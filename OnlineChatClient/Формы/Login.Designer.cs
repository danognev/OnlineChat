namespace OnlineChatClient
{
  partial class Login
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

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.mainContainer = new System.Windows.Forms.Panel();
      this.closeButton = new LollipopLabel();
      this.loginUC1 = new OnlineChatClient.LoginUC();
      this.mainContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainContainer
      // 
      this.mainContainer.BackColor = System.Drawing.Color.Transparent;
      this.mainContainer.Controls.Add(this.closeButton);
      this.mainContainer.Controls.Add(this.loginUC1);
      this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainContainer.Location = new System.Drawing.Point(0, 0);
      this.mainContainer.Name = "mainContainer";
      this.mainContainer.Size = new System.Drawing.Size(303, 505);
      this.mainContainer.TabIndex = 0;
      // 
      // closeButton
      // 
      this.closeButton.AutoSize = true;
      this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.closeButton.Location = new System.Drawing.Point(283, 0);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(17, 17);
      this.closeButton.TabIndex = 1;
      this.closeButton.Text = "X";
      this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
      this.closeButton.MouseEnter += new System.EventHandler(this.CloseButtonEnter);
      this.closeButton.MouseLeave += new System.EventHandler(this.CloseButtonLeave);
      // 
      // loginUC1
      // 
      this.loginUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.loginUC1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.loginUC1.Location = new System.Drawing.Point(0, 0);
      this.loginUC1.Name = "loginUC1";
      this.loginUC1.Size = new System.Drawing.Size(303, 505);
      this.loginUC1.TabIndex = 0;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(303, 505);
      this.Controls.Add(this.mainContainer);
      this.MaximizeBox = false;
      this.Name = "Main";
      this.Sizable = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Чат";
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.mainContainer.ResumeLayout(false);
      this.mainContainer.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel mainContainer;
    private LoginUC loginUC1;
    private LollipopLabel closeButton;
  }
}

