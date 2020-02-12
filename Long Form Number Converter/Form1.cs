using Common;

using System.Windows.Forms;

namespace Long_Form_Number_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertInt_MouseUp(object sender, MouseEventArgs e)
        {
            lblOutput.Text = NumberFormatter.Spell(txtUnsignedInt.Text);
        }

        private void btnConvertString_MouseUp(object sender, MouseEventArgs e)
        {
            lblOutput.Text = NumberFormatter.Spell(txtString.Text);
        }
    }
}
