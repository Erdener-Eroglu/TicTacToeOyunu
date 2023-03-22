namespace TicTacToeOyunu.Forms;

public partial class OyunForm : Form
{
    char sira;
    public OyunForm()
    {
        InitializeComponent();
    }
    Image imageX;
    Image imageO;
    int skorX = 0;
    int skorO = 0;
    private AnaMenuForm _anaMenuForm;
    private void OyunForm_Load(object sender, EventArgs e)
    {
        imageX = Image.FromFile("x.png");
        imageO = Image.FromFile("o.png");
        pictureBoxX.BackColor = Color.Green;
        sira = 'x';
    }
    private void pictureBox_Clixk(object sender, EventArgs e)
    {
        if (sira == 'x')
        {
            (sender as PictureBox).Image = imageX;
            pictureBoxX.BackColor = pictureBox7.BackColor;
            pictureBoxO.BackColor = Color.Green;
            sira = 'o';
        }
        else if (sira == 'o')
        {
            pictureBoxX.BackColor = Color.Green;
            pictureBoxO.BackColor = pictureBox7.BackColor;
            (sender as PictureBox).Image = imageO;

            sira = 'x';
        }
        (sender as PictureBox).Enabled = false;
        if (XKazandiMi())
        {
            MessageBox.Show("X KAZANDI", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            skorX++;
            OyunuSıfırla();
            lblOScore.Text = skorO.ToString();
            lblXScore.Text = skorX.ToString();
        }
        if (OKazandiMi())
        {
            MessageBox.Show("O KAZANDI", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            skorO++;
            OyunuSıfırla();
            lblOScore.Text = skorO.ToString();
            lblXScore.Text = skorX.ToString();
        }
    }
    private void OyunuSıfırla()
    {
        foreach (PictureBox item in tableLayoutPanel2.Controls)
        {
            item.Enabled = true;
            item.Image = null;
            item.BackColor = Color.White;
        }
        sira = 'x';
        pictureBoxX.BackColor = Color.Green;
        pictureBoxO.BackColor = pictureBox9.BackColor;
    }
    private bool XKazandiMi()
    {
        if (pictureBox1.Image == imageX && pictureBox2.Image == imageX && pictureBox3.Image == imageX)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            return true;
        }
        if (pictureBox4.Image == imageX && pictureBox5.Image == imageX && pictureBox6.Image == imageX)
        {
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox6.BackColor = Color.Red;
            return true;
        }
        if (pictureBox7.Image == imageX && pictureBox8.Image == imageX && pictureBox9.Image == imageX)
        {
            pictureBox7.BackColor = Color.Red;
            pictureBox8.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            return true;
        }
        if (pictureBox1.Image == imageX && pictureBox4.Image == imageX && pictureBox7.Image == imageX)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            pictureBox7.BackColor = Color.Red;
            return true;
        }
        if (pictureBox2.Image == imageX && pictureBox5.Image == imageX && pictureBox8.Image == imageX)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox8.BackColor = Color.Red;
            return true;
        }
        if (pictureBox3.Image == imageX && pictureBox6.Image == imageX && pictureBox9.Image == imageX)
        {
            pictureBox3.BackColor = Color.Red;
            pictureBox6.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            return true;
        }
        if (pictureBox1.Image == imageX && pictureBox5.Image == imageX && pictureBox9.Image == imageX)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            return true;
        }
        if (pictureBox3.Image == imageX && pictureBox5.Image == imageX && pictureBox7.Image == imageX)
        {
            pictureBox3.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox7.BackColor = Color.Red;
            return true;
        }
        return false;
    }
    private bool OKazandiMi()
    {
        if (pictureBox1.Image == imageO && pictureBox2.Image == imageO && pictureBox3.Image == imageO)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            return true;
        }
        if (pictureBox4.Image == imageO && pictureBox5.Image == imageO && pictureBox6.Image == imageO)
        {
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox6.BackColor = Color.Red;
            return true;
        }
        if (pictureBox7.Image == imageO && pictureBox8.Image == imageO && pictureBox9.Image == imageO)
        {
            pictureBox7.BackColor = Color.Red;
            pictureBox8.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            return true;
        }
        if (pictureBox1.Image == imageO && pictureBox4.Image == imageO && pictureBox7.Image == imageO)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            pictureBox7.BackColor = Color.Red;
            return true;
        }
        if (pictureBox2.Image == imageO && pictureBox5.Image == imageO && pictureBox8.Image == imageO)
        {
            pictureBox2.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox8.BackColor = Color.Red;
            return true;
        }
        if (pictureBox3.Image == imageO && pictureBox6.Image == imageO && pictureBox9.Image == imageO)
        {
            pictureBox3.BackColor = Color.Red;
            pictureBox6.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            return true;
        }
        if (pictureBox1.Image == imageO && pictureBox5.Image == imageO && pictureBox9.Image == imageO)
        {
            pictureBox1.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            return true;
        }
        if (pictureBox3.Image == imageO && pictureBox5.Image == imageO && pictureBox7.Image == imageO)
        {
            pictureBox3.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox7.BackColor = Color.Red;
            return true;
        }
        return false;
    }

    private void btnSıfırla_Click(object sender, EventArgs e)
    {
        OyunuSıfırla();
        skorO = 0;
        skorX = 0;
        lblOScore.Text = skorO.ToString();
        lblXScore.Text = skorX.ToString();
    }

    private void btnGeri_Click(object sender, EventArgs e)
    {

        if (_anaMenuForm == null || _anaMenuForm.IsDisposed)
        {
            _anaMenuForm = new AnaMenuForm();
            _anaMenuForm.Text = "Oyun";
            _anaMenuForm.Show();
        }
        this.Hide();
    }

    private void OyunForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
