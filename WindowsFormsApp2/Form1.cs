using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using GenLogic.GraphLayout;

using GenLogic;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1 glg_control;

        public Form1()
        {
            //InitializeComponent();
            TopLevel = true;
            SetBounds(20, 20, 800, 700);
            AutoSize = false;   // Allow resizing
            Text = "GLG Air Combat Simulation Demo";

            glg_control = new Form1();
            glg_control.Size = this.ClientSize;

            // Resize the control to fit the form when the form is resized.
            glg_control.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom |
                                   AnchorStyles.Left | AnchorStyles.Right);
            Controls.Add(glg_control);
        }
    }
}
