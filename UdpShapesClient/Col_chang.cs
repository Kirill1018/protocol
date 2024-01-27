using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpShapesClient
{
    public partial class Col_chang : Form
    {
        public Col_chang()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            new MainForm().ConnectToServer(new UdpShapesLib.Player(player.Text, (byte)int.Parse(color1.Text), (byte)int.Parse(color2.Text),
                (byte)int.Parse(color3.Text)));
            Close();
        }
    }
}