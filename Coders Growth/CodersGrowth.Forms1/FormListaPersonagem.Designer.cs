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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomePersonagemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            elementoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            armaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            constelacaoLvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ataqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defesaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxaCritDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            danoCritDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proficienciaElementalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recargaDeEnergiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusElementalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusCuraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            escudoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            criadoPorUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeAquisicaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textBoxFiltroUsuario = new TextBox();
            button2 = new Button();
            button4 = new Button();
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
            dataGridViewPersonagem.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomePersonagemDataGridViewTextBoxColumn, elementoDataGridViewTextBoxColumn, armaDataGridViewTextBoxColumn, constelacaoLvDataGridViewTextBoxColumn, vidaDataGridViewTextBoxColumn, ataqueDataGridViewTextBoxColumn, defesaDataGridViewTextBoxColumn, taxaCritDataGridViewTextBoxColumn, danoCritDataGridViewTextBoxColumn, proficienciaElementalDataGridViewTextBoxColumn, recargaDeEnergiaDataGridViewTextBoxColumn, bonusElementalDataGridViewTextBoxColumn, bonusCuraDataGridViewTextBoxColumn, escudoDataGridViewTextBoxColumn, criadoPorUsuarioDataGridViewTextBoxColumn, dataDeAquisicaoDataGridViewTextBoxColumn, nomeUsuarioDataGridViewTextBoxColumn });
            dataGridViewPersonagem.DataSource = personagemBindingSource;
            dataGridViewPersonagem.Location = new Point(12, 179);
            dataGridViewPersonagem.MultiSelect = false;
            dataGridViewPersonagem.Name = "dataGridViewPersonagem";
            dataGridViewPersonagem.RowTemplate.Height = 25;
            dataGridViewPersonagem.Size = new Size(850, 211);
            dataGridViewPersonagem.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomePersonagemDataGridViewTextBoxColumn
            // 
            nomePersonagemDataGridViewTextBoxColumn.DataPropertyName = "NomePersonagem";
            nomePersonagemDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomePersonagemDataGridViewTextBoxColumn.Name = "nomePersonagemDataGridViewTextBoxColumn";
            // 
            // elementoDataGridViewTextBoxColumn
            // 
            elementoDataGridViewTextBoxColumn.DataPropertyName = "Elemento";
            elementoDataGridViewTextBoxColumn.HeaderText = "Elemento";
            elementoDataGridViewTextBoxColumn.Name = "elementoDataGridViewTextBoxColumn";
            // 
            // armaDataGridViewTextBoxColumn
            // 
            armaDataGridViewTextBoxColumn.DataPropertyName = "Arma";
            armaDataGridViewTextBoxColumn.HeaderText = "Arma";
            armaDataGridViewTextBoxColumn.Name = "armaDataGridViewTextBoxColumn";
            // 
            // constelacaoLvDataGridViewTextBoxColumn
            // 
            constelacaoLvDataGridViewTextBoxColumn.DataPropertyName = "ConstelacaoLv";
            constelacaoLvDataGridViewTextBoxColumn.HeaderText = "Constelação";
            constelacaoLvDataGridViewTextBoxColumn.Name = "constelacaoLvDataGridViewTextBoxColumn";
            // 
            // vidaDataGridViewTextBoxColumn
            // 
            vidaDataGridViewTextBoxColumn.DataPropertyName = "Vida";
            vidaDataGridViewTextBoxColumn.HeaderText = "Vida";
            vidaDataGridViewTextBoxColumn.Name = "vidaDataGridViewTextBoxColumn";
            // 
            // ataqueDataGridViewTextBoxColumn
            // 
            ataqueDataGridViewTextBoxColumn.DataPropertyName = "Ataque";
            ataqueDataGridViewTextBoxColumn.HeaderText = "Ataque";
            ataqueDataGridViewTextBoxColumn.Name = "ataqueDataGridViewTextBoxColumn";
            // 
            // defesaDataGridViewTextBoxColumn
            // 
            defesaDataGridViewTextBoxColumn.DataPropertyName = "Defesa";
            defesaDataGridViewTextBoxColumn.HeaderText = "Defesa";
            defesaDataGridViewTextBoxColumn.Name = "defesaDataGridViewTextBoxColumn";
            // 
            // taxaCritDataGridViewTextBoxColumn
            // 
            taxaCritDataGridViewTextBoxColumn.DataPropertyName = "TaxaCrit";
            taxaCritDataGridViewTextBoxColumn.HeaderText = "Taxa Crítica";
            taxaCritDataGridViewTextBoxColumn.Name = "taxaCritDataGridViewTextBoxColumn";
            // 
            // danoCritDataGridViewTextBoxColumn
            // 
            danoCritDataGridViewTextBoxColumn.DataPropertyName = "DanoCrit";
            danoCritDataGridViewTextBoxColumn.HeaderText = "Dano Crítico";
            danoCritDataGridViewTextBoxColumn.Name = "danoCritDataGridViewTextBoxColumn";
            // 
            // proficienciaElementalDataGridViewTextBoxColumn
            // 
            proficienciaElementalDataGridViewTextBoxColumn.DataPropertyName = "ProficienciaElemental";
            proficienciaElementalDataGridViewTextBoxColumn.HeaderText = "Proficiência Elemental";
            proficienciaElementalDataGridViewTextBoxColumn.Name = "proficienciaElementalDataGridViewTextBoxColumn";
            // 
            // recargaDeEnergiaDataGridViewTextBoxColumn
            // 
            recargaDeEnergiaDataGridViewTextBoxColumn.DataPropertyName = "RecargaDeEnergia";
            recargaDeEnergiaDataGridViewTextBoxColumn.HeaderText = "Recarga de Energia";
            recargaDeEnergiaDataGridViewTextBoxColumn.Name = "recargaDeEnergiaDataGridViewTextBoxColumn";
            // 
            // bonusElementalDataGridViewTextBoxColumn
            // 
            bonusElementalDataGridViewTextBoxColumn.DataPropertyName = "BonusElemental";
            bonusElementalDataGridViewTextBoxColumn.HeaderText = "Bônus de Dano Elemental";
            bonusElementalDataGridViewTextBoxColumn.Name = "bonusElementalDataGridViewTextBoxColumn";
            // 
            // bonusCuraDataGridViewTextBoxColumn
            // 
            bonusCuraDataGridViewTextBoxColumn.DataPropertyName = "BonusCura";
            bonusCuraDataGridViewTextBoxColumn.HeaderText = "Bônus de Cura";
            bonusCuraDataGridViewTextBoxColumn.Name = "bonusCuraDataGridViewTextBoxColumn";
            // 
            // escudoDataGridViewTextBoxColumn
            // 
            escudoDataGridViewTextBoxColumn.DataPropertyName = "Escudo";
            escudoDataGridViewTextBoxColumn.HeaderText = "Força de Escudo";
            escudoDataGridViewTextBoxColumn.Name = "escudoDataGridViewTextBoxColumn";
            // 
            // criadoPorUsuarioDataGridViewTextBoxColumn
            // 
            criadoPorUsuarioDataGridViewTextBoxColumn.DataPropertyName = "CriadoPorUsuario";
            criadoPorUsuarioDataGridViewTextBoxColumn.HeaderText = "Criado Por Usuário";
            criadoPorUsuarioDataGridViewTextBoxColumn.Name = "criadoPorUsuarioDataGridViewTextBoxColumn";
            // 
            // dataDeAquisicaoDataGridViewTextBoxColumn
            // 
            dataDeAquisicaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAquisicao";
            dataDeAquisicaoDataGridViewTextBoxColumn.HeaderText = "Data De Aquisição";
            dataDeAquisicaoDataGridViewTextBoxColumn.Name = "dataDeAquisicaoDataGridViewTextBoxColumn";
            // 
            // nomeUsuarioDataGridViewTextBoxColumn
            // 
            nomeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NomeUsuario";
            nomeUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuário Criador";
            nomeUsuarioDataGridViewTextBoxColumn.Name = "nomeUsuarioDataGridViewTextBoxColumn";
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomePersonagemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn armaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn constelacaoLvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ataqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxaCritDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn danoCritDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proficienciaElementalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recargaDeEnergiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonusElementalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonusCuraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn escudoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn criadoPorUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeAquisicaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeUsuarioDataGridViewTextBoxColumn;
        private Button button4;
    }
}
