using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portal
{
    public class Base64Convert
    {
        public static String FileToBase64(Stream fs)
        {
            String strRet = String.Empty;
            try
            {
                if (fs == null)
                    return strRet;
                byte[] bt = new byte[fs.Length];
                fs.Read(bt, 0, bt.Length);
                strRet = Convert.ToBase64String(bt);
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return strRet;
        }
    }
}
