using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEZ.Core.Infrastructure.Extensions;

namespace CEZ.Tools.QuartzConfigEditor
{
    public partial class FrmCronBuilder : Form
    {
        public string CronExpression { get; set; }

        public FrmCronBuilder()
        {
            InitializeComponent();
        }

        #region Event Handler

        private void FrmCronBuilder_Load(object sender, EventArgs e)
        {
            InitControls();
            LoadForm();
        }

        private void InitControls()
        {
            cmbIntervalType.SelectedIndex = 0;
            dtpDailyExecuteTime.Value = dtpDailyExecuteTime.MinDate;
            dtpWeeklyExecute.Value = dtpWeeklyExecute.MinDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm(false);
        }

        #endregion

        #region Cron builder

        private string GetExpression()
        {
            string result = string.Empty;
            if (tabControl1.SelectedTab == tabPage1)
            {
                result = GetInterval();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                result = GetDaily();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                result = GetWeekly();
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                result = GetMonthly();
            }
            return result;
        }

        private string GetInterval()
        {
            DateTime selected = dtpDailyExecuteTime.Value;
            string result = "10 0/5 * 1/1 * ? *";
            string sec = "*";
            string min = "*";
            string hour = "*";
            string day = "?";
            string month = "*";
            string dow = "?";

            switch (Convert.ToString(cmbIntervalType.SelectedItem))
            {
                case "Seconds":
                    sec = GetPartFormat(0, nudInterval.Value);
                    break;
                case "Minutes":
                    min = GetPartFormat(0, nudInterval.Value);
                    break;
                case "Hours":
                    hour = GetPartFormat(0, nudInterval.Value);
                    break;
                case "Days":
                    day = GetPartFormat(0, nudInterval.Value);
                    break;
            }

            result = string.Format("{0} {1} {2} {3} {4} {5}"
                , sec, min, hour
                , day, month, dow);

            return result;
        }


        private string GetDaily()
        {
            DateTime selected = dtpDailyExecuteTime.Value;
            string result = "10 0/5 * 1/1 * ? *";
            string sec = "";
            string min = "";
            string hour = "";
            string day = "*";
            string month = "*";
            string dow = "?";

            result = string.Format("{0} {1} {2} {3} {4} {5}"
                , selected.Second, selected.Minute, selected.Hour
                , day, month, dow);

            return result;
        }

        private string GetWeekly()
        {
            DateTime selected = dtpWeeklyExecute.Value;
            string day = "*";
            string month = "*";
            string dow = "?";

            string dowStr = clbWeekday.CheckedItems.Cast<string>().ToList().ConcatAsString(",");
            if (!string.IsNullOrEmpty(dowStr))
            {
                dow = dowStr;
            }
            
            string result = string.Format("{0} {1} {2} {3} {4} {5}"
                , selected.Second, selected.Minute, selected.Hour
                , day, month, dow);

            return result;
        }

        private string GetMonthly()
        {
            DateTime selected = dtpDailyExecuteTime.Value;
            string day = "*";
            string month = "*";
            string dow = "?";

            StringBuilder sb = new StringBuilder();
            foreach (String wd in clbWeekday.CheckedItems)
            {
                sb.AppendFormat("{0},", wd);
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 2, 1);
                dow = sb.ToString();
            }

            string result = string.Format("{0} {1} {2} {3} {4} {5}"
                , selected.Second, selected.Minute, selected.Hour
                , day, month, dow);

            return result;
        }

        private void SetExpression()
        {

        }

        private string GetPartFormat(int start = -1, decimal repeat = -1)
        {
            return GetPartFormat(start, Convert.ToInt32(repeat)); 
        }

        private string GetPartFormat(int start = -1, int repeat = -1)
        {
            if (start < 0 && repeat < 0)
                return "*";

            if (start < 0)
                start = 0;

            if(repeat < 0)
                return string.Format("{0}", start);

            return string.Format("{0}/{1}", start, repeat);
        }
        #endregion

        private void LoadForm()
        {
        }

        private void SaveForm()
        {
            this.CronExpression = GetExpression();
            CloseForm(true);
        }

        private void CloseForm(bool isSave)
        {
            this.DialogResult = isSave ? System.Windows.Forms.DialogResult.OK : System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmbIntervalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (Convert.ToString(cmbIntervalType.SelectedItem))
            //{
            //    case "Seconds":
            //        nudInterval.Maximum = 60;
            //        break;
            //    case "Minutes":
            //        nudInterval.Maximum = 60;
            //        break;
            //    case "Hours":
            //        nudInterval.Maximum = 24;
            //        break;
            //    case "Days":
            //        nudInterval.Maximum = 30;
            //        break;
            //}

        }

        private void chkAllWeekday_CheckedChanged(object sender, EventArgs e)
        {
            clbWeekday.CheckAll(chkAllWeekday.Checked);
        }

        #region Utility


        #endregion
    }
}
