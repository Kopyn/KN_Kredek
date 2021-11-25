
namespace MaciejKopinskiLab1ZadDom
{
    partial class BattlePanel
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
            this.buttonPlayMatch = new System.Windows.Forms.Button();
            this.toolTipPlayMatch = new System.Windows.Forms.ToolTip(this.components);
            this.panelBattle = new System.Windows.Forms.Panel();
            this.labelPoints = new System.Windows.Forms.Label();
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.pictureBoxRacket = new System.Windows.Forms.PictureBox();
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.panelBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacket)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlayMatch
            // 
            this.buttonPlayMatch.Location = new System.Drawing.Point(401, 281);
            this.buttonPlayMatch.Name = "buttonPlayMatch";
            this.buttonPlayMatch.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayMatch.TabIndex = 1;
            this.buttonPlayMatch.Text = "Zagraj";
            this.buttonPlayMatch.UseVisualStyleBackColor = true;
            this.buttonPlayMatch.Click += new System.EventHandler(this.buttonPlayMatch_Click);
            this.buttonPlayMatch.MouseHover += new System.EventHandler(this.buttonPlayMatch_MouseHover);
            // 
            // panelBattle
            // 
            this.panelBattle.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.BattleHalf;
            this.panelBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBattle.Controls.Add(this.labelPoints);
            this.panelBattle.Controls.Add(this.pictureBoxBall);
            this.panelBattle.Controls.Add(this.pictureBoxRacket);
            this.panelBattle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBattle.Location = new System.Drawing.Point(0, 0);
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Size = new System.Drawing.Size(873, 590);
            this.panelBattle.TabIndex = 2;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.Transparent;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPoints.Location = new System.Drawing.Point(15, 13);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(89, 24);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "Wynik: 0";
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.ping_pong;
            this.pictureBoxBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBall.Location = new System.Drawing.Point(469, 224);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBall.TabIndex = 1;
            this.pictureBoxBall.TabStop = false;
            // 
            // pictureBoxRacket
            // 
            this.pictureBoxRacket.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRacket.Location = new System.Drawing.Point(330, 555);
            this.pictureBoxRacket.Name = "pictureBoxRacket";
            this.pictureBoxRacket.Size = new System.Drawing.Size(200, 20);
            this.pictureBoxRacket.TabIndex = 0;
            this.pictureBoxRacket.TabStop = false;
            // 
            // timerBattle
            // 
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // BattlePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.BattlePanel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panelBattle);
            this.Controls.Add(this.buttonPlayMatch);
            this.DoubleBuffered = true;
            this.Name = "BattlePanel";
            this.Size = new System.Drawing.Size(873, 590);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.panelBattle.ResumeLayout(false);
            this.panelBattle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPlayMatch;
        private System.Windows.Forms.ToolTip toolTipPlayMatch;
        private System.Windows.Forms.Panel panelBattle;
        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.PictureBox pictureBoxRacket;
        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.Label labelPoints;
    }
}
