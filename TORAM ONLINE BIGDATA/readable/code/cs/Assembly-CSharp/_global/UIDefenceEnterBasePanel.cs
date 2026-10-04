// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIDefenceEnterBasePanel // TypeDefIndex: 5745
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

	// RVA: 0x17DA658 Offset: 0x17D6658 VA: 0x17DA658 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x17DA660 Offset: 0x17D6660 VA: 0x17DA660 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x17DA668 Offset: 0x17D6668 VA: 0x17DA668 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x17DA670 Offset: 0x17D6670 VA: 0x17DA670
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17DA8B8 Offset: 0x17D68B8 VA: 0x17DA8B8 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x17DA8C0 Offset: 0x17D68C0 VA: 0x17DA8C0 Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x17DA8C4 Offset: 0x17D68C4 VA: 0x17DA8C4 Slot: 10
	public virtual bool Cancel() { }

	// RVA: 0x17DA8CC Offset: 0x17D68CC VA: 0x17DA8CC Slot: 11
	public virtual void Enter() { }
}
