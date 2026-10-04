// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class CristaBreakResponse : PacketBase // TypeDefIndex: 12154
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x34

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public int Hp { get; set; }
	public short Mp { get; set; }
	public int ExHp { get; set; }
	public short ExMp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3792408 Offset: 0x378E408 VA: 0x3792408
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3792410 Offset: 0x378E410 VA: 0x3792410
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3792418 Offset: 0x378E418 VA: 0x3792418
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3792420 Offset: 0x378E420 VA: 0x3792420
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3792428 Offset: 0x378E428 VA: 0x3792428
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3792430 Offset: 0x378E430 VA: 0x3792430
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3792438 Offset: 0x378E438 VA: 0x3792438
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3792440 Offset: 0x378E440 VA: 0x3792440
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3792448 Offset: 0x378E448 VA: 0x3792448
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x3792450 Offset: 0x378E450 VA: 0x3792450
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3792458 Offset: 0x378E458 VA: 0x3792458
	public short get_ExMp() { }

	// RVA: 0x3792460 Offset: 0x378E460 VA: 0x3792460 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3792468 Offset: 0x378E468 VA: 0x3792468 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3792730 Offset: 0x378E730 VA: 0x3792730 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
