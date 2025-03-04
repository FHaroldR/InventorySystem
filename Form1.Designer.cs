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
        label1 = new Label();
        SuspendLayout();
        // 
        // txtUsername
        // 
        txtUsername.BorderStyle = BorderStyle.None;
        txtUsername.Font = new Font("Segoe UI", 14F);
        txtUsername.Location = new Point(301, 159);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(167, 25);
        txtUsername.TabIndex = 0;
        txtUsername.Text = "Username";
        txtUsername.TextChanged += textBox1_TextChanged;
        // 
        // txtPassword
        // 
        txtPassword.BorderStyle = BorderStyle.None;
        txtPassword.Font = new Font("Segoe UI", 14F);
        txtPassword.Location = new Point(301, 220);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(167, 25);
        txtPassword.TabIndex = 1;
        txtPassword.Text = "Password";
        txtPassword.UseSystemPasswordChar = true;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.Highlight;
        button1.BackgroundImageLayout = ImageLayout.Center;
        button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.ButtonFace;
        button1.Location = new Point(301, 277);
        button1.Name = "button1";
        button1.Size = new Size(92, 39);
        button1.TabIndex = 2;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(290, 94);
        label1.Name = "label1";
        label1.Size = new Size(192, 34);
        label1.TabIndex = 3;
        label1.Text = "Admin Login";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label1);
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
    private Label label1;
}
