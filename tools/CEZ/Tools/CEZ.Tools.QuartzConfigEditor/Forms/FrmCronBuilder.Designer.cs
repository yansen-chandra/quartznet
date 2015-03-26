namespace CEZ.Tools.QuartzConfigEditor
{
    partial class FrmCronBuilder
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbIntervalType = new System.Windows.Forms.ComboBox();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDailyExecuteTime = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkAllWeekday = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbWeekday = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpWeeklyExecute = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbWeekInterval = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkMonthlyCheckAllWeekday = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clbMonthlyWeekday = new System.Windows.Forms.CheckedListBox();
            this.chkMonthlyCheckAllMonth = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clbMOnthlyMOnth = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpMonthlyExecute = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(393, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 246);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbIntervalType);
            this.tabPage1.Controls.Add(this.nudInterval);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interval";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbIntervalType
            // 
            this.cmbIntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalType.FormattingEnabled = true;
            this.cmbIntervalType.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.cmbIntervalType.Location = new System.Drawing.Point(194, 19);
            this.cmbIntervalType.Name = "cmbIntervalType";
            this.cmbIntervalType.Size = new System.Drawing.Size(94, 21);
            this.cmbIntervalType.TabIndex = 35;
            this.cmbIntervalType.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalType_SelectedIndexChanged);
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(68, 20);
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(120, 20);
            this.nudInterval.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Every";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtpDailyExecuteTime);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daily";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Execute Time";
            // 
            // dtpDailyExecuteTime
            // 
            this.dtpDailyExecuteTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDailyExecuteTime.Location = new System.Drawing.Point(105, 17);
            this.dtpDailyExecuteTime.Name = "dtpDailyExecuteTime";
            this.dtpDailyExecuteTime.ShowUpDown = true;
            this.dtpDailyExecuteTime.Size = new System.Drawing.Size(93, 20);
            this.dtpDailyExecuteTime.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkAllWeekday);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.clbWeekday);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dtpWeeklyExecute);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(452, 220);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Weekly";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkAllWeekday
            // 
            this.chkAllWeekday.AutoSize = true;
            this.chkAllWeekday.Location = new System.Drawing.Point(105, 43);
            this.chkAllWeekday.Name = "chkAllWeekday";
            this.chkAllWeekday.Size = new System.Drawing.Size(71, 17);
            this.chkAllWeekday.TabIndex = 24;
            this.chkAllWeekday.Text = "Check All";
            this.chkAllWeekday.UseVisualStyleBackColor = true;
            this.chkAllWeekday.CheckedChanged += new System.EventHandler(this.chkAllWeekday_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Month";
            // 
            // clbWeekday
            // 
            this.clbWeekday.FormattingEnabled = true;
            this.clbWeekday.Items.AddRange(new object[] {
            "MON",
            "TUE",
            "WED",
            "THU",
            "FRI",
            "SAT",
            "SUN"});
            this.clbWeekday.Location = new System.Drawing.Point(105, 66);
            this.clbWeekday.Name = "clbWeekday";
            this.clbWeekday.Size = new System.Drawing.Size(108, 109);
            this.clbWeekday.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Execute Time";
            // 
            // dtpWeeklyExecute
            // 
            this.dtpWeeklyExecute.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWeeklyExecute.Location = new System.Drawing.Point(105, 17);
            this.dtpWeeklyExecute.Name = "dtpWeeklyExecute";
            this.dtpWeeklyExecute.ShowUpDown = true;
            this.dtpWeeklyExecute.Size = new System.Drawing.Size(93, 20);
            this.dtpWeeklyExecute.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbWeekInterval);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.chkMonthlyCheckAllWeekday);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.clbMonthlyWeekday);
            this.tabPage4.Controls.Add(this.chkMonthlyCheckAllMonth);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.clbMOnthlyMOnth);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.dtpMonthlyExecute);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(452, 220);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Monthly";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbWeekInterval
            // 
            this.cmbWeekInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeekInterval.FormattingEnabled = true;
            this.cmbWeekInterval.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Last"});
            this.cmbWeekInterval.Location = new System.Drawing.Point(334, 16);
            this.cmbWeekInterval.Name = "cmbWeekInterval";
            this.cmbWeekInterval.Size = new System.Drawing.Size(94, 21);
            this.cmbWeekInterval.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Weektime";
            // 
            // chkMonthlyCheckAllWeekday
            // 
            this.chkMonthlyCheckAllWeekday.AutoSize = true;
            this.chkMonthlyCheckAllWeekday.Location = new System.Drawing.Point(337, 43);
            this.chkMonthlyCheckAllWeekday.Name = "chkMonthlyCheckAllWeekday";
            this.chkMonthlyCheckAllWeekday.Size = new System.Drawing.Size(71, 17);
            this.chkMonthlyCheckAllWeekday.TabIndex = 32;
            this.chkMonthlyCheckAllWeekday.Text = "Check All";
            this.chkMonthlyCheckAllWeekday.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Weekdays";
            // 
            // clbMonthlyWeekday
            // 
            this.clbMonthlyWeekday.FormattingEnabled = true;
            this.clbMonthlyWeekday.Items.AddRange(new object[] {
            "MON",
            "TUE",
            "WED",
            "THU",
            "FRI",
            "SAT",
            "SUN"});
            this.clbMonthlyWeekday.Location = new System.Drawing.Point(337, 66);
            this.clbMonthlyWeekday.Name = "clbMonthlyWeekday";
            this.clbMonthlyWeekday.Size = new System.Drawing.Size(91, 109);
            this.clbMonthlyWeekday.TabIndex = 30;
            // 
            // chkMonthlyCheckAllMonth
            // 
            this.chkMonthlyCheckAllMonth.AutoSize = true;
            this.chkMonthlyCheckAllMonth.Location = new System.Drawing.Point(105, 43);
            this.chkMonthlyCheckAllMonth.Name = "chkMonthlyCheckAllMonth";
            this.chkMonthlyCheckAllMonth.Size = new System.Drawing.Size(71, 17);
            this.chkMonthlyCheckAllMonth.TabIndex = 29;
            this.chkMonthlyCheckAllMonth.Text = "Check All";
            this.chkMonthlyCheckAllMonth.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Weekdays";
            // 
            // clbMOnthlyMOnth
            // 
            this.clbMOnthlyMOnth.FormattingEnabled = true;
            this.clbMOnthlyMOnth.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.clbMOnthlyMOnth.Location = new System.Drawing.Point(105, 66);
            this.clbMOnthlyMOnth.Name = "clbMOnthlyMOnth";
            this.clbMOnthlyMOnth.Size = new System.Drawing.Size(108, 139);
            this.clbMOnthlyMOnth.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Execute Time";
            // 
            // dtpMonthlyExecute
            // 
            this.dtpMonthlyExecute.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMonthlyExecute.Location = new System.Drawing.Point(105, 17);
            this.dtpMonthlyExecute.Name = "dtpMonthlyExecute";
            this.dtpMonthlyExecute.ShowUpDown = true;
            this.dtpMonthlyExecute.Size = new System.Drawing.Size(93, 20);
            this.dtpMonthlyExecute.TabIndex = 25;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd MMM yyyy HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(98, 289);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 16;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd MMM yyyy HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(98, 264);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start Time";
            // 
            // FrmCronBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 364);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmCronBuilder";
            this.Text = "FrmCronBuilder";
            this.Load += new System.EventHandler(this.FrmCronBuilder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDailyExecuteTime;
        private System.Windows.Forms.CheckBox chkAllWeekday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbWeekday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpWeeklyExecute;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkMonthlyCheckAllMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbMOnthlyMOnth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpMonthlyExecute;
        private System.Windows.Forms.ComboBox cmbWeekInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkMonthlyCheckAllWeekday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox clbMonthlyWeekday;
        private System.Windows.Forms.ComboBox cmbIntervalType;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label label8;
    }
}