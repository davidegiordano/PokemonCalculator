using PokémonCalculator.controller;
using PokémonCalculator.model.pokémon;
using PokémonCalculator.persistence;

namespace PokémonCalculator.view
{
    public class MainForm : Form
    {
        private Label pokémon1MovesLabel;
        private Button pokémon1Move1Button;
        private Button pokémon1Move2Button;
        private Button pokémon1Move3Button;
        private Button pokémon1Move4Button;
        private TextBox calcTextBox;
        private Button pokémon2Move4Button;
        private Button pokémon2Move3Button;
        private Button pokémon2Move2Button;
        private Button pokémon2Move1Button;
        private Label pokémon2MovesLabel;
        private System.ComponentModel.IContainer components;
        private GroupBox pokémon1GroupBox;
        private ComboBox pokémon1ComboBox;
        private GroupBox pokémon2GroupBox;
        private ComboBox pokémon2ComboBox;
        private Label pokémon1LevelLabel;
        private TextBox pokémon1Type2TextBox;
        private TextBox pokémon1Type1TextBox;
        private Label pokémon1TypeLabel;
        private Label pokémon2LevelLabel;
        private TextBox pokémon2Type2TextBox;
        private TextBox pokémon2Type1TextBox;
        private Label pokémon2TypeLabel;
        private Label pokémon1SpeLabel;
        private Label pokémon1SpDefLabel;
        private Label pokémon1SpAtkLabel;
        private Label pokémon1DefLabel;
        private Label pokémon1AtkLabel;
        private Label pokémon1HPLabel;
        private Label pokémon1IVLabel;
        private Label pokémon1EVLabel;
        private Label pokémon1BaseLabel;
        private TextBox pokémon1BaseSpAtkTextBox;
        private TextBox pokémon1BaseSpDefTextBox;
        private TextBox pokémon1BaseSpeTextBox;
        private TextBox pokémon1BaseDefTextBox;
        private TextBox pokémon1BaseAtkTextBox;
        private TextBox pokémon1BaseHPTextBox;
        private ComboBox pokémon1NatureComboBox;
        private Label pokémon1NatureLabel;
        private ComboBox pokémon1Move4ComboBox;
        private ComboBox pokémon1Move3ComboBox;
        private ComboBox pokémon1Move2ComboBox;
        private ComboBox pokémon1Move1ComboBox;
        private TextBox pokémon1Move4CategoryTextBox;
        private TextBox pokémon1Move3CategoryTextBox;
        private TextBox pokémon1Move2CategoryTextBox;
        private TextBox pokémon1Move1CategoryTextBox;
        private TextBox pokémon1Move4TypeTextBox;
        private TextBox pokémon1Move3TypeTextBox;
        private TextBox pokémon1Move2TypeTextBox;
        private TextBox pokémon1Move1TypeTextBox;
        private TextBox pokémon1Move4PowerTextBox;
        private TextBox pokémon1Move3PowerTextBox;
        private TextBox pokémon1Move2PowerTextBox;
        private TextBox pokémon1Move1PowerTextBox;
        private TextBox pokémon2Move4CategoryTextBox;
        private TextBox pokémon2Move3CategoryTextBox;
        private TextBox pokémon2Move2CategoryTextBox;
        private TextBox pokémon2Move1CategoryTextBox;
        private TextBox pokémon2Move4TypeTextBox;
        private TextBox pokémon2Move3TypeTextBox;
        private TextBox pokémon2Move2TypeTextBox;
        private TextBox pokémon2Move1TypeTextBox;
        private TextBox pokémon2Move4PowerTextBox;
        private TextBox pokémon2Move3PowerTextBox;
        private TextBox pokémon2Move2PowerTextBox;
        private TextBox pokémon2Move1PowerTextBox;
        private ComboBox pokémon2Move4ComboBox;
        private ComboBox pokémon2Move3ComboBox;
        private ComboBox pokémon2Move2ComboBox;
        private ComboBox pokémon2Move1ComboBox;
        private ComboBox pokémon2NatureComboBox;
        private Label pokémon2NatureLabel;
        private TextBox pokémon2BaseSpAtkTextBox;
        private TextBox pokémon2BaseSpDefTextBox;
        private TextBox pokémon2BaseSpeTextBox;
        private TextBox pokémon2BaseDefTextBox;
        private TextBox pokémon2BaseAtkTextBox;
        private TextBox pokémon2BaseHPTextBox;
        private Label pokémon2IVLabel;
        private Label pokémon2EVLabel;
        private Label pokémon2BaseLabel;
        private Label pokémon2SpeLabel;
        private Label pokémon2SpDefLabel;
        private Label pokémon2SpAtkLabel;
        private Label pokémon2DefLabel;
        private Label pokémon2AtkLabel;
        private Label pokémon2HPLabel;
        private Label pokémon1SpeStatLabel;
        private Label pokémon1SpDefStatLabel;
        private Label pokémon1SpAtkStatLabel;
        private Label pokémon1DefStatLabel;
        private Label pokémon1AtkStatLabel;
        private Label pokémon1HPStatLabel;
        private Label pokémon2SpeStatLabel;
        private Label pokémon2SpDefStatLabel;
        private Label pokémon2SpAtkStatLabel;
        private Label pokémon2DefStatLabel;
        private Label pokémon2AtkStatLabel;
        private Label pokémon2HPStatLabel;
        private NumericUpDown pokémon1EVSpeNumericUpDown;
        private NumericUpDown pokémon1EVHPNumericUpDown;
        private NumericUpDown pokémon1EVSpDefNumericUpDown;
        private NumericUpDown pokémon1EVSpAtkNumericUpDown;
        private NumericUpDown pokémon1EVDefNumericUpDown;
        private NumericUpDown pokémon1EVAtkNumericUpDown;
        private NumericUpDown pokémon2EVSpeNumericUpDown;
        private NumericUpDown pokémon2EVHPNumericUpDown;
        private NumericUpDown pokémon2EVSpDefNumericUpDown;
        private NumericUpDown pokémon2EVSpAtkNumericUpDown;
        private NumericUpDown pokémon2EVDefNumericUpDown;
        private NumericUpDown pokémon2EVAtkNumericUpDown;
        private NumericUpDown pokémon1IVSpeNumericUpDown;
        private NumericUpDown pokémon1LevelNumericUpDown;
        private NumericUpDown pokémon1IVSpDefNumericUpDown;
        private NumericUpDown pokémon1IVHPNumericUpDown;
        private NumericUpDown pokémon1IVSpAtkNumericUpDown;
        private NumericUpDown pokémon1IVDefNumericUpDown;
        private NumericUpDown pokémon1IVAtkNumericUpDown;
        private NumericUpDown pokémon2LevelNumericUpDown;
        private NumericUpDown pokémon2IVSpeNumericUpDown;
        private NumericUpDown pokémon2IVSpDefNumericUpDown;
        private NumericUpDown pokémon2IVHPNumericUpDown;
        private NumericUpDown pokémon2IVSpAtkNumericUpDown;
        private NumericUpDown pokémon2IVDefNumericUpDown;
        private NumericUpDown pokémon2IVAtkNumericUpDown;

        private Pokémon pokémon1;
        private Pokémon pokémon2;
        private BindingSource parseMovesBindingSource3;
        private BindingSource parseMovesBindingSource2;
        private BindingSource parseMovesBindingSource1;
        private BindingSource parseMovesBindingSource;
        private BindingSource listNaturesBindingSource;
        private BindingSource parsePokémonBindingSource;
        private BindingSource parseMovesBindingSource7;
        private BindingSource parseMovesBindingSource6;
        private BindingSource parseMovesBindingSource5;
        private BindingSource parseMovesBindingSource4;
        private BindingSource listNaturesBindingSource1;
        private BindingSource parsePokémonBindingSource1;
        private Calculator calculatorController;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pokémon1MovesLabel = new System.Windows.Forms.Label();
            this.pokémon1Move1Button = new System.Windows.Forms.Button();
            this.pokémon1Move2Button = new System.Windows.Forms.Button();
            this.pokémon1Move3Button = new System.Windows.Forms.Button();
            this.pokémon1Move4Button = new System.Windows.Forms.Button();
            this.calcTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move4Button = new System.Windows.Forms.Button();
            this.pokémon2Move3Button = new System.Windows.Forms.Button();
            this.pokémon2Move2Button = new System.Windows.Forms.Button();
            this.pokémon2Move1Button = new System.Windows.Forms.Button();
            this.pokémon2MovesLabel = new System.Windows.Forms.Label();
            this.pokémon1GroupBox = new System.Windows.Forms.GroupBox();
            this.pokémon1IVSpeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1LevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1IVSpDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1IVHPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1IVSpAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1EVSpeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1IVDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1EVHPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1IVAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1EVSpDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1SpeStatLabel = new System.Windows.Forms.Label();
            this.pokémon1EVSpAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1SpDefStatLabel = new System.Windows.Forms.Label();
            this.pokémon1EVDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1SpAtkStatLabel = new System.Windows.Forms.Label();
            this.pokémon1EVAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon1DefStatLabel = new System.Windows.Forms.Label();
            this.pokémon1AtkStatLabel = new System.Windows.Forms.Label();
            this.pokémon1HPStatLabel = new System.Windows.Forms.Label();
            this.pokémon1Move4CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move3CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move2CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move1CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move4TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move3TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move2TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move1TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move4PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move3PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move2PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move1PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Move4ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon1Move3ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon1Move2ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon1Move1ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon1NatureComboBox = new System.Windows.Forms.ComboBox();
            this.listNaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon1NatureLabel = new System.Windows.Forms.Label();
            this.pokémon1BaseSpAtkTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1BaseSpDefTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1BaseSpeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1BaseDefTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1BaseAtkTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1BaseHPTextBox = new System.Windows.Forms.TextBox();
            this.pokémon1IVLabel = new System.Windows.Forms.Label();
            this.pokémon1EVLabel = new System.Windows.Forms.Label();
            this.pokémon1BaseLabel = new System.Windows.Forms.Label();
            this.pokémon1SpeLabel = new System.Windows.Forms.Label();
            this.pokémon1SpDefLabel = new System.Windows.Forms.Label();
            this.pokémon1SpAtkLabel = new System.Windows.Forms.Label();
            this.pokémon1DefLabel = new System.Windows.Forms.Label();
            this.pokémon1AtkLabel = new System.Windows.Forms.Label();
            this.pokémon1HPLabel = new System.Windows.Forms.Label();
            this.pokémon1LevelLabel = new System.Windows.Forms.Label();
            this.pokémon1Type2TextBox = new System.Windows.Forms.TextBox();
            this.pokémon1Type1TextBox = new System.Windows.Forms.TextBox();
            this.pokémon1TypeLabel = new System.Windows.Forms.Label();
            this.pokémon1ComboBox = new System.Windows.Forms.ComboBox();
            this.parsePokémonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon2GroupBox = new System.Windows.Forms.GroupBox();
            this.pokémon2LevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2IVSpeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2EVSpeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2IVSpDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2SpeStatLabel = new System.Windows.Forms.Label();
            this.pokémon2IVHPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2IVSpAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2EVHPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2IVDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2EVSpDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2IVAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2SpDefStatLabel = new System.Windows.Forms.Label();
            this.pokémon2EVSpAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2SpAtkStatLabel = new System.Windows.Forms.Label();
            this.pokémon2EVDefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2DefStatLabel = new System.Windows.Forms.Label();
            this.pokémon2EVAtkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pokémon2AtkStatLabel = new System.Windows.Forms.Label();
            this.pokémon2HPStatLabel = new System.Windows.Forms.Label();
            this.pokémon2Move4CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move3CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move2CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move1CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move4TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move3TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move2TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move1TypeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move4PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move3PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move2PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move1PowerTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Move4ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon2Move3ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon2Move2ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon2Move1ComboBox = new System.Windows.Forms.ComboBox();
            this.parseMovesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon2NatureComboBox = new System.Windows.Forms.ComboBox();
            this.listNaturesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon2NatureLabel = new System.Windows.Forms.Label();
            this.pokémon2BaseSpAtkTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2BaseSpDefTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2BaseSpeTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2BaseDefTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2BaseAtkTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2BaseHPTextBox = new System.Windows.Forms.TextBox();
            this.pokémon2IVLabel = new System.Windows.Forms.Label();
            this.pokémon2EVLabel = new System.Windows.Forms.Label();
            this.pokémon2BaseLabel = new System.Windows.Forms.Label();
            this.pokémon2SpeLabel = new System.Windows.Forms.Label();
            this.pokémon2SpDefLabel = new System.Windows.Forms.Label();
            this.pokémon2SpAtkLabel = new System.Windows.Forms.Label();
            this.pokémon2DefLabel = new System.Windows.Forms.Label();
            this.pokémon2AtkLabel = new System.Windows.Forms.Label();
            this.pokémon2HPLabel = new System.Windows.Forms.Label();
            this.pokémon2LevelLabel = new System.Windows.Forms.Label();
            this.pokémon2Type2TextBox = new System.Windows.Forms.TextBox();
            this.pokémon2Type1TextBox = new System.Windows.Forms.TextBox();
            this.pokémon2TypeLabel = new System.Windows.Forms.Label();
            this.pokémon2ComboBox = new System.Windows.Forms.ComboBox();
            this.parsePokémonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pokémon1GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVSpeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1LevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVSpDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVHPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVSpAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVSpeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVHPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVSpDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVSpAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listNaturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsePokémonBindingSource)).BeginInit();
            this.pokémon2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2LevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVSpeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVSpeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVSpDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVHPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVSpAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVHPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVSpDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVSpAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVDefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVAtkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listNaturesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsePokémonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pokémon1MovesLabel
            // 
            this.pokémon1MovesLabel.AutoSize = true;
            this.pokémon1MovesLabel.Location = new System.Drawing.Point(12, 9);
            this.pokémon1MovesLabel.Name = "pokémon1MovesLabel";
            this.pokémon1MovesLabel.Size = new System.Drawing.Size(53, 15);
            this.pokémon1MovesLabel.TabIndex = 1;
            this.pokémon1MovesLabel.Text = "\'s Moves";
            // 
            // pokémon1Move1Button
            // 
            this.pokémon1Move1Button.Location = new System.Drawing.Point(12, 27);
            this.pokémon1Move1Button.Name = "pokémon1Move1Button";
            this.pokémon1Move1Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon1Move1Button.TabIndex = 2;
            this.pokémon1Move1Button.Text = "button1";
            this.pokémon1Move1Button.UseVisualStyleBackColor = true;
            this.pokémon1Move1Button.Click += new System.EventHandler(this.pokémon1Move1Button_Click);
            // 
            // pokémon1Move2Button
            // 
            this.pokémon1Move2Button.Location = new System.Drawing.Point(12, 56);
            this.pokémon1Move2Button.Name = "pokémon1Move2Button";
            this.pokémon1Move2Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon1Move2Button.TabIndex = 3;
            this.pokémon1Move2Button.Text = "button2";
            this.pokémon1Move2Button.UseVisualStyleBackColor = true;
            this.pokémon1Move2Button.Click += new System.EventHandler(this.pokémon1Move2Button_Click);
            // 
            // pokémon1Move3Button
            // 
            this.pokémon1Move3Button.Location = new System.Drawing.Point(12, 85);
            this.pokémon1Move3Button.Name = "pokémon1Move3Button";
            this.pokémon1Move3Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon1Move3Button.TabIndex = 4;
            this.pokémon1Move3Button.Text = "button3";
            this.pokémon1Move3Button.UseVisualStyleBackColor = true;
            this.pokémon1Move3Button.Click += new System.EventHandler(this.pokémon1Move3Button_Click);
            // 
            // pokémon1Move4Button
            // 
            this.pokémon1Move4Button.Location = new System.Drawing.Point(12, 114);
            this.pokémon1Move4Button.Name = "pokémon1Move4Button";
            this.pokémon1Move4Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon1Move4Button.TabIndex = 5;
            this.pokémon1Move4Button.Text = "button4";
            this.pokémon1Move4Button.UseVisualStyleBackColor = true;
            this.pokémon1Move4Button.Click += new System.EventHandler(this.pokémon1Move4Button_Click);
            // 
            // calcTextBox
            // 
            this.calcTextBox.Location = new System.Drawing.Point(12, 180);
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.Size = new System.Drawing.Size(942, 23);
            this.calcTextBox.TabIndex = 6;
            // 
            // pokémon2Move4Button
            // 
            this.pokémon2Move4Button.Location = new System.Drawing.Point(639, 114);
            this.pokémon2Move4Button.Name = "pokémon2Move4Button";
            this.pokémon2Move4Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon2Move4Button.TabIndex = 11;
            this.pokémon2Move4Button.Text = "button5";
            this.pokémon2Move4Button.UseVisualStyleBackColor = true;
            this.pokémon2Move4Button.Click += new System.EventHandler(this.pokémon2Move4Button_Click);
            // 
            // pokémon2Move3Button
            // 
            this.pokémon2Move3Button.Location = new System.Drawing.Point(639, 85);
            this.pokémon2Move3Button.Name = "pokémon2Move3Button";
            this.pokémon2Move3Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon2Move3Button.TabIndex = 10;
            this.pokémon2Move3Button.Text = "button6";
            this.pokémon2Move3Button.UseVisualStyleBackColor = true;
            this.pokémon2Move3Button.Click += new System.EventHandler(this.pokémon2Move3Button_Click);
            // 
            // pokémon2Move2Button
            // 
            this.pokémon2Move2Button.Location = new System.Drawing.Point(639, 56);
            this.pokémon2Move2Button.Name = "pokémon2Move2Button";
            this.pokémon2Move2Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon2Move2Button.TabIndex = 9;
            this.pokémon2Move2Button.Text = "button7";
            this.pokémon2Move2Button.UseVisualStyleBackColor = true;
            this.pokémon2Move2Button.Click += new System.EventHandler(this.pokémon2Move2Button_Click);
            // 
            // pokémon2Move1Button
            // 
            this.pokémon2Move1Button.Location = new System.Drawing.Point(639, 27);
            this.pokémon2Move1Button.Name = "pokémon2Move1Button";
            this.pokémon2Move1Button.Size = new System.Drawing.Size(75, 23);
            this.pokémon2Move1Button.TabIndex = 8;
            this.pokémon2Move1Button.Text = "button8";
            this.pokémon2Move1Button.UseVisualStyleBackColor = true;
            this.pokémon2Move1Button.Click += new System.EventHandler(this.pokémon2Move1Button_Click);
            // 
            // pokémon2MovesLabel
            // 
            this.pokémon2MovesLabel.AutoSize = true;
            this.pokémon2MovesLabel.Location = new System.Drawing.Point(639, 9);
            this.pokémon2MovesLabel.Name = "pokémon2MovesLabel";
            this.pokémon2MovesLabel.Size = new System.Drawing.Size(53, 15);
            this.pokémon2MovesLabel.TabIndex = 7;
            this.pokémon2MovesLabel.Text = "\'s Moves";
            // 
            // pokémon1GroupBox
            // 
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVSpeNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1LevelNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVSpDefNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVHPNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVSpAtkNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVSpeNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVDefNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVHPNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVAtkNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVSpDefNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1SpeStatLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVSpAtkNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1SpDefStatLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVDefNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1SpAtkStatLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVAtkNumericUpDown);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1DefStatLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1AtkStatLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1HPStatLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move4CategoryTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move3CategoryTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move2CategoryTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move1CategoryTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move4TypeTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move3TypeTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move2TypeTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move1TypeTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move4PowerTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move3PowerTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move2PowerTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move1PowerTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move4ComboBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move3ComboBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move2ComboBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Move1ComboBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1NatureComboBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1NatureLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseSpAtkTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseSpDefTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseSpeTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseDefTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseAtkTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseHPTextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1IVLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1EVLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1BaseLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1SpeLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1SpDefLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1SpAtkLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1DefLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1AtkLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1HPLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1LevelLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Type2TextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1Type1TextBox);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1TypeLabel);
            this.pokémon1GroupBox.Controls.Add(this.pokémon1ComboBox);
            this.pokémon1GroupBox.Location = new System.Drawing.Point(12, 209);
            this.pokémon1GroupBox.Name = "pokémon1GroupBox";
            this.pokémon1GroupBox.Size = new System.Drawing.Size(387, 501);
            this.pokémon1GroupBox.TabIndex = 12;
            this.pokémon1GroupBox.TabStop = false;
            this.pokémon1GroupBox.Text = "Pokémon 1";
            // 
            // pokémon1IVSpeNumericUpDown
            // 
            this.pokémon1IVSpeNumericUpDown.Location = new System.Drawing.Point(102, 285);
            this.pokémon1IVSpeNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon1IVSpeNumericUpDown.Name = "pokémon1IVSpeNumericUpDown";
            this.pokémon1IVSpeNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon1IVSpeNumericUpDown.TabIndex = 20;
            this.pokémon1IVSpeNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1IVSpeNumericUpDown_ValueChanged);
            // 
            // pokémon1LevelNumericUpDown
            // 
            this.pokémon1LevelNumericUpDown.Location = new System.Drawing.Point(46, 90);
            this.pokémon1LevelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pokémon1LevelNumericUpDown.Name = "pokémon1LevelNumericUpDown";
            this.pokémon1LevelNumericUpDown.Size = new System.Drawing.Size(53, 23);
            this.pokémon1LevelNumericUpDown.TabIndex = 21;
            this.pokémon1LevelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pokémon1LevelNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1LevelNumericUpDown_ValueChanged);
            // 
            // pokémon1IVSpDefNumericUpDown
            // 
            this.pokémon1IVSpDefNumericUpDown.Location = new System.Drawing.Point(102, 256);
            this.pokémon1IVSpDefNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon1IVSpDefNumericUpDown.Name = "pokémon1IVSpDefNumericUpDown";
            this.pokémon1IVSpDefNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon1IVSpDefNumericUpDown.TabIndex = 19;
            this.pokémon1IVSpDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1IVSpDefNumericUpDown_ValueChanged);
            // 
            // pokémon1IVHPNumericUpDown
            // 
            this.pokémon1IVHPNumericUpDown.Location = new System.Drawing.Point(102, 140);
            this.pokémon1IVHPNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon1IVHPNumericUpDown.Name = "pokémon1IVHPNumericUpDown";
            this.pokémon1IVHPNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon1IVHPNumericUpDown.TabIndex = 15;
            this.pokémon1IVHPNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1IVHPNumericUpDown_ValueChanged);
            // 
            // pokémon1IVSpAtkNumericUpDown
            // 
            this.pokémon1IVSpAtkNumericUpDown.Location = new System.Drawing.Point(102, 227);
            this.pokémon1IVSpAtkNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon1IVSpAtkNumericUpDown.Name = "pokémon1IVSpAtkNumericUpDown";
            this.pokémon1IVSpAtkNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon1IVSpAtkNumericUpDown.TabIndex = 18;
            this.pokémon1IVSpAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1IVSpAtkNumericUpDown_ValueChanged);
            // 
            // pokémon1EVSpeNumericUpDown
            // 
            this.pokémon1EVSpeNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon1EVSpeNumericUpDown.Location = new System.Drawing.Point(146, 285);
            this.pokémon1EVSpeNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon1EVSpeNumericUpDown.Name = "pokémon1EVSpeNumericUpDown";
            this.pokémon1EVSpeNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon1EVSpeNumericUpDown.TabIndex = 19;
            this.pokémon1EVSpeNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1EVSpeNumericUpDown_ValueChanged);
            // 
            // pokémon1IVDefNumericUpDown
            // 
            this.pokémon1IVDefNumericUpDown.Location = new System.Drawing.Point(102, 198);
            this.pokémon1IVDefNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon1IVDefNumericUpDown.Name = "pokémon1IVDefNumericUpDown";
            this.pokémon1IVDefNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon1IVDefNumericUpDown.TabIndex = 17;
            this.pokémon1IVDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1IVDefNumericUpDown_ValueChanged);
            // 
            // pokémon1EVHPNumericUpDown
            // 
            this.pokémon1EVHPNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon1EVHPNumericUpDown.Location = new System.Drawing.Point(146, 140);
            this.pokémon1EVHPNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon1EVHPNumericUpDown.Name = "pokémon1EVHPNumericUpDown";
            this.pokémon1EVHPNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon1EVHPNumericUpDown.TabIndex = 14;
            this.pokémon1EVHPNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1EVHPNumericUpDown_ValueChanged);
            // 
            // pokémon1IVAtkNumericUpDown
            // 
            this.pokémon1IVAtkNumericUpDown.Location = new System.Drawing.Point(102, 169);
            this.pokémon1IVAtkNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon1IVAtkNumericUpDown.Name = "pokémon1IVAtkNumericUpDown";
            this.pokémon1IVAtkNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon1IVAtkNumericUpDown.TabIndex = 16;
            this.pokémon1IVAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1IVAtkNumericUpDown_ValueChanged);
            // 
            // pokémon1EVSpDefNumericUpDown
            // 
            this.pokémon1EVSpDefNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon1EVSpDefNumericUpDown.Location = new System.Drawing.Point(146, 256);
            this.pokémon1EVSpDefNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon1EVSpDefNumericUpDown.Name = "pokémon1EVSpDefNumericUpDown";
            this.pokémon1EVSpDefNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon1EVSpDefNumericUpDown.TabIndex = 18;
            this.pokémon1EVSpDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1EVSpDefNumericUpDown_ValueChanged);
            // 
            // pokémon1SpeStatLabel
            // 
            this.pokémon1SpeStatLabel.AutoSize = true;
            this.pokémon1SpeStatLabel.Location = new System.Drawing.Point(199, 288);
            this.pokémon1SpeStatLabel.Name = "pokémon1SpeStatLabel";
            this.pokémon1SpeStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon1SpeStatLabel.TabIndex = 57;
            this.pokémon1SpeStatLabel.Text = "label6";
            // 
            // pokémon1EVSpAtkNumericUpDown
            // 
            this.pokémon1EVSpAtkNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon1EVSpAtkNumericUpDown.Location = new System.Drawing.Point(146, 227);
            this.pokémon1EVSpAtkNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon1EVSpAtkNumericUpDown.Name = "pokémon1EVSpAtkNumericUpDown";
            this.pokémon1EVSpAtkNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon1EVSpAtkNumericUpDown.TabIndex = 17;
            this.pokémon1EVSpAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1EVSpAtkNumericUpDown_ValueChanged);
            // 
            // pokémon1SpDefStatLabel
            // 
            this.pokémon1SpDefStatLabel.AutoSize = true;
            this.pokémon1SpDefStatLabel.Location = new System.Drawing.Point(199, 259);
            this.pokémon1SpDefStatLabel.Name = "pokémon1SpDefStatLabel";
            this.pokémon1SpDefStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon1SpDefStatLabel.TabIndex = 56;
            this.pokémon1SpDefStatLabel.Text = "label5";
            // 
            // pokémon1EVDefNumericUpDown
            // 
            this.pokémon1EVDefNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon1EVDefNumericUpDown.Location = new System.Drawing.Point(146, 198);
            this.pokémon1EVDefNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon1EVDefNumericUpDown.Name = "pokémon1EVDefNumericUpDown";
            this.pokémon1EVDefNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon1EVDefNumericUpDown.TabIndex = 16;
            this.pokémon1EVDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1EVDefNumericUpDown_ValueChanged);
            // 
            // pokémon1SpAtkStatLabel
            // 
            this.pokémon1SpAtkStatLabel.AutoSize = true;
            this.pokémon1SpAtkStatLabel.Location = new System.Drawing.Point(199, 230);
            this.pokémon1SpAtkStatLabel.Name = "pokémon1SpAtkStatLabel";
            this.pokémon1SpAtkStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon1SpAtkStatLabel.TabIndex = 55;
            this.pokémon1SpAtkStatLabel.Text = "label4";
            // 
            // pokémon1EVAtkNumericUpDown
            // 
            this.pokémon1EVAtkNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon1EVAtkNumericUpDown.Location = new System.Drawing.Point(146, 169);
            this.pokémon1EVAtkNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon1EVAtkNumericUpDown.Name = "pokémon1EVAtkNumericUpDown";
            this.pokémon1EVAtkNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon1EVAtkNumericUpDown.TabIndex = 15;
            this.pokémon1EVAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon1EVAtkNumericUpDown_ValueChanged);
            // 
            // pokémon1DefStatLabel
            // 
            this.pokémon1DefStatLabel.AutoSize = true;
            this.pokémon1DefStatLabel.Location = new System.Drawing.Point(199, 201);
            this.pokémon1DefStatLabel.Name = "pokémon1DefStatLabel";
            this.pokémon1DefStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon1DefStatLabel.TabIndex = 54;
            this.pokémon1DefStatLabel.Text = "label3";
            // 
            // pokémon1AtkStatLabel
            // 
            this.pokémon1AtkStatLabel.AutoSize = true;
            this.pokémon1AtkStatLabel.Location = new System.Drawing.Point(199, 172);
            this.pokémon1AtkStatLabel.Name = "pokémon1AtkStatLabel";
            this.pokémon1AtkStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon1AtkStatLabel.TabIndex = 53;
            this.pokémon1AtkStatLabel.Text = "label2";
            // 
            // pokémon1HPStatLabel
            // 
            this.pokémon1HPStatLabel.AutoSize = true;
            this.pokémon1HPStatLabel.Location = new System.Drawing.Point(199, 143);
            this.pokémon1HPStatLabel.Name = "pokémon1HPStatLabel";
            this.pokémon1HPStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon1HPStatLabel.TabIndex = 52;
            this.pokémon1HPStatLabel.Text = "label1";
            // 
            // pokémon1Move4CategoryTextBox
            // 
            this.pokémon1Move4CategoryTextBox.Location = new System.Drawing.Point(257, 458);
            this.pokémon1Move4CategoryTextBox.Name = "pokémon1Move4CategoryTextBox";
            this.pokémon1Move4CategoryTextBox.ReadOnly = true;
            this.pokémon1Move4CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move4CategoryTextBox.TabIndex = 51;
            // 
            // pokémon1Move3CategoryTextBox
            // 
            this.pokémon1Move3CategoryTextBox.Location = new System.Drawing.Point(257, 429);
            this.pokémon1Move3CategoryTextBox.Name = "pokémon1Move3CategoryTextBox";
            this.pokémon1Move3CategoryTextBox.ReadOnly = true;
            this.pokémon1Move3CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move3CategoryTextBox.TabIndex = 50;
            // 
            // pokémon1Move2CategoryTextBox
            // 
            this.pokémon1Move2CategoryTextBox.Location = new System.Drawing.Point(257, 400);
            this.pokémon1Move2CategoryTextBox.Name = "pokémon1Move2CategoryTextBox";
            this.pokémon1Move2CategoryTextBox.ReadOnly = true;
            this.pokémon1Move2CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move2CategoryTextBox.TabIndex = 49;
            // 
            // pokémon1Move1CategoryTextBox
            // 
            this.pokémon1Move1CategoryTextBox.Location = new System.Drawing.Point(257, 371);
            this.pokémon1Move1CategoryTextBox.Name = "pokémon1Move1CategoryTextBox";
            this.pokémon1Move1CategoryTextBox.ReadOnly = true;
            this.pokémon1Move1CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move1CategoryTextBox.TabIndex = 48;
            // 
            // pokémon1Move4TypeTextBox
            // 
            this.pokémon1Move4TypeTextBox.Location = new System.Drawing.Point(172, 458);
            this.pokémon1Move4TypeTextBox.Name = "pokémon1Move4TypeTextBox";
            this.pokémon1Move4TypeTextBox.ReadOnly = true;
            this.pokémon1Move4TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move4TypeTextBox.TabIndex = 47;
            // 
            // pokémon1Move3TypeTextBox
            // 
            this.pokémon1Move3TypeTextBox.Location = new System.Drawing.Point(172, 429);
            this.pokémon1Move3TypeTextBox.Name = "pokémon1Move3TypeTextBox";
            this.pokémon1Move3TypeTextBox.ReadOnly = true;
            this.pokémon1Move3TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move3TypeTextBox.TabIndex = 46;
            // 
            // pokémon1Move2TypeTextBox
            // 
            this.pokémon1Move2TypeTextBox.Location = new System.Drawing.Point(172, 400);
            this.pokémon1Move2TypeTextBox.Name = "pokémon1Move2TypeTextBox";
            this.pokémon1Move2TypeTextBox.ReadOnly = true;
            this.pokémon1Move2TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move2TypeTextBox.TabIndex = 45;
            // 
            // pokémon1Move1TypeTextBox
            // 
            this.pokémon1Move1TypeTextBox.Location = new System.Drawing.Point(172, 371);
            this.pokémon1Move1TypeTextBox.Name = "pokémon1Move1TypeTextBox";
            this.pokémon1Move1TypeTextBox.ReadOnly = true;
            this.pokémon1Move1TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Move1TypeTextBox.TabIndex = 44;
            // 
            // pokémon1Move4PowerTextBox
            // 
            this.pokémon1Move4PowerTextBox.Location = new System.Drawing.Point(128, 458);
            this.pokémon1Move4PowerTextBox.MaxLength = 3;
            this.pokémon1Move4PowerTextBox.Name = "pokémon1Move4PowerTextBox";
            this.pokémon1Move4PowerTextBox.ReadOnly = true;
            this.pokémon1Move4PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1Move4PowerTextBox.TabIndex = 43;
            // 
            // pokémon1Move3PowerTextBox
            // 
            this.pokémon1Move3PowerTextBox.Location = new System.Drawing.Point(128, 429);
            this.pokémon1Move3PowerTextBox.MaxLength = 3;
            this.pokémon1Move3PowerTextBox.Name = "pokémon1Move3PowerTextBox";
            this.pokémon1Move3PowerTextBox.ReadOnly = true;
            this.pokémon1Move3PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1Move3PowerTextBox.TabIndex = 42;
            // 
            // pokémon1Move2PowerTextBox
            // 
            this.pokémon1Move2PowerTextBox.Location = new System.Drawing.Point(128, 400);
            this.pokémon1Move2PowerTextBox.MaxLength = 3;
            this.pokémon1Move2PowerTextBox.Name = "pokémon1Move2PowerTextBox";
            this.pokémon1Move2PowerTextBox.ReadOnly = true;
            this.pokémon1Move2PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1Move2PowerTextBox.TabIndex = 41;
            // 
            // pokémon1Move1PowerTextBox
            // 
            this.pokémon1Move1PowerTextBox.Location = new System.Drawing.Point(128, 371);
            this.pokémon1Move1PowerTextBox.MaxLength = 3;
            this.pokémon1Move1PowerTextBox.Name = "pokémon1Move1PowerTextBox";
            this.pokémon1Move1PowerTextBox.ReadOnly = true;
            this.pokémon1Move1PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1Move1PowerTextBox.TabIndex = 40;
            // 
            // pokémon1Move4ComboBox
            // 
            this.pokémon1Move4ComboBox.DataSource = this.parseMovesBindingSource3;
            this.pokémon1Move4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon1Move4ComboBox.FormattingEnabled = true;
            this.pokémon1Move4ComboBox.Location = new System.Drawing.Point(6, 458);
            this.pokémon1Move4ComboBox.Name = "pokémon1Move4ComboBox";
            this.pokémon1Move4ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon1Move4ComboBox.TabIndex = 38;
            this.pokémon1Move4ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon1Move4ComboBox_SelectedIndexChanged);
            // 
            // pokémon1Move3ComboBox
            // 
            this.pokémon1Move3ComboBox.DataSource = this.parseMovesBindingSource2;
            this.pokémon1Move3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon1Move3ComboBox.FormattingEnabled = true;
            this.pokémon1Move3ComboBox.Location = new System.Drawing.Point(6, 429);
            this.pokémon1Move3ComboBox.Name = "pokémon1Move3ComboBox";
            this.pokémon1Move3ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon1Move3ComboBox.TabIndex = 37;
            this.pokémon1Move3ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon1Move3ComboBox_SelectedIndexChanged);
            // 
            // pokémon1Move2ComboBox
            // 
            this.pokémon1Move2ComboBox.DataSource = this.parseMovesBindingSource1;
            this.pokémon1Move2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon1Move2ComboBox.FormattingEnabled = true;
            this.pokémon1Move2ComboBox.Location = new System.Drawing.Point(6, 400);
            this.pokémon1Move2ComboBox.Name = "pokémon1Move2ComboBox";
            this.pokémon1Move2ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon1Move2ComboBox.TabIndex = 36;
            this.pokémon1Move2ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon1Move2ComboBox_SelectedIndexChanged);
            // 
            // pokémon1Move1ComboBox
            // 
            this.pokémon1Move1ComboBox.DataSource = this.parseMovesBindingSource;
            this.pokémon1Move1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon1Move1ComboBox.FormattingEnabled = true;
            this.pokémon1Move1ComboBox.Location = new System.Drawing.Point(6, 371);
            this.pokémon1Move1ComboBox.Name = "pokémon1Move1ComboBox";
            this.pokémon1Move1ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon1Move1ComboBox.TabIndex = 35;
            this.pokémon1Move1ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon1Move1ComboBox_SelectedIndexChanged);
            // 
            // pokémon1NatureComboBox
            // 
            this.pokémon1NatureComboBox.DataSource = this.listNaturesBindingSource;
            this.pokémon1NatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon1NatureComboBox.FormattingEnabled = true;
            this.pokémon1NatureComboBox.Location = new System.Drawing.Point(58, 327);
            this.pokémon1NatureComboBox.Name = "pokémon1NatureComboBox";
            this.pokémon1NatureComboBox.Size = new System.Drawing.Size(140, 23);
            this.pokémon1NatureComboBox.TabIndex = 34;
            this.pokémon1NatureComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon1NatureComboBox_SelectedIndexChanged);
            // 
            // pokémon1NatureLabel
            // 
            this.pokémon1NatureLabel.AutoSize = true;
            this.pokémon1NatureLabel.Location = new System.Drawing.Point(6, 330);
            this.pokémon1NatureLabel.Name = "pokémon1NatureLabel";
            this.pokémon1NatureLabel.Size = new System.Drawing.Size(43, 15);
            this.pokémon1NatureLabel.TabIndex = 33;
            this.pokémon1NatureLabel.Text = "Nature";
            // 
            // pokémon1BaseSpAtkTextBox
            // 
            this.pokémon1BaseSpAtkTextBox.Location = new System.Drawing.Point(58, 227);
            this.pokémon1BaseSpAtkTextBox.MaxLength = 3;
            this.pokémon1BaseSpAtkTextBox.Name = "pokémon1BaseSpAtkTextBox";
            this.pokémon1BaseSpAtkTextBox.ReadOnly = true;
            this.pokémon1BaseSpAtkTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1BaseSpAtkTextBox.TabIndex = 20;
            // 
            // pokémon1BaseSpDefTextBox
            // 
            this.pokémon1BaseSpDefTextBox.Location = new System.Drawing.Point(58, 256);
            this.pokémon1BaseSpDefTextBox.MaxLength = 3;
            this.pokémon1BaseSpDefTextBox.Name = "pokémon1BaseSpDefTextBox";
            this.pokémon1BaseSpDefTextBox.ReadOnly = true;
            this.pokémon1BaseSpDefTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1BaseSpDefTextBox.TabIndex = 19;
            // 
            // pokémon1BaseSpeTextBox
            // 
            this.pokémon1BaseSpeTextBox.Location = new System.Drawing.Point(58, 285);
            this.pokémon1BaseSpeTextBox.MaxLength = 3;
            this.pokémon1BaseSpeTextBox.Name = "pokémon1BaseSpeTextBox";
            this.pokémon1BaseSpeTextBox.ReadOnly = true;
            this.pokémon1BaseSpeTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1BaseSpeTextBox.TabIndex = 18;
            // 
            // pokémon1BaseDefTextBox
            // 
            this.pokémon1BaseDefTextBox.Location = new System.Drawing.Point(58, 198);
            this.pokémon1BaseDefTextBox.MaxLength = 3;
            this.pokémon1BaseDefTextBox.Name = "pokémon1BaseDefTextBox";
            this.pokémon1BaseDefTextBox.ReadOnly = true;
            this.pokémon1BaseDefTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1BaseDefTextBox.TabIndex = 17;
            // 
            // pokémon1BaseAtkTextBox
            // 
            this.pokémon1BaseAtkTextBox.Location = new System.Drawing.Point(58, 169);
            this.pokémon1BaseAtkTextBox.MaxLength = 3;
            this.pokémon1BaseAtkTextBox.Name = "pokémon1BaseAtkTextBox";
            this.pokémon1BaseAtkTextBox.ReadOnly = true;
            this.pokémon1BaseAtkTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1BaseAtkTextBox.TabIndex = 16;
            // 
            // pokémon1BaseHPTextBox
            // 
            this.pokémon1BaseHPTextBox.Location = new System.Drawing.Point(58, 140);
            this.pokémon1BaseHPTextBox.MaxLength = 3;
            this.pokémon1BaseHPTextBox.Name = "pokémon1BaseHPTextBox";
            this.pokémon1BaseHPTextBox.ReadOnly = true;
            this.pokémon1BaseHPTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon1BaseHPTextBox.TabIndex = 15;
            // 
            // pokémon1IVLabel
            // 
            this.pokémon1IVLabel.AutoSize = true;
            this.pokémon1IVLabel.Location = new System.Drawing.Point(102, 125);
            this.pokémon1IVLabel.Name = "pokémon1IVLabel";
            this.pokémon1IVLabel.Size = new System.Drawing.Size(22, 15);
            this.pokémon1IVLabel.TabIndex = 14;
            this.pokémon1IVLabel.Text = "IVs";
            // 
            // pokémon1EVLabel
            // 
            this.pokémon1EVLabel.AutoSize = true;
            this.pokémon1EVLabel.Location = new System.Drawing.Point(146, 125);
            this.pokémon1EVLabel.Name = "pokémon1EVLabel";
            this.pokémon1EVLabel.Size = new System.Drawing.Size(25, 15);
            this.pokémon1EVLabel.TabIndex = 13;
            this.pokémon1EVLabel.Text = "EVs";
            // 
            // pokémon1BaseLabel
            // 
            this.pokémon1BaseLabel.AutoSize = true;
            this.pokémon1BaseLabel.Location = new System.Drawing.Point(58, 125);
            this.pokémon1BaseLabel.Name = "pokémon1BaseLabel";
            this.pokémon1BaseLabel.Size = new System.Drawing.Size(31, 15);
            this.pokémon1BaseLabel.TabIndex = 12;
            this.pokémon1BaseLabel.Text = "Base";
            // 
            // pokémon1SpeLabel
            // 
            this.pokémon1SpeLabel.AutoSize = true;
            this.pokémon1SpeLabel.Location = new System.Drawing.Point(16, 288);
            this.pokémon1SpeLabel.Name = "pokémon1SpeLabel";
            this.pokémon1SpeLabel.Size = new System.Drawing.Size(39, 15);
            this.pokémon1SpeLabel.TabIndex = 11;
            this.pokémon1SpeLabel.Text = "Speed";
            this.pokémon1SpeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon1SpDefLabel
            // 
            this.pokémon1SpDefLabel.AutoSize = true;
            this.pokémon1SpDefLabel.Location = new System.Drawing.Point(11, 259);
            this.pokémon1SpDefLabel.Name = "pokémon1SpDefLabel";
            this.pokémon1SpDefLabel.Size = new System.Drawing.Size(44, 15);
            this.pokémon1SpDefLabel.TabIndex = 10;
            this.pokémon1SpDefLabel.Text = "Sp. Def";
            this.pokémon1SpDefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon1SpAtkLabel
            // 
            this.pokémon1SpAtkLabel.AutoSize = true;
            this.pokémon1SpAtkLabel.Location = new System.Drawing.Point(11, 230);
            this.pokémon1SpAtkLabel.Name = "pokémon1SpAtkLabel";
            this.pokémon1SpAtkLabel.Size = new System.Drawing.Size(44, 15);
            this.pokémon1SpAtkLabel.TabIndex = 9;
            this.pokémon1SpAtkLabel.Text = "Sp. Atk";
            this.pokémon1SpAtkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon1DefLabel
            // 
            this.pokémon1DefLabel.AutoSize = true;
            this.pokémon1DefLabel.Location = new System.Drawing.Point(6, 201);
            this.pokémon1DefLabel.Name = "pokémon1DefLabel";
            this.pokémon1DefLabel.Size = new System.Drawing.Size(49, 15);
            this.pokémon1DefLabel.TabIndex = 8;
            this.pokémon1DefLabel.Text = "Defense";
            this.pokémon1DefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon1AtkLabel
            // 
            this.pokémon1AtkLabel.AutoSize = true;
            this.pokémon1AtkLabel.Location = new System.Drawing.Point(14, 172);
            this.pokémon1AtkLabel.Name = "pokémon1AtkLabel";
            this.pokémon1AtkLabel.Size = new System.Drawing.Size(41, 15);
            this.pokémon1AtkLabel.TabIndex = 7;
            this.pokémon1AtkLabel.Text = "Attack";
            this.pokémon1AtkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon1HPLabel
            // 
            this.pokémon1HPLabel.AutoSize = true;
            this.pokémon1HPLabel.Location = new System.Drawing.Point(29, 143);
            this.pokémon1HPLabel.Name = "pokémon1HPLabel";
            this.pokémon1HPLabel.Size = new System.Drawing.Size(23, 15);
            this.pokémon1HPLabel.TabIndex = 6;
            this.pokémon1HPLabel.Text = "HP";
            this.pokémon1HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon1LevelLabel
            // 
            this.pokémon1LevelLabel.AutoSize = true;
            this.pokémon1LevelLabel.Location = new System.Drawing.Point(6, 92);
            this.pokémon1LevelLabel.Name = "pokémon1LevelLabel";
            this.pokémon1LevelLabel.Size = new System.Drawing.Size(34, 15);
            this.pokémon1LevelLabel.TabIndex = 4;
            this.pokémon1LevelLabel.Text = "Level";
            // 
            // pokémon1Type2TextBox
            // 
            this.pokémon1Type2TextBox.Location = new System.Drawing.Point(128, 57);
            this.pokémon1Type2TextBox.Name = "pokémon1Type2TextBox";
            this.pokémon1Type2TextBox.ReadOnly = true;
            this.pokémon1Type2TextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Type2TextBox.TabIndex = 3;
            // 
            // pokémon1Type1TextBox
            // 
            this.pokémon1Type1TextBox.Location = new System.Drawing.Point(43, 57);
            this.pokémon1Type1TextBox.Name = "pokémon1Type1TextBox";
            this.pokémon1Type1TextBox.ReadOnly = true;
            this.pokémon1Type1TextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon1Type1TextBox.TabIndex = 2;
            // 
            // pokémon1TypeLabel
            // 
            this.pokémon1TypeLabel.AutoSize = true;
            this.pokémon1TypeLabel.Location = new System.Drawing.Point(6, 60);
            this.pokémon1TypeLabel.Name = "pokémon1TypeLabel";
            this.pokémon1TypeLabel.Size = new System.Drawing.Size(31, 15);
            this.pokémon1TypeLabel.TabIndex = 1;
            this.pokémon1TypeLabel.Text = "Type";
            // 
            // pokémon1ComboBox
            // 
            this.pokémon1ComboBox.DataSource = this.parsePokémonBindingSource;
            this.pokémon1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon1ComboBox.FormattingEnabled = true;
            this.pokémon1ComboBox.Location = new System.Drawing.Point(6, 22);
            this.pokémon1ComboBox.Name = "pokémon1ComboBox";
            this.pokémon1ComboBox.Size = new System.Drawing.Size(192, 23);
            this.pokémon1ComboBox.TabIndex = 0;
            this.pokémon1ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon1ComboBox_SelectedIndexChanged);
            // 
            // pokémon2GroupBox
            // 
            this.pokémon2GroupBox.Controls.Add(this.pokémon2LevelNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVSpeNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVSpeNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVSpDefNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2SpeStatLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVHPNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVSpAtkNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVHPNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVDefNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVSpDefNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVAtkNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2SpDefStatLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVSpAtkNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2SpAtkStatLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVDefNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2DefStatLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVAtkNumericUpDown);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2AtkStatLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2HPStatLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move4CategoryTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move3CategoryTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move2CategoryTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move1CategoryTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move4TypeTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move3TypeTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move2TypeTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move1TypeTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move4PowerTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move3PowerTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move2PowerTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move1PowerTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move4ComboBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move3ComboBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move2ComboBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Move1ComboBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2NatureComboBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2NatureLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseSpAtkTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseSpDefTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseSpeTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseDefTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseAtkTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseHPTextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2IVLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2EVLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2BaseLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2SpeLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2SpDefLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2SpAtkLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2DefLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2AtkLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2HPLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2LevelLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Type2TextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2Type1TextBox);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2TypeLabel);
            this.pokémon2GroupBox.Controls.Add(this.pokémon2ComboBox);
            this.pokémon2GroupBox.Location = new System.Drawing.Point(567, 209);
            this.pokémon2GroupBox.Name = "pokémon2GroupBox";
            this.pokémon2GroupBox.Size = new System.Drawing.Size(387, 501);
            this.pokémon2GroupBox.TabIndex = 13;
            this.pokémon2GroupBox.TabStop = false;
            this.pokémon2GroupBox.Text = "Pokémon 2";
            // 
            // pokémon2LevelNumericUpDown
            // 
            this.pokémon2LevelNumericUpDown.Location = new System.Drawing.Point(46, 90);
            this.pokémon2LevelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pokémon2LevelNumericUpDown.Name = "pokémon2LevelNumericUpDown";
            this.pokémon2LevelNumericUpDown.Size = new System.Drawing.Size(53, 23);
            this.pokémon2LevelNumericUpDown.TabIndex = 22;
            this.pokémon2LevelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pokémon2LevelNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2LevelNumericUpDown_ValueChanged);
            // 
            // pokémon2IVSpeNumericUpDown
            // 
            this.pokémon2IVSpeNumericUpDown.Location = new System.Drawing.Point(102, 285);
            this.pokémon2IVSpeNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon2IVSpeNumericUpDown.Name = "pokémon2IVSpeNumericUpDown";
            this.pokémon2IVSpeNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon2IVSpeNumericUpDown.TabIndex = 26;
            this.pokémon2IVSpeNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2IVSpeNumericUpDown_ValueChanged);
            // 
            // pokémon2EVSpeNumericUpDown
            // 
            this.pokémon2EVSpeNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon2EVSpeNumericUpDown.Location = new System.Drawing.Point(146, 285);
            this.pokémon2EVSpeNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon2EVSpeNumericUpDown.Name = "pokémon2EVSpeNumericUpDown";
            this.pokémon2EVSpeNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon2EVSpeNumericUpDown.TabIndex = 25;
            this.pokémon2EVSpeNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2EVSpeNumericUpDown_ValueChanged);
            // 
            // pokémon2IVSpDefNumericUpDown
            // 
            this.pokémon2IVSpDefNumericUpDown.Location = new System.Drawing.Point(102, 256);
            this.pokémon2IVSpDefNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon2IVSpDefNumericUpDown.Name = "pokémon2IVSpDefNumericUpDown";
            this.pokémon2IVSpDefNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon2IVSpDefNumericUpDown.TabIndex = 25;
            this.pokémon2IVSpDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2IVSpDefNumericUpDown_ValueChanged);
            // 
            // pokémon2SpeStatLabel
            // 
            this.pokémon2SpeStatLabel.AutoSize = true;
            this.pokémon2SpeStatLabel.Location = new System.Drawing.Point(199, 287);
            this.pokémon2SpeStatLabel.Name = "pokémon2SpeStatLabel";
            this.pokémon2SpeStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon2SpeStatLabel.TabIndex = 102;
            this.pokémon2SpeStatLabel.Text = "label6";
            // 
            // pokémon2IVHPNumericUpDown
            // 
            this.pokémon2IVHPNumericUpDown.Location = new System.Drawing.Point(102, 140);
            this.pokémon2IVHPNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon2IVHPNumericUpDown.Name = "pokémon2IVHPNumericUpDown";
            this.pokémon2IVHPNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon2IVHPNumericUpDown.TabIndex = 21;
            this.pokémon2IVHPNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2IVHPNumericUpDown_ValueChanged);
            // 
            // pokémon2IVSpAtkNumericUpDown
            // 
            this.pokémon2IVSpAtkNumericUpDown.Location = new System.Drawing.Point(102, 227);
            this.pokémon2IVSpAtkNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon2IVSpAtkNumericUpDown.Name = "pokémon2IVSpAtkNumericUpDown";
            this.pokémon2IVSpAtkNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon2IVSpAtkNumericUpDown.TabIndex = 24;
            this.pokémon2IVSpAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2IVSpAtkNumericUpDown_ValueChanged);
            // 
            // pokémon2EVHPNumericUpDown
            // 
            this.pokémon2EVHPNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon2EVHPNumericUpDown.Location = new System.Drawing.Point(146, 140);
            this.pokémon2EVHPNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon2EVHPNumericUpDown.Name = "pokémon2EVHPNumericUpDown";
            this.pokémon2EVHPNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon2EVHPNumericUpDown.TabIndex = 20;
            this.pokémon2EVHPNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2EVHPNumericUpDown_ValueChanged);
            // 
            // pokémon2IVDefNumericUpDown
            // 
            this.pokémon2IVDefNumericUpDown.Location = new System.Drawing.Point(102, 198);
            this.pokémon2IVDefNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon2IVDefNumericUpDown.Name = "pokémon2IVDefNumericUpDown";
            this.pokémon2IVDefNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon2IVDefNumericUpDown.TabIndex = 23;
            this.pokémon2IVDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2IVDefNumericUpDown_ValueChanged);
            // 
            // pokémon2EVSpDefNumericUpDown
            // 
            this.pokémon2EVSpDefNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon2EVSpDefNumericUpDown.Location = new System.Drawing.Point(146, 256);
            this.pokémon2EVSpDefNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon2EVSpDefNumericUpDown.Name = "pokémon2EVSpDefNumericUpDown";
            this.pokémon2EVSpDefNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon2EVSpDefNumericUpDown.TabIndex = 24;
            this.pokémon2EVSpDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2EVSpDefNumericUpDown_ValueChanged);
            // 
            // pokémon2IVAtkNumericUpDown
            // 
            this.pokémon2IVAtkNumericUpDown.Location = new System.Drawing.Point(102, 169);
            this.pokémon2IVAtkNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pokémon2IVAtkNumericUpDown.Name = "pokémon2IVAtkNumericUpDown";
            this.pokémon2IVAtkNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.pokémon2IVAtkNumericUpDown.TabIndex = 22;
            this.pokémon2IVAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2IVAtkNumericUpDown_ValueChanged);
            // 
            // pokémon2SpDefStatLabel
            // 
            this.pokémon2SpDefStatLabel.AutoSize = true;
            this.pokémon2SpDefStatLabel.Location = new System.Drawing.Point(199, 259);
            this.pokémon2SpDefStatLabel.Name = "pokémon2SpDefStatLabel";
            this.pokémon2SpDefStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon2SpDefStatLabel.TabIndex = 101;
            this.pokémon2SpDefStatLabel.Text = "label5";
            // 
            // pokémon2EVSpAtkNumericUpDown
            // 
            this.pokémon2EVSpAtkNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon2EVSpAtkNumericUpDown.Location = new System.Drawing.Point(146, 227);
            this.pokémon2EVSpAtkNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon2EVSpAtkNumericUpDown.Name = "pokémon2EVSpAtkNumericUpDown";
            this.pokémon2EVSpAtkNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon2EVSpAtkNumericUpDown.TabIndex = 23;
            this.pokémon2EVSpAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2EVSpAtkNumericUpDown_ValueChanged);
            // 
            // pokémon2SpAtkStatLabel
            // 
            this.pokémon2SpAtkStatLabel.AutoSize = true;
            this.pokémon2SpAtkStatLabel.Location = new System.Drawing.Point(199, 229);
            this.pokémon2SpAtkStatLabel.Name = "pokémon2SpAtkStatLabel";
            this.pokémon2SpAtkStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon2SpAtkStatLabel.TabIndex = 100;
            this.pokémon2SpAtkStatLabel.Text = "label4";
            // 
            // pokémon2EVDefNumericUpDown
            // 
            this.pokémon2EVDefNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon2EVDefNumericUpDown.Location = new System.Drawing.Point(146, 198);
            this.pokémon2EVDefNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon2EVDefNumericUpDown.Name = "pokémon2EVDefNumericUpDown";
            this.pokémon2EVDefNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon2EVDefNumericUpDown.TabIndex = 22;
            this.pokémon2EVDefNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2EVDefNumericUpDown_ValueChanged);
            // 
            // pokémon2DefStatLabel
            // 
            this.pokémon2DefStatLabel.AutoSize = true;
            this.pokémon2DefStatLabel.Location = new System.Drawing.Point(199, 201);
            this.pokémon2DefStatLabel.Name = "pokémon2DefStatLabel";
            this.pokémon2DefStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon2DefStatLabel.TabIndex = 99;
            this.pokémon2DefStatLabel.Text = "label3";
            // 
            // pokémon2EVAtkNumericUpDown
            // 
            this.pokémon2EVAtkNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pokémon2EVAtkNumericUpDown.Location = new System.Drawing.Point(146, 169);
            this.pokémon2EVAtkNumericUpDown.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.pokémon2EVAtkNumericUpDown.Name = "pokémon2EVAtkNumericUpDown";
            this.pokémon2EVAtkNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.pokémon2EVAtkNumericUpDown.TabIndex = 21;
            this.pokémon2EVAtkNumericUpDown.ValueChanged += new System.EventHandler(this.pokémon2EVAtkNumericUpDown_ValueChanged);
            // 
            // pokémon2AtkStatLabel
            // 
            this.pokémon2AtkStatLabel.AutoSize = true;
            this.pokémon2AtkStatLabel.Location = new System.Drawing.Point(199, 172);
            this.pokémon2AtkStatLabel.Name = "pokémon2AtkStatLabel";
            this.pokémon2AtkStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon2AtkStatLabel.TabIndex = 98;
            this.pokémon2AtkStatLabel.Text = "label2";
            // 
            // pokémon2HPStatLabel
            // 
            this.pokémon2HPStatLabel.AutoSize = true;
            this.pokémon2HPStatLabel.Location = new System.Drawing.Point(199, 143);
            this.pokémon2HPStatLabel.Name = "pokémon2HPStatLabel";
            this.pokémon2HPStatLabel.Size = new System.Drawing.Size(38, 15);
            this.pokémon2HPStatLabel.TabIndex = 97;
            this.pokémon2HPStatLabel.Text = "label1";
            // 
            // pokémon2Move4CategoryTextBox
            // 
            this.pokémon2Move4CategoryTextBox.Location = new System.Drawing.Point(257, 458);
            this.pokémon2Move4CategoryTextBox.Name = "pokémon2Move4CategoryTextBox";
            this.pokémon2Move4CategoryTextBox.ReadOnly = true;
            this.pokémon2Move4CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move4CategoryTextBox.TabIndex = 96;
            // 
            // pokémon2Move3CategoryTextBox
            // 
            this.pokémon2Move3CategoryTextBox.Location = new System.Drawing.Point(257, 429);
            this.pokémon2Move3CategoryTextBox.Name = "pokémon2Move3CategoryTextBox";
            this.pokémon2Move3CategoryTextBox.ReadOnly = true;
            this.pokémon2Move3CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move3CategoryTextBox.TabIndex = 95;
            // 
            // pokémon2Move2CategoryTextBox
            // 
            this.pokémon2Move2CategoryTextBox.Location = new System.Drawing.Point(257, 400);
            this.pokémon2Move2CategoryTextBox.Name = "pokémon2Move2CategoryTextBox";
            this.pokémon2Move2CategoryTextBox.ReadOnly = true;
            this.pokémon2Move2CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move2CategoryTextBox.TabIndex = 94;
            // 
            // pokémon2Move1CategoryTextBox
            // 
            this.pokémon2Move1CategoryTextBox.Location = new System.Drawing.Point(257, 371);
            this.pokémon2Move1CategoryTextBox.Name = "pokémon2Move1CategoryTextBox";
            this.pokémon2Move1CategoryTextBox.ReadOnly = true;
            this.pokémon2Move1CategoryTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move1CategoryTextBox.TabIndex = 93;
            // 
            // pokémon2Move4TypeTextBox
            // 
            this.pokémon2Move4TypeTextBox.Location = new System.Drawing.Point(172, 458);
            this.pokémon2Move4TypeTextBox.Name = "pokémon2Move4TypeTextBox";
            this.pokémon2Move4TypeTextBox.ReadOnly = true;
            this.pokémon2Move4TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move4TypeTextBox.TabIndex = 92;
            // 
            // pokémon2Move3TypeTextBox
            // 
            this.pokémon2Move3TypeTextBox.Location = new System.Drawing.Point(172, 429);
            this.pokémon2Move3TypeTextBox.Name = "pokémon2Move3TypeTextBox";
            this.pokémon2Move3TypeTextBox.ReadOnly = true;
            this.pokémon2Move3TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move3TypeTextBox.TabIndex = 91;
            // 
            // pokémon2Move2TypeTextBox
            // 
            this.pokémon2Move2TypeTextBox.Location = new System.Drawing.Point(172, 400);
            this.pokémon2Move2TypeTextBox.Name = "pokémon2Move2TypeTextBox";
            this.pokémon2Move2TypeTextBox.ReadOnly = true;
            this.pokémon2Move2TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move2TypeTextBox.TabIndex = 90;
            // 
            // pokémon2Move1TypeTextBox
            // 
            this.pokémon2Move1TypeTextBox.Location = new System.Drawing.Point(172, 371);
            this.pokémon2Move1TypeTextBox.Name = "pokémon2Move1TypeTextBox";
            this.pokémon2Move1TypeTextBox.ReadOnly = true;
            this.pokémon2Move1TypeTextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Move1TypeTextBox.TabIndex = 89;
            // 
            // pokémon2Move4PowerTextBox
            // 
            this.pokémon2Move4PowerTextBox.Location = new System.Drawing.Point(128, 458);
            this.pokémon2Move4PowerTextBox.MaxLength = 3;
            this.pokémon2Move4PowerTextBox.Name = "pokémon2Move4PowerTextBox";
            this.pokémon2Move4PowerTextBox.ReadOnly = true;
            this.pokémon2Move4PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2Move4PowerTextBox.TabIndex = 88;
            // 
            // pokémon2Move3PowerTextBox
            // 
            this.pokémon2Move3PowerTextBox.Location = new System.Drawing.Point(128, 429);
            this.pokémon2Move3PowerTextBox.MaxLength = 3;
            this.pokémon2Move3PowerTextBox.Name = "pokémon2Move3PowerTextBox";
            this.pokémon2Move3PowerTextBox.ReadOnly = true;
            this.pokémon2Move3PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2Move3PowerTextBox.TabIndex = 87;
            // 
            // pokémon2Move2PowerTextBox
            // 
            this.pokémon2Move2PowerTextBox.Location = new System.Drawing.Point(128, 400);
            this.pokémon2Move2PowerTextBox.MaxLength = 3;
            this.pokémon2Move2PowerTextBox.Name = "pokémon2Move2PowerTextBox";
            this.pokémon2Move2PowerTextBox.ReadOnly = true;
            this.pokémon2Move2PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2Move2PowerTextBox.TabIndex = 86;
            // 
            // pokémon2Move1PowerTextBox
            // 
            this.pokémon2Move1PowerTextBox.Location = new System.Drawing.Point(128, 371);
            this.pokémon2Move1PowerTextBox.MaxLength = 3;
            this.pokémon2Move1PowerTextBox.Name = "pokémon2Move1PowerTextBox";
            this.pokémon2Move1PowerTextBox.ReadOnly = true;
            this.pokémon2Move1PowerTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2Move1PowerTextBox.TabIndex = 85;
            // 
            // pokémon2Move4ComboBox
            // 
            this.pokémon2Move4ComboBox.DataSource = this.parseMovesBindingSource7;
            this.pokémon2Move4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon2Move4ComboBox.FormattingEnabled = true;
            this.pokémon2Move4ComboBox.Location = new System.Drawing.Point(6, 458);
            this.pokémon2Move4ComboBox.Name = "pokémon2Move4ComboBox";
            this.pokémon2Move4ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon2Move4ComboBox.TabIndex = 84;
            this.pokémon2Move4ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon2Move4ComboBox_SelectedIndexChanged);
            // 
            // pokémon2Move3ComboBox
            // 
            this.pokémon2Move3ComboBox.DataSource = this.parseMovesBindingSource6;
            this.pokémon2Move3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon2Move3ComboBox.FormattingEnabled = true;
            this.pokémon2Move3ComboBox.Location = new System.Drawing.Point(6, 429);
            this.pokémon2Move3ComboBox.Name = "pokémon2Move3ComboBox";
            this.pokémon2Move3ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon2Move3ComboBox.TabIndex = 83;
            this.pokémon2Move3ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon2Move3ComboBox_SelectedIndexChanged);
            // 
            // pokémon2Move2ComboBox
            // 
            this.pokémon2Move2ComboBox.DataSource = this.parseMovesBindingSource5;
            this.pokémon2Move2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon2Move2ComboBox.FormattingEnabled = true;
            this.pokémon2Move2ComboBox.Location = new System.Drawing.Point(6, 400);
            this.pokémon2Move2ComboBox.Name = "pokémon2Move2ComboBox";
            this.pokémon2Move2ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon2Move2ComboBox.TabIndex = 82;
            this.pokémon2Move2ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon2Move2ComboBox_SelectedIndexChanged);
            // 
            // pokémon2Move1ComboBox
            // 
            this.pokémon2Move1ComboBox.DataSource = this.parseMovesBindingSource4;
            this.pokémon2Move1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon2Move1ComboBox.FormattingEnabled = true;
            this.pokémon2Move1ComboBox.Location = new System.Drawing.Point(6, 371);
            this.pokémon2Move1ComboBox.Name = "pokémon2Move1ComboBox";
            this.pokémon2Move1ComboBox.Size = new System.Drawing.Size(116, 23);
            this.pokémon2Move1ComboBox.TabIndex = 81;
            this.pokémon2Move1ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon2Move1ComboBox_SelectedIndexChanged);
            // 
            // pokémon2NatureComboBox
            // 
            this.pokémon2NatureComboBox.DataSource = this.listNaturesBindingSource1;
            this.pokémon2NatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon2NatureComboBox.FormattingEnabled = true;
            this.pokémon2NatureComboBox.Location = new System.Drawing.Point(58, 327);
            this.pokémon2NatureComboBox.Name = "pokémon2NatureComboBox";
            this.pokémon2NatureComboBox.Size = new System.Drawing.Size(140, 23);
            this.pokémon2NatureComboBox.TabIndex = 80;
            this.pokémon2NatureComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon2NatureComboBox_SelectedIndexChanged);
            // 
            // pokémon2NatureLabel
            // 
            this.pokémon2NatureLabel.AutoSize = true;
            this.pokémon2NatureLabel.Location = new System.Drawing.Point(6, 330);
            this.pokémon2NatureLabel.Name = "pokémon2NatureLabel";
            this.pokémon2NatureLabel.Size = new System.Drawing.Size(43, 15);
            this.pokémon2NatureLabel.TabIndex = 79;
            this.pokémon2NatureLabel.Text = "Nature";
            // 
            // pokémon2BaseSpAtkTextBox
            // 
            this.pokémon2BaseSpAtkTextBox.Location = new System.Drawing.Point(58, 227);
            this.pokémon2BaseSpAtkTextBox.MaxLength = 3;
            this.pokémon2BaseSpAtkTextBox.Name = "pokémon2BaseSpAtkTextBox";
            this.pokémon2BaseSpAtkTextBox.ReadOnly = true;
            this.pokémon2BaseSpAtkTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2BaseSpAtkTextBox.TabIndex = 66;
            // 
            // pokémon2BaseSpDefTextBox
            // 
            this.pokémon2BaseSpDefTextBox.Location = new System.Drawing.Point(58, 256);
            this.pokémon2BaseSpDefTextBox.MaxLength = 3;
            this.pokémon2BaseSpDefTextBox.Name = "pokémon2BaseSpDefTextBox";
            this.pokémon2BaseSpDefTextBox.ReadOnly = true;
            this.pokémon2BaseSpDefTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2BaseSpDefTextBox.TabIndex = 65;
            // 
            // pokémon2BaseSpeTextBox
            // 
            this.pokémon2BaseSpeTextBox.Location = new System.Drawing.Point(58, 285);
            this.pokémon2BaseSpeTextBox.MaxLength = 3;
            this.pokémon2BaseSpeTextBox.Name = "pokémon2BaseSpeTextBox";
            this.pokémon2BaseSpeTextBox.ReadOnly = true;
            this.pokémon2BaseSpeTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2BaseSpeTextBox.TabIndex = 64;
            // 
            // pokémon2BaseDefTextBox
            // 
            this.pokémon2BaseDefTextBox.Location = new System.Drawing.Point(58, 198);
            this.pokémon2BaseDefTextBox.MaxLength = 3;
            this.pokémon2BaseDefTextBox.Name = "pokémon2BaseDefTextBox";
            this.pokémon2BaseDefTextBox.ReadOnly = true;
            this.pokémon2BaseDefTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2BaseDefTextBox.TabIndex = 63;
            // 
            // pokémon2BaseAtkTextBox
            // 
            this.pokémon2BaseAtkTextBox.Location = new System.Drawing.Point(58, 169);
            this.pokémon2BaseAtkTextBox.MaxLength = 3;
            this.pokémon2BaseAtkTextBox.Name = "pokémon2BaseAtkTextBox";
            this.pokémon2BaseAtkTextBox.ReadOnly = true;
            this.pokémon2BaseAtkTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2BaseAtkTextBox.TabIndex = 62;
            // 
            // pokémon2BaseHPTextBox
            // 
            this.pokémon2BaseHPTextBox.Location = new System.Drawing.Point(58, 140);
            this.pokémon2BaseHPTextBox.MaxLength = 3;
            this.pokémon2BaseHPTextBox.Name = "pokémon2BaseHPTextBox";
            this.pokémon2BaseHPTextBox.ReadOnly = true;
            this.pokémon2BaseHPTextBox.Size = new System.Drawing.Size(38, 23);
            this.pokémon2BaseHPTextBox.TabIndex = 61;
            // 
            // pokémon2IVLabel
            // 
            this.pokémon2IVLabel.AutoSize = true;
            this.pokémon2IVLabel.Location = new System.Drawing.Point(102, 125);
            this.pokémon2IVLabel.Name = "pokémon2IVLabel";
            this.pokémon2IVLabel.Size = new System.Drawing.Size(22, 15);
            this.pokémon2IVLabel.TabIndex = 60;
            this.pokémon2IVLabel.Text = "IVs";
            // 
            // pokémon2EVLabel
            // 
            this.pokémon2EVLabel.AutoSize = true;
            this.pokémon2EVLabel.Location = new System.Drawing.Point(146, 125);
            this.pokémon2EVLabel.Name = "pokémon2EVLabel";
            this.pokémon2EVLabel.Size = new System.Drawing.Size(25, 15);
            this.pokémon2EVLabel.TabIndex = 59;
            this.pokémon2EVLabel.Text = "EVs";
            // 
            // pokémon2BaseLabel
            // 
            this.pokémon2BaseLabel.AutoSize = true;
            this.pokémon2BaseLabel.Location = new System.Drawing.Point(58, 125);
            this.pokémon2BaseLabel.Name = "pokémon2BaseLabel";
            this.pokémon2BaseLabel.Size = new System.Drawing.Size(31, 15);
            this.pokémon2BaseLabel.TabIndex = 58;
            this.pokémon2BaseLabel.Text = "Base";
            // 
            // pokémon2SpeLabel
            // 
            this.pokémon2SpeLabel.AutoSize = true;
            this.pokémon2SpeLabel.Location = new System.Drawing.Point(16, 288);
            this.pokémon2SpeLabel.Name = "pokémon2SpeLabel";
            this.pokémon2SpeLabel.Size = new System.Drawing.Size(39, 15);
            this.pokémon2SpeLabel.TabIndex = 57;
            this.pokémon2SpeLabel.Text = "Speed";
            this.pokémon2SpeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon2SpDefLabel
            // 
            this.pokémon2SpDefLabel.AutoSize = true;
            this.pokémon2SpDefLabel.Location = new System.Drawing.Point(11, 259);
            this.pokémon2SpDefLabel.Name = "pokémon2SpDefLabel";
            this.pokémon2SpDefLabel.Size = new System.Drawing.Size(44, 15);
            this.pokémon2SpDefLabel.TabIndex = 56;
            this.pokémon2SpDefLabel.Text = "Sp. Def";
            this.pokémon2SpDefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon2SpAtkLabel
            // 
            this.pokémon2SpAtkLabel.AutoSize = true;
            this.pokémon2SpAtkLabel.Location = new System.Drawing.Point(11, 230);
            this.pokémon2SpAtkLabel.Name = "pokémon2SpAtkLabel";
            this.pokémon2SpAtkLabel.Size = new System.Drawing.Size(44, 15);
            this.pokémon2SpAtkLabel.TabIndex = 55;
            this.pokémon2SpAtkLabel.Text = "Sp. Atk";
            this.pokémon2SpAtkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon2DefLabel
            // 
            this.pokémon2DefLabel.AutoSize = true;
            this.pokémon2DefLabel.Location = new System.Drawing.Point(6, 201);
            this.pokémon2DefLabel.Name = "pokémon2DefLabel";
            this.pokémon2DefLabel.Size = new System.Drawing.Size(49, 15);
            this.pokémon2DefLabel.TabIndex = 54;
            this.pokémon2DefLabel.Text = "Defense";
            this.pokémon2DefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon2AtkLabel
            // 
            this.pokémon2AtkLabel.AutoSize = true;
            this.pokémon2AtkLabel.Location = new System.Drawing.Point(14, 172);
            this.pokémon2AtkLabel.Name = "pokémon2AtkLabel";
            this.pokémon2AtkLabel.Size = new System.Drawing.Size(41, 15);
            this.pokémon2AtkLabel.TabIndex = 53;
            this.pokémon2AtkLabel.Text = "Attack";
            this.pokémon2AtkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon2HPLabel
            // 
            this.pokémon2HPLabel.AutoSize = true;
            this.pokémon2HPLabel.Location = new System.Drawing.Point(29, 143);
            this.pokémon2HPLabel.Name = "pokémon2HPLabel";
            this.pokémon2HPLabel.Size = new System.Drawing.Size(23, 15);
            this.pokémon2HPLabel.TabIndex = 52;
            this.pokémon2HPLabel.Text = "HP";
            this.pokémon2HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokémon2LevelLabel
            // 
            this.pokémon2LevelLabel.AutoSize = true;
            this.pokémon2LevelLabel.Location = new System.Drawing.Point(6, 92);
            this.pokémon2LevelLabel.Name = "pokémon2LevelLabel";
            this.pokémon2LevelLabel.Size = new System.Drawing.Size(34, 15);
            this.pokémon2LevelLabel.TabIndex = 6;
            this.pokémon2LevelLabel.Text = "Level";
            // 
            // pokémon2Type2TextBox
            // 
            this.pokémon2Type2TextBox.Location = new System.Drawing.Point(128, 57);
            this.pokémon2Type2TextBox.Name = "pokémon2Type2TextBox";
            this.pokémon2Type2TextBox.ReadOnly = true;
            this.pokémon2Type2TextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Type2TextBox.TabIndex = 5;
            // 
            // pokémon2Type1TextBox
            // 
            this.pokémon2Type1TextBox.Location = new System.Drawing.Point(43, 57);
            this.pokémon2Type1TextBox.Name = "pokémon2Type1TextBox";
            this.pokémon2Type1TextBox.ReadOnly = true;
            this.pokémon2Type1TextBox.Size = new System.Drawing.Size(79, 23);
            this.pokémon2Type1TextBox.TabIndex = 4;
            // 
            // pokémon2TypeLabel
            // 
            this.pokémon2TypeLabel.AutoSize = true;
            this.pokémon2TypeLabel.Location = new System.Drawing.Point(6, 60);
            this.pokémon2TypeLabel.Name = "pokémon2TypeLabel";
            this.pokémon2TypeLabel.Size = new System.Drawing.Size(31, 15);
            this.pokémon2TypeLabel.TabIndex = 2;
            this.pokémon2TypeLabel.Text = "Type";
            // 
            // pokémon2ComboBox
            // 
            this.pokémon2ComboBox.DataSource = this.parsePokémonBindingSource1;
            this.pokémon2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokémon2ComboBox.FormattingEnabled = true;
            this.pokémon2ComboBox.Location = new System.Drawing.Point(6, 22);
            this.pokémon2ComboBox.Name = "pokémon2ComboBox";
            this.pokémon2ComboBox.Size = new System.Drawing.Size(192, 23);
            this.pokémon2ComboBox.TabIndex = 1;
            this.pokémon2ComboBox.SelectedIndexChanged += new System.EventHandler(this.pokémon2ComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(966, 722);
            this.Controls.Add(this.pokémon2GroupBox);
            this.Controls.Add(this.pokémon1GroupBox);
            this.Controls.Add(this.pokémon2Move4Button);
            this.Controls.Add(this.pokémon2Move3Button);
            this.Controls.Add(this.pokémon2Move2Button);
            this.Controls.Add(this.pokémon2Move1Button);
            this.Controls.Add(this.pokémon2MovesLabel);
            this.Controls.Add(this.calcTextBox);
            this.Controls.Add(this.pokémon1Move4Button);
            this.Controls.Add(this.pokémon1Move3Button);
            this.Controls.Add(this.pokémon1Move2Button);
            this.Controls.Add(this.pokémon1Move1Button);
            this.Controls.Add(this.pokémon1MovesLabel);
            this.Name = "MainForm";
            this.pokémon1GroupBox.ResumeLayout(false);
            this.pokémon1GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVSpeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1LevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVSpDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVHPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVSpAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVSpeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVHPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1IVAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVSpDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVSpAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon1EVAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listNaturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsePokémonBindingSource)).EndInit();
            this.pokémon2GroupBox.ResumeLayout(false);
            this.pokémon2GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2LevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVSpeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVSpeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVSpDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVHPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVSpAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVHPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVSpDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2IVAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVSpAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVDefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokémon2EVAtkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parseMovesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listNaturesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsePokémonBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void UpdateAll()
        {
            Pokémon1MovesLabel.Text = calculatorController.GetPokémon1().Name + "'s Moves";
            Pokémon1Move1Button.Text = calculatorController.GetPokémon1MovesNames()[0];
            Pokémon1Move2Button.Text = calculatorController.GetPokémon1MovesNames()[1];
            Pokémon1Move3Button.Text = calculatorController.GetPokémon1MovesNames()[2];
            Pokémon1Move4Button.Text = calculatorController.GetPokémon1MovesNames()[3];

            Pokémon1ComboBox.Text = calculatorController.GetPokémon1().Name;

            Pokémon1LevelNumericUpDown.Text = calculatorController.GetPokémon1().Level.ToString();

            Pokémon1Type1TextBox.Text = calculatorController.GetPokémon1Types()[0];
            Pokémon1Type2TextBox.Text = calculatorController.GetPokémon1Types()[1];

            Pokémon1BaseHPTextBox.Text = calculatorController.GetPokémon1().BaseStats.GetHPBaseStats().ToString();
            Pokémon1BaseAtkTextBox.Text = calculatorController.GetPokémon1().BaseStats.GetAttackBaseStats().ToString();
            Pokémon1BaseDefTextBox.Text = calculatorController.GetPokémon1().BaseStats.GetDefenseBaseStats().ToString();
            Pokémon1BaseSpAtkTextBox.Text = calculatorController.GetPokémon1().BaseStats.GetSpecialAttackBaseStats().ToString();
            Pokémon1BaseSpDefTextBox.Text = calculatorController.GetPokémon1().BaseStats.GetSpecialDefenseBaseStats().ToString();
            Pokémon1BaseSpeTextBox.Text = calculatorController.GetPokémon1().BaseStats.GetSpeedBaseStats().ToString();

            Pokémon1IVHPNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetHPIV();
            Pokémon1IVAtkNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetAttackIV();
            Pokémon1IVDefNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetDefenseIV();
            Pokémon1IVSpAtkNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetSpecialAttackIV();
            Pokémon1IVSpDefNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetSpecialDefenseIV();
            Pokémon1IVSpeNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetSpeedIV();

            Pokémon1EVHPNumericUpDown.Value = calculatorController.GetPokémon1().GetEVs().GetHPEV();
            Pokémon1EVAtkNumericUpDown.Value = calculatorController.GetPokémon1().GetEVs().GetAttackEV();
            Pokémon1EVDefNumericUpDown.Value = calculatorController.GetPokémon1().GetEVs().GetDefenseEV();
            Pokémon1EVSpAtkNumericUpDown.Value = calculatorController.GetPokémon1().GetEVs().GetSpecialAttackEV();
            Pokémon1EVSpDefNumericUpDown.Value = calculatorController.GetPokémon1().GetEVs().GetSpecialDefenseEV();
            Pokémon1EVSpeNumericUpDown.Value = calculatorController.GetPokémon1().GetEVs().GetSpeedEV();

            Pokémon1HPStatLabel.Text = calculatorController.GetPokémon1().HP.ToString();
            Pokémon1AtkStatLabel.Text = calculatorController.GetPokémon1().Attack.ToString();
            Pokémon1DefStatLabel.Text = calculatorController.GetPokémon1().Defense.ToString();
            Pokémon1SpAtkStatLabel.Text = calculatorController.GetPokémon1().SpecialAttack.ToString();
            Pokémon1SpDefStatLabel.Text = calculatorController.GetPokémon1().SpecialDefense.ToString();
            Pokémon1SpeStatLabel.Text = calculatorController.GetPokémon1().Speed.ToString();

            Pokémon1NatureComboBox.Text = calculatorController.GetPokémon1().Nature.ToString();

            Pokémon1Move1ComboBox.Text = calculatorController.GetPokémon1MovesNames()[0];
            Pokémon1Move2ComboBox.Text = calculatorController.GetPokémon1MovesNames()[1];
            Pokémon1Move3ComboBox.Text = calculatorController.GetPokémon1MovesNames()[2];
            Pokémon1Move4ComboBox.Text = calculatorController.GetPokémon1MovesNames()[3];

            Pokémon1Move1PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[0].ToString();
            Pokémon1Move2PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[1].ToString();
            Pokémon1Move3PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[2].ToString();
            Pokémon1Move4PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[3].ToString();

            Pokémon1Move1TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[0];
            Pokémon1Move2TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[1];
            Pokémon1Move3TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[2];
            Pokémon1Move4TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[3];

            Pokémon1Move1CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[0];
            Pokémon1Move2CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[1];
            Pokémon1Move3CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[2];
            Pokémon1Move4CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[3];




            Pokémon2MovesLabel.Text = calculatorController.GetPokémon2().Name + "'s Moves";
            Pokémon2Move1Button.Text = calculatorController.GetPokémon2MovesNames()[0];
            Pokémon2Move2Button.Text = calculatorController.GetPokémon2MovesNames()[1];
            Pokémon2Move3Button.Text = calculatorController.GetPokémon2MovesNames()[2];
            Pokémon2Move4Button.Text = calculatorController.GetPokémon2MovesNames()[3];

            Pokémon2ComboBox.Text = calculatorController.GetPokémon2().Name;

            Pokémon2LevelNumericUpDown.Text = calculatorController.GetPokémon2().Level.ToString();

            Pokémon2Type1TextBox.Text = calculatorController.GetPokémon2Types()[0];
            Pokémon2Type2TextBox.Text = calculatorController.GetPokémon2Types()[1];

            Pokémon2BaseHPTextBox.Text = calculatorController.GetPokémon2().BaseStats.GetHPBaseStats().ToString();
            Pokémon2BaseAtkTextBox.Text = calculatorController.GetPokémon2().BaseStats.GetAttackBaseStats().ToString();
            Pokémon2BaseDefTextBox.Text = calculatorController.GetPokémon2().BaseStats.GetDefenseBaseStats().ToString();
            Pokémon2BaseSpAtkTextBox.Text = calculatorController.GetPokémon2().BaseStats.GetSpecialAttackBaseStats().ToString();
            Pokémon2BaseSpDefTextBox.Text = calculatorController.GetPokémon2().BaseStats.GetSpecialDefenseBaseStats().ToString();
            Pokémon2BaseSpeTextBox.Text = calculatorController.GetPokémon2().BaseStats.GetSpeedBaseStats().ToString();

            Pokémon2IVHPNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetHPIV();
            Pokémon2IVAtkNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetAttackIV();
            Pokémon2IVDefNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetDefenseIV();
            Pokémon2IVSpAtkNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetSpecialAttackIV();
            Pokémon2IVSpDefNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetSpecialDefenseIV();
            Pokémon2IVSpeNumericUpDown.Value = calculatorController.GetPokémon2().GetIVs().GetSpeedIV();

            Pokémon2EVHPNumericUpDown.Value = calculatorController.GetPokémon2().GetEVs().GetHPEV();
            Pokémon2EVAtkNumericUpDown.Value = calculatorController.GetPokémon2().GetEVs().GetAttackEV();
            Pokémon2EVDefNumericUpDown.Value = calculatorController.GetPokémon2().GetEVs().GetDefenseEV();
            Pokémon2EVSpAtkNumericUpDown.Value = calculatorController.GetPokémon2().GetEVs().GetSpecialAttackEV();
            Pokémon2EVSpDefNumericUpDown.Value = calculatorController.GetPokémon2().GetEVs().GetSpecialDefenseEV();
            Pokémon2EVSpeNumericUpDown.Value = calculatorController.GetPokémon2().GetEVs().GetSpeedEV();

            Pokémon2HPStatLabel.Text = calculatorController.GetPokémon2().HP.ToString();
            Pokémon2AtkStatLabel.Text = calculatorController.GetPokémon2().Attack.ToString();
            Pokémon2DefStatLabel.Text = calculatorController.GetPokémon2().Defense.ToString();
            Pokémon2SpAtkStatLabel.Text = calculatorController.GetPokémon2().SpecialAttack.ToString();
            Pokémon2SpDefStatLabel.Text = calculatorController.GetPokémon2().SpecialDefense.ToString();
            Pokémon2SpeStatLabel.Text = calculatorController.GetPokémon2().Speed.ToString();

            Pokémon2NatureComboBox.Text = calculatorController.GetPokémon2().Nature.ToString();

            Pokémon2Move1ComboBox.Text = calculatorController.GetPokémon2MovesNames()[0];
            Pokémon2Move2ComboBox.Text = calculatorController.GetPokémon2MovesNames()[1];
            Pokémon2Move3ComboBox.Text = calculatorController.GetPokémon2MovesNames()[2];
            Pokémon2Move4ComboBox.Text = calculatorController.GetPokémon2MovesNames()[3];

            Pokémon2Move1PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[0].ToString();
            Pokémon2Move2PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[1].ToString();
            Pokémon2Move3PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[2].ToString();
            Pokémon2Move4PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[3].ToString();

            Pokémon2Move1TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[0];
            Pokémon2Move2TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[1];
            Pokémon2Move3TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[2];
            Pokémon2Move4TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[3];

            Pokémon2Move1CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[0];
            Pokémon2Move2CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[1];
            Pokémon2Move3CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[2];
            Pokémon2Move4CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[3];
        }

        public void SetDataSources()
        {
            parsePokémonBindingSource.DataSource = ParsePokémon.Instance.GetPokémons();
            listNaturesBindingSource.DataSource = ListNatures.Instance.GetNatures();
            parseMovesBindingSource.DataSource = ParseMoves.Instance.GetDamagingMoves();
            parseMovesBindingSource1.DataSource = ParseMoves.Instance.GetDamagingMoves();
            parseMovesBindingSource2.DataSource = ParseMoves.Instance.GetDamagingMoves();
            parseMovesBindingSource3.DataSource = ParseMoves.Instance.GetDamagingMoves();

            parsePokémonBindingSource1.DataSource = ParsePokémon.Instance.GetPokémons();
            listNaturesBindingSource1.DataSource = ListNatures.Instance.GetNatures();
            parseMovesBindingSource4.DataSource = ParseMoves.Instance.GetDamagingMoves();
            parseMovesBindingSource5.DataSource = ParseMoves.Instance.GetDamagingMoves();
            parseMovesBindingSource6.DataSource = ParseMoves.Instance.GetDamagingMoves();
            parseMovesBindingSource7.DataSource = ParseMoves.Instance.GetDamagingMoves();

            this.pokémon1ComboBox.DataSource = parsePokémonBindingSource;
            this.pokémon1NatureComboBox.DataSource = listNaturesBindingSource;
            this.pokémon1Move1ComboBox.DataSource = parseMovesBindingSource;
            this.pokémon1Move2ComboBox.DataSource = parseMovesBindingSource1;
            this.pokémon1Move3ComboBox.DataSource = parseMovesBindingSource2;
            this.pokémon1Move4ComboBox.DataSource = parseMovesBindingSource3;

            this.pokémon2ComboBox.DataSource = parsePokémonBindingSource1;
            this.pokémon2NatureComboBox.DataSource = listNaturesBindingSource1;
            this.pokémon2Move1ComboBox.DataSource = parseMovesBindingSource4;
            this.pokémon2Move2ComboBox.DataSource = parseMovesBindingSource5;
            this.pokémon2Move3ComboBox.DataSource = parseMovesBindingSource6;
            this.pokémon2Move4ComboBox.DataSource = parseMovesBindingSource7;

            /*this.pokémon1ComboBox.DataSource = parsePokémonBindingSource.DataSource = ParsePokémon.Instance.GetPokémons();
            this.pokémon1NatureComboBox.DataSource = listNaturesBindingSource.DataSource = ListNatures.Instance.GetNatures();
            this.pokémon1Move1ComboBox.DataSource = parseMovesBindingSource.DataSource = ParseMoves.Instance.GetDamagingMoves();
            this.pokémon1Move2ComboBox.DataSource = parseMovesBindingSource1.DataSource = ParseMoves.Instance.GetDamagingMoves();
            this.pokémon1Move3ComboBox.DataSource = parseMovesBindingSource2.DataSource = ParseMoves.Instance.GetDamagingMoves();
            this.pokémon1Move4ComboBox.DataSource = parseMovesBindingSource3.DataSource = ParseMoves.Instance.GetDamagingMoves();

            this.pokémon2ComboBox.DataSource = parsePokémonBindingSource1.DataSource = ParsePokémon.Instance.GetPokémons();
            this.pokémon2NatureComboBox.DataSource = listNaturesBindingSource1.DataSource = ListNatures.Instance.GetNatures();
            this.pokémon2Move1ComboBox.DataSource = parseMovesBindingSource4.DataSource = ParseMoves.Instance.GetDamagingMoves();
            this.pokémon2Move2ComboBox.DataSource = parseMovesBindingSource5.DataSource = ParseMoves.Instance.GetDamagingMoves();
            this.pokémon2Move3ComboBox.DataSource = parseMovesBindingSource6.DataSource = ParseMoves.Instance.GetDamagingMoves();
            this.pokémon2Move4ComboBox.DataSource = parseMovesBindingSource7.DataSource = ParseMoves.Instance.GetDamagingMoves();*/
        }

        public MainForm()
        {
            InitializeComponent();
            SetDataSources();
            calculatorController = Calculator.Instance;
            UpdateAll();
        }

        public void UpdatePokémon1Stats()
        {
            Pokémon1HPStatLabel.Text = calculatorController.GetPokémon1().HP.ToString();
            Pokémon1AtkStatLabel.Text = calculatorController.GetPokémon1().Attack.ToString();
            Pokémon1DefStatLabel.Text = calculatorController.GetPokémon1().Defense.ToString();
            Pokémon1SpAtkStatLabel.Text = calculatorController.GetPokémon1().SpecialAttack.ToString();
            Pokémon1SpDefStatLabel.Text = calculatorController.GetPokémon1().SpecialDefense.ToString();
            Pokémon1SpeStatLabel.Text = calculatorController.GetPokémon1().Speed.ToString();
        }

        public void UpdatePokémon2Stats()
        {
            Pokémon2HPStatLabel.Text = calculatorController.GetPokémon2().HP.ToString();
            Pokémon2AtkStatLabel.Text = calculatorController.GetPokémon2().Attack.ToString();
            Pokémon2DefStatLabel.Text = calculatorController.GetPokémon2().Defense.ToString();
            Pokémon2SpAtkStatLabel.Text = calculatorController.GetPokémon2().SpecialAttack.ToString();
            Pokémon2SpDefStatLabel.Text = calculatorController.GetPokémon2().SpecialDefense.ToString();
            Pokémon2SpeStatLabel.Text = calculatorController.GetPokémon2().Speed.ToString();
        }

        public void UpdatePokémon1Moves()
        {
            Pokémon1Move1Button.Text = Pokémon1Move1ComboBox.Text;
            Pokémon1Move2Button.Text = Pokémon1Move2ComboBox.Text;
            Pokémon1Move3Button.Text = Pokémon1Move3ComboBox.Text;
            Pokémon1Move4Button.Text = Pokémon1Move4ComboBox.Text;

            Pokémon1Move1PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[0].ToString();
            Pokémon1Move1TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[0].ToString();
            Pokémon1Move1CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[0].ToString();
            Pokémon1Move2PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[1].ToString();
            Pokémon1Move2TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[1].ToString();
            Pokémon1Move2CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[1].ToString();
            Pokémon1Move3PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[2].ToString();
            Pokémon1Move3TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[2].ToString();
            Pokémon1Move3CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[2].ToString();
            Pokémon1Move4PowerTextBox.Text = calculatorController.GetPokémon1MovesPowers()[3].ToString();
            Pokémon1Move4TypeTextBox.Text = calculatorController.GetPokémon1MovesTypes()[3].ToString();
            Pokémon1Move4CategoryTextBox.Text = calculatorController.GetPokémon1MovesCategories()[3].ToString();
        }
        public void UpdatePokémon2Moves()
        {
            Pokémon2Move1Button.Text = Pokémon2Move1ComboBox.Text;
            Pokémon2Move2Button.Text = Pokémon2Move2ComboBox.Text;
            Pokémon2Move3Button.Text = Pokémon2Move3ComboBox.Text;
            Pokémon2Move4Button.Text = Pokémon2Move4ComboBox.Text;

            Pokémon2Move1PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[0].ToString();
            Pokémon2Move1TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[0].ToString();
            Pokémon2Move1CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[0].ToString();
            Pokémon2Move2PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[1].ToString();
            Pokémon2Move2TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[1].ToString();
            Pokémon2Move2CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[1].ToString();
            Pokémon2Move3PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[2].ToString();
            Pokémon2Move3TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[2].ToString();
            Pokémon2Move3CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[2].ToString();
            Pokémon2Move4PowerTextBox.Text = calculatorController.GetPokémon2MovesPowers()[3].ToString();
            Pokémon2Move4TypeTextBox.Text = calculatorController.GetPokémon2MovesTypes()[3].ToString();
            Pokémon2Move4CategoryTextBox.Text = calculatorController.GetPokémon2MovesCategories()[3].ToString();
        }

        #region Properties
        /*
         * 
         * Pokémon 1
         * 
         */


        public Label Pokémon1MovesLabel { get => pokémon1MovesLabel; set => pokémon1MovesLabel = value; }
        public Button Pokémon1Move1Button { get => pokémon1Move1Button; set => pokémon1Move1Button = value; }
        public Button Pokémon1Move2Button { get => pokémon1Move2Button; set => pokémon1Move2Button = value; }
        public Button Pokémon1Move3Button { get => pokémon1Move3Button; set => pokémon1Move3Button = value; }
        public Button Pokémon1Move4Button { get => pokémon1Move4Button; set => pokémon1Move4Button = value; }

        public ComboBox Pokémon1ComboBox { get => pokémon1ComboBox; set => pokémon1ComboBox = value; }

        public NumericUpDown Pokémon1LevelNumericUpDown { get => pokémon1LevelNumericUpDown; set => pokémon1LevelNumericUpDown = value; }

        public TextBox Pokémon1Type2TextBox { get => pokémon1Type2TextBox; set => pokémon1Type2TextBox = value; }
        public TextBox Pokémon1Type1TextBox { get => pokémon1Type1TextBox; set => pokémon1Type1TextBox = value; }

        public NumericUpDown Pokémon1EVSpeNumericUpDown { get => pokémon1EVSpeNumericUpDown; set => pokémon1EVSpeNumericUpDown = value; }
        public NumericUpDown Pokémon1EVHPNumericUpDown { get => pokémon1EVHPNumericUpDown; set => pokémon1EVHPNumericUpDown = value; }
        public NumericUpDown Pokémon1EVSpDefNumericUpDown { get => pokémon1EVSpDefNumericUpDown; set => pokémon1EVSpDefNumericUpDown = value; }
        public NumericUpDown Pokémon1EVSpAtkNumericUpDown { get => pokémon1EVSpAtkNumericUpDown; set => pokémon1EVSpAtkNumericUpDown = value; }
        public NumericUpDown Pokémon1EVDefNumericUpDown { get => pokémon1EVDefNumericUpDown; set => pokémon1EVDefNumericUpDown = value; }
        public NumericUpDown Pokémon1EVAtkNumericUpDown { get => pokémon1EVAtkNumericUpDown; set => pokémon1EVAtkNumericUpDown = value; }

        public NumericUpDown Pokémon1IVSpeNumericUpDown { get => pokémon1IVSpeNumericUpDown; set => pokémon1IVSpeNumericUpDown = value; }
        public NumericUpDown Pokémon1IVSpDefNumericUpDown { get => pokémon1IVSpDefNumericUpDown; set => pokémon1IVSpDefNumericUpDown = value; }
        public NumericUpDown Pokémon1IVHPNumericUpDown { get => pokémon1IVHPNumericUpDown; set => pokémon1IVHPNumericUpDown = value; }
        public NumericUpDown Pokémon1IVSpAtkNumericUpDown { get => pokémon1IVSpAtkNumericUpDown; set => pokémon1IVSpAtkNumericUpDown = value; }
        public NumericUpDown Pokémon1IVDefNumericUpDown { get => pokémon1IVDefNumericUpDown; set => pokémon1IVDefNumericUpDown = value; }
        public NumericUpDown Pokémon1IVAtkNumericUpDown { get => pokémon1IVAtkNumericUpDown; set => pokémon1IVAtkNumericUpDown = value; }

        public TextBox Pokémon1BaseSpAtkTextBox { get => pokémon1BaseSpAtkTextBox; set => pokémon1BaseSpAtkTextBox = value; }
        public TextBox Pokémon1BaseSpDefTextBox { get => pokémon1BaseSpDefTextBox; set => pokémon1BaseSpDefTextBox = value; }
        public TextBox Pokémon1BaseSpeTextBox { get => pokémon1BaseSpeTextBox; set => pokémon1BaseSpeTextBox = value; }
        public TextBox Pokémon1BaseDefTextBox { get => pokémon1BaseDefTextBox; set => pokémon1BaseDefTextBox = value; }
        public TextBox Pokémon1BaseAtkTextBox { get => pokémon1BaseAtkTextBox; set => pokémon1BaseAtkTextBox = value; }
        public TextBox Pokémon1BaseHPTextBox { get => pokémon1BaseHPTextBox; set => pokémon1BaseHPTextBox = value; }

        public Label Pokémon1SpeStatLabel { get => pokémon1SpeStatLabel; set => pokémon1SpeStatLabel = value; }
        public Label Pokémon1SpDefStatLabel { get => pokémon1SpDefStatLabel; set => pokémon1SpDefStatLabel = value; }
        public Label Pokémon1SpAtkStatLabel { get => pokémon1SpAtkStatLabel; set => pokémon1SpAtkStatLabel = value; }
        public Label Pokémon1DefStatLabel { get => pokémon1DefStatLabel; set => pokémon1DefStatLabel = value; }
        public Label Pokémon1AtkStatLabel { get => pokémon1AtkStatLabel; set => pokémon1AtkStatLabel = value; }
        public Label Pokémon1HPStatLabel { get => pokémon1HPStatLabel; set => pokémon1HPStatLabel = value; }

        public ComboBox Pokémon1NatureComboBox { get => pokémon1NatureComboBox; set => pokémon1NatureComboBox = value; }

        public ComboBox Pokémon1Move4ComboBox { get => pokémon1Move4ComboBox; set => pokémon1Move4ComboBox = value; }
        public ComboBox Pokémon1Move3ComboBox { get => pokémon1Move3ComboBox; set => pokémon1Move3ComboBox = value; }
        public ComboBox Pokémon1Move2ComboBox { get => pokémon1Move2ComboBox; set => pokémon1Move2ComboBox = value; }
        public ComboBox Pokémon1Move1ComboBox { get => pokémon1Move1ComboBox; set => pokémon1Move1ComboBox = value; }

        public TextBox Pokémon1Move4CategoryTextBox { get => pokémon1Move4CategoryTextBox; set => pokémon1Move4CategoryTextBox = value; }
        public TextBox Pokémon1Move3CategoryTextBox { get => pokémon1Move3CategoryTextBox; set => pokémon1Move3CategoryTextBox = value; }
        public TextBox Pokémon1Move2CategoryTextBox { get => pokémon1Move2CategoryTextBox; set => pokémon1Move2CategoryTextBox = value; }
        public TextBox Pokémon1Move1CategoryTextBox { get => pokémon1Move1CategoryTextBox; set => pokémon1Move1CategoryTextBox = value; }

        public TextBox Pokémon1Move4TypeTextBox { get => pokémon1Move4TypeTextBox; set => pokémon1Move4TypeTextBox = value; }
        public TextBox Pokémon1Move3TypeTextBox { get => pokémon1Move3TypeTextBox; set => pokémon1Move3TypeTextBox = value; }
        public TextBox Pokémon1Move2TypeTextBox { get => pokémon1Move2TypeTextBox; set => pokémon1Move2TypeTextBox = value; }
        public TextBox Pokémon1Move1TypeTextBox { get => pokémon1Move1TypeTextBox; set => pokémon1Move1TypeTextBox = value; }

        public TextBox Pokémon1Move4PowerTextBox { get => pokémon1Move4PowerTextBox; set => pokémon1Move4PowerTextBox = value; }
        public TextBox Pokémon1Move3PowerTextBox { get => pokémon1Move3PowerTextBox; set => pokémon1Move3PowerTextBox = value; }
        public TextBox Pokémon1Move2PowerTextBox { get => pokémon1Move2PowerTextBox; set => pokémon1Move2PowerTextBox = value; }
        public TextBox Pokémon1Move1PowerTextBox { get => pokémon1Move1PowerTextBox; set => pokémon1Move1PowerTextBox = value; }


        /*
         * 
         * Pokémon 2
         * 
         */


        public Label Pokémon2MovesLabel { get => pokémon2MovesLabel; set => pokémon2MovesLabel = value; }
        public Button Pokémon2Move4Button { get => pokémon2Move4Button; set => pokémon2Move4Button = value; }
        public Button Pokémon2Move3Button { get => pokémon2Move3Button; set => pokémon2Move3Button = value; }
        public Button Pokémon2Move2Button { get => pokémon2Move2Button; set => pokémon2Move2Button = value; }
        public Button Pokémon2Move1Button { get => pokémon2Move1Button; set => pokémon2Move1Button = value; }

        public ComboBox Pokémon2ComboBox { get => pokémon2ComboBox; set => pokémon2ComboBox = value; }

        public NumericUpDown Pokémon2LevelNumericUpDown { get => pokémon2LevelNumericUpDown; set => pokémon2LevelNumericUpDown = value; }

        public TextBox Pokémon2Type2TextBox { get => pokémon2Type2TextBox; set => pokémon2Type2TextBox = value; }
        public TextBox Pokémon2Type1TextBox { get => pokémon2Type1TextBox; set => pokémon2Type1TextBox = value; }

        public NumericUpDown Pokémon2EVSpeNumericUpDown { get => pokémon2EVSpeNumericUpDown; set => pokémon2EVSpeNumericUpDown = value; }
        public NumericUpDown Pokémon2EVHPNumericUpDown { get => pokémon2EVHPNumericUpDown; set => pokémon2EVHPNumericUpDown = value; }
        public NumericUpDown Pokémon2EVSpDefNumericUpDown { get => pokémon2EVSpDefNumericUpDown; set => pokémon2EVSpDefNumericUpDown = value; }
        public NumericUpDown Pokémon2EVSpAtkNumericUpDown { get => pokémon2EVSpAtkNumericUpDown; set => pokémon2EVSpAtkNumericUpDown = value; }
        public NumericUpDown Pokémon2EVDefNumericUpDown { get => pokémon2EVDefNumericUpDown; set => pokémon2EVDefNumericUpDown = value; }
        public NumericUpDown Pokémon2EVAtkNumericUpDown { get => pokémon2EVAtkNumericUpDown; set => pokémon2EVAtkNumericUpDown = value; }

        public NumericUpDown Pokémon2IVSpeNumericUpDown { get => pokémon2IVSpeNumericUpDown; set => pokémon2IVSpeNumericUpDown = value; }
        public NumericUpDown Pokémon2IVSpDefNumericUpDown { get => pokémon2IVSpDefNumericUpDown; set => pokémon2IVSpDefNumericUpDown = value; }
        public NumericUpDown Pokémon2IVHPNumericUpDown { get => pokémon2IVHPNumericUpDown; set => pokémon2IVHPNumericUpDown = value; }
        public NumericUpDown Pokémon2IVSpAtkNumericUpDown { get => pokémon2IVSpAtkNumericUpDown; set => pokémon2IVSpAtkNumericUpDown = value; }
        public NumericUpDown Pokémon2IVDefNumericUpDown { get => pokémon2IVDefNumericUpDown; set => pokémon2IVDefNumericUpDown = value; }
        public NumericUpDown Pokémon2IVAtkNumericUpDown { get => pokémon2IVAtkNumericUpDown; set => pokémon2IVAtkNumericUpDown = value; }

        public TextBox Pokémon2BaseSpAtkTextBox { get => pokémon2BaseSpAtkTextBox; set => pokémon2BaseSpAtkTextBox = value; }
        public TextBox Pokémon2BaseSpDefTextBox { get => pokémon2BaseSpDefTextBox; set => pokémon2BaseSpDefTextBox = value; }
        public TextBox Pokémon2BaseSpeTextBox { get => pokémon2BaseSpeTextBox; set => pokémon2BaseSpeTextBox = value; }
        public TextBox Pokémon2BaseDefTextBox { get => pokémon2BaseDefTextBox; set => pokémon2BaseDefTextBox = value; }
        public TextBox Pokémon2BaseAtkTextBox { get => pokémon2BaseAtkTextBox; set => pokémon2BaseAtkTextBox = value; }
        public TextBox Pokémon2BaseHPTextBox { get => pokémon2BaseHPTextBox; set => pokémon2BaseHPTextBox = value; }

        public Label Pokémon2SpeStatLabel { get => pokémon2SpeStatLabel; set => pokémon2SpeStatLabel = value; }
        public Label Pokémon2SpDefStatLabel { get => pokémon2SpDefStatLabel; set => pokémon2SpDefStatLabel = value; }
        public Label Pokémon2SpAtkStatLabel { get => pokémon2SpAtkStatLabel; set => pokémon2SpAtkStatLabel = value; }
        public Label Pokémon2DefStatLabel { get => pokémon2DefStatLabel; set => pokémon2DefStatLabel = value; }
        public Label Pokémon2AtkStatLabel { get => pokémon2AtkStatLabel; set => pokémon2AtkStatLabel = value; }
        public Label Pokémon2HPStatLabel { get => pokémon2HPStatLabel; set => pokémon2HPStatLabel = value; }

        public ComboBox Pokémon2NatureComboBox { get => pokémon2NatureComboBox; set => pokémon2NatureComboBox = value; }

        public ComboBox Pokémon2Move4ComboBox { get => pokémon2Move4ComboBox; set => pokémon2Move4ComboBox = value; }
        public ComboBox Pokémon2Move3ComboBox { get => pokémon2Move3ComboBox; set => pokémon2Move3ComboBox = value; }
        public ComboBox Pokémon2Move2ComboBox { get => pokémon2Move2ComboBox; set => pokémon2Move2ComboBox = value; }
        public ComboBox Pokémon2Move1ComboBox { get => pokémon2Move1ComboBox; set => pokémon2Move1ComboBox = value; }

        public TextBox Pokémon2Move4CategoryTextBox { get => pokémon2Move4CategoryTextBox; set => pokémon2Move4CategoryTextBox = value; }
        public TextBox Pokémon2Move3CategoryTextBox { get => pokémon2Move3CategoryTextBox; set => pokémon2Move3CategoryTextBox = value; }
        public TextBox Pokémon2Move2CategoryTextBox { get => pokémon2Move2CategoryTextBox; set => pokémon2Move2CategoryTextBox = value; }
        public TextBox Pokémon2Move1CategoryTextBox { get => pokémon2Move1CategoryTextBox; set => pokémon2Move1CategoryTextBox = value; }

        public TextBox Pokémon2Move4TypeTextBox { get => pokémon2Move4TypeTextBox; set => pokémon2Move4TypeTextBox = value; }
        public TextBox Pokémon2Move3TypeTextBox { get => pokémon2Move3TypeTextBox; set => pokémon2Move3TypeTextBox = value; }
        public TextBox Pokémon2Move2TypeTextBox { get => pokémon2Move2TypeTextBox; set => pokémon2Move2TypeTextBox = value; }
        public TextBox Pokémon2Move1TypeTextBox { get => pokémon2Move1TypeTextBox; set => pokémon2Move1TypeTextBox = value; }

        public TextBox Pokémon2Move4PowerTextBox { get => pokémon2Move4PowerTextBox; set => pokémon2Move4PowerTextBox = value; }
        public TextBox Pokémon2Move3PowerTextBox { get => pokémon2Move3PowerTextBox; set => pokémon2Move3PowerTextBox = value; }
        public TextBox Pokémon2Move2PowerTextBox { get => pokémon2Move2PowerTextBox; set => pokémon2Move2PowerTextBox = value; }
        public TextBox Pokémon2Move1PowerTextBox { get => pokémon2Move1PowerTextBox; set => pokémon2Move1PowerTextBox = value; }

        #endregion

        /*
         * Events
         * 
         */

        #region Buttons
        private void pokémon1Move1Button_Click(object sender, EventArgs e)
        {
            if (Pokémon1Move1Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom1To2(Pokémon1Move1Button.Text);
            }
        }

        private void pokémon1Move2Button_Click(object sender, EventArgs e)
        {
            if (Pokémon1Move2Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom1To2(Pokémon1Move2Button.Text);
            }
        }

        private void pokémon1Move3Button_Click(object sender, EventArgs e)
        {
            if (Pokémon1Move3Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom1To2(Pokémon1Move3Button.Text);
            }
        }

        private void pokémon1Move4Button_Click(object sender, EventArgs e)
        {
            if (Pokémon1Move4Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom1To2(Pokémon1Move4Button.Text);
            }
        }

        private void pokémon2Move1Button_Click(object sender, EventArgs e)
        {
            if (Pokémon2Move1Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom2To1(Pokémon2Move1Button.Text);
            }
        }

        private void pokémon2Move2Button_Click(object sender, EventArgs e)
        {
            if (Pokémon2Move2Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom2To1(Pokémon2Move2Button.Text);
            }
        }

        private void pokémon2Move3Button_Click(object sender, EventArgs e)
        {
            if (Pokémon2Move3Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom2To1(Pokémon2Move3Button.Text);
            }
        }

        private void pokémon2Move4Button_Click(object sender, EventArgs e)
        {
            if (Pokémon2Move4Button.Text != "(No move)")
            {
                calcTextBox.Text = calculatorController.CalculateDamageFrom2To1(Pokémon2Move4Button.Text);
            }
        }

        #endregion

        #region Pokémon
        private void pokémon1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1(Pokémon1ComboBox.Text);
            UpdateAll();
        }
        private void pokémon2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2(Pokémon2ComboBox.Text);
            UpdateAll();
        }

        #region StatChanger
        /*
         * Pokémon 1
         */
        private void pokémon1LevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1Level((uint)Pokémon1LevelNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1IVHPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1HPIV((uint)Pokémon1IVHPNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1IVAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1AttackIV((uint)Pokémon1IVAtkNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1IVDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1DefenseIV((uint)Pokémon1IVDefNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1IVSpAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1SpecialAttackIV((uint)Pokémon1IVSpAtkNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1IVSpDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1SpecialDefenseIV((uint)Pokémon1IVSpDefNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1IVSpeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1SpeedIV((uint)Pokémon1IVSpeNumericUpDown.Value);
            UpdatePokémon1Stats();
        }


        private void pokémon1EVHPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1HPEV((uint)Pokémon1EVHPNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1EVAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1AttackEV((uint)Pokémon1EVAtkNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1EVDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1DefenseEV((uint)Pokémon1EVDefNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1EVSpAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1SpecialAttackEV((uint)Pokémon1EVSpAtkNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1EVSpDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1SpecialDefenseEV((uint)Pokémon1EVSpDefNumericUpDown.Value);
            UpdatePokémon1Stats();
        }
        private void pokémon1EVSpeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1SpeedEV((uint)Pokémon1EVSpeNumericUpDown.Value);
            UpdatePokémon1Stats();
        }

        private void pokémon1NatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1Nature(Pokémon1NatureComboBox.Text);
            UpdatePokémon1Stats();
        }

        /*
         * Pokémon 2
         */
        private void pokémon2LevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2Level((uint)Pokémon2LevelNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2IVHPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2HPIV((uint)Pokémon2IVHPNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2IVAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2AttackIV((uint)Pokémon2IVAtkNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2IVDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2DefenseIV((uint)Pokémon2IVDefNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2IVSpAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2SpecialAttackIV((uint)Pokémon2IVSpAtkNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2IVSpDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2SpecialDefenseIV((uint)Pokémon2IVSpDefNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2IVSpeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2SpeedIV((uint)Pokémon2IVSpeNumericUpDown.Value);
            UpdatePokémon2Stats();
        }


        private void pokémon2EVHPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2HPEV((uint)Pokémon2EVHPNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2EVAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2AttackEV((uint)Pokémon2EVAtkNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2EVDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2DefenseEV((uint)Pokémon2EVDefNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2EVSpAtkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2SpecialAttackEV((uint)Pokémon2EVSpAtkNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2EVSpDefNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2SpecialDefenseEV((uint)Pokémon2EVSpDefNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2EVSpeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2SpeedEV((uint)Pokémon2EVSpeNumericUpDown.Value);
            UpdatePokémon2Stats();
        }
        private void pokémon2NatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2Nature(Pokémon2NatureComboBox.Text);
            UpdatePokémon2Stats();
        }



        #endregion

        #region SelectMoves


        private void pokémon1Move1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1Move(Pokémon1Move1ComboBox.Text, 0);
            UpdatePokémon1Moves();
        }
        private void pokémon1Move2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1Move(Pokémon1Move2ComboBox.Text, 1);
            UpdatePokémon1Moves();
        }
        private void pokémon1Move3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1Move(Pokémon1Move3ComboBox.Text, 2);
            UpdatePokémon1Moves();
        }
        private void pokémon1Move4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon1Move(Pokémon1Move4ComboBox.Text, 3);
            UpdatePokémon1Moves();
        }



        private void pokémon2Move1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2Move(Pokémon2Move1ComboBox.Text, 0);
            UpdatePokémon2Moves();
        }
        private void pokémon2Move2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2Move(Pokémon2Move2ComboBox.Text, 1);
            UpdatePokémon2Moves();
        }
        private void pokémon2Move3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2Move(Pokémon2Move3ComboBox.Text, 2);
            UpdatePokémon2Moves();
        }
        private void pokémon2Move4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorController.ChangePokémon2Move(Pokémon2Move4ComboBox.Text, 3);
            UpdatePokémon2Moves();
        }

        #endregion

        #endregion

    }
}
