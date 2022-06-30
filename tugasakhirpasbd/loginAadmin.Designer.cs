
namespace tugasakhirpasbd
{
    partial class loginadmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginadmin));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectakhirDataSet4 = new tugasakhirpasbd.projectakhirDataSet4();
            this.adminLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminLogTableAdapter = new tugasakhirpasbd.projectakhirDataSet4TableAdapters.AdminLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectakhirDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(320, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 49;
            this.label7.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(318, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminLogBindingSource, "password", true));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(320, 270);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(326, 33);
            this.password.TabIndex = 46;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminLogBindingSource, "username", true));
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(320, 220);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.Size = new System.Drawing.Size(326, 31);
            this.username.TabIndex = 45;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(353, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 43);
            this.button1.TabIndex = 44;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tugasakhirpasbd.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(423, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // projectakhirDataSet4
            // 
            this.projectakhirDataSet4.DataSetName = "projectakhirDataSet4";
            this.projectakhirDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminLogBindingSource
            // 
            this.adminLogBindingSource.DataMember = "AdminLog";
            this.adminLogBindingSource.DataSource = this.projectakhirDataSet4;
            // 
            // adminLogTableAdapter
            // 
            this.adminLogTableAdapter.ClearBeforeFill = true;
            // 
            // loginadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(955, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "loginadmin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectakhirDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private projectakhirDataSet4 projectakhirDataSet4;
        private System.Windows.Forms.BindingSource adminLogBindingSource;
        private projectakhirDataSet4TableAdapters.AdminLogTableAdapter adminLogTableAdapter;
    }
}