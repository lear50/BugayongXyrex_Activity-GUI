using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UserNameLbl = new Label();
            PasswordLbl = new Label();
            UsernameTxtbox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            CancelBtn = new Button();
            ErrorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Location = new Point(103, 274);
            UserNameLbl.Margin = new Padding(2, 0, 2, 0);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(63, 15);
            UserNameLbl.TabIndex = 0;
            UserNameLbl.Text = "Username:";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(103, 315);
            PasswordLbl.Margin = new Padding(2, 0, 2, 0);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(57, 15);
            PasswordLbl.TabIndex = 1;
            PasswordLbl.Text = "Password";
            // 
            // UsernameTxtbox
            // 
            UsernameTxtbox.Location = new Point(189, 271);
            UsernameTxtbox.Margin = new Padding(2);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(239, 23);
            UsernameTxtbox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(189, 311);
            PasswordTxtBox.Margin = new Padding(2);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(239, 23);
            PasswordTxtBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSize = true;
            LoginBtn.Location = new Point(169, 417);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(78, 25);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSize = true;
            CancelBtn.Location = new Point(292, 417);
            CancelBtn.Margin = new Padding(2);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(78, 25);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ErrorProvider1
            // 
            ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(29, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 240);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.HotTrack;
            pictureBox2.Location = new Point(-11, 508);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(584, 76);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.HotTrack;
            pictureBox3.Location = new Point(-11, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(584, 76);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 544);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(CancelBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtbox);
            Controls.Add(PasswordLbl);
            Controls.Add(UserNameLbl);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "LogIn Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLbl;
        private Label PasswordLbl;
        private TextBox UsernameTxtbox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Button CancelBtn;
        private ErrorProvider ErrorProvider1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
