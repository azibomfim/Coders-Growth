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
            dataGridViewPersonagem = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomePersonagemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ataqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defesaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proficienciaElementalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxaCritDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            danoCritDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusCuraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recargaDeEnergiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            escudoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusElementalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            criadoPorUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            constelacaoLvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeAquisicaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            elementoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            armaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPersonagem
            // 
            dataGridViewPersonagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPersonagem.AutoGenerateColumns = false;
            dataGridViewPersonagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersonagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonagem.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomePersonagemDataGridViewTextBoxColumn, vidaDataGridViewTextBoxColumn, ataqueDataGridViewTextBoxColumn, defesaDataGridViewTextBoxColumn, proficienciaElementalDataGridViewTextBoxColumn, taxaCritDataGridViewTextBoxColumn, danoCritDataGridViewTextBoxColumn, bonusCuraDataGridViewTextBoxColumn, recargaDeEnergiaDataGridViewTextBoxColumn, escudoDataGridViewTextBoxColumn, bonusElementalDataGridViewTextBoxColumn, criadoPorUsuarioDataGridViewTextBoxColumn, constelacaoLvDataGridViewTextBoxColumn, dataDeAquisicaoDataGridViewTextBoxColumn, elementoDataGridViewTextBoxColumn, armaDataGridViewTextBoxColumn, idUsuarioDataGridViewTextBoxColumn });
            dataGridViewPersonagem.DataSource = personagemBindingSource;
            dataGridViewPersonagem.Location = new Point(15, 179);
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
            // proficienciaElementalDataGridViewTextBoxColumn
            // 
            proficienciaElementalDataGridViewTextBoxColumn.DataPropertyName = "ProficienciaElemental";
            proficienciaElementalDataGridViewTextBoxColumn.HeaderText = "Proficiencia Elemental";
            proficienciaElementalDataGridViewTextBoxColumn.Name = "proficienciaElementalDataGridViewTextBoxColumn";
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
            // bonusCuraDataGridViewTextBoxColumn
            // 
            bonusCuraDataGridViewTextBoxColumn.DataPropertyName = "BonusCura";
            bonusCuraDataGridViewTextBoxColumn.HeaderText = "Bônus de Cura";
            bonusCuraDataGridViewTextBoxColumn.Name = "bonusCuraDataGridViewTextBoxColumn";
            // 
            // recargaDeEnergiaDataGridViewTextBoxColumn
            // 
            recargaDeEnergiaDataGridViewTextBoxColumn.DataPropertyName = "RecargaDeEnergia";
            recargaDeEnergiaDataGridViewTextBoxColumn.HeaderText = "Recarga de Energia";
            recargaDeEnergiaDataGridViewTextBoxColumn.Name = "recargaDeEnergiaDataGridViewTextBoxColumn";
            // 
            // escudoDataGridViewTextBoxColumn
            // 
            escudoDataGridViewTextBoxColumn.DataPropertyName = "Escudo";
            escudoDataGridViewTextBoxColumn.HeaderText = "Força de Escudo";
            escudoDataGridViewTextBoxColumn.Name = "escudoDataGridViewTextBoxColumn";
            // 
            // bonusElementalDataGridViewTextBoxColumn
            // 
            bonusElementalDataGridViewTextBoxColumn.DataPropertyName = "BonusElemental";
            bonusElementalDataGridViewTextBoxColumn.HeaderText = "Bônus de Dano Elemental";
            bonusElementalDataGridViewTextBoxColumn.Name = "bonusElementalDataGridViewTextBoxColumn";
            // 
            // criadoPorUsuarioDataGridViewTextBoxColumn
            // 
            criadoPorUsuarioDataGridViewTextBoxColumn.DataPropertyName = "CriadoPorUsuario";
            criadoPorUsuarioDataGridViewTextBoxColumn.HeaderText = "Criado por Usuário";
            criadoPorUsuarioDataGridViewTextBoxColumn.Name = "criadoPorUsuarioDataGridViewTextBoxColumn";
            // 
            // constelacaoLvDataGridViewTextBoxColumn
            // 
            constelacaoLvDataGridViewTextBoxColumn.DataPropertyName = "ConstelacaoLv";
            constelacaoLvDataGridViewTextBoxColumn.HeaderText = "Nível de Constelação";
            constelacaoLvDataGridViewTextBoxColumn.Name = "constelacaoLvDataGridViewTextBoxColumn";
            // 
            // dataDeAquisicaoDataGridViewTextBoxColumn
            // 
            dataDeAquisicaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAquisicao";
            dataDeAquisicaoDataGridViewTextBoxColumn.HeaderText = "Data de Aquisição";
            dataDeAquisicaoDataGridViewTextBoxColumn.Name = "dataDeAquisicaoDataGridViewTextBoxColumn";
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
            // idUsuarioDataGridViewTextBoxColumn
            // 
            idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id do Usuário";
            idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // personagemBindingSource
            // 
            personagemBindingSource.DataSource = typeof(Dominio.Models.Personagem);
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 396);
            button3.Name = "button3";
            button3.Size = new Size(172, 32);
            button3.TabIndex = 4;
            button3.Text = "Editar personagem";
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
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(690, 396);
            button1.Name = "button1";
            button1.Size = new Size(172, 32);
            button1.TabIndex = 6;
            button1.Text = "Criar novo personagem";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxArma
            // 
            comboBoxArma.AccessibleName = "";
            comboBoxArma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxArma.FormattingEnabled = true;
            comboBoxArma.Location = new Point(669, 46);
            comboBoxArma.Name = "comboBoxArma";
            comboBoxArma.Size = new Size(125, 23);
            comboBoxArma.TabIndex = 7;
            comboBoxArma.Text = "Arma";
            // 
            // comboBoxElemento
            // 
            comboBoxElemento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxElemento.FormattingEnabled = true;
            comboBoxElemento.Location = new Point(669, 75);
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
            botaoFiltro.BackColor = SystemColors.ControlLightLight;
            botaoFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            botaoFiltro.Location = new Point(699, 150);
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
            dateTimePickerFiltro.Location = new Point(669, 104);
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
            comboBoxNome.Location = new Point(669, 17);
            comboBoxNome.Name = "comboBoxNome";
            comboBoxNome.Size = new Size(125, 23);
            comboBoxNome.TabIndex = 9;
            comboBoxNome.Text = "Nome";
            // 
            // checkBoxBool
            // 
            checkBoxBool.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxBool.AutoSize = true;
            checkBoxBool.Location = new Point(670, 133);
            checkBoxBool.Name = "checkBoxBool";
            checkBoxBool.Size = new Size(124, 19);
            checkBoxBool.TabIndex = 15;
            checkBoxBool.Text = "Criado por usuário";
            checkBoxBool.UseVisualStyleBackColor = true;
            // 
            // FormListaPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(874, 440);
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
            Controls.Add(dataGridViewPersonagem);
            Name = "FormListaPersonagem";
            Text = "Lista de Personagens";
            WindowState = FormWindowState.Maximized;
            Load += aoCarregarTela;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPersonagem;
        private BindingSource personagemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomePersonagemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ataqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proficienciaElementalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxaCritDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn danoCritDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonusCuraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recargaDeEnergiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn escudoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonusElementalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn criadoPorUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn constelacaoLvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeAquisicaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn armaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
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
    }
}
