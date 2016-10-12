using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace System.Windows.Forms
{
    public class RribbonTheme: RibbonProfesionalRendererColorTable
    {
        public RribbonTheme()
        {
            #region Fields

            OrbDropDownDarkBorder = FromHex("#B1B1B1");
            OrbDropDownLightBorder = FromHex("#FFFFFF");
            OrbDropDownBack = FromHex("#D4D4D4");
            OrbDropDownNorthA = FromHex("#E6E6E6");
            OrbDropDownNorthB = FromHex("#E2E2E2");
            OrbDropDownNorthC = FromHex("#D9D9D9");
            OrbDropDownNorthD = FromHex("#CDCDCD");
            OrbDropDownSouthC = FromHex("#CBCBCB");
            OrbDropDownSouthD = FromHex("#E1E1E1");
            OrbDropDownContentbg = FromHex("#EBEBEB");
            OrbDropDownContentbglight = FromHex("#FAFAFA");
            OrbDropDownSeparatorlight = FromHex("#F5F5F5");
            OrbDropDownSeparatordark = FromHex("#C5C5C5");
            Caption1 = FromHex("#ECECEC");
            Caption2 = FromHex("#EAEAEA");
            Caption3 = FromHex("#E6E6E6");
            Caption4 = FromHex("#E8E8E8");
            Caption5 = FromHex("#DFDFDF");
            Caption6 = FromHex("#F0F0F0");
            Caption7 = FromHex("#D2D2D2");
            QuickAccessBorderDark = FromHex("#CBCBCB");
            QuickAccessBorderLight = FromHex("#F6F6F6");
            QuickAccessUpper = FromHex("#ECECEC");
            QuickAccessLower = FromHex("#DADADA");
            OrbOptionBorder = FromHex("#969696");
            OrbOptionBackground = FromHex("#F1F1F1");
            OrbOptionShine = FromHex("#E2E2E2");
            Arrow = FromHex("#7C7C7C");
            ArrowLight = FromHex("#EAF2F9");
            ArrowDisabled = FromHex("#7C7C7C");
            Text = FromHex("#000000");
            RibbonBackground = FromHex("#535353");
            TabBorder = FromHex("#BEBEBE");
            TabNorth = FromHex("#F1F2F2");
            TabSouth = FromHex("#D6D9DF");
            TabGlow = FromHex("#D1FBFF");
            TabText = FromHex("#FFFFFF");
            TabActiveText = FromHex("#000000");
            TabContentNorth = FromHex("#B6BCC6");
            TabContentSouth = FromHex("#E6F0F1");
            TabSelectedGlow = FromHex("#E1D2A5");
            PanelDarkBorder = FromHex("#AEB0B4");
            PanelLightBorder = FromHex("#E7E9ED");
            PanelTextBackground = FromHex("#ABAEAE");
            PanelTextBackgroundSelected = FromHex("#949495");
            PanelText = FromHex("#FFFFFF");
            PanelBackgroundSelected = FromHex("#F3F5F5");
            PanelOverflowBackground = FromHex("#B9D1F0");
            PanelOverflowBackgroundPressed = FromHex("#AAAEB3");
            PanelOverflowBackgroundSelectedNorth = FromHex("#FFFFFF");
            PanelOverflowBackgroundSelectedSouth = FromHex("#EBEBEB");
            ButtonBgOut = FromHex("#B4B9C2");
            ButtonBgCenter = FromHex("#CDD2D8");
            ButtonBorderOut = FromHex("#A9B1B8");
            ButtonBorderIn = FromHex("#DFE2E6");
            ButtonGlossyNorth = FromHex("#DBDFE4");
            ButtonGlossySouth = FromHex("#DFE2E8");
            ButtonDisabledBgOut = FromHex("#E0E4E8");
            ButtonDisabledBgCenter = FromHex("#E8EBEF");
            ButtonDisabledBorderOut = FromHex("#C5D1DE");
            ButtonDisabledBorderIn = FromHex("#F1F3F5");
            ButtonDisabledGlossyNorth = FromHex("#F0F3F6");
            ButtonDisabledGlossySouth = FromHex("#EAEDF1");
            ButtonSelectedBgOut = FromHex("#FFD646");
            ButtonSelectedBgCenter = FromHex("#FFEAAC");
            ButtonSelectedBorderOut = FromHex("#C2A978");
            ButtonSelectedBorderIn = FromHex("#FFF2C7");
            ButtonSelectedGlossyNorth = FromHex("#FFFDDB");
            ButtonSelectedGlossySouth = FromHex("#FFE793");
            ButtonPressedBgOut = FromHex("#F88F2C");
            ButtonPressedBgCenter = FromHex("#FDF1B0");
            ButtonPressedBorderOut = FromHex("#8E8165");
            ButtonPressedBorderIn = FromHex("#F9C65A");
            ButtonPressedGlossyNorth = FromHex("#FDD5A8");
            ButtonPressedGlossySouth = FromHex("#FBB062");
            ButtonCheckedBgOut = FromHex("#F9AA45");
            ButtonCheckedBgCenter = FromHex("#FDEA9D");
            ButtonCheckedBorderOut = FromHex("#8E8165");
            ButtonCheckedBorderIn = FromHex("#F9C65A");
            ButtonCheckedGlossyNorth = FromHex("#F8DBB7");
            ButtonCheckedGlossySouth = FromHex("#FED18E");
            ItemGroupOuterBorder = FromHex("#ADB7BB");
            ItemGroupInnerBorder = FromHex("#FFFFFF");
            ItemGroupSeparatorLight = FromHex("#FFFFFF");
            ItemGroupSeparatorDark = FromHex("#ADB7BB");
            ItemGroupBgNorth = FromHex("#D9E0E1");
            ItemGroupBgSouth = FromHex("#EDF0F1");
            ItemGroupBgGlossy = FromHex("#D2D9DB");
            ButtonListBorder = FromHex("#ACACAC");
            ButtonListBg = FromHex("#DAE2E2");
            ButtonListBgSelected = FromHex("#F7F7F7");
            DropDownBg = FromHex("#FAFAFA");
            DropDownImageBg = FromHex("#E9EEEE");
            DropDownImageSeparator = FromHex("#C5C5C5");
            DropDownBorder = FromHex("#868686");
            DropDownGripNorth = FromHex("#FFFFFF");
            DropDownGripSouth = FromHex("#DFE9EF");
            DropDownGripBorder = FromHex("#DDE7EE");
            DropDownGripDark = FromHex("#5574A7");
            DropDownGripLight = FromHex("#FFFFFF");
            SeparatorLight = FromHex("#E6E8EB");
            SeparatorDark = FromHex("#C5C5C5");
            SeparatorBg = FromHex("#EBEBEB");
            SeparatorLine = FromHex("#C5C5C5");
            TextBoxUnselectedBg = FromHex("#E8E8E8");
            TextBoxBorder = FromHex("#898989");
            ToolTipContentNorth = FromHex("#B6BCC6");
            ToolTipContentSouth = FromHex("#E6F0F1");
            ToolTipDarkBorder = FromHex("#AEB0B4");
            ToolTipLightBorder = FromHex("#E7E9ED");

            #endregion
        }

        public Color FromHex(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            if (hex.Length != 6) throw new Exception("Color not valid");

            return Color.FromArgb(
                int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
        }
    }
}