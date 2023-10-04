using DependencyInjection.WinForms.Abstract;
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
    public partial class MainForm : Form, IMainForm
    {
        private readonly IAnimalService _animalService;
        private readonly SecondaryForm _secondaryForm;
        private readonly ThirdForm _thirdForm;
        public MainForm(IAnimalService animalService, SecondaryForm secondaryForm, ThirdForm thirdForm)
        {
            InitializeComponent();

            _animalService = animalService;
            _secondaryForm = secondaryForm;
            _thirdForm = thirdForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void playSoundBtn_Click(object sender, EventArgs e)
        {
            _animalService.Sound();
        }

        private void openSecFormBtn_Click(object sender, EventArgs e)
        {
            _secondaryForm.Show();
        }

        private void readTextBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, _secondaryForm.ReadText(), "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openThrdFormBtn_Click(object sender, EventArgs e)
        {
            _thirdForm.Show();
        }
    }
}
