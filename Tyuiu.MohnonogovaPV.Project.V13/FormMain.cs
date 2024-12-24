using Tyuiu.MohnonogovaPV.Project.V13.Lib;
namespace Tyuiu.MohnonogovaPV.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
