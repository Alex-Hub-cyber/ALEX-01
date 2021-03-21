
namespace ALEX0_1.VISTA
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.matematicasToolStripMenuItem,
            this.conexiónesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem
            // 
            this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem.Name = "cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem";
            this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem.Text = " CLICK AQUI PARA MAS INFORMACIÓN";
            this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem.Click += new System.EventHandler(this.cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            this.arreglosToolStripMenuItem.Click += new System.EventHandler(this.arreglosToolStripMenuItem_Click);
            // 
            // matematicasToolStripMenuItem
            // 
            this.matematicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem});
            this.matematicasToolStripMenuItem.Name = "matematicasToolStripMenuItem";
            this.matematicasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.matematicasToolStripMenuItem.Text = "Matemáticas";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // conexiónesToolStripMenuItem
            // 
            this.conexiónesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crudToolStripMenuItem});
            this.conexiónesToolStripMenuItem.Name = "conexiónesToolStripMenuItem";
            this.conexiónesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.conexiónesToolStripMenuItem.Text = "Conexiones BD";
            this.conexiónesToolStripMenuItem.Click += new System.EventHandler(this.conexiónesToolStripMenuItem_Click);
            // 
            // crudToolStripMenuItem
            // 
            this.crudToolStripMenuItem.Name = "crudToolStripMenuItem";
            this.crudToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crudToolStripMenuItem.Text = "Crud";
            this.crudToolStripMenuItem.Click += new System.EventHandler(this.crudToolStripMenuItem_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(447, 10);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(0, 13);
            this.Lbl1.TabIndex = 3;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 293);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLICKAQUIPARAMASINFORMACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crudToolStripMenuItem;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
    }
}