namespace Computer_Controller
{
    partial class FormController
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
            this.components = new System.ComponentModel.Container();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tab_timer = new MetroFramework.Controls.MetroTabPage();
            this.lbl_timer = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textbox_shutdown = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textbox_restart = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.timer_pcController = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl.SuspendLayout();
            this.tab_timer.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.metroTabControl.Controls.Add(this.tab_timer);
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Controls.Add(this.metroTabPage3);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl.HotTrack = true;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.MinimumSize = new System.Drawing.Size(10, 10);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 2;
            this.metroTabControl.Size = new System.Drawing.Size(542, 100);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // tab_timer
            // 
            this.tab_timer.Controls.Add(this.lbl_timer);
            this.tab_timer.HorizontalScrollbarBarColor = true;
            this.tab_timer.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_timer.HorizontalScrollbarSize = 10;
            this.tab_timer.Location = new System.Drawing.Point(4, 4);
            this.tab_timer.Name = "tab_timer";
            this.tab_timer.Size = new System.Drawing.Size(534, 58);
            this.tab_timer.TabIndex = 0;
            this.tab_timer.Text = "  Timer  ";
            this.tab_timer.VerticalScrollbarBarColor = true;
            this.tab_timer.VerticalScrollbarHighlightOnWheel = false;
            this.tab_timer.VerticalScrollbarSize = 10;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_timer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_timer.Location = new System.Drawing.Point(13, 11);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(22, 25);
            this.lbl_timer.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "0";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.textbox_shutdown);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(534, 58);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = " Shutdown  ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(165, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "minute(s)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Shutdown after";
            // 
            // textbox_shutdown
            // 
            // 
            // 
            // 
            this.textbox_shutdown.CustomButton.Image = null;
            this.textbox_shutdown.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.textbox_shutdown.CustomButton.Name = "";
            this.textbox_shutdown.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_shutdown.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_shutdown.CustomButton.TabIndex = 1;
            this.textbox_shutdown.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_shutdown.CustomButton.UseSelectable = true;
            this.textbox_shutdown.CustomButton.Visible = false;
            this.textbox_shutdown.Lines = new string[] {
        "0"};
            this.textbox_shutdown.Location = new System.Drawing.Point(106, 17);
            this.textbox_shutdown.MaxLength = 32767;
            this.textbox_shutdown.Name = "textbox_shutdown";
            this.textbox_shutdown.PasswordChar = '\0';
            this.textbox_shutdown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_shutdown.SelectedText = "";
            this.textbox_shutdown.SelectionLength = 0;
            this.textbox_shutdown.SelectionStart = 0;
            this.textbox_shutdown.ShortcutsEnabled = true;
            this.textbox_shutdown.Size = new System.Drawing.Size(53, 23);
            this.textbox_shutdown.TabIndex = 3;
            this.textbox_shutdown.Text = "0";
            this.textbox_shutdown.UseSelectable = true;
            this.textbox_shutdown.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_shutdown.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(233, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Start";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.ShutdownButtonClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.textbox_restart);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(534, 58);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = " Restart  ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(165, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "minute(s)";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Restart after";
            // 
            // textbox_restart
            // 
            // 
            // 
            // 
            this.textbox_restart.CustomButton.Image = null;
            this.textbox_restart.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.textbox_restart.CustomButton.Name = "";
            this.textbox_restart.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_restart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_restart.CustomButton.TabIndex = 1;
            this.textbox_restart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_restart.CustomButton.UseSelectable = true;
            this.textbox_restart.CustomButton.Visible = false;
            this.textbox_restart.Lines = new string[] {
        "0"};
            this.textbox_restart.Location = new System.Drawing.Point(106, 17);
            this.textbox_restart.MaxLength = 32767;
            this.textbox_restart.Name = "textbox_restart";
            this.textbox_restart.PasswordChar = '\0';
            this.textbox_restart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_restart.SelectedText = "";
            this.textbox_restart.SelectionLength = 0;
            this.textbox_restart.SelectionStart = 0;
            this.textbox_restart.ShortcutsEnabled = true;
            this.textbox_restart.Size = new System.Drawing.Size(53, 23);
            this.textbox_restart.TabIndex = 7;
            this.textbox_restart.Text = "0";
            this.textbox_restart.UseSelectable = true;
            this.textbox_restart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_restart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(233, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(92, 52);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Start";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.RestartButtonClick);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(534, 58);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "  Logoff  ";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // timer_pcController
            // 
            this.timer_pcController.Tick += new System.EventHandler(this.ShutDownTimerTick);
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 172);
            this.Controls.Add(this.metroTabControl);
            this.Name = "FormController";
            this.Text = "Computer Controller";
            this.metroTabControl.ResumeLayout(false);
            this.tab_timer.ResumeLayout(false);
            this.tab_timer.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage tab_timer;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textbox_shutdown;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lbl_timer;
        private System.Windows.Forms.Timer timer_pcController;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textbox_restart;
        private MetroFramework.Controls.MetroButton metroButton2;


    }
}

