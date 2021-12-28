namespace PromedioAlumno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalBa = new System.Windows.Forms.TextBox();
            this.txtCalAl = new System.Windows.Forms.TextBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.txtNumAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcu
            // 
            this.btnCalcu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcu.Location = new System.Drawing.Point(48, 254);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(100, 27);
            this.btnCalcu.TabIndex = 32;
            this.btnCalcu.Text = "Calcular";
            this.btnCalcu.UseVisualStyleBackColor = false;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 31;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(154, 254);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 27);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(44, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Calificación más Baja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(44, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Calificación más Alta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Promedio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Número de calificaciones";
            // 
            // txtCalBa
            // 
            this.txtCalBa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalBa.Location = new System.Drawing.Point(209, 191);
            this.txtCalBa.Name = "txtCalBa";
            this.txtCalBa.Size = new System.Drawing.Size(100, 26);
            this.txtCalBa.TabIndex = 25;
            // 
            // txtCalAl
            // 
            this.txtCalAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalAl.Location = new System.Drawing.Point(209, 141);
            this.txtCalAl.Name = "txtCalAl";
            this.txtCalAl.Size = new System.Drawing.Size(100, 26);
            this.txtCalAl.TabIndex = 24;
            // 
            // txtProm
            // 
            this.txtProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProm.Location = new System.Drawing.Point(128, 87);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(100, 26);
            this.txtProm.TabIndex = 23;
            // 
            // txtNumAlumnos
            // 
            this.txtNumAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAlumnos.Location = new System.Drawing.Point(234, 31);
            this.txtNumAlumnos.Name = "txtNumAlumnos";
            this.txtNumAlumnos.Size = new System.Drawing.Size(100, 26);
            this.txtNumAlumnos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(403, 313);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalBa);
            this.Controls.Add(this.txtCalAl);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.txtNumAlumnos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promediar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalBa;
        private System.Windows.Forms.TextBox txtCalAl;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.TextBox txtNumAlumnos;
    }
}

