using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControlesPersonalizados
{
    public class Controles
    {

        public static string InputBoxPassword(string prompt, string title)
        {
            InputBoxPasswordDialog ib = new InputBoxPasswordDialog(prompt, title);
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        public static string InputBox(string prompt, string title)
        {
            InputBoxDialog ib = new InputBoxDialog(prompt,title);
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }


        public static void ShowLogDialog(string title , DataTable dt)
        {
            LogDialog ib = new LogDialog(title , dt);
            ib.ShowDialog();
        }

    }
}
