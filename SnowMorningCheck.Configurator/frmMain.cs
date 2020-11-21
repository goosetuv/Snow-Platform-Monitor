using System;
using System.Windows.Forms;

namespace SnowMorningCheck.Configurator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnServersSQLTest_Click(object sender, EventArgs e)
        {
            string SqlConnection = "Data Source=" + txtServersSQL.Text + ";Application Name=SMC.Configurator;User=" + txtlServersSQLUser.Text + ";Password=" + txtlServersSQLPass.Text + txtlServersSQLParam.Text;
            MessageBox.Show(Core.Utilities.IsSqlCorrect(SqlConnection).ToString());
        }
    }
}