namespace DemoDirectPin
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.nudWriteTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudReadTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPortasCOM = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudValorTransacao = new System.Windows.Forms.NumericUpDown();
            this.btnEnviarPagamento = new System.Windows.Forms.Button();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.chkPreAutorizacao = new System.Windows.Forms.CheckBox();
            this.chkDigitado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbParceladoPor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbParcelado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoTransacao = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNSU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnviarEstorno = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbRespostas = new System.Windows.Forms.RichTextBox();
            this.btnLimparRespostas = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriteTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadTimeOut)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorTransacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdParcelas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.nudWriteTimeOut);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.nudReadTimeOut);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbEncoding);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbStopBits);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPortasCOM);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(370, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 23);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Write Timeout";
            // 
            // nudWriteTimeOut
            // 
            this.nudWriteTimeOut.Location = new System.Drawing.Point(191, 129);
            this.nudWriteTimeOut.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudWriteTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWriteTimeOut.Name = "nudWriteTimeOut";
            this.nudWriteTimeOut.Size = new System.Drawing.Size(70, 20);
            this.nudWriteTimeOut.TabIndex = 49;
            this.nudWriteTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWriteTimeOut.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Read Timeout";
            // 
            // nudReadTimeOut
            // 
            this.nudReadTimeOut.Location = new System.Drawing.Point(115, 129);
            this.nudReadTimeOut.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudReadTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReadTimeOut.Name = "nudReadTimeOut";
            this.nudReadTimeOut.Size = new System.Drawing.Size(70, 20);
            this.nudReadTimeOut.TabIndex = 47;
            this.nudReadTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudReadTimeOut.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Encoding";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(6, 129);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(103, 21);
            this.cmbEncoding.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "StopBits";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(353, 79);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(94, 21);
            this.cmbStopBits.TabIndex = 43;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(287, 126);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 23);
            this.btnOpen.TabIndex = 42;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Parity";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(240, 79);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(107, 21);
            this.cmbParity.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "DataBits";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(123, 79);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(111, 21);
            this.cmbDataBits.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "BaudRate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(6, 79);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(111, 21);
            this.cmbBaudRate.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PortaCOM";
            // 
            // cmbPortasCOM
            // 
            this.cmbPortasCOM.FormattingEnabled = true;
            this.cmbPortasCOM.Location = new System.Drawing.Point(6, 35);
            this.cmbPortasCOM.Name = "cmbPortasCOM";
            this.cmbPortasCOM.Size = new System.Drawing.Size(441, 21);
            this.cmbPortasCOM.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudValorTransacao);
            this.groupBox2.Controls.Add(this.btnEnviarPagamento);
            this.groupBox2.Controls.Add(this.chkImprimir);
            this.groupBox2.Controls.Add(this.chkPreAutorizacao);
            this.groupBox2.Controls.Add(this.chkDigitado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbParceladoPor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudQtdParcelas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbParcelado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbTipoTransacao);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transação de Pagamento";
            // 
            // nudValorTransacao
            // 
            this.nudValorTransacao.Location = new System.Drawing.Point(9, 89);
            this.nudValorTransacao.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudValorTransacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValorTransacao.Name = "nudValorTransacao";
            this.nudValorTransacao.Size = new System.Drawing.Size(91, 20);
            this.nudValorTransacao.TabIndex = 50;
            this.nudValorTransacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudValorTransacao.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnEnviarPagamento
            // 
            this.btnEnviarPagamento.Location = new System.Drawing.Point(309, 86);
            this.btnEnviarPagamento.Name = "btnEnviarPagamento";
            this.btnEnviarPagamento.Size = new System.Drawing.Size(138, 23);
            this.btnEnviarPagamento.TabIndex = 45;
            this.btnEnviarPagamento.Text = "Enviar Pagamento";
            this.btnEnviarPagamento.UseVisualStyleBackColor = true;
            this.btnEnviarPagamento.Click += new System.EventHandler(this.btnEnviarPagamento_Click);
            // 
            // chkImprimir
            // 
            this.chkImprimir.AutoSize = true;
            this.chkImprimir.Location = new System.Drawing.Point(230, 90);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(61, 17);
            this.chkImprimir.TabIndex = 44;
            this.chkImprimir.Text = "Imprimir";
            this.chkImprimir.UseVisualStyleBackColor = true;
            // 
            // chkPreAutorizacao
            // 
            this.chkPreAutorizacao.AutoSize = true;
            this.chkPreAutorizacao.Location = new System.Drawing.Point(123, 92);
            this.chkPreAutorizacao.Name = "chkPreAutorizacao";
            this.chkPreAutorizacao.Size = new System.Drawing.Size(101, 17);
            this.chkPreAutorizacao.TabIndex = 43;
            this.chkPreAutorizacao.Text = "Pré-Autorização";
            this.chkPreAutorizacao.UseVisualStyleBackColor = true;
            // 
            // chkDigitado
            // 
            this.chkDigitado.AutoSize = true;
            this.chkDigitado.Location = new System.Drawing.Point(123, 73);
            this.chkDigitado.Name = "chkDigitado";
            this.chkDigitado.Size = new System.Drawing.Size(65, 17);
            this.chkDigitado.TabIndex = 42;
            this.chkDigitado.Text = "Digitado";
            this.chkDigitado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Valor da Transação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Parcelado Por";
            // 
            // cmbParceladoPor
            // 
            this.cmbParceladoPor.FormattingEnabled = true;
            this.cmbParceladoPor.Location = new System.Drawing.Point(309, 42);
            this.cmbParceladoPor.Name = "cmbParceladoPor";
            this.cmbParceladoPor.Size = new System.Drawing.Size(138, 21);
            this.cmbParceladoPor.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Parcelas";
            // 
            // nudQtdParcelas
            // 
            this.nudQtdParcelas.Location = new System.Drawing.Point(250, 43);
            this.nudQtdParcelas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQtdParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdParcelas.Name = "nudQtdParcelas";
            this.nudQtdParcelas.Size = new System.Drawing.Size(53, 20);
            this.nudQtdParcelas.TabIndex = 36;
            this.nudQtdParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQtdParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parcelado ?";
            // 
            // cmbParcelado
            // 
            this.cmbParcelado.FormattingEnabled = true;
            this.cmbParcelado.Location = new System.Drawing.Point(106, 42);
            this.cmbParcelado.Name = "cmbParcelado";
            this.cmbParcelado.Size = new System.Drawing.Size(138, 21);
            this.cmbParcelado.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Transação";
            // 
            // cmbTipoTransacao
            // 
            this.cmbTipoTransacao.FormattingEnabled = true;
            this.cmbTipoTransacao.Location = new System.Drawing.Point(6, 42);
            this.cmbTipoTransacao.Name = "cmbTipoTransacao";
            this.cmbTipoTransacao.Size = new System.Drawing.Size(94, 21);
            this.cmbTipoTransacao.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNSU);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnEnviarEstorno);
            this.groupBox3.Location = new System.Drawing.Point(12, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estorno do Pagamento";
            // 
            // txtNSU
            // 
            this.txtNSU.Location = new System.Drawing.Point(6, 37);
            this.txtNSU.Name = "txtNSU";
            this.txtNSU.Size = new System.Drawing.Size(297, 20);
            this.txtNSU.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "NSU";
            // 
            // btnEnviarEstorno
            // 
            this.btnEnviarEstorno.Location = new System.Drawing.Point(309, 35);
            this.btnEnviarEstorno.Name = "btnEnviarEstorno";
            this.btnEnviarEstorno.Size = new System.Drawing.Size(138, 23);
            this.btnEnviarEstorno.TabIndex = 45;
            this.btnEnviarEstorno.Text = "Enviar Estorno";
            this.btnEnviarEstorno.UseVisualStyleBackColor = true;
            this.btnEnviarEstorno.Click += new System.EventHandler(this.btnEnviarEstorno_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbRespostas);
            this.groupBox4.Location = new System.Drawing.Point(475, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 331);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Respostas";
            // 
            // rtbRespostas
            // 
            this.rtbRespostas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRespostas.Location = new System.Drawing.Point(3, 16);
            this.rtbRespostas.Name = "rtbRespostas";
            this.rtbRespostas.Size = new System.Drawing.Size(419, 312);
            this.rtbRespostas.TabIndex = 3;
            this.rtbRespostas.Text = "";
            // 
            // btnLimparRespostas
            // 
            this.btnLimparRespostas.Location = new System.Drawing.Point(761, 349);
            this.btnLimparRespostas.Name = "btnLimparRespostas";
            this.btnLimparRespostas.Size = new System.Drawing.Size(139, 23);
            this.btnLimparRespostas.TabIndex = 32;
            this.btnLimparRespostas.Text = "Limpar Respostas";
            this.btnLimparRespostas.UseVisualStyleBackColor = true;
            this.btnLimparRespostas.Click += new System.EventHandler(this.btnLimparRespostas_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(475, 349);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(139, 23);
            this.btnAbort.TabIndex = 33;
            this.btnAbort.Text = "Abortar Transação";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 381);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnLimparRespostas);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Exemplo DirectPin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriteTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadTimeOut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorTransacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdParcelas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPortasCOM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQtdParcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbParcelado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoTransacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbParceladoPor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkPreAutorizacao;
        private System.Windows.Forms.CheckBox chkDigitado;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.Button btnEnviarPagamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNSU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviarEstorno;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbRespostas;
        private System.Windows.Forms.Button btnLimparRespostas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudWriteTimeOut;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudReadTimeOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nudValorTransacao;
        private System.Windows.Forms.Button btnAbort;
    }
}

