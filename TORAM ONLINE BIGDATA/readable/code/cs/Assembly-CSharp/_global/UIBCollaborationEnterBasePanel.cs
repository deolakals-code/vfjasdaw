// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIBCollaborationEnterBasePanel // TypeDefIndex: 5622
{
	// Fields
	protected UIPartyMember[] partyMemberData; // 0x10
	protected TweenPosition[] partyMemberEffect; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20
	private BCollaborationRoomData roomData; // 0x28
	protected bool enterCheck; // 0x30

	// Properties
	protected BCollaborationRoomData RoomData { get; }
	public virtual bool IsReady { get; }
	public virtual bool IsEnterCheck { get; }
	public virtual bool IsSelectUser { get; }

	// Methods

	// RVA: 0x17AA528 Offset: 0x17A6528 VA: 0x17AA528
	protected BCollaborationRoomData get_RoomData() { }

	// RVA: 0x17AA608 Offset: 0x17A6608 VA: 0x17AA608 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x17AA610 Offset: 0x17A6610 VA: 0x17AA610 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x17AA618 Offset: 0x17A6618 VA: 0x17AA618 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x17AA620 Offset: 0x17A6620 VA: 0x17AA620
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17AA868 Offset: 0x17A6868 VA: 0x17AA868 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x17AA870 Offset: 0x17A6870 VA: 0x17AA870 Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x17AA874 Offset: 0x17A6874 VA: 0x17AA874 Slot: 10
	public virtual bool Cancel() { }
}
