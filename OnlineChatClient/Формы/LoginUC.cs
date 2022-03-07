using OnlineChatClient.Формы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChatClient
{
  public partial class LoginUC : UserControl
  {
    static ushort count = 0;
    static readonly ushort CREATE_COUNT = 2;
    public LoginUC()
    {
      InitializeComponent();
    }

    private void CreateAccButtonClick(object sender, EventArgs e)
    {
      count++;
      repeatLabel.Visible = true;
      repeatPassTextBox.Visible = true;
      createAccButton.Text = "Создать!";
      if(count == CREATE_COUNT) {
        Login.Instance.Hide();
        new NewUser().Show();
      }
    }

    private void LoginButtonClick(object sender, EventArgs e)
    {
      Login.Instance.Hide();
      new MainForm().Show();
    }
  }
}
