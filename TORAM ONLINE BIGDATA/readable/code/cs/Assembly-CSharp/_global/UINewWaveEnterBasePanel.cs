// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UINewWaveEnterBasePanel // TypeDefIndex: 6157
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

	// RVA: 0x18A7350 Offset: 0x18A3350 VA: 0x18A7350 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x18A7358 Offset: 0x18A3358 VA: 0x18A7358 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x18A7360 Offset: 0x18A3360 VA: 0x18A7360 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x18A7368 Offset: 0x18A3368 VA: 0x18A7368
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18A75B0 Offset: 0x18A35B0 VA: 0x18A75B0 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x18A75B8 Offset: 0x18A35B8 VA: 0x18A75B8 Slot: 9
	public virtual void BattleReady(byte[] bonusList) { }

	// RVA: 0x18A75BC Offset: 0x18A35BC VA: 0x18A75BC Slot: 10
	public virtual bool Cancel() { }
}
