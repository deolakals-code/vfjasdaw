// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class DiscardFishingRod : OperationRequestBase // TypeDefIndex: 11649
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

	// RVA: 0x372B4D4 Offset: 0x37274D4 VA: 0x372B4D4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372B4DC Offset: 0x37274DC VA: 0x372B4DC
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x372B4E4 Offset: 0x37274E4 VA: 0x372B4E4
	public void set_Index(byte value) { }

	// RVA: 0x372B4EC Offset: 0x37274EC VA: 0x372B4EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372B4F4 Offset: 0x37274F4 VA: 0x372B4F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372B4FC Offset: 0x37274FC VA: 0x372B4FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372B59C Offset: 0x372759C VA: 0x372B59C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
