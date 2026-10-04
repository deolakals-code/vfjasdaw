// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class PartsAttackResponseData : UnityHashBase, IMobIdData // TypeDefIndex: 13119
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <PartId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x2C

	// Properties
	[UnityHash(Code = 22)]
	public int MobId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 24)]
	public int UniqueId { get; set; }
	[UnityHash(Code = 25)]
	public byte PartId { get; set; }
	[UnityHash(Code = 12)]
	public int Hp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AA758 Offset: 0x36A6758 VA: 0x36AA758
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AA760 Offset: 0x36A6760 VA: 0x36AA760 Slot: 7
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36AA768 Offset: 0x36A6768 VA: 0x36AA768
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AA770 Offset: 0x36A6770 VA: 0x36AA770 Slot: 8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36AA778 Offset: 0x36A6778 VA: 0x36AA778
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AA780 Offset: 0x36A6780 VA: 0x36AA780 Slot: 9
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36AA788 Offset: 0x36A6788 VA: 0x36AA788
	public void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AA790 Offset: 0x36A6790 VA: 0x36AA790
	public byte get_PartId() { }

	[CompilerGenerated]
	// RVA: 0x36AA798 Offset: 0x36A6798 VA: 0x36AA798
	public void set_PartId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AA7A0 Offset: 0x36A67A0 VA: 0x36AA7A0
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36AA7A8 Offset: 0x36A67A8 VA: 0x36AA7A8
	public void set_Hp(int value) { }

	// RVA: 0x36AA7B0 Offset: 0x36A67B0 VA: 0x36AA7B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AA7B8 Offset: 0x36A67B8 VA: 0x36AA7B8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36AAA80 Offset: 0x36A6A80 VA: 0x36AAA80 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
