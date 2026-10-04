// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Orbs
public class OrbItemData : BinaryBase // TypeDefIndex: 11146
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x20
	[CompilerGenerated]
	private TimeStamp <BuyTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <UseTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <New>k__BackingField; // 0x38

	// Properties
	[BinaryParameter]
	public int ItemId { get; set; }
	[BinaryParameter]
	public int Num { get; set; }
	[BinaryClass]
	public TimeStamp BuyTime { get; set; }
	[BinaryClass]
	public DateTime UseTime { get; set; }
	[BinaryParameter]
	public byte New { get; set; }

	// Methods

	// RVA: 0x35C9EE8 Offset: 0x35C5EE8 VA: 0x35C9EE8
	public void .ctor() { }

	// RVA: 0x35C9EF0 Offset: 0x35C5EF0 VA: 0x35C9EF0
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35C9EF8 Offset: 0x35C5EF8 VA: 0x35C9EF8
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35C9F00 Offset: 0x35C5F00 VA: 0x35C9F00
	protected void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C9F08 Offset: 0x35C5F08 VA: 0x35C9F08
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x35C9F10 Offset: 0x35C5F10 VA: 0x35C9F10
	protected void set_Num(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C9F18 Offset: 0x35C5F18 VA: 0x35C9F18
	public TimeStamp get_BuyTime() { }

	[CompilerGenerated]
	// RVA: 0x35C9F20 Offset: 0x35C5F20 VA: 0x35C9F20
	protected void set_BuyTime(TimeStamp value) { }

	[CompilerGenerated]
	// RVA: 0x35C9F28 Offset: 0x35C5F28 VA: 0x35C9F28
	public DateTime get_UseTime() { }

	[CompilerGenerated]
	// RVA: 0x35C9F30 Offset: 0x35C5F30 VA: 0x35C9F30
	protected void set_UseTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35C9F38 Offset: 0x35C5F38 VA: 0x35C9F38
	public byte get_New() { }

	[CompilerGenerated]
	// RVA: 0x35C9F40 Offset: 0x35C5F40 VA: 0x35C9F40
	protected void set_New(byte value) { }

	// RVA: 0x35C9F48 Offset: 0x35C5F48 VA: 0x35C9F48 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C9FE8 Offset: 0x35C5FE8 VA: 0x35C9FE8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CA170 Offset: 0x35C6170 VA: 0x35CA170 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
