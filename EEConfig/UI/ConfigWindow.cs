using EEConfig.Components;
using System.Diagnostics;
using System.Text.RegularExpressions;
using EEConfig.Properties; 

namespace EEConfig.UI
{
    public delegate void GameFoundHandler(string ShortGameName, string LongGameName);
    public delegate void UtilityClosedHandler();

    public partial class ConfigWindow : BaseWindow
    {
        private ApplicationConfigurationData Config = new();

        private string ConfigFileName => "Baldur.lua";

        private ConfigBackupManager? ConfigBackupManager { get; set; }
        private BaldurPropertyManager? BaldurPropertyManager { get; set; }

        public event GameFoundHandler? GameFound;
        public event UtilityClosedHandler? UtilityClosed;


        readonly Dictionary<int, string> Graphics_Properties = new()
        {
            { 0, "Graphics,Scale UI" },
            { 1, "Graphics,Show Black Space" },
            { 2, "Graphics,Hardware Mouse Cursor" },
            { 3, "Graphics,Greyscale On Pause" },
            { 4, "Graphics,Area Map Zoom" },
            { 5, "Graphics,Use Sprite Outlines" },
            { 6, "Graphics,Use Character Highlights" },
            { 7, "Graphics,Zoom Lock" },
            { 8, "Graphics,Backend" },
            { 9, "Graphics,Use Nearest Neighbour Scaling" },
            { 10, "Graphics,Maximized" },
            { 11, "Graphics,Full Screen" }
        };

        readonly Dictionary<int, string> Multiplayer_Properties = new()
        {
            { 0, "Multiplayer,Disable Banters" },
            { 1, "Multiplayer,Enable Chat Menu" }
        };

        readonly Dictionary<int, string> ProgramOptionsOne_Properties = new()
        {
            { 0, "Program Options,Translucent Shadows" },
            { 1, "Program Options,Never Show Nuisance SOD" },
            { 2, "Program Options,Display Subtitles" },
            { 3, "Program Options,Sprite Mirror" },
            { 4, "Program Options,Drop Capitals" },
            { 5, "Program Options,3D Acceleration" },
            { 6, "Program Options,Debug Mode" },
            { 7, "Program Options,Disable Cosmetic Attacks" },
            { 8, "Game Options,Pausing Map" },
            { 9, "Game Options,Ranged Weapon Switching" },
            { 10, "Game Options,Nightmare Bonus XP" },
            { 11, "Game Options,Auto Pause Center" },
            { 12, "Game Options,Maximum HP" },
            { 13, "Game Options,Show Character HP" },
            { 14, "Game Options,No Difficulty Based XP Bonus" },
            { 15, "Game Options,Infravision" },
            { 16, "Game Options,Render Explored Map" },
            { 17, "Game Options,3E Thief Sneak Attack" }
        };

        readonly Dictionary<int, string> ProgramOptionsTwo_Properties = new()
        {
            { 0, "Game Options,Nightmare Bonus Gold" },
            { 1, "Game Options,Always Dither" },
            { 2, "Game Options,HP Over Head" },
            { 3, "Game Options,Footsteps" },
            { 4, "Game Options,Attack Sounds" },
            { 5, "Game Options,Expire Trap Highlights" },
            { 6, "Game Options,Critical Hit Screen Shake" },
            { 7, "Game Options,Subtitles" },
            { 8, "Game Options,Combat UI" },
            { 9, "Game Options,Render Actions" },
            { 10, "Game Options,Environmental Audio" },
            { 11, "Game Options,Weather" },
            { 12, "Game Options,Classic Selection Circles" },
            { 13, "Game Options,Heal Party on Rest" },
            { 14, "Game Options,Terrain Hugging" },
            { 15, "Game Options,Color Circles" },
            { 16, "Game Options,Extra Feedback" },
            { 17, "Game Options,Cleric Ranger Spells" }
        };

        readonly Dictionary<int, string> ProgramOptionsThree_Properties = new()
        {
            { 0, "Game Options,Show Message Box Hint" },
            { 1, "Game Options,Show Learnable Spells" },
            { 2, "Game Options,Duplicate Floating Text" },
            { 3, "Game Options,Show AOE" },
            { 4, "Game Options,Render Travel Regions" },
            { 5, "Game Options,Quick Item Mapping" },
            { 6, "Game Options,Journal Popups" },
            { 7, "Game Options,Hotkeys On Tooltips" },
            { 8, "Game Options,All Learn Spell Info" },
            { 9, "Game Options,Equipment Comparison" },
            { 10, "Game Options,Confirm Dialog" },
            { 11, "Game Options,Suppress Extra Difficulty Damage" },
            { 12, "Game Options,Over Confirm Everything" },
            { 13, "Game Options,Tutorial State" },
            { 14, "Game Options,Filter Games" },
            { 15, "Game Options,Auto Pause State" },
            { 16, "Program Options,Cloud Saves Enabled" },
            { 17, "Program Options,Active Campaign" }
        };

        readonly Dictionary<int, string> ProgramOptionsExtendedOne_Properties = new()
        {
            { 0, "Program Options,Disable Movies" },
            { 1, "Program Options,UI Edit Mode" },
            { 2, "Program Options,Strref On" },
            { 3, "Game Options,Disable Foot Steps During Combat" },
        };

        readonly Dictionary<int, string> ProgramOptionsExtendedTwo_Properties = new()
        {
            { 0, "Game Options,Enable Fog" },
            { 1, "Game Options,Extra Combat Info" },
            { 2, "Game Options,Force Dialog Pause" },
            { 3, "Game Options,Enhanced Path Search" },
        };

        readonly Dictionary<int, string> ProgramOptionsExtendedThree_Properties = new()
        {
            { 0, "Game Options,Show Triggers On Tab" },
            { 1, "Game Options,Show Date On Pause" },
            { 2, "Game Options,Reverse Mouse Wheel Zoom" },
            { 3, "Game Options,Super Atomic Speed Fighting Action" },
        };

        public ConfigWindow()
        {
            InitializeComponent();
        }
        public string ShortGameName { get; private set; } = "";
        public string LongGameName { get; private set; } = "";
        // Methods

        private bool BackupConfiguration(bool overwrite)
        {
            if (BaldurPropertyManager is not null && ConfigBackupManager is not null && BaldurPropertyManager.ConfigFileExists)
            {
                try
                {
                    return ConfigBackupManager.CreateBackup(null, overwrite);
                }
                catch (Exception ex)
                {
                    Logger.LogLine($"Error during backup creation: {ex.Message}", LogType.Exception);
                    return false;
                }
            }

            return false;
        }

        private void UpdateUI()
        {
            if (BaldurPropertyManager is not null && BaldurPropertyManager.ConfigFileExists)
            {
                // Update game speed

                int gameSpeed = 30;

                if (BaldurPropertyManager.GetProperty("Maximum Frame Rate", out var Speed))
                {
                    gameSpeed = Convert.ToInt32(Speed);

                    if (gameSpeed > hScrollBar_GameSpeed.Maximum)
                        gameSpeed = 60;
                    else if (gameSpeed < hScrollBar_GameSpeed.Minimum)
                        gameSpeed = 15;
                }

                hScrollBar_GameSpeed.Value = gameSpeed;
                label_SpeedValueDisplay.Text = string.Format(Resources.SpeedValueDisplayFormat, gameSpeed);

                // Update the blocks

                Dictionary<CheckedListBox, Dictionary<int, string>> blocks = new()
                {
                    { checkedListBox_GraphicOptions, Graphics_Properties },
                    { checkedListBox_MultiplayerOptions, Multiplayer_Properties },
                    { checkedListBox_ProgramOptionsOne, ProgramOptionsOne_Properties },
                    { checkedListBox_ProgramOptionsTwo, ProgramOptionsTwo_Properties },
                    { checkedListBox_ProgramOptionsThree, ProgramOptionsThree_Properties },
                    { checkedListBox_ExtendedProgramConfigurationOne, ProgramOptionsExtendedOne_Properties},
                    { checkedListBox_ExtendedProgramConfigurationTwo, ProgramOptionsExtendedTwo_Properties},
                    { checkedListBox_ExtendedProgramConfigurationThree, ProgramOptionsExtendedThree_Properties }
                };

                foreach (var block in blocks)
                {
                    foreach (var propertyString in block.Value)
                    {
                        bool status = false;

                        if (BaldurPropertyManager.GetProperty(BaldurPropertyManager.GetPropertyName(propertyString.Value), out var value))
                        {
                            status = Convert.ToBoolean(Convert.ToInt16(value));
                        }

                        block.Key.SetItemChecked(propertyString.Key, status);
                    }
                }
            }
        }

        private string? LocateGameConfig()
        {
            try
            {
                string currentDirectory = Environment.CurrentDirectory;
                string engineLuaPath = Path.Combine(currentDirectory, "engine.lua");

                if (File.Exists(engineLuaPath))
                {
                    string engineLuaContent = File.ReadAllText(engineLuaPath);

                    var nameMatch = Regex.Match(engineLuaContent, @"engine_name\s*=\s*""([^""]*)""");
                    var modeMatch = Regex.Match(engineLuaContent, @"engine_mode\s*=\s*(\d+)");

                    if (nameMatch.Success && modeMatch.Success)
                    {
                        string longName = nameMatch.Groups[1].Value;
                        if (int.TryParse(modeMatch.Groups[1].Value, out int modeValue))
                        {
                            string shortName = GetShortGameNameFromMode(modeValue, longName);
                            if (!string.IsNullOrEmpty(shortName))
                            {
                                LongGameName = longName;
                                ShortGameName = shortName;

                                var basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                            LongGameName,
                                                            ConfigFileName);

                                if (File.Exists(basePath))
                                {
                                    Console.WriteLine($"Located {ConfigFileName} via engine.lua at: {basePath}");
                                    return basePath;
                                }
                                else
                                {
                                    Console.WriteLine($"Parsed path from engine.lua does not exist: {basePath}");
                                }
                            }
                            else
                            {
                                Msg.Error(string.Format(Resources.Error_UnknownEngineMode, modeValue));
                            }
                        }
                        else
                        {
                            Msg.Error(Resources.MsgText_CouldNotParseEngineMode);
                        }
                    }
                    else
                    {
                        Msg.Error(Resources.MsgText_CouldNotFindEngineNameOrMode);
                    }
                }
                else
                {
                    Console.WriteLine("engine.lua not found in current directory.");
                }

                Msg.Information(string.Format(Resources.MsgText_CannotLocateConfigManuallySelect, ConfigFileName));

                if (openFileDialog_SelectGameConfig.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog_SelectGameConfig.FileName;

                    if (Path.GetFileName(selectedFilePath) == ConfigFileName)
                    {
                        string configDirectory = Path.GetDirectoryName(selectedFilePath);
                        string potentialLongName = Path.GetFileName(configDirectory);

                        string potentialShortName = GetShortGameNameFromLongName(potentialLongName);

                        if (!string.IsNullOrEmpty(potentialShortName) && !string.IsNullOrEmpty(potentialLongName))
                        {
                            LongGameName = potentialLongName;
                            ShortGameName = potentialShortName;
                            Console.WriteLine($"Inferred Game Names from path - Short: {ShortGameName}, Long: {LongGameName}");
                        }
                        else
                        {
                            Msg.Warning(string.Format(Resources.MsgText_CouldNotInferGameName, configDirectory));
                            LongGameName = "Unknown Game Directory";
                            ShortGameName = "Unknown";
                        }

                        return selectedFilePath;
                    }
                    else
                    {
                        Console.WriteLine($"Selected file is not {ConfigFileName}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message, LogType.Exception);
                Msg.Error(string.Format(Resources.MsgText_ConfigLocateError, ex.Message));
            }

            return null;
        }
        private string GetShortGameNameFromLongName(string longName)
        {
            if (string.IsNullOrEmpty(longName))
                return "";

            string lowerLongName = longName.ToLowerInvariant();

            if (lowerLongName.Contains("baldur's gate") || lowerLongName.Contains("bg1")) // BG1:EE, BG:EE, Baldur's Gate - Enhanced Edition
            {
                if (lowerLongName.Contains("ee") && !lowerLongName.Contains("2")) // Explicitly check for EE and not 2
                {
                    // Check for EET specific strings within BG related names
                    if (lowerLongName.Contains("tetralogy") || lowerLongName.Contains("trilogy") || lowerLongName.Contains("eet"))
                    {
                        return "EET"; // Although EET often uses BG2's lua, this handles the BG1 part if applicable
                    }
                    return "BG1:EE";
                }
                // Fallback if contains "baldur's gate" but not explicitly "ee" or "2"
                // This might be ambiguous, adjust logic if needed
                // For now, assume BG1:EE if it's just "Baldur's Gate"
                if (!lowerLongName.Contains("2") && !lowerLongName.Contains("tutu") && !lowerLongName.Contains("bgt")) // Avoid BG2, Tutu, BGT
                {
                    return "BG1:EE";
                }
            }
            else if (lowerLongName.Contains("baldur's gate 2") || lowerLongName.Contains("bg2") || lowerLongName.Contains("soa") || lowerLongName.Contains("toi")) // BG2:EE, SoA, ToB, BG2 - Enhanced Edition
            {
                // Check for EET specific strings
                if (lowerLongName.Contains("tetralogy") || lowerLongName.Contains("trilogy") || lowerLongName.Contains("eet"))
                {
                    return "EET";
                }
                return "BG2:EE";
            }
            else if (lowerLongName.Contains("icewind dale") || lowerLongName.Contains("iwd1")) // IWD1:EE, Icewind Dale - Enhanced Edition
            {
                if (lowerLongName.Contains("ee"))
                {
                    return "IWD1:EE";
                }
                // Fallback for "icewind dale" without "ee"
                // Could be ambiguous, assume IWD1:EE if no other indicator
                return "IWD1:EE";
            }
            else if (lowerLongName.Contains("planescape") || lowerLongName.Contains("torment") || lowerLongName.Contains("pst")) // PST:EE, PST - Enhanced Edition
            {
                if (lowerLongName.Contains("ee"))
                {
                    return "PST:EE";
                }
                // Fallback for "planescape" or "torment" without "ee"
                // Could be ambiguous, assume PST:EE if no other indicator
                return "PST:EE";
            }

            return "";
        }
        private string GetShortGameNameFromMode(int mode, string longName)
        {
            if (mode == 1 && !string.IsNullOrEmpty(longName) &&
                (longName.Contains("Tetralogy") || longName.Contains("Trilogy") || longName.Contains("EET")))
            {
                return "EET";
            }

            return mode switch
            {
                0 => "BG1:EE",
                1 => "BG2:EE",
                2 => "IWD1:EE",
                3 => "PST:EE",
                _ => ""
            };
        }

        // Event handlers

        private void HScrollBar_GameSpeed_ValueChanged(object sender, EventArgs e)
        {
            var selectedSpeedValue = ((HScrollBar)sender).Value.ToString();

            // Update UI
            label_SpeedValueDisplay.Text = $"{selectedSpeedValue}{Resources.LabelText_AIUpdatesPerSecond}";

            // Update value
            BaldurPropertyManager?.SetProperty("Program Options", "Maximum Frame Rate", selectedSpeedValue);
        }

        private void ConfigWindow_Load(object sender, EventArgs e)
        {

            Config.BaldurLuaPath = LocateGameConfig();
            ApplicationConfiguration.Write(Config);


            if (string.IsNullOrEmpty(Config.BaldurLuaPath))
            {
                string gameInfo = string.IsNullOrEmpty(ShortGameName) ? Resources.TheGame : ShortGameName;
                Msg.Information(string.Format(Resources.MsgText_ConfigNotFound, gameInfo));

                Application.Exit();
            }
            else
            {
                try
                {
                    ConfigBackupManager = new(Config.BaldurLuaPath, "Configuration");
                    BaldurPropertyManager = new(Config.BaldurLuaPath);

                    Text = string.Format(Resources.WindowTitle, ShortGameName);

                    GameFound += ConfigWindow_GameFound;
                    UtilityClosed += ConfigWindow_UtilityClosed;

                    if (BaldurPropertyManager != null && BaldurPropertyManager.ConfigFileExists)
                    {
                        label_GameConfigNameStatus.Text = Resources.Status_ConfigurationFound;
                        label_GameConfigNameStatus.ForeColor = Color.Green;

                        GameFound?.Invoke(ShortGameName, LongGameName);
                    }
                    else
                    {
                        label_GameConfigNameStatus.Text = Resources.Status_ConfigurationNotFound;
                        label_GameConfigNameStatus.ForeColor = Color.Red;
                    }

                    if (ConfigBackupManager != null && !ConfigBackupManager.BackupExists)
                    {
                        // Do not overwrite any existing backups on load

                        if (BackupConfiguration(false))
                            Msg.Information(Resources.MsgText_ConfigBackedUpSuccessfully);
                        else
                            Msg.Warning(Resources.MsgText_ConfigNotBackedUp);
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogLine($"Error initializing BaldurPropertyManager or ConfigBackupManager: {ex.Message}", LogType.Exception);
                    Msg.Error(Resources.MsgText_InitManagersFailed);
                    Application.Exit();
                }
            }
            label1.Text = Resources.PanelTitle_Graphics;
            label2.Text = Resources.PanelTitle_GameSpeed;
            label8.Text = Resources.PanelTitle_Program;
            label4.Text = Resources.PanelTitle_ExtendedProgramConfiguration;
            label9.Text = Resources.PanelTitle_Multiplayer;
            label3.Text = Resources.FooterText_ChangesSavedAutomatically;

            utilityToolStripMenuItem.Text = Resources.MenuItem_Utility;
            refreshToolStripMenuItem.Text = Resources.MenuItem_Refresh;
            extendedConfigurationToolStripMenuItem.Text = Resources.MenuItem_AdditionalOptions;
            writeOptimalConfigurationToolStripMenuItem.Text = Resources.MenuItem_WriteOptimalConfiguration;
            closeToolStripMenuItem.Text = Resources.MenuItem_Exit;

            backupToolStripMenuItem.Text = Resources.MenuItem_Backup;
            checkToolStripMenuItem.Text = Resources.MenuItem_Check;
            createToolStripMenuItem.Text = Resources.MenuItem_Create;
            restoreToolStripMenuItem.Text = Resources.MenuItem_Restore;

            helpToolStripMenuItem.Text = Resources.MenuItem_Help;
            openReferenceToolStripMenuItem.Text = Resources.MenuItem_OpenReference;
            openGitHubToolStripMenuItem.Text = Resources.MenuItem_OpenGitHub;
            aboutToolStripMenuItem1.Text = Resources.MenuItem_About;

            checkedListBox_GraphicOptions.Items.Clear();
            checkedListBox_GraphicOptions.Items.AddRange(new object[] {
                Resources.GraphicsItem_EnableUIScaling,
                Resources.GraphicsItem_ShowBlackSpace,
                Resources.GraphicsItem_HardwareMouseCursor,
                Resources.GraphicsItem_GreyscaleOnPause,
                Resources.GraphicsItem_AreaMapZoom,
                Resources.GraphicsItem_UseSpriteOutlines,
                Resources.GraphicsItem_UseCharacterHighlights,
                Resources.GraphicsItem_ZoomLock,
                Resources.GraphicsItem_Backend,
                Resources.GraphicsItem_UseNearestNeighbourScaling,
                Resources.GraphicsItem_WindowMaximized,
                Resources.GraphicsItem_WindowFullscreen
            });

            checkedListBox_MultiplayerOptions.Items.Clear();
            checkedListBox_MultiplayerOptions.Items.AddRange(new object[] {
                Resources.MultiplayerItem_DisableBanters,
                Resources.MultiplayerItem_EnableChatMenu
            });

            checkedListBox_ProgramOptionsOne.Items.Clear();
            checkedListBox_ProgramOptionsOne.Items.AddRange(new object[] {
                Resources.ProgramOptionsOneItem_TranslucentShadows,
                Resources.ProgramOptionsOneItem_NeverShowNuisanceSOD,
                Resources.ProgramOptionsOneItem_DisplaySubtitles,
                Resources.ProgramOptionsOneItem_SpriteMirror,
                Resources.ProgramOptionsOneItem_DropCapitals,
                Resources.ProgramOptionsOneItem_3DAcceleration,
                Resources.ProgramOptionsOneItem_DebugMode,
                Resources.ProgramOptionsOneItem_DisableCosmeticAttacks,
                Resources.ProgramOptionsOneItem_PausingMap,
                Resources.ProgramOptionsOneItem_RangedWeaponSwitching,
                Resources.ProgramOptionsOneItem_NightmareBonusXP,
                Resources.ProgramOptionsOneItem_AutoPauseCenter,
                Resources.ProgramOptionsOneItem_MaximumHP,
                Resources.ProgramOptionsOneItem_ShowCharacterHP,
                Resources.ProgramOptionsOneItem_NoDifficultyBasedXPBonus,
                Resources.ProgramOptionsOneItem_Infravision,
                Resources.ProgramOptionsOneItem_RenderExploredMap,
                Resources.ProgramOptionsOneItem_3EThiefSneakAttack
            });

            checkedListBox_ProgramOptionsTwo.Items.Clear();
            checkedListBox_ProgramOptionsTwo.Items.AddRange(new object[] {
                Resources.ProgramOptionsTwoItem_NightmareBonusGold,
                Resources.ProgramOptionsTwoItem_AlwaysDither,
                Resources.ProgramOptionsTwoItem_HPOverHead,
                Resources.ProgramOptionsTwoItem_Footsteps,
                Resources.ProgramOptionsTwoItem_AttackSounds,
                Resources.ProgramOptionsTwoItem_ExpireTrapHighlights,
                Resources.ProgramOptionsTwoItem_CriticalHitScreenShake,
                Resources.ProgramOptionsTwoItem_Subtitles,
                Resources.ProgramOptionsTwoItem_CombatUI,
                Resources.ProgramOptionsTwoItem_RenderActions,
                Resources.ProgramOptionsTwoItem_EnvironmentalAudio,
                Resources.ProgramOptionsTwoItem_Weather,
                Resources.ProgramOptionsTwoItem_ClassicSelectionCircles,
                Resources.ProgramOptionsTwoItem_HealPartyOnRest,
                Resources.ProgramOptionsTwoItem_TerrainHugging,
                Resources.ProgramOptionsTwoItem_ColorCircles,
                Resources.ProgramOptionsTwoItem_ExtraFeedback,
                Resources.ProgramOptionsTwoItem_ClericRangerSpells
            });

            checkedListBox_ProgramOptionsThree.Items.Clear();
            checkedListBox_ProgramOptionsThree.Items.AddRange(new object[] {
                Resources.ProgramOptionsThreeItem_ShowMessageBoxHint,
                Resources.ProgramOptionsThreeItem_ShowLearnableSpells,
                Resources.ProgramOptionsThreeItem_DuplicateFloatingText,
                Resources.ProgramOptionsThreeItem_ShowAOE,
                Resources.ProgramOptionsThreeItem_RenderTravelRegions,
                Resources.ProgramOptionsThreeItem_QuickItemMapping,
                Resources.ProgramOptionsThreeItem_JournalPopups,
                Resources.ProgramOptionsThreeItem_HotkeysOnTooltips,
                Resources.ProgramOptionsThreeItem_AllLearnSpellInfo,
                Resources.ProgramOptionsThreeItem_EquipmentComparison,
                Resources.ProgramOptionsThreeItem_ConfirmDialog,
                Resources.ProgramOptionsThreeItem_SuppressExtraDifficultyDamage,
                Resources.ProgramOptionsThreeItem_OverConfirmEverything,
                Resources.ProgramOptionsThreeItem_TutorialState,
                Resources.ProgramOptionsThreeItem_FilterGames,
                Resources.ProgramOptionsThreeItem_AutoPauseState,
                Resources.ProgramOptionsThreeItem_CloudSavesEnabled,
                Resources.ProgramOptionsThreeItem_ActiveCampaign
            });

            checkedListBox_ExtendedProgramConfigurationOne.Items.Clear();
            checkedListBox_ExtendedProgramConfigurationOne.Items.AddRange(new object[] {
                Resources.ExtendedProgramConfigOneItem_DisableMovies,
                Resources.ExtendedProgramConfigOneItem_UIEditMode,
                Resources.ExtendedProgramConfigOneItem_StrrefOn,
                Resources.ExtendedProgramConfigOneItem_DisableFootstepsDuringCombat
            });

            checkedListBox_ExtendedProgramConfigurationTwo.Items.Clear();
            checkedListBox_ExtendedProgramConfigurationTwo.Items.AddRange(new object[] {
                Resources.ExtendedProgramConfigTwoItem_EnableFog,
                Resources.ExtendedProgramConfigTwoItem_ExtraCombatInfo,
                Resources.ExtendedProgramConfigTwoItem_ForceDialogPause,
                Resources.ExtendedProgramConfigTwoItem_EnhancedPathSearch
            });

            checkedListBox_ExtendedProgramConfigurationThree.Items.Clear();
            checkedListBox_ExtendedProgramConfigurationThree.Items.AddRange(new object[] {
                Resources.ExtendedProgramConfigThreeItem_ShowTriggersOnTab,
                Resources.ExtendedProgramConfigThreeItem_ShowDateOnPause,
                Resources.ExtendedProgramConfigThreeItem_ReverseMouseWheelZoom,
                Resources.ExtendedProgramConfigThreeItem_SuperAtomicSpeedFightingAction
            });

            if (BaldurPropertyManager != null && BaldurPropertyManager.ConfigFileExists)
            {
                UpdateUI();
            }

        }

        private void ConfigWindow_GameFound(string ShortGameName, string LongGameName)
        {
            checkedListBox_GraphicOptions.Enabled = true;
            checkedListBox_MultiplayerOptions.Enabled = true;
            checkedListBox_ProgramOptionsOne.Enabled = true;
            checkedListBox_ProgramOptionsTwo.Enabled = true;
            checkedListBox_ProgramOptionsThree.Enabled = true;
            checkedListBox_ExtendedProgramConfigurationOne.Enabled = true;
            checkedListBox_ExtendedProgramConfigurationTwo.Enabled = true;
            checkedListBox_ExtendedProgramConfigurationThree.Enabled = true;

            hScrollBar_GameSpeed.Enabled = true;

            UpdateUI();
        }

        private void ConfigWindow_UtilityClosed()
        {
            Close();
        }

        private void CheckedListBox_GraphicOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && Graphics_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_MultiplayerOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && Multiplayer_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ProgramOptionsOne_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsOne_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ProgramOptionsTwo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsTwo_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ProgramOptionsThree_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsThree_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityClosed?.Invoke();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaldurPropertyManager is not null && BaldurPropertyManager.ConfigFileExists)
            {
                UpdateUI();
                Msg.Information(Resources.MsgText_OptionStatusRefreshed);
            }
            else
            {
                Msg.Warning(Resources.MsgText_CannotRefresh);
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(Resources.MsgText_CreateBackupPrompt,
                                                    Resources.MsgText_Information,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Asterisk))
            {
                if (BackupConfiguration(true))
                {
                    Msg.Information(Resources.MsgText_BackupCreatedSuccessfully);
                    UpdateUI();
                }
                else
                {
                    Msg.Information(Resources.MsgText_BackupCreationFailed);
                }
            }
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var backupManager = ConfigBackupManager;
            if (backupManager != null)
            {
                if (backupManager.RestoreBackup())
                {
                    Msg.Information(Resources.MsgText_BackupRestoredSuccessfully);
                    UpdateUI();
                }
                else
                {
                    Msg.Information(Resources.MsgText_CannotRestoreBackup);
                }
            }
            else
            {
                Msg.Error(Resources.MsgText_CannotRestoreBackupManagersNotInit);
            }
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigBackupManager != null && ConfigBackupManager.BackupExists)
            {
                var creationTime = File.GetCreationTime(ConfigBackupManager.BackupFilePath);
                string gameNameForDisplay = string.IsNullOrEmpty(ShortGameName) ? Resources.GameName_UnknownGame : ShortGameName;
                Msg.Information(string.Format(Resources.MsgText_BackupExistsInfo, gameNameForDisplay, creationTime), Resources.MsgText_BackupStatus);
            }
            else if (ConfigBackupManager != null)
            {
                string gameNameForDisplay = string.IsNullOrEmpty(ShortGameName) ? Resources.GameName_UnknownGame : ShortGameName;
                Msg.Information(string.Format(Resources.MsgText_BackupDoesNotExistInfo, gameNameForDisplay), Resources.MsgText_BackupStatus);
            }
            else
            {
                Msg.Error(Resources.MsgText_CannotCheckBackupStatus);
            }
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void CheckedListBox_ExtendedProgramConfigurationOne_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsExtendedOne_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ExtendedProgramConfigurationTwo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsExtendedTwo_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void CheckedListBox_ExtendedProgramConfigurationThree_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (BaldurPropertyManager is not null && ProgramOptionsExtendedThree_Properties.TryGetValue(e.Index, out var s))
                BaldurPropertyManager.SetBoolean(s, e.NewValue == CheckState.Checked);

            UITools.ResetSelectedIndex((CheckedListBox)sender);
        }

        private void WriteOptimalConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaldurPropertyManager == null)
            {
                Msg.Error(Resources.MsgText_CannotAccessGameConfigProps);
                return;
            }

            var text = Resources.MsgText_WriteOptimalChangesList;

            if (DialogResult.OK == MessageBox.Show(text, Resources.MsgText_Confirmation, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                BaldurPropertyManager.SetProperty("Program Options", "Maximum Frame Rate", "40");
                BaldurPropertyManager.SetBoolean("Game Options,Disable Foot Steps During Combat", false);
                BaldurPropertyManager.SetBoolean("Game Options,Show Date On Pause", true);
                BaldurPropertyManager.SetBoolean("Game Options,Enhanced Path Search", true);
                BaldurPropertyManager.SetBoolean("Program Options,Disable Cosmetic Attacks", true);

                UpdateUI();

                Msg.Information(Resources.MsgText_ConfigurationWritten);
            }
        }

        private void ExtendedConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaldurPropertyManager == null)
            {
                Msg.Error(Resources.MsgText_CannotOpenExtendedConfig);
                return;
            }

            new AdditionalOptions(BaldurPropertyManager).ShowDialog();
        }

        private void OpenGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://github.com/Nesae-avi/IE-EE-Configuration"
            });
        }

        private void OpenReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://nesae-avi.github.io/IE-EE-Configuration/Reference"
            });
        }

    }
}