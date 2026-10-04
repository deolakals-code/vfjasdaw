// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIScoreAttackEnterBasePanel // TypeDefIndex: 6239
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

	// RVA: 0x18C6C70 Offset: 0x18C2C70 VA: 0x18C6C70 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x18C6C78 Offset: 0x18C2C78 VA: 0x18C6C78 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x18C6C80 Offset: 0x18C2C80 VA: 0x18C6C80 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x18C6C88 Offset: 0x18C2C88 VA: 0x18C6C88
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18C6ED0 Offset: 0x18C2ED0 VA: 0x18C6ED0 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x18C6ED8 Offset: 0x18C2ED8 VA: 0x18C6ED8 Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x18C6EDC Offset: 0x18C2EDC VA: 0x18C6EDC Slot: 10
	public virtual bool Cancel() { }
}
