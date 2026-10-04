// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class GroupMemberStatusEvent : PacketBase // TypeDefIndex: 12752
{
	// Fields
	[CompilerGenerated]
	private GroupMemberStatusData[] <Members>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 95, IsOptional = True)]
	public GroupMemberStatusData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3650C20 Offset: 0x364CC20 VA: 0x3650C20
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3650C28 Offset: 0x364CC28 VA: 0x3650C28
	public GroupMemberStatusData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3650C30 Offset: 0x364CC30 VA: 0x3650C30
	public void set_Members(GroupMemberStatusData[] value) { }

	// RVA: 0x3650C38 Offset: 0x364CC38 VA: 0x3650C38
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650D38 Offset: 0x364CD38 VA: 0x3650D38
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650DC4 Offset: 0x364CDC4 VA: 0x3650DC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3650DCC Offset: 0x364CDCC VA: 0x3650DCC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650E64 Offset: 0x364CE64 VA: 0x3650E64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
