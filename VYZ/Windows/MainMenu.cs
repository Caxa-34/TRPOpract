using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYZ.Windows
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnOtch_Click(object sender, EventArgs e)
        {
            Otchets otchets = new Otchets();
            otchets.Owner = this;
            otchets.Show();
            Hide();
        }

        private void btnKaf_Click(object sender, EventArgs e)
        {
            KafAndFac kafAndFac = new KafAndFac();
            kafAndFac.Owner = this;
            kafAndFac.Show();
            Hide();
        }

        private void btnPrep_Click(object sender, EventArgs e)
        {
            PrepAndSubj prepAndSubj = new PrepAndSubj();
            prepAndSubj.Owner = this;
            prepAndSubj.Show();
            Hide();
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            Stud stud = new Stud();
            stud.Owner = this;
            stud.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
    }
}
