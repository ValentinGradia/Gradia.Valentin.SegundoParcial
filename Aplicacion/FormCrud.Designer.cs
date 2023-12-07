﻿namespace Aplicacion
{
    partial class FormCrud
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
            lstEquipo = new ListBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregarEquipo = new Button();
            btnOrdenarEdadAscendente = new Button();
            btnOrdenarApellidosAscendente = new Button();
            label1 = new Label();
            label2 = new Label();
            btnOrdenarEdadDescendente = new Button();
            btnOrdenarApellidosDescendente = new Button();
            btnSerealizar = new Button();
            btnDeserealizar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnEliminarBBDD = new Button();
            btnModificarBBDD = new Button();
            btnAgregarBBDD = new Button();
            groupBox3 = new GroupBox();
            btnObtenerBBDD = new Button();
            rdbVoleibolistas = new RadioButton();
            rdbFutbolistas = new RadioButton();
            rdbBasquetbolistas = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lstEquipo
            // 
            lstEquipo.FormattingEnabled = true;
            lstEquipo.ItemHeight = 15;
            lstEquipo.Location = new Point(12, 12);
            lstEquipo.Name = "lstEquipo";
            lstEquipo.Size = new Size(892, 379);
            lstEquipo.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Location = new Point(12, 430);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 68);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Jugador";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            btnAgregar.MouseHover += btnAgregar_MouseHover;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ScrollBar;
            btnModificar.Location = new Point(12, 526);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 68);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Jugador";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseHover += btnModificar_MouseHover;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Location = new Point(12, 625);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 68);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Jugador";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseHover += btnEliminar_MouseHover;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.IndianRed;
            btnAgregarEquipo.ForeColor = SystemColors.ButtonFace;
            btnAgregarEquipo.Location = new Point(854, 503);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(109, 68);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnOrdenarEdadAscendente
            // 
            btnOrdenarEdadAscendente.BackColor = Color.FromArgb(255, 192, 128);
            btnOrdenarEdadAscendente.Location = new Point(910, 43);
            btnOrdenarEdadAscendente.Name = "btnOrdenarEdadAscendente";
            btnOrdenarEdadAscendente.Size = new Size(88, 53);
            btnOrdenarEdadAscendente.TabIndex = 5;
            btnOrdenarEdadAscendente.Text = "Ordenar por Edad";
            btnOrdenarEdadAscendente.UseVisualStyleBackColor = false;
            btnOrdenarEdadAscendente.Click += btnOrdenarEdadAscendente_Click;
            // 
            // btnOrdenarApellidosAscendente
            // 
            btnOrdenarApellidosAscendente.BackColor = Color.FromArgb(255, 224, 192);
            btnOrdenarApellidosAscendente.Location = new Point(910, 121);
            btnOrdenarApellidosAscendente.Name = "btnOrdenarApellidosAscendente";
            btnOrdenarApellidosAscendente.Size = new Size(88, 55);
            btnOrdenarApellidosAscendente.TabIndex = 6;
            btnOrdenarApellidosAscendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosAscendente.UseVisualStyleBackColor = false;
            btnOrdenarApellidosAscendente.Click += btnOrdenarApellidosAscendente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(910, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Ascendente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(910, 212);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Descendente";
            // 
            // btnOrdenarEdadDescendente
            // 
            btnOrdenarEdadDescendente.BackColor = Color.FromArgb(255, 192, 128);
            btnOrdenarEdadDescendente.Location = new Point(910, 247);
            btnOrdenarEdadDescendente.Name = "btnOrdenarEdadDescendente";
            btnOrdenarEdadDescendente.Size = new Size(88, 59);
            btnOrdenarEdadDescendente.TabIndex = 9;
            btnOrdenarEdadDescendente.Text = "Ordenar por Edad";
            btnOrdenarEdadDescendente.UseVisualStyleBackColor = false;
            btnOrdenarEdadDescendente.Click += btnOrdenarEdadDescendente_Click;
            // 
            // btnOrdenarApellidosDescendente
            // 
            btnOrdenarApellidosDescendente.BackColor = Color.FromArgb(255, 224, 192);
            btnOrdenarApellidosDescendente.Location = new Point(910, 328);
            btnOrdenarApellidosDescendente.Name = "btnOrdenarApellidosDescendente";
            btnOrdenarApellidosDescendente.Size = new Size(88, 63);
            btnOrdenarApellidosDescendente.TabIndex = 10;
            btnOrdenarApellidosDescendente.Text = "Ordenar por Apellido";
            btnOrdenarApellidosDescendente.UseVisualStyleBackColor = false;
            btnOrdenarApellidosDescendente.Click += btnOrdenarApellidosDescendente_Click;
            // 
            // btnSerealizar
            // 
            btnSerealizar.BackColor = SystemColors.InactiveCaption;
            btnSerealizar.Location = new Point(57, 43);
            btnSerealizar.Name = "btnSerealizar";
            btnSerealizar.Size = new Size(98, 68);
            btnSerealizar.TabIndex = 11;
            btnSerealizar.Text = "Serealizar jugador";
            btnSerealizar.UseVisualStyleBackColor = false;
            btnSerealizar.Click += btnSerealizar_Click;
            // 
            // btnDeserealizar
            // 
            btnDeserealizar.BackColor = SystemColors.InactiveCaption;
            btnDeserealizar.Location = new Point(57, 144);
            btnDeserealizar.Name = "btnDeserealizar";
            btnDeserealizar.Size = new Size(98, 68);
            btnDeserealizar.TabIndex = 15;
            btnDeserealizar.Text = "Deserealizar jugador";
            btnDeserealizar.UseVisualStyleBackColor = false;
            btnDeserealizar.Click += btnDeserealizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSkyBlue;
            groupBox1.Controls.Add(btnDeserealizar);
            groupBox1.Controls.Add(btnSerealizar);
            groupBox1.Location = new Point(174, 413);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 255);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serializacion XML";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Highlight;
            groupBox2.Controls.Add(btnEliminarBBDD);
            groupBox2.Controls.Add(btnModificarBBDD);
            groupBox2.Controls.Add(btnAgregarBBDD);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(517, 413);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 294);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Base de Datos";
            // 
            // btnEliminarBBDD
            // 
            btnEliminarBBDD.BackColor = SystemColors.ActiveBorder;
            btnEliminarBBDD.Location = new Point(23, 127);
            btnEliminarBBDD.Name = "btnEliminarBBDD";
            btnEliminarBBDD.Size = new Size(95, 63);
            btnEliminarBBDD.TabIndex = 18;
            btnEliminarBBDD.Text = "Eliminar Jugador";
            btnEliminarBBDD.UseVisualStyleBackColor = false;
            btnEliminarBBDD.MouseHover += btnEliminarBBDD_MouseHover;
            // 
            // btnModificarBBDD
            // 
            btnModificarBBDD.BackColor = SystemColors.ActiveBorder;
            btnModificarBBDD.Location = new Point(130, 69);
            btnModificarBBDD.Name = "btnModificarBBDD";
            btnModificarBBDD.Size = new Size(95, 68);
            btnModificarBBDD.TabIndex = 1;
            btnModificarBBDD.Text = "Modificar Jugador";
            btnModificarBBDD.UseVisualStyleBackColor = false;
            // 
            // btnAgregarBBDD
            // 
            btnAgregarBBDD.BackColor = SystemColors.ActiveBorder;
            btnAgregarBBDD.Location = new Point(23, 22);
            btnAgregarBBDD.Name = "btnAgregarBBDD";
            btnAgregarBBDD.Size = new Size(95, 68);
            btnAgregarBBDD.TabIndex = 0;
            btnAgregarBBDD.Text = "Guardar Jugador";
            btnAgregarBBDD.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.IndianRed;
            groupBox3.Controls.Add(btnObtenerBBDD);
            groupBox3.Controls.Add(rdbVoleibolistas);
            groupBox3.Controls.Add(rdbFutbolistas);
            groupBox3.Controls.Add(rdbBasquetbolistas);
            groupBox3.Location = new Point(6, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 80);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Traer lista ";
            // 
            // btnObtenerBBDD
            // 
            btnObtenerBBDD.BackColor = Color.RosyBrown;
            btnObtenerBBDD.Location = new Point(17, 27);
            btnObtenerBBDD.Name = "btnObtenerBBDD";
            btnObtenerBBDD.Size = new Size(75, 45);
            btnObtenerBBDD.TabIndex = 18;
            btnObtenerBBDD.Text = "Obtener";
            btnObtenerBBDD.UseVisualStyleBackColor = false;
            // 
            // rdbVoleibolistas
            // 
            rdbVoleibolistas.AutoSize = true;
            rdbVoleibolistas.Location = new Point(141, 55);
            rdbVoleibolistas.Name = "rdbVoleibolistas";
            rdbVoleibolistas.Size = new Size(90, 19);
            rdbVoleibolistas.TabIndex = 3;
            rdbVoleibolistas.TabStop = true;
            rdbVoleibolistas.Text = "Voleibolistas";
            rdbVoleibolistas.UseVisualStyleBackColor = true;
            // 
            // rdbFutbolistas
            // 
            rdbFutbolistas.AutoSize = true;
            rdbFutbolistas.Location = new Point(149, 22);
            rdbFutbolistas.Name = "rdbFutbolistas";
            rdbFutbolistas.Size = new Size(82, 19);
            rdbFutbolistas.TabIndex = 4;
            rdbFutbolistas.TabStop = true;
            rdbFutbolistas.Text = "Futbolistas";
            rdbFutbolistas.UseVisualStyleBackColor = true;
            // 
            // rdbBasquetbolistas
            // 
            rdbBasquetbolistas.AutoSize = true;
            rdbBasquetbolistas.Location = new Point(124, 39);
            rdbBasquetbolistas.Name = "rdbBasquetbolistas";
            rdbBasquetbolistas.Size = new Size(107, 19);
            rdbBasquetbolistas.TabIndex = 2;
            rdbBasquetbolistas.TabStop = true;
            rdbBasquetbolistas.Text = "Basquetbolistas";
            rdbBasquetbolistas.UseVisualStyleBackColor = true;
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1058, 719);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnOrdenarApellidosDescendente);
            Controls.Add(btnOrdenarEdadDescendente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOrdenarApellidosAscendente);
            Controls.Add(btnOrdenarEdadAscendente);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstEquipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCrud";
            Text = "FormCrud";
            Load += FormCrud_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEquipo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregarEquipo;
        private Button btnOrdenarEdadAscendente;
        private Button btnOrdenarApellidosAscendente;
        private Label label1;
        private Label label2;
        private Button btnOrdenarEdadDescendente;
        private Button btnOrdenarApellidosDescendente;
        private Button btnSerealizar;
        private Button btnDeserealizar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnModificarBBDD;
        private Button btnAgregarBBDD;
        private GroupBox groupBox3;
        private Button btnObtenerBBDD;
        private RadioButton rdbVoleibolistas;
        private RadioButton rdbFutbolistas;
        private RadioButton rdbBasquetbolistas;
        private Button btnEliminarBBDD;
    }
}