// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public abstract class ItemDatav2 : BinaryBase, IItemDatav2, IItemv2 // TypeDefIndex: 12500
{
	// Fields
	public const int SlotNum = 2;
	public const int CapMax = 10;
	public const int ColorMax = 3;
	public static byte[] AppearanceValue; // 0x0
	private static bool[] ItemBinaryTypes; // 0x8
	private static bool[] ItemEquipTypes; // 0x10
	private static bool[] ItemWeaponTypes; // 0x18
	public static readonly short[] WeaponTypes; // 0x20
	private static bool[] ItemUseTypes; // 0x28
	private static bool[] ItemSubHandTypes; // 0x30
	private static byte[] ItemTypev2; // 0x38
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Type>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Max>k__BackingField; // 0x26
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28

	// Properties
	public abstract byte ItemDataType { get; }
	public abstract short Index { get; }
	public int Uuid { get; set; }
	public int Id { get; set; }
	public short Type { get; set; }
	public short Max { get; set; }
	public byte Flag { get; set; }
	public abstract short Function { get; }
	public abstract byte SlotMax { get; }
	public abstract int Slot1 { get; }
	public abstract int Slot2 { get; }
	public abstract short Potential { get; }
	public abstract byte Refine { get; }
	public abstract byte AbilityValue { get; }
	public abstract byte BattleCustomize { get; }
	public abstract int Model { get; }
	public abstract int Rproperty { get; }
	public abstract byte Premium { get; }
	public abstract string Creater { get; }
	public abstract long UniqueId { get; }
	public abstract byte[] Color { get; }
	public abstract short[] CapId { get; }
	public abstract short[] CapVal { get; }

	// Methods

	// RVA: 0x36124D0 Offset: 0x360E4D0 VA: 0x36124D0
	private static void .cctor() { }

	// RVA: 0x3610410 Offset: 0x360C410 VA: 0x3610410
	protected void .ctor() { }

	// RVA: 0x3610480 Offset: 0x360C480 VA: 0x3610480
	protected void .ctor(MemoryStream ms) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract byte get_ItemDataType();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract short get_Index();

	[CompilerGenerated]
	// RVA: 0x361336C Offset: 0x360F36C VA: 0x361336C Slot: 8
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x3613374 Offset: 0x360F374 VA: 0x3613374
	protected void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x361337C Offset: 0x360F37C VA: 0x361337C Slot: 10
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3613384 Offset: 0x360F384 VA: 0x3613384
	protected void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x361338C Offset: 0x360F38C VA: 0x361338C Slot: 11
	public short get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3613394 Offset: 0x360F394 VA: 0x3613394
	protected void set_Type(short value) { }

	[CompilerGenerated]
	// RVA: 0x361339C Offset: 0x360F39C VA: 0x361339C Slot: 12
	public short get_Max() { }

	[CompilerGenerated]
	// RVA: 0x36133A4 Offset: 0x360F3A4 VA: 0x36133A4
	protected void set_Max(short value) { }

	[CompilerGenerated]
	// RVA: 0x36133AC Offset: 0x360F3AC VA: 0x36133AC Slot: 13
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36133B4 Offset: 0x360F3B4 VA: 0x36133B4
	protected void set_Flag(byte value) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract short get_Function();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract byte get_SlotMax();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int get_Slot1();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int get_Slot2();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract short get_Potential();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract byte get_Refine();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract byte get_AbilityValue();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract byte get_BattleCustomize();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract int get_Model();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int get_Rproperty();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract byte get_Premium();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract string get_Creater();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract long get_UniqueId();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract byte[] get_Color();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract short[] get_CapId();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract short[] get_CapVal();

	// RVA: 0x36133BC Offset: 0x360F3BC VA: 0x36133BC Slot: 5
	public override byte[] GetBinary() { }

	// RVA: 0x361363C Offset: 0x360F63C VA: 0x361363C Slot: 6
	public override void GetBinary(MemoryStream ms) { }

	// RVA: 0x36101A0 Offset: 0x360C1A0 VA: 0x36101A0
	public static bool IsFull(short type) { }

	// RVA: 0x3613688 Offset: 0x360F688 VA: 0x3613688
	public static byte GetItemDataType(short type) { }

	// RVA: 0x3613718 Offset: 0x360F718 VA: 0x3613718
	public static ItemDatav2 GetItem(byte[] binary) { }

	// RVA: 0x3611CB0 Offset: 0x360DCB0 VA: 0x3611CB0
	public static byte[] GetItemBinary(ItemDatav2[] array) { }

	// RVA: 0x36139A0 Offset: 0x360F9A0 VA: 0x36139A0
	public static void GetItemBinary(MemoryStream ms, ItemDatav2[] array) { }

	// RVA: 0x3613A44 Offset: 0x360FA44 VA: 0x3613A44
	public static ItemDatav2[] GetItemArray(byte[] binary) { }

	// RVA: 0x3613E28 Offset: 0x360FE28 VA: 0x3613E28
	public static ItemDatav2[] GetItemArray(MemoryStream ms) { }
}
