using System.Windows.Forms;

namespace lab4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean lightON = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lightON = !lightON;
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (lightON)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }
    }
}
    }
}

/*
namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean lightON = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            lightON = !lightON;
            flip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flip();
        }

        private void flip()
        {
            if (lightON)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }
    }
}

*/