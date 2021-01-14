using MelonLoader;
using UnityEngine;

namespace IncreaseSaveSlotLimit
{
    internal class Implementation : MelonMod
    {

        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            SaveGameSlots.MAX_SAVESLOTS = 999;
        }
    }
}
