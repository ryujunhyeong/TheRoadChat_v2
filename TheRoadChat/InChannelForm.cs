using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRoadChat
{
    public partial class InChannelForm : Form
    {
        private int i_channel;
        private DBManager myDBManager;

        bool On;
        Point Pos;
        public InChannelForm(int _i_channel, string name, DBManager _myDBManager)
        {
            InitializeComponent();
            canMoveForm();

            this.i_channel = _i_channel;
            labelChannelName.Text = name;
            myDBManager = _myDBManager;

            myDBManager.pullMessage(PanelMsg, this.i_channel);
        }

        private void canMoveForm()
        {
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        
    }
}
