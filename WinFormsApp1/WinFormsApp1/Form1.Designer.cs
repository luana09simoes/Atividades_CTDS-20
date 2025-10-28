namespace WinFormsApp1
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
            button1 = new Button();
            panel1 = new Panel();
            button11 = new Button();
            button13 = new Button();
            button12 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            IMC = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 55);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += gerarNumero;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 281);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button11
            // 
            button11.BackColor = Color.Yellow;
            button11.Location = new Point(12, 255);
            button11.Name = "button11";
            button11.Size = new Size(269, 23);
            button11.TabIndex = 13;
            button11.Text = "Calcular Índice de Massa Corporal";
            button11.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Yellow;
            button13.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(206, 194);
            button13.Name = "button13";
            button13.Size = new Size(75, 55);
            button13.TabIndex = 12;
            button13.Text = "Del";
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Yellow;
            button12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(206, 133);
            button12.Name = "button12";
            button12.Size = new Size(75, 55);
            button12.TabIndex = 11;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = false;
            button12.Click += gerarNumero;
            // 
            // button10
            // 
            button10.BackColor = Color.Yellow;
            button10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(111, 194);
            button10.Name = "button10";
            button10.Size = new Size(75, 55);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += gerarNumero;
            // 
            // button9
            // 
            button9.BackColor = Color.Yellow;
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(206, 72);
            button9.Name = "button9";
            button9.Size = new Size(75, 55);
            button9.TabIndex = 8;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = false;
            button9.Click += gerarNumero;
            // 
            // button8
            // 
            button8.BackColor = Color.Yellow;
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(111, 133);
            button8.Name = "button8";
            button8.Size = new Size(75, 58);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += gerarNumero;
            // 
            // button7
            // 
            button7.BackColor = Color.Yellow;
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(206, 11);
            button7.Name = "button7";
            button7.Size = new Size(75, 55);
            button7.TabIndex = 6;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = false;
            button7.Click += gerarNumero;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(111, 72);
            button6.Name = "button6";
            button6.Size = new Size(75, 55);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += gerarNumero;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(111, 11);
            button5.Name = "button5";
            button5.Size = new Size(75, 55);
            button5.TabIndex = 4;
            button5.Text = "8";
            button5.UseVisualStyleBackColor = false;
            button5.Click += gerarNumero;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 194);
            button4.Name = "button4";
            button4.Size = new Size(75, 55);
            button4.TabIndex = 3;
            button4.Text = ",";
            button4.UseVisualStyleBackColor = false;
            button4.Click += gerarNumero;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 133);
            button3.Name = "button3";
            button3.Size = new Size(75, 55);
            button3.TabIndex = 2;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = false;
            button3.Click += gerarNumero;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 72);
            button2.Name = "button2";
            button2.Size = new Size(75, 55);
            button2.TabIndex = 1;
            button2.Text = "4";
            button2.UseVisualStyleBackColor = false;
            button2.Click += gerarNumero;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 64);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 2;
            label1.Text = "peso";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 108);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "Altura";
            label2.Click += label2_Click;
            // 
            // IMC
            // 
            IMC.AutoSize = true;
            IMC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            IMC.Location = new Point(128, 147);
            IMC.Name = "IMC";
            IMC.Size = new Size(32, 17);
            IMC.TabIndex = 4;
            IMC.Text = "IMC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(270, 70);
            label4.Name = "label4";
            label4.Size = new Size(23, 17);
            label4.TabIndex = 5;
            label4.Text = "kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 6;
            label5.Text = "Situação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(273, 108);
            label3.Name = "label3";
            label3.Size = new Size(20, 17);
            label3.TabIndex = 7;
            label3.Text = "m";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 23);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, -5);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 11;
            label6.Text = "Cálculo de IMC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(65, 16);
            label7.Name = "label7";
            label7.Size = new Size(182, 20);
            label7.TabIndex = 12;
            label7.Text = "Informe seu peso e altura";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(68, 64);
            label8.Name = "label8";
            label8.Size = new Size(33, 25);
            label8.TabIndex = 13;
            label8.Text = "⚖️";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(68, 102);
            label9.Name = "label9";
            label9.Size = new Size(33, 25);
            label9.TabIndex = 14;
            label9.Text = "📏";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(68, 142);
            label10.Name = "label10";
            label10.Size = new Size(32, 25);
            label10.TabIndex = 15;
            label10.Text = "📈";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(320, 489);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(IMC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "  ";
            Load += Form1_Load;
            Click += gerarNumero;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button11;
        private Button button13;
        private Button button12;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label IMC;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}