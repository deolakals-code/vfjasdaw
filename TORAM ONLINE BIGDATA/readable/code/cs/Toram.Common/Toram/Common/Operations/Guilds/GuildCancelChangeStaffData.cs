// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCancelChangeStaffData : OperationRequestBase // TypeDefIndex: 12361
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FAC34 Offset: 0x35F6C34 VA: 0x35FAC34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FAC3C Offset: 0x35F6C3C VA: 0x35FAC3C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35FAC44 Offset: 0x35F6C44 VA: 0x35FAC44
	public void set_Type(byte value) { }

	// RVA: 0x35FAC4C Offset: 0x35F6C4C VA: 0x35FAC4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FAC54 Offset: 0x35F6C54 VA: 0x35FAC54 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FAC5C Offset: 0x35F6C5C VA: 0x35FAC5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FACFC Offset: 0x35F6CFC VA: 0x35FACFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
