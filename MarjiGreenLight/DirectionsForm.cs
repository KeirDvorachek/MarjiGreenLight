using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarjiGreenLight {
    public partial class frmDirections : Form {
        public frmDirections() {
            InitializeComponent();
        }

        public static string urlInsert = "https://www.bikereg.com/marji-gesick-2025";

        private void btnClose_Click(object sender, EventArgs e) {this.Close();}
        private void btnSave_Click(object sender, EventArgs e) {
            urlInsert = txtInsertUrl.Text;
            this.Close();
        }
    }
}
