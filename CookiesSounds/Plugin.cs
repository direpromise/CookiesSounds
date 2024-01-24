using BepInEx;
using LCSoundTool;
using UnityEngine;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesSounds.Patches;

namespace CookiesSounds
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {

        private const string modGUID = "ChocolateCookies.CookiesSounds";
        private const string modName = "CookiesSounds";
        private const string modVersion = "1.0.6";

        private readonly Harmony _harmony = new Harmony(modGUID);

        private void Awake()
        {
            _harmony.PatchAll(typeof(BellDingerSounds));
            Logger.LogInfo($"Plugin {modGUID} is loaded!");
        }
    }
}
