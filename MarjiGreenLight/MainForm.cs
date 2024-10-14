using HtmlAgilityPack;
using System.Media;

namespace MarjiGreenLight {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e) {
            //Grabs URL from Directions window and starts screen scraping BikeReg.
            var htmlWeb = new HtmlWeb();
            string opensAt = "null";
            string password = "null";
            while (true) {
                var webPage = htmlWeb.Load(frmDirections.urlInsert);
                var determination = webPage.DocumentNode.SelectSingleNode("//body/form/div/div/div/div/div/div/div/h3/span");
                var regOpens = webPage.DocumentNode.SelectSingleNode("//body/form/div/div/div/div/div/div/div/div/h3/span");
                if (determination != null) {
                    password = determination.InnerHtml.ToString();
                }
                if (regOpens != null) {
                    opensAt = regOpens.InnerHtml.ToString();
                }
                if (password == "null" && opensAt == "null") {
                    pbTrafficLight.BackColor = Color.Lime;
                    SystemSounds.Hand.Play();
                    break;
                } else {
                    Thread.Sleep(5000);
                }
                webPage = null;
            }
        }
        private void btnClose_Click(Object sender, EventArgs e) {this.Close();}
        private void btnDirections_Click(Object sender, EventArgs e) {
            var frmDirections = new frmDirections();
            frmDirections.Show();
        }
    }
}
