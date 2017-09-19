namespace Feincraft.MiniWeb
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblForward = new System.Windows.Forms.Label();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.pnlTools.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webMain
            // 
            this.webMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMain.Location = new System.Drawing.Point(0, 34);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(499, 361);
            this.webMain.TabIndex = 0;
            this.webMain.Url = new System.Uri("http://www.duckduckgo.com", System.UriKind.Absolute);
            this.webMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webMain_Navigating);
            // 
            // txtURL
            // 
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtURL.Location = new System.Drawing.Point(74, 0);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(425, 22);
            this.txtURL.TabIndex = 1;
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURL_KeyPress);
            this.txtURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyUp);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.SlateGray;
            this.pnlTools.Controls.Add(this.txtURL);
            this.pnlTools.Controls.Add(this.panel2);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTools.Location = new System.Drawing.Point(0, 10);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(499, 24);
            this.pnlTools.TabIndex = 2;
            this.pnlTools.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.lblForward);
            this.panel2.Controls.Add(this.lblBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 24);
            this.panel2.TabIndex = 2;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Wingdings 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblBack.Location = new System.Drawing.Point(3, 1);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(27, 23);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "t";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblForward
            // 
            this.lblForward.AutoSize = true;
            this.lblForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForward.Font = new System.Drawing.Font("Wingdings 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblForward.Location = new System.Drawing.Point(26, 1);
            this.lblForward.Name = "lblForward";
            this.lblForward.Size = new System.Drawing.Size(27, 23);
            this.lblForward.TabIndex = 1;
            this.lblForward.Text = "u";
            this.lblForward.Click += new System.EventHandler(this.lblForward_Click);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Font = new System.Drawing.Font("Wingdings 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRefresh.Location = new System.Drawing.Point(47, 1);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(27, 23);
            this.lblRefresh.TabIndex = 2;
            this.lblRefresh.Text = "Q";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(499, 395);
            this.ControlBox = false;
            this.Controls.Add(this.webMain);
            this.Controls.Add(this.pnlTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainFrame";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label lblForward;
        private System.Windows.Forms.Label lblBack;
    }
}

