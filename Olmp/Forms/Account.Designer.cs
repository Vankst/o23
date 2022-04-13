namespace Olmp
{
    partial class Account
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
            this.panellLogo = new System.Windows.Forms.Panel();
            this.lbl_hi = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_addapp = new System.Windows.Forms.Button();
            this.btn_applist = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.lbl_hi);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(220, 0);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(580, 449);
            this.panellLogo.TabIndex = 7;
            // 
            // lbl_hi
            // 
            this.lbl_hi.AutoSize = true;
            this.lbl_hi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_hi.Location = new System.Drawing.Point(15, 31);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(79, 29);
            this.lbl_hi.TabIndex = 0;
            this.lbl_hi.Text = "label1";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_exit);
            this.panelMenu.Controls.Add(this.btn_addapp);
            this.panelMenu.Controls.Add(this.btn_applist);
            this.panelMenu.Controls.Add(this.btn_main);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 449);
            this.panelMenu.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Montserrat", 8F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 260);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(220, 60);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Выйти";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_addapp
            // 
            this.btn_addapp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addapp.FlatAppearance.BorderSize = 0;
            this.btn_addapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addapp.Font = new System.Drawing.Font("Montserrat", 8F);
            this.btn_addapp.ForeColor = System.Drawing.Color.White;
            this.btn_addapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addapp.Location = new System.Drawing.Point(0, 200);
            this.btn_addapp.Name = "btn_addapp";
            this.btn_addapp.Size = new System.Drawing.Size(220, 60);
            this.btn_addapp.TabIndex = 5;
            this.btn_addapp.Text = "Добавить приложение";
            this.btn_addapp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addapp.UseVisualStyleBackColor = true;
            this.btn_addapp.Click += new System.EventHandler(this.btn_addapp_Click);
            // 
            // btn_applist
            // 
            this.btn_applist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_applist.FlatAppearance.BorderSize = 0;
            this.btn_applist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_applist.Font = new System.Drawing.Font("Montserrat", 8F);
            this.btn_applist.ForeColor = System.Drawing.Color.White;
            this.btn_applist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applist.Location = new System.Drawing.Point(0, 140);
            this.btn_applist.Name = "btn_applist";
            this.btn_applist.Size = new System.Drawing.Size(220, 60);
            this.btn_applist.TabIndex = 4;
            this.btn_applist.Text = "Список приложений";
            this.btn_applist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_applist.UseVisualStyleBackColor = true;
            this.btn_applist.Click += new System.EventHandler(this.btn_applist_Click);
            // 
            // btn_main
            // 
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Font = new System.Drawing.Font("Montserrat", 8F);
            this.btn_main.ForeColor = System.Drawing.Color.White;
            this.btn_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main.Location = new System.Drawing.Point(0, 80);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(220, 60);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "На главную";
            this.btn_main.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panellLogo.ResumeLayout(false);
            this.panellLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_applist;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbl_hi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addapp;
    }
}