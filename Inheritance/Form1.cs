using System;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        class BJCP_Style
        {
            protected string BJCP;

            public BJCP_Style(string style)
            {
                if (style.Length == 0)
                {
                    MessageBox.Show("Enter Valid Catagory!");
                    BJCP = "00";
                }
                else
                {
                    BJCP = style;
                    //MessageBox.Show("Inside BJCP_Style Constructor " + BJCP);
                }
            }
            public void display()
            {
                MessageBox.Show("BJCP_Style " + BJCP + " Display");

            }
        }
        class Beer_ABV : BJCP_Style
        {
            private double ABV;

            public Beer_ABV(string style, double abv) : base(style)
            {
                if (abv < 6.00)
                {
                    //ABV = 6.00;
                    MessageBox.Show("BJCP 21A should be above 6%");
                }
                else
                {
                    ABV = abv;
                }
            }
            public void display()
            {
                MessageBox.Show("Beer Alcohol by Volume = " + ABV + "%");
            }
        }
        class Beer_Color : BJCP_Style
        {
            private double SRM;

            public Beer_Color(string style, double srm) : base(style)
            {
                if (srm == 0)
                { 

                }
                else if (srm < 10)
                {
                    //SRM = 10;
                    MessageBox.Show("BJCP 21A should be above 10 °L");
                }
                else
                {
                    SRM = srm;
                }
            }
            public void display()
            {
                MessageBox.Show("Beer Color in °L = " + SRM + "°L");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BJCP_Style b1 = new BJCP_Style(style.Text);
            b1.display();
            if (string.IsNullOrEmpty(txtABV.Text))
                {

                }
            else
            {
                double txtboxABV = double.Parse(txtABV.Text);
                Beer_ABV bn = new Beer_ABV(style.Text, txtboxABV);
                bn.display();
            }
            if (string.IsNullOrEmpty(txtColor.Text))
            {

            }
            else
            {
                double txtboxSRM = double.Parse(txtColor.Text);
                Beer_Color bc = new Beer_Color(style.Text, txtboxSRM);
                bc.display();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtABV.Clear();
            txtColor.Clear();
            style.Clear();
        }
    }
}
