// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyFieldMemberListEvent : PacketBase // TypeDefIndex: 12869
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ArchetypeUid[] <PartyMembers>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, object> <NewJoinMemberData>k__BackingField; // 0x30

	// Properties
	public int PartyId { get; set; }
	public ArchetypeUid[] PartyMembers { get; set; }
	public Dictionary<byte, object> NewJoinMemberData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366C1E8 Offset: 0x36681E8 VA: 0x366C1E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366C1F0 Offset: 0x36681F0 VA: 0x366C1F0
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366C1F8 Offset: 0x36681F8 VA: 0x366C1F8
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366C200 Offset: 0x3668200 VA: 0x366C200
	public ArchetypeUid[] get_PartyMembers() { }

	[CompilerGenerated]
	// RVA: 0x366C208 Offset: 0x3668208 VA: 0x366C208
	public void set_PartyMembers(ArchetypeUid[] value) { }

	[CompilerGenerated]
	// RVA: 0x366C210 Offset: 0x3668210 VA: 0x366C210
	public Dictionary<byte, object> get_NewJoinMemberData() { }

	[CompilerGenerated]
	// RVA: 0x366C218 Offset: 0x3668218 VA: 0x366C218
	public void set_NewJoinMemberData(Dictionary<byte, object> value) { }

	// RVA: 0x366C220 Offset: 0x3668220 VA: 0x366C220 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366C228 Offset: 0x3668228 VA: 0x366C228 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366C50C Offset: 0x366850C VA: 0x366C50C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
