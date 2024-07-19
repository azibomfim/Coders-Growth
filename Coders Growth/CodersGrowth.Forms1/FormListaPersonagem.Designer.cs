using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CodersGrowth.Forms1
{
    partial class FormListaPersonagem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPersonagem));
            personagemBindingSource = new BindingSource(components);
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            comboBoxArma = new ComboBox();
            comboBoxElemento = new ComboBox();
            personagemBindingSource1 = new BindingSource(components);
            botaoFiltro = new Button();
            dateTimePickerFiltro = new DateTimePicker();
            textboxTitulo = new TextBox();
            comboBoxNome = new ComboBox();
            checkBoxBool = new CheckBox();
            personagemBindingSource2 = new BindingSource(components);
            dataGridViewPersonagem = new DataGridView();
            textBoxFiltroUsuario = new TextBox();
            button2 = new Button();
            button4 = new Button();
            idColumn = new DataGridViewTextBoxColumn();
            nomePersonagemColumn = new DataGridViewTextBoxColumn();
            elementoColumn = new DataGridViewTextBoxColumn();
            armaColumn = new DataGridViewTextBoxColumn();
            constelacaoColumn = new DataGridViewTextBoxColumn();
            vidaColumn = new DataGridViewTextBoxColumn();
            ataqueColumn = new DataGridViewTextBoxColumn();
            defesaColumn = new DataGridViewTextBoxColumn();
            taxaCritColumn = new DataGridViewTextBoxColumn();
            danoCritColumn = new DataGridViewTextBoxColumn();
            proficienciaColumn = new DataGridViewTextBoxColumn();
            recargaColumn = new DataGridViewTextBoxColumn();
            bonusElementalColumn = new DataGridViewTextBoxColumn();
            curaColumn = new DataGridViewTextBoxColumn();
            escudoColumn = new DataGridViewTextBoxColumn();
            criadoPorUsuarioColumn = new DataGridViewTextBoxColumn();
            dataColumn = new DataGridViewTextBoxColumn();
            nomeUsuarioColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonagem).BeginInit();
            SuspendLayout();
            // 
            // personagemBindingSource
            // 
            personagemBindingSource.DataSource = typeof(Dominio.Models.Personagem);
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.MediumPurple;
            button3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(662, 396);
            button3.Name = "button3";
            button3.Size = new Size(97, 32);
            button3.TabIndex = 4;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += aoClicarEmEditar;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-2, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(559, 396);
            button1.Name = "button1";
            button1.Size = new Size(97, 32);
            button1.TabIndex = 6;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += aoClicarEmCriar;
            // 
            // comboBoxArma
            // 
            comboBoxArma.AccessibleName = "";
            comboBoxArma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxArma.FormattingEnabled = true;
            comboBoxArma.Location = new Point(669, 32);
            comboBoxArma.Name = "comboBoxArma";
            comboBoxArma.Size = new Size(125, 23);
            comboBoxArma.TabIndex = 7;
            comboBoxArma.Text = "Arma";
            // 
            // comboBoxElemento
            // 
            comboBoxElemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxElemento.FormattingEnabled = true;
            comboBoxElemento.Location = new Point(669, 61);
            comboBoxElemento.Name = "comboBoxElemento";
            comboBoxElemento.Size = new Size(125, 23);
            comboBoxElemento.TabIndex = 8;
            comboBoxElemento.Text = "Elemento";
            // 
            // personagemBindingSource1
            // 
            personagemBindingSource1.DataSource = typeof(Dominio.Models.Personagem);
            // 
            // botaoFiltro
            // 
            botaoFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botaoFiltro.BackColor = Color.MediumPurple;
            botaoFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            botaoFiltro.Location = new Point(800, 61);
            botaoFiltro.Name = "botaoFiltro";
            botaoFiltro.Size = new Size(65, 23);
            botaoFiltro.TabIndex = 13;
            botaoFiltro.Text = "Filtrar";
            botaoFiltro.UseVisualStyleBackColor = false;
            botaoFiltro.Click += aoClicarEmFiltrar;
            // 
            // dateTimePickerFiltro
            // 
            dateTimePickerFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerFiltro.Checked = false;
            dateTimePickerFiltro.Format = DateTimePickerFormat.Short;
            dateTimePickerFiltro.Location = new Point(669, 90);
            dateTimePickerFiltro.Name = "dateTimePickerFiltro";
            dateTimePickerFiltro.Size = new Size(125, 23);
            dateTimePickerFiltro.TabIndex = 14;
            // 
            // textboxTitulo
            // 
            textboxTitulo.Anchor = AnchorStyles.Top;
            textboxTitulo.BorderStyle = BorderStyle.None;
            textboxTitulo.Font = new Font("Gabriola", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textboxTitulo.Location = new Point(-2, 20);
            textboxTitulo.Multiline = true;
            textboxTitulo.Name = "textboxTitulo";
            textboxTitulo.Size = new Size(777, 107);
            textboxTitulo.TabIndex = 1;
            textboxTitulo.Text = "Biblioteca Genshin Impact\r\n";
            textboxTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxNome
            // 
            comboBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxNome.FormattingEnabled = true;
            comboBoxNome.Location = new Point(669, 3);
            comboBoxNome.Name = "comboBoxNome";
            comboBoxNome.Size = new Size(125, 23);
            comboBoxNome.TabIndex = 9;
            comboBoxNome.Text = "Nome";
            // 
            // checkBoxBool
            // 
            checkBoxBool.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxBool.AutoSize = true;
            checkBoxBool.Location = new Point(669, 148);
            checkBoxBool.Name = "checkBoxBool";
            checkBoxBool.Size = new Size(124, 19);
            checkBoxBool.TabIndex = 15;
            checkBoxBool.Text = "Criado por usuário";
            checkBoxBool.UseVisualStyleBackColor = true;
            // 
            // personagemBindingSource2
            // 
            personagemBindingSource2.DataSource = typeof(Dominio.Models.Personagem);
            // 
            // dataGridViewPersonagem
            // 
            dataGridViewPersonagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPersonagem.AutoGenerateColumns = false;
            dataGridViewPersonagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersonagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonagem.Columns.AddRange(new DataGridViewColumn[] { idColumn, nomePersonagemColumn, elementoColumn, armaColumn, constelacaoColumn, vidaColumn, ataqueColumn, defesaColumn, taxaCritColumn, danoCritColumn, proficienciaColumn, recargaColumn, bonusElementalColumn, curaColumn, escudoColumn, criadoPorUsuarioColumn, dataColumn, nomeUsuarioColumn });
            dataGridViewPersonagem.DataSource = personagemBindingSource;
            dataGridViewPersonagem.Location = new Point(12, 179);
            dataGridViewPersonagem.MultiSelect = false;
            dataGridViewPersonagem.Name = "dataGridViewPersonagem";
            dataGridViewPersonagem.RowTemplate.Height = 25;
            dataGridViewPersonagem.Size = new Size(850, 211);
            dataGridViewPersonagem.TabIndex = 0;
            // 
            // textBoxFiltroUsuario
            // 
            textBoxFiltroUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFiltroUsuario.Location = new Point(669, 119);
            textBoxFiltroUsuario.Name = "textBoxFiltroUsuario";
            textBoxFiltroUsuario.Size = new Size(125, 23);
            textBoxFiltroUsuario.TabIndex = 17;
            textBoxFiltroUsuario.Text = "Nome de usuário";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.MediumPurple;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(800, 91);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 18;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += aoClicarEmLimpar;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.MediumPurple;
            button4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(765, 396);
            button4.Name = "button4";
            button4.Size = new Size(97, 32);
            button4.TabIndex = 19;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = false;
            button4.Click += aoClicarEmRemoverPersonagem;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            // 
            // nomePersonagemColumn
            // 
            nomePersonagemColumn.DataPropertyName = "NomePersonagem";
            nomePersonagemColumn.HeaderText = "Nome";
            nomePersonagemColumn.Name = "nomePersonagemColumn";
            // 
            // elementoColumn
            // 
            elementoColumn.DataPropertyName = "Elemento";
            elementoColumn.HeaderText = "Elemento";
            elementoColumn.Name = "elementoColumn";
            // 
            // armaColumn
            // 
            armaColumn.DataPropertyName = "Arma";
            armaColumn.HeaderText = "Arma";
            armaColumn.Name = "armaColumn";
            // 
            // constelacaoColumn
            // 
            constelacaoColumn.DataPropertyName = "ConstelacaoLv";
            constelacaoColumn.HeaderText = "Constelação";
            constelacaoColumn.Name = "constelacaoColumn";
            // 
            // vidaColumn
            // 
            vidaColumn.DataPropertyName = "Vida";
            vidaColumn.HeaderText = "Vida";
            vidaColumn.Name = "vidaColumn";
            // 
            // ataqueColumn
            // 
            ataqueColumn.DataPropertyName = "Ataque";
            ataqueColumn.HeaderText = "Ataque";
            ataqueColumn.Name = "ataqueColumn";
            // 
            // defesaColumn
            // 
            defesaColumn.DataPropertyName = "Defesa";
            defesaColumn.HeaderText = "Defesa";
            defesaColumn.Name = "defesaColumn";
            // 
            // taxaCritColumn
            // 
            taxaCritColumn.DataPropertyName = "TaxaCrit";
            taxaCritColumn.HeaderText = "Taxa Crítica";
            taxaCritColumn.Name = "taxaCritColumn";
            // 
            // danoCritColumn
            // 
            danoCritColumn.DataPropertyName = "DanoCrit";
            danoCritColumn.HeaderText = "Dano Crítico";
            danoCritColumn.Name = "danoCritColumn";
            // 
            // proficienciaColumn
            // 
            proficienciaColumn.DataPropertyName = "ProficienciaElemental";
            proficienciaColumn.HeaderText = "Proficiência Elemental";
            proficienciaColumn.Name = "proficienciaColumn";
            // 
            // recargaColumn
            // 
            recargaColumn.DataPropertyName = "RecargaDeEnergia";
            recargaColumn.HeaderText = "Recarga de Energia";
            recargaColumn.Name = "recargaColumn";
            // 
            // bonusElementalColumn
            // 
            bonusElementalColumn.DataPropertyName = "BonusElemental";
            bonusElementalColumn.HeaderText = "Bônus de Dano Elemental";
            bonusElementalColumn.Name = "bonusElementalColumn";
            // 
            // curaColumn
            // 
            curaColumn.DataPropertyName = "BonusCura";
            curaColumn.HeaderText = "Bônus de Cura";
            curaColumn.Name = "curaColumn";
            // 
            // escudoColumn
            // 
            escudoColumn.DataPropertyName = "Escudo";
            escudoColumn.HeaderText = "Força de Escudo";
            escudoColumn.Name = "escudoColumn";
            // 
            // criadoPorUsuarioColumn
            // 
            criadoPorUsuarioColumn.DataPropertyName = "CriadoPorUsuario";
            criadoPorUsuarioColumn.HeaderText = "Criado Por Usuário";
            criadoPorUsuarioColumn.Name = "criadoPorUsuarioColumn";
            // 
            // dataColumn
            // 
            dataColumn.DataPropertyName = "DataDeAquisicao";
            dataColumn.HeaderText = "Data De Aquisição";
            dataColumn.Name = "dataColumn";
            // 
            // nomeUsuarioColumn
            // 
            nomeUsuarioColumn.DataPropertyName = "NomeUsuario";
            nomeUsuarioColumn.HeaderText = "Usuário Criador";
            nomeUsuarioColumn.Name = "nomeUsuarioColumn";
            // 
            // FormListaPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(874, 440);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBoxFiltroUsuario);
            Controls.Add(dataGridViewPersonagem);
            Controls.Add(checkBoxBool);
            Controls.Add(dateTimePickerFiltro);
            Controls.Add(botaoFiltro);
            Controls.Add(comboBoxNome);
            Controls.Add(comboBoxElemento);
            Controls.Add(comboBoxArma);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(textboxTitulo);
            Name = "FormListaPersonagem";
            Text = "Lista de Personagens";
            WindowState = FormWindowState.Maximized;
            Load += aoCarregarTela;
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource personagemBindingSource;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox comboBoxArma;
        private BindingSource personagemBindingSource1;
        private ComboBox comboBoxElemento;
        private Button botaoFiltro;
        private DateTimePicker dateTimePickerFiltro;
        private TextBox textboxTitulo;
        private ComboBox comboBoxNome;
        private CheckBox checkBoxBool;
        private BindingSource personagemBindingSource2;
        private DataGridView dataGridViewPersonagem;
        private TextBox textBoxFiltroUsuario;
        private Button button2;
        private Button button4;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nomePersonagemColumn;
        private DataGridViewTextBoxColumn elementoColumn;
        private DataGridViewTextBoxColumn armaColumn;
        private DataGridViewTextBoxColumn constelacaoColumn;
        private DataGridViewTextBoxColumn vidaColumn;
        private DataGridViewTextBoxColumn ataqueColumn;
        private DataGridViewTextBoxColumn defesaColumn;
        private DataGridViewTextBoxColumn taxaCritColumn;
        private DataGridViewTextBoxColumn danoCritColumn;
        private DataGridViewTextBoxColumn proficienciaColumn;
        private DataGridViewTextBoxColumn recargaColumn;
        private DataGridViewTextBoxColumn bonusElementalColumn;
        private DataGridViewTextBoxColumn curaColumn;
        private DataGridViewTextBoxColumn escudoColumn;
        private DataGridViewTextBoxColumn criadoPorUsuarioColumn;
        private DataGridViewTextBoxColumn dataColumn;
        private DataGridViewTextBoxColumn nomeUsuarioColumn;
    }
}
