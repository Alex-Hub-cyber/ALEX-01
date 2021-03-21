
using System;

namespace ALEX0_1.VISTA
{
    partial class FrmUsuarios
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombree = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.LblNombree = new System.Windows.Forms.Label();
            this.LblApellidoo = new System.Windows.Forms.Label();
            this.LblEdadd = new System.Windows.Forms.Label();
            this.LblContra = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.dtgListaUsuarios = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnGuardar.Location = new System.Drawing.Point(167, 376);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(103, 88);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(466, 20);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtNombree
            // 
            this.TxtNombree.Location = new System.Drawing.Point(103, 46);
            this.TxtNombree.Name = "TxtNombree";
            this.TxtNombree.Size = new System.Drawing.Size(466, 20);
            this.TxtNombree.TabIndex = 2;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(103, 131);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(466, 20);
            this.TxtEdad.TabIndex = 3;
            // 
            // TxtContra
            // 
            this.TxtContra.Location = new System.Drawing.Point(103, 177);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '#';
            this.TxtContra.Size = new System.Drawing.Size(466, 20);
            this.TxtContra.TabIndex = 4;
            // 
            // LblNombree
            // 
            this.LblNombree.AutoSize = true;
            this.LblNombree.Location = new System.Drawing.Point(28, 53);
            this.LblNombree.Name = "LblNombree";
            this.LblNombree.Size = new System.Drawing.Size(50, 13);
            this.LblNombree.TabIndex = 5;
            this.LblNombree.Text = "Nombre :";
            // 
            // LblApellidoo
            // 
            this.LblApellidoo.AutoSize = true;
            this.LblApellidoo.Location = new System.Drawing.Point(28, 95);
            this.LblApellidoo.Name = "LblApellidoo";
            this.LblApellidoo.Size = new System.Drawing.Size(50, 13);
            this.LblApellidoo.TabIndex = 6;
            this.LblApellidoo.Text = "Apellido :";
            // 
            // LblEdadd
            // 
            this.LblEdadd.AutoSize = true;
            this.LblEdadd.Location = new System.Drawing.Point(28, 131);
            this.LblEdadd.Name = "LblEdadd";
            this.LblEdadd.Size = new System.Drawing.Size(38, 13);
            this.LblEdadd.TabIndex = 7;
            this.LblEdadd.Text = "Edad :";
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Location = new System.Drawing.Point(28, 184);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(67, 13);
            this.LblContra.TabIndex = 8;
            this.LblContra.Text = "Contraseña :";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnBorrar.Location = new System.Drawing.Point(303, 376);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 9;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(28, 13);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(22, 13);
            this.LblID.TabIndex = 10;
            this.LblID.Text = "Id :";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(103, 6);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(466, 20);
            this.TxtId.TabIndex = 11;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnActualizar.Location = new System.Drawing.Point(430, 376);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dtgListaUsuarios
            // 
            this.dtgListaUsuarios.AllowUserToAddRows = false;
            this.dtgListaUsuarios.AllowUserToDeleteRows = false;
            this.dtgListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgListaUsuarios.Location = new System.Drawing.Point(103, 209);
            this.dtgListaUsuarios.Name = "dtgListaUsuarios";
            this.dtgListaUsuarios.ReadOnly = true;
            this.dtgListaUsuarios.Size = new System.Drawing.Size(466, 150);
            this.dtgListaUsuarios.TabIndex = 13;
            this.dtgListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaUsuarios_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 411);
            this.Controls.Add(this.dtgListaUsuarios);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.LblContra);
            this.Controls.Add(this.LblEdadd);
            this.Controls.Add(this.LblApellidoo);
            this.Controls.Add(this.LblNombree);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombree);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombree;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Label LblNombree;
        private System.Windows.Forms.Label LblApellidoo;
        private System.Windows.Forms.Label LblEdadd;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView dtgListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}