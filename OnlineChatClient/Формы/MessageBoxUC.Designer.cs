namespace OnlineChatClient.Формы
{
  partial class MessageBoxUC
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
      this.components = new System.ComponentModel.Container();
      this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
      this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
      this.SuspendLayout();
      // 
      // guna2GradientPanel1
      // 
      this.guna2GradientPanel1.BorderRadius = 30;
      this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
      this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
      this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
      this.guna2GradientPanel1.Location = new System.Drawing.Point(102, 28);
      this.guna2GradientPanel1.Name = "guna2GradientPanel1";
      this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
      this.guna2GradientPanel1.Size = new System.Drawing.Size(240, 81);
      this.guna2GradientPanel1.TabIndex = 0;
      // 
      // MessageBoxUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.guna2GradientPanel1);
      this.Name = "MessageBoxUC";
      this.Size = new System.Drawing.Size(386, 262);
      this.ResumeLayout(false);

    }

    #endregion

    private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
  }
}
