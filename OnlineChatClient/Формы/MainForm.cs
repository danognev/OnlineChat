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

namespace OnlineChatClient.Формы
{
  public partial class MainForm : MaterialForm
  {
    public MainForm()
    {
      InitializeComponent();
      MaterialSkinManager manager = MaterialSkinManager.Instance;
      manager.AddFormToManage(this);
      manager.Theme = MaterialSkinManager.Themes.DARK;
      manager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple900, Accent.Purple200, TextShade.WHITE);
    }
  }
}
