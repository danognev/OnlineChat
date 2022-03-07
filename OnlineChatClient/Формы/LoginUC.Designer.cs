namespace OnlineChatClient
{
  partial class LoginUC
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.loginButton = new LollipopButton();
      this.lollipopLabel4 = new LollipopLabel();
      this.createAccButton = new LollipopButton();
      this.repeatPassTextBox = new LollipopTextBox();
      this.repeatLabel = new LollipopLabel();
      this.lollipopLabel2 = new LollipopLabel();
      this.passTextBox = new LollipopTextBox();
      this.loginTextBox = new LollipopTextBox();
      this.lollipopLabel1 = new LollipopLabel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::OnlineChatClient.Properties.Resources.messenger;
      this.pictureBox1.Location = new System.Drawing.Point(108, 53);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 100);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // loginButton
      // 
      this.loginButton.BackColor = System.Drawing.Color.Transparent;
      this.loginButton.BGColor = "#9C36FF";
      this.loginButton.FontColor = "#ffffff";
      this.loginButton.Location = new System.Drawing.Point(75, 428);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(143, 41);
      this.loginButton.TabIndex = 10;
      this.loginButton.Text = "Войти";
      this.loginButton.Click += new System.EventHandler(this.LoginButtonClick);
      // 
      // lollipopLabel4
      // 
      this.lollipopLabel4.AutoSize = true;
      this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
      this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.lollipopLabel4.Location = new System.Drawing.Point(105, 407);
      this.lollipopLabel4.Name = "lollipopLabel4";
      this.lollipopLabel4.Size = new System.Drawing.Size(90, 17);
      this.lollipopLabel4.TabIndex = 9;
      this.lollipopLabel4.Text = "Уже с нами?";
      // 
      // createAccButton
      // 
      this.createAccButton.BackColor = System.Drawing.Color.Transparent;
      this.createAccButton.BGColor = "#F74F8B";
      this.createAccButton.FontColor = "#ffffff";
      this.createAccButton.Location = new System.Drawing.Point(75, 347);
      this.createAccButton.Name = "createAccButton";
      this.createAccButton.Size = new System.Drawing.Size(143, 41);
      this.createAccButton.TabIndex = 8;
      this.createAccButton.Text = "Создать аккаунт";
      this.createAccButton.Click += new System.EventHandler(this.CreateAccButtonClick);
      // 
      // repeatPassTextBox
      // 
      this.repeatPassTextBox.FocusedColor = "#F74F8B";
      this.repeatPassTextBox.FontColor = "#999999";
      this.repeatPassTextBox.IsEnabled = true;
      this.repeatPassTextBox.Location = new System.Drawing.Point(26, 317);
      this.repeatPassTextBox.MaxLength = 32767;
      this.repeatPassTextBox.Multiline = false;
      this.repeatPassTextBox.Name = "repeatPassTextBox";
      this.repeatPassTextBox.ReadOnly = false;
      this.repeatPassTextBox.Size = new System.Drawing.Size(252, 24);
      this.repeatPassTextBox.TabIndex = 7;
      this.repeatPassTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      this.repeatPassTextBox.UseSystemPasswordChar = true;
      this.repeatPassTextBox.Visible = false;
      // 
      // repeatLabel
      // 
      this.repeatLabel.AutoSize = true;
      this.repeatLabel.BackColor = System.Drawing.Color.Transparent;
      this.repeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.repeatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.repeatLabel.Location = new System.Drawing.Point(23, 296);
      this.repeatLabel.Name = "repeatLabel";
      this.repeatLabel.Size = new System.Drawing.Size(172, 17);
      this.repeatLabel.TabIndex = 6;
      this.repeatLabel.Text = "Введите пароль ещё раз";
      this.repeatLabel.Visible = false;
      // 
      // lollipopLabel2
      // 
      this.lollipopLabel2.AutoSize = true;
      this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
      this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.lollipopLabel2.Location = new System.Drawing.Point(23, 244);
      this.lollipopLabel2.Name = "lollipopLabel2";
      this.lollipopLabel2.Size = new System.Drawing.Size(57, 17);
      this.lollipopLabel2.TabIndex = 5;
      this.lollipopLabel2.Text = "Пароль";
      // 
      // passTextBox
      // 
      this.passTextBox.FocusedColor = "#F74F8B";
      this.passTextBox.FontColor = "#999999";
      this.passTextBox.IsEnabled = true;
      this.passTextBox.Location = new System.Drawing.Point(26, 265);
      this.passTextBox.MaxLength = 32767;
      this.passTextBox.Multiline = false;
      this.passTextBox.Name = "passTextBox";
      this.passTextBox.ReadOnly = false;
      this.passTextBox.Size = new System.Drawing.Size(252, 24);
      this.passTextBox.TabIndex = 4;
      this.passTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      this.passTextBox.UseSystemPasswordChar = true;
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
      // lollipopLabel1
      // 
      this.lollipopLabel1.AutoSize = true;
      this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
      this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.lollipopLabel1.Location = new System.Drawing.Point(23, 196);
      this.lollipopLabel1.Name = "lollipopLabel1";
      this.lollipopLabel1.Size = new System.Drawing.Size(77, 17);
      this.lollipopLabel1.TabIndex = 1;
      this.lollipopLabel1.Text = "Ваш логин";
      // 
      // LoginUC
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.lollipopLabel4);
      this.Controls.Add(this.createAccButton);
      this.Controls.Add(this.repeatPassTextBox);
      this.Controls.Add(this.repeatLabel);
      this.Controls.Add(this.lollipopLabel2);
      this.Controls.Add(this.passTextBox);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.lollipopLabel1);
      this.Controls.Add(this.pictureBox1);
      this.Name = "LoginUC";
      this.Size = new System.Drawing.Size(300, 506);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private LollipopLabel lollipopLabel1;
    private LollipopTextBox loginTextBox;
    private LollipopTextBox passTextBox;
    private LollipopLabel lollipopLabel2;
    private LollipopLabel repeatLabel;
    private LollipopTextBox repeatPassTextBox;
    private LollipopButton createAccButton;
    private LollipopLabel lollipopLabel4;
    private LollipopButton loginButton;
  }
}
