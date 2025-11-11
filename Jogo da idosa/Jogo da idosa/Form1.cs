namespace Jogo_da_idosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label2.ForeColor == Color.Red)
            {
                label1.ForeColor = Color.Blue;
            }
            if (label2.ForeColor == Color.Blue)
            {
                label1.ForeColor = Color.Red;
            }
            else
                label1.ForeColor = Color.Blue;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Blue)
            {
                label2.ForeColor = Color.Red;
            }
            if (label1.ForeColor == Color.Red)
            {
                label2.ForeColor = Color.Blue;
            }
            if (label1.ForeColor != Color.Blue)
            {
                label2.ForeColor = Color.Blue;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
        }

        private void b3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}