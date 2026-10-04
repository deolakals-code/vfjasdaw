// Assembly: Assembly-CSharp.dll
// Namespace: 
private class RoomManager.RoomMembersData // TypeDefIndex: 2454
{
	// Fields
	private Dictionary<int, RoomManager.RoomMeberData> memberData; // 0x10

	// Properties
	public IList<RoomManager.RoomMeberData> MemberData { get; }

	// Methods

	// RVA: 0x21B6F74 Offset: 0x21B2F74 VA: 0x21B6F74
	public IList<RoomManager.RoomMeberData> get_MemberData() { }

	// RVA: 0x21B7574 Offset: 0x21B3574 VA: 0x21B7574
	public void Initialize(List<IRoomMember> memberList) { }

	// RVA: 0x21B97F8 Offset: 0x21B57F8 VA: 0x21B97F8
	public void Add(IRoomMember member) { }

	// RVA: 0x21B93B0 Offset: 0x21B53B0 VA: 0x21B93B0
	public void UpdateData(List<IRoomMember> memberList) { }

	// RVA: 0x21B99C0 Offset: 0x21B59C0 VA: 0x21B99C0
	public bool Remove(int archetypeId) { }

	// RVA: 0x21B7524 Offset: 0x21B3524 VA: 0x21B7524
	public void RemoveAll() { }

	// RVA: 0x21BA968 Offset: 0x21B6968 VA: 0x21BA968
	public bool IsMember(byte archetypeType, int archetypeId) { }

	// RVA: 0x21B9A4C Offset: 0x21B5A4C VA: 0x21B9A4C
	public RoomUserStateType GetState(byte archetypeType, int archetypeId) { }

	// RVA: 0x21B9AF0 Offset: 0x21B5AF0 VA: 0x21B9AF0
	public int GetStateUserNum(RoomUserStateType state) { }

	// RVA: 0x21BA600 Offset: 0x21B6600 VA: 0x21BA600
	public void .ctor() { }
}
