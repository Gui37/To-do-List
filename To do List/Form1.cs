using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace To_do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private static DialogResult ShowInputDialogBox(ref string input, ref string input2, string prompt,
            string prompt2,string title = "Title", int width = 300, int height = 200)  {
            //This function creates the custom input dialog box by individually creating the different
            //window elements and adding them to the dialog box

            //Specify the size of the window using the parameters passed
            Size size = new Size(width, height);
            //Create a new form using a System.Windows Form
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.Fixed3D;
            inputBox.ClientSize = size;
            inputBox.MaximizeBox= false;
            inputBox.MinimizeBox= false;
            inputBox.StartPosition= FormStartPosition.CenterScreen;
            
            //Set the window title using the parameter passed
            inputBox.Text = title;

            //Create a new label to hold the prompt
            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(5, 5);
            label.Width = size.Width - 15;
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, label.Location.Y + 23);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            //Create a new label to hold the prompt
            Label label2 = new Label();
            label2.Text = prompt2;
            label2.Location = new Point(5, 50);
            label2.Width = size.Width - 15;
            inputBox.Controls.Add(label2);

            //Create a textbox to accept the user's other input
            TextBox textBox2 = new TextBox();
            textBox2.Size = new Size(size.Width - 10, 23);
            textBox2.Location = new Point(5, label2.Location.Y + 23);
            textBox2.Text = input2;
            inputBox.Controls.Add(textBox2);

            //Create an OK Button 
            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

           

            //Set the input box's buttons to the created OK 
            //so the window appropriately behaves with the button clicks
            inputBox.AcceptButton = okButton;
            
            

            //Show the window dialog box 
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            input2= textBox2.Text; 

            //After input has been submitted, return the input value
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private int checkedBoxes()
        {
            int x = 0;

           
             if (checkBox1.Checked && checkBox5.Checked && checkBox9.Checked && checkBox2.Checked && checkBox6.Checked && checkBox10.Checked && checkBox3.Checked && checkBox7.Checked && checkBox11.Checked && checkBox4.Checked && checkBox9.Checked && checkBox9.Checked && checkBox8.Checked && checkBox12.Checked)
            {
                x = 5;
            }
            else if (checkBox1.Checked && checkBox5.Checked && checkBox9.Checked)
            {
                x = 4;
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                x = 3;
            }
            else if (checkBox5.Checked && checkBox6.Checked && checkBox7.Checked && checkBox8.Checked)
            {
                x = 2;
            }
            else if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
            {
                x = 1;
            }
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (checkedBoxes())
            {
                case 3:
                    groupBox1.BackColor = Color.Red;
                    MessageBox.Show("Little things gave you away", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case 2:
                    groupBox2.BackColor = Color.Green;
                    MessageBox.Show("If you continue, you will surpass your weakness", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                case 1:
                    groupBox3.BackColor = Color.BlueViolet;
                    MessageBox.Show("Keep it up bro", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;  
                case 4:
                    groupBox1.BackColor = Color.Red;
                    groupBox2.BackColor = Color.Green;
                    groupBox3.BackColor = Color.BlueViolet;
                    MessageBox.Show("At least you are doing something", "Heads up", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case 5:
                    groupBox1.BackColor = Color.CadetBlue;
                    groupBox2.BackColor = Color.DarkCyan;
                    groupBox3.BackColor = Color.LightSteelBlue;
                    MessageBox.Show("You are really working", "Heads up", MessageBoxButtons.OK,
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

        public void dialogBox()
        {
            string input = "";
            string input2 = "";
            ShowInputDialogBox(ref input, ref input2, "Please enter the checkbox number between 1-12",
                "Please write the chore you want to modify", "Qwerty", 300, 200);
            int x = 0;
            
            try
            {
                x = Int32.Parse(input);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("There was a FormatException while using the dialog box");
                
            }
        
            switch (x)
            {
                case 1:
                    checkBox1.Text = input2;
                    DataCheck dataCheck = new DataCheck();
                    dataCheck.start();
                    
                    break;
                case 2:
                    checkBox2.Text = input2;
                    break;
                case 3:
                    checkBox3.Text = input2;
                    break;
                case 4:
                    checkBox4.Text = input2;
                    break;
                case 5:
                    checkBox5.Text = input2;
                    break;
                case 6:
                    checkBox6.Text = input2;
                    break;
                case 7:
                    checkBox7.Text = input2;
                    break;
                case 8:
                    checkBox8.Text = input2;
                    break;
                case 9:
                    checkBox9.Text = input2;
                    break;
                case 10:
                    checkBox10.Text = input2;
                    break;
                case 11:
                    checkBox11.Text = input2;
                    break;
                case 12:
                    checkBox12.Text = input2;
                    break;
                default:
                    MessageBox.Show("Can you please follow the rules", "Yoooo!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    break;
            }
            
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dialogBox();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.DarkSlateGray)
            {
                BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else
            {
                BackColor = Color.DarkSlateGray;
            }

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.Menu;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.DarkSlateGray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.DarkGoldenrod;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.LightYellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }
    }
}