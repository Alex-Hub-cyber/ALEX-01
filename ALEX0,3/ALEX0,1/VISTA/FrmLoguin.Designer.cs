
namespace ALEX0_1
{
    partial class FrmLoguin
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
            this.LblUSER = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblPASSWORDD = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUSER
            // 
            this.LblUSER.AutoSize = true;
            this.LblUSER.BackColor = System.Drawing.SystemColors.Control;
            this.LblUSER.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUSER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUSER.Location = new System.Drawing.Point(60, 47);
            this.LblUSER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUSER.Name = "LblUSER";
            this.LblUSER.Size = new System.Drawing.Size(38, 16);
            this.LblUSER.TabIndex = 0;
            this.LblUSER.Text = "USER";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(64, 94);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(244, 22);
            this.TxtUser.TabIndex = 1;
            // 
            // LblPASSWORDD
            // 
            this.LblPASSWORDD.AutoSize = true;
            this.LblPASSWORDD.BackColor = System.Drawing.SystemColors.Control;
            this.LblPASSWORDD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPASSWORDD.Location = new System.Drawing.Point(60, 164);
            this.LblPASSWORDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPASSWORDD.Name = "LblPASSWORDD";
            this.LblPASSWORDD.Size = new System.Drawing.Size(73, 16);
            this.LblPASSWORDD.TabIndex = 2;
            this.LblPASSWORDD.Text = "PASSWORD";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(64, 204);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '#';
            this.TxtPass.Size = new System.Drawing.Size(244, 22);
            this.TxtPass.TabIndex = 3;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEnter.Location = new System.Drawing.Point(64, 281);
            this.BtnEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(100, 28);
            this.BtnEnter.TabIndex = 4;
            this.BtnEnter.Text = "ENTER";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancel.Location = new System.Drawing.Point(209, 281);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmLoguin
            // 
            this.AcceptButton = this.BtnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(372, 347);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LblPASSWORDD);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblUSER);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUSER;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LblPASSWORDD;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnCancel;
    }
}

