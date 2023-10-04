using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUI
{
    public partial class ThirdForm : Form
    {
        private readonly SecondaryForm _secondaryForm;
        public ThirdForm(SecondaryForm secondaryForm)
        {
            InitializeComponent();

            _secondaryForm = secondaryForm;
        }

        private void ThirdForm_Load(object sender, EventArgs e)
        {

        }

        private void readTextBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, _secondaryForm.ReadText(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
