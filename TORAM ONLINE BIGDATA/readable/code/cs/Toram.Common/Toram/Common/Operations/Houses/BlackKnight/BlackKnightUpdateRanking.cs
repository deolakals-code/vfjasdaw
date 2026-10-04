// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightUpdateRanking : OperationRequestBase // TypeDefIndex: 12244
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StageId>k__BackingField; // 0x21

	// Properties
	public byte Type { get; set; }
	public byte StageId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E6794 Offset: 0x35E2794 VA: 0x35E6794
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E679C Offset: 0x35E279C VA: 0x35E679C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35E67A4 Offset: 0x35E27A4 VA: 0x35E67A4
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E67AC Offset: 0x35E27AC VA: 0x35E67AC
	public byte get_StageId() { }

	[CompilerGenerated]
	// RVA: 0x35E67B4 Offset: 0x35E27B4 VA: 0x35E67B4
	public void set_StageId(byte value) { }

	// RVA: 0x35E67BC Offset: 0x35E27BC VA: 0x35E67BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E67C4 Offset: 0x35E27C4 VA: 0x35E67C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E67CC Offset: 0x35E27CC VA: 0x35E67CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E6894 Offset: 0x35E2894 VA: 0x35E6894 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
