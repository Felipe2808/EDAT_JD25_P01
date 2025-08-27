namespace UI.Trabajo
{
    partial class frmDatossAleatorios
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
            Numero = new TextBox();
            Nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Fecha = new DateTimePicker();
            Seguro = new CheckBox();
            label4 = new Label();
            Grupo = new DomainUpDown();
            Sueldo = new TextBox();
            label5 = new Label();
            Masculino = new RadioButton();
            Femenino = new RadioButton();
            Generar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            label1.Click += label1_Click;
            // 
            // Numero
            // 
            Numero.Location = new Point(73, 50);
            Numero.Name = "Numero";
            Numero.Size = new Size(100, 23);
            Numero.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(73, 91);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(201, 23);
            Nombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 135);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de Nacimiento";
            // 
            // Fecha
            // 
            Fecha.Location = new Point(141, 129);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(220, 23);
            Fecha.TabIndex = 6;
            // 
            // Seguro
            // 
            Seguro.AutoSize = true;
            Seguro.Location = new Point(65, 297);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(106, 19);
            Seguro.TabIndex = 7;
            Seguro.Text = "Seguro Medico";
            Seguro.UseVisualStyleBackColor = true;
            Seguro.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 222);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Grupo";
            // 
            // Grupo
            // 
            Grupo.Location = new Point(62, 220);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(120, 23);
            Grupo.TabIndex = 10;
            Grupo.SelectedItemChanged += Grupo_SelectedItemChanged_1;
            // 
            // Sueldo
            // 
            Sueldo.Location = new Point(65, 255);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(100, 23);
            Sueldo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 255);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "Sueldo";
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(28, 160);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(80, 19);
            Masculino.TabIndex = 15;
            Masculino.TabStop = true;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(30, 195);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(78, 19);
            Femenino.TabIndex = 17;
            Femenino.TabStop = true;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // Generar
            // 
            Generar.Location = new Point(100, 335);
            Generar.Name = "Generar";
            Generar.Size = new Size(196, 23);
            Generar.TabIndex = 18;
            Generar.Text = "Generar Datos Aleatorios";
            Generar.UseVisualStyleBackColor = true;
            Generar.Click += Generar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Fecha);
            groupBox1.Controls.Add(Generar);
            groupBox1.Controls.Add(Masculino);
            groupBox1.Controls.Add(Femenino);
            groupBox1.Controls.Add(Grupo);
            groupBox1.Controls.Add(Seguro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Sueldo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Numero);
            groupBox1.Controls.Add(Nombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 392);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            // 
            // frmDatossAleatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 498);
            Controls.Add(groupBox1);
            Name = "frmDatossAleatorios";
            Text = "frmDatossAleatorios";
            Load += frmDatossAleatorios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox Numero;
        private TextBox Nombre;
        private Label label2;
        private Label label3;
        private DateTimePicker Fecha;
        private CheckBox Seguro;
        private Label label4;
        private DomainUpDown Grupo;
        private TextBox Sueldo;
        private Label label5;
        private RadioButton Masculino;
        private RadioButton Femenino;
        private Button Generar;
        private GroupBox groupBox1;
    }
}