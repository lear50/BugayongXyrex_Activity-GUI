namespace Windows_Forms_Sample
{
    partial class Form2
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            studentImage = new PictureBox();
            pictureBox3 = new PictureBox();
            NameLabel = new Label();
            AddressLabel = new Label();
            ContactNumberLabel = new Label();
            EmailAddressLabel = new Label();
            CourseLabel = new Label();
            NameOfParentGuardianLabel = new Label();
            ParentGuardianContactNumberLabel = new Label();
            NickanameLabel = new Label();
            HobbiesLabel = new Label();
            addChangeImage = new Button();
            editUpdate = new Button();
            pictureBox2 = new PictureBox();
            Namee = new Label();
            Address = new Label();
            ContactNumber = new Label();
            EmailAddress = new Label();
            Course = new Label();
            NameOfParentGuardian = new Label();
            ParentGuardianContactNumber = new Label();
            Hobbies = new Label();
            Nickname = new Label();
            label19 = new Label();
            AgeLabel = new Label();
            Age = new Label();
            YearLabel = new Label();
            Year = new Label();
            ((System.ComponentModel.ISupportInitialize)studentImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // studentImage
            // 
            studentImage.BackColor = SystemColors.ControlLight;
            studentImage.BackgroundImage = (Image)resources.GetObject("studentImage.BackgroundImage");
            studentImage.BackgroundImageLayout = ImageLayout.Zoom;
            studentImage.Location = new Point(227, 85);
            studentImage.Name = "studentImage";
            studentImage.Size = new Size(165, 203);
            studentImage.TabIndex = 0;
            studentImage.TabStop = false;
            studentImage.Tag = "Student Image";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.HotTrack;
            pictureBox3.Location = new Point(-4, -46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(649, 76);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(62, 367);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(43, 15);
            NameLabel.TabIndex = 10;
            NameLabel.Text = "Name:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLabel.Location = new Point(62, 427);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(54, 15);
            AddressLabel.TabIndex = 11;
            AddressLabel.Text = "Address:";
            // 
            // ContactNumberLabel
            // 
            ContactNumberLabel.AutoSize = true;
            ContactNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactNumberLabel.Location = new Point(62, 458);
            ContactNumberLabel.Name = "ContactNumberLabel";
            ContactNumberLabel.Size = new Size(102, 15);
            ContactNumberLabel.TabIndex = 12;
            ContactNumberLabel.Text = "Contact Number:";
            // 
            // EmailAddressLabel
            // 
            EmailAddressLabel.AutoSize = true;
            EmailAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailAddressLabel.Location = new Point(62, 489);
            EmailAddressLabel.Name = "EmailAddressLabel";
            EmailAddressLabel.Size = new Size(86, 15);
            EmailAddressLabel.TabIndex = 13;
            EmailAddressLabel.Text = "Email Address:";
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseLabel.Location = new Point(62, 546);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(48, 15);
            CourseLabel.TabIndex = 14;
            CourseLabel.Text = "Course:";
            // 
            // NameOfParentGuardianLabel
            // 
            NameOfParentGuardianLabel.AutoSize = true;
            NameOfParentGuardianLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameOfParentGuardianLabel.Location = new Point(62, 577);
            NameOfParentGuardianLabel.Name = "NameOfParentGuardianLabel";
            NameOfParentGuardianLabel.Size = new Size(153, 15);
            NameOfParentGuardianLabel.TabIndex = 15;
            NameOfParentGuardianLabel.Text = "Name of Parent/Guardian:";
            // 
            // ParentGuardianContactNumberLabel
            // 
            ParentGuardianContactNumberLabel.AutoSize = true;
            ParentGuardianContactNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ParentGuardianContactNumberLabel.Location = new Point(62, 608);
            ParentGuardianContactNumberLabel.Name = "ParentGuardianContactNumberLabel";
            ParentGuardianContactNumberLabel.Size = new Size(197, 15);
            ParentGuardianContactNumberLabel.TabIndex = 16;
            ParentGuardianContactNumberLabel.Text = "Parent/Guardian Contact Number:";
            // 
            // NickanameLabel
            // 
            NickanameLabel.AutoSize = true;
            NickanameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NickanameLabel.Location = new Point(62, 670);
            NickanameLabel.Name = "NickanameLabel";
            NickanameLabel.Size = new Size(66, 15);
            NickanameLabel.TabIndex = 18;
            NickanameLabel.Text = "Nickname:";
            // 
            // HobbiesLabel
            // 
            HobbiesLabel.AutoSize = true;
            HobbiesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HobbiesLabel.Location = new Point(62, 639);
            HobbiesLabel.Name = "HobbiesLabel";
            HobbiesLabel.Size = new Size(55, 15);
            HobbiesLabel.TabIndex = 17;
            HobbiesLabel.Text = "Hobbies:";
            // 
            // addChangeImage
            // 
            addChangeImage.AutoSize = true;
            addChangeImage.FlatStyle = FlatStyle.System;
            addChangeImage.Location = new Point(247, 307);
            addChangeImage.Name = "addChangeImage";
            addChangeImage.Size = new Size(125, 27);
            addChangeImage.TabIndex = 19;
            addChangeImage.Text = "Add/Change Image";
            addChangeImage.UseVisualStyleBackColor = true;
            // 
            // editUpdate
            // 
            editUpdate.AutoSize = true;
            editUpdate.FlatStyle = FlatStyle.System;
            editUpdate.Location = new Point(264, 722);
            editUpdate.Name = "editUpdate";
            editUpdate.Size = new Size(84, 24);
            editUpdate.TabIndex = 20;
            editUpdate.Text = "Edit/Update";
            editUpdate.UseVisualStyleBackColor = true;
            editUpdate.Click += EditUpdate_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.HotTrack;
            pictureBox2.Location = new Point(-4, 801);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(649, 30);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // Namee
            // 
            Namee.AutoSize = true;
            Namee.Location = new Point(276, 367);
            Namee.Name = "Namee";
            Namee.Size = new Size(93, 15);
            Namee.TabIndex = 22;
            Namee.Text = "Xyrex Bugayong";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(276, 427);
            Address.Name = "Address";
            Address.Size = new Size(166, 15);
            Address.TabIndex = 23;
            Address.Text = "Bani, Bayambang, Pangasinan";
            // 
            // ContactNumber
            // 
            ContactNumber.AutoSize = true;
            ContactNumber.Location = new Point(276, 458);
            ContactNumber.Name = "ContactNumber";
            ContactNumber.Size = new Size(79, 15);
            ContactNumber.TabIndex = 24;
            ContactNumber.Text = "0999 1653 344";
            // 
            // EmailAddress
            // 
            EmailAddress.AutoSize = true;
            EmailAddress.Location = new Point(276, 489);
            EmailAddress.Name = "EmailAddress";
            EmailAddress.Size = new Size(155, 15);
            EmailAddress.TabIndex = 25;
            EmailAddress.Text = "22bgu1240_ms@psu.edu.ph";
            // 
            // Course
            // 
            Course.AutoSize = true;
            Course.Location = new Point(276, 546);
            Course.Name = "Course";
            Course.Size = new Size(29, 15);
            Course.TabIndex = 26;
            Course.Text = "BSIT";
            // 
            // NameOfParentGuardian
            // 
            NameOfParentGuardian.AutoSize = true;
            NameOfParentGuardian.Location = new Point(276, 577);
            NameOfParentGuardian.Name = "NameOfParentGuardian";
            NameOfParentGuardian.Size = new Size(101, 15);
            NameOfParentGuardian.TabIndex = 27;
            NameOfParentGuardian.Text = "Winnie Bugayong";
            // 
            // ParentGuardianContactNumber
            // 
            ParentGuardianContactNumber.AutoSize = true;
            ParentGuardianContactNumber.Location = new Point(276, 608);
            ParentGuardianContactNumber.Name = "ParentGuardianContactNumber";
            ParentGuardianContactNumber.Size = new Size(79, 15);
            ParentGuardianContactNumber.TabIndex = 28;
            ParentGuardianContactNumber.Text = "0927 9641 849";
            // 
            // Hobbies
            // 
            Hobbies.AutoSize = true;
            Hobbies.Location = new Point(276, 639);
            Hobbies.Name = "Hobbies";
            Hobbies.Size = new Size(272, 15);
            Hobbies.TabIndex = 29;
            Hobbies.Text = "Playing Video Games, Watching Films, and Editing";
            // 
            // Nickname
            // 
            Nickname.AutoSize = true;
            Nickname.Location = new Point(276, 670);
            Nickname.Name = "Nickname";
            Nickname.Size = new Size(20, 15);
            Nickname.TabIndex = 30;
            Nickname.Text = "Xy";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(213, 33);
            label19.Name = "label19";
            label19.Size = new Size(187, 32);
            label19.TabIndex = 31;
            label19.Text = "Student Details";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeLabel.Location = new Point(62, 398);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(32, 15);
            AgeLabel.TabIndex = 32;
            AgeLabel.Text = "Age:";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(276, 398);
            Age.Name = "Age";
            Age.Size = new Size(19, 15);
            Age.TabIndex = 33;
            Age.Text = "21";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YearLabel.Location = new Point(62, 518);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(37, 15);
            YearLabel.TabIndex = 34;
            YearLabel.Text = "Year: ";
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(276, 518);
            Year.Name = "Year";
            Year.Size = new Size(34, 15);
            Year.TabIndex = 35;
            Year.Text = "Third";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 820);
            Controls.Add(Year);
            Controls.Add(YearLabel);
            Controls.Add(Age);
            Controls.Add(AgeLabel);
            Controls.Add(label19);
            Controls.Add(Nickname);
            Controls.Add(Hobbies);
            Controls.Add(ParentGuardianContactNumber);
            Controls.Add(NameOfParentGuardian);
            Controls.Add(Course);
            Controls.Add(EmailAddress);
            Controls.Add(ContactNumber);
            Controls.Add(Address);
            Controls.Add(Namee);
            Controls.Add(pictureBox2);
            Controls.Add(editUpdate);
            Controls.Add(addChangeImage);
            Controls.Add(NickanameLabel);
            Controls.Add(HobbiesLabel);
            Controls.Add(ParentGuardianContactNumberLabel);
            Controls.Add(NameOfParentGuardianLabel);
            Controls.Add(CourseLabel);
            Controls.Add(EmailAddressLabel);
            Controls.Add(ContactNumberLabel);
            Controls.Add(AddressLabel);
            Controls.Add(NameLabel);
            Controls.Add(pictureBox3);
            Controls.Add(studentImage);
            Name = "Form2";
            Text = "Student Details";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)studentImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox studentImage;
        private PictureBox pictureBox3;
        private Label NameLabel;
        private Label AddressLabel;
        private Label ContactNumberLabel;
        private Label EmailAddressLabel;
        private Label CourseLabel;
        private Label NameOfParentGuardianLabel;
        private Label ParentGuardianContactNumberLabel;
        private Label NickanameLabel;
        private Label HobbiesLabel;
        private Button addChangeImage;
        private Button editUpdate;
        private PictureBox pictureBox2;
        private Label Namee;
        private Label Address;
        private Label ContactNumber;
        private Label EmailAddress;
        private Label Course;
        private Label NameOfParentGuardian;
        private Label ParentGuardianContactNumber;
        private Label Hobbies;
        private Label Nickname;
        private Label label19;
        private Label AgeLabel;
        private Label Age;
        private Label YearLabel;
        private Label Year;
    }
}