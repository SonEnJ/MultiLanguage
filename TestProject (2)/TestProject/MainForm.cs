using System.Globalization;
using System.Windows.Forms;

namespace TestProject
{
    public partial class MainForm : Form
    {

        private CultureInfo cultureInfo;
        private bool isKr = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(isKr)
            {
                cultureInfo = null;
                cultureInfo = new CultureInfo("en-US");
                LanguageResource.Culture = cultureInfo;

                isKr = false;
                this.button1.Text = "US";
            }
            else
            {
                cultureInfo = new CultureInfo("ko-KR");
                LanguageResource.Culture = cultureInfo;
                isKr = true;
                this.button1.Text = "KR";
            }

            this.valueLabel1.Text = TestProject.LanguageResource.key1;
            this.valueLabel2.Text = TestProject.LanguageResource.key2;
            this.label1.Text = TestProject.LanguageResource.Key3;
        }
    }
}