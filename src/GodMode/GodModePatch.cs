using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace GodMode
{
    [HarmonyPatch(typeof(MissionBehavior), nameof(MissionBehavior.OnMissionTick))]
    public static class GodModePatch
    {
        public static void Postfix()
        {
            Agent.Main?.SetInvulnerable(true);
        }
    }
}
