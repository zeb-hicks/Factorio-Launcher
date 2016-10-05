using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Factorio_Launcher {
    public partial class MainWindow : Form {
        private AboutWindow aboutWindow = new AboutWindow();
        private SettingsWindow settingsWindow = new SettingsWindow();

        public MainWindow() {
            InitializeComponent();
            this.FormClosed += WindowClosed;

            ConfigurationList.SelectedIndexChanged += ConfigSelectionChange;
            ConfigurationList.DoubleClick += ConfigDoubleClick;

            LaunchButton.Click += LaunchButtonClick;
        }

        private void LaunchButtonClick(object sender, EventArgs e) {
            LaunchConfig();
        }

        private void ConfigDoubleClick(object sender, EventArgs e) {
            LaunchConfig();
        }

        private void ConfigSelectionChange(object sender, EventArgs e) {
            if (ConfigurationList.SelectedItems.Count > 0) {
                // A configuration is selected.
                LaunchButton.Enabled = true;
            } else {
                // No configuration selected.
                LaunchButton.Enabled = false;
            }
        }

        private void WindowClosed(object sender, FormClosedEventArgs e) {
            aboutWindow.Dispose();
            settingsWindow.Dispose();
        }

        private void LauncherExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LauncherSettings_Click(object sender, EventArgs e) {
            if (settingsWindow.IsDisposed) {
                settingsWindow = new SettingsWindow();
            }
            settingsWindow.Show();
        }

        private void HelpAbout_Click(object sender, EventArgs e) {
            if (aboutWindow.IsDisposed) {
                aboutWindow = new AboutWindow();
            }
            aboutWindow.Show();
        }

        private void LaunchConfig() {
            //Process.Start("C:\\Program Files (x86)\\Steam\\SteamApps\\common\\Factorio\\bin\\x64\\factorio.exe", "--mp-connect \"spork.nimphio.us\"");
            Process game = new Process();
            game.StartInfo.FileName = "C:\\Games\\Factorio_0.14.12\\bin\\x64\\factorio.exe";
            game.StartInfo.Arguments = "--mp-connect \"spork.nimphio.us\"";
            game.StartInfo.CreateNoWindow = true;
            game.Start();
        }
    }
}
