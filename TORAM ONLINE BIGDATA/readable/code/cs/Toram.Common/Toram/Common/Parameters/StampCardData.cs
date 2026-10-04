// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class StampCardData : BinaryBase // TypeDefIndex: 11129
{
	// Fields
	[CompilerGenerated]
	private byte <Month>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte[] <Stamp>k__BackingField; // 0x20

	// Properties
	[BinaryParameter]
	public byte Month { get; set; }
	[BinaryParameter]
	public byte Level { get; set; }
	[BinaryParameter]
	public byte[] Stamp { get; set; }

	// Methods

	// RVA: 0x35C5090 Offset: 0x35C1090 VA: 0x35C5090
	public void .ctor() { }

	// RVA: 0x35C5098 Offset: 0x35C1098 VA: 0x35C5098
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35C50A0 Offset: 0x35C10A0 VA: 0x35C50A0
	public byte get_Month() { }

	[CompilerGenerated]
	// RVA: 0x35C50A8 Offset: 0x35C10A8 VA: 0x35C50A8
	protected void set_Month(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C50B0 Offset: 0x35C10B0 VA: 0x35C50B0
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x35C50B8 Offset: 0x35C10B8 VA: 0x35C50B8
	protected void set_Level(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C50C0 Offset: 0x35C10C0 VA: 0x35C50C0
	public byte[] get_Stamp() { }

	[CompilerGenerated]
	// RVA: 0x35C50C8 Offset: 0x35C10C8 VA: 0x35C50C8
	protected void set_Stamp(byte[] value) { }

	// RVA: 0x35C50D0 Offset: 0x35C10D0 VA: 0x35C50D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C5454 Offset: 0x35C1454 VA: 0x35C5454 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C5580 Offset: 0x35C1580 VA: 0x35C5580 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
