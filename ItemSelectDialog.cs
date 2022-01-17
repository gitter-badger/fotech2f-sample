using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fotech2FSample
{
    public partial class ItemSelectDialog : Form
    {
        public ItemSelectDialog()
        {
            InitializeComponent();
        }

        public IEnumerable<object> Items
        {
            get => listBox.Items.Cast<object>();
            set
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(value.ToArray());
                openBtn.Enabled = value.Any();
                listBox.SelectedItem = value.First();
            }
        }

        public object SelectedItem { get; private set; }

        private void openBtn_Click(object sender, EventArgs e)
        {
            SelectedItem = listBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}