
namespace MaciejKopinskiLab1ZadDom
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonFinalBattle = new System.Windows.Forms.Button();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonCharacter = new System.Windows.Forms.Button();
            this.characterPanel1 = new MaciejKopinskiLab1ZadDom.CharacterPanel();
            this.shopPanel1 = new MaciejKopinskiLab1ZadDom.ShopPanel();
            this.finalBattlePanel1 = new MaciejKopinskiLab1ZadDom.FinalBattlePanel();
            this.timerResourcesIncome = new System.Windows.Forms.Timer(this.components);
            this.battlePanel1 = new MaciejKopinskiLab1ZadDom.BattlePanel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonStartGame);
            this.panelMenu.Controls.Add(this.buttonFinalBattle);
            this.panelMenu.Controls.Add(this.buttonMatch);
            this.panelMenu.Controls.Add(this.buttonShop);
            this.panelMenu.Controls.Add(this.buttonCharacter);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 590);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(49, 113);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(113, 36);
            this.buttonStartGame.TabIndex = 6;
            this.buttonStartGame.Text = "Rozpocznij grę";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonFinalBattle
            // 
            this.buttonFinalBattle.Enabled = false;
            this.buttonFinalBattle.Location = new System.Drawing.Point(49, 401);
            this.buttonFinalBattle.Name = "buttonFinalBattle";
            this.buttonFinalBattle.Size = new System.Drawing.Size(113, 36);
            this.buttonFinalBattle.TabIndex = 5;
            this.buttonFinalBattle.Text = "Mecz z nauczycielem";
            this.buttonFinalBattle.UseVisualStyleBackColor = true;
            this.buttonFinalBattle.Click += new System.EventHandler(this.buttonFinalBattle_Click);
            // 
            // buttonMatch
            // 
            this.buttonMatch.Enabled = false;
            this.buttonMatch.Location = new System.Drawing.Point(49, 329);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(113, 36);
            this.buttonMatch.TabIndex = 4;
            this.buttonMatch.Text = "Szybki mecz";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.Enabled = false;
            this.buttonShop.Location = new System.Drawing.Point(49, 257);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(113, 36);
            this.buttonShop.TabIndex = 3;
            this.buttonShop.Text = "Sklep";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonCharacter
            // 
            this.buttonCharacter.Enabled = false;
            this.buttonCharacter.Location = new System.Drawing.Point(49, 185);
            this.buttonCharacter.Name = "buttonCharacter";
            this.buttonCharacter.Size = new System.Drawing.Size(113, 36);
            this.buttonCharacter.TabIndex = 2;
            this.buttonCharacter.Text = "Rozwój postaci";
            this.buttonCharacter.UseVisualStyleBackColor = true;
            this.buttonCharacter.Click += new System.EventHandler(this.buttonCharacter_Click);
            // 
            // characterPanel1
            // 
            this.characterPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("characterPanel1.BackgroundImage")));
            this.characterPanel1.Location = new System.Drawing.Point(196, 0);
            this.characterPanel1.Name = "characterPanel1";
            this.characterPanel1.Size = new System.Drawing.Size(873, 590);
            this.characterPanel1.TabIndex = 2;
            // 
            // shopPanel1
            // 
            this.shopPanel1.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.FinalShop1;
            this.shopPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shopPanel1.Location = new System.Drawing.Point(196, 0);
            this.shopPanel1.Name = "shopPanel1";
            this.shopPanel1.Size = new System.Drawing.Size(873, 590);
            this.shopPanel1.TabIndex = 3;
            // 
            // finalBattlePanel1
            // 
            this.finalBattlePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalBattlePanel1.BackgroundImage")));
            this.finalBattlePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalBattlePanel1.Location = new System.Drawing.Point(196, 0);
            this.finalBattlePanel1.Name = "finalBattlePanel1";
            this.finalBattlePanel1.Size = new System.Drawing.Size(873, 590);
            this.finalBattlePanel1.TabIndex = 5;
            // 
            // timerResourcesIncome
            // 
            this.timerResourcesIncome.Tick += new System.EventHandler(this.timerResourcesIncome_Tick);
            // 
            // battlePanel1
            // 
            this.battlePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.battlePanel1.Location = new System.Drawing.Point(196, 0);
            this.battlePanel1.Name = "battlePanel1";
            this.battlePanel1.Size = new System.Drawing.Size(873, 590);
            this.battlePanel1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.StartPanel11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 590);
            this.Controls.Add(this.battlePanel1);
            this.Controls.Add(this.finalBattlePanel1);
            this.Controls.Add(this.shopPanel1);
            this.Controls.Add(this.characterPanel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping-Pong Master";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonCharacter;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonFinalBattle;
        private System.Windows.Forms.Button buttonMatch;
        private CharacterPanel characterPanel1;
        private ShopPanel shopPanel1;
        private FinalBattlePanel finalBattlePanel1;
        private System.Windows.Forms.Timer timerResourcesIncome;
        private BattlePanel battlePanel1;
    }
}

