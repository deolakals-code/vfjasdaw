// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Registlet
public class GemCartData : BinaryBase // TypeDefIndex: 11099
{
	// Fields
	[CompilerGenerated]
	private short <GemNo>k__BackingField; // 0x1A
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Id>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x2C

	// Properties
	public short GemNo { get; set; }
	public long Uuid { get; set; }
	public short Id { get; set; }
	public short Lv { get; set; }
	public byte Flag { get; set; }

	// Methods

	// RVA: 0x35B9B2C Offset: 0x35B5B2C VA: 0x35B9B2C
	public void .ctor() { }

	// RVA: 0x35B9B34 Offset: 0x35B5B34 VA: 0x35B9B34
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35B9B3C Offset: 0x35B5B3C VA: 0x35B9B3C
	public short get_GemNo() { }

	[CompilerGenerated]
	// RVA: 0x35B9B44 Offset: 0x35B5B44 VA: 0x35B9B44
	public void set_GemNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B9B4C Offset: 0x35B5B4C VA: 0x35B9B4C
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x35B9B54 Offset: 0x35B5B54 VA: 0x35B9B54
	public void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35B9B5C Offset: 0x35B5B5C VA: 0x35B9B5C
	public short get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35B9B64 Offset: 0x35B5B64 VA: 0x35B9B64
	public void set_Id(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B9B6C Offset: 0x35B5B6C VA: 0x35B9B6C
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x35B9B74 Offset: 0x35B5B74 VA: 0x35B9B74
	public void set_Lv(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B9B7C Offset: 0x35B5B7C VA: 0x35B9B7C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35B9B84 Offset: 0x35B5B84 VA: 0x35B9B84
	public void set_Flag(byte value) { }

	// RVA: 0x35B9B8C Offset: 0x35B5B8C VA: 0x35B9B8C Slot: 3
	public override string ToString() { }

	// RVA: 0x35B9DDC Offset: 0x35B5DDC VA: 0x35B9DDC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B9E48 Offset: 0x35B5E48 VA: 0x35B9E48 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
