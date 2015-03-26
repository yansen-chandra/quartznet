using CEZ.Core.Infrastructure.Utilities;
using CEZ.Tools.QuartzConfigEditor.Entity;
using CEZ.Tools.QuartzConfigEditor.Entity.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor
{
    public partial class FrmMain : Form
    {
        DTOSchedule dto;
 
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Event Handler

        private void btnLoad_Click(object sender, EventArgs e)
        {
            XmlSchedule sch = SerializationUtility.Deserialize<XmlSchedule>(ReadFile());
            //string res = SerializationUtility.Serialize<XmlSchedule>(sch);
            //SaveFile(res);
            dto = new DTOSchedule(sch);
            Reload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Save? ", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;

            XmlSchedule sch = dto.GetJobSchedule();
            string res = SerializationUtility.Serialize<XmlSchedule>(sch);
            SaveFile(res);
            MessageBox.Show("Config Saved!!");
        }

        private void dgvConfigs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            triggersToolStripMenuItem_Click(sender, e);
        }

        #region Context Menu

        private void triggersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlJob job = GetSelectedJob();
            FrmTriggerList frm = new FrmTriggerList(job);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Delete ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;

            XmlJob job = GetSelectedJob();
            dgvConfigs.DataSource = null;
            dto.Jobs.Remove(job);
            Reload();
        }

        #endregion

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        #endregion

        #region Functions

        private string GetDummy()
        {
            return @"  <schedule>
    
    <job>
      <name>xmljobName1</name>
      <group>xmljobGroup1</group>
      <description>jobDesciption1</description>
      <job-type>NEC.NCSS.NIS.TaskScheduler.ConsoleApp.SimpleJob, NEC.NCSS.NIS.TaskScheduler.ConsoleApp</job-type>
      <durable>true</durable>
      <recover>false</recover>
      <job-data-map>
        <entry>
          <key>key0</key>
          <value>value0</value>
        </entry>
        <entry>
          <key>key1</key>
          <value>value1</value>
        </entry>
        <entry>
          <key>key2</key>
          <value>value2</value>
        </entry>
      </job-data-map>
    </job>

    <trigger>
      <simple>
        <name>xmlTrigger1</name>
        <group>xmljobGroup1</group>
        <description>SimpleTriggerDescription</description>
        <job-name>xmljobName1</job-name>
        <job-group>xmljobGroup1</job-group>
        <start-time>1982-06-28T18:15:00.0Z</start-time>
        <end-time>2020-05-04T18:13:51.0Z</end-time>
        <misfire-instruction>SmartPolicy</misfire-instruction>
        <repeat-count>100</repeat-count>
        <repeat-interval>5000</repeat-interval>
      </simple>
    </trigger>

    <trigger>
      <cron>
        <name>xmlCronTrigger1</name>
        <group>xmlCronjobGroup1</group>
        <description>A cron description</description>
        <job-name>xmljobName1</job-name>
        <job-group>xmljobGroup1</job-group>
        <cron-expression>0 0/1 * 1/1 * ? *</cron-expression>
      </cron>
    </trigger>

  </schedule>
  ";
        }

        private string ReadFile()
        {
            string result = "";
            string path = textBox1.Text;
            //XmlTextReader reader = new XmlTextReader(path);
            //result= reader.ReadElementContentAsString("schedule", "http://quartznet.sourceforge.net/JobSchedulingData");

            string xmlStr = File.ReadAllText(path);
            XElement xEl = XElement.Parse(xmlStr);
            XElement sEl = xEl.Elements().FirstOrDefault(x => x.Name.LocalName == "schedule");
            if (sEl != null)
            {
                result = sEl.ToString();
                //sEl.SetValue("test");
            }
            //XDocument document = XDocument.Parse(xmlStr);
            //var words = document.XPathSelectElements("//word[./category[text() = 'verb']]");
            return result;
        }

        private void SaveFile(string newElStr)
        {
            //string path = @"E:\Projects\CEZ\CEZ.Tools.QuartzConfigEditor\Files\quartz_jobs.xml";
            string path = textBox1.Text;

            string xmlStr = File.ReadAllText(path);
            XElement xEl = XElement.Parse(xmlStr);
            XElement sEl = xEl.Elements().FirstOrDefault(x => x.Name.LocalName == "schedule");
            if (sEl != null)
            {
                sEl.Remove();
                XElement myX = XElement.Parse(newElStr);
                xEl.Add(myX);
                //xEl.Save(@"E:\Projects\CEZ\CEZ.Tools.QuartzConfigEditor\Files\quartz_jobs_cjange.xml");
                File.Copy(path, string.Format("{0}.{1}.bak", path, DateTime.Now.ToString("yyyyMMddHHmmss")));
                xEl.Save(path);
            }
        }

        private XmlJob GetSelectedJob()
        {
            XmlJob job = (XmlJob)dgvConfigs.SelectedRows[0].DataBoundItem;
            return job;
        }

        private void Reload()
        {
            BindingList<XmlJob> list = new BindingList<XmlJob>(dto.Jobs);
            list.AllowNew = true;
            dgvConfigs.DataSource = list;
            dgvConfigs.Refresh();
        }

        #endregion

    }
}
