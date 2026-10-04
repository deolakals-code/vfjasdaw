// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Missions
public class MissionItemCommon : BinaryBase, IScenarioItem // TypeDefIndex: 11095
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <ItemNum>k__BackingField; // 0x20

	// Properties
	[BinaryParameter]
	public byte No { get; set; }
	[BinaryParameter]
	public int ItemId { get; set; }
	[BinaryParameter]
	public short ItemNum { get; set; }

	// Methods

	// RVA: 0x35B856C Offset: 0x35B456C VA: 0x35B856C
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B9134 Offset: 0x35B5134 VA: 0x35B9134 Slot: 8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35B913C Offset: 0x35B513C VA: 0x35B913C Slot: 11
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B9144 Offset: 0x35B5144 VA: 0x35B9144 Slot: 9
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35B914C Offset: 0x35B514C VA: 0x35B914C Slot: 12
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B9154 Offset: 0x35B5154 VA: 0x35B9154 Slot: 10
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x35B915C Offset: 0x35B515C VA: 0x35B915C Slot: 13
	public void set_ItemNum(short value) { }

	// RVA: 0x35B9164 Offset: 0x35B5164 VA: 0x35B9164 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B9284 Offset: 0x35B5284 VA: 0x35B9284 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
