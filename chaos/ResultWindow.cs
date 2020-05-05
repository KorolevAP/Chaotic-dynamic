using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaos
{
    public partial class ResultWindow : Form
    {
        public ResultWindow(string s1,string s2)
        {
            
            InitializeComponent();
            label1.Text = s1;
            label2.Text = s2;
        }

       
    }
}
