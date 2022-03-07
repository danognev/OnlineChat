using MaterialSkin;
using MaterialSkin.Controls;
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
  public partial class NewUser : MaterialForm
  {
    private static NewUser instance;
    public static NewUser Instance
    {
      get
      {
        if(instance == null)
          instance = new NewUser();
        return instance;
      }
    }
    public NewUser()
    {
      InitializeComponent();
      MaterialSkinManager manager = MaterialSkinManager.Instance;
      manager.AddFormToManage(this);
      manager.Theme = MaterialSkinManager.Themes.DARK;
      manager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple900, Accent.Purple200, TextShade.WHITE);
    }

    public Panel Content
    {
      get { return mainContainer; }
      set { mainContainer = value; }
    }
    private void MainFormLoad(object sender, EventArgs e)
    {
      instance = this;
    }

    private void CloseButtonEnter(object sender, EventArgs e)
    {
      closeButton.BackColor = ColorTranslator.FromHtml("#F74F8B");
      closeButton.ForeColor = Color.White;
    }

    private void CloseButtonLeave(object sender, EventArgs e)
    {
      closeButton.BackColor = ColorTranslator.FromHtml("#1F1F1F");
      closeButton.ForeColor = Color.FromArgb(153, 153, 153);
    }

    private void CloseButtonClick(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
