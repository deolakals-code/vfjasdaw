// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class GuildStaffChangeFlag : OperationRequestBase // TypeDefIndex: 12412
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Value>k__BackingField; // 0x21

	// Properties
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	[PacketParameter(Code = 195)]
	public byte Value { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3603578 Offset: 0x35FF578 VA: 0x3603578
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3603580 Offset: 0x35FF580 VA: 0x3603580
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3603588 Offset: 0x35FF588 VA: 0x3603588
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3603590 Offset: 0x35FF590 VA: 0x3603590
	public byte get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3603598 Offset: 0x35FF598 VA: 0x3603598
	public void set_Value(byte value) { }

	// RVA: 0x36035A0 Offset: 0x35FF5A0 VA: 0x36035A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36035A8 Offset: 0x35FF5A8 VA: 0x36035A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36035B0 Offset: 0x35FF5B0 VA: 0x36035B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360371C Offset: 0x35FF71C VA: 0x360371C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
