// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIHighRaidEnterBasePanel // TypeDefIndex: 5795
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

	// RVA: 0x17F3E18 Offset: 0x17EFE18 VA: 0x17F3E18 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x17F3E20 Offset: 0x17EFE20 VA: 0x17F3E20 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x17F3E28 Offset: 0x17EFE28 VA: 0x17F3E28 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x17F3E30 Offset: 0x17EFE30 VA: 0x17F3E30
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17F4078 Offset: 0x17F0078 VA: 0x17F4078 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x17F4080 Offset: 0x17F0080 VA: 0x17F4080 Slot: 9
	public virtual void BattleReady(int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x17F4084 Offset: 0x17F0084 VA: 0x17F4084 Slot: 10
	public virtual void BattleReady(byte[] list) { }

	// RVA: 0x17F4088 Offset: 0x17F0088 VA: 0x17F4088 Slot: 11
	public virtual bool Cancel() { }
}
