// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trades
public class TradeReadyOk_ : OperationRequestBase // TypeDefIndex: 11698
{
	// Fields
	[CompilerGenerated]
	private ItemSelectData[] <SelectItems>k__BackingField; // 0x20
	[CompilerGenerated]
	private long[] <StarGemUuids>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30

	// Properties
	public ItemSelectData[] SelectItems { get; set; }
	public long[] StarGemUuids { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3734E9C Offset: 0x3730E9C VA: 0x3734E9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3734EA4 Offset: 0x3730EA4 VA: 0x3734EA4
	public ItemSelectData[] get_SelectItems() { }

	[CompilerGenerated]
	// RVA: 0x3734EAC Offset: 0x3730EAC VA: 0x3734EAC
	public void set_SelectItems(ItemSelectData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3734EB4 Offset: 0x3730EB4 VA: 0x3734EB4
	public long[] get_StarGemUuids() { }

	[CompilerGenerated]
	// RVA: 0x3734EBC Offset: 0x3730EBC VA: 0x3734EBC
	public void set_StarGemUuids(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x3734EC4 Offset: 0x3730EC4 VA: 0x3734EC4
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3734ECC Offset: 0x3730ECC VA: 0x3734ECC
	public void set_Gold(int value) { }

	// RVA: 0x3734ED4 Offset: 0x3730ED4 VA: 0x3734ED4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3734EDC Offset: 0x3730EDC VA: 0x3734EDC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3734EE4 Offset: 0x3730EE4 VA: 0x3734EE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3734FE0 Offset: 0x3730FE0 VA: 0x3734FE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
