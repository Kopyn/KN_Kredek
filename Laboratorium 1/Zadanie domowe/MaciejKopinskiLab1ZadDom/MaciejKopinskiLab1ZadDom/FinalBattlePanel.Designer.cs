
namespace MaciejKopinskiLab1ZadDom
{
    partial class FinalBattlePanel
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonTryFinalBattle = new System.Windows.Forms.Button();
            this.toolTipFinalBattle = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonTryFinalBattle
            // 
            this.buttonTryFinalBattle.Location = new System.Drawing.Point(400, 273);
            this.buttonTryFinalBattle.Name = "buttonTryFinalBattle";
            this.buttonTryFinalBattle.Size = new System.Drawing.Size(76, 38);
            this.buttonTryFinalBattle.TabIndex = 1;
            this.buttonTryFinalBattle.Text = "Podejmij wyzwanie";
            this.buttonTryFinalBattle.UseVisualStyleBackColor = true;
            this.buttonTryFinalBattle.Click += new System.EventHandler(this.buttonTryFinalBattle_Click);
            this.buttonTryFinalBattle.MouseHover += new System.EventHandler(this.buttonTryFinalBattle_MouseHover);
            // 
            // FinalBattlePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.BattlePanel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.buttonTryFinalBattle);
            this.DoubleBuffered = true;
            this.Name = "FinalBattlePanel";
            this.Size = new System.Drawing.Size(873, 590);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTryFinalBattle;
        private System.Windows.Forms.ToolTip toolTipFinalBattle;
    }
}
