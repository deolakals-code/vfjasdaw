// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIBossRaidSymbolBasePanel // TypeDefIndex: 5649
{
	// Fields
	protected UIPartyMember[] partyMemberData; // 0x10
	protected TweenPosition[] partyMemberEffect; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20

	// Properties
	public virtual bool IsReady { get; }

	// Methods

	// RVA: 0x17B8494 Offset: 0x17B4494 VA: 0x17B8494 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x17B849C Offset: 0x17B449C VA: 0x17B849C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17B86DC Offset: 0x17B46DC VA: 0x17B86DC Slot: 5
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Update();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void BattleReady();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Cancel();
}
