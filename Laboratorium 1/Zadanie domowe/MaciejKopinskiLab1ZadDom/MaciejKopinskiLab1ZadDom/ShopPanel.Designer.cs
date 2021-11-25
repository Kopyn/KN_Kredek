
namespace MaciejKopinskiLab1ZadDom
{
    partial class ShopPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopPanel));
            this.buttonBuyRocket = new System.Windows.Forms.Button();
            this.labelShopName = new System.Windows.Forms.Label();
            this.buttonBuyTshirt = new System.Windows.Forms.Button();
            this.buttonBuyShorts = new System.Windows.Forms.Button();
            this.buttonBuyShoes = new System.Windows.Forms.Button();
            this.labelTennisRacket = new System.Windows.Forms.Label();
            this.labelTshirt = new System.Windows.Forms.Label();
            this.labelShorts = new System.Windows.Forms.Label();
            this.labelShoes = new System.Windows.Forms.Label();
            this.pictureBoxRacket = new System.Windows.Forms.PictureBox();
            this.pictureBoxTshirt = new System.Windows.Forms.PictureBox();
            this.pictureBoxShorts = new System.Windows.Forms.PictureBox();
            this.pictureBoxShoes = new System.Windows.Forms.PictureBox();
            this.toolTipBuyButton = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTshirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShorts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuyRocket
            // 
            this.buttonBuyRocket.Location = new System.Drawing.Point(659, 115);
            this.buttonBuyRocket.Name = "buttonBuyRocket";
            this.buttonBuyRocket.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyRocket.TabIndex = 0;
            this.buttonBuyRocket.Text = "Kup";
            this.buttonBuyRocket.UseVisualStyleBackColor = true;
            this.buttonBuyRocket.Click += new System.EventHandler(this.buttonBuyRocket_Click);
            this.buttonBuyRocket.MouseHover += new System.EventHandler(this.buttonBuyRocket_MouseHover);
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.BackColor = System.Drawing.Color.Transparent;
            this.labelShopName.Location = new System.Drawing.Point(24, 18);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(81, 13);
            this.labelShopName.TabIndex = 1;
            this.labelShopName.Text = "Sklep Sportowy";
            // 
            // buttonBuyTshirt
            // 
            this.buttonBuyTshirt.Location = new System.Drawing.Point(659, 266);
            this.buttonBuyTshirt.Name = "buttonBuyTshirt";
            this.buttonBuyTshirt.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyTshirt.TabIndex = 2;
            this.buttonBuyTshirt.Text = "Kup";
            this.buttonBuyTshirt.UseVisualStyleBackColor = true;
            this.buttonBuyTshirt.Click += new System.EventHandler(this.buttonBuyTshirt_Click);
            this.buttonBuyTshirt.MouseHover += new System.EventHandler(this.buttonBuyTshirt_MouseHover);
            // 
            // buttonBuyShorts
            // 
            this.buttonBuyShorts.Location = new System.Drawing.Point(659, 401);
            this.buttonBuyShorts.Name = "buttonBuyShorts";
            this.buttonBuyShorts.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyShorts.TabIndex = 3;
            this.buttonBuyShorts.Text = "Kup";
            this.buttonBuyShorts.UseVisualStyleBackColor = true;
            this.buttonBuyShorts.Click += new System.EventHandler(this.buttonBuyShorts_Click);
            this.buttonBuyShorts.MouseHover += new System.EventHandler(this.buttonBuyShorts_MouseHover);
            // 
            // buttonBuyShoes
            // 
            this.buttonBuyShoes.Location = new System.Drawing.Point(659, 542);
            this.buttonBuyShoes.Name = "buttonBuyShoes";
            this.buttonBuyShoes.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyShoes.TabIndex = 4;
            this.buttonBuyShoes.Text = "Kup";
            this.buttonBuyShoes.UseVisualStyleBackColor = true;
            this.buttonBuyShoes.Click += new System.EventHandler(this.buttonBuyShoes_Click);
            this.buttonBuyShoes.MouseHover += new System.EventHandler(this.buttonBuyShoes_MouseHover);
            // 
            // labelTennisRacket
            // 
            this.labelTennisRacket.AutoSize = true;
            this.labelTennisRacket.BackColor = System.Drawing.Color.Transparent;
            this.labelTennisRacket.Location = new System.Drawing.Point(746, 19);
            this.labelTennisRacket.Name = "labelTennisRacket";
            this.labelTennisRacket.Size = new System.Drawing.Size(89, 13);
            this.labelTennisRacket.TabIndex = 5;
            this.labelTennisRacket.Text = "Paletka sportowa";
            // 
            // labelTshirt
            // 
            this.labelTshirt.AutoSize = true;
            this.labelTshirt.BackColor = System.Drawing.Color.Transparent;
            this.labelTshirt.Location = new System.Drawing.Point(742, 170);
            this.labelTshirt.Name = "labelTshirt";
            this.labelTshirt.Size = new System.Drawing.Size(96, 13);
            this.labelTshirt.TabIndex = 6;
            this.labelTshirt.Text = "Koszulka sportowa";
            // 
            // labelShorts
            // 
            this.labelShorts.AutoSize = true;
            this.labelShorts.BackColor = System.Drawing.Color.Transparent;
            this.labelShorts.Location = new System.Drawing.Point(741, 305);
            this.labelShorts.Name = "labelShorts";
            this.labelShorts.Size = new System.Drawing.Size(98, 13);
            this.labelShorts.TabIndex = 7;
            this.labelShorts.Text = "Spodenki sportowe";
            // 
            // labelShoes
            // 
            this.labelShoes.AutoSize = true;
            this.labelShoes.BackColor = System.Drawing.Color.Transparent;
            this.labelShoes.Location = new System.Drawing.Point(753, 446);
            this.labelShoes.Name = "labelShoes";
            this.labelShoes.Size = new System.Drawing.Size(74, 13);
            this.labelShoes.TabIndex = 8;
            this.labelShoes.Text = "Buty sportowe";
            // 
            // pictureBoxRacket
            // 
            this.pictureBoxRacket.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRacket.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.TableTennisRacketFinal;
            this.pictureBoxRacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRacket.Location = new System.Drawing.Point(740, 35);
            this.pictureBoxRacket.Name = "pictureBoxRacket";
            this.pictureBoxRacket.Size = new System.Drawing.Size(100, 103);
            this.pictureBoxRacket.TabIndex = 9;
            this.pictureBoxRacket.TabStop = false;
            // 
            // pictureBoxTshirt
            // 
            this.pictureBoxTshirt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTshirt.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.TshirtFinal;
            this.pictureBoxTshirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTshirt.Location = new System.Drawing.Point(740, 186);
            this.pictureBoxTshirt.Name = "pictureBoxTshirt";
            this.pictureBoxTshirt.Size = new System.Drawing.Size(100, 103);
            this.pictureBoxTshirt.TabIndex = 10;
            this.pictureBoxTshirt.TabStop = false;
            // 
            // pictureBoxShorts
            // 
            this.pictureBoxShorts.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShorts.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.ShortsFinal;
            this.pictureBoxShorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxShorts.Location = new System.Drawing.Point(740, 321);
            this.pictureBoxShorts.Name = "pictureBoxShorts";
            this.pictureBoxShorts.Size = new System.Drawing.Size(100, 103);
            this.pictureBoxShorts.TabIndex = 11;
            this.pictureBoxShorts.TabStop = false;
            // 
            // pictureBoxShoes
            // 
            this.pictureBoxShoes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxShoes.BackgroundImage")));
            this.pictureBoxShoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxShoes.Location = new System.Drawing.Point(740, 462);
            this.pictureBoxShoes.Name = "pictureBoxShoes";
            this.pictureBoxShoes.Size = new System.Drawing.Size(100, 103);
            this.pictureBoxShoes.TabIndex = 12;
            this.pictureBoxShoes.TabStop = false;
            // 
            // ShopPanel
            // 
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.FinalShop1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBoxShoes);
            this.Controls.Add(this.pictureBoxShorts);
            this.Controls.Add(this.pictureBoxTshirt);
            this.Controls.Add(this.pictureBoxRacket);
            this.Controls.Add(this.labelShoes);
            this.Controls.Add(this.labelShorts);
            this.Controls.Add(this.labelTshirt);
            this.Controls.Add(this.labelTennisRacket);
            this.Controls.Add(this.buttonBuyShoes);
            this.Controls.Add(this.buttonBuyShorts);
            this.Controls.Add(this.buttonBuyTshirt);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.buttonBuyRocket);
            this.DoubleBuffered = true;
            this.Name = "ShopPanel";
            this.Size = new System.Drawing.Size(873, 590);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTshirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShorts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyRocket;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button buttonBuyTshirt;
        private System.Windows.Forms.Button buttonBuyShorts;
        private System.Windows.Forms.Button buttonBuyShoes;
        private System.Windows.Forms.Label labelTennisRacket;
        private System.Windows.Forms.Label labelTshirt;
        private System.Windows.Forms.Label labelShorts;
        private System.Windows.Forms.Label labelShoes;
        private System.Windows.Forms.PictureBox pictureBoxRacket;
        private System.Windows.Forms.PictureBox pictureBoxTshirt;
        private System.Windows.Forms.PictureBox pictureBoxShorts;
        private System.Windows.Forms.PictureBox pictureBoxShoes;
        private System.Windows.Forms.ToolTip toolTipBuyButton;
    }
}
