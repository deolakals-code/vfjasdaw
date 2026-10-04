// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidTrophysResponse : OperationResponseBase // TypeDefIndex: 11563
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, byte> <Trophys>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 210)]
	public byte HighRaidNo { get; set; }
	[PacketParameter(Code = 213)]
	public Dictionary<byte, byte> Trophys { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371AD28 Offset: 0x3716D28 VA: 0x371AD28
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371AD30 Offset: 0x3716D30 VA: 0x371AD30
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371AD38 Offset: 0x3716D38 VA: 0x371AD38
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371AD40 Offset: 0x3716D40 VA: 0x371AD40
	public Dictionary<byte, byte> get_Trophys() { }

	[CompilerGenerated]
	// RVA: 0x371AD48 Offset: 0x3716D48 VA: 0x371AD48
	public void set_Trophys(Dictionary<byte, byte> value) { }

	// RVA: 0x371AD50 Offset: 0x3716D50 VA: 0x371AD50
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371AE3C Offset: 0x3716E3C VA: 0x371AE3C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371AEA8 Offset: 0x3716EA8 VA: 0x371AEA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371AEB0 Offset: 0x3716EB0 VA: 0x371AEB0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371AEB8 Offset: 0x3716EB8 VA: 0x371AEB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371AFE8 Offset: 0x3716FE8 VA: 0x371AFE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
