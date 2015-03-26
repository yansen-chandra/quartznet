namespace CEZ.Tools.QuartzConfigEditor
{
    partial class FrmTriggerList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTriggers = new System.Windows.Forms.DataGridView();
            this.btnAddCron = new System.Windows.Forms.Button();
            this.btnAddSimple = new System.Windows.Forms.Button();
            this.cmsGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriggers)).BeginInit();
            this.cmsGridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddSimple);
            this.panel1.Controls.Add(this.btnAddCron);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTriggers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 385);
            this.panel2.TabIndex = 2;
            // 
            // dgvTriggers
            // 
            this.dgvTriggers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTriggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTriggers.ContextMenuStrip = this.cmsGridMenu;
            this.dgvTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTriggers.Location = new System.Drawing.Point(0, 0);
            this.dgvTriggers.MultiSelect = false;
            this.dgvTriggers.Name = "dgvTriggers";
            this.dgvTriggers.ReadOnly = true;
            this.dgvTriggers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTriggers.Size = new System.Drawing.Size(658, 385);
            this.dgvTriggers.TabIndex = 1;
            this.dgvTriggers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTriggers_CellDoubleClick);
            // 
            // btnAddCron
            // 
            this.btnAddCron.Location = new System.Drawing.Point(499, 6);
            this.btnAddCron.Name = "btnAddCron";
            this.btnAddCron.Size = new System.Drawing.Size(75, 23);
            this.btnAddCron.TabIndex = 3;
            this.btnAddCron.Text = "Add Cron";
            this.btnAddCron.UseVisualStyleBackColor = true;
            this.btnAddCron.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddSimple
            // 
            this.btnAddSimple.Location = new System.Drawing.Point(418, 6);
            this.btnAddSimple.Name = "btnAddSimple";
            this.btnAddSimple.Size = new System.Drawing.Size(75, 23);
            this.btnAddSimple.TabIndex = 4;
            this.btnAddSimple.Text = "Add Simple";
            this.btnAddSimple.UseVisualStyleBackColor = true;
            this.btnAddSimple.Click += new System.EventHandler(this.btnAddSimple_Click);
            // 
            // cmsGridMenu
            // 
            this.cmsGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsGridMenu.Name = "cmsGridMenu";
            this.cmsGridMenu.Size = new System.Drawing.Size(106, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FrmTriggerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTriggerList";
            this.Text = "FrmTriggerList";
            this.Load += new System.EventHandler(this.FrmTriggerList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriggers)).EndInit();
            this.cmsGridMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTriggers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddCron;
        private System.Windows.Forms.Button btnAddSimple;
        private System.Windows.Forms.ContextMenuStrip cmsGridMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}