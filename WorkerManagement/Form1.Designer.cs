namespace WorkerManagement
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpInDay = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxDetail = new System.Windows.Forms.GroupBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQueryMobile = new System.Windows.Forms.TextBox();
            this.txtQueryName = new System.Windows.Forms.TextBox();
            this.gboxQuery = new System.Windows.Forms.GroupBox();
            this.txtQueryNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            this.WNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboxDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(261, 84);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(49, 30);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpInDay
            // 
            this.dtpInDay.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpInDay.CalendarTitleForeColor = System.Drawing.SystemColors.Desktop;
            this.dtpInDay.Location = new System.Drawing.Point(640, 34);
            this.dtpInDay.Name = "dtpInDay";
            this.dtpInDay.Size = new System.Drawing.Size(240, 33);
            this.dtpInDay.TabIndex = 5;
            this.dtpInDay.Value = new System.DateTime(2017, 12, 22, 15, 55, 59, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(948, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 34);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCommit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCommit.Location = new System.Drawing.Point(948, 49);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(110, 34);
            this.btnCommit.TabIndex = 16;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(206, 84);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 30);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1229, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(1229, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(1229, 228);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(127, 34);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "导入数据";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(1229, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gboxDetail
            // 
            this.gboxDetail.Controls.Add(this.rbFemale);
            this.gboxDetail.Controls.Add(this.dtpInDay);
            this.gboxDetail.Controls.Add(this.btnCancel);
            this.gboxDetail.Controls.Add(this.btnCommit);
            this.gboxDetail.Controls.Add(this.rbMale);
            this.gboxDetail.Controls.Add(this.btnChoose);
            this.gboxDetail.Controls.Add(this.photo);
            this.gboxDetail.Controls.Add(this.txtEmail);
            this.gboxDetail.Controls.Add(this.txtName);
            this.gboxDetail.Controls.Add(this.label6);
            this.gboxDetail.Controls.Add(this.label8);
            this.gboxDetail.Controls.Add(this.txtMobile);
            this.gboxDetail.Controls.Add(this.label9);
            this.gboxDetail.Controls.Add(this.label4);
            this.gboxDetail.Controls.Add(this.txtPosition);
            this.gboxDetail.Controls.Add(this.label7);
            this.gboxDetail.Controls.Add(this.txtNum);
            this.gboxDetail.Controls.Add(this.label10);
            this.gboxDetail.Controls.Add(this.label5);
            this.gboxDetail.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxDetail.Location = new System.Drawing.Point(263, 512);
            this.gboxDetail.Name = "gboxDetail";
            this.gboxDetail.Size = new System.Drawing.Size(1093, 173);
            this.gboxDetail.TabIndex = 15;
            this.gboxDetail.TabStop = false;
            this.gboxDetail.Text = "员工详细信息";
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoose.Location = new System.Drawing.Point(42, 137);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(47, 26);
            this.btnChoose.TabIndex = 15;
            this.btnChoose.Text = "选择";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // photo
            // 
            this.photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photo.Location = new System.Drawing.Point(15, 38);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(103, 117);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(640, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 29);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(386, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 29);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(131, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "性别：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(317, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "电话：";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMobile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMobile.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMobile.Location = new System.Drawing.Point(386, 83);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(146, 29);
            this.txtMobile.TabIndex = 10;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(131, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "职位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(131, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "工号：";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPosition.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPosition.Location = new System.Drawing.Point(206, 129);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(674, 33);
            this.txtPosition.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(540, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "邮        箱:";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNum.Location = new System.Drawing.Point(206, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(90, 29);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(540, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "入职日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(317, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "姓名：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 628);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtQueryMobile
            // 
            this.txtQueryMobile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtQueryMobile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryMobile.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQueryMobile.Location = new System.Drawing.Point(663, 58);
            this.txtQueryMobile.Name = "txtQueryMobile";
            this.txtQueryMobile.Size = new System.Drawing.Size(145, 29);
            this.txtQueryMobile.TabIndex = 5;
            this.txtQueryMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQueryMobile.TextChanged += new System.EventHandler(this.txtQueryMobile_TextChanged);
            // 
            // txtQueryName
            // 
            this.txtQueryName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtQueryName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQueryName.Location = new System.Drawing.Point(391, 58);
            this.txtQueryName.Name = "txtQueryName";
            this.txtQueryName.Size = new System.Drawing.Size(103, 29);
            this.txtQueryName.TabIndex = 3;
            this.txtQueryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQueryName.TextChanged += new System.EventHandler(this.txtQueryName_TextChanged);
            // 
            // gboxQuery
            // 
            this.gboxQuery.Controls.Add(this.txtQueryMobile);
            this.gboxQuery.Controls.Add(this.txtQueryName);
            this.gboxQuery.Controls.Add(this.txtQueryNum);
            this.gboxQuery.Controls.Add(this.label3);
            this.gboxQuery.Controls.Add(this.label2);
            this.gboxQuery.Controls.Add(this.label1);
            this.gboxQuery.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxQuery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gboxQuery.Location = new System.Drawing.Point(263, 68);
            this.gboxQuery.Name = "gboxQuery";
            this.gboxQuery.Size = new System.Drawing.Size(1093, 122);
            this.gboxQuery.TabIndex = 7;
            this.gboxQuery.TabStop = false;
            this.gboxQuery.Text = "员工信息查询";
            // 
            // txtQueryNum
            // 
            this.txtQueryNum.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtQueryNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryNum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQueryNum.Location = new System.Drawing.Point(108, 58);
            this.txtQueryNum.Name = "txtQueryNum";
            this.txtQueryNum.Size = new System.Drawing.Size(101, 29);
            this.txtQueryNum.TabIndex = 1;
            this.txtQueryNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQueryNum.TextChanged += new System.EventHandler(this.txtQueryNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(599, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(327, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号：";
            // 
            // dgvWorker
            // 
            this.dgvWorker.AllowUserToAddRows = false;
            this.dgvWorker.AllowUserToDeleteRows = false;
            this.dgvWorker.AllowUserToResizeColumns = false;
            this.dgvWorker.AllowUserToResizeRows = false;
            this.dgvWorker.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvWorker.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WNum,
            this.WName,
            this.InDay,
            this.Position,
            this.Mobile,
            this.Email});
            this.dgvWorker.EnableHeadersVisualStyles = false;
            this.dgvWorker.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvWorker.Location = new System.Drawing.Point(263, 208);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.ReadOnly = true;
            this.dgvWorker.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            this.dgvWorker.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvWorker.RowTemplate.Height = 23;
            this.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorker.Size = new System.Drawing.Size(951, 298);
            this.dgvWorker.TabIndex = 8;
            this.dgvWorker.SelectionChanged += new System.EventHandler(this.dgvWorker_SelectionChanged);
            // 
            // WNum
            // 
            this.WNum.DataPropertyName = "WNum";
            this.WNum.Frozen = true;
            this.WNum.HeaderText = "工号";
            this.WNum.Name = "WNum";
            this.WNum.ReadOnly = true;
            this.WNum.Width = 80;
            // 
            // WName
            // 
            this.WName.DataPropertyName = "WName";
            this.WName.Frozen = true;
            this.WName.HeaderText = "姓名";
            this.WName.Name = "WName";
            this.WName.ReadOnly = true;
            this.WName.Width = 80;
            // 
            // InDay
            // 
            this.InDay.DataPropertyName = "InDay";
            this.InDay.Frozen = true;
            this.InDay.HeaderText = "入职日期";
            this.InDay.Name = "InDay";
            this.InDay.ReadOnly = true;
            this.InDay.Width = 130;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.Frozen = true;
            this.Position.HeaderText = "职位";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 180;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.Frozen = true;
            this.Mobile.HeaderText = "电话号码";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 180;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(1296, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1378, 712);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboxDetail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboxQuery);
            this.Controls.Add(this.dgvWorker);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gboxDetail.ResumeLayout(false);
            this.gboxDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxQuery.ResumeLayout(false);
            this.gboxQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpInDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gboxDetail;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQueryMobile;
        private System.Windows.Forms.TextBox txtQueryName;
        private System.Windows.Forms.GroupBox gboxQuery;
        private System.Windows.Forms.TextBox txtQueryNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWorker;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn WNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn WName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

