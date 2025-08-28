
using DirectPin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDirectPin
{
    public partial class FrmMain : Form
    {
        private SerialPort _serialPort;
        private string _logFilePath;

        public FrmMain()
        {
            InitializeComponent();
            InicializarInterface();
            InicializarLog();
        }

        private void InicializarInterface()
        {
            cmbTipoTransacao.Items.Clear();
            foreach (DpTypeTransaction val in Enum.GetValues(typeof(DpTypeTransaction)))
                cmbTipoTransacao.Items.Add(val.ToString());
            cmbTipoTransacao.SelectedIndex = 2;

            cmbParcelado.Items.Clear();
            foreach (DpCreditType val in Enum.GetValues(typeof(DpCreditType)))
                cmbParcelado.Items.Add(val.ToString());
            cmbParcelado.SelectedIndex = 0;

            cmbParceladoPor.Items.Clear();
            foreach (DpInterestType val in Enum.GetValues(typeof(DpInterestType)))
                cmbParceladoPor.Items.Add(val.ToString());
            cmbParceladoPor.SelectedIndex = 0;


            //Configurações COM
            cmbPortasCOM.Items.Clear();
            cmbPortasCOM.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPortasCOM.Items.Count > 0)
                cmbPortasCOM.SelectedIndex = 0;

            // BaudRate
            cmbBaudRate.Items.Clear();
            cmbBaudRate.Items.AddRange(new object[] {
                "75", "110", "300", "600", "1200", "2400", "4800",
                "9600", "14400", "19200", "38400", "57600",
                "115200", "128000", "256000"
                });
            cmbBaudRate.SelectedItem = "115200";

            // DataBits
            cmbDataBits.Items.Clear();
            cmbDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            cmbDataBits.SelectedItem = "8";

            // Parity
            cmbParity.Items.Clear();
            cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbParity.SelectedItem = Parity.None.ToString();

            // StopBits
            cmbStopBits.Items.Clear();
            cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            cmbStopBits.SelectedItem = StopBits.One.ToString();

            // Encoding
            cmbEncoding.Items.Clear();
            cmbEncoding.Items.AddRange(new object[] {
                "ASCII", "UTF8", "Unicode", "UTF32", "ISO-8859-1"
                });
            cmbEncoding.SelectedItem = "UTF8";
        }

        private void InicializarLog()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"directpin_log_{timestamp}.txt");
            File.WriteAllText(_logFilePath, $"=== Direct PIN Log ===\nTimestamp: {timestamp}\n\n");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string portaSelecionada = cmbPortasCOM.Text;
                int baudRate = int.Parse(cmbBaudRate.Text);
                int dataBits = int.Parse(cmbDataBits.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                StopBits stopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);

                Encoding encoding;
                switch (cmbEncoding.Text)
                {
                    case "ASCII":
                        encoding = Encoding.ASCII;
                        break;
                    case "UTF8":
                        encoding = Encoding.UTF8;
                        break;
                    case "Unicode":
                        encoding = Encoding.Unicode;
                        break;
                    case "UTF32":
                        encoding = Encoding.UTF32;
                        break;
                    case "ISO-8859-1":
                        encoding = Encoding.GetEncoding("ISO-8859-1");
                        break;
                    default:
                        encoding = Encoding.UTF8;
                        break;
                }

                int readTimeout = (int)nudReadTimeOut.Value;
                int writeTimeout = (int)nudWriteTimeOut.Value;

                _serialPort = new SerialPort
                {
                    PortName = portaSelecionada,
                    BaudRate = baudRate,
                    DataBits = dataBits,
                    Parity = parity,
                    StopBits = stopBits,
                    Encoding = encoding,
                    ReadTimeout = readTimeout,
                    WriteTimeout = writeTimeout,
                };

                // Verifica o que esta sendo enviado para a PortaCOM
                // _serialPort.DataReceived += _serialPort_DataReceived;

                _serialPort.Open();
                MessageBox.Show("Porta aberta com sucesso!", "Sucesso", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir porta serial: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                _serialPort.Close();
        }

        private async void btnEnviarPagamento_Click(object sender, EventArgs e)
        {
            Log("-- Enviar Transação Pagamento --");

            if (_serialPort == null || !_serialPort.IsOpen)
            {
                Log("Porta serial não está aberta.");
                return;
            }

            try
            {
                var request = new DpPayloadRequestTransaction
                {
                    Type = "transaction",
                    Amount = (int)nudValorTransacao.Value,
                    TypeTransaction = cmbTipoTransacao.Text,
                    CreditType = cmbParcelado.Text,
                    Installment = (int)nudQtdParcelas.Value,
                    IsTyped = chkDigitado.Checked,
                    IsPreAuth = chkPreAutorizacao.Checked, 
                    InterestType = cmbParceladoPor.Text,
                    PrintReceipt = chkImprimir.Checked
                };

                string payload = JsonSerializer.Serialize(request);
                Log("- Payload JSON -");
                Log(payload);

                string base64 = Utils.ToBase64(payload);
                ushort crc = Utils.StringCrcCCITT(base64);
                byte crcHigh = (byte)((crc >> 8) & 0xFF);
                byte crcLow = (byte)(crc & 0xFF);

                byte SYN = 0x16;
                byte ETB = 0x17;

                List<byte> messageBytes = new List<byte>();
                messageBytes.Add(SYN);
                messageBytes.AddRange(Encoding.ASCII.GetBytes(base64));
                messageBytes.Add(crcHigh);
                messageBytes.Add(crcLow);
                messageBytes.Add(ETB);

                _serialPort.Write(messageBytes.ToArray(), 0, messageBytes.Count);

                string resposta = await LerRespostaSerialAsync(90000);
                if (string.IsNullOrWhiteSpace(resposta))
                {
                    Log("Nenhuma resposta válida recebida.");
                    return;
                }

                Log("Resposta recebida:");
                Log(resposta);

                string jsonResp;
                try
                {
                    var dpMessage = new DpSerialMessage();
                    dpMessage.SetMessage(resposta);
                    jsonResp = dpMessage.PayLoad;
                }
                catch (Exception ex)
                {
                    Log("Erro ao decodificar mensagem com SetMessage: " + ex.Message);
                    jsonResp = ExtrairBase64Manual(resposta);
                    if (string.IsNullOrEmpty(jsonResp)) return;
                }

                var resTrans = new DpPayloadResponseTransaction();
                resTrans.FromJson(jsonResp);

                Log("-- Dados da Resposta da Transação --");
                Log("Result: " + resTrans.Result);
                Log("Message: " + resTrans.Message);
                Log("Amount: " + resTrans.Amount);
                Log("NSU: " + resTrans.Nsu);
                Log("NSU Acquirer: " + resTrans.NsuAcquirer);
                Log("PAN Masked: " + resTrans.PanMasked);
                Log("Date: " + DateTimeOffset.FromUnixTimeMilliseconds(resTrans.Date).ToString("dd/MM/yy HH:mm:ss"));
                Log("Type Card: " + resTrans.TypeCard);
                Log("Final Result: " + resTrans.FinalResult);
                Log("Code Result: " + resTrans.CodeResult);
                Log("- Receipt Content -");
                Log(resTrans.ReceiptContent.Replace("@", Environment.NewLine));

                txtNSU.Text = resTrans.Nsu;
            }
            catch (Exception ex)
            {
                Log("Erro geral: " + ex.Message);
            }
        }

        private async void btnEnviarEstorno_Click(object sender, EventArgs e)
        {
            Log("-- Enviar Estorno --");

            if (_serialPort == null || !_serialPort.IsOpen)
            {
                Log("Porta serial não está aberta.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNSU.Text))
            {
                Log("NSU da transação a ser estornada não informado.");
                return;
            }

            try
            {
                var request = new DpPayloadRequestReversal
                {
                    Nsu = txtNSU.Text
                };

                string payload = JsonSerializer.Serialize(request);
                Log("- Payload JSON -");
                Log(payload);

                string base64 = Utils.ToBase64(payload);
                ushort crc = Utils.StringCrcCCITT(base64);
                byte crcHigh = (byte)((crc >> 8) & 0xFF);
                byte crcLow = (byte)(crc & 0xFF);

                byte SYN = 0x16;
                byte ETB = 0x17;

                List<byte> messageBytes = new List<byte>();
                messageBytes.Add(SYN);
                messageBytes.AddRange(Encoding.ASCII.GetBytes(base64));
                messageBytes.Add(crcHigh);
                messageBytes.Add(crcLow);
                messageBytes.Add(ETB);

                _serialPort.Write(messageBytes.ToArray(), 0, messageBytes.Count);

                string resposta = await LerRespostaSerialAsync(90000);
                if (string.IsNullOrWhiteSpace(resposta))
                {
                    Log("Nenhuma resposta válida recebida.");
                    return;
                }

                Log("Resposta recebida:");
                Log(resposta);

                string jsonResp;
                try
                {
                    var dpMessage = new DpSerialMessage();
                    dpMessage.SetMessage(resposta);
                    jsonResp = dpMessage.PayLoad;
                }
                catch (Exception ex)
                {
                    Log("Erro ao decodificar mensagem com SetMessage: " + ex.Message);
                    jsonResp = ExtrairBase64Manual(resposta);
                    if (string.IsNullOrEmpty(jsonResp)) return;
                }

                var resRev = new DpPayloadResponseReversal();
                resRev.FromJson(jsonResp);

                Log("-- Dados da Resposta do Estorno --");
                Log("Result: " + resRev.Result);
                Log("Message: " + resRev.Message);
                Log("- Receipt Content -");
                Log(resRev.ReceiptContent.Replace("@", Environment.NewLine));
            }
            catch (Exception ex)
            {
                Log("Erro geral: " + ex.Message);
            }
        }

        private async void btnAbort_Click(object sender, EventArgs e)
        {
            Log("-- Abortar Transação --");

            if (_serialPort == null || !_serialPort.IsOpen)
            {
                Log("Porta serial não está aberta.");
                return;
            }

            try
            {
                var request = new DpPayloadRequestAbort();
                {
                    request.Type = "abort";
                }

                string payload = JsonSerializer.Serialize(request);
                Log("- Payload JSON -");
                Log(payload);

                string base64 = Utils.ToBase64(payload);
                ushort crc = Utils.StringCrcCCITT(base64);
                byte crcHigh = (byte)((crc >> 8) & 0xFF);
                byte crcLow = (byte)(crc & 0xFF);

                byte SYN = 0x16;
                byte ETB = 0x17;

                List<byte> messageBytes = new List<byte>();
                messageBytes.Add(SYN);
                messageBytes.AddRange(Encoding.ASCII.GetBytes(base64));
                messageBytes.Add(crcHigh);
                messageBytes.Add(crcLow);
                messageBytes.Add(ETB);

                _serialPort.Write(messageBytes.ToArray(), 0, messageBytes.Count);
            }
            catch (Exception ex)
            {
                Log("Erro geral: " + ex.Message);
            }

        }

        private void btnLimparRespostas_Click(object sender, EventArgs e)
        {
            rtbRespostas.Clear();
        }

        private string ExtrairBase64Manual(string resposta)
        {
            try
            {
                byte[] rawBytes = Encoding.ASCII.GetBytes(resposta);
                int startIndex = Array.IndexOf(rawBytes, (byte)0x16);
                int endIndex = Array.IndexOf(rawBytes, (byte)0x17);

                if (startIndex >= 0 && endIndex > startIndex + 3)
                {
                    int base64Length = endIndex - startIndex - 3;
                    byte[] base64Bytes = rawBytes.Skip(startIndex + 1).Take(base64Length).ToArray();
                    string base64String = Encoding.ASCII.GetString(base64Bytes);

                    // Log antes da decodificação
                    Log("Base64 extraído manualmente:");
                    Log(base64String);

                    string json = Utils.FromBase64(base64String);

                    // Log depois da decodificação
                    Log("JSON decodificado:");
                    Log(json);

                    return json;
                }
                else
                {
                    Log("Não foi possível localizar delimitadores SYN/ETB corretamente.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Log("Erro ao extrair base64 manualmente: " + ex.Message);
                return string.Empty;
            }
        }

        private async Task<string> LerRespostaSerialAsync(int timeoutMs = 90000)
        {
            return await Task.Run(async () =>
            {
                var buffer = new List<byte>();
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                try
                {
                    int b = _serialPort.ReadByte();
                    Log($"  ret: {b}");

                    if (b == DpSerialMessage.NAK)
                    {
                        Log("  NAK - comando inválido");
                        return string.Empty;
                    }
                    else if (b != DpSerialMessage.ACK)
                    {
                        Log("  Erro na resposta");
                        return string.Empty;
                    }

                    Log("  ACK - comando ok");

                    bool etbRecebido = false;

                    while (stopwatch.ElapsedMilliseconds < timeoutMs)
                    {
                        while (_serialPort.BytesToRead > 0)
                        {
                            int byteLido = _serialPort.ReadByte();
                            buffer.Add((byte)byteLido);

                            //Leitura de todos os Bytes Recebidos
                            //Log($"  Byte recebido: 0x{byteLido:X2}");

                            if (byteLido == DpSerialMessage.ETB)
                            {
                                etbRecebido = true;
                                break;
                            }
                        }

                        if (etbRecebido)
                            break;

                        await Task.Delay(50);
                    }

                    if (!etbRecebido)
                    {
                        Log("  Timeout atingido sem receber ETB.");
                        return string.Empty;
                    }

                    if (buffer.Count == 0 || buffer[0] != DpSerialMessage.SYN)
                    {
                        Log("  Mensagem recebida não começa com SYN.");
                        return string.Empty;
                    }

                    string resposta = Encoding.ASCII.GetString(buffer.ToArray());
                    Log("  Mensagem completa:");
                    Log(resposta);
                    return resposta;
                }
                catch (Exception ex)
                {
                    Log("Erro ao ler da porta serial: " + ex.Message);
                }

                return string.Empty;
            });
        }

        private void Log(string texto)
        {
            rtbRespostas.AppendText(texto + Environment.NewLine);
            File.AppendAllText(_logFilePath, texto + Environment.NewLine);
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadExisting();
                Invoke(new Action(() =>
                {
                    rtbRespostas.AppendText($"Recebido: {data}{Environment.NewLine}");
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    rtbRespostas.AppendText($"Erro ao ler dados: {ex.Message}{Environment.NewLine}");
                }));
            }
        }
    }
}
