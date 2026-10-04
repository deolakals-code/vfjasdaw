// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class DiscardFishingRodResponse : OperationResponseBase // TypeDefIndex: 11648
{
	// Fields
	[CompilerGenerated]
	private byte <RodIndex>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 62)]
	public byte RodIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372B2EC Offset: 0x37272EC VA: 0x372B2EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372B2F4 Offset: 0x37272F4 VA: 0x372B2F4
	public byte get_RodIndex() { }

	[CompilerGenerated]
	// RVA: 0x372B2FC Offset: 0x37272FC VA: 0x372B2FC
	public void set_RodIndex(byte value) { }

	// RVA: 0x372B304 Offset: 0x3727304 VA: 0x372B304 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372B30C Offset: 0x372730C VA: 0x372B30C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372B314 Offset: 0x3727314 VA: 0x372B314 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372B3B4 Offset: 0x37273B4 VA: 0x372B3B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
