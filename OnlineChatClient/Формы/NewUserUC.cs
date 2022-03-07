using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChatClient
{
  public partial class NewUserUC : UserControl
  {
    public NewUserUC()
    {
      InitializeComponent();
      avatarFileInput.TextChanged += AvatarFileInput_TextChanged;
    }
    private void AvatarFileInput_TextChanged(object sender, EventArgs e)
    {
      avatarImage.Image = OvalImage(Image.FromFile(avatarFileInput.Dialog.FileName));
    }

    public static Image OvalImage(Image img)
    {
      Bitmap bmp = new Bitmap(img.Width, img.Height);
      using (GraphicsPath gp = new GraphicsPath())
      {
        gp.AddEllipse(0, 0, img.Width, img.Height);
        using (Graphics gr = Graphics.FromImage(bmp))
        {
          gr.SetClip(gp);
          gr.DrawImage(img, Point.Empty);
        }
      }
      return bmp;
    }
    private void CreateAccButtonClick(object sender, EventArgs e)
    {
    }
  }
}
