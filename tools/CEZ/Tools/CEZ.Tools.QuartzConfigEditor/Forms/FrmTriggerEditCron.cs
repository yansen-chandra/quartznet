using CEZ.Tools.QuartzConfigEditor.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEZ.Tools.QuartzConfigEditor
{
    public partial class FrmTriggerEditCron : Form
    {
        XmlCronTrigger _Trigger;
        //public bool IsSaved { get; set; }

        public FrmTriggerEditCron(XmlCronTrigger trigger)
        {
            //this.IsSaved = false;
            this._Trigger = trigger;
            InitializeComponent();
        }

        #region Event Handler

        private void FrmTriggerEditCron_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
            CloseForm(true);
        }

        #endregion

        private void LoadForm()
        {
            txtName.Text = _Trigger.Name;
            txtGroup.Text = _Trigger.Group;
            txtDescription.Text = _Trigger.Description;
            txtExpression.Text = _Trigger.CronExpression;
        }

        private void SaveForm()
        {
            _Trigger.Name = txtName.Text;
            _Trigger.Group = txtGroup.Text;
            _Trigger.Description = txtDescription.Text;
            _Trigger.CronExpression = txtExpression.Text;
            //this.IsSaved = true;
        }

        private void CloseForm(bool isSave)
        {
            this.DialogResult = isSave ? System.Windows.Forms.DialogResult.OK : System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnBuildCron_Click(object sender, EventArgs e)
        {
            FrmCronBuilder form = new FrmCronBuilder();
            form.ShowDialog();
            txtExpression.Text = form.CronExpression;
        }

    }
}
