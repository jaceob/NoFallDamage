using GameNetcodeStuff;
using HarmonyLib;

namespace NoFallDamage.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void noFallDamagePatch(ref float ___timeSinceTakingGravityDamage)
        {
            ___timeSinceTakingGravityDamage = 0f;
        }
    }
}
