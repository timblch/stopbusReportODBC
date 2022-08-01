
namespace BusStopWP
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пользователь";
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Location = new System.Drawing.Point(32, 128);
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(215, 24);
            this.textUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пароль";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Location = new System.Drawing.Point(32, 191);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(215, 24);
            this.textPassword.TabIndex = 2;
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPassword.Location = new System.Drawing.Point(128, 221);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(118, 20);
            this.checkPassword.TabIndex = 3;
            this.checkPassword.Text = "Показать пароль";
            this.checkPassword.UseVisualStyleBackColor = true;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonRegistration.Enabled = false;
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(32, 342);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(215, 32);
            this.buttonRegistration.TabIndex = 4;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonInput.ForeColor = System.Drawing.Color.White;
            this.buttonInput.Location = new System.Drawing.Point(32, 266);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(215, 32);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Вход";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(32, 304);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(215, 32);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Х";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label4;
    }
}

