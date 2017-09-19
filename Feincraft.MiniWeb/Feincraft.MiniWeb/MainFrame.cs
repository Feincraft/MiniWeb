using Feincraft.MiniWeb.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Feincraft.MiniWeb
{
    public partial class MainFrame : Form
    {
        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
        const int URLMON_OPTION_USERAGENT = 0x10000001;

        public MainFrame()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Boolean renav = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainFrame_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlTools.Visible = !pnlTools.Visible;
            txtURL.Focus();
        }

        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtURL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) pnlTools.Visible = false;
            if (e.KeyData == Keys.Enter)
            {
                pnlTools.Visible = false;
                webMain.Navigate(txtURL.Text);
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            if (Settings.Default.UseCustomSA)
            {
                String agent = Settings.Default.UserAgent;
                UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, agent, agent.Length, 0);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            webMain.GoBack();
        }

        private void lblForward_Click(object sender, EventArgs e)
        {
            webMain.GoForward();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            webMain.Refresh();
        }

        private void webMain_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }
    }
}
