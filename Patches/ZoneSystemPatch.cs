﻿using HarmonyLib;

namespace ExtraSnapPointsMadeEasy.Patches
{
    // hook right when the game first starts
    // to avoid touching pieces added by mods
    [HarmonyPatch(typeof(ZoneSystem))]
    internal class ZoneSystemPatch
    {
        [HarmonyPostfix]
        [HarmonyPriority(Priority.Low)]
        [HarmonyPatch(nameof(ZoneSystem.Start))]
        public static void Start()
        {
            if (!ZNetScene.instance)
            {
                return;
            }
            ExtraSnapPoints.AddExtraSnapPoints();
        }
    }
}