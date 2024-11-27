namespace Arbol_Binario_de_busqueda
{
    partial class Acceso
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            Datelb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 50);
            label1.Name = "label1";
            label1.Size = new Size(269, 30);
            label1.TabIndex = 0;
            label1.Text = "Arbol Binario de busqueda";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 104);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 150);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(298, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '-';
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(296, 196);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(156, 33);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += Accessbtn_Click;
            // 
            // Datelb
            // 
            Datelb.AutoSize = true;
            Datelb.Location = new Point(355, 267);
            Datelb.Name = "Datelb";
            Datelb.Size = new Size(31, 15);
            Datelb.TabIndex = 5;
            Datelb.Text = "Date";
            // 
            // Acceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Datelb);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Acceso";
            Text = "Formulario de acceso a la ineterfaz grafica del arbol";
            Load += Acceso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Label Datelb;
    }
}
