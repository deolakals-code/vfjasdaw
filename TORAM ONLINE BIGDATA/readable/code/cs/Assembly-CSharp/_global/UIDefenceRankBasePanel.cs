// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIDefenceRankBasePanel // TypeDefIndex: 5752
{
	// Fields
	protected UIPartyMember[] partyMemberData; // 0x10
	protected TweenPosition[] partyMemberEffect; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20
	protected bool enterCheck; // 0x28

	// Properties
	public virtual bool IsReady { get; }
	public virtual bool IsRankCheck { get; }
	public virtual bool IsSelectUser { get; }

	// Methods

	// RVA: 0x17DCD68 Offset: 0x17D8D68 VA: 0x17DCD68 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x17DCD70 Offset: 0x17D8D70 VA: 0x17DCD70 Slot: 5
	public virtual bool get_IsRankCheck() { }

	// RVA: 0x17DCD78 Offset: 0x17D8D78 VA: 0x17DCD78 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x17DCD80 Offset: 0x17D8D80 VA: 0x17DCD80
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17DCFC8 Offset: 0x17D8FC8 VA: 0x17DCFC8 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x17DCFD0 Offset: 0x17D8FD0 VA: 0x17DCFD0 Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x17DCFD4 Offset: 0x17D8FD4 VA: 0x17DCFD4 Slot: 10
	public virtual bool Cancel() { }

	// RVA: 0x17DCFDC Offset: 0x17D8FDC VA: 0x17DCFDC Slot: 11
	public virtual void Rank() { }
}
