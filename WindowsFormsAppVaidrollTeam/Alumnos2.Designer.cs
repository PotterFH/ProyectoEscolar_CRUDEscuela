
namespace WindowsFormsAppVaidrollTeam
{
    partial class Alumnos2
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
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salon_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbosalon2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmatricula2 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbocurso2 = new System.Windows.Forms.ComboBox();
            this.txttel2 = new System.Windows.Forms.TextBox();
            this.txtcodigo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(491, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Carga de materias y asignacion de salon";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 29);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(211, 25);
            this.modificarToolStripMenuItem.Text = "Registrar materia y salon";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 283);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Matricula,
            this.Column4,
            this.salon_nombre,
            this.id_cursos,
            this.id_salon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_alumno";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "telefono";
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "curso_nombre";
            this.Column4.HeaderText = "Curso";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // salon_nombre
            // 
            this.salon_nombre.DataPropertyName = "salon_nombre";
            this.salon_nombre.HeaderText = "Salon";
            this.salon_nombre.Name = "salon_nombre";
            this.salon_nombre.ReadOnly = true;
            // 
            // id_cursos
            // 
            this.id_cursos.DataPropertyName = "id_cursos";
            this.id_cursos.HeaderText = "id_cursos";
            this.id_cursos.Name = "id_cursos";
            this.id_cursos.ReadOnly = true;
            this.id_cursos.Visible = false;
            // 
            // id_salon
            // 
            this.id_salon.DataPropertyName = "id_salon";
            this.id_salon.HeaderText = "id_salon";
            this.id_salon.Name = "id_salon";
            this.id_salon.ReadOnly = true;
            this.id_salon.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 60);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(192, 22);
            this.textBox8.MaxLength = 50;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(464, 26);
            this.textBox8.TabIndex = 3;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Buscar por nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbosalon2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmatricula2);
            this.groupBox1.Controls.Add(this.txtnombre2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbocurso2);
            this.groupBox1.Controls.Add(this.txttel2);
            this.groupBox1.Controls.Add(this.txtcodigo2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 168);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // cbosalon2
            // 
            this.cbosalon2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosalon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosalon2.FormattingEnabled = true;
            this.cbosalon2.Location = new System.Drawing.Point(401, 120);
            this.cbosalon2.Name = "cbosalon2";
            this.cbosalon2.Size = new System.Drawing.Size(180, 28);
            this.cbosalon2.TabIndex = 11;
            this.cbosalon2.SelectedIndexChanged += new System.EventHandler(this.cbosalon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salón:";
            // 
            // txtmatricula2
            // 
            this.txtmatricula2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricula2.Location = new System.Drawing.Point(401, 72);
            this.txtmatricula2.MaxLength = 6;
            this.txtmatricula2.Name = "txtmatricula2";
            this.txtmatricula2.Size = new System.Drawing.Size(180, 26);
            this.txtmatricula2.TabIndex = 9;
            // 
            // txtnombre2
            // 
            this.txtnombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre2.Location = new System.Drawing.Point(401, 25);
            this.txtnombre2.MaxLength = 50;
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(255, 26);
            this.txtnombre2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre:";
            // 
            // cbocurso2
            // 
            this.cbocurso2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocurso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocurso2.FormattingEnabled = true;
            this.cbocurso2.Location = new System.Drawing.Point(106, 120);
            this.cbocurso2.Name = "cbocurso2";
            this.cbocurso2.Size = new System.Drawing.Size(180, 28);
            this.cbocurso2.TabIndex = 6;
            this.cbocurso2.SelectedIndexChanged += new System.EventHandler(this.cbocurso2_SelectedIndexChanged);
            // 
            // txttel2
            // 
            this.txttel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel2.Location = new System.Drawing.Point(106, 69);
            this.txttel2.MaxLength = 9;
            this.txttel2.Name = "txttel2";
            this.txttel2.Size = new System.Drawing.Size(180, 26);
            this.txttel2.TabIndex = 4;
            // 
            // txtcodigo2
            // 
            this.txtcodigo2.Enabled = false;
            this.txtcodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo2.Location = new System.Drawing.Point(106, 25);
            this.txtcodigo2.Name = "txtcodigo2";
            this.txtcodigo2.Size = new System.Drawing.Size(180, 26);
            this.txtcodigo2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // Alumnos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Name = "Alumnos2";
            this.Text = "Alumnos2";
            this.Load += new System.EventHandler(this.Alumnos2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn salon_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_salon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbosalon2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmatricula2;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbocurso2;
        private System.Windows.Forms.TextBox txttel2;
        private System.Windows.Forms.TextBox txtcodigo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}