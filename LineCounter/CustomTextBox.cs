using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCounter
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Back)
        //    {
        //        if (SelectionStart != 0 && Text[SelectionStart - 1] != ',')
        //        {
                    
        //        }
        //    }
        //    base.OnKeyDown(e);
        //}
    }
}
