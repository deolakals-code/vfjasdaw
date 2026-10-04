// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Registlet
public class RegistletChangeGemCartFlag : OperationRequestBase // TypeDefIndex: 11446
{
	// Fields
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 137)]
	public long Uuid { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370BDCC Offset: 0x3707DCC VA: 0x370BDCC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370BDD4 Offset: 0x3707DD4 VA: 0x370BDD4
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x370BDDC Offset: 0x3707DDC VA: 0x370BDDC
	public void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x370BDE4 Offset: 0x3707DE4 VA: 0x370BDE4
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x370BDEC Offset: 0x3707DEC VA: 0x370BDEC
	public void set_Flag(byte value) { }

	// RVA: 0x370BDF4 Offset: 0x3707DF4 VA: 0x370BDF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370BDFC Offset: 0x3707DFC VA: 0x370BDFC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370BE04 Offset: 0x3707E04 VA: 0x370BE04 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x370BEE8 Offset: 0x3707EE8 VA: 0x370BEE8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
