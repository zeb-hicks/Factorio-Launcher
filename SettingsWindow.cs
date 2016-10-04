using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorio_Launcher {
    public partial class SettingsWindow : Form {
        public SettingsWindow() {
            InitializeComponent();
            this.FormClosing += WindowClosing;
        }

        private void WindowClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            // Save settings, then exit.
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

    }
}
