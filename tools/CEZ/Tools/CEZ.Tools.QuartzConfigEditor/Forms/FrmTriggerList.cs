using CEZ.Tools.QuartzConfigEditor.Entity;
using CEZ.Tools.QuartzConfigEditor.Entity.DTO;
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
    public partial class FrmTriggerList : Form
    {
        XmlJob _Job;

        public FrmTriggerList(XmlJob job)
        {
            this._Job = job;
            InitializeComponent();
        }

        private void FrmTriggerList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dgvTriggers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            XmlBaseTrigger trigger = GetSelectedTrigger();
            OpenEditForm(trigger, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            XmlTrigger trigger = new XmlTrigger();
            trigger.CronTrigger = new XmlCronTrigger() { JobGroup = this._Job.Group, JobName = this._Job.Name };
            _Job.Triggers.Add(trigger);
            OpenEditForm(trigger.CronTrigger, true);
        }

        private void btnAddSimple_Click(object sender, EventArgs e)
        {
            XmlTrigger trigger = new XmlTrigger();
            trigger.SimpleTrigger = new XmlSimpleTrigger() { JobGroup = this._Job.Group, JobName = this._Job.Name
                , StartTime = DateTime.Now, EndTime = DateTime.Now.AddYears(1) };
            _Job.Triggers.Add(trigger);
            OpenEditForm(trigger.SimpleTrigger, true);
        }

        private void LoadList()
        {
            dgvTriggers.DataSource = _Job.GetAllTriggers();
            dgvTriggers.Refresh();
        }

        private void OpenEditForm(XmlBaseTrigger trigger, bool isAddNew = false)
        {
            DialogResult dr = System.Windows.Forms.DialogResult.Cancel;
            if (trigger is XmlCronTrigger)
            {
                FrmTriggerEditCron frmCron = new FrmTriggerEditCron((XmlCronTrigger)trigger);
                dr = frmCron.ShowDialog();
            }
            else if (trigger is XmlSimpleTrigger)
            {
                FrmTriggerEditSimple frmSimple = new FrmTriggerEditSimple((XmlSimpleTrigger)trigger);
                dr = frmSimple.ShowDialog();
            }
            if (dr != System.Windows.Forms.DialogResult.OK && isAddNew)
            {
                DeleteTrigger(trigger);
            }
            LoadList();
        }

        private XmlBaseTrigger GetSelectedTrigger()
        {
            XmlBaseTrigger trigger = (XmlBaseTrigger)dgvTriggers.SelectedRows[0].DataBoundItem;
            return trigger;
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void DeleteTrigger(XmlBaseTrigger trigger)
        {
            if (trigger != null)
            {
                XmlTrigger trg = this._Job.Triggers.FirstOrDefault(x => x.GetTrigger().Name == trigger.Name);
                if (trg != null)
                {
                    this._Job.Triggers.Remove(trg);
                    LoadList();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlBaseTrigger trigger = GetSelectedTrigger();
            DeleteTrigger(trigger);
        }

    }
}
