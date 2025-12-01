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
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogador";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(28, 177);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(106, 34);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 82);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 24);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(264, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 124);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Placar";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(556, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(232, 124);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Empate";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(-11, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 293);
            panel1.TabIndex = 3;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.LightSeaGreen;
            textBox11.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox11.Location = new Point(435, 189);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 88);
            textBox11.TabIndex = 8;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.LightSeaGreen;
            textBox10.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox10.Location = new Point(435, 97);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 88);
            textBox10.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.LightSeaGreen;
            textBox9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox9.Location = new Point(435, 3);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 88);
            textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightSeaGreen;
            textBox8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox8.Location = new Point(329, 191);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 88);
            textBox8.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightSeaGreen;
            textBox7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox7.Location = new Point(329, 97);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 88);
            textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightSeaGreen;
            textBox6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox6.Location = new Point(329, 3);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 88);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightSeaGreen;
            textBox5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox5.Location = new Point(223, 191);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 88);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightSeaGreen;
            textBox4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox4.Location = new Point(223, 97);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 88);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightSeaGreen;
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textBox3.Location = new Point(223, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 88);
            textBox3.TabIndex = 0;
            // 
            // button10
            // 
            button10.ForeColor = Color.LightSeaGreen;
            button10.Location = new Point(364, 198);
            button10.Name = "button10";
            button10.Size = new Size(124, 23);
            button10.TabIndex = 9;
            button10.Text = "íniciar";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.ForeColor = Color.LightSeaGreen;
            button11.Location = new Point(494, 198);
            button11.Name = "button11";
            button11.Size = new Size(127, 23);
            button11.TabIndex = 10;
            button11.Text = "Reiniciar";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.ForeColor = Color.LightSeaGreen;
            button12.Location = new Point(627, 198);
            button12.Name = "button12";
            button12.Size = new Size(125, 23);
            button12.TabIndex = 11;
            button12.Text = "Sair";
            button12.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(12, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(191, 79);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opções";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 29);
            label2.Name = "label2";
            label2.Size = new Size(46, 40);
            label2.TabIndex = 1;
            label2.Text = "•0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(46, 37);
            label1.TabIndex = 0;
            label1.Text = "•X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(802, 516);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Azure;
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button10;
        private Button button11;
        private Button button12;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
