using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICT4events
{
    public partial class Form1 : Form
    {
        Remise Remise;
        public Form1()
        {
            InitializeComponent();
            Remise = new Remise("Havenstraat");
        }
    }
}
