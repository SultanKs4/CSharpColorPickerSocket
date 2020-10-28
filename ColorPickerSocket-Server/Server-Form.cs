using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerSocket_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (textBoxIPAddress.Text != "" && textBoxPort.Text != "")
            {
                thr.Start();
                buttonListen.Enabled = false;
                textBoxIPAddress.Enabled = false;
                textBoxPort.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu !!!");
            }
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(textBoxPort.Text); // konversi dari string ke integer
            varGlobal.alamatIPServer = textBoxIPAddress.Text;
            SocketTCP.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if(varGlobal.terimapesandiserver.Length > 1)
            {
                panelColorSelected.BackColor = Color.Transparent;
                string[] data = varGlobal.terimapesandiserver.Trim().Split(',');
                textBoxRedCode.Text = data[0];
                textBoxGreenCode.Text = data[1];
                textBoxBlueCode.Text = data[2];

                int r = 0;
                int g = 0;
                int b = 0;

                if(Int32.TryParse(textBoxRedCode.Text, out r) 
                    && Int32.TryParse(textBoxGreenCode.Text, out g)
                    && Int32.TryParse(textBoxBlueCode.Text, out b))
                {
                    panelColorSelected.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
    }
}
