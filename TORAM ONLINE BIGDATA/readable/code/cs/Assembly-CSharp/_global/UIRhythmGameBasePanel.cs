// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIRhythmGameBasePanel // TypeDefIndex: 6199
{
	// Fields
	protected UILabel[] nameLabel; // 0x10
	protected UILabel[] readyLabel; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20
	protected SystemTextManager systemTextManager; // 0x28
	protected string[] stateTextList; // 0x30
	protected bool enterCheck; // 0x38

	// Properties
	public virtual bool IsReady { get; }
	public virtual bool IsEnterCheck { get; }
	public virtual bool IsSelectUser { get; }

	// Methods

	// RVA: 0x18B6F14 Offset: 0x18B2F14 VA: 0x18B6F14 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x18B6F1C Offset: 0x18B2F1C VA: 0x18B6F1C Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x18B6F24 Offset: 0x18B2F24 VA: 0x18B6F24 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x18B6F2C Offset: 0x18B2F2C VA: 0x18B6F2C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18B7328 Offset: 0x18B3328 VA: 0x18B7328 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BattleReady(RhythmGameState gameState, int musicId, byte difficulty);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Cancel();
}
