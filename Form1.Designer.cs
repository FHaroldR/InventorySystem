namespace LoginApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(337, 152);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(100, 23);
        txtUsername.TabIndex = 0;
        txtUsername.Text = "Username";
        txtUsername.TextChanged += textBox1_TextChanged;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(340, 216);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(100, 23);
        txtPassword.TabIndex = 1;
        txtPassword.Text = "Password";
        txtPassword.UseSystemPasswordChar = true; // Hides the password input
        // 
        // button1
        // 
        button1.Location = new Point(348, 265);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 2;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(txtPassword);
        Controls.Add(txtUsername);
        Name = "Form1";
        Text = "Admin Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button button1;
}
