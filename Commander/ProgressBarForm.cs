using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commander
{
    public partial class ProgressBarForm : Form
    {
        public delegate void CancelHandler();

        public event CancelHandler Cancel;

        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (Cancel != null)
            {
                Cancel();
            }
        }

        private void ProgressBarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Cancel != null)
            {
                Cancel();
            }
        }
    }
}
