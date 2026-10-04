// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidPointResponse : OperationResponseBase // TypeDefIndex: 11560
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <NowPoint>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <AcquiredFlag>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 210)]
	public byte HighRaidNo { get; set; }
	[PacketParameter(Code = 205)]
	public int NowPoint { get; set; }
	[PacketParameter(Code = 141)]
	public byte AcquiredFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371A5B4 Offset: 0x37165B4 VA: 0x371A5B4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371A5BC Offset: 0x37165BC VA: 0x371A5BC
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371A5C4 Offset: 0x37165C4 VA: 0x371A5C4
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371A5CC Offset: 0x37165CC VA: 0x371A5CC
	public int get_NowPoint() { }

	[CompilerGenerated]
	// RVA: 0x371A5D4 Offset: 0x37165D4 VA: 0x371A5D4
	public void set_NowPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x371A5DC Offset: 0x37165DC VA: 0x371A5DC
	public byte get_AcquiredFlag() { }

	[CompilerGenerated]
	// RVA: 0x371A5E4 Offset: 0x37165E4 VA: 0x371A5E4
	public void set_AcquiredFlag(byte value) { }

	// RVA: 0x371A5EC Offset: 0x37165EC VA: 0x371A5EC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371A5F0 Offset: 0x37165F0 VA: 0x371A5F0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371A5F4 Offset: 0x37165F4 VA: 0x371A5F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371A5FC Offset: 0x37165FC VA: 0x371A5FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371A604 Offset: 0x3716604 VA: 0x371A604 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371A710 Offset: 0x3716710 VA: 0x371A710 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
