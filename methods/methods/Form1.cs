using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(AddTwoNumbers(2, 4).ToString());
           MessageBox.Show(MultiplyTwoNumbers(3,4).ToString());      

        }

        public  int MultiplyTwoNumbers(int p1, int p2)
        {
            int answer;
            answer= p1 * p2;
            return answer;
        }

        public int AddTwoNumbers(int firstnumber, int secondnumber)
        {
            return  firstnumber + secondnumber;
          }
        public void displaymessage(String message)
        {
            MessageBox.Show(message);
        }
    }
}
