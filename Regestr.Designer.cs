namespace ОАИП_12
{
    partial class Regestr
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
            label1 = new Label();
            textBox_name = new TextBox();
            textBox_email = new TextBox();
            textBox_pass = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_phone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 29);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(108, 83);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(162, 27);
            textBox_name.TabIndex = 1;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(108, 132);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(162, 27);
            textBox_email.TabIndex = 2;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(108, 182);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(162, 27);
            textBox_pass.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(25, 296);
            button1.Name = "button1";
            button1.Size = new Size(245, 43);
            button1.TabIndex = 4;
            button1.Text = "Зарегестрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 139);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 6;
            label3.Text = "Почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 189);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 237);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Телефон";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(108, 237);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(162, 27);
            textBox_phone.TabIndex = 9;
            // 
            // Regestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 409);
            Controls.Add(textBox_phone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_email);
            Controls.Add(textBox_name);
            Controls.Add(label1);
            Name = "Regestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regestr";
            Load += Regestr_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_name;
        private TextBox textBox_email;
        private TextBox textBox_pass;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_phone;
    }
}