
namespace ElectronicBusStation
{
    partial class AuthorisationForm
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
            this.SignIn = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.VOAuth = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignIn.Location = new System.Drawing.Point(336, 251);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(95, 39);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(401, 165);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(111, 22);
            this.loginBox.TabIndex = 1;
            this.loginBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(401, 204);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(111, 22);
            this.passBox.TabIndex = 2;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.TextChanged += new System.EventHandler(this.passField_TextChanged);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(277, 158);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(83, 29);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(277, 197);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(99, 29);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Пароль";
            this.PassLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.Location = new System.Drawing.Point(113, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(555, 55);
            this.logo.TabIndex = 5;
            this.logo.Text = "Расписание автобусов";
            this.logo.Click += new System.EventHandler(this.label3_Click);
            // 
            // VOAuth
            // 
            this.VOAuth.AutoSize = true;
            this.VOAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VOAuth.Location = new System.Drawing.Point(197, 363);
            this.VOAuth.Name = "VOAuth";
            this.VOAuth.Size = new System.Drawing.Size(372, 39);
            this.VOAuth.TabIndex = 7;
            this.VOAuth.Text = "Продолжить без регистрации";
            this.VOAuth.UseVisualStyleBackColor = true;
            this.VOAuth.Click += new System.EventHandler(this.VOAuth_Click);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(246, 307);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(275, 39);
            this.Registration.TabIndex = 8;
            this.Registration.Text = "Быстрая регистрация";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.VOAuth);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.SignIn);
            this.Name = "AuthorisationForm";
            this.Text = "Расписание автобусов";
            this.Load += new System.EventHandler(this.AuthorisationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button VOAuth;
        private System.Windows.Forms.Button Registration;
    }
}

