namespace xoxoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOX(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (label1.Text == "X")
            {
                button.Text = "X";
                button.Enabled = false;
                label1.Text = "O";
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
                label1.Text = "X";
            }

             // X kazandýðý senaryo
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X kazandý");
                OyunBitis();
            }
            // O kazandýðý senaryo
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("0 kazandý");
                OyunBitis();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O kazandý");
                OyunBitis();
            }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != ""&& button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Berabere");
                OyunBitis();
            }
        }
        public void OyunBitis()
        {
            label1.Text = "X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }
    }
}