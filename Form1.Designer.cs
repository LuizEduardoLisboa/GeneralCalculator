namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnnove = new Button();
            btnmenos = new Button();
            btnmais = new Button();
            btnseis = new Button();
            btnsete = new Button();
            btnoito = new Button();
            btntres = new Button();
            btnquatro = new Button();
            btncinco = new Button();
            btnresultado = new Button();
            btnzero = new Button();
            btnum = new Button();
            btndois = new Button();
            btndivisao = new Button();
            btnmultiplicacao = new Button();
            btnlimpar = new Button();
            txtresultado = new TextBox();
            button1 = new Button();
            btnponto = new Button();
            lbloperacao = new Label();
            btnsair = new Button();
            SuspendLayout();
            // 
            // btnnove
            // 
            btnnove.BackColor = SystemColors.ActiveCaptionText;
            btnnove.ForeColor = SystemColors.ControlLightLight;
            btnnove.Location = new Point(168, 141);
            btnnove.Name = "btnnove";
            btnnove.Size = new Size(56, 56);
            btnnove.TabIndex = 2;
            btnnove.Text = "9";
            btnnove.UseVisualStyleBackColor = false;
            btnnove.Click += btnnove_Click;
            // 
            // btnmenos
            // 
            btnmenos.BackColor = SystemColors.ActiveCaptionText;
            btnmenos.ForeColor = Color.FromArgb(0, 192, 0);
            btnmenos.Location = new Point(230, 141);
            btnmenos.Name = "btnmenos";
            btnmenos.Size = new Size(56, 56);
            btnmenos.TabIndex = 3;
            btnmenos.Text = "-";
            btnmenos.UseVisualStyleBackColor = false;
            btnmenos.Click += btnmenos_Click;
            // 
            // btnmais
            // 
            btnmais.BackColor = SystemColors.ActiveCaptionText;
            btnmais.ForeColor = Color.FromArgb(0, 192, 0);
            btnmais.Location = new Point(230, 203);
            btnmais.Name = "btnmais";
            btnmais.Size = new Size(56, 56);
            btnmais.TabIndex = 7;
            btnmais.Text = "+";
            btnmais.UseVisualStyleBackColor = false;
            btnmais.Click += btnmais_Click;
            // 
            // btnseis
            // 
            btnseis.BackColor = SystemColors.ActiveCaptionText;
            btnseis.ForeColor = SystemColors.ControlLightLight;
            btnseis.Location = new Point(168, 203);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(56, 56);
            btnseis.TabIndex = 6;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = false;
            btnseis.Click += btnseis_Click;
            // 
            // btnsete
            // 
            btnsete.BackColor = SystemColors.ActiveCaptionText;
            btnsete.ForeColor = SystemColors.ControlLightLight;
            btnsete.Location = new Point(44, 141);
            btnsete.Name = "btnsete";
            btnsete.Size = new Size(56, 56);
            btnsete.TabIndex = 5;
            btnsete.Text = "7";
            btnsete.UseVisualStyleBackColor = false;
            btnsete.Click += btnsete_Click;
            // 
            // btnoito
            // 
            btnoito.BackColor = SystemColors.ActiveCaptionText;
            btnoito.ForeColor = SystemColors.ControlLightLight;
            btnoito.Location = new Point(106, 141);
            btnoito.Name = "btnoito";
            btnoito.Size = new Size(56, 56);
            btnoito.TabIndex = 4;
            btnoito.Text = "8";
            btnoito.UseVisualStyleBackColor = false;
            btnoito.Click += btnoito_Click;
            // 
            // btntres
            // 
            btntres.BackColor = SystemColors.ActiveCaptionText;
            btntres.ForeColor = SystemColors.ControlLightLight;
            btntres.Location = new Point(168, 265);
            btntres.Name = "btntres";
            btntres.Size = new Size(56, 56);
            btntres.TabIndex = 10;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = false;
            btntres.Click += btntres_Click;
            // 
            // btnquatro
            // 
            btnquatro.BackColor = SystemColors.ActiveCaptionText;
            btnquatro.ForeColor = SystemColors.ControlLightLight;
            btnquatro.Location = new Point(44, 203);
            btnquatro.Name = "btnquatro";
            btnquatro.Size = new Size(56, 56);
            btnquatro.TabIndex = 9;
            btnquatro.Text = "4";
            btnquatro.UseVisualStyleBackColor = false;
            btnquatro.Click += btnquatro_Click;
            // 
            // btncinco
            // 
            btncinco.BackColor = SystemColors.ActiveCaptionText;
            btncinco.ForeColor = SystemColors.ControlLightLight;
            btncinco.Location = new Point(106, 203);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(56, 56);
            btncinco.TabIndex = 8;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = false;
            btncinco.Click += btncinco_Click;
            // 
            // btnresultado
            // 
            btnresultado.BackColor = SystemColors.ActiveCaptionText;
            btnresultado.ForeColor = Color.FromArgb(0, 192, 0);
            btnresultado.Location = new Point(230, 265);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(56, 118);
            btnresultado.TabIndex = 15;
            btnresultado.Text = "=";
            btnresultado.UseVisualStyleBackColor = false;
            btnresultado.Click += button13_Click;
            // 
            // btnzero
            // 
            btnzero.BackColor = SystemColors.ActiveCaptionText;
            btnzero.ForeColor = SystemColors.ControlLightLight;
            btnzero.Location = new Point(44, 327);
            btnzero.Name = "btnzero";
            btnzero.Size = new Size(118, 56);
            btnzero.TabIndex = 14;
            btnzero.Text = "0";
            btnzero.UseVisualStyleBackColor = false;
            btnzero.Click += btnzero_Click;
            // 
            // btnum
            // 
            btnum.BackColor = SystemColors.ActiveCaptionText;
            btnum.ForeColor = SystemColors.ControlLightLight;
            btnum.Location = new Point(44, 265);
            btnum.Name = "btnum";
            btnum.Size = new Size(56, 56);
            btnum.TabIndex = 13;
            btnum.Text = "1";
            btnum.UseVisualStyleBackColor = false;
            btnum.Click += btnum_Click;
            // 
            // btndois
            // 
            btndois.BackColor = SystemColors.ActiveCaptionText;
            btndois.ForeColor = SystemColors.ControlLightLight;
            btndois.Location = new Point(106, 265);
            btndois.Name = "btndois";
            btndois.Size = new Size(56, 56);
            btndois.TabIndex = 12;
            btndois.Text = "2";
            btndois.UseVisualStyleBackColor = false;
            btndois.Click += btndois_Click;
            // 
            // btndivisao
            // 
            btndivisao.BackColor = SystemColors.ActiveCaptionText;
            btndivisao.ForeColor = Color.FromArgb(0, 192, 0);
            btndivisao.Location = new Point(230, 79);
            btndivisao.Name = "btndivisao";
            btndivisao.Size = new Size(56, 56);
            btndivisao.TabIndex = 19;
            btndivisao.Text = "/";
            btndivisao.UseVisualStyleBackColor = false;
            btndivisao.Click += btndivisao_Click;
            // 
            // btnmultiplicacao
            // 
            btnmultiplicacao.BackColor = SystemColors.ActiveCaptionText;
            btnmultiplicacao.ForeColor = Color.FromArgb(0, 192, 0);
            btnmultiplicacao.Location = new Point(168, 79);
            btnmultiplicacao.Name = "btnmultiplicacao";
            btnmultiplicacao.Size = new Size(56, 56);
            btnmultiplicacao.TabIndex = 18;
            btnmultiplicacao.Text = "X";
            btnmultiplicacao.UseVisualStyleBackColor = false;
            btnmultiplicacao.Click += btnmultiplicacao_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = SystemColors.ActiveCaptionText;
            btnlimpar.ForeColor = Color.FromArgb(0, 192, 0);
            btnlimpar.Location = new Point(168, 327);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(56, 56);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "C";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(44, 32);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(242, 23);
            txtresultado.TabIndex = 20;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(44, 79);
            button1.Name = "button1";
            button1.Size = new Size(56, 56);
            button1.TabIndex = 21;
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnponto
            // 
            btnponto.BackColor = SystemColors.ActiveCaptionText;
            btnponto.ForeColor = Color.FromArgb(0, 192, 0);
            btnponto.Location = new Point(106, 79);
            btnponto.Name = "btnponto";
            btnponto.Size = new Size(56, 56);
            btnponto.TabIndex = 22;
            btnponto.Text = ".";
            btnponto.UseVisualStyleBackColor = false;
            btnponto.Click += btnponto_Click;
            // 
            // lbloperacao
            // 
            lbloperacao.AutoSize = true;
            lbloperacao.Location = new Point(66, 35);
            lbloperacao.Name = "lbloperacao";
            lbloperacao.Size = new Size(0, 15);
            lbloperacao.TabIndex = 23;
            // 
            // btnsair
            // 
            btnsair.BackColor = SystemColors.InactiveCaptionText;
            btnsair.Location = new Point(44, 402);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(118, 36);
            btnsair.TabIndex = 24;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(329, 450);
            Controls.Add(btnsair);
            Controls.Add(lbloperacao);
            Controls.Add(btnponto);
            Controls.Add(button1);
            Controls.Add(txtresultado);
            Controls.Add(btndivisao);
            Controls.Add(btnmultiplicacao);
            Controls.Add(btnlimpar);
            Controls.Add(btnresultado);
            Controls.Add(btnzero);
            Controls.Add(btnum);
            Controls.Add(btndois);
            Controls.Add(btntres);
            Controls.Add(btnquatro);
            Controls.Add(btncinco);
            Controls.Add(btnmais);
            Controls.Add(btnseis);
            Controls.Add(btnsete);
            Controls.Add(btnoito);
            Controls.Add(btnmenos);
            Controls.Add(btnnove);
            ForeColor = Color.FromArgb(0, 192, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnnove;
        private Button btnmenos;
        private Button btnmais;
        private Button btnseis;
        private Button btnsete;
        private Button btnoito;
        private Button btntres;
        private Button btnquatro;
        private Button btncinco;
        private Button btnresultado;
        private Button btnzero;
        private Button btnum;
        private Button btndois;
        private Button btndivisao;
        private Button btnmultiplicacao;
        private Button btnlimpar;
        private TextBox txtresultado;
        private Button button1;
        private Button btnponto;
        private Label lbloperacao;
        private Button btnsair;
    }
}