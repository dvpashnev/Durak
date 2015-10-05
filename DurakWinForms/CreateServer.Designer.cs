namespace DurakWinForms
{
  partial class CreateServer
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.serverNameTb = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.NickTb = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(43, 105);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(166, 105);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = "Cansel";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 28);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Имя сервера";
      // 
      // serverNameTb
      // 
      this.serverNameTb.Location = new System.Drawing.Point(113, 25);
      this.serverNameTb.Name = "serverNameTb";
      this.serverNameTb.Size = new System.Drawing.Size(159, 20);
      this.serverNameTb.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 65);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Ваш ник";
      // 
      // NickTb
      // 
      this.NickTb.Location = new System.Drawing.Point(115, 62);
      this.NickTb.Name = "NickTb";
      this.NickTb.Size = new System.Drawing.Size(157, 20);
      this.NickTb.TabIndex = 8;
      // 
      // CreateServer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 143);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.NickTb);
      this.Controls.Add(this.serverNameTb);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "CreateServer";
      this.Text = "Создать сервер";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.TextBox serverNameTb;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.TextBox NickTb;
  }
}