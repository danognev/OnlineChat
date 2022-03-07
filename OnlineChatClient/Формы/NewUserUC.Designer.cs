namespace OnlineChatClient
{
  partial class NewUserUC
  {
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.avatarImage = new System.Windows.Forms.PictureBox();
      this.avatarFileInput = new LollipopFileInput();
      this.lollipopLabel2 = new LollipopLabel();
      this.lollipopLabel1 = new LollipopLabel();
      this.createAccButton = new LollipopButton();
      this.loginTextBox = new LollipopTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
      this.SuspendLayout();
      // 
      // avatarImage
      // 
      this.avatarImage.Image = global::OnlineChatClient.Properties.Resources.messenger;
      this.avatarImage.Location = new System.Drawing.Point(108, 53);
      this.avatarImage.Name = "avatarImage";
      this.avatarImage.Size = new System.Drawing.Size(100, 100);
      this.avatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.avatarImage.TabIndex = 0;
      this.avatarImage.TabStop = false;
      // 
      // avatarFileInput
      // 
      this.avatarFileInput.Filter = "Images |*.jpg; *.png; *.bmp";
      this.avatarFileInput.FocusedColor = "#F74F8B";
      this.avatarFileInput.FontColor = "#999999";
      this.avatarFileInput.IsEnabled = true;
      this.avatarFileInput.Location = new System.Drawing.Point(26, 269);
      this.avatarFileInput.MaxLength = 32767;
      this.avatarFileInput.Name = "avatarFileInput";
      this.avatarFileInput.ReadOnly = false;
      this.avatarFileInput.Size = new System.Drawing.Size(252, 24);
      this.avatarFileInput.TabIndex = 13;
      this.avatarFileInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      this.avatarFileInput.UseSystemPasswordChar = false;
      // 
      // lollipopLabel2
      // 
      this.lollipopLabel2.AutoSize = true;
      this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
      this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.lollipopLabel2.Location = new System.Drawing.Point(23, 248);
      this.lollipopLabel2.Name = "lollipopLabel2";
      this.lollipopLabel2.Size = new System.Drawing.Size(159, 17);
      this.lollipopLabel2.TabIndex = 12;
      this.lollipopLabel2.Text = "Загрузите свой аватар";
      // 
      // lollipopLabel1
      // 
      this.lollipopLabel1.AutoSize = true;
      this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
      this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.lollipopLabel1.Location = new System.Drawing.Point(23, 196);
      this.lollipopLabel1.Name = "lollipopLabel1";
      this.lollipopLabel1.Size = new System.Drawing.Size(106, 17);
      this.lollipopLabel1.TabIndex = 11;
      this.lollipopLabel1.Text = "Как вас зовут?";
      // 
      // createAccButton
      // 
      this.createAccButton.BackColor = System.Drawing.Color.Transparent;
      this.createAccButton.BGColor = "#F74F8B";
      this.createAccButton.FontColor = "#ffffff";
      this.createAccButton.Location = new System.Drawing.Point(79, 313);
      this.createAccButton.Name = "createAccButton";
      this.createAccButton.Size = new System.Drawing.Size(143, 41);
      this.createAccButton.TabIndex = 8;
      this.createAccButton.Text = "Готово";
      this.createAccButton.Click += new System.EventHandler(this.CreateAccButtonClick);
      // 
      // loginTextBox
      // 
      this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.loginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.loginTextBox.FocusedColor = "#F74F8B";
      this.loginTextBox.FontColor = "#999999";
      this.loginTextBox.IsEnabled = true;
      this.loginTextBox.Location = new System.Drawing.Point(26, 217);
      this.loginTextBox.MaxLength = 32767;
      this.loginTextBox.Multiline = false;
      this.loginTextBox.Name = "loginTextBox";
      this.loginTextBox.ReadOnly = false;
      this.loginTextBox.Size = new System.Drawing.Size(252, 24);
      this.loginTextBox.TabIndex = 2;
      this.loginTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      this.loginTextBox.UseSystemPasswordChar = false;
      // 
      // NewUserUC
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.Controls.Add(this.avatarFileInput);
      this.Controls.Add(this.lollipopLabel2);
      this.Controls.Add(this.lollipopLabel1);
      this.Controls.Add(this.createAccButton);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.avatarImage);
      this.Name = "NewUserUC";
      this.Size = new System.Drawing.Size(300, 506);
      ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox avatarImage;
    private LollipopTextBox loginTextBox;
    private LollipopButton createAccButton;
    private LollipopLabel lollipopLabel1;
    private LollipopLabel lollipopLabel2;
    private LollipopFileInput avatarFileInput;
  }
}
