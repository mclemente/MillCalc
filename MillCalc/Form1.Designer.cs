namespace MillCalc
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.calculateButton = new System.Windows.Forms.Button();
			this.playerHPLabel = new System.Windows.Forms.Label();
			this.opponentHPLabel = new System.Windows.Forms.Label();
			this.playerArmorLabel = new System.Windows.Forms.Label();
			this.opponentInfoLabel = new System.Windows.Forms.Label();
			this.PlayerInfoLabel = new System.Windows.Forms.Label();
			this.playerHPUpDown = new System.Windows.Forms.NumericUpDown();
			this.playerArmorUpDown = new System.Windows.Forms.NumericUpDown();
			this.playerDeckUpDown = new System.Windows.Forms.NumericUpDown();
			this.playerDeckLabel = new System.Windows.Forms.Label();
			this.opponentHPUpDown = new System.Windows.Forms.NumericUpDown();
			this.playerFatigueCheckBox = new System.Windows.Forms.CheckBox();
			this.opponentArmorUpDown = new System.Windows.Forms.NumericUpDown();
			this.opponentArmorLabel = new System.Windows.Forms.Label();
			this.opponentDeckLabel = new System.Windows.Forms.Label();
			this.opponentDeckUpDown = new System.Windows.Forms.NumericUpDown();
			this.playerFatigueDamageLabel = new System.Windows.Forms.Label();
			this.playerFatigueDamageUpDown = new System.Windows.Forms.NumericUpDown();
			this.opponentFatigueDamageUpDown = new System.Windows.Forms.NumericUpDown();
			this.opponentFatigueDamageLabel = new System.Windows.Forms.Label();
			this.opponentFatigueCheckBox = new System.Windows.Forms.CheckBox();
			this.playerCardsDrawLabel = new System.Windows.Forms.Label();
			this.playerCardsDrawUpDown = new System.Windows.Forms.NumericUpDown();
			this.resultBox = new System.Windows.Forms.TextBox();
			this.opponentCardsDrawLabel = new System.Windows.Forms.Label();
			this.opponentCardsDrawUpDown = new System.Windows.Forms.NumericUpDown();
			this.mirrorDraw = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.playerHPUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerArmorUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerDeckUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentHPUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentArmorUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentDeckUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerFatigueDamageUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentFatigueDamageUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCardsDrawUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentCardsDrawUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(73, 416);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(75, 23);
			this.calculateButton.TabIndex = 0;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// playerHPLabel
			// 
			this.playerHPLabel.AutoSize = true;
			this.playerHPLabel.Location = new System.Drawing.Point(14, 52);
			this.playerHPLabel.Name = "playerHPLabel";
			this.playerHPLabel.Size = new System.Drawing.Size(22, 13);
			this.playerHPLabel.TabIndex = 3;
			this.playerHPLabel.Text = "HP";
			// 
			// opponentHPLabel
			// 
			this.opponentHPLabel.AutoSize = true;
			this.opponentHPLabel.Location = new System.Drawing.Point(14, 263);
			this.opponentHPLabel.Name = "opponentHPLabel";
			this.opponentHPLabel.Size = new System.Drawing.Size(22, 13);
			this.opponentHPLabel.TabIndex = 4;
			this.opponentHPLabel.Text = "HP";
			// 
			// playerArmorLabel
			// 
			this.playerArmorLabel.AutoSize = true;
			this.playerArmorLabel.Location = new System.Drawing.Point(14, 70);
			this.playerArmorLabel.Name = "playerArmorLabel";
			this.playerArmorLabel.Size = new System.Drawing.Size(34, 13);
			this.playerArmorLabel.TabIndex = 6;
			this.playerArmorLabel.Text = "Armor";
			// 
			// opponentInfoLabel
			// 
			this.opponentInfoLabel.AutoSize = true;
			this.opponentInfoLabel.Location = new System.Drawing.Point(73, 229);
			this.opponentInfoLabel.Name = "opponentInfoLabel";
			this.opponentInfoLabel.Size = new System.Drawing.Size(75, 13);
			this.opponentInfoLabel.TabIndex = 8;
			this.opponentInfoLabel.Text = "Opponent Info";
			// 
			// PlayerInfoLabel
			// 
			this.PlayerInfoLabel.AutoSize = true;
			this.PlayerInfoLabel.Location = new System.Drawing.Point(73, 28);
			this.PlayerInfoLabel.Name = "PlayerInfoLabel";
			this.PlayerInfoLabel.Size = new System.Drawing.Size(50, 13);
			this.PlayerInfoLabel.TabIndex = 9;
			this.PlayerInfoLabel.Text = "Your Info";
			// 
			// playerHPUpDown
			// 
			this.playerHPUpDown.Location = new System.Drawing.Point(99, 50);
			this.playerHPUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.playerHPUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.playerHPUpDown.Name = "playerHPUpDown";
			this.playerHPUpDown.Size = new System.Drawing.Size(52, 20);
			this.playerHPUpDown.TabIndex = 10;
			this.playerHPUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// playerArmorUpDown
			// 
			this.playerArmorUpDown.Location = new System.Drawing.Point(99, 68);
			this.playerArmorUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.playerArmorUpDown.Name = "playerArmorUpDown";
			this.playerArmorUpDown.Size = new System.Drawing.Size(52, 20);
			this.playerArmorUpDown.TabIndex = 11;
			// 
			// playerDeckUpDown
			// 
			this.playerDeckUpDown.Location = new System.Drawing.Point(99, 85);
			this.playerDeckUpDown.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
			this.playerDeckUpDown.Name = "playerDeckUpDown";
			this.playerDeckUpDown.Size = new System.Drawing.Size(52, 20);
			this.playerDeckUpDown.TabIndex = 12;
			this.playerDeckUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// playerDeckLabel
			// 
			this.playerDeckLabel.AutoSize = true;
			this.playerDeckLabel.Location = new System.Drawing.Point(14, 87);
			this.playerDeckLabel.Name = "playerDeckLabel";
			this.playerDeckLabel.Size = new System.Drawing.Size(74, 13);
			this.playerDeckLabel.TabIndex = 13;
			this.playerDeckLabel.Text = "Cards in Deck";
			// 
			// opponentHPUpDown
			// 
			this.opponentHPUpDown.Location = new System.Drawing.Point(99, 261);
			this.opponentHPUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.opponentHPUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.opponentHPUpDown.Name = "opponentHPUpDown";
			this.opponentHPUpDown.Size = new System.Drawing.Size(52, 20);
			this.opponentHPUpDown.TabIndex = 14;
			this.opponentHPUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// playerFatigueCheckBox
			// 
			this.playerFatigueCheckBox.AutoSize = true;
			this.playerFatigueCheckBox.Location = new System.Drawing.Point(17, 141);
			this.playerFatigueCheckBox.Name = "playerFatigueCheckBox";
			this.playerFatigueCheckBox.Size = new System.Drawing.Size(102, 17);
			this.playerFatigueCheckBox.TabIndex = 15;
			this.playerFatigueCheckBox.Text = "Fatigue damage";
			this.toolTip1.SetToolTip(this.playerFatigueCheckBox, "Did you took any Fatigue damage?\r\nDisables Cards in Deck field.");
			this.playerFatigueCheckBox.UseVisualStyleBackColor = true;
			this.playerFatigueCheckBox.CheckedChanged += new System.EventHandler(this.playerFatigueCheckBox_CheckedChanged);
			// 
			// opponentArmorUpDown
			// 
			this.opponentArmorUpDown.Location = new System.Drawing.Point(99, 280);
			this.opponentArmorUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.opponentArmorUpDown.Name = "opponentArmorUpDown";
			this.opponentArmorUpDown.Size = new System.Drawing.Size(52, 20);
			this.opponentArmorUpDown.TabIndex = 16;
			// 
			// opponentArmorLabel
			// 
			this.opponentArmorLabel.AutoSize = true;
			this.opponentArmorLabel.Location = new System.Drawing.Point(15, 282);
			this.opponentArmorLabel.Name = "opponentArmorLabel";
			this.opponentArmorLabel.Size = new System.Drawing.Size(34, 13);
			this.opponentArmorLabel.TabIndex = 17;
			this.opponentArmorLabel.Text = "Armor";
			// 
			// opponentDeckLabel
			// 
			this.opponentDeckLabel.AutoSize = true;
			this.opponentDeckLabel.Location = new System.Drawing.Point(15, 300);
			this.opponentDeckLabel.Name = "opponentDeckLabel";
			this.opponentDeckLabel.Size = new System.Drawing.Size(74, 13);
			this.opponentDeckLabel.TabIndex = 18;
			this.opponentDeckLabel.Text = "Cards in Deck";
			// 
			// opponentDeckUpDown
			// 
			this.opponentDeckUpDown.Location = new System.Drawing.Point(99, 298);
			this.opponentDeckUpDown.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
			this.opponentDeckUpDown.Name = "opponentDeckUpDown";
			this.opponentDeckUpDown.Size = new System.Drawing.Size(52, 20);
			this.opponentDeckUpDown.TabIndex = 19;
			this.opponentDeckUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// playerFatigueDamageLabel
			// 
			this.playerFatigueDamageLabel.AutoSize = true;
			this.playerFatigueDamageLabel.Enabled = false;
			this.playerFatigueDamageLabel.Location = new System.Drawing.Point(14, 166);
			this.playerFatigueDamageLabel.Name = "playerFatigueDamageLabel";
			this.playerFatigueDamageLabel.Size = new System.Drawing.Size(108, 13);
			this.playerFatigueDamageLabel.TabIndex = 20;
			this.playerFatigueDamageLabel.Text = "Last Fatigue Damage";
			// 
			// playerFatigueDamageUpDown
			// 
			this.playerFatigueDamageUpDown.Enabled = false;
			this.playerFatigueDamageUpDown.Location = new System.Drawing.Point(128, 164);
			this.playerFatigueDamageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.playerFatigueDamageUpDown.Name = "playerFatigueDamageUpDown";
			this.playerFatigueDamageUpDown.Size = new System.Drawing.Size(41, 20);
			this.playerFatigueDamageUpDown.TabIndex = 21;
			this.playerFatigueDamageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// opponentFatigueDamageUpDown
			// 
			this.opponentFatigueDamageUpDown.Enabled = false;
			this.opponentFatigueDamageUpDown.Location = new System.Drawing.Point(128, 381);
			this.opponentFatigueDamageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.opponentFatigueDamageUpDown.Name = "opponentFatigueDamageUpDown";
			this.opponentFatigueDamageUpDown.Size = new System.Drawing.Size(41, 20);
			this.opponentFatigueDamageUpDown.TabIndex = 24;
			this.opponentFatigueDamageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// opponentFatigueDamageLabel
			// 
			this.opponentFatigueDamageLabel.AutoSize = true;
			this.opponentFatigueDamageLabel.Enabled = false;
			this.opponentFatigueDamageLabel.Location = new System.Drawing.Point(14, 383);
			this.opponentFatigueDamageLabel.Name = "opponentFatigueDamageLabel";
			this.opponentFatigueDamageLabel.Size = new System.Drawing.Size(108, 13);
			this.opponentFatigueDamageLabel.TabIndex = 23;
			this.opponentFatigueDamageLabel.Text = "Last Fatigue Damage";
			// 
			// opponentFatigueCheckBox
			// 
			this.opponentFatigueCheckBox.AutoSize = true;
			this.opponentFatigueCheckBox.Location = new System.Drawing.Point(17, 358);
			this.opponentFatigueCheckBox.Name = "opponentFatigueCheckBox";
			this.opponentFatigueCheckBox.Size = new System.Drawing.Size(102, 17);
			this.opponentFatigueCheckBox.TabIndex = 22;
			this.opponentFatigueCheckBox.Text = "Fatigue damage";
			this.toolTip1.SetToolTip(this.opponentFatigueCheckBox, "Did your opponent took any Fatigue damage?\r\nDisables Cards in Deck field.");
			this.opponentFatigueCheckBox.UseVisualStyleBackColor = true;
			this.opponentFatigueCheckBox.CheckedChanged += new System.EventHandler(this.opponentFatigueCheckBox_CheckedChanged);
			// 
			// playerCardsDrawLabel
			// 
			this.playerCardsDrawLabel.AutoSize = true;
			this.playerCardsDrawLabel.Location = new System.Drawing.Point(14, 106);
			this.playerCardsDrawLabel.Name = "playerCardsDrawLabel";
			this.playerCardsDrawLabel.Size = new System.Drawing.Size(74, 13);
			this.playerCardsDrawLabel.TabIndex = 25;
			this.playerCardsDrawLabel.Text = "Cards to Draw";
			// 
			// playerCardsDrawUpDown
			// 
			this.playerCardsDrawUpDown.Location = new System.Drawing.Point(99, 104);
			this.playerCardsDrawUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.playerCardsDrawUpDown.Name = "playerCardsDrawUpDown";
			this.playerCardsDrawUpDown.Size = new System.Drawing.Size(52, 20);
			this.playerCardsDrawUpDown.TabIndex = 26;
			this.playerCardsDrawUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.playerCardsDrawUpDown.ValueChanged += new System.EventHandler(this.playerCardsDrawUpDown_ValueChanged);
			// 
			// resultBox
			// 
			this.resultBox.Location = new System.Drawing.Point(0, 445);
			this.resultBox.Multiline = true;
			this.resultBox.Name = "resultBox";
			this.resultBox.ReadOnly = true;
			this.resultBox.ShortcutsEnabled = false;
			this.resultBox.Size = new System.Drawing.Size(214, 126);
			this.resultBox.TabIndex = 29;
			this.resultBox.Visible = false;
			// 
			// opponentCardsDrawLabel
			// 
			this.opponentCardsDrawLabel.AutoSize = true;
			this.opponentCardsDrawLabel.Location = new System.Drawing.Point(15, 319);
			this.opponentCardsDrawLabel.Name = "opponentCardsDrawLabel";
			this.opponentCardsDrawLabel.Size = new System.Drawing.Size(74, 13);
			this.opponentCardsDrawLabel.TabIndex = 27;
			this.opponentCardsDrawLabel.Text = "Cards to Draw";
			// 
			// opponentCardsDrawUpDown
			// 
			this.opponentCardsDrawUpDown.Location = new System.Drawing.Point(99, 317);
			this.opponentCardsDrawUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.opponentCardsDrawUpDown.Name = "opponentCardsDrawUpDown";
			this.opponentCardsDrawUpDown.Size = new System.Drawing.Size(52, 20);
			this.opponentCardsDrawUpDown.TabIndex = 28;
			this.opponentCardsDrawUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.opponentCardsDrawUpDown.ValueChanged += new System.EventHandler(this.opponentCardsDrawUpDown_ValueChanged);
			// 
			// mirrorDraw
			// 
			this.mirrorDraw.AutoSize = true;
			this.mirrorDraw.Location = new System.Drawing.Point(12, 8);
			this.mirrorDraw.Name = "mirrorDraw";
			this.mirrorDraw.Size = new System.Drawing.Size(80, 17);
			this.mirrorDraw.TabIndex = 30;
			this.mirrorDraw.Text = "Mirror Draw";
			this.toolTip1.SetToolTip(this.mirrorDraw, "Mirrors the Cards to Draw fields.");
			this.mirrorDraw.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AcceptButton = this.calculateButton;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(212, 572);
			this.Controls.Add(this.mirrorDraw);
			this.Controls.Add(this.resultBox);
			this.Controls.Add(this.opponentCardsDrawUpDown);
			this.Controls.Add(this.opponentCardsDrawLabel);
			this.Controls.Add(this.playerCardsDrawUpDown);
			this.Controls.Add(this.playerCardsDrawLabel);
			this.Controls.Add(this.opponentFatigueDamageUpDown);
			this.Controls.Add(this.opponentFatigueDamageLabel);
			this.Controls.Add(this.opponentFatigueCheckBox);
			this.Controls.Add(this.playerFatigueDamageUpDown);
			this.Controls.Add(this.playerFatigueDamageLabel);
			this.Controls.Add(this.opponentDeckUpDown);
			this.Controls.Add(this.opponentDeckLabel);
			this.Controls.Add(this.opponentArmorLabel);
			this.Controls.Add(this.opponentArmorUpDown);
			this.Controls.Add(this.playerFatigueCheckBox);
			this.Controls.Add(this.opponentHPUpDown);
			this.Controls.Add(this.playerDeckLabel);
			this.Controls.Add(this.playerDeckUpDown);
			this.Controls.Add(this.playerArmorUpDown);
			this.Controls.Add(this.playerHPUpDown);
			this.Controls.Add(this.PlayerInfoLabel);
			this.Controls.Add(this.opponentInfoLabel);
			this.Controls.Add(this.playerArmorLabel);
			this.Controls.Add(this.opponentHPLabel);
			this.Controls.Add(this.playerHPLabel);
			this.Controls.Add(this.calculateButton);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(228, 610);
			this.MinimumSize = new System.Drawing.Size(228, 610);
			this.Name = "Form1";
			this.Text = "Mill Calculator";
			((System.ComponentModel.ISupportInitialize)(this.playerHPUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerArmorUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerDeckUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentHPUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentArmorUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentDeckUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerFatigueDamageUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentFatigueDamageUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCardsDrawUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.opponentCardsDrawUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label playerHPLabel;
		private System.Windows.Forms.Label opponentHPLabel;
		private System.Windows.Forms.Label playerArmorLabel;
		private System.Windows.Forms.Label opponentInfoLabel;
		private System.Windows.Forms.Label PlayerInfoLabel;
		private System.Windows.Forms.NumericUpDown playerHPUpDown;
		private System.Windows.Forms.NumericUpDown playerArmorUpDown;
		private System.Windows.Forms.NumericUpDown playerDeckUpDown;
		private System.Windows.Forms.Label playerDeckLabel;
		private System.Windows.Forms.NumericUpDown opponentHPUpDown;
		private System.Windows.Forms.CheckBox playerFatigueCheckBox;
		private System.Windows.Forms.NumericUpDown opponentArmorUpDown;
		private System.Windows.Forms.Label opponentArmorLabel;
		private System.Windows.Forms.Label opponentDeckLabel;
		private System.Windows.Forms.NumericUpDown opponentDeckUpDown;
		private System.Windows.Forms.Label playerFatigueDamageLabel;
		private System.Windows.Forms.NumericUpDown playerFatigueDamageUpDown;
		private System.Windows.Forms.NumericUpDown opponentFatigueDamageUpDown;
		private System.Windows.Forms.Label opponentFatigueDamageLabel;
		private System.Windows.Forms.CheckBox opponentFatigueCheckBox;
		private System.Windows.Forms.Label playerCardsDrawLabel;
		private System.Windows.Forms.NumericUpDown playerCardsDrawUpDown;
		private System.Windows.Forms.TextBox resultBox;
		private System.Windows.Forms.Label opponentCardsDrawLabel;
		private System.Windows.Forms.NumericUpDown opponentCardsDrawUpDown;
		private System.Windows.Forms.CheckBox mirrorDraw;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

