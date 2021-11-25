
namespace MaciejKopińskiLab1
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonColorSecond = new System.Windows.Forms.Button();
            this.buttonColorThird = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.textBoxMultiply = new System.Windows.Forms.TextBox();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(137, 42);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Zmień kolor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColorSecond
            // 
            this.buttonColorSecond.Location = new System.Drawing.Point(13, 61);
            this.buttonColorSecond.Name = "buttonColorSecond";
            this.buttonColorSecond.Size = new System.Drawing.Size(137, 42);
            this.buttonColorSecond.TabIndex = 1;
            this.buttonColorSecond.Text = "Zmień kolor trzeciego przycisku";
            this.buttonColorSecond.UseVisualStyleBackColor = true;
            this.buttonColorSecond.Click += new System.EventHandler(this.buttonColorClickThirdButton);
            // 
            // buttonColorThird
            // 
            this.buttonColorThird.Location = new System.Drawing.Point(13, 110);
            this.buttonColorThird.Name = "buttonColorThird";
            this.buttonColorThird.Size = new System.Drawing.Size(137, 42);
            this.buttonColorThird.TabIndex = 2;
            this.buttonColorThird.Text = "Zmień kolor drugiego przycisku";
            this.buttonColorThird.UseVisualStyleBackColor = true;
            this.buttonColorThird.Click += new System.EventHandler(this.buttonColorClickSecondButton);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 42);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(155, 171);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(135, 20);
            this.textBoxAdd.TabIndex = 4;
            this.textBoxAdd.Text = "1";
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(13, 208);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(137, 42);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "Pomnóż";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // textBoxMultiply
            // 
            this.textBoxMultiply.Location = new System.Drawing.Point(156, 220);
            this.textBoxMultiply.Name = "textBoxMultiply";
            this.textBoxMultiply.Size = new System.Drawing.Size(134, 20);
            this.textBoxMultiply.TabIndex = 6;
            this.textBoxMultiply.Text = "1";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 257);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(137, 42);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(13, 306);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(136, 44);
            this.buttonNewWindow.TabIndex = 8;
            this.buttonNewWindow.Text = "Nowe Okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMultiply);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonColorThird);
            this.Controls.Add(this.buttonColorSecond);
            this.Controls.Add(this.buttonColor);
            this.Name = "FormMain";
            this.Text = "Maciej Kopiński - program laboratorium 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonColorSecond;
        private System.Windows.Forms.Button buttonColorThird;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.TextBox textBoxMultiply;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

