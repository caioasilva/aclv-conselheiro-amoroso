using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conselheiro_Amoroso
{
    public partial class DoubleBufferedButton : Form
    {
        public DoubleBufferedButton()
        {
            InitializeComponent();
            this.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.bt_vt;
        }
    }
}
