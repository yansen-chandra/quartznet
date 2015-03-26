using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEZ.Core.Infrastructure.Extensions
{
    public static class WinformControlExtension
    {
        public static void CheckAll(this CheckedListBox clb, bool isChecked)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, isChecked);
            }
        }
    }
}
