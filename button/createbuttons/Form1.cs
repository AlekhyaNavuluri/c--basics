using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace createbuttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 100;
            int left = 100;
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 1; i < 12; i++)   // generate 12 buttons
                {
                    Button btn = new Button(); 
                    btn.Name = i.ToString();   // button name also i value
                    btn.Text = i.ToString();   //i value in the button
                    btn.Top = top;
                    btn.Left = left;        // button location
                    left += 80;       // left = left+80
                    btn.Size = new System.Drawing.Size(44, 29);  // button size 
                    btn.Click += new System.EventHandler(btn_Click);  
                    this.Controls.Add(btn);    
                }
                left = 100;
                top += 40;
            }
   
            
            //  this.BackColor = System.Drawing.Color.Lime;  // change backgroundcolor of the form
        
        }


    public void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;  
            if (button.Text == "B")
            {
                button.Text = button.Name;
                button.BackColor = Color.White;
              }
            else
            {
                button.Text = "B";
                button.BackColor = Color.Yellow;
            }
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.WindowState = FormWindowState.Maximized;
            using (StreamWriter w = File.AppendText(@"C:\Temp\log.txt"))
            {
                w.WriteLine(button.Text);
                w.WriteLine(button.Name);
            }
            

        }
            
  }
  }

        
    

