namespace Jogo_da_idosa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            b2 = new Button();
            b5 = new Button();
            b8 = new Button();
            b9 = new Button();
            b6 = new Button();
            b3 = new Button();
            b7 = new Button();
            b4 = new Button();
            b1 = new Button();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 210);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 191);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.LightSeaGreen;
            button3.Location = new Point(643, 173);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 16;
            button3.Text = "sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.LightSeaGreen;
            button2.Location = new Point(514, 173);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 15;
            button2.Text = "Reiniciar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(385, 173);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 14;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(12, 118);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 78);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opções";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 40);
            label2.TabIndex = 15;
            label2.Text = "•0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(48, 40);
            label1.TabIndex = 14;
            label1.Text = "•X";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(527, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 109);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Empate";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(262, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 109);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Placar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 109);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogador";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(9, 67);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 1;
            // 
            // b2
            // 
            b2.BackColor = Color.LightSeaGreen;
            b2.FlatAppearance.BorderSize = 0;
            b2.FlatStyle = FlatStyle.Flat;
            b2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b2.ForeColor = Color.White;
            b2.Location = new Point(349, 216);
            b2.Name = "b2";
            b2.Size = new Size(75, 70);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = false;
            b2.Click += button4_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.LightSeaGreen;
            b5.FlatAppearance.BorderSize = 0;
            b5.FlatStyle = FlatStyle.Flat;
            b5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b5.ForeColor = Color.White;
            b5.Location = new Point(349, 292);
            b5.Name = "b5";
            b5.Size = new Size(75, 70);
            b5.TabIndex = 2;
            b5.UseVisualStyleBackColor = false;
            // 
            // b8
            // 
            b8.BackColor = Color.LightSeaGreen;
            b8.FlatAppearance.BorderSize = 0;
            b8.FlatStyle = FlatStyle.Flat;
            b8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b8.ForeColor = Color.White;
            b8.Location = new Point(349, 368);
            b8.Name = "b8";
            b8.Size = new Size(75, 70);
            b8.TabIndex = 3;
            b8.UseVisualStyleBackColor = false;
            // 
            // b9
            // 
            b9.BackColor = Color.LightSeaGreen;
            b9.FlatAppearance.BorderSize = 0;
            b9.FlatStyle = FlatStyle.Flat;
            b9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b9.ForeColor = Color.White;
            b9.Location = new Point(430, 368);
            b9.Name = "b9";
            b9.Size = new Size(75, 70);
            b9.TabIndex = 6;
            b9.UseVisualStyleBackColor = false;
            // 
            // b6
            // 
            b6.BackColor = Color.LightSeaGreen;
            b6.FlatAppearance.BorderSize = 0;
            b6.FlatStyle = FlatStyle.Flat;
            b6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b6.ForeColor = Color.White;
            b6.Location = new Point(430, 292);
            b6.Name = "b6";
            b6.Size = new Size(75, 70);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            b3.BackColor = Color.LightSeaGreen;
            b3.FlatAppearance.BorderSize = 0;
            b3.FlatStyle = FlatStyle.Flat;
            b3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b3.ForeColor = Color.White;
            b3.Location = new Point(430, 216);
            b3.Name = "b3";
            b3.Size = new Size(75, 70);
            b3.TabIndex = 4;
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.LightSeaGreen;
            b7.FlatAppearance.BorderSize = 0;
            b7.FlatStyle = FlatStyle.Flat;
            b7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b7.ForeColor = Color.White;
            b7.Location = new Point(268, 368);
            b7.Name = "b7";
            b7.Size = new Size(75, 70);
            b7.TabIndex = 9;
            b7.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            b4.BackColor = Color.LightSeaGreen;
            b4.FlatAppearance.BorderSize = 0;
            b4.FlatStyle = FlatStyle.Flat;
            b4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b4.ForeColor = Color.White;
            b4.Location = new Point(268, 292);
            b4.Name = "b4";
            b4.Size = new Size(75, 70);
            b4.TabIndex = 8;
            b4.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            b1.BackColor = Color.LightSeaGreen;
            b1.FlatAppearance.BorderSize = 0;
            b1.FlatStyle = FlatStyle.Flat;
            b1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b1.ForeColor = Color.White;
            b1.Location = new Point(268, 216);
            b1.Name = "b1";
            b1.Size = new Size(75, 70);
            b1.TabIndex = 7;
            b1.UseVisualStyleBackColor = false;
            b1.Click += button12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 450);
            Controls.Add(b7);
            Controls.Add(b4);
            Controls.Add(b1);
            Controls.Add(b9);
            Controls.Add(b6);
            Controls.Add(b3);
            Controls.Add(b8);
            Controls.Add(b5);
            Controls.Add(b2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button b2;
        private Button b5;
        private Button b8;
        private Button b9;
        private Button b6;
        private Button b3;
        private Button b7;
        private Button b4;
        private Button b1;
        private RadioButton radioButton1;
    }
}