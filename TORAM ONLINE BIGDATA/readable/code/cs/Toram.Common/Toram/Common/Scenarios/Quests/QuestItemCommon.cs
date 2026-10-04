// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Quests
public class QuestItemCommon : BinaryBase, IScenarioItem // TypeDefIndex: 11091
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

	// RVA: 0x35B673C Offset: 0x35B273C VA: 0x35B673C
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B77D8 Offset: 0x35B37D8 VA: 0x35B77D8 Slot: 8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35B77E0 Offset: 0x35B37E0 VA: 0x35B77E0 Slot: 11
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B77E8 Offset: 0x35B37E8 VA: 0x35B77E8 Slot: 9
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35B77F0 Offset: 0x35B37F0 VA: 0x35B77F0 Slot: 12
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B77F8 Offset: 0x35B37F8 VA: 0x35B77F8 Slot: 10
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x35B7800 Offset: 0x35B3800 VA: 0x35B7800 Slot: 13
	public void set_ItemNum(short value) { }

	// RVA: 0x35B7808 Offset: 0x35B3808 VA: 0x35B7808 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B7928 Offset: 0x35B3928 VA: 0x35B7928 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
