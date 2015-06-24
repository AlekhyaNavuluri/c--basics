using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays_lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //single-dimensional array
            //int[] numbers = new int[5] {1, 2, 3, 4, 5};

            //multi-dimensional array
            // string[] myArray = new string[2] ;
            //  myArray [0] = "banana";
            //  myArray [1] = "apple";
            //  MessageBox.Show(myArray[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //single-dimensional array
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)

            //
            //{ 
            // MessageBox.Show(numbers.Length);
            //}
            //String[] myArray = { "apple", "banana", "peach", "berry"};
            //for ( var index = 0; index < myArray.Length; index++ )
            // {
            // MessageBox.Show(index.ToString());
            // }
            //String[] myArray = { "apple", "banana", "peach", "berry"};
            //for ( var index = 0; index < myArray.Length; index++ )
            // {
            //  if(myArray[index] =="banana")
            //{
            //  MessageBox.Show(index.ToString());
            //}

            // }
            // String[] myArray = { "apple", "banana", "peach", "berry"};
            //for ( var index = 0; index < myArray.Length; )
            // {
            // foreach(var nickname in myArray)
            //{
            //   MessageBox.Show(index++ + "" + nickname);
            // }

            //}
            //String[] myArray = { "apple", "banana", "peach", "berry" };
           // for (var index = 0; index < myArray.Length; )
           // {
               // for (var nickname = 0; nickname < myArray.Length; )
               // {
                 //   MessageBox.Show(index++ + "" + nickname++);

               // }
            //}
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           int i = 0;
         while(i < int.Parse(textBox1.Text))
            {
                i++;
            }
            MessageBox.Show("the final value was:" + i.ToString());
        }
    }
}
