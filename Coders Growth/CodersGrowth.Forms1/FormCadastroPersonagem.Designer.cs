
namespace CodersGrowth.Forms1
{
    partial class FormCadastroPersonagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBoxNomeU = new TextBox();
            linkLabel1 = new LinkLabel();
            comboBoxNome = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBoxAtq = new TextBox();
            textBoxRE = new TextBox();
            textBoxHP = new TextBox();
            textBoxPE = new TextBox();
            textBoxDef = new TextBox();
            textBoxConst = new TextBox();
            textBoxDC = new TextBox();
            comboBoxArma = new ComboBox();
            comboBoxElemento = new ComboBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            textBox26 = new TextBox();
            textBoxBE = new TextBox();
            textBoxTC = new TextBox();
            textBoxCura = new TextBox();
            textBoxShield = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Gabriola", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(199, -3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(396, 82);
            textBox1.TabIndex = 0;
            textBox1.Text = "Cadastro de Personagem";
            // 
            // textBoxNomeU
            // 
            textBoxNomeU.Anchor = AnchorStyles.None;
            textBoxNomeU.Location = new Point(73, 394);
            textBoxNomeU.Name = "textBoxNomeU";
            textBoxNomeU.Size = new Size(156, 23);
            textBoxNomeU.TabIndex = 1;
            textBoxNomeU.KeyPress += aoDigitarValorInvalidoEmNomeUsuario;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(73, 420);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Não tem conta? Cadastre-se";
            linkLabel1.LinkClicked += aoClicarEmCadastrarUsuario;
            // 
            // comboBoxNome
            // 
            comboBoxNome.Anchor = AnchorStyles.None;
            comboBoxNome.FormattingEnabled = true;
            comboBoxNome.Location = new Point(73, 134);
            comboBoxNome.Name = "comboBoxNome";
            comboBoxNome.Size = new Size(156, 23);
            comboBoxNome.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(73, 371);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(120, 17);
            textBox3.TabIndex = 2;
            textBox3.Text = "Nome de Usuário:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.ControlLightLight;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(73, 111);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(147, 17);
            textBox4.TabIndex = 6;
            textBox4.Text = "Nome do Personagem:";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BackColor = SystemColors.ControlLightLight;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(316, 215);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(120, 17);
            textBox5.TabIndex = 7;
            textBox5.Text = "Defesa:";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BackColor = SystemColors.ControlLightLight;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(73, 163);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(120, 17);
            textBox6.TabIndex = 8;
            textBox6.Text = "Elemento:";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.BackColor = SystemColors.ControlLightLight;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(316, 111);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(120, 17);
            textBox7.TabIndex = 9;
            textBox7.Text = "Vida:";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.BackColor = SystemColors.ControlLightLight;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(316, 319);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(120, 17);
            textBox8.TabIndex = 10;
            textBox8.Text = "Recarga de Energia:";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.BackColor = SystemColors.ControlLightLight;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.Location = new Point(316, 163);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(120, 17);
            textBox9.TabIndex = 11;
            textBox9.Text = "Ataque:";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.None;
            textBox10.BackColor = SystemColors.ControlLightLight;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.Location = new Point(316, 267);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(147, 17);
            textBox10.TabIndex = 12;
            textBox10.Text = "Proficiência Elemental:";
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.None;
            textBox11.BackColor = SystemColors.ControlLightLight;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.Location = new Point(73, 319);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(120, 17);
            textBox11.TabIndex = 13;
            textBox11.Text = "Data de Aquisição:";
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.None;
            textBox12.BackColor = SystemColors.ControlLightLight;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(73, 267);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(147, 17);
            textBox12.TabIndex = 14;
            textBox12.Text = "Nível de Constelação:";
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.None;
            textBox13.BackColor = SystemColors.ControlLightLight;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox13.Location = new Point(73, 215);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(120, 17);
            textBox13.TabIndex = 15;
            textBox13.Text = "Arma:";
            // 
            // textBoxAtq
            // 
            textBoxAtq.Anchor = AnchorStyles.None;
            textBoxAtq.Location = new Point(316, 186);
            textBoxAtq.Name = "textBoxAtq";
            textBoxAtq.Size = new Size(156, 23);
            textBoxAtq.TabIndex = 17;
            textBoxAtq.KeyPress += aoDigitarValorInvalidoEmAtaque;
            // 
            // textBoxRE
            // 
            textBoxRE.Anchor = AnchorStyles.None;
            textBoxRE.Location = new Point(316, 342);
            textBoxRE.Name = "textBoxRE";
            textBoxRE.Size = new Size(156, 23);
            textBoxRE.TabIndex = 18;
            textBoxRE.KeyPress += aoDigitarValorInvalidoEmRecarga;
            // 
            // textBoxHP
            // 
            textBoxHP.Anchor = AnchorStyles.None;
            textBoxHP.Location = new Point(316, 134);
            textBoxHP.Name = "textBoxHP";
            textBoxHP.Size = new Size(156, 23);
            textBoxHP.TabIndex = 19;
            textBoxHP.KeyPress += aoDigitarValorInvalidoEmVida;
            // 
            // textBoxPE
            // 
            textBoxPE.Anchor = AnchorStyles.None;
            textBoxPE.Location = new Point(316, 290);
            textBoxPE.Name = "textBoxPE";
            textBoxPE.Size = new Size(156, 23);
            textBoxPE.TabIndex = 20;
            textBoxPE.KeyPress += aoDigitarValorInvalidoEmProficiencia;
            // 
            // textBoxDef
            // 
            textBoxDef.Anchor = AnchorStyles.None;
            textBoxDef.Location = new Point(316, 238);
            textBoxDef.Name = "textBoxDef";
            textBoxDef.Size = new Size(156, 23);
            textBoxDef.TabIndex = 21;
            textBoxDef.KeyPress += aoDigitarValorInvalidoEmDefesa;
            // 
            // textBoxConst
            // 
            textBoxConst.Anchor = AnchorStyles.None;
            textBoxConst.Location = new Point(73, 290);
            textBoxConst.Name = "textBoxConst";
            textBoxConst.Size = new Size(156, 23);
            textBoxConst.TabIndex = 22;
            textBoxConst.KeyPress += aoDigitarValorInvalidoEmConstelacao;
            // 
            // textBoxDC
            // 
            textBoxDC.Anchor = AnchorStyles.None;
            textBoxDC.Location = new Point(559, 134);
            textBoxDC.Name = "textBoxDC";
            textBoxDC.Size = new Size(156, 23);
            textBoxDC.TabIndex = 23;
            textBoxDC.KeyPress += aoDigitarValorInvalidoEmDanoCritico;
            // 
            // comboBoxArma
            // 
            comboBoxArma.Anchor = AnchorStyles.None;
            comboBoxArma.FormattingEnabled = true;
            comboBoxArma.Location = new Point(73, 238);
            comboBoxArma.Name = "comboBoxArma";
            comboBoxArma.Size = new Size(156, 23);
            comboBoxArma.TabIndex = 24;
            // 
            // comboBoxElemento
            // 
            comboBoxElemento.Anchor = AnchorStyles.None;
            comboBoxElemento.FormattingEnabled = true;
            comboBoxElemento.Location = new Point(73, 186);
            comboBoxElemento.Name = "comboBoxElemento";
            comboBoxElemento.Size = new Size(156, 23);
            comboBoxElemento.TabIndex = 25;
            // 
            // textBox22
            // 
            textBox22.Anchor = AnchorStyles.None;
            textBox22.BackColor = SystemColors.ControlLightLight;
            textBox22.BorderStyle = BorderStyle.None;
            textBox22.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox22.Location = new Point(559, 163);
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(120, 17);
            textBox22.TabIndex = 26;
            textBox22.Text = "Taxa Crítica:";
            // 
            // textBox23
            // 
            textBox23.Anchor = AnchorStyles.None;
            textBox23.BackColor = SystemColors.ControlLightLight;
            textBox23.BorderStyle = BorderStyle.None;
            textBox23.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox23.Location = new Point(559, 267);
            textBox23.Name = "textBox23";
            textBox23.ReadOnly = true;
            textBox23.Size = new Size(120, 17);
            textBox23.TabIndex = 27;
            textBox23.Text = "Força de Escudo:";
            // 
            // textBox24
            // 
            textBox24.Anchor = AnchorStyles.None;
            textBox24.BackColor = SystemColors.ControlLightLight;
            textBox24.BorderStyle = BorderStyle.None;
            textBox24.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox24.Location = new Point(559, 215);
            textBox24.Name = "textBox24";
            textBox24.ReadOnly = true;
            textBox24.Size = new Size(120, 17);
            textBox24.TabIndex = 28;
            textBox24.Text = "Bônus de Cura:";
            // 
            // textBox25
            // 
            textBox25.Anchor = AnchorStyles.None;
            textBox25.BackColor = SystemColors.ControlLightLight;
            textBox25.BorderStyle = BorderStyle.None;
            textBox25.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox25.Location = new Point(559, 324);
            textBox25.Name = "textBox25";
            textBox25.ReadOnly = true;
            textBox25.Size = new Size(147, 17);
            textBox25.TabIndex = 29;
            textBox25.Text = "Bônus Elemental:";
            // 
            // textBox26
            // 
            textBox26.Anchor = AnchorStyles.None;
            textBox26.BackColor = SystemColors.ControlLightLight;
            textBox26.BorderStyle = BorderStyle.None;
            textBox26.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox26.Location = new Point(559, 111);
            textBox26.Name = "textBox26";
            textBox26.ReadOnly = true;
            textBox26.Size = new Size(120, 17);
            textBox26.TabIndex = 30;
            textBox26.Text = "Dano Crítico:";
            // 
            // textBoxBE
            // 
            textBoxBE.Anchor = AnchorStyles.None;
            textBoxBE.Location = new Point(559, 345);
            textBoxBE.Name = "textBoxBE";
            textBoxBE.Size = new Size(156, 23);
            textBoxBE.TabIndex = 32;
            textBoxBE.KeyPress += aoDigitarValorInvalidoEmBonusElemental;
            // 
            // textBoxTC
            // 
            textBoxTC.Anchor = AnchorStyles.None;
            textBoxTC.Location = new Point(559, 186);
            textBoxTC.Name = "textBoxTC";
            textBoxTC.Size = new Size(156, 23);
            textBoxTC.TabIndex = 33;
            textBoxTC.KeyPress += aoDigitarValorInvalidoEmTaxaCritica;
            // 
            // textBoxCura
            // 
            textBoxCura.Anchor = AnchorStyles.None;
            textBoxCura.Location = new Point(559, 238);
            textBoxCura.Name = "textBoxCura";
            textBoxCura.Size = new Size(156, 23);
            textBoxCura.TabIndex = 34;
            textBoxCura.KeyPress += aoDigitarValorInvalidoEmBonusCura;
            // 
            // textBoxShield
            // 
            textBoxShield.Anchor = AnchorStyles.None;
            textBoxShield.Location = new Point(559, 290);
            textBoxShield.Name = "textBoxShield";
            textBoxShield.Size = new Size(156, 23);
            textBoxShield.TabIndex = 35;
            textBoxShield.KeyPress += aoDigitarValorInvalidoEmEscudo;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(316, 394);
            button1.Name = "button1";
            button1.Size = new Size(156, 24);
            button1.TabIndex = 36;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += aoClicarEmSalvar;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.MediumPurple;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(559, 394);
            button2.Name = "button2";
            button2.Size = new Size(156, 23);
            button2.TabIndex = 37;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += aoClicarEmCancelar;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.Checked = false;
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(73, 342);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(156, 23);
            dateTimePicker.TabIndex = 39;
            // 
            // FormCadastroPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxShield);
            Controls.Add(textBoxCura);
            Controls.Add(textBoxTC);
            Controls.Add(textBoxBE);
            Controls.Add(textBox26);
            Controls.Add(textBox25);
            Controls.Add(textBox24);
            Controls.Add(textBox23);
            Controls.Add(textBox22);
            Controls.Add(comboBoxElemento);
            Controls.Add(comboBoxArma);
            Controls.Add(textBoxDC);
            Controls.Add(textBoxConst);
            Controls.Add(textBoxDef);
            Controls.Add(textBoxPE);
            Controls.Add(textBoxHP);
            Controls.Add(textBoxRE);
            Controls.Add(textBoxAtq);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBoxNome);
            Controls.Add(linkLabel1);
            Controls.Add(textBox3);
            Controls.Add(textBoxNomeU);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "FormCadastroPersonagem";
            Text = "Cadastro de Personagem";
            Load += aoCarregarTelaDeCadastro;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxNomeU;
        private LinkLabel linkLabel1;
        private ComboBox comboBoxNome;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBoxAtq;
        private TextBox textBoxRE;
        private TextBox textBoxHP;
        private TextBox textBoxPE;
        private TextBox textBoxDef;
        private TextBox textBoxConst;
        private TextBox textBoxDC;
        private ComboBox comboBoxArma;
        private ComboBox comboBoxElemento;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBoxBE;
        private TextBox textBoxTC;
        private TextBox textBoxCura;
        private TextBox textBoxShield;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker;
    }
}