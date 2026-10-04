// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIGuildQuestBoardManager.GuildQuestDataBase // TypeDefIndex: 6650
{
	// Fields
	public readonly int UID; // 0x10
	public readonly byte No; // 0x14
	public readonly UIGuildQuestBoardManager.GuildQuestMaseter Master; // 0x18
	public readonly RewardData[] Rewards; // 0x38
	public readonly string TypeIcon; // 0x40
	public readonly string TypeText; // 0x48
	public readonly int Gold; // 0x50

	// Methods

	// RVA: 0x19AB3DC Offset: 0x19A73DC VA: 0x19AB3DC
	public void .ctor(GuildOrderQuestData data, UIGuildQuestBoardManager.GuildQuestMaseter maseter, string typeIcon, string typeText) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract UIGuildQuestBoardManager.GuildQuestDataBase.State CheckState(ItemManager itemManager);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string TargetWord();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string CountWord(SystemTextManager systemManager, ItemManager itemManager);

	// RVA: 0x19AB478 Offset: 0x19A7478 VA: 0x19AB478 Slot: 7
	public virtual string GetPaperText(SystemTextManager systemManager, ItemManager itemManager) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Color GetFrameColor();

	// RVA: 0x19AB520 Offset: 0x19A7520 VA: 0x19AB520
	public List<QuestManager.RewardData> GetPopRewardData() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetTargetIcon(UIIconBase icon);
}
