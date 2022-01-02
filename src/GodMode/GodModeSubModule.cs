using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace GodMode
{
    public sealed class GodModeSubModule : MBSubModuleBase
    {
        private bool Loaded { get; set; }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

            if (Loaded)
            {
                return;
            }

            new Harmony("GodMode").PatchAll();
            InformationManager.DisplayMessage(new InformationMessage(new TextObject("{=miUO4w1hn}Loaded God Mode.").ToString()));
            Loaded = true;
        }
    }
}
