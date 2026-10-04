// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildQuestBoardManager.GuildQuestSmith : UIGuildQuestBoardManager.GuildQuestDataBase // TypeDefIndex: 6653
{
	// Methods

	// RVA: 0x19AAB08 Offset: 0x19A6B08 VA: 0x19AAB08
	public void .ctor(GuildOrderQuestData data, UIGuildQuestBoardManager.GuildQuestMaseter maseter, string typeText) { }

	// RVA: 0x19ABD68 Offset: 0x19A7D68 VA: 0x19ABD68
	private bool ValCheck(int maseterVal, int checkVal) { }

	// RVA: 0x19ABD88 Offset: 0x19A7D88 VA: 0x19ABD88
	public bool CheckItem(ItemData x) { }

	// RVA: 0x19ABFA8 Offset: 0x19A7FA8 VA: 0x19ABFA8
	public bool LockItem(ItemData x) { }

	// RVA: 0x19AC014 Offset: 0x19A8014 VA: 0x19AC014
	public List<ItemData> GetTargetItemData(ItemManager itemManager) { }

	// RVA: 0x19AC0A4 Offset: 0x19A80A4 VA: 0x19AC0A4 Slot: 4
	public override UIGuildQuestBoardManager.GuildQuestDataBase.State CheckState(ItemManager itemManager) { }

	// RVA: 0x19AC104 Offset: 0x19A8104 VA: 0x19AC104 Slot: 5
	public override string TargetWord() { }

	// RVA: 0x19AC454 Offset: 0x19A8454 VA: 0x19AC454 Slot: 6
	public override string CountWord(SystemTextManager systemManager, ItemManager itemManager) { }

	// RVA: 0x19AC4B8 Offset: 0x19A84B8 VA: 0x19AC4B8 Slot: 8
	public override Color GetFrameColor() { }

	// RVA: 0x19AC4D8 Offset: 0x19A84D8 VA: 0x19AC4D8 Slot: 9
	public override void SetTargetIcon(UIIconBase icon) { }
}
