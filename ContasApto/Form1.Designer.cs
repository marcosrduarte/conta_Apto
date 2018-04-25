namespace ContasApto
{
    partial class frmPrincipal
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
            this.txtAluguel = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.lblAluguel = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblOutros = new System.Windows.Forms.Label();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOAplicativoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQtdmoradores = new System.Windows.Forms.Label();
            this.cmbMoradores = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAluguel
            // 
            this.txtAluguel.Location = new System.Drawing.Point(116, 130);
            this.txtAluguel.Name = "txtAluguel";
            this.txtAluguel.Size = new System.Drawing.Size(157, 22);
            this.txtAluguel.TabIndex = 1;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(116, 438);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(157, 22);
            this.txtNet.TabIndex = 5;
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(116, 361);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(157, 22);
            this.txtGas.TabIndex = 4;
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(116, 284);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(157, 22);
            this.txtEnergia.TabIndex = 3;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(116, 207);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(157, 22);
            this.txtCondominio.TabIndex = 2;
            // 
            // lblAluguel
            // 
            this.lblAluguel.AutoSize = true;
            this.lblAluguel.Location = new System.Drawing.Point(113, 110);
            this.lblAluguel.Name = "lblAluguel";
            this.lblAluguel.Size = new System.Drawing.Size(55, 17);
            this.lblAluguel.TabIndex = 5;
            this.lblAluguel.Text = "Aluguel";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(113, 187);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(82, 17);
            this.lblCondominio.TabIndex = 6;
            this.lblCondominio.Text = "Condominio";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(113, 264);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(118, 17);
            this.lblEnergia.TabIndex = 7;
            this.lblEnergia.Text = "Conta de Energia";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Location = new System.Drawing.Point(113, 341);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(95, 17);
            this.lblGas.TabIndex = 8;
            this.lblGas.Text = "Conta de Gás";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(113, 418);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(191, 17);
            this.lblNet.TabIndex = 9;
            this.lblNet.Text = "Contas de Internet e telefone";
            // 
            // lblOutros
            // 
            this.lblOutros.AutoSize = true;
            this.lblOutros.Location = new System.Drawing.Point(113, 495);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(118, 17);
            this.lblOutros.TabIndex = 10;
            this.lblOutros.Text = "Outras Despesas";
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(116, 515);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(157, 22);
            this.txtOutros.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(143, 556);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 28);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagarToolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.sobreOAplicativoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apagarToolStripMenuItem1
            // 
            this.apagarToolStripMenuItem1.Name = "apagarToolStripMenuItem1";
            this.apagarToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.apagarToolStripMenuItem1.Text = "Limpar";
            this.apagarToolStripMenuItem1.Click += new System.EventHandler(this.apagarToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.sobreToolStripMenuItem.Text = "Sobre o Autor";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sobreOAplicativoToolStripMenuItem1
            // 
            this.sobreOAplicativoToolStripMenuItem1.Name = "sobreOAplicativoToolStripMenuItem1";
            this.sobreOAplicativoToolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.sobreOAplicativoToolStripMenuItem1.Text = "Sobre o Aplicativo";
            this.sobreOAplicativoToolStripMenuItem1.Click += new System.EventHandler(this.sobreOAplicativoToolStripMenuItem1_Click);
            // 
            // lblQtdmoradores
            // 
            this.lblQtdmoradores.AutoSize = true;
            this.lblQtdmoradores.Location = new System.Drawing.Point(32, 51);
            this.lblQtdmoradores.Name = "lblQtdmoradores";
            this.lblQtdmoradores.Size = new System.Drawing.Size(174, 17);
            this.lblQtdmoradores.TabIndex = 21;
            this.lblQtdmoradores.Text = "Quantidade de Moradores";
            // 
            // cmbMoradores
            // 
            this.cmbMoradores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoradores.FormattingEnabled = true;
            this.cmbMoradores.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbMoradores.Location = new System.Drawing.Point(35, 71);
            this.cmbMoradores.Name = "cmbMoradores";
            this.cmbMoradores.Size = new System.Drawing.Size(46, 24);
            this.cmbMoradores.TabIndex = 22;
            this.cmbMoradores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(383, 602);
            this.Controls.Add(this.cmbMoradores);
            this.Controls.Add(this.lblQtdmoradores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.lblOutros);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblEnergia);
            this.Controls.Add(this.lblCondominio);
            this.Controls.Add(this.lblAluguel);
            this.Controls.Add(this.txtCondominio);
            this.Controls.Add(this.txtEnergia);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtAluguel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Rateio de Despesas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAluguel;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.Label lblAluguel;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblOutros;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem1;
        private System.Windows.Forms.Label lblQtdmoradores;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOAplicativoToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cmbMoradores;
    }
}

