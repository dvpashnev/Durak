using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakWinForms
{
  public partial class InputBox : Form
  {
    public InputBox()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (HostNameTb.Text == String.Empty)
      {
        MessageBox.Show(@"Введите имя сервера!");
        HostNameTb.Focus();
      } else if (NickTb.Text == String.Empty)
      {
        MessageBox.Show(@"Введите ник!");
        NickTb.Focus();
      }
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
