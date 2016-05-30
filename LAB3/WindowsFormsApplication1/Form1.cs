using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
           
        }

        float num,num1,ans;
        int count;
        int cnk=0,xx=0;
       
        private void button3_Click(object sender, EventArgs e)  //backspace
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4 ;
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {   if (cnk == 0)
            {
                //afisarea in text box shi press button cu rosu
                textBox1.Text = textBox1.Text + ".";
                textBox1.ForeColor = Color.Red;
                cnk++;
            }  
        else { textBox1.Text = textBox1.Text + ""; }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +7 ;
            textBox1.ForeColor = Color.Red;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +8 ;
            textBox1.ForeColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9 ;
            textBox1.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e) //butonul +
        { 
                cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
                count = 1;
                label1.Text = num.ToString() + "+";  //afisarea textului in label 
            } 

        private void button20_Click(object sender, EventArgs e) //butonul -
        {

            cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
            count = 2;
                label1.Text = num.ToString() + "-";  //afisarea textului in label

            
        }

        private void button21_Click(object sender, EventArgs e)   //butonul *
        {

            cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
            count = 3;
            label1.Text = num.ToString() + "*";  //afisarea textului in label
        }

        private void button22_Click(object sender, EventArgs e)  //butonul /
        {

            cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
            count = 4;
            label1.Text = num.ToString() + "/";  //afisarea textului in label
        }

        private void button12_Click(object sender, EventArgs e)  //butonul =
        {
          
            cnk = 0;
            compute(); //apelam functia
            label1.Text = ""; //curatim labelu
            xx = 0;
        }

        private void button4_Click(object sender, EventArgs e) // C
        {
            xx = 0;
            cnk = 0;
            textBox1.Text = "";
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                  }

        private void button5_Click(object sender, EventArgs e) //butonul sqrt
        {

            cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
            textBox1.Text = Math.Sqrt(num).ToString();
           
        }

        private void button24_Click(object sender, EventArgs e)  //butonul x^2
        {
             cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
            textBox1.Text = (num * num).ToString();
        }

        private void button23_Click(object sender, EventArgs e)  // +/-
        {
            
            cnk = 0;
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();    //curatirea textboxului
            textBox1.Focus();     //focusarea asupra textbox dupa curatire
            textBox1.Text = (num1*(-1)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)  // 1/x
        {

            cnk = 0;
            if (xx == 0)
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();    //curatirea textboxului
                textBox1.Focus();     //focusarea asupra textbox dupa curatire
                xx = 1;
            }
            textBox1.Text = (1/num).ToString();
        }

        public void compute()
            
        {

            switch (count)
            {
                case 1: ans = num + float.Parse(textBox1.Text);  //adunarea
                    textBox1.Text = ans.ToString(); //convert float in string
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);  //scaderea
                    textBox1.Text = ans.ToString(); //convert float in string
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);  //inmultirea
                    textBox1.Text = ans.ToString(); //convert float in string
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);  //impartirea
                    textBox1.Text = ans.ToString(); //convert float in string
                    break;

                 case 5:
                    
                    break;
                default: break;
            }


        }
    }
}
