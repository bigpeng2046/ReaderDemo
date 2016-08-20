namespace ReaderDemo
{
   partial class AForgeDemoForm
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
          this.label1 = new System.Windows.Forms.Label();
          this.cmbDevice = new System.Windows.Forms.ComboBox();
          this.pictureBox1 = new System.Windows.Forms.PictureBox();
          this.label3 = new System.Windows.Forms.Label();
          this.listBox1 = new System.Windows.Forms.ListBox();
          this.button1 = new System.Windows.Forms.Button();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(13, 13);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(41, 13);
          this.label1.TabIndex = 0;
          this.label1.Text = "Device";
          // 
          // cmbDevice
          // 
          this.cmbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cmbDevice.FormattingEnabled = true;
          this.cmbDevice.Location = new System.Drawing.Point(100, 10);
          this.cmbDevice.Name = "cmbDevice";
          this.cmbDevice.Size = new System.Drawing.Size(314, 21);
          this.cmbDevice.TabIndex = 1;
          this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
          // 
          // pictureBox1
          // 
          this.pictureBox1.Location = new System.Drawing.Point(12, 242);
          this.pictureBox1.Name = "pictureBox1";
          this.pictureBox1.Size = new System.Drawing.Size(548, 260);
          this.pictureBox1.TabIndex = 2;
          this.pictureBox1.TabStop = false;
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(13, 36);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(44, 13);
          this.label3.TabIndex = 4;
          this.label3.Text = "Content";
          // 
          // listBox1
          // 
          this.listBox1.FormattingEnabled = true;
          this.listBox1.Location = new System.Drawing.Point(100, 37);
          this.listBox1.Name = "listBox1";
          this.listBox1.Size = new System.Drawing.Size(295, 186);
          this.listBox1.TabIndex = 5;
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(476, 74);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(103, 41);
          this.button1.TabIndex = 6;
          this.button1.Text = "Clear";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // AForgeDemoForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(613, 514);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.listBox1);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.pictureBox1);
          this.Controls.Add(this.cmbDevice);
          this.Controls.Add(this.label1);
          this.Name = "AForgeDemoForm";
          this.Text = "AForgeDemo";
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cmbDevice;
       private System.Windows.Forms.PictureBox pictureBox1;
       private System.Windows.Forms.Label label3;
       private System.Windows.Forms.ListBox listBox1;
       private System.Windows.Forms.Button button1;
   }
}

