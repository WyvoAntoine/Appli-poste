using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFFRANCHISSEMENT_INTERNE
{
    static class Program
    {
       
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAffranchissement());
            
        }
        public static string prix;
    }
}
