using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerSocket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            varGlobal.port = Int16.Parse(textBoxPort.Text);
            StringBuilder color = new StringBuilder();
            color.Append(textBoxRedCode.Text)
                .Append(",")
                .Append(textBoxGreenCode.Text)
                .Append(",")
                .Append(textBoxBlueCode.Text);
            SocketTCP.StartClient(color.ToString());
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            selectColor();
        }

        private void selectColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.Color = panelColorSelected.BackColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRedCode.Text = colorDialog.Color.R.ToString();
                textBoxGreenCode.Text = colorDialog.Color.G.ToString();
                textBoxBlueCode.Text = colorDialog.Color.B.ToString();

                panelColorSelected.BackColor = colorDialog.Color;
            }

            if(buttonSend.Enabled.Equals(false))
            {
                buttonSend.Enabled = true;
            }
        }
    }
}
