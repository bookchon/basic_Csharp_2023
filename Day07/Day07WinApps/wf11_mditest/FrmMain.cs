using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf11_mditest
{
    public partial class FrmMain : Form
    {
        FrmChild1 child1 = null;
        FrmChild2 child2 = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void OldMethod()
        {
            Console.WriteLine("올드 메서드");
        }
        [Obsolete("OldMethod는 다음 버전에서 폐기됩니다. NewMethod를 이용하세요.")]
        private void MinForm1_Click(object sender, EventArgs e)
        {
            OldMethod();
            child1 = new FrmChild1();
            child1.TopLevel = false;
            this.Controls.Add(child1);
            child1.Show();
        }

        private void NewMethod()
        {

        }

        private void MniForm2_Click(object sender, EventArgs e)
        {
            child2 = new FrmChild2();
            child2.TopLevel = false;
            this.Controls.Add(child2);
            child2.Show();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MniAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
    }
}
