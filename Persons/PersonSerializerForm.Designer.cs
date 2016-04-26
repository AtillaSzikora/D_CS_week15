namespace PersonSerializer {
	partial class PersonSerializationForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.txtName = new System.Windows.Forms.TextBox ();
			this.txtPhone = new System.Windows.Forms.TextBox ();
			this.txtAddress = new System.Windows.Forms.TextBox ();
			this.lblName = new System.Windows.Forms.Label ();
			this.lblAddress = new System.Windows.Forms.Label ();
			this.lblPhone = new System.Windows.Forms.Label ();
			this.btnPrevious = new System.Windows.Forms.Button ();
			this.btnNext = new System.Windows.Forms.Button ();
			this.btnSave = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point (63, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size (237, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point (63, 64);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size (237, 20);
			this.txtPhone.TabIndex = 1;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point (63, 38);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size (237, 20);
			this.txtAddress.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point (12, 15);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size (35, 13);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Name";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point (12, 41);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size (45, 13);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point (12, 67);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size (38, 13);
			this.lblPhone.TabIndex = 5;
			this.lblPhone.Text = "Phone";
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point (63, 90);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size (75, 23);
			this.btnPrevious.TabIndex = 6;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point (144, 90);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size (75, 23);
			this.btnNext.TabIndex = 7;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point (225, 90);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size (75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// PersonsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (313, 128);
			this.Controls.Add (this.btnSave);
			this.Controls.Add (this.btnNext);
			this.Controls.Add (this.btnPrevious);
			this.Controls.Add (this.lblPhone);
			this.Controls.Add (this.lblAddress);
			this.Controls.Add (this.lblName);
			this.Controls.Add (this.txtAddress);
			this.Controls.Add (this.txtPhone);
			this.Controls.Add (this.txtName);
			this.Name = "PersonsForm";
			this.Text = "Persons";
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnSave;
	}
}

