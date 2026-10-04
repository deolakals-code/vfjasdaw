// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UINCollaborationEnterBasePanel // TypeDefIndex: 6149
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

	// RVA: 0x18A24FC Offset: 0x189E4FC VA: 0x18A24FC Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x18A2504 Offset: 0x189E504 VA: 0x18A2504 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x18A250C Offset: 0x189E50C VA: 0x18A250C Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x18A2514 Offset: 0x189E514 VA: 0x18A2514
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18A275C Offset: 0x189E75C VA: 0x18A275C Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x18A2764 Offset: 0x189E764 VA: 0x18A2764 Slot: 9
	public virtual void BattleReady(byte[] bonusList) { }

	// RVA: 0x18A2768 Offset: 0x189E768 VA: 0x18A2768 Slot: 10
	public virtual bool Cancel() { }
}
