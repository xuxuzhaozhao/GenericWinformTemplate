using GenericWinformTemplate.Forms;
using GenericWinformTemplate.Infrastructures;
using GenericWinformTemplate.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GenericWinformTemplate
{
    public partial class MainForm : Form
    {
        public MainForm() { } // for design time

        private readonly IServiceProvider _serviceProvider;
        private readonly ITestService _testService;
        public MainForm(IServiceProvider serviceProvider, ITestService testService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _testService = testService;
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<SettingsForm>().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var message = ConfigurationHelper.Current.AppSettings.Name;
            _testService.SayHello(message);
        }
    }
}
