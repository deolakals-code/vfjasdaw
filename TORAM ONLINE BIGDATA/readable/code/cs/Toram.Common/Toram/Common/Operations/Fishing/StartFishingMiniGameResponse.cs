// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class StartFishingMiniGameResponse : OperationResponseBase // TypeDefIndex: 11657
{
	// Fields
	[CompilerGenerated]
	private byte <Stamina>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <MovePattern>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 10)]
	public byte Stamina { get; set; }
	[PacketParameter(Code = 15)]
	public short[] MovePattern { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372C738 Offset: 0x3728738 VA: 0x372C738
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372C740 Offset: 0x3728740 VA: 0x372C740
	public byte get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x372C748 Offset: 0x3728748 VA: 0x372C748
	public void set_Stamina(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372C750 Offset: 0x3728750 VA: 0x372C750
	public short[] get_MovePattern() { }

	[CompilerGenerated]
	// RVA: 0x372C758 Offset: 0x3728758 VA: 0x372C758
	public void set_MovePattern(short[] value) { }

	// RVA: 0x372C760 Offset: 0x3728760 VA: 0x372C760 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372C768 Offset: 0x3728768 VA: 0x372C768 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372C770 Offset: 0x3728770 VA: 0x372C770 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372C824 Offset: 0x3728824 VA: 0x372C824 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
