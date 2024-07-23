namespace CodersGrowth.Forms1
{
    partial class FormsCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsCadastroUsuario));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBoxNome = new TextBox();
            textBox8 = new TextBox();
            textBoxAR = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Gabriola", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(311, 1);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(194, 109);
            textBox1.TabIndex = 0;
            textBox1.Text = "Cadastro";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(311, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 1;
            textBox2.Text = "Nome de usuário";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.None;
            textBoxNome.Location = new Point(311, 149);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(194, 23);
            textBoxNome.TabIndex = 2;
            textBoxNome.KeyPress += aoDigitarValorInvalidoEmNome;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(311, 204);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 16);
            textBox8.TabIndex = 4;
            textBox8.Text = "Adventure Rank";
            // 
            // textBoxAR
            // 
            textBoxAR.Anchor = AnchorStyles.None;
            textBoxAR.Location = new Point(311, 226);
            textBoxAR.Name = "textBoxAR";
            textBoxAR.Size = new Size(194, 23);
            textBoxAR.TabIndex = 6;
            textBoxAR.KeyPress += aoDigitarValorInvalidoEmAR;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(311, 306);
            button1.Name = "button1";
            button1.Size = new Size(194, 27);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += aoClicarEmCadastrar;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.MediumPurple;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(311, 354);
            button2.Name = "button2";
            button2.Size = new Size(194, 27);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += aoClicarEmCancelar;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(540, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 321);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // FormsCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxAR);
            Controls.Add(textBox8);
            Controls.Add(textBoxNome);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormsCadastroUsuario";
            Text = "Cadastro de usuário";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxNome;
        private TextBox textBox8;
        private TextBox textBoxAR;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}