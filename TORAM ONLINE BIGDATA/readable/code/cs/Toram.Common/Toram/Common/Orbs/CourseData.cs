// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Orbs
public class CourseData : BinaryBase // TypeDefIndex: 11140
{
	// Fields
	[CompilerGenerated]
	private byte <CourseType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private DateTime <LimitDate>k__BackingField; // 0x20

	// Properties
	public byte CourseType { get; set; }
	public int ItemId { get; set; }
	public DateTime LimitDate { get; set; }

	// Methods

	// RVA: 0x35C81CC Offset: 0x35C41CC VA: 0x35C81CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35C81D4 Offset: 0x35C41D4 VA: 0x35C81D4
	public byte get_CourseType() { }

	[CompilerGenerated]
	// RVA: 0x35C81DC Offset: 0x35C41DC VA: 0x35C81DC
	public void set_CourseType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C81E4 Offset: 0x35C41E4 VA: 0x35C81E4
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35C81EC Offset: 0x35C41EC VA: 0x35C81EC
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C81F4 Offset: 0x35C41F4 VA: 0x35C81F4
	public DateTime get_LimitDate() { }

	[CompilerGenerated]
	// RVA: 0x35C81FC Offset: 0x35C41FC VA: 0x35C81FC
	public void set_LimitDate(DateTime value) { }

	// RVA: 0x35C8204 Offset: 0x35C4204 VA: 0x35C8204 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C8324 Offset: 0x35C4324 VA: 0x35C8324 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
