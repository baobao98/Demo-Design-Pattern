using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public class ChatDinhDuong : Observer
    {
        private string _name;
        private Label _label;
        private int value;
        public string Name { get => _name; set => _name = value; }

        public Label Label { get => _label; set => _label = value; }
        public int Value { get => value; set => this.value = value; }

        public ChatDinhDuong(Label label) { this.Label = label; }

        public override void Update()
        {
            Label.Text = Value.ToString();
        }
    }
}
