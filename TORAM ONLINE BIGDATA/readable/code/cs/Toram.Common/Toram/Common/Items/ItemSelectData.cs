// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class ItemSelectData : BinaryBase // TypeDefIndex: 12502
{
	// Fields
	[CompilerGenerated]
	private byte <ItemDataType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <ItemNum>k__BackingField; // 0x20

	// Properties
	public byte ItemDataType { get; set; }
	public int ItemUuid { get; set; }
	public short ItemNum { get; set; }

	// Methods

	// RVA: 0x3614074 Offset: 0x3610074 VA: 0x3614074
	public void .ctor() { }

	// RVA: 0x361407C Offset: 0x361007C VA: 0x361407C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3614084 Offset: 0x3610084 VA: 0x3614084
	public byte get_ItemDataType() { }

	[CompilerGenerated]
	// RVA: 0x361408C Offset: 0x361008C VA: 0x361408C
	public void set_ItemDataType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3614094 Offset: 0x3610094 VA: 0x3614094
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x361409C Offset: 0x361009C VA: 0x361409C
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36140A4 Offset: 0x36100A4 VA: 0x36140A4
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x36140AC Offset: 0x36100AC VA: 0x36140AC
	public void set_ItemNum(short value) { }

	// RVA: 0x36140B4 Offset: 0x36100B4 VA: 0x36140B4 Slot: 3
	public override string ToString() { }

	// RVA: 0x36141A8 Offset: 0x36101A8 VA: 0x36141A8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36141F4 Offset: 0x36101F4 VA: 0x36141F4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
