using System.Collections;

namespace To_do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=0;
            
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                x = 1;
            }
            else if (checkBox5.Checked && checkBox6.Checked && checkBox7.Checked && checkBox8.Checked)
            {
                x = 2;

            }
            else if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
            {
                x = 3;
            }
            else
            {
               
            }

            switch (x)
            {
                case 1:
                    groupBox1.BackColor = Color.Red;
                    checkBox1.Checked = false;
                    MessageBox.Show("Little things gave you away", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    break;
                case 2:
                    groupBox2.BackColor = Color.Green;
                    checkBox5.Checked = false;
                    MessageBox.Show("If you continue, you will surpass your weakness", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                case 3:
                    checkBox9.Checked = false;
                    groupBox3.BackColor = Color.BlueViolet;
                    MessageBox.Show("Keep it up bro", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break; 
                default:
                    MessageBox.Show("Nigga find something to do bro", "The Fuck?", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
        }

       
    }
}