// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ChangeEquipFishingRodResponse : OperationResponseBase // TypeDefIndex: 11651
{
	// Fields
	[CompilerGenerated]
	private byte <EquipRodIndex>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 62)]
	public byte EquipRodIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372B8A4 Offset: 0x37278A4 VA: 0x372B8A4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372B8AC Offset: 0x37278AC VA: 0x372B8AC
	public byte get_EquipRodIndex() { }

	[CompilerGenerated]
	// RVA: 0x372B8B4 Offset: 0x37278B4 VA: 0x372B8B4
	public void set_EquipRodIndex(byte value) { }

	// RVA: 0x372B8BC Offset: 0x37278BC VA: 0x372B8BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372B8C4 Offset: 0x37278C4 VA: 0x372B8C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372B8CC Offset: 0x37278CC VA: 0x372B8CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372B96C Offset: 0x372796C VA: 0x372B96C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
