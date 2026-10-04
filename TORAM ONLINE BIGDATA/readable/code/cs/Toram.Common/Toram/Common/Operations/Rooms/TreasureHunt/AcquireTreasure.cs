// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.TreasureHunt
public class AcquireTreasure : OperationRequestBase // TypeDefIndex: 11784
{
	// Fields
	[CompilerGenerated]
	private TreasureHuntTreasureData <Treasure>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 199)]
	public TreasureHuntTreasureData Treasure { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374A82C Offset: 0x374682C VA: 0x374A82C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374A834 Offset: 0x3746834 VA: 0x374A834
	public TreasureHuntTreasureData get_Treasure() { }

	[CompilerGenerated]
	// RVA: 0x374A83C Offset: 0x374683C VA: 0x374A83C
	public void set_Treasure(TreasureHuntTreasureData value) { }

	// RVA: 0x374A844 Offset: 0x3746844 VA: 0x374A844 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374A84C Offset: 0x374684C VA: 0x374A84C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374A854 Offset: 0x3746854 VA: 0x374A854 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374A8DC Offset: 0x37468DC VA: 0x374A8DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
