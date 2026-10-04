// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Facility
public class GuildLevelUpFacility : OperationRequestBase // TypeDefIndex: 12442
{
	// Fields
	[CompilerGenerated]
	private int <FacilityId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x26

	// Properties
	[PacketParameter(Code = 0)]
	public int FacilityId { get; set; }
	[PacketParameter(Code = 10)]
	public short Lv { get; set; }
	[PacketParameter(Code = 11)]
	public byte Element { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3608EBC Offset: 0x3604EBC VA: 0x3608EBC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3608EC4 Offset: 0x3604EC4 VA: 0x3608EC4
	public int get_FacilityId() { }

	[CompilerGenerated]
	// RVA: 0x3608ECC Offset: 0x3604ECC VA: 0x3608ECC
	public void set_FacilityId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3608ED4 Offset: 0x3604ED4 VA: 0x3608ED4
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x3608EDC Offset: 0x3604EDC VA: 0x3608EDC
	public void set_Lv(short value) { }

	[CompilerGenerated]
	// RVA: 0x3608EE4 Offset: 0x3604EE4 VA: 0x3608EE4
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x3608EEC Offset: 0x3604EEC VA: 0x3608EEC
	public void set_Element(byte value) { }

	// RVA: 0x3608EF4 Offset: 0x3604EF4 VA: 0x3608EF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3608EFC Offset: 0x3604EFC VA: 0x3608EFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3608F04 Offset: 0x3604F04 VA: 0x3608F04 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3609024 Offset: 0x3605024 VA: 0x3609024 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
