using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public partial class form2 : Component
    {
        public form2()
        {
            InitializeComponent();
        }

        public form2(IContainer container)
        {
            container.Add(this);
            form2 form2 = new form2();
            


            InitializeComponent();
        }
    }
}
