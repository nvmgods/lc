namespace RavenDevLauncher.Interface
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsScreenResolution = new System.Windows.Forms.ComboBox();
            this.settingsWindowMode = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.settingsShadowUnlimited = new System.Windows.Forms.RadioButton();
            this.settingsShadow10 = new System.Windows.Forms.RadioButton();
            this.settingsShadow1 = new System.Windows.Forms.RadioButton();
            this.settingsShadowNone = new System.Windows.Forms.RadioButton();
            this.settingsDetailedTextures = new System.Windows.Forms.CheckBox();
            this.settingsMouseAccelleration = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.settingsEffects = new System.Windows.Forms.CheckBox();
            this.settingsMusic = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.settingsDynamicLightUnlimited = new System.Windows.Forms.RadioButton();
            this.settingsDynamicLight4 = new System.Windows.Forms.RadioButton();
            this.settingsDynamicLight1 = new System.Windows.Forms.RadioButton();
            this.settingsDynamicLightNone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.settingsGlowEffectHigh = new System.Windows.Forms.RadioButton();
            this.settingsGlowEffectLow = new System.Windows.Forms.RadioButton();
            this.settingsGlowEffectNone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsTextureResolutionVeryHigh = new System.Windows.Forms.RadioButton();
            this.settingsTextureResolutionLow = new System.Windows.Forms.RadioButton();
            this.settingsTextureResolutionHigh = new System.Windows.Forms.RadioButton();
            this.settingsTextureResolutionMid = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.settingsLauncherMusic = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // settingsScreenResolution
            // 
            this.settingsScreenResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsScreenResolution.FormattingEnabled = true;
            this.settingsScreenResolution.Items.AddRange(new object[] {
            resources.GetString("settingsScreenResolution.Items"),
            resources.GetString("settingsScreenResolution.Items1"),
            resources.GetString("settingsScreenResolution.Items2"),
            resources.GetString("settingsScreenResolution.Items3"),
            resources.GetString("settingsScreenResolution.Items4"),
            resources.GetString("settingsScreenResolution.Items5"),
            resources.GetString("settingsScreenResolution.Items6"),
            resources.GetString("settingsScreenResolution.Items7"),
            resources.GetString("settingsScreenResolution.Items8"),
            resources.GetString("settingsScreenResolution.Items9"),
            resources.GetString("settingsScreenResolution.Items10"),
            resources.GetString("settingsScreenResolution.Items11"),
            resources.GetString("settingsScreenResolution.Items12"),
            resources.GetString("settingsScreenResolution.Items13"),
            resources.GetString("settingsScreenResolution.Items14")});
            resources.ApplyResources(this.settingsScreenResolution, "settingsScreenResolution");
            this.settingsScreenResolution.Name = "settingsScreenResolution";
            this.settingsScreenResolution.SelectedIndexChanged += new System.EventHandler(this.settingsScreenResolution_SelectedIndexChanged);
            // 
            // settingsWindowMode
            // 
            resources.ApplyResources(this.settingsWindowMode, "settingsWindowMode");
            this.settingsWindowMode.Name = "settingsWindowMode";
            this.settingsWindowMode.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.settingsShadowUnlimited);
            this.groupBox5.Controls.Add(this.settingsShadow10);
            this.groupBox5.Controls.Add(this.settingsShadow1);
            this.groupBox5.Controls.Add(this.settingsShadowNone);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // settingsShadowUnlimited
            // 
            resources.ApplyResources(this.settingsShadowUnlimited, "settingsShadowUnlimited");
            this.settingsShadowUnlimited.Name = "settingsShadowUnlimited";
            this.settingsShadowUnlimited.TabStop = true;
            this.settingsShadowUnlimited.UseVisualStyleBackColor = true;
            // 
            // settingsShadow10
            // 
            resources.ApplyResources(this.settingsShadow10, "settingsShadow10");
            this.settingsShadow10.Name = "settingsShadow10";
            this.settingsShadow10.TabStop = true;
            this.settingsShadow10.UseVisualStyleBackColor = true;
            // 
            // settingsShadow1
            // 
            resources.ApplyResources(this.settingsShadow1, "settingsShadow1");
            this.settingsShadow1.Name = "settingsShadow1";
            this.settingsShadow1.TabStop = true;
            this.settingsShadow1.UseVisualStyleBackColor = true;
            // 
            // settingsShadowNone
            // 
            resources.ApplyResources(this.settingsShadowNone, "settingsShadowNone");
            this.settingsShadowNone.Name = "settingsShadowNone";
            this.settingsShadowNone.TabStop = true;
            this.settingsShadowNone.UseVisualStyleBackColor = true;
            // 
            // settingsDetailedTextures
            // 
            resources.ApplyResources(this.settingsDetailedTextures, "settingsDetailedTextures");
            this.settingsDetailedTextures.Name = "settingsDetailedTextures";
            this.settingsDetailedTextures.UseVisualStyleBackColor = true;
            // 
            // settingsMouseAccelleration
            // 
            resources.ApplyResources(this.settingsMouseAccelleration, "settingsMouseAccelleration");
            this.settingsMouseAccelleration.Name = "settingsMouseAccelleration";
            this.settingsMouseAccelleration.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.settingsEffects);
            this.groupBox4.Controls.Add(this.settingsDetailedTextures);
            this.groupBox4.Controls.Add(this.settingsMusic);
            this.groupBox4.Controls.Add(this.settingsMouseAccelleration);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // settingsEffects
            // 
            resources.ApplyResources(this.settingsEffects, "settingsEffects");
            this.settingsEffects.Name = "settingsEffects";
            this.settingsEffects.UseVisualStyleBackColor = true;
            // 
            // settingsMusic
            // 
            resources.ApplyResources(this.settingsMusic, "settingsMusic");
            this.settingsMusic.Name = "settingsMusic";
            this.settingsMusic.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.settingsDynamicLightUnlimited);
            this.groupBox3.Controls.Add(this.settingsDynamicLight4);
            this.groupBox3.Controls.Add(this.settingsDynamicLight1);
            this.groupBox3.Controls.Add(this.settingsDynamicLightNone);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // settingsDynamicLightUnlimited
            // 
            resources.ApplyResources(this.settingsDynamicLightUnlimited, "settingsDynamicLightUnlimited");
            this.settingsDynamicLightUnlimited.Name = "settingsDynamicLightUnlimited";
            this.settingsDynamicLightUnlimited.TabStop = true;
            this.settingsDynamicLightUnlimited.UseVisualStyleBackColor = true;
            // 
            // settingsDynamicLight4
            // 
            resources.ApplyResources(this.settingsDynamicLight4, "settingsDynamicLight4");
            this.settingsDynamicLight4.Name = "settingsDynamicLight4";
            this.settingsDynamicLight4.TabStop = true;
            this.settingsDynamicLight4.UseVisualStyleBackColor = true;
            // 
            // settingsDynamicLight1
            // 
            resources.ApplyResources(this.settingsDynamicLight1, "settingsDynamicLight1");
            this.settingsDynamicLight1.Name = "settingsDynamicLight1";
            this.settingsDynamicLight1.TabStop = true;
            this.settingsDynamicLight1.UseVisualStyleBackColor = true;
            // 
            // settingsDynamicLightNone
            // 
            resources.ApplyResources(this.settingsDynamicLightNone, "settingsDynamicLightNone");
            this.settingsDynamicLightNone.Name = "settingsDynamicLightNone";
            this.settingsDynamicLightNone.TabStop = true;
            this.settingsDynamicLightNone.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.settingsGlowEffectHigh);
            this.groupBox2.Controls.Add(this.settingsGlowEffectLow);
            this.groupBox2.Controls.Add(this.settingsGlowEffectNone);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // settingsGlowEffectHigh
            // 
            resources.ApplyResources(this.settingsGlowEffectHigh, "settingsGlowEffectHigh");
            this.settingsGlowEffectHigh.Name = "settingsGlowEffectHigh";
            this.settingsGlowEffectHigh.TabStop = true;
            this.settingsGlowEffectHigh.UseVisualStyleBackColor = true;
            // 
            // settingsGlowEffectLow
            // 
            resources.ApplyResources(this.settingsGlowEffectLow, "settingsGlowEffectLow");
            this.settingsGlowEffectLow.Name = "settingsGlowEffectLow";
            this.settingsGlowEffectLow.TabStop = true;
            this.settingsGlowEffectLow.UseVisualStyleBackColor = true;
            // 
            // settingsGlowEffectNone
            // 
            resources.ApplyResources(this.settingsGlowEffectNone, "settingsGlowEffectNone");
            this.settingsGlowEffectNone.Name = "settingsGlowEffectNone";
            this.settingsGlowEffectNone.TabStop = true;
            this.settingsGlowEffectNone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsTextureResolutionVeryHigh);
            this.groupBox1.Controls.Add(this.settingsTextureResolutionLow);
            this.groupBox1.Controls.Add(this.settingsTextureResolutionHigh);
            this.groupBox1.Controls.Add(this.settingsTextureResolutionMid);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // settingsTextureResolutionVeryHigh
            // 
            resources.ApplyResources(this.settingsTextureResolutionVeryHigh, "settingsTextureResolutionVeryHigh");
            this.settingsTextureResolutionVeryHigh.Name = "settingsTextureResolutionVeryHigh";
            this.settingsTextureResolutionVeryHigh.TabStop = true;
            this.settingsTextureResolutionVeryHigh.UseVisualStyleBackColor = true;
            // 
            // settingsTextureResolutionLow
            // 
            resources.ApplyResources(this.settingsTextureResolutionLow, "settingsTextureResolutionLow");
            this.settingsTextureResolutionLow.Name = "settingsTextureResolutionLow";
            this.settingsTextureResolutionLow.TabStop = true;
            this.settingsTextureResolutionLow.UseVisualStyleBackColor = true;
            // 
            // settingsTextureResolutionHigh
            // 
            resources.ApplyResources(this.settingsTextureResolutionHigh, "settingsTextureResolutionHigh");
            this.settingsTextureResolutionHigh.Name = "settingsTextureResolutionHigh";
            this.settingsTextureResolutionHigh.TabStop = true;
            this.settingsTextureResolutionHigh.UseVisualStyleBackColor = true;
            // 
            // settingsTextureResolutionMid
            // 
            resources.ApplyResources(this.settingsTextureResolutionMid, "settingsTextureResolutionMid");
            this.settingsTextureResolutionMid.Name = "settingsTextureResolutionMid";
            this.settingsTextureResolutionMid.TabStop = true;
            this.settingsTextureResolutionMid.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // settingsLanguage
            // 
            this.settingsLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsLanguage.FormattingEnabled = true;
            this.settingsLanguage.Items.AddRange(new object[] {
            resources.GetString("settingsLanguage.Items"),
            resources.GetString("settingsLanguage.Items1"),
            resources.GetString("settingsLanguage.Items2"),
            resources.GetString("settingsLanguage.Items3"),
            resources.GetString("settingsLanguage.Items4"),
            resources.GetString("settingsLanguage.Items5"),
            resources.GetString("settingsLanguage.Items6"),
            resources.GetString("settingsLanguage.Items7"),
            resources.GetString("settingsLanguage.Items8"),
            resources.GetString("settingsLanguage.Items9"),
            resources.GetString("settingsLanguage.Items10")});
            resources.ApplyResources(this.settingsLanguage, "settingsLanguage");
            this.settingsLanguage.Name = "settingsLanguage";
            this.settingsLanguage.SelectedIndexChanged += new System.EventHandler(this.settingsLanguage_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.settingsLauncherMusic);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // settingsLauncherMusic
            // 
            resources.ApplyResources(this.settingsLauncherMusic, "settingsLauncherMusic");
            this.settingsLauncherMusic.Name = "settingsLauncherMusic";
            this.settingsLauncherMusic.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.settingsLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settingsWindowMode);
            this.Controls.Add(this.settingsScreenResolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox settingsScreenResolution;
        private System.Windows.Forms.CheckBox settingsWindowMode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton settingsShadowUnlimited;
        private System.Windows.Forms.RadioButton settingsShadow10;
        private System.Windows.Forms.RadioButton settingsShadow1;
        private System.Windows.Forms.RadioButton settingsShadowNone;
        private System.Windows.Forms.CheckBox settingsDetailedTextures;
        private System.Windows.Forms.CheckBox settingsMouseAccelleration;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox settingsEffects;
        private System.Windows.Forms.CheckBox settingsMusic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton settingsDynamicLightUnlimited;
        private System.Windows.Forms.RadioButton settingsDynamicLight4;
        private System.Windows.Forms.RadioButton settingsDynamicLight1;
        private System.Windows.Forms.RadioButton settingsDynamicLightNone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton settingsGlowEffectHigh;
        private System.Windows.Forms.RadioButton settingsGlowEffectLow;
        private System.Windows.Forms.RadioButton settingsGlowEffectNone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton settingsTextureResolutionVeryHigh;
        private System.Windows.Forms.RadioButton settingsTextureResolutionLow;
        private System.Windows.Forms.RadioButton settingsTextureResolutionHigh;
        private System.Windows.Forms.RadioButton settingsTextureResolutionMid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox settingsLanguage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox settingsLauncherMusic;
    }
}