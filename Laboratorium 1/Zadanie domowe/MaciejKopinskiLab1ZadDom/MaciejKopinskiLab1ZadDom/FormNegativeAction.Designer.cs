
namespace MaciejKopinskiLab1ZadDom
{
    partial class FormNegativeAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNegativeAction));
            this.labelNegativeAction = new System.Windows.Forms.Label();
            this.buttonCloseNegativeActionForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNegativeAction
            // 
            this.labelNegativeAction.AutoSize = true;
            this.labelNegativeAction.BackColor = System.Drawing.Color.Transparent;
            this.labelNegativeAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNegativeAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNegativeAction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNegativeAction.Location = new System.Drawing.Point(19, 9);
            this.labelNegativeAction.Name = "labelNegativeAction";
            this.labelNegativeAction.Size = new System.Drawing.Size(485, 98);
            this.labelNegativeAction.TabIndex = 0;
            this.labelNegativeAction.Text = "Uczeń pochodzenia azjatyckiego \nwyzwał Cie do meczu o \npieniądze i przegrałeś, tr" +
    "acisz połowę pieniędzy!\nZdobądź przynajmniej 100 siły, aby temu zapobiec.";
            this.labelNegativeAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCloseNegativeActionForm
            // 
            this.buttonCloseNegativeActionForm.Location = new System.Drawing.Point(220, 153);
            this.buttonCloseNegativeActionForm.Name = "buttonCloseNegativeActionForm";
            this.buttonCloseNegativeActionForm.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseNegativeActionForm.TabIndex = 1;
            this.buttonCloseNegativeActionForm.Text = "OK";
            this.buttonCloseNegativeActionForm.UseVisualStyleBackColor = true;
            this.buttonCloseNegativeActionForm.Click += new System.EventHandler(this.buttonCloseNegativeActionForm_Click);
            // 
            // FormNegativeAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.OtherPlayer1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 188);
            this.Controls.Add(this.buttonCloseNegativeActionForm);
            this.Controls.Add(this.labelNegativeAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNegativeAction";
            this.Text = "FormNegativeAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNegativeAction;
        private System.Windows.Forms.Button buttonCloseNegativeActionForm;
    }
}