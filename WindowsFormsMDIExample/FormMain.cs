using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMDIExample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void addPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAddPublisher frmAddPublisher = new FrmAddPublisher();
            frmAddPublisher.MdiParent = this;
            frmAddPublisher.Show();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewAuthor frmNewAuthor = new FrmNewAuthor();
            frmNewAuthor.MdiParent = this;
            frmNewAuthor.Show();
        }

        private void addTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewTitle frmNewTitle = new FrmNewTitle();
            frmNewTitle.MdiParent = this;
            frmNewTitle.Show();
        }
    }
}
