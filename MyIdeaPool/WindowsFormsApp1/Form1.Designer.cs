namespace WindowsFormsApp1
{
    partial class Form1
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
            this.SignUpButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.JwtTextBox = new System.Windows.Forms.TextBox();
            this.RefreshTextBox = new System.Windows.Forms.TextBox();
            this.GetTokenButton = new System.Windows.Forms.Button();
            this.ResponseLogClearButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.MeButton = new System.Windows.Forms.Button();
            this.CreateIdeaButton = new System.Windows.Forms.Button();
            this.NewIdeaContentTextBox = new System.Windows.Forms.TextBox();
            this.NewIdeaImpactTextBox = new System.Windows.Forms.TextBox();
            this.NewIdeaConfidenceTextBox = new System.Windows.Forms.TextBox();
            this.NewIdeaEaseTextBox = new System.Windows.Forms.TextBox();
            this.IdeaContentTextBox = new System.Windows.Forms.TextBox();
            this.IdeaImpactTextBox = new System.Windows.Forms.TextBox();
            this.IdeaConfidenceTextBox = new System.Windows.Forms.TextBox();
            this.IdeaEaseTextBox = new System.Windows.Forms.TextBox();
            this.IdeaIdTextBox = new System.Windows.Forms.TextBox();
            this.IdeaAvgTextBox = new System.Windows.Forms.TextBox();
            this.IdeaCreatedAtTextBox = new System.Windows.Forms.TextBox();
            this.GetIdeaButton = new System.Windows.Forms.Button();
            this.DeleteIdeaButton = new System.Windows.Forms.Button();
            this.UpdateIdeaButton = new System.Windows.Forms.Button();
            this.GetIdeasButton = new System.Windows.Forms.Button();
            this.LastResponseCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(405, 26);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(-1, -1);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(128, 20);
            this.UrlTextBox.TabIndex = 1;
            this.UrlTextBox.TextChanged += new System.EventHandler(this.UrlTextBox_TextChanged);
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResponseTextBox.Location = new System.Drawing.Point(0, 162);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResponseTextBox.Size = new System.Drawing.Size(1201, 522);
            this.ResponseTextBox.TabIndex = 2;
            // 
            // JwtTextBox
            // 
            this.JwtTextBox.Location = new System.Drawing.Point(133, -1);
            this.JwtTextBox.Name = "JwtTextBox";
            this.JwtTextBox.Size = new System.Drawing.Size(756, 20);
            this.JwtTextBox.TabIndex = 3;
            // 
            // RefreshTextBox
            // 
            this.RefreshTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshTextBox.Location = new System.Drawing.Point(895, 0);
            this.RefreshTextBox.Name = "RefreshTextBox";
            this.RefreshTextBox.Size = new System.Drawing.Size(306, 20);
            this.RefreshTextBox.TabIndex = 4;
            // 
            // GetTokenButton
            // 
            this.GetTokenButton.Location = new System.Drawing.Point(567, 26);
            this.GetTokenButton.Name = "GetTokenButton";
            this.GetTokenButton.Size = new System.Drawing.Size(75, 23);
            this.GetTokenButton.TabIndex = 5;
            this.GetTokenButton.Text = "GetToken";
            this.GetTokenButton.UseVisualStyleBackColor = true;
            this.GetTokenButton.Click += new System.EventHandler(this.GetTokenButton_Click);
            // 
            // ResponseLogClearButton
            // 
            this.ResponseLogClearButton.Location = new System.Drawing.Point(0, 133);
            this.ResponseLogClearButton.Name = "ResponseLogClearButton";
            this.ResponseLogClearButton.Size = new System.Drawing.Size(75, 23);
            this.ResponseLogClearButton.TabIndex = 6;
            this.ResponseLogClearButton.Text = "Clear";
            this.ResponseLogClearButton.UseVisualStyleBackColor = true;
            this.ResponseLogClearButton.Click += new System.EventHandler(this.ResponseLogClearButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(3, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(128, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.Text = "Name Surname";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(137, 28);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(128, 20);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.Text = "name@domain.com";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(271, 28);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(128, 20);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.Text = "Abc231415";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(486, 26);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(648, 26);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(729, 26);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 12;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MeButton
            // 
            this.MeButton.Location = new System.Drawing.Point(810, 26);
            this.MeButton.Name = "MeButton";
            this.MeButton.Size = new System.Drawing.Size(75, 23);
            this.MeButton.TabIndex = 13;
            this.MeButton.Text = "Me";
            this.MeButton.UseVisualStyleBackColor = true;
            this.MeButton.Click += new System.EventHandler(this.MeButton_Click);
            // 
            // CreateIdeaButton
            // 
            this.CreateIdeaButton.Location = new System.Drawing.Point(271, 54);
            this.CreateIdeaButton.Name = "CreateIdeaButton";
            this.CreateIdeaButton.Size = new System.Drawing.Size(75, 23);
            this.CreateIdeaButton.TabIndex = 14;
            this.CreateIdeaButton.Text = "Create";
            this.CreateIdeaButton.UseVisualStyleBackColor = true;
            this.CreateIdeaButton.Click += new System.EventHandler(this.CreateIdeaButton_Click);
            // 
            // NewIdeaContentTextBox
            // 
            this.NewIdeaContentTextBox.Location = new System.Drawing.Point(3, 54);
            this.NewIdeaContentTextBox.Name = "NewIdeaContentTextBox";
            this.NewIdeaContentTextBox.Size = new System.Drawing.Size(128, 20);
            this.NewIdeaContentTextBox.TabIndex = 15;
            this.NewIdeaContentTextBox.Text = "Content 1";
            // 
            // NewIdeaImpactTextBox
            // 
            this.NewIdeaImpactTextBox.Location = new System.Drawing.Point(137, 54);
            this.NewIdeaImpactTextBox.Name = "NewIdeaImpactTextBox";
            this.NewIdeaImpactTextBox.Size = new System.Drawing.Size(34, 20);
            this.NewIdeaImpactTextBox.TabIndex = 16;
            this.NewIdeaImpactTextBox.Text = "1";
            // 
            // NewIdeaConfidenceTextBox
            // 
            this.NewIdeaConfidenceTextBox.Location = new System.Drawing.Point(217, 54);
            this.NewIdeaConfidenceTextBox.Name = "NewIdeaConfidenceTextBox";
            this.NewIdeaConfidenceTextBox.Size = new System.Drawing.Size(34, 20);
            this.NewIdeaConfidenceTextBox.TabIndex = 17;
            this.NewIdeaConfidenceTextBox.Text = "3";
            // 
            // NewIdeaEaseTextBox
            // 
            this.NewIdeaEaseTextBox.Location = new System.Drawing.Point(177, 54);
            this.NewIdeaEaseTextBox.Name = "NewIdeaEaseTextBox";
            this.NewIdeaEaseTextBox.Size = new System.Drawing.Size(34, 20);
            this.NewIdeaEaseTextBox.TabIndex = 18;
            this.NewIdeaEaseTextBox.Text = "2";
            // 
            // IdeaContentTextBox
            // 
            this.IdeaContentTextBox.Location = new System.Drawing.Point(152, 80);
            this.IdeaContentTextBox.Name = "IdeaContentTextBox";
            this.IdeaContentTextBox.Size = new System.Drawing.Size(128, 20);
            this.IdeaContentTextBox.TabIndex = 15;
            // 
            // IdeaImpactTextBox
            // 
            this.IdeaImpactTextBox.Location = new System.Drawing.Point(286, 80);
            this.IdeaImpactTextBox.Name = "IdeaImpactTextBox";
            this.IdeaImpactTextBox.Size = new System.Drawing.Size(34, 20);
            this.IdeaImpactTextBox.TabIndex = 16;
            // 
            // IdeaConfidenceTextBox
            // 
            this.IdeaConfidenceTextBox.Location = new System.Drawing.Point(366, 80);
            this.IdeaConfidenceTextBox.Name = "IdeaConfidenceTextBox";
            this.IdeaConfidenceTextBox.Size = new System.Drawing.Size(34, 20);
            this.IdeaConfidenceTextBox.TabIndex = 17;
            // 
            // IdeaEaseTextBox
            // 
            this.IdeaEaseTextBox.Location = new System.Drawing.Point(326, 80);
            this.IdeaEaseTextBox.Name = "IdeaEaseTextBox";
            this.IdeaEaseTextBox.Size = new System.Drawing.Size(34, 20);
            this.IdeaEaseTextBox.TabIndex = 18;
            // 
            // IdeaIdTextBox
            // 
            this.IdeaIdTextBox.Location = new System.Drawing.Point(3, 80);
            this.IdeaIdTextBox.Name = "IdeaIdTextBox";
            this.IdeaIdTextBox.Size = new System.Drawing.Size(143, 20);
            this.IdeaIdTextBox.TabIndex = 19;
            // 
            // IdeaAvgTextBox
            // 
            this.IdeaAvgTextBox.Location = new System.Drawing.Point(406, 80);
            this.IdeaAvgTextBox.Name = "IdeaAvgTextBox";
            this.IdeaAvgTextBox.Size = new System.Drawing.Size(34, 20);
            this.IdeaAvgTextBox.TabIndex = 20;
            // 
            // IdeaCreatedAtTextBox
            // 
            this.IdeaCreatedAtTextBox.Location = new System.Drawing.Point(446, 80);
            this.IdeaCreatedAtTextBox.Name = "IdeaCreatedAtTextBox";
            this.IdeaCreatedAtTextBox.Size = new System.Drawing.Size(140, 20);
            this.IdeaCreatedAtTextBox.TabIndex = 21;
            // 
            // GetIdeaButton
            // 
            this.GetIdeaButton.Location = new System.Drawing.Point(352, 54);
            this.GetIdeaButton.Name = "GetIdeaButton";
            this.GetIdeaButton.Size = new System.Drawing.Size(75, 23);
            this.GetIdeaButton.TabIndex = 22;
            this.GetIdeaButton.Text = "GetIdea";
            this.GetIdeaButton.UseVisualStyleBackColor = true;
            this.GetIdeaButton.Click += new System.EventHandler(this.GetIdeaButton_Click);
            // 
            // DeleteIdeaButton
            // 
            this.DeleteIdeaButton.Location = new System.Drawing.Point(592, 77);
            this.DeleteIdeaButton.Name = "DeleteIdeaButton";
            this.DeleteIdeaButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteIdeaButton.TabIndex = 23;
            this.DeleteIdeaButton.Text = "Delete";
            this.DeleteIdeaButton.UseVisualStyleBackColor = true;
            this.DeleteIdeaButton.Click += new System.EventHandler(this.DeleteIdeaButton_Click);
            // 
            // UpdateIdeaButton
            // 
            this.UpdateIdeaButton.Location = new System.Drawing.Point(673, 77);
            this.UpdateIdeaButton.Name = "UpdateIdeaButton";
            this.UpdateIdeaButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateIdeaButton.TabIndex = 24;
            this.UpdateIdeaButton.Text = "Update";
            this.UpdateIdeaButton.UseVisualStyleBackColor = true;
            this.UpdateIdeaButton.Click += new System.EventHandler(this.UpdateIdeaButton_Click);
            // 
            // GetIdeasButton
            // 
            this.GetIdeasButton.Location = new System.Drawing.Point(433, 54);
            this.GetIdeasButton.Name = "GetIdeasButton";
            this.GetIdeasButton.Size = new System.Drawing.Size(75, 23);
            this.GetIdeasButton.TabIndex = 25;
            this.GetIdeasButton.Text = "GetIdeas";
            this.GetIdeasButton.UseVisualStyleBackColor = true;
            this.GetIdeasButton.Click += new System.EventHandler(this.GetIdeasButton_Click);
            // 
            // LastResponseCodeLabel
            // 
            this.LastResponseCodeLabel.AutoSize = true;
            this.LastResponseCodeLabel.Location = new System.Drawing.Point(81, 143);
            this.LastResponseCodeLabel.Name = "LastResponseCodeLabel";
            this.LastResponseCodeLabel.Size = new System.Drawing.Size(32, 13);
            this.LastResponseCodeLabel.TabIndex = 26;
            this.LastResponseCodeLabel.Text = "Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 684);
            this.Controls.Add(this.LastResponseCodeLabel);
            this.Controls.Add(this.GetIdeasButton);
            this.Controls.Add(this.UpdateIdeaButton);
            this.Controls.Add(this.DeleteIdeaButton);
            this.Controls.Add(this.GetIdeaButton);
            this.Controls.Add(this.IdeaCreatedAtTextBox);
            this.Controls.Add(this.IdeaAvgTextBox);
            this.Controls.Add(this.IdeaIdTextBox);
            this.Controls.Add(this.IdeaEaseTextBox);
            this.Controls.Add(this.NewIdeaEaseTextBox);
            this.Controls.Add(this.IdeaConfidenceTextBox);
            this.Controls.Add(this.NewIdeaConfidenceTextBox);
            this.Controls.Add(this.IdeaImpactTextBox);
            this.Controls.Add(this.NewIdeaImpactTextBox);
            this.Controls.Add(this.IdeaContentTextBox);
            this.Controls.Add(this.NewIdeaContentTextBox);
            this.Controls.Add(this.CreateIdeaButton);
            this.Controls.Add(this.MeButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ResponseLogClearButton);
            this.Controls.Add(this.GetTokenButton);
            this.Controls.Add(this.RefreshTextBox);
            this.Controls.Add(this.JwtTextBox);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.SignUpButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.TextBox JwtTextBox;
        private System.Windows.Forms.TextBox RefreshTextBox;
        private System.Windows.Forms.Button GetTokenButton;
        private System.Windows.Forms.Button ResponseLogClearButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button MeButton;
        private System.Windows.Forms.Button CreateIdeaButton;
        private System.Windows.Forms.TextBox NewIdeaContentTextBox;
        private System.Windows.Forms.TextBox NewIdeaImpactTextBox;
        private System.Windows.Forms.TextBox NewIdeaConfidenceTextBox;
        private System.Windows.Forms.TextBox NewIdeaEaseTextBox;
        private System.Windows.Forms.TextBox IdeaContentTextBox;
        private System.Windows.Forms.TextBox IdeaImpactTextBox;
        private System.Windows.Forms.TextBox IdeaConfidenceTextBox;
        private System.Windows.Forms.TextBox IdeaEaseTextBox;
        private System.Windows.Forms.TextBox IdeaIdTextBox;
        private System.Windows.Forms.TextBox IdeaAvgTextBox;
        private System.Windows.Forms.TextBox IdeaCreatedAtTextBox;
        private System.Windows.Forms.Button GetIdeaButton;
        private System.Windows.Forms.Button DeleteIdeaButton;
        private System.Windows.Forms.Button UpdateIdeaButton;
        private System.Windows.Forms.Button GetIdeasButton;
        private System.Windows.Forms.Label LastResponseCodeLabel;
    }
}

