using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace GodMode
{
    [HarmonyPatch(typeof(MissionBehavior), nameof(MissionBehavior.OnMissionTick))]
    public static class GodModePatch
    {
        public static void Postfix()
        {
            if (Agent.Main?.CurrentMortalityState != Agent.MortalityState.Invulnerable)
            {
                Agent.Main?.ToggleInvulnerable();
            }
        }
    }
}
