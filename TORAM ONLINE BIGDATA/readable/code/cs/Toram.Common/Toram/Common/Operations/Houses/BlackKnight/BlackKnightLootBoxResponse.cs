// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightLootBoxResponse : OperationResponseBase // TypeDefIndex: 12239
{
	// Fields
	[CompilerGenerated]
	private byte <CristaId>k__BackingField; // 0x20

	// Properties
	public byte CristaId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E5AE8 Offset: 0x35E1AE8 VA: 0x35E5AE8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E5AF0 Offset: 0x35E1AF0 VA: 0x35E5AF0
	public byte get_CristaId() { }

	[CompilerGenerated]
	// RVA: 0x35E5AF8 Offset: 0x35E1AF8 VA: 0x35E5AF8
	public void set_CristaId(byte value) { }

	// RVA: 0x35E5B00 Offset: 0x35E1B00 VA: 0x35E5B00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E5B08 Offset: 0x35E1B08 VA: 0x35E5B08 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E5B10 Offset: 0x35E1B10 VA: 0x35E5B10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E5BB0 Offset: 0x35E1BB0 VA: 0x35E5BB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
