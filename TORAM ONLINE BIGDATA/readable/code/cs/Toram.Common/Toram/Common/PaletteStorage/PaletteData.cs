// Assembly: Toram.Common.dll
// Namespace: Toram.Common.PaletteStorage
public class PaletteData : BinaryBase // TypeDefIndex: 11137
{
	// Fields
	public const byte MaxStack = 99;
	[CompilerGenerated]
	private short <ItemType>k__BackingField; // 0x1A
	[CompilerGenerated]
	private Dictionary<byte, PaletteData.ColorStackData> <ColorStackList>k__BackingField; // 0x20

	// Properties
	public short ItemType { get; set; }
	public Dictionary<byte, PaletteData.ColorStackData> ColorStackList { get; set; }

	// Methods

	// RVA: 0x35C6CC8 Offset: 0x35C2CC8 VA: 0x35C6CC8
	public void .ctor() { }

	// RVA: 0x35C6D50 Offset: 0x35C2D50 VA: 0x35C6D50
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35C6D58 Offset: 0x35C2D58 VA: 0x35C6D58
	public short get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x35C6D60 Offset: 0x35C2D60 VA: 0x35C6D60
	public void set_ItemType(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C6D68 Offset: 0x35C2D68 VA: 0x35C6D68
	public Dictionary<byte, PaletteData.ColorStackData> get_ColorStackList() { }

	[CompilerGenerated]
	// RVA: 0x35C6D70 Offset: 0x35C2D70 VA: 0x35C6D70
	public void set_ColorStackList(Dictionary<byte, PaletteData.ColorStackData> value) { }

	// RVA: 0x35C6D78 Offset: 0x35C2D78 VA: 0x35C6D78 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C6E08 Offset: 0x35C2E08 VA: 0x35C6E08 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
