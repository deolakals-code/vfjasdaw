// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global
public class GlobalChangeResponse : OperationResponseBase // TypeDefIndex: 11569
{
	// Fields
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GlobalEventId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <LocationId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Result>k__BackingField; // 0x2A

	// Properties
	public int WorldId { get; set; }
	public int GlobalEventId { get; set; }
	public short LocationId { get; set; }
	public byte Result { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371C554 Offset: 0x3718554 VA: 0x371C554
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371C55C Offset: 0x371855C VA: 0x371C55C
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x371C564 Offset: 0x3718564 VA: 0x371C564
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371C56C Offset: 0x371856C VA: 0x371C56C
	public int get_GlobalEventId() { }

	[CompilerGenerated]
	// RVA: 0x371C574 Offset: 0x3718574 VA: 0x371C574
	public void set_GlobalEventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371C57C Offset: 0x371857C VA: 0x371C57C
	public short get_LocationId() { }

	[CompilerGenerated]
	// RVA: 0x371C584 Offset: 0x3718584 VA: 0x371C584
	public void set_LocationId(short value) { }

	[CompilerGenerated]
	// RVA: 0x371C58C Offset: 0x371858C VA: 0x371C58C
	public byte get_Result() { }

	[CompilerGenerated]
	// RVA: 0x371C594 Offset: 0x3718594 VA: 0x371C594
	public void set_Result(byte value) { }

	// RVA: 0x371C59C Offset: 0x371859C VA: 0x371C59C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371C5A4 Offset: 0x37185A4 VA: 0x371C5A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371C5AC Offset: 0x37185AC VA: 0x371C5AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371C7C8 Offset: 0x37187C8 VA: 0x371C7C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
