
namespace Loja_da_Cris
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btAdcCliente = new System.Windows.Forms.Button();
            this.btEdtCliente = new System.Windows.Forms.Button();
            this.btExcCliente = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.btConsultarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.lojaDaCrisDataSet = new Loja_da_Cris.LojaDaCrisDataSet();
            this.loginTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.LoginTableAdapter();
            this.clientesTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.ClientesTableAdapter();
            this.mtxIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.clienteTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxNumero = new System.Windows.Forms.MaskedTextBox();
            this.vendaTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.VendaTableAdapter();
            this.vendedorTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdcCliente
            // 
            this.btAdcCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btAdcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdcCliente.Image = global::Loja_da_Cris.Properties.Resources.adicionar_cliente;
            this.btAdcCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdcCliente.Location = new System.Drawing.Point(636, 64);
            this.btAdcCliente.Name = "btAdcCliente";
            this.btAdcCliente.Size = new System.Drawing.Size(122, 59);
            this.btAdcCliente.TabIndex = 23;
            this.btAdcCliente.Text = "Adicionar Cliente";
            this.btAdcCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdcCliente.UseVisualStyleBackColor = false;
            this.btAdcCliente.Click += new System.EventHandler(this.btAdcCliente_Click);
            // 
            // btEdtCliente
            // 
            this.btEdtCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.btEdtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdtCliente.Image = global::Loja_da_Cris.Properties.Resources.alterar_cliente;
            this.btEdtCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdtCliente.Location = new System.Drawing.Point(636, 131);
            this.btEdtCliente.Name = "btEdtCliente";
            this.btEdtCliente.Size = new System.Drawing.Size(122, 59);
            this.btEdtCliente.TabIndex = 22;
            this.btEdtCliente.Text = "Alterar Cliente";
            this.btEdtCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdtCliente.UseVisualStyleBackColor = false;
            this.btEdtCliente.Click += new System.EventHandler(this.btEdtCliente_Click);
            // 
            // btExcCliente
            // 
            this.btExcCliente.BackColor = System.Drawing.Color.Salmon;
            this.btExcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcCliente.Image = global::Loja_da_Cris.Properties.Resources.excluir_cliente;
            this.btExcCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcCliente.Location = new System.Drawing.Point(636, 198);
            this.btExcCliente.Name = "btExcCliente";
            this.btExcCliente.Size = new System.Drawing.Size(122, 59);
            this.btExcCliente.TabIndex = 21;
            this.btExcCliente.Text = "Excluir Cliente";
            this.btExcCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcCliente.UseVisualStyleBackColor = false;
            this.btExcCliente.Click += new System.EventHandler(this.btExcCliente_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Data,
            this.Hora,
            this.toolStripStatusLabel2,
            this.tsData,
            this.toolStripStatusLabel3,
            this.tsHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "Clientes - Loja da Cris";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Data
            // 
            this.Data.Name = "Data";
            this.Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Data.Size = new System.Drawing.Size(0, 17);
            this.Data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hora
            // 
            this.Hora.Name = "Hora";
            this.Hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Hora.Size = new System.Drawing.Size(0, 17);
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel2.Text = "Data:";
            // 
            // tsData
            // 
            this.tsData.Name = "tsData";
            this.tsData.Size = new System.Drawing.Size(118, 17);
            this.tsData.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // tsHora
            // 
            this.tsHora.Name = "tsHora";
            this.tsHora.Size = new System.Drawing.Size(118, 17);
            this.tsHora.Text = "toolStripStatusLabel4";
            this.tsHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data nasc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Email:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(12, 72);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(196, 20);
            this.txNome.TabIndex = 35;
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(227, 72);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(77, 20);
            this.dtDataNasc.TabIndex = 36;
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Items.AddRange(new object[] {
            "Três Arroios",
            "Severiano de Almeida",
            "Erechim",
            "Maximiliano de Almeida",
            "Aratiba",
            "Mariano Moro"});
            this.cbCidade.Location = new System.Drawing.Point(12, 126);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(196, 21);
            this.cbCidade.TabIndex = 37;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(12, 277);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(85, 20);
            this.mtxCPF.TabIndex = 38;
            this.mtxCPF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxCPF_MouseUp);
            this.mtxCPF.Validating += new System.ComponentModel.CancelEventHandler(this.mtxCPF_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "CPF:";
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(227, 126);
            this.mtxCEP.Mask = "00000-000";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(65, 20);
            this.mtxCEP.TabIndex = 40;
            this.mtxCEP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxCEP_MouseUp);
            // 
            // txEndereco
            // 
            this.txEndereco.Location = new System.Drawing.Point(12, 178);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.Size = new System.Drawing.Size(196, 20);
            this.txEndereco.TabIndex = 41;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(227, 230);
            this.mtxTelefone.Mask = "(99)00000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(96, 20);
            this.mtxTelefone.TabIndex = 42;
            this.mtxTelefone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxTelefone_MouseUp);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(12, 230);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(196, 20);
            this.txEmail.TabIndex = 43;
            // 
            // btConsultarCliente
            // 
            this.btConsultarCliente.Location = new System.Drawing.Point(101, 26);
            this.btConsultarCliente.Name = "btConsultarCliente";
            this.btConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btConsultarCliente.TabIndex = 44;
            this.btConsultarCliente.Text = "Consultar";
            this.btConsultarCliente.UseVisualStyleBackColor = true;
            this.btConsultarCliente.Click += new System.EventHandler(this.btConsultarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 132);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClienteDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.Width = 90;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            this.dataNascDataGridViewTextBoxColumn.Width = 80;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // lojaDaCrisDataSetNovo
            // 
            this.lojaDaCrisDataSetNovo.DataSetName = "LojaDaCrisDataSetNovo";
            this.lojaDaCrisDataSetNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lojaDaCrisDataSet
            // 
            this.lojaDaCrisDataSet.DataSetName = "LojaDaCrisDataSet";
            this.lojaDaCrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // mtxIdCliente
            // 
            this.mtxIdCliente.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.mtxIdCliente.Location = new System.Drawing.Point(12, 29);
            this.mtxIdCliente.Mask = "00000";
            this.mtxIdCliente.Name = "mtxIdCliente";
            this.mtxIdCliente.Size = new System.Drawing.Size(72, 20);
            this.mtxIdCliente.SkipLiterals = false;
            this.mtxIdCliente.TabIndex = 46;
            this.mtxIdCliente.ValidatingType = typeof(int);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(224, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Número:";
            // 
            // mtxNumero
            // 
            this.mtxNumero.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.mtxNumero.Location = new System.Drawing.Point(227, 177);
            this.mtxNumero.Mask = "00000";
            this.mtxNumero.Name = "mtxNumero";
            this.mtxNumero.Size = new System.Drawing.Size(72, 20);
            this.mtxNumero.SkipLiterals = false;
            this.mtxNumero.TabIndex = 49;
            this.mtxNumero.ValidatingType = typeof(int);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.mtxNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtxIdCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btConsultarCliente);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.txEndereco);
            this.Controls.Add(this.mtxCEP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.dtDataNasc);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btAdcCliente);
            this.Controls.Add(this.btEdtCliente);
            this.Controls.Add(this.btExcCliente);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdcCliente;
        private System.Windows.Forms.Button btEdtCliente;
        private System.Windows.Forms.Button btExcCliente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button btConsultarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LojaDaCrisDataSet lojaDaCrisDataSet;
        private LojaDaCrisDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private LojaDaCrisDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtxIdCliente;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxNumero;
        private LojaDaCrisDataSetNovoTableAdapters.VendaTableAdapter vendaTableAdapter;
        private LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}