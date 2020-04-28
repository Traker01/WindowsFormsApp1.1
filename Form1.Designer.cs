namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BUTTON = new System.Windows.Forms.Button();
            this.CHECKBOX = new System.Windows.Forms.CheckBox();
            this.TEXTBOX = new System.Windows.Forms.TextBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BUTTON.Location = new System.Drawing.Point(59, 174);
            this.BUTTON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(171, 44);
            this.BUTTON.TabIndex = 0;
            this.BUTTON.Text = "CHANGE ME";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.CHECKBOX_CheckedChanged);
            this.BUTTON.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BUTTON_MouseClick);
            // 
            // CHECKBOX
            // 
            this.CHECKBOX.AutoSize = true;
            this.CHECKBOX.Location = new System.Drawing.Point(59, 130);
            this.CHECKBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CHECKBOX.Name = "CHECKBOX";
            this.CHECKBOX.Size = new System.Drawing.Size(147, 21);
            this.CHECKBOX.TabIndex = 1;
            this.CHECKBOX.Text = "WLACZ / WYLACZ";
            this.CHECKBOX.UseVisualStyleBackColor = true;
            this.CHECKBOX.CheckedChanged += new System.EventHandler(this.CHECKBOX_CheckedChanged);
            // 
            // TEXTBOX
            // 
            this.TEXTBOX.Location = new System.Drawing.Point(16, 71);
            this.TEXTBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TEXTBOX.Name = "TEXTBOX";
            this.TEXTBOX.Size = new System.Drawing.Size(260, 22);
            this.TEXTBOX.TabIndex = 2;
            this.TEXTBOX.TextChanged += new System.EventHandler(this.TEXTBOX_TextChanged);
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LABEL.Location = new System.Drawing.Point(67, 18);
            this.LABEL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(150, 31);
            this.LABEL.TabIndex = 3;
            this.LABEL.Text = "KWZP LAB";
            this.LABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 246);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.TEXTBOX);
            this.Controls.Add(this.CHECKBOX);
            this.Controls.Add(this.BUTTON);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.CheckBox CHECKBOX;
        private System.Windows.Forms.TextBox TEXTBOX;
        private System.Windows.Forms.Label LABEL;
    }
}

