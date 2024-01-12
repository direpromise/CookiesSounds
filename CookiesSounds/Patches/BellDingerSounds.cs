using BepInEx;
using LCSoundTool;
using HarmonyLib;
using System;
using UnityEngine;

namespace CookiesSounds.Patches
{
    internal class BellDingerSounds
    {
        AudioClip newRandomSound1;
        AudioClip newRandomSound2;

        // Constructor or initialization method
        internal BellDingerSounds()
        {
            newRandomSound1 = SoundTool.GetAudioClip("ChocolateCookies-CookiesSounds", "Sounds", "BellDinger1.wav");
            newRandomSound2 = SoundTool.GetAudioClip("ChocolateCookies-CookiesSounds", "Sounds", "BellDinger2.wav");

            SoundTool.ReplaceAudioClip("BellDinger", newRandomSound1, 0.50f);
            SoundTool.ReplaceAudioClip("BellDinger", newRandomSound2, 0.50f);
        }
    }
}
