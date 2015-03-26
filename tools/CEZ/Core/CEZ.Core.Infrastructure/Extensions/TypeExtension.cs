using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Extensions
{
    public static class TypeExtension
    {
        public static void RemoveLastCharacter(this StringBuilder sb)
        {
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
        }

        public static string ConcatAsString(this List<string> list, string delimit)
        {
            StringBuilder sb = new StringBuilder();
            foreach (String str in list)
            {
                sb.AppendFormat("{0}{1}", str, delimit);
            }
            sb.RemoveLastCharacter();
            return sb.ToString();
            
        }
    }
}
