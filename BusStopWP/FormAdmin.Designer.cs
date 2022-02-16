
namespace BusStopWP
{
    partial class FormAdmin
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbgosnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbdatevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbdatevvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtipstsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbsumdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbsumcashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbmestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbbusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new BusStopWP.DataSet4();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dbtipstsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new BusStopWP.DataSet7();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dbusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new BusStopWP.DataSet6();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.textPassword1 = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tapPages = new System.Windows.Forms.TabControl();
            this.db_busTableAdapter = new BusStopWP.DataSet4TableAdapters.db_busTableAdapter();
            this.dataSet5 = new BusStopWP.DataSet5();
            this.dbtarifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_tarifTableAdapter = new BusStopWP.DataSet5TableAdapters.db_tarifTableAdapter();
            this.db_usersTableAdapter = new BusStopWP.DataSet6TableAdapters.db_usersTableAdapter();
            this.db_tipstsTableAdapter = new BusStopWP.DataSet7TableAdapters.db_tipstsTableAdapter();
            this.idusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtiptsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtipstsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            this.tapPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtarifBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1162, 619);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчеты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.dbnameDataGridViewTextBoxColumn,
            this.dbadressDataGridViewTextBoxColumn,
            this.dbgosnumberDataGridViewTextBoxColumn,
            this.dbmarkaDataGridViewTextBoxColumn,
            this.dbmodelDataGridViewTextBoxColumn,
            this.dbdatevDataGridViewTextBoxColumn,
            this.dbdatevvDataGridViewTextBoxColumn,
            this.dbstatusDataGridViewTextBoxColumn,
            this.dbtipstsDataGridViewTextBoxColumn,
            this.dbsumdateDataGridViewTextBoxColumn,
            this.dbsumcashDataGridViewTextBoxColumn,
            this.dbmestoDataGridViewTextBoxColumn,
            this.dbuserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbbusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 613);
            this.dataGridView1.TabIndex = 4;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbnameDataGridViewTextBoxColumn
            // 
            this.dbnameDataGridViewTextBoxColumn.DataPropertyName = "db_name";
            this.dbnameDataGridViewTextBoxColumn.HeaderText = "db_name";
            this.dbnameDataGridViewTextBoxColumn.Name = "dbnameDataGridViewTextBoxColumn";
            this.dbnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbadressDataGridViewTextBoxColumn
            // 
            this.dbadressDataGridViewTextBoxColumn.DataPropertyName = "db_adress";
            this.dbadressDataGridViewTextBoxColumn.HeaderText = "db_adress";
            this.dbadressDataGridViewTextBoxColumn.Name = "dbadressDataGridViewTextBoxColumn";
            this.dbadressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbgosnumberDataGridViewTextBoxColumn
            // 
            this.dbgosnumberDataGridViewTextBoxColumn.DataPropertyName = "db_gosnumber";
            this.dbgosnumberDataGridViewTextBoxColumn.HeaderText = "db_gosnumber";
            this.dbgosnumberDataGridViewTextBoxColumn.Name = "dbgosnumberDataGridViewTextBoxColumn";
            this.dbgosnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbmarkaDataGridViewTextBoxColumn
            // 
            this.dbmarkaDataGridViewTextBoxColumn.DataPropertyName = "db_marka";
            this.dbmarkaDataGridViewTextBoxColumn.HeaderText = "db_marka";
            this.dbmarkaDataGridViewTextBoxColumn.Name = "dbmarkaDataGridViewTextBoxColumn";
            this.dbmarkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbmodelDataGridViewTextBoxColumn
            // 
            this.dbmodelDataGridViewTextBoxColumn.DataPropertyName = "db_model";
            this.dbmodelDataGridViewTextBoxColumn.HeaderText = "db_model";
            this.dbmodelDataGridViewTextBoxColumn.Name = "dbmodelDataGridViewTextBoxColumn";
            this.dbmodelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbdatevDataGridViewTextBoxColumn
            // 
            this.dbdatevDataGridViewTextBoxColumn.DataPropertyName = "db_date_v";
            this.dbdatevDataGridViewTextBoxColumn.HeaderText = "db_date_v";
            this.dbdatevDataGridViewTextBoxColumn.Name = "dbdatevDataGridViewTextBoxColumn";
            this.dbdatevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbdatevvDataGridViewTextBoxColumn
            // 
            this.dbdatevvDataGridViewTextBoxColumn.DataPropertyName = "db_date_vv";
            this.dbdatevvDataGridViewTextBoxColumn.HeaderText = "db_date_vv";
            this.dbdatevvDataGridViewTextBoxColumn.Name = "dbdatevvDataGridViewTextBoxColumn";
            this.dbdatevvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbstatusDataGridViewTextBoxColumn
            // 
            this.dbstatusDataGridViewTextBoxColumn.DataPropertyName = "db_status";
            this.dbstatusDataGridViewTextBoxColumn.HeaderText = "db_status";
            this.dbstatusDataGridViewTextBoxColumn.Name = "dbstatusDataGridViewTextBoxColumn";
            this.dbstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbtipstsDataGridViewTextBoxColumn
            // 
            this.dbtipstsDataGridViewTextBoxColumn.DataPropertyName = "db_tipsts";
            this.dbtipstsDataGridViewTextBoxColumn.HeaderText = "db_tipsts";
            this.dbtipstsDataGridViewTextBoxColumn.Name = "dbtipstsDataGridViewTextBoxColumn";
            this.dbtipstsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbsumdateDataGridViewTextBoxColumn
            // 
            this.dbsumdateDataGridViewTextBoxColumn.DataPropertyName = "db_sumdate";
            this.dbsumdateDataGridViewTextBoxColumn.HeaderText = "db_sumdate";
            this.dbsumdateDataGridViewTextBoxColumn.Name = "dbsumdateDataGridViewTextBoxColumn";
            this.dbsumdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbsumcashDataGridViewTextBoxColumn
            // 
            this.dbsumcashDataGridViewTextBoxColumn.DataPropertyName = "db_sumcash";
            this.dbsumcashDataGridViewTextBoxColumn.HeaderText = "db_sumcash";
            this.dbsumcashDataGridViewTextBoxColumn.Name = "dbsumcashDataGridViewTextBoxColumn";
            this.dbsumcashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbmestoDataGridViewTextBoxColumn
            // 
            this.dbmestoDataGridViewTextBoxColumn.DataPropertyName = "db_mesto";
            this.dbmestoDataGridViewTextBoxColumn.HeaderText = "db_mesto";
            this.dbmestoDataGridViewTextBoxColumn.Name = "dbmestoDataGridViewTextBoxColumn";
            this.dbmestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbuserDataGridViewTextBoxColumn
            // 
            this.dbuserDataGridViewTextBoxColumn.DataPropertyName = "db_user";
            this.dbuserDataGridViewTextBoxColumn.HeaderText = "db_user";
            this.dbuserDataGridViewTextBoxColumn.Name = "dbuserDataGridViewTextBoxColumn";
            this.dbuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbbusBindingSource
            // 
            this.dbbusBindingSource.DataMember = "db_bus";
            this.dbbusBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 619);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тарифы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtiptsDataGridViewTextBoxColumn,
            this.dbtsnameDataGridViewTextBoxColumn,
            this.dbtarifDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dbtipstsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(230, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(902, 585);
            this.dataGridView2.TabIndex = 0;
            // 
            // dbtipstsBindingSource
            // 
            this.dbtipstsBindingSource.DataMember = "db_tipsts";
            this.dbtipstsBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonInput);
            this.tabPage1.Controls.Add(this.buttonRegistration);
            this.tabPage1.Controls.Add(this.checkPassword);
            this.tabPage1.Controls.Add(this.textPassword1);
            this.tabPage1.Controls.Add(this.textPassword);
            this.tabPage1.Controls.Add(this.textUser);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.idpasswordDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.dbusersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(287, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(644, 554);
            this.dataGridView3.TabIndex = 14;
            // 
            // dbusersBindingSource
            // 
            this.dbusersBindingSource.DataMember = "db_users";
            this.dbusersBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(37, 296);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(215, 32);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonInput.ForeColor = System.Drawing.Color.White;
            this.buttonInput.Location = new System.Drawing.Point(37, 334);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(215, 32);
            this.buttonInput.TabIndex = 12;
            this.buttonInput.Text = "Выход";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(37, 258);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(215, 32);
            this.buttonRegistration.TabIndex = 13;
            this.buttonRegistration.Text = "Добавить";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPassword.Location = new System.Drawing.Point(133, 223);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(118, 20);
            this.checkPassword.TabIndex = 10;
            this.checkPassword.Text = "Показать пароль";
            this.checkPassword.UseVisualStyleBackColor = true;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // textPassword1
            // 
            this.textPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword1.Location = new System.Drawing.Point(37, 194);
            this.textPassword1.Multiline = true;
            this.textPassword1.Name = "textPassword1";
            this.textPassword1.PasswordChar = '*';
            this.textPassword1.Size = new System.Drawing.Size(215, 24);
            this.textPassword1.TabIndex = 8;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Location = new System.Drawing.Point(37, 138);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(215, 24);
            this.textPassword.TabIndex = 8;
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Location = new System.Drawing.Point(37, 85);
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(215, 24);
            this.textUser.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подтверждение пароля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регистрация";
            // 
            // tapPages
            // 
            this.tapPages.Controls.Add(this.tabPage1);
            this.tapPages.Controls.Add(this.tabPage2);
            this.tapPages.Controls.Add(this.tabPage3);
            this.tapPages.Location = new System.Drawing.Point(2, 2);
            this.tapPages.Name = "tapPages";
            this.tapPages.SelectedIndex = 0;
            this.tapPages.Size = new System.Drawing.Size(1170, 648);
            this.tapPages.TabIndex = 0;
            // 
            // db_busTableAdapter
            // 
            this.db_busTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbtarifBindingSource
            // 
            this.dbtarifBindingSource.DataMember = "db_tarif";
            this.dbtarifBindingSource.DataSource = this.dataSet5;
            // 
            // db_tarifTableAdapter
            // 
            this.db_tarifTableAdapter.ClearBeforeFill = true;
            // 
            // db_usersTableAdapter
            // 
            this.db_usersTableAdapter.ClearBeforeFill = true;
            // 
            // db_tipstsTableAdapter
            // 
            this.db_tipstsTableAdapter.ClearBeforeFill = true;
            // 
            // idusDataGridViewTextBoxColumn
            // 
            this.idusDataGridViewTextBoxColumn.DataPropertyName = "id_us";
            this.idusDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idusDataGridViewTextBoxColumn.Name = "idusDataGridViewTextBoxColumn";
            this.idusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduserDataGridViewTextBoxColumn.Width = 300;
            // 
            // idpasswordDataGridViewTextBoxColumn
            // 
            this.idpasswordDataGridViewTextBoxColumn.DataPropertyName = "id_password";
            this.idpasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.idpasswordDataGridViewTextBoxColumn.Name = "idpasswordDataGridViewTextBoxColumn";
            this.idpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpasswordDataGridViewTextBoxColumn.Width = 200;
            // 
            // idtiptsDataGridViewTextBoxColumn
            // 
            this.idtiptsDataGridViewTextBoxColumn.DataPropertyName = "id_tipts";
            this.idtiptsDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idtiptsDataGridViewTextBoxColumn.Name = "idtiptsDataGridViewTextBoxColumn";
            this.idtiptsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbtsnameDataGridViewTextBoxColumn
            // 
            this.dbtsnameDataGridViewTextBoxColumn.DataPropertyName = "db_tsname";
            this.dbtsnameDataGridViewTextBoxColumn.HeaderText = "Тип транспортного средства";
            this.dbtsnameDataGridViewTextBoxColumn.Name = "dbtsnameDataGridViewTextBoxColumn";
            this.dbtsnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dbtsnameDataGridViewTextBoxColumn.Width = 400;
            // 
            // dbtarifDataGridViewTextBoxColumn
            // 
            this.dbtarifDataGridViewTextBoxColumn.DataPropertyName = "db_tarif";
            this.dbtarifDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.dbtarifDataGridViewTextBoxColumn.Name = "dbtarifDataGridViewTextBoxColumn";
            this.dbtarifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.tapPages);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtipstsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            this.tapPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtarifBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.TextBox textPassword1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tapPages;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource dbbusBindingSource;
        private DataSet4TableAdapters.db_busTableAdapter db_busTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbgosnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbdatevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbdatevvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbtipstsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbsumdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbsumcashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbmestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource dbtarifBindingSource;
        private DataSet5TableAdapters.db_tarifTableAdapter db_tarifTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource dbusersBindingSource;
        private DataSet6TableAdapters.db_usersTableAdapter db_usersTableAdapter;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource dbtipstsBindingSource;
        private DataSet7TableAdapters.db_tipstsTableAdapter db_tipstsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtiptsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbtsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbtarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpasswordDataGridViewTextBoxColumn;
    }
}