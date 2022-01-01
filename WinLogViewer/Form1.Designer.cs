namespace WinLogViewer
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowserPath = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadLog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controllerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logInfoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInfoViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowserPath
            // 
            this.btnBrowserPath.Location = new System.Drawing.Point(6, 27);
            this.btnBrowserPath.Name = "btnBrowserPath";
            this.btnBrowserPath.Size = new System.Drawing.Size(116, 31);
            this.btnBrowserPath.TabIndex = 0;
            this.btnBrowserPath.Text = "انتخاب مسیر...";
            this.btnBrowserPath.UseVisualStyleBackColor = true;
            this.btnBrowserPath.Click += new System.EventHandler(this.btnBrowserPath_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(128, 35);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(436, 15);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "C:\\Users\\m.jahanbin\\source\\repos\\LogViewer\\LogViewer\\bin\\Debug\\net6.0\\logs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadLog);
            this.groupBox1.Controls.Add(this.btnBrowserPath);
            this.groupBox1.Controls.Add(this.lblLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1767, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب مسیر فایل لاگ";
            // 
            // btnReadLog
            // 
            this.btnReadLog.Location = new System.Drawing.Point(6, 64);
            this.btnReadLog.Name = "btnReadLog";
            this.btnReadLog.Size = new System.Drawing.Size(116, 31);
            this.btnReadLog.TabIndex = 0;
            this.btnReadLog.Text = "خواندن لاگ";
            this.btnReadLog.UseVisualStyleBackColor = true;
            this.btnReadLog.Click += new System.EventHandler(this.btnReadLog_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.controllerDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.methodDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.contentTypeDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.queryStringDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.userAgentDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.additionalInfoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logInfoViewModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1761, 514);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeDataGridViewTextBoxColumn.Width = 107;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 108;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostDataGridViewTextBoxColumn.Width = 107;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Width = 108;
            // 
            // controllerDataGridViewTextBoxColumn
            // 
            this.controllerDataGridViewTextBoxColumn.DataPropertyName = "Controller";
            this.controllerDataGridViewTextBoxColumn.HeaderText = "Controller";
            this.controllerDataGridViewTextBoxColumn.Name = "controllerDataGridViewTextBoxColumn";
            this.controllerDataGridViewTextBoxColumn.ReadOnly = true;
            this.controllerDataGridViewTextBoxColumn.Width = 107;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDataGridViewTextBoxColumn.Width = 107;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            this.methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            this.methodDataGridViewTextBoxColumn.HeaderText = "Method";
            this.methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            this.methodDataGridViewTextBoxColumn.ReadOnly = true;
            this.methodDataGridViewTextBoxColumn.Width = 108;
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            this.statusCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn.Width = 107;
            // 
            // formDataGridViewTextBoxColumn
            // 
            this.formDataGridViewTextBoxColumn.DataPropertyName = "Form";
            this.formDataGridViewTextBoxColumn.HeaderText = "Form";
            this.formDataGridViewTextBoxColumn.Name = "formDataGridViewTextBoxColumn";
            this.formDataGridViewTextBoxColumn.ReadOnly = true;
            this.formDataGridViewTextBoxColumn.Width = 107;
            // 
            // contentTypeDataGridViewTextBoxColumn
            // 
            this.contentTypeDataGridViewTextBoxColumn.DataPropertyName = "ContentType";
            this.contentTypeDataGridViewTextBoxColumn.HeaderText = "ContentType";
            this.contentTypeDataGridViewTextBoxColumn.Name = "contentTypeDataGridViewTextBoxColumn";
            this.contentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentTypeDataGridViewTextBoxColumn.Width = 108;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyDataGridViewTextBoxColumn.Width = 107;
            // 
            // queryStringDataGridViewTextBoxColumn
            // 
            this.queryStringDataGridViewTextBoxColumn.DataPropertyName = "QueryString";
            this.queryStringDataGridViewTextBoxColumn.HeaderText = "QueryString";
            this.queryStringDataGridViewTextBoxColumn.Name = "queryStringDataGridViewTextBoxColumn";
            this.queryStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.queryStringDataGridViewTextBoxColumn.Width = 108;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPDataGridViewTextBoxColumn.Width = 107;
            // 
            // userAgentDataGridViewTextBoxColumn
            // 
            this.userAgentDataGridViewTextBoxColumn.DataPropertyName = "UserAgent";
            this.userAgentDataGridViewTextBoxColumn.HeaderText = "UserAgent";
            this.userAgentDataGridViewTextBoxColumn.Name = "userAgentDataGridViewTextBoxColumn";
            this.userAgentDataGridViewTextBoxColumn.ReadOnly = true;
            this.userAgentDataGridViewTextBoxColumn.Width = 107;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 108;
            // 
            // additionalInfoDataGridViewTextBoxColumn
            // 
            this.additionalInfoDataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfo";
            this.additionalInfoDataGridViewTextBoxColumn.HeaderText = "AdditionalInfo";
            this.additionalInfoDataGridViewTextBoxColumn.Name = "additionalInfoDataGridViewTextBoxColumn";
            this.additionalInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.additionalInfoDataGridViewTextBoxColumn.Width = 107;
            // 
            // logInfoViewModelBindingSource
            // 
            this.logInfoViewModelBindingSource.DataSource = typeof(WinLogViewer.LogInfoViewModel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(827, 23);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 809);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInfoViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnBrowserPath;
        private Label lblLog;
        private GroupBox groupBox1;
        private Button btnReadLog;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn controllerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn queryStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userAgentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionalInfoDataGridViewTextBoxColumn;
        private BindingSource logInfoViewModelBindingSource;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}