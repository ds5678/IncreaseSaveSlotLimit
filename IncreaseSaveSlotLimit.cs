internal class IncreaseSaveSlotLimit {
	public static void OnLoad() {
		SaveGameSlots.MAX_SAVESLOTS = 999;
	}
}
