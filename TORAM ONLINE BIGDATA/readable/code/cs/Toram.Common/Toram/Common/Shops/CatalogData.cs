// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Shops
public class CatalogData : BinaryBase // TypeDefIndex: 11075
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x20

	// Properties
	[BinaryParameter]
	public int ItemId { get; set; }
	[BinaryParameter]
	public int Price { get; set; }

	// Methods

	// RVA: 0x35B2FA8 Offset: 0x35AEFA8 VA: 0x35B2FA8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35B2FB0 Offset: 0x35AEFB0 VA: 0x35B2FB0
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35B2FB8 Offset: 0x35AEFB8 VA: 0x35B2FB8
	protected void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B2FC0 Offset: 0x35AEFC0 VA: 0x35B2FC0
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x35B2FC8 Offset: 0x35AEFC8 VA: 0x35B2FC8
	protected void set_Price(int value) { }

	// RVA: 0x35B2FD0 Offset: 0x35AEFD0 VA: 0x35B2FD0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B30DC Offset: 0x35AF0DC VA: 0x35B30DC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
