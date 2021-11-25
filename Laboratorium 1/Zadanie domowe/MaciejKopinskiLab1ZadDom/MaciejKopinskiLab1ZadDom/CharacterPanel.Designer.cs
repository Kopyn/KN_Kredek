
namespace MaciejKopinskiLab1ZadDom
{
    partial class CharacterPanel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.labelGoldAmount = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelLuck = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.buttonStrengthIncome = new System.Windows.Forms.Button();
            this.buttonConditionIncome = new System.Windows.Forms.Button();
            this.buttonLuckIncome = new System.Windows.Forms.Button();
            this.buttonDexterityIncome = new System.Windows.Forms.Button();
            this.buttonIntelligenceIncome = new System.Windows.Forms.Button();
            this.toolTipIncomeButton = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.BackColor = System.Drawing.Color.Transparent;
            this.labelNameInput.Location = new System.Drawing.Point(108, 53);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(77, 13);
            this.labelNameInput.TabIndex = 3;
            this.labelNameInput.Text = "Nazwa postaci";
            // 
            // labelGoldAmount
            // 
            this.labelGoldAmount.AutoSize = true;
            this.labelGoldAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelGoldAmount.Location = new System.Drawing.Point(30, 342);
            this.labelGoldAmount.Name = "labelGoldAmount";
            this.labelGoldAmount.Size = new System.Drawing.Size(51, 13);
            this.labelGoldAmount.TabIndex = 4;
            this.labelGoldAmount.Text = "Złoto = 0";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.BackColor = System.Drawing.Color.Transparent;
            this.labelStrength.Location = new System.Drawing.Point(30, 383);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(50, 13);
            this.labelStrength.TabIndex = 5;
            this.labelStrength.Text = "Siła = 10";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Location = new System.Drawing.Point(30, 424);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(75, 13);
            this.labelCondition.TabIndex = 6;
            this.labelCondition.Text = "Kondycja = 10";
            // 
            // labelLuck
            // 
            this.labelLuck.AutoSize = true;
            this.labelLuck.BackColor = System.Drawing.Color.Transparent;
            this.labelLuck.Location = new System.Drawing.Point(30, 465);
            this.labelLuck.Name = "labelLuck";
            this.labelLuck.Size = new System.Drawing.Size(79, 13);
            this.labelLuck.TabIndex = 7;
            this.labelLuck.Text = "Szczęście = 10";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.BackColor = System.Drawing.Color.Transparent;
            this.labelDexterity.Location = new System.Drawing.Point(30, 506);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(81, 13);
            this.labelDexterity.TabIndex = 8;
            this.labelDexterity.Text = "Zręczność = 10";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.BackColor = System.Drawing.Color.Transparent;
            this.labelIntelligence.Location = new System.Drawing.Point(30, 547);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(85, 13);
            this.labelIntelligence.TabIndex = 9;
            this.labelIntelligence.Text = "Inteligencja = 10";
            // 
            // buttonStrengthIncome
            // 
            this.buttonStrengthIncome.Location = new System.Drawing.Point(166, 373);
            this.buttonStrengthIncome.Name = "buttonStrengthIncome";
            this.buttonStrengthIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonStrengthIncome.TabIndex = 11;
            this.buttonStrengthIncome.Text = "Ulepsz";
            this.buttonStrengthIncome.UseVisualStyleBackColor = true;
            this.buttonStrengthIncome.Click += new System.EventHandler(this.buttonStrengthIncome_Click);
            this.buttonStrengthIncome.MouseHover += new System.EventHandler(this.buttonStrengthIncome_MouseHover);
            // 
            // buttonConditionIncome
            // 
            this.buttonConditionIncome.Enabled = false;
            this.buttonConditionIncome.Location = new System.Drawing.Point(166, 414);
            this.buttonConditionIncome.Name = "buttonConditionIncome";
            this.buttonConditionIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonConditionIncome.TabIndex = 13;
            this.buttonConditionIncome.Text = "Ulepsz";
            this.buttonConditionIncome.UseVisualStyleBackColor = true;
            this.buttonConditionIncome.Click += new System.EventHandler(this.buttonConditionIncome_Click);
            this.buttonConditionIncome.MouseHover += new System.EventHandler(this.buttonConditionIncome_MouseHover);
            // 
            // buttonLuckIncome
            // 
            this.buttonLuckIncome.Enabled = false;
            this.buttonLuckIncome.Location = new System.Drawing.Point(166, 455);
            this.buttonLuckIncome.Name = "buttonLuckIncome";
            this.buttonLuckIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonLuckIncome.TabIndex = 14;
            this.buttonLuckIncome.Text = "Ulepsz";
            this.buttonLuckIncome.UseVisualStyleBackColor = true;
            this.buttonLuckIncome.Click += new System.EventHandler(this.buttonLuckIncome_Click);
            this.buttonLuckIncome.MouseHover += new System.EventHandler(this.buttonLuckIncome_MouseHover);
            // 
            // buttonDexterityIncome
            // 
            this.buttonDexterityIncome.Enabled = false;
            this.buttonDexterityIncome.Location = new System.Drawing.Point(166, 496);
            this.buttonDexterityIncome.Name = "buttonDexterityIncome";
            this.buttonDexterityIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonDexterityIncome.TabIndex = 15;
            this.buttonDexterityIncome.Text = "Ulepsz";
            this.buttonDexterityIncome.UseVisualStyleBackColor = true;
            this.buttonDexterityIncome.Click += new System.EventHandler(this.buttonDexterityIncome_Click);
            this.buttonDexterityIncome.MouseHover += new System.EventHandler(this.buttonDexterityIncome_MouseHover);
            // 
            // buttonIntelligenceIncome
            // 
            this.buttonIntelligenceIncome.Enabled = false;
            this.buttonIntelligenceIncome.Location = new System.Drawing.Point(166, 537);
            this.buttonIntelligenceIncome.Name = "buttonIntelligenceIncome";
            this.buttonIntelligenceIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonIntelligenceIncome.TabIndex = 16;
            this.buttonIntelligenceIncome.Text = "Ulepsz";
            this.buttonIntelligenceIncome.UseVisualStyleBackColor = true;
            this.buttonIntelligenceIncome.Click += new System.EventHandler(this.buttonIntelligenceIncome_Click);
            this.buttonIntelligenceIncome.MouseHover += new System.EventHandler(this.buttonIntelligenceIncome_MouseHover);
            // 
            // CharacterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaciejKopinskiLab1ZadDom.Properties.Resources.CharacterPanel11;
            this.Controls.Add(this.buttonIntelligenceIncome);
            this.Controls.Add(this.buttonDexterityIncome);
            this.Controls.Add(this.buttonLuckIncome);
            this.Controls.Add(this.buttonConditionIncome);
            this.Controls.Add(this.buttonStrengthIncome);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelDexterity);
            this.Controls.Add(this.labelLuck);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelGoldAmount);
            this.Controls.Add(this.labelNameInput);
            this.Controls.Add(this.textBox1);
            this.Name = "CharacterPanel";
            this.Size = new System.Drawing.Size(873, 590);
            this.Load += new System.EventHandler(this.CharacterPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.Label labelGoldAmount;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelLuck;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Button buttonStrengthIncome;
        private System.Windows.Forms.Button buttonConditionIncome;
        private System.Windows.Forms.Button buttonLuckIncome;
        private System.Windows.Forms.Button buttonDexterityIncome;
        private System.Windows.Forms.Button buttonIntelligenceIncome;
        private System.Windows.Forms.ToolTip toolTipIncomeButton;
    }
}
