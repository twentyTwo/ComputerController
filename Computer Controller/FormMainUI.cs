// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormMainUI.cs" company="">
//   
// </copyright>
// <summary>
//   The form controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Computer_Controller
{
    using System;

    using MetroFramework.Forms;

    /// <summary>
    /// The form controller.
    /// </summary>
    public partial class FormController : MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormController"/> class.
        /// </summary>
        public FormController()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The shutdown button click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ShutdownButtonClick(object sender, EventArgs e)
        {
            this.metroTabControl.SelectedTab = this.tab_timer;
            this.timer_pcController.Start();
            this.timer_pcController.Interval = 1000;
            this.lbl_timer.Text = this.textbox_shutdown.Text;
        }

        /// <summary>
        /// The shut down timer tick.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ShutDownTimerTick(object sender, EventArgs e)
        {
            var remainingSeconds = int.Parse(this.lbl_timer.Text);
            remainingSeconds--;
            this.lbl_timer.Text = remainingSeconds.ToString();
        }
    }
}