// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Mob
public class MonsterDropDetailData : BinaryBase // TypeDefIndex: 12484
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <DropType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ColorTotal>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PropertyIdTotal>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PropertyValTotal>k__BackingField; // 0x2C

	// Properties
	[BinaryParameter]
	public int ItemId { get; set; }
	[BinaryParameter]
	public byte DropType { get; set; }
	[BinaryParameter]
	public int ColorTotal { get; set; }
	[BinaryParameter]
	public int PropertyIdTotal { get; set; }
	[BinaryParameter]
	public int PropertyValTotal { get; set; }

	// Methods

	// RVA: 0x360E918 Offset: 0x360A918 VA: 0x360E918
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360E940 Offset: 0x360A940 VA: 0x360E940
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x360E948 Offset: 0x360A948 VA: 0x360E948
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E950 Offset: 0x360A950 VA: 0x360E950
	public byte get_DropType() { }

	[CompilerGenerated]
	// RVA: 0x360E958 Offset: 0x360A958 VA: 0x360E958
	public void set_DropType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360E960 Offset: 0x360A960 VA: 0x360E960
	public int get_ColorTotal() { }

	[CompilerGenerated]
	// RVA: 0x360E968 Offset: 0x360A968 VA: 0x360E968
	public void set_ColorTotal(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E970 Offset: 0x360A970 VA: 0x360E970
	public int get_PropertyIdTotal() { }

	[CompilerGenerated]
	// RVA: 0x360E978 Offset: 0x360A978 VA: 0x360E978
	public void set_PropertyIdTotal(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E980 Offset: 0x360A980 VA: 0x360E980
	public int get_PropertyValTotal() { }

	[CompilerGenerated]
	// RVA: 0x360E988 Offset: 0x360A988 VA: 0x360E988
	public void set_PropertyValTotal(int value) { }

	// RVA: 0x360E990 Offset: 0x360A990 VA: 0x360E990 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x360EAD8 Offset: 0x360AAD8 VA: 0x360EAD8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
