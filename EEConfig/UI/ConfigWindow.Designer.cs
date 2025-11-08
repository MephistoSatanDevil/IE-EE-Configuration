namespace EEConfig.UI
{
    partial class ConfigWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox_GraphicOptions = new CheckedListBox();
            panel_GraphicOptions = new Panel();
            panel1 = new Panel();
            label_SpeedValueDisplay = new Label();
            label2 = new Label();
            hScrollBar_GameSpeed = new HScrollBar();
            label1 = new Label();
            panel4 = new Panel();
            checkedListBox_ProgramOptionsThree = new CheckedListBox();
            checkedListBox_ProgramOptionsTwo = new CheckedListBox();
            label8 = new Label();
            checkedListBox_ProgramOptionsOne = new CheckedListBox();
            panel_Content = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            checkedListBox_ExtendedProgramConfigurationThree = new CheckedListBox();
            checkedListBox_ExtendedProgramConfigurationTwo = new CheckedListBox();
            checkedListBox_ExtendedProgramConfigurationOne = new CheckedListBox();
            label4 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            checkedListBox_MultiplayerOptions = new CheckedListBox();
            panel_GameConfigStatus = new Panel();
            label_GameConfigNameStatus = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            utilityToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            extendedConfigurationToolStripMenuItem = new ToolStripMenuItem();
            writeOptimalConfigurationToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            checkToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            openReferenceToolStripMenuItem = new ToolStripMenuItem();
            openGitHubToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog_SelectGameConfig = new OpenFileDialog();
            panel_GraphicOptions.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel_Content.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel_GameConfigStatus.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox_GraphicOptions
            // 
            checkedListBox_GraphicOptions.BackColor = SystemColors.Control;
            checkedListBox_GraphicOptions.BorderStyle = BorderStyle.None;
            checkedListBox_GraphicOptions.CheckOnClick = true;
            checkedListBox_GraphicOptions.Enabled = false;
            checkedListBox_GraphicOptions.FormattingEnabled = true;
            checkedListBox_GraphicOptions.Items.AddRange(new object[] { "Enable UI Scaling", "Show Black Space", "Hardware Mouse Cursor", "Greyscale On Pause", "Area Map Zoom", "Use Sprite Outlines", "Use Character Highlights", "Zoom Lock", "Backend", "Use Nearest Neighbour Scaling", "Window - Maximized", "Window - Fullscreen" });
            checkedListBox_GraphicOptions.Location = new Point(10, 31);
            checkedListBox_GraphicOptions.Margin = new Padding(2);
            checkedListBox_GraphicOptions.Name = "checkedListBox_GraphicOptions";
            checkedListBox_GraphicOptions.Size = new Size(211, 216);
            checkedListBox_GraphicOptions.TabIndex = 1;
            checkedListBox_GraphicOptions.ItemCheck += CheckedListBox_GraphicOptions_ItemCheck;
            // 
            // panel_GraphicOptions
            // 
            panel_GraphicOptions.BorderStyle = BorderStyle.FixedSingle;
            panel_GraphicOptions.Controls.Add(panel1);
            panel_GraphicOptions.Controls.Add(label1);
            panel_GraphicOptions.Controls.Add(checkedListBox_GraphicOptions);
            panel_GraphicOptions.Location = new Point(6, 22);
            panel_GraphicOptions.Margin = new Padding(2);
            panel_GraphicOptions.Name = "panel_GraphicOptions";
            panel_GraphicOptions.Size = new Size(231, 367);
            panel_GraphicOptions.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label_SpeedValueDisplay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(hScrollBar_GameSpeed);
            panel1.Location = new Point(10, 261);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 83);
            panel1.TabIndex = 3;
            // 
            // label_SpeedValueDisplay
            // 
            label_SpeedValueDisplay.Dock = DockStyle.Bottom;
            label_SpeedValueDisplay.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic);
            label_SpeedValueDisplay.Location = new Point(0, 56);
            label_SpeedValueDisplay.Margin = new Padding(2, 0, 2, 0);
            label_SpeedValueDisplay.Name = "label_SpeedValueDisplay";
            label_SpeedValueDisplay.Size = new Size(209, 25);
            label_SpeedValueDisplay.TabIndex = 5;
            label_SpeedValueDisplay.Text = "30 AI Updates / Sec";
            label_SpeedValueDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 3, 0, 0);
            label2.Size = new Size(209, 22);
            label2.TabIndex = 4;
            label2.Text = "GAME SPEED";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // hScrollBar_GameSpeed
            // 
            hScrollBar_GameSpeed.Enabled = false;
            hScrollBar_GameSpeed.Location = new Point(5, 31);
            hScrollBar_GameSpeed.Maximum = 69;
            hScrollBar_GameSpeed.Minimum = 15;
            hScrollBar_GameSpeed.Name = "hScrollBar_GameSpeed";
            hScrollBar_GameSpeed.Size = new Size(199, 26);
            hScrollBar_GameSpeed.TabIndex = 3;
            hScrollBar_GameSpeed.Value = 30;
            hScrollBar_GameSpeed.ValueChanged += HScrollBar_GameSpeed_ValueChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 2;
            label1.Text = "GRAPHICS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(checkedListBox_ProgramOptionsThree);
            panel4.Controls.Add(checkedListBox_ProgramOptionsTwo);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(checkedListBox_ProgramOptionsOne);
            panel4.Location = new Point(256, 23);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 366);
            panel4.TabIndex = 4;
            // 
            // checkedListBox_ProgramOptionsThree
            // 
            checkedListBox_ProgramOptionsThree.BackColor = SystemColors.Control;
            checkedListBox_ProgramOptionsThree.BorderStyle = BorderStyle.None;
            checkedListBox_ProgramOptionsThree.CheckOnClick = true;
            checkedListBox_ProgramOptionsThree.Enabled = false;
            checkedListBox_ProgramOptionsThree.FormattingEnabled = true;
            checkedListBox_ProgramOptionsThree.Items.AddRange(new object[] { "Show Message Box Hint", "Show Learnable Spells", "Duplicate Floating Text", "Show AOE", "Render Travel Regions", "Quick Item Mapping", "Journal Popups", "Hotkeys On Tooltips", "All Learn Spell Info", "Equipment Comparison", "Confirm Dialog", "Suppress Extra Difficulty Damage", "Over Confirm Everything", "Tutorial State", "Filter Games", "Auto Pause State", "Cloud Saves Enabled", "Active Campaign" });
            checkedListBox_ProgramOptionsThree.Location = new Point(485, 29);
            checkedListBox_ProgramOptionsThree.Margin = new Padding(2);
            checkedListBox_ProgramOptionsThree.Name = "checkedListBox_ProgramOptionsThree";
            checkedListBox_ProgramOptionsThree.Size = new Size(211, 324);
            checkedListBox_ProgramOptionsThree.TabIndex = 4;
            checkedListBox_ProgramOptionsThree.ItemCheck += CheckedListBox_ProgramOptionsThree_ItemCheck;
            // 
            // checkedListBox_ProgramOptionsTwo
            // 
            checkedListBox_ProgramOptionsTwo.BackColor = SystemColors.Control;
            checkedListBox_ProgramOptionsTwo.BorderStyle = BorderStyle.None;
            checkedListBox_ProgramOptionsTwo.CheckOnClick = true;
            checkedListBox_ProgramOptionsTwo.Enabled = false;
            checkedListBox_ProgramOptionsTwo.FormattingEnabled = true;
            checkedListBox_ProgramOptionsTwo.Items.AddRange(new object[] { "Nightmare Bonus Gold", "Always Dither", "HP Over Head", "Footsteps", "Attack Sounds", "Expire Trap Highlights", "Critical Hit Screen Shake", "Subtitles", "Combat UI", "Render Actions", "Environmental Audio", "Weather", "Classic Selection Circles", "Heal Party On Rest", "Terrain Hugging", "Color Circles", "Extra Feedback", "Cleric Ranger Spells" });
            checkedListBox_ProgramOptionsTwo.Location = new Point(258, 30);
            checkedListBox_ProgramOptionsTwo.Margin = new Padding(2);
            checkedListBox_ProgramOptionsTwo.Name = "checkedListBox_ProgramOptionsTwo";
            checkedListBox_ProgramOptionsTwo.Size = new Size(211, 324);
            checkedListBox_ProgramOptionsTwo.TabIndex = 3;
            checkedListBox_ProgramOptionsTwo.ItemCheck += CheckedListBox_ProgramOptionsTwo_ItemCheck;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(725, 28);
            label8.TabIndex = 2;
            label8.Text = "PROGRAM";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox_ProgramOptionsOne
            // 
            checkedListBox_ProgramOptionsOne.BackColor = SystemColors.Control;
            checkedListBox_ProgramOptionsOne.BorderStyle = BorderStyle.None;
            checkedListBox_ProgramOptionsOne.CheckOnClick = true;
            checkedListBox_ProgramOptionsOne.Enabled = false;
            checkedListBox_ProgramOptionsOne.FormattingEnabled = true;
            checkedListBox_ProgramOptionsOne.Items.AddRange(new object[] { "Translucent Shadows", "Never Show Nuisance SOD", "Display Subtitles", "Sprite Mirror", "Drop Capitals", "3D Acceleration", "Debug Mode", "Disable Cosmetic Attacks", "Pausing Map", "Ranged Weapon Switching", "Nightmare Bonus XP", "Auto Pause Center", "Maximum HP", "Show Character HP", "No Difficulty Based XP Bonus", "Infravision", "Render Explored Map", "3E Thief Sneak Attack" });
            checkedListBox_ProgramOptionsOne.Location = new Point(30, 30);
            checkedListBox_ProgramOptionsOne.Margin = new Padding(2);
            checkedListBox_ProgramOptionsOne.Name = "checkedListBox_ProgramOptionsOne";
            checkedListBox_ProgramOptionsOne.Size = new Size(211, 324);
            checkedListBox_ProgramOptionsOne.TabIndex = 1;
            checkedListBox_ProgramOptionsOne.ItemCheck += CheckedListBox_ProgramOptionsOne_ItemCheck;
            // 
            // panel_Content
            // 
            panel_Content.Controls.Add(panel6);
            panel_Content.Controls.Add(panel3);
            panel_Content.Controls.Add(panel_GameConfigStatus);
            panel_Content.Controls.Add(label3);
            panel_Content.Controls.Add(panel4);
            panel_Content.Controls.Add(panel_GraphicOptions);
            panel_Content.Controls.Add(menuStrip1);
            panel_Content.Location = new Point(2, 2);
            panel_Content.Margin = new Padding(2);
            panel_Content.Name = "panel_Content";
            panel_Content.Size = new Size(989, 588);
            panel_Content.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(256, 407);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(727, 146);
            panel6.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkedListBox_ExtendedProgramConfigurationThree);
            panel2.Controls.Add(checkedListBox_ExtendedProgramConfigurationTwo);
            panel2.Controls.Add(checkedListBox_ExtendedProgramConfigurationOne);
            panel2.Location = new Point(-1, 30);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 114);
            panel2.TabIndex = 5;
            // 
            // checkedListBox_ExtendedProgramConfigurationThree
            // 
            checkedListBox_ExtendedProgramConfigurationThree.BackColor = SystemColors.Control;
            checkedListBox_ExtendedProgramConfigurationThree.BorderStyle = BorderStyle.None;
            checkedListBox_ExtendedProgramConfigurationThree.CheckOnClick = true;
            checkedListBox_ExtendedProgramConfigurationThree.Enabled = false;
            checkedListBox_ExtendedProgramConfigurationThree.FormattingEnabled = true;
            checkedListBox_ExtendedProgramConfigurationThree.Items.AddRange(new object[] { "Show Triggers On Tab", "Show Date On Pause", "Reverse Mouse Wheel Zoom", "Super Atomic Speed Fighting Action" });
            checkedListBox_ExtendedProgramConfigurationThree.Location = new Point(476, 19);
            checkedListBox_ExtendedProgramConfigurationThree.Margin = new Padding(2);
            checkedListBox_ExtendedProgramConfigurationThree.Name = "checkedListBox_ExtendedProgramConfigurationThree";
            checkedListBox_ExtendedProgramConfigurationThree.Size = new Size(224, 72);
            checkedListBox_ExtendedProgramConfigurationThree.TabIndex = 6;
            checkedListBox_ExtendedProgramConfigurationThree.ItemCheck += CheckedListBox_ExtendedProgramConfigurationThree_ItemCheck;
            // 
            // checkedListBox_ExtendedProgramConfigurationTwo
            // 
            checkedListBox_ExtendedProgramConfigurationTwo.BackColor = SystemColors.Control;
            checkedListBox_ExtendedProgramConfigurationTwo.BorderStyle = BorderStyle.None;
            checkedListBox_ExtendedProgramConfigurationTwo.CheckOnClick = true;
            checkedListBox_ExtendedProgramConfigurationTwo.Enabled = false;
            checkedListBox_ExtendedProgramConfigurationTwo.FormattingEnabled = true;
            checkedListBox_ExtendedProgramConfigurationTwo.Items.AddRange(new object[] { "Enable Fog", "Extra Combat Info", "Force Dialog Pause", "Enhanced Path Search" });
            checkedListBox_ExtendedProgramConfigurationTwo.Location = new Point(250, 19);
            checkedListBox_ExtendedProgramConfigurationTwo.Margin = new Padding(2);
            checkedListBox_ExtendedProgramConfigurationTwo.Name = "checkedListBox_ExtendedProgramConfigurationTwo";
            checkedListBox_ExtendedProgramConfigurationTwo.Size = new Size(224, 72);
            checkedListBox_ExtendedProgramConfigurationTwo.TabIndex = 5;
            checkedListBox_ExtendedProgramConfigurationTwo.ItemCheck += CheckedListBox_ExtendedProgramConfigurationTwo_ItemCheck;
            // 
            // checkedListBox_ExtendedProgramConfigurationOne
            // 
            checkedListBox_ExtendedProgramConfigurationOne.BackColor = SystemColors.Control;
            checkedListBox_ExtendedProgramConfigurationOne.BorderStyle = BorderStyle.None;
            checkedListBox_ExtendedProgramConfigurationOne.CheckOnClick = true;
            checkedListBox_ExtendedProgramConfigurationOne.Enabled = false;
            checkedListBox_ExtendedProgramConfigurationOne.FormattingEnabled = true;
            checkedListBox_ExtendedProgramConfigurationOne.Items.AddRange(new object[] { "Disable Movies", "UI Edit Mode", "Strref On", "Disable Footsteps During Combat" });
            checkedListBox_ExtendedProgramConfigurationOne.Location = new Point(22, 19);
            checkedListBox_ExtendedProgramConfigurationOne.Margin = new Padding(2);
            checkedListBox_ExtendedProgramConfigurationOne.Name = "checkedListBox_ExtendedProgramConfigurationOne";
            checkedListBox_ExtendedProgramConfigurationOne.Size = new Size(224, 72);
            checkedListBox_ExtendedProgramConfigurationOne.TabIndex = 4;
            checkedListBox_ExtendedProgramConfigurationOne.ItemCheck += CheckedListBox_ExtendedProgramConfigurationOne_ItemCheck;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(725, 28);
            label4.TabIndex = 3;
            label4.Text = "EXTENDED PROGRAM CONFIGURATION";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(checkedListBox_MultiplayerOptions);
            panel3.Location = new Point(6, 408);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 73);
            panel3.TabIndex = 4;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(229, 28);
            label9.TabIndex = 2;
            label9.Text = "MULTIPLAYER";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox_MultiplayerOptions
            // 
            checkedListBox_MultiplayerOptions.BackColor = SystemColors.Control;
            checkedListBox_MultiplayerOptions.BorderStyle = BorderStyle.None;
            checkedListBox_MultiplayerOptions.CheckOnClick = true;
            checkedListBox_MultiplayerOptions.Enabled = false;
            checkedListBox_MultiplayerOptions.FormattingEnabled = true;
            checkedListBox_MultiplayerOptions.Items.AddRange(new object[] { "Disable Banters", "Enable Chat Menu" });
            checkedListBox_MultiplayerOptions.Location = new Point(10, 30);
            checkedListBox_MultiplayerOptions.Margin = new Padding(2);
            checkedListBox_MultiplayerOptions.Name = "checkedListBox_MultiplayerOptions";
            checkedListBox_MultiplayerOptions.Size = new Size(211, 36);
            checkedListBox_MultiplayerOptions.TabIndex = 1;
            checkedListBox_MultiplayerOptions.ItemCheck += CheckedListBox_MultiplayerOptions_ItemCheck;
            // 
            // panel_GameConfigStatus
            // 
            panel_GameConfigStatus.BorderStyle = BorderStyle.FixedSingle;
            panel_GameConfigStatus.Controls.Add(label_GameConfigNameStatus);
            panel_GameConfigStatus.Location = new Point(6, 493);
            panel_GameConfigStatus.Margin = new Padding(2);
            panel_GameConfigStatus.Name = "panel_GameConfigStatus";
            panel_GameConfigStatus.Size = new Size(231, 60);
            panel_GameConfigStatus.TabIndex = 6;
            // 
            // label_GameConfigNameStatus
            // 
            label_GameConfigNameStatus.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            label_GameConfigNameStatus.ForeColor = Color.Red;
            label_GameConfigNameStatus.Location = new Point(0, 0);
            label_GameConfigNameStatus.Margin = new Padding(2, 0, 2, 0);
            label_GameConfigNameStatus.Name = "label_GameConfigNameStatus";
            label_GameConfigNameStatus.Size = new Size(229, 58);
            label_GameConfigNameStatus.TabIndex = 0;
            label_GameConfigNameStatus.Text = "CONFIGURATION NOT FOUND";
            label_GameConfigNameStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(0, 553);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(989, 35);
            label3.TabIndex = 5;
            label3.Text = "All changes are saved automatically.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { utilityToolStripMenuItem, backupToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(989, 25);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // utilityToolStripMenuItem
            // 
            utilityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, extendedConfigurationToolStripMenuItem, writeOptimalConfigurationToolStripMenuItem, closeToolStripMenuItem });
            utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            utilityToolStripMenuItem.Size = new Size(52, 21);
            utilityToolStripMenuItem.Text = "Utility";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(240, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += RefreshToolStripMenuItem_Click;
            // 
            // extendedConfigurationToolStripMenuItem
            // 
            extendedConfigurationToolStripMenuItem.Name = "extendedConfigurationToolStripMenuItem";
            extendedConfigurationToolStripMenuItem.Size = new Size(240, 22);
            extendedConfigurationToolStripMenuItem.Text = "Additional Options";
            extendedConfigurationToolStripMenuItem.Visible = false;
            extendedConfigurationToolStripMenuItem.Click += ExtendedConfigurationToolStripMenuItem_Click;
            // 
            // writeOptimalConfigurationToolStripMenuItem
            // 
            writeOptimalConfigurationToolStripMenuItem.Name = "writeOptimalConfigurationToolStripMenuItem";
            writeOptimalConfigurationToolStripMenuItem.Size = new Size(240, 22);
            writeOptimalConfigurationToolStripMenuItem.Text = "Write Optimal Configuration";
            writeOptimalConfigurationToolStripMenuItem.Click += WriteOptimalConfigurationToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(240, 22);
            closeToolStripMenuItem.Text = "Exit";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkToolStripMenuItem, createToolStripMenuItem, restoreToolStripMenuItem });
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(63, 21);
            backupToolStripMenuItem.Text = "Backup";
            // 
            // checkToolStripMenuItem
            // 
            checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            checkToolStripMenuItem.Size = new Size(121, 22);
            checkToolStripMenuItem.Text = "Check";
            checkToolStripMenuItem.Click += CheckToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(121, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // restoreToolStripMenuItem
            // 
            restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            restoreToolStripMenuItem.Size = new Size(121, 22);
            restoreToolStripMenuItem.Text = "Restore";
            restoreToolStripMenuItem.Click += RestoreToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openReferenceToolStripMenuItem, openGitHubToolStripMenuItem, aboutToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 21);
            helpToolStripMenuItem.Text = "Help";
            // 
            // openReferenceToolStripMenuItem
            // 
            openReferenceToolStripMenuItem.Name = "openReferenceToolStripMenuItem";
            openReferenceToolStripMenuItem.Size = new Size(170, 22);
            openReferenceToolStripMenuItem.Text = "Open Reference";
            openReferenceToolStripMenuItem.Click += OpenReferenceToolStripMenuItem_Click;
            // 
            // openGitHubToolStripMenuItem
            // 
            openGitHubToolStripMenuItem.Name = "openGitHubToolStripMenuItem";
            openGitHubToolStripMenuItem.Size = new Size(170, 22);
            openGitHubToolStripMenuItem.Text = "Open GitHub";
            openGitHubToolStripMenuItem.Click += OpenGitHubToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(170, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += AboutToolStripMenuItem1_Click;
            // 
            // openFileDialog_SelectGameConfig
            // 
            openFileDialog_SelectGameConfig.DefaultExt = "ini";
            openFileDialog_SelectGameConfig.FileName = "Baldur.lua";
            openFileDialog_SelectGameConfig.Filter = "Lua Files|*.lua";
            // 
            // ConfigWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 589);
            Controls.Add(panel_Content);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "ConfigWindow";
            Load += ConfigWindow_Load;
            panel_GraphicOptions.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel_Content.ResumeLayout(false);
            panel_Content.PerformLayout();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel_GameConfigStatus.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox_GraphicOptions;
        private Panel panel_GraphicOptions;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private HScrollBar hScrollBar_GameSpeed;
        private Label label_SpeedValueDisplay;
        private Panel panel4;
        private CheckedListBox checkedListBox_ProgramOptionsTwo;
        private Label label8;
        private CheckedListBox checkedListBox_ProgramOptionsOne;
        private Panel panel_Content;
        private Label label3;
        private Panel panel_GameConfigStatus;
        private Label label_GameConfigNameStatus;
        private Panel panel3;
        private Label label9;
        private CheckedListBox checkedListBox_MultiplayerOptions;
        private CheckedListBox checkedListBox_ProgramOptionsThree;
        private Panel panel6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem utilityToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem extendedConfigurationToolStripMenuItem;
        private ToolStripMenuItem writeOptimalConfigurationToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem checkToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Panel panel2;
        private Label label4;
        private CheckedListBox checkedListBox_ExtendedProgramConfigurationOne;
        private CheckedListBox checkedListBox_ExtendedProgramConfigurationTwo;
        private CheckedListBox checkedListBox_ExtendedProgramConfigurationThree;
        private OpenFileDialog openFileDialog_SelectGameConfig;
        private ToolStripMenuItem openGitHubToolStripMenuItem;
        private ToolStripMenuItem openReferenceToolStripMenuItem;
    }
}