using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
           // int x = 0;
           // int y = 0;
        for (int i = 0; i < 5; i++)
     {
        Button btn = new Button();
        btn.Name = "btn1";
        btn.Location = new Point(20, 30 * i + 10);
        btn.Tag = i;
        btn.BackColor = Color.Red;
        btn.Text = "1";
        btn.Click += new System.EventHandler(btn_Click);
        this.Controls.Add(btn);
        
     }
            

 }
    public void btn_Click(object sender, EventArgs e)
        {
         
        }

  }
  }

        
    

