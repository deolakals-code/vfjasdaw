// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ChangeEquipFishingRod : OperationRequestBase // TypeDefIndex: 11650
{
	// Fields
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 62)]
	public byte Index { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372B6BC Offset: 0x37276BC VA: 0x372B6BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372B6C4 Offset: 0x37276C4 VA: 0x372B6C4
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x372B6CC Offset: 0x37276CC VA: 0x372B6CC
	public void set_Index(byte value) { }

	// RVA: 0x372B6D4 Offset: 0x37276D4 VA: 0x372B6D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372B6DC Offset: 0x37276DC VA: 0x372B6DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372B6E4 Offset: 0x37276E4 VA: 0x372B6E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372B784 Offset: 0x3727784 VA: 0x372B784 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
