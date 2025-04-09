using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericWinformTemplate.Infrastructures;
using Newtonsoft.Json.Linq;

namespace GenericWinformTemplate.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            txtName.Text = ConfigurationHelper.Current.AppSettings.Name;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var configPath = Path.Combine(AppContext.BaseDirectory, "appSettings.json");

            var config = JObject.Parse(await File.ReadAllTextAsync(configPath));

            config["AppSettings"]["Name"] = txtName.Text;

            await File.WriteAllTextAsync(configPath, config.ToString());

            Close();
        }
    }
}
