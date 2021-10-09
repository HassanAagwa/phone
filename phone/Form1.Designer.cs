namespace phone
{
    partial class Form1
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
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_serch = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(258, 120);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(48, 16);
            this.lbl_phone.TabIndex = 14;
            this.lbl_phone.Text = "phone";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(258, 76);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 16);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(279, 35);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 16);
            this.lbl_ID.TabIndex = 12;
            this.lbl_ID.Text = "ID";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(30, 187);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 37);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_serch
            // 
            this.btn_serch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serch.Location = new System.Drawing.Point(129, 187);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(77, 37);
            this.btn_serch.TabIndex = 10;
            this.btn_serch.Text = "serch";
            this.btn_serch.UseVisualStyleBackColor = true;
            this.btn_serch.Click += new System.EventHandler(this.Btn_serch_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(222, 187);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 37);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(48, 117);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(168, 23);
            this.txt_phone.TabIndex = 15;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(48, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(168, 23);
            this.txt_name.TabIndex = 16;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(106, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(67, 23);
            this.txt_id.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(336, 249);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_serch);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_serch;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
    }
}

