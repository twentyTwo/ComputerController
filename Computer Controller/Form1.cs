using System.Diagnostics;
using MetroFramework.Forms;

namespace Computer_Controller
{
    public partial class formController : MetroForm
    {
        public formController()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            metroTabControl.SelectedTab = tab_timer;
            timer1.Start();
            metroLabel3.Text = metroTextBox1.Text;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            var a = int.Parse(metroLabel3.Text);
            a--;
            metroLabel3.Text = a.ToString();
        }
    }
}