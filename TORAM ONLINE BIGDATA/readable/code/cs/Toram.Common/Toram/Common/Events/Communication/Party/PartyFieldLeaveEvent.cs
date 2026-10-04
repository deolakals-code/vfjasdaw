// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyFieldLeaveEvent : PacketBase // TypeDefIndex: 12868
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366BE7C Offset: 0x3667E7C VA: 0x366BE7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366BE84 Offset: 0x3667E84 VA: 0x366BE84
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366BE8C Offset: 0x3667E8C VA: 0x366BE8C
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366BE94 Offset: 0x3667E94 VA: 0x366BE94
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x366BE9C Offset: 0x3667E9C VA: 0x366BE9C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366BEA4 Offset: 0x3667EA4 VA: 0x366BEA4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366BEAC Offset: 0x3667EAC VA: 0x366BEAC
	public void set_ArchetypeId(int value) { }

	// RVA: 0x366BEB4 Offset: 0x3667EB4 VA: 0x366BEB4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366BEBC Offset: 0x3667EBC VA: 0x366BEBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366C0AC Offset: 0x36680AC VA: 0x366C0AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
