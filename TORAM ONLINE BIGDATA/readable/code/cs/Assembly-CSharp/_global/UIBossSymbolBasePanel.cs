// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIBossSymbolBasePanel // TypeDefIndex: 6397
{
	// Fields
	protected UIPartyMember[] partyMemberData; // 0x10
	protected TweenPosition[] partyMemberEffect; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20

	// Properties
	public virtual bool IsReady { get; }

	// Methods

	// RVA: 0x1925548 Offset: 0x1921548 VA: 0x1925548 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x1925550 Offset: 0x1921550 VA: 0x1925550
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1925790 Offset: 0x1921790 VA: 0x1925790 Slot: 5
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Update();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void BattleReady(int[] itemList, int[] orbItemList);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Cancel();
}
