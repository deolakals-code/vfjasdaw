// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIRezeroRaidEnterBasePanel // TypeDefIndex: 6183
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

	// RVA: 0x18B3EB0 Offset: 0x18AFEB0 VA: 0x18B3EB0 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x18B3EB8 Offset: 0x18AFEB8 VA: 0x18B3EB8 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x18B3EC0 Offset: 0x18AFEC0 VA: 0x18B3EC0 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x18B3EC8 Offset: 0x18AFEC8 VA: 0x18B3EC8
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18B4110 Offset: 0x18B0110 VA: 0x18B4110 Slot: 7
	public virtual byte Initialize() { }

	// RVA: 0x18B4118 Offset: 0x18B0118 VA: 0x18B4118 Slot: 8
	public virtual bool Update() { }

	// RVA: 0x18B4120 Offset: 0x18B0120 VA: 0x18B4120 Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x18B4124 Offset: 0x18B0124 VA: 0x18B4124 Slot: 10
	public virtual bool Cancel() { }

	// RVA: 0x18B412C Offset: 0x18B012C VA: 0x18B412C Slot: 11
	public virtual void Enter() { }
}
