﻿using BepInEx;
using HarmonyLib;
using System.Reflection;

// TODO: Look into checking collider values and just using those to dictate snap points for furniture
namespace ExtraSnapPointsMadeEasy
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class ExtraSnapPointsMadeEasy : BaseUnityPlugin
    {
        internal const string PluginName = "ExtraSnapPointsMadeEasy";
        internal const string Author = "Searica";
        public const string PluginGuid = $"{Author}.Valheim.{PluginName}";
        public const string PluginVersion = "1.1.1";

        private void Awake()
        {
            Log.Init(Logger);
            PluginConfig.Init(Config);
            PluginConfig.SetUp();

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), harmonyInstanceId: PluginGuid);

            PluginConfig.SetupWatcher();
            PluginConfig.CheckForConfigManager();
        }

        private void OnDestroy()
        {
            PluginConfig.Save();
        }

        /// <summary>
        ///     Public API so other mods can rescan piece tables and add
        ///     extra snap points after dynamically adding/removing pieces
        ///     from piece tables.
        /// </summary>
        /// <param name="msg"></param>
        public static void ReInitExtraSnapPoints(string msg)
        {
            ExtraSnapPoints.AddExtraSnapPoints(msg, true);
        }
    }
}