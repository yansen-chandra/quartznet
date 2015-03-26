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
    public partial class FrmTriggerEditSimple : Form
    {
        XmlSimpleTrigger _Trigger;
        //public bool IsSaved { get; set; }

        public FrmTriggerEditSimple(XmlSimpleTrigger trigger)
        {
            //this.IsSaved = false;
            this._Trigger = trigger;
            InitializeComponent();
        }

        #region Event Handler

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveForm();
            CloseForm(true);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            CloseForm(false);
        }

        private void FrmTriggerEditSimple_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
            txtName.Text = _Trigger.Name;
            txtGroup.Text = _Trigger.Group;
            txtDescription.Text = _Trigger.Description;
            dtpStart.Value = _Trigger.StartTime;
            dtpEnd.Value = _Trigger.EndTime;
            nudRepeatCount.Value = _Trigger.RepeatCount;
            nudRepeatInterval.Value = _Trigger.RepeatInterval;
        }

        private void SaveForm()
        {
            _Trigger.Name = txtName.Text;
            _Trigger.Group = txtGroup.Text;
            _Trigger.Description = txtDescription.Text;
            _Trigger.StartTime = dtpStart.Value;
            _Trigger.EndTime = dtpEnd.Value;
            _Trigger.RepeatCount = Convert.ToInt32(nudRepeatCount.Value);
            _Trigger.RepeatInterval = Convert.ToInt32(nudRepeatInterval.Value);
        }

        private void CloseForm(bool isSave)
        {
            this.DialogResult = isSave ? System.Windows.Forms.DialogResult.OK  : System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
