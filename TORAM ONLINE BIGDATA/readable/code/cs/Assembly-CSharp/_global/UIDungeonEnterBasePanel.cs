// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIDungeonEnterBasePanel // TypeDefIndex: 6606
{
	// Fields
	protected UIPartyMember[] partyMemberData; // 0x10
	protected TweenPosition[] partyMemberEffect; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20
	protected bool enterCheck; // 0x28

	// Properties
	public virtual bool IsReady { get; }
	public virtual bool IsEnterCheck { get; }
	public virtual bool IsSelectUser { get; }

	// Methods

	// RVA: 0x1999954 Offset: 0x1995954 VA: 0x1999954 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x199995C Offset: 0x199595C VA: 0x199995C Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x1999964 Offset: 0x1995964 VA: 0x1999964 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x199996C Offset: 0x199596C VA: 0x199996C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1999BB4 Offset: 0x1995BB4 VA: 0x1999BB4 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x1999BBC Offset: 0x1995BBC VA: 0x1999BBC Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x1999BC0 Offset: 0x1995BC0 VA: 0x1999BC0 Slot: 10
	public virtual bool Cancel() { }

	// RVA: 0x1999BC8 Offset: 0x1995BC8 VA: 0x1999BC8 Slot: 11
	public virtual void Enter() { }
}
