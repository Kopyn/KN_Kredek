
namespace MaciejKopinskiLab1ZadDom
{
    partial class FormFinalBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinalBattle));
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.labelEndGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Location = new System.Drawing.Point(242, 253);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(75, 23);
            this.buttonEndGame.TabIndex = 0;
            this.buttonEndGame.Text = "OK";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // labelEndGame
            // 
            this.labelEndGame.AutoSize = true;
            this.labelEndGame.BackColor = System.Drawing.Color.Transparent;
            this.labelEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEndGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEndGame.Location = new System.Drawing.Point(22, 113);
            this.labelEndGame.Name = "labelEndGame";
            this.labelEndGame.Size = new System.Drawing.Size(497, 48);
            this.labelEndGame.TabIndex = 1;
            this.labelEndGame.Text = "Udało Ci się! \nPokonałeś wuefistę i zostałeś mistrzem ping-ponga.";
            this.labelEndGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFinalBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.finalFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 309);
            this.Controls.Add(this.labelEndGame);
            this.Controls.Add(this.buttonEndGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFinalBattle";
            this.Text = "FormFinalBattle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Label labelEndGame;
    }
}