// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UINaCollaborationEnterBasePanel // TypeDefIndex: 6134
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

	// RVA: 0x18984BC Offset: 0x18944BC VA: 0x18984BC Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x18984C4 Offset: 0x18944C4 VA: 0x18984C4 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x18984CC Offset: 0x18944CC VA: 0x18984CC Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x18984D4 Offset: 0x18944D4 VA: 0x18984D4
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x189871C Offset: 0x189471C VA: 0x189871C Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x1898724 Offset: 0x1894724 VA: 0x1898724 Slot: 9
	public virtual void BattleReady(byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x1898728 Offset: 0x1894728 VA: 0x1898728 Slot: 10
	public virtual bool Cancel() { }
}
