// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightStartGame : OperationRequestBase // TypeDefIndex: 12237
{
	// Fields
	[CompilerGenerated]
	private byte <StageId>k__BackingField; // 0x20

	// Properties
	public byte StageId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E5718 Offset: 0x35E1718 VA: 0x35E5718
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E5720 Offset: 0x35E1720 VA: 0x35E5720
	public byte get_StageId() { }

	[CompilerGenerated]
	// RVA: 0x35E5728 Offset: 0x35E1728 VA: 0x35E5728
	public void set_StageId(byte value) { }

	// RVA: 0x35E5730 Offset: 0x35E1730 VA: 0x35E5730 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E5738 Offset: 0x35E1738 VA: 0x35E5738 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E5740 Offset: 0x35E1740 VA: 0x35E5740 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E57E0 Offset: 0x35E17E0 VA: 0x35E57E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
