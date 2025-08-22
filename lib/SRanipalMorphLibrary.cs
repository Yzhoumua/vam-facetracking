using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using SimpleJSON;

namespace FacialTrackerVamPlugin
{
    public class SRanipalMorphLibrary
    {
        private float ParseFloat(JSONClass node, params string[] keys)
        {
            foreach (var k in keys)
            {
                float v;
                if (node.HasKey(k) && float.TryParse(node[k], out v)) return v;
            }
            return 0f;
        }

        public static float Jaw_Right = 0;
        public static float Jaw_Left = 0;
        public static float Jaw_Forward = 0;
        public static float Jaw_Open = 0;
        public static float Mouth_Ape_Shape = 0;
        public static float Mouth_Upper_Right = 0;
        public static float Mouth_Upper_Left = 0;
        public static float Mouth_Lower_Right = 0;
        public static float Mouth_Lower_Left = 0;
        public static float Mouth_Upper_Overturn = 0;
        public static float Mouth_Lower_Overturn = 0;
        public static float Mouth_Pout = 0;
        public static float Mouth_Smile_Right = 0;
        public static float Mouth_Smile_Left = 0;
        public static float Mouth_Sad_Right = 0;
        public static float Mouth_Sad_Left = 0;
        public static float Cheek_Puff_Right = 0;
        public static float Cheek_Puff_Left = 0;
        public static float Cheek_Suck = 0;
        public static float Mouth_Upper_UpRight = 0;
        public static float Mouth_Upper_UpLeft = 0;
        public static float Mouth_Lower_DownRight = 0;
        public static float Mouth_Lower_DownLeft = 0;
        public static float Mouth_Upper_Inside = 0;
        public static float Mouth_Lower_Inside = 0;
        public static float Mouth_Lower_Overlay = 0;
        public static float Tongue_LongStep1 = 0;
        public static float Tongue_Up = 0;
        public static float Tongue_Left = 0;
        public static float Tongue_Right = 0;
        public static float Tongue_Down = 0;
        public static float Tongue_Roll = 0;
        public static float Tongue_LongStep2 = 0;
        public static float Tongue_UpRight_Morph = 0;
        public static float Tongue_UpLeft_Morph = 0;
        public static float Tongue_DownRight_Morph = 0;
        public static float Tongue_DownLeft_Morph = 0;
        public static float Eye_X_Left = 0;
        public static float Eye_Y_Left = 0;
        public static float Eye_X_Right = 0;
        public static float Eye_Y_Right = 0;
        public static float Eye_Blink_Left = 0;
        public static float Eye_Blink_Right = 0;
        public static float Eye_Squint_Left = 0;
        public static float Eye_Squint_Right = 0;
        public static float Brow_Down_Left = 0;
        public static float Brow_Down_Right = 0;
        public static float Brow_Inner_Up = 0;
        public static float Brow_Outer_Up_Left = 0;
        public static float Brow_Outer_Up_Right = 0;

        public SRanipalMorphLibrary()
        {

        }

        public void _updateFromJsonNode(JSONClass sranipalValues)
        {
            try
            {
                Jaw_Right = ParseFloat(sranipalValues, "Jaw_Right", "JawRight");
                Jaw_Left = ParseFloat(sranipalValues, "Jaw_Left", "JawLeft");
                Jaw_Forward = ParseFloat(sranipalValues, "Jaw_Forward", "JawForward");
                Jaw_Open = ParseFloat(sranipalValues, "Jaw_Open", "JawOpen");
                float.TryParse(sranipalValues["Mouth_Ape_Shape"], out Mouth_Ape_Shape);
                float.TryParse(sranipalValues["Mouth_Upper_Right"], out Mouth_Upper_Right); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Upper_Left"], out Mouth_Upper_Left); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Lower_Right"], out Mouth_Lower_Right); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Lower_Left"], out Mouth_Lower_Left); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Upper_Overturn"], out Mouth_Upper_Overturn); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Lower_Overturn"], out Mouth_Lower_Overturn); // NOT CURRENTLY USED
                Mouth_Pout = ParseFloat(sranipalValues, "Mouth_Pout", "MouthPout");
                Mouth_Smile_Right = ParseFloat(sranipalValues, "Mouth_Smile_Right", "MouthSmileRight");
                Mouth_Smile_Left = ParseFloat(sranipalValues, "Mouth_Smile_Left", "MouthSmileLeft");
                Mouth_Sad_Right = ParseFloat(sranipalValues, "Mouth_Sad_Right", "MouthFrownRight");
                Mouth_Sad_Left = ParseFloat(sranipalValues, "Mouth_Sad_Left", "MouthFrownLeft");
                Cheek_Puff_Right = ParseFloat(sranipalValues, "Cheek_Puff_Right", "CheekPuffRight");
                Cheek_Puff_Left = ParseFloat(sranipalValues, "Cheek_Puff_Left", "CheekPuffLeft");
                Cheek_Suck = ParseFloat(sranipalValues, "Cheek_Suck", "CheekSuck");
                Mouth_Upper_UpRight = ParseFloat(sranipalValues, "Mouth_Upper_UpRight", "MouthUpperUpRight");
                Mouth_Upper_UpLeft = ParseFloat(sranipalValues, "Mouth_Upper_UpLeft", "MouthUpperUpLeft");
                Mouth_Lower_DownRight = ParseFloat(sranipalValues, "Mouth_Lower_DownRight", "MouthLowerDownRight");
                Mouth_Lower_DownLeft = ParseFloat(sranipalValues, "Mouth_Lower_DownLeft", "MouthLowerDownLeft");
                float.TryParse(sranipalValues["Mouth_Upper_Inside"], out Mouth_Upper_Inside); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Lower_Inside"], out Mouth_Lower_Inside); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Mouth_Lower_Overlay"], out Mouth_Lower_Overlay); // NOT CURRENTLY USED
                Tongue_LongStep1 = ParseFloat(sranipalValues, "Tongue_LongStep1", "TongueInOut", "Tongue_InOut");
                Tongue_Up = ParseFloat(sranipalValues, "Tongue_Up", "TongueUp");
                Tongue_Left = ParseFloat(sranipalValues, "Tongue_Left", "TongueLeft");
                Tongue_Right = ParseFloat(sranipalValues, "Tongue_Right", "TongueRight");
                Tongue_Down = ParseFloat(sranipalValues, "Tongue_Down", "TongueDown");
                Tongue_Roll = ParseFloat(sranipalValues, "Tongue_Roll", "TongueRoll");
                Tongue_LongStep2 = ParseFloat(sranipalValues, "Tongue_LongStep2", "TongueStep2");

                float tongueX = ParseFloat(sranipalValues, "Tongue_X", "TongueX");
                if (tongueX > 0) Tongue_Right = tongueX; else if (tongueX < 0) Tongue_Left = -tongueX;
                float tongueY = ParseFloat(sranipalValues, "Tongue_Y", "TongueY");
                if (tongueY > 0) Tongue_Up = tongueY; else if (tongueY < 0) Tongue_Down = -tongueY;
                float.TryParse(sranipalValues["Tongue_UpRight_Morph"], out Tongue_UpRight_Morph); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Tongue_UpLeft_Morph"], out Tongue_UpLeft_Morph); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Tongue_DownRight_Morph"], out Tongue_DownRight_Morph); // NOT CURRENTLY USED
                float.TryParse(sranipalValues["Tongue_DownLeft_Morph"], out Tongue_DownLeft_Morph); // NOT CURRENTLY USED
                if (sranipalValues.HasKey("Eye_X_Left")) float.TryParse(sranipalValues["Eye_X_Left"], out Eye_X_Left);
                if (sranipalValues.HasKey("Eye_Y_Left")) float.TryParse(sranipalValues["Eye_Y_Left"], out Eye_Y_Left);
                if (sranipalValues.HasKey("Eye_X_Right")) float.TryParse(sranipalValues["Eye_X_Right"], out Eye_X_Right);
                if (sranipalValues.HasKey("Eye_Y_Right")) float.TryParse(sranipalValues["Eye_Y_Right"], out Eye_Y_Right);
                Eye_Blink_Left = ParseFloat(sranipalValues, "Eye_Blink_Left", "EyeBlink_L", "EyeBlinkLeft");
                Eye_Blink_Right = ParseFloat(sranipalValues, "Eye_Blink_Right", "EyeBlink_R", "EyeBlinkRight");
                Eye_Squint_Left = ParseFloat(sranipalValues, "Eye_Squint_Left", "EyeSquint_L", "EyeSquintLeft");
                Eye_Squint_Right = ParseFloat(sranipalValues, "Eye_Squint_Right", "EyeSquint_R", "EyeSquintRight");
                Brow_Down_Left = ParseFloat(sranipalValues, "Brow_Down_Left", "BrowD_L", "BrowDownLeft");
                Brow_Down_Right = ParseFloat(sranipalValues, "Brow_Down_Right", "BrowD_R", "BrowDownRight");
                Brow_Inner_Up = ParseFloat(sranipalValues, "Brow_Inner_Up", "BrowU_C", "BrowInnerUp");
                Brow_Outer_Up_Left = ParseFloat(sranipalValues, "Brow_Outer_Up_Left", "BrowU_L", "BrowOuterUpLeft");
                Brow_Outer_Up_Right = ParseFloat(sranipalValues, "Brow_Outer_Up_Right", "BrowU_R", "BrowOuterUpRight");
            }
            catch (Exception e)
            {
                SuperController.LogError($"Unable to retrieve SRanipal morph values from JSON message");
                throw e;
            }
        }
    }

}