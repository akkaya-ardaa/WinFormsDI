using ExampleServices;
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
    public partial class SecondaryForm : Form
    {
        private readonly IAnimalService _animalService;
        public SecondaryForm(IAnimalService animalService)
        {
            InitializeComponent();

            _animalService = animalService;
        }

        private void SecondaryForm_Load(object sender, EventArgs e)
        {
            _animalService.Sound();
        }

        private void SecondaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public string ReadText()
        {
            return richTextBox1.Text;
        }
    }
}
