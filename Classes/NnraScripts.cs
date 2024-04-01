using System.Drawing;
using System.Drawing.Drawing2D;

namespace Poliklinika.Classes
{
    public class NnraScripts : Form
    {
        public void ChangeMode(Form frm) 
        {
            if (Properties.Settings.Default.DarkMode)
            {
                frm.BackColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                frm.BackColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
