using Il2Cpp;
using MelonLoader;

namespace IncreaseSaveSlotLimit;

internal class Implementation : MelonMod
{
	public override void OnInitializeMelon()
	{
		SaveGameSlots.MAX_SAVESLOTS = 999;
	}
}
