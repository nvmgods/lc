using RavenDevLauncher.Logic;
using System;
using System.Windows.Forms;

namespace RavenDevLauncher.Interface
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            /* 
             * Warning:
             * 
             * This is a messy implementation, but copy / pasted from an older
             * launcher prototype project first testing the setting adjustments.
             * There was no effort updating this portion as this is a
             * bit redundant to the launcher's purpose. This should be optimized 
             * and extended for release applications.
             */

            INIFile ini = new INIFile(@".\R3Engine.ini");

            // Setup
            string r3Language = ini.ReadValue("Setup", "Language");

            // RenderState
            string r3ScreenXSize = ini.ReadValue("RenderState", "ScreenXSize");
            string r3ScreenYSize = ini.ReadValue("RenderState", "ScreenYSize");
            string r3RenderBits = ini.ReadValue("RenderState", "RenderBits");
            string r3ZbufferBits = ini.ReadValue("RenderState", "ZbufferBits");
            string r3bFullScreen = ini.ReadValue("RenderState", "bFullScreen");
            string r3bStartCamera = ini.ReadValue("RenderState", "bStartCamera");
            string r3Gamma = ini.ReadValue("RenderState", "Gamma");
            string r3TextureDetail = ini.ReadValue("RenderState", "TextureDetail");
            string r3DynamicLight = ini.ReadValue("RenderState", "DynamicLight");
            string r3ShadowDetail = ini.ReadValue("RenderState", "ShadowDetail");
            string r3SeeDistance = ini.ReadValue("RenderState", "SeeDistance");
            string r3bMouseAccelation = ini.ReadValue("RenderState", "bMouseAccelation");
            string r3bDetailTexture = ini.ReadValue("RenderState", "bDetailTexture");
            string r3BboShasi = ini.ReadValue("RenderState", "BboShasi");
            string r3Adapter = ini.ReadValue("RenderState", "Adapter");
            // Sound
            string r3Sound = ini.ReadValue("Sound", "Sound");
            string r3Music = ini.ReadValue("Sound", "Music");
            string r3SoundVol = ini.ReadValue("Sound", "SoundVol");
            string r3MusicVol = ini.ReadValue("Sound", "MusicVol");
            string r3AmbVol = ini.ReadValue("Sound", "AmbVol");
            string r3LauncherMusic = ini.ReadValue("Sound", "LauncherMusic");

            // LauncherMusic
            if (r3LauncherMusic == "FALSE")
            {
                settingsLauncherMusic.Checked = false;
            }
            else
            {
                settingsLauncherMusic.Checked = true;
            }


            // Language

            if (r3Language == "Korea")
            {
                settingsLanguage.Text = "Korea";
            }
            else if (r3Language == "China")
            {
                settingsLanguage.Text = "China";
            }
            else if (r3Language == "Europe")
            {
                settingsLanguage.Text = "Europe";
            }
            else if (r3Language == "Indonesia")
            {
                settingsLanguage.Text = "Indonesia";
            }
            else if (r3Language == "Japan")
            {
                settingsLanguage.Text = "Japan";
            }
            else if (r3Language == "Philippines")
            {
                settingsLanguage.Text = "Philippines";
            }
            else if (r3Language == "Russia")
            {
                settingsLanguage.Text = "Russia";
            }
            else if (r3Language == "Taiwan")
            {
                settingsLanguage.Text = "Taiwan";
            }
            else if (r3Language == "USA")
            {
                settingsLanguage.Text = "United States";
            }
            else if (r3Language == "Thailand")
            {
                settingsLanguage.Text = "Thailand";
            }


            // Window mode
            if (r3bFullScreen == "TRUE")
            {
                settingsWindowMode.Checked = false;
            }
            else
            {
                settingsWindowMode.Checked = true;
            }

            // Screensize
            if ((r3ScreenXSize == "800") && (r3ScreenYSize == "600"))
            {
                settingsScreenResolution.Text = "800x600";
            }
            else if ((r3ScreenXSize == "1024") && (r3ScreenYSize == "768"))
            {
                settingsScreenResolution.Text = "1024x768";
            }
            else if ((r3ScreenXSize == "1152") && (r3ScreenYSize == "864"))
            {
                settingsScreenResolution.Text = "1152x864";
            }
            else if ((r3ScreenXSize == "1280") && (r3ScreenYSize == "600"))
            {
                settingsScreenResolution.Text = "1280x600";
            }
            else if ((r3ScreenXSize == "1280") && (r3ScreenYSize == "720"))
            {
                settingsScreenResolution.Text = "1280x720";
            }
            else if ((r3ScreenXSize == "1280") && (r3ScreenYSize == "780"))
            {
                settingsScreenResolution.Text = "1280x780";
            }
            else if ((r3ScreenXSize == "1280") && (r3ScreenYSize == "800"))
            {
                settingsScreenResolution.Text = "1280x800";
            }
            else if ((r3ScreenXSize == "1280") && (r3ScreenYSize == "960"))
            {
                settingsScreenResolution.Text = "1280x960";
            }
            else if ((r3ScreenXSize == "1280") && (r3ScreenYSize == "1024"))
            {
                settingsScreenResolution.Text = "1280x1024";
            }
            else if ((r3ScreenXSize == "1360") && (r3ScreenYSize == "768"))
            {
                settingsScreenResolution.Text = "1360x768";
            }
            else if ((r3ScreenXSize == "1366") && (r3ScreenYSize == "768"))
            {
                settingsScreenResolution.Text = "1366x768";
            }
            else if ((r3ScreenXSize == "1400") && (r3ScreenYSize == "1050"))
            {
                settingsScreenResolution.Text = "1400x1050";
            }
            else if ((r3ScreenXSize == "1440") && (r3ScreenYSize == "900"))
            {
                settingsScreenResolution.Text = "1440x900";
            }
            else if ((r3ScreenXSize == "1600") && (r3ScreenYSize == "900"))
            {
                settingsScreenResolution.Text = "1600x900";
            }
            else if ((r3ScreenXSize == "1680") && (r3ScreenYSize == "1050"))
            {
                settingsScreenResolution.Text = "1680x1050";
            }
            else if ((r3ScreenXSize == "1920") && (r3ScreenYSize == "1080"))
            {
                settingsScreenResolution.Text = "1920x1080";
            }
            // Texture Resolution
            if (r3TextureDetail == "0")
            {
                settingsTextureResolutionLow.Checked = true;
            }
            else if (r3TextureDetail == "1")
            {
                settingsTextureResolutionMid.Checked = true;
            }
            else if (r3TextureDetail == "2")
            {
                settingsTextureResolutionHigh.Checked = true;
            }
            else if (r3TextureDetail == "3")
            {
                settingsTextureResolutionVeryHigh.Checked = true;
            }
            // Dynamic Light
            if (r3DynamicLight == "0")
            {
                settingsDynamicLightNone.Checked = true;
            }
            else if (r3DynamicLight == "1")
            {
                settingsDynamicLight1.Checked = true;
            }
            else if (r3DynamicLight == "2")
            {
                settingsDynamicLight4.Checked = true;
            }
            else if (r3DynamicLight == "3")
            {
                settingsDynamicLightUnlimited.Checked = true;
            }
            // Glow Effect
            if (r3BboShasi == "0")
            {
                settingsGlowEffectNone.Checked = true;
            }
            else if (r3BboShasi == "1")
            {
                settingsGlowEffectLow.Checked = true;
            }
            else if (r3BboShasi == "2")
            {
                settingsGlowEffectHigh.Checked = true;
            }
            // Shadow
            if (r3ShadowDetail == "0")
            {
                settingsShadowNone.Checked = true;
            }
            else if (r3ShadowDetail == "1")
            {
                settingsShadow1.Checked = true;
            }
            else if (r3ShadowDetail == "2")
            {
                settingsShadow10.Checked = true;
            }
            else if (r3ShadowDetail == "3")
            {
                settingsShadowUnlimited.Checked = true;
            }
            // Sound
            if (r3Music == "TRUE")
            {
                settingsMusic.Checked = true;
            }
            else
            {
                settingsMusic.Checked = false;
            }
            if (r3Sound == "TRUE")
            {
                settingsEffects.Checked = true;
            }
            else
            {
                settingsEffects.Checked = false;
            }
            // Other options
            if (r3bMouseAccelation == "TRUE")
            {
                settingsMouseAccelleration.Checked = true;
            }
            else
            {
                settingsMouseAccelleration.Checked = false;
            }
            if (r3bDetailTexture == "TRUE")
            {
                settingsDetailedTextures.Checked = true;
            }
            else
            {
                settingsDetailedTextures.Checked = false;
            }
        }

        private void settingsScreenResolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void settingsLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            INIFile ini = new INIFile(@".\R3Engine.ini");
            
            string r3Language = "";
            string r3ScreenXSize = "";
            string r3ScreenYSize = "";
            //string r3RenderBits = ""; // Not currently handled on settings form. 
            //string r3ZbufferBits = ""; // Not currently handled on settings form
            string r3bFullScreen = "";
            //string r3bStartCamera = ""; // Not currently handled on settings form
            //string r3Gamma = ""; // Not currently handled on settings form
            string r3TextureDetail = "";
            string r3DynamicLight = "";
            string r3ShadowDetail = "";
            //string r3SeeDistance = ""; // Not currently handled on settings form
            string r3bMouseAccelation = "";
            string r3bDetailTexture = "";
            string r3BboShasi = "";
            //string r3Adapter = ""; // Not currently handled on settings form
            string r3Sound = "";
            string r3Music = "";
            //string r3SoundVol = ""; // Not currently handled on settings form
            //string r3MusicVol = ""; // Not currently handled on settings form
            //string r3AmbVol = ""; // Not currently handled on settings form
            string r3LauncherMusic = "";


            // LauncherMusic
            if (settingsLauncherMusic.Checked == true)
            {
                r3LauncherMusic = "TRUE";
            }
            else
            {
                r3LauncherMusic = "FALSE";
            }
            ini.WriteValue("Sound", "LauncherMusic", r3LauncherMusic);


            // Language
            if (settingsLanguage.Text == "Korea")
            {
                r3Language = "Korea";
            }
            else if (settingsLanguage.Text == "China")
            {
                r3Language = "China";
            }
            else if (settingsLanguage.Text == "Europe")
            {
                r3Language = "Europe";
            }
            else if (settingsLanguage.Text == "Indonesia")
            {
                r3Language = "Indonesia";
            }
            else if (settingsLanguage.Text == "Japan")
            {
                r3Language = "Japan";
            }
            else if (settingsLanguage.Text == "Philippines")
            {
                r3Language = "Philippines";
            }
            else if (settingsLanguage.Text == "Russia")
            {
                r3Language = "Russia";
            }
            else if (settingsLanguage.Text == "Taiwan")
            {
                r3Language = "Taiwan";
            }
            else if (settingsLanguage.Text == "United States")
            {
                r3Language = "USA";
            }
            else if (settingsLanguage.Text == "Thailand")
            {
                r3Language = "Thailand";
            }

            ini.WriteValue("Setup", "Language", r3Language);

            // Resolution
            if (settingsScreenResolution.Text == "800x600")
            {
                r3ScreenXSize = "800";
                r3ScreenYSize = "600";
            }
            else if (settingsScreenResolution.Text == "1024x768")
            {
                r3ScreenXSize = "1024";
                r3ScreenYSize = "768";
            }
            else if (settingsScreenResolution.Text == "1152x864")
            {
                r3ScreenXSize = "1152";
                r3ScreenYSize = "864";
            }

            else if (settingsScreenResolution.Text == "1280x600")
            {
                r3ScreenXSize = "1280";
                r3ScreenYSize = "600";
            }

            else if (settingsScreenResolution.Text == "1280x720")
            {
                r3ScreenXSize = "1280";
                r3ScreenYSize = "720";
            }

            else if (settingsScreenResolution.Text == "1280x768")
            {
                r3ScreenXSize = "1280";
                r3ScreenYSize = "768";
            }

            else if (settingsScreenResolution.Text == "1280x800")
            {
                r3ScreenXSize = "1280";
                r3ScreenYSize = "800";
            }

            else if (settingsScreenResolution.Text == "1280x960")
            {
                r3ScreenXSize = "1280";
                r3ScreenYSize = "960";
            }

            else if (settingsScreenResolution.Text == "1280x1024")
            {
                r3ScreenXSize = "1280";
                r3ScreenYSize = "1024";
            }

            else if (settingsScreenResolution.Text == "1360x768")
            {
                r3ScreenXSize = "1360";
                r3ScreenYSize = "768";
            }

            else if (settingsScreenResolution.Text == "1366x768")
            {
                r3ScreenXSize = "1366";
                r3ScreenYSize = "768";
            }

            else if (settingsScreenResolution.Text == "1400x1050")
            {
                r3ScreenXSize = "1400";
                r3ScreenYSize = "1050";
            }

            else if (settingsScreenResolution.Text == "1440x900")
            {
                r3ScreenXSize = "1440";
                r3ScreenYSize = "900";
            }

            else if (settingsScreenResolution.Text == "1600x900")
            {
                r3ScreenXSize = "1600";
                r3ScreenYSize = "900";
            }

            else if (settingsScreenResolution.Text == "1680x1050")
            {
                r3ScreenXSize = "1680";
                r3ScreenYSize = "1050";
            }

            else if (settingsScreenResolution.Text == "1920x1080")
            {
                r3ScreenXSize = "1920";
                r3ScreenYSize = "1080";
            }
            ini.WriteValue("RenderState", "ScreenXSize", r3ScreenXSize);
            ini.WriteValue("RenderState", "ScreenYSize", r3ScreenYSize);



            // Window mdoe
            if (settingsWindowMode.Checked == true)
            {
                r3bFullScreen = "FALSE";
            }
            else
            {
                r3bFullScreen = "TRUE";
            }
            ini.WriteValue("RenderState", "bFullScreen", r3bFullScreen);

            // Texture resolution
            if (settingsTextureResolutionLow.Checked == true)
            {
                r3TextureDetail = "0";
            }
            else if (settingsTextureResolutionMid.Checked == true)
            {
                r3TextureDetail = "1";
            }
            else if (settingsTextureResolutionHigh.Checked == true)
            {
                r3TextureDetail = "2";
            }
            else if (settingsTextureResolutionVeryHigh.Checked == true)
            {
                r3TextureDetail = "3";
            }
            ini.WriteValue("RenderState", "TextureDetail", r3TextureDetail);

            // Dynamic light
            if (settingsDynamicLightNone.Checked == true)
            {
                r3DynamicLight = "0";
            }
            else if (settingsDynamicLight1.Checked == true)
            {
                r3DynamicLight = "1";
            }
            else if (settingsDynamicLight4.Checked == true)
            {
                r3DynamicLight = "2";
            }
            else if (settingsDynamicLightUnlimited.Checked == true)
            {
                r3DynamicLight = "3";
            }
            ini.WriteValue("RenderState", "DynamicLight", r3DynamicLight);

            // Glow effect
            if (settingsGlowEffectNone.Checked == true)
            {
                r3BboShasi = "0";
            }
            else if (settingsGlowEffectLow.Checked == true)
            {
                r3BboShasi = "1";
            }
            else if (settingsGlowEffectHigh.Checked == true)
            {
                r3BboShasi = "2";
            }
            ini.WriteValue("RenderState", "BboShasi", r3BboShasi);

            // Shadow
            if (settingsShadowNone.Checked == true)
            {
                r3ShadowDetail = "0";
            }
            else if (settingsShadow1.Checked == true)
            {
                r3ShadowDetail = "1";
            }
            else if (settingsShadow10.Checked == true)
            {
                r3ShadowDetail = "2";
            }
            else if (settingsShadowUnlimited.Checked == true)
            {
                r3ShadowDetail = "3";
            }
            ini.WriteValue("RenderState", "ShadowDetail", r3ShadowDetail);

            // Sound
            if (settingsEffects.Checked == true)
            {
                r3Sound = "TRUE";
            }
            else
            {
                r3Sound = "FALSE";
            }
            if (settingsMusic.Checked == true)
            {
                r3Music = "TRUE";
            }
            else
            {
                r3Music = "FALSE";
            }
            ini.WriteValue("Sound", "Sound", r3Sound);
            ini.WriteValue("Sound", "Music", r3Music);

            // Misc Settings
            if (settingsMouseAccelleration.Checked == true)
            {
                r3bMouseAccelation = "TRUE";
            }
            else
            {
                r3bMouseAccelation = "FALSE";
            }
            if (settingsDetailedTextures.Checked == true)
            {
                r3bDetailTexture = "TRUE";
            }
            else
            {
                r3bDetailTexture = "FALSE";
            }
            ini.WriteValue("RenderState", "bMouseAccelation", r3bMouseAccelation);
            ini.WriteValue("RenderState", "bDetailTexture", r3bDetailTexture);

            // Close form
            this.Hide();
        }


    }
}
