using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeOyunu.Forms
{
    public partial class AnaMenuForm : Form
    {
        public AnaMenuForm()
        {
            InitializeComponent();
        }
        private OyunForm _yeniOyun;

        private void btnIkiKisilik_Click(object sender, EventArgs e)
        {
            if (_yeniOyun == null || _yeniOyun.IsDisposed)
            {
                _yeniOyun = new OyunForm();
                _yeniOyun.Text = "Oyun";
                _yeniOyun.Show();
            }
            this.Hide();
        }

        private void AnaMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
