namespace Arbol_Binario_de_busqueda
{
    partial class MainForm
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
            textBox1 = new TextBox();
            panelArbol = new Panel();
            panelPreorden = new Panel();
            panelInorden = new Panel();
            panelPosorden = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 0;
            // 
            // panelArbol
            // 
            panelArbol.BackColor = SystemColors.ControlLight;
            panelArbol.Location = new Point(15, 85);
            panelArbol.Name = "panelArbol";
            panelArbol.Size = new Size(707, 244);
            panelArbol.TabIndex = 1;
            panelArbol.Paint += panelArbol_Paint;
            // 
            // panelPreorden
            // 
            panelPreorden.Location = new Point(14, 354);
            panelPreorden.Name = "panelPreorden";
            panelPreorden.Size = new Size(707, 42);
            panelPreorden.TabIndex = 2;
            panelPreorden.Paint += panelPreorden_Paint;
            // 
            // panelInorden
            // 
            panelInorden.Location = new Point(15, 426);
            panelInorden.Name = "panelInorden";
            panelInorden.Size = new Size(707, 45);
            panelInorden.TabIndex = 3;
            panelInorden.Paint += panelInorden_Paint;
            // 
            // panelPosorden
            // 
            panelPosorden.Location = new Point(15, 496);
            panelPosorden.Name = "panelPosorden";
            panelPosorden.Size = new Size(707, 44);
            panelPosorden.TabIndex = 4;
            panelPosorden.Paint += panelPosorden_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(170, 38);
            button1.Name = "button1";
            button1.Size = new Size(139, 24);
            button1.TabIndex = 5;
            button1.Text = "Add Node";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 6;
            label1.Text = "Please enter int value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 334);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Preorder ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 399);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Inorder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 478);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Postorder";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 65);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 10;
            label5.Text = "Binary Tree";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panelPosorden);
            Controls.Add(panelInorden);
            Controls.Add(panelPreorden);
            Controls.Add(panelArbol);
            Controls.Add(textBox1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panelArbol;
        private Panel panelPreorden;
        private Panel panelInorden;
        private Panel panelPosorden;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}