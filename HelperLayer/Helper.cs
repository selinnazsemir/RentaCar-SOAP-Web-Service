using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HelperLayer
{
    public class Helper
    {
        public static string MD5eDonustur(string parola)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] md5Byte = Encoding.UTF8.GetBytes(parola);
            md5Byte = mD5CryptoServiceProvider.ComputeHash(md5Byte);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in md5Byte)
            {
                stringBuilder.Append(item.ToString("x2").ToLower());
            }
            return stringBuilder.ToString();
        }
        public static bool AlanKontrol(Control ctl)
        {
            bool kontrol = true;
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == "")
                    {
                        kontrol = false;
                        break;
                    }
                }
                else if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedIndex == -1)
                    { kontrol = false; break; }
                }
            }
            return kontrol;
        }
    }
}
