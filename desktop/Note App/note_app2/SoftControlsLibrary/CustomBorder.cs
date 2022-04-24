using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftControlsLibrary
{
    public partial class CustomBorder : TextBox
    {
        private Color _bottomBorderColor = Color.Black;
        private Color _onFocusColor = Color.Blue;
        public CustomBorder()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _bottomBorderColor
            });
            InitializeComponent();
        }
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }
        
        public Color ButtomBorderColor
        {
            get { return _bottomBorderColor; }
            set
            {
                _bottomBorderColor = value;
                Controls[0].BackColor = _bottomBorderColor;
            }
        }

        public Color BottomBorderOnFocusColor
        {
            get { return _onFocusColor; }
            set { _onFocusColor = value; }
        }

        private void CustomBorder_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _onFocusColor;
        }

        private void CustomBorder_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _bottomBorderColor;
        }
    }
}
