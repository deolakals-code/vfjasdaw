// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ReinforceCristaAttachResponse : PacketBase // TypeDefIndex: 12150
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbItemData[] <OrbItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x44

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public OrbItemData[] OrbItemList { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int Hp { get; set; }
	public short Mp { get; set; }
	public int ExHp { get; set; }
	public short ExMp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x379127C Offset: 0x378D27C VA: 0x379127C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3791284 Offset: 0x378D284 VA: 0x3791284
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x379128C Offset: 0x378D28C VA: 0x379128C
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3791294 Offset: 0x378D294 VA: 0x3791294
	public OrbItemData[] get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x379129C Offset: 0x378D29C VA: 0x379129C
	public void set_OrbItemList(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37912A4 Offset: 0x378D2A4 VA: 0x37912A4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x37912AC Offset: 0x378D2AC VA: 0x37912AC
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x37912B4 Offset: 0x378D2B4 VA: 0x37912B4
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x37912BC Offset: 0x378D2BC VA: 0x37912BC
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x37912C4 Offset: 0x378D2C4 VA: 0x37912C4
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x37912CC Offset: 0x378D2CC VA: 0x37912CC
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x37912D4 Offset: 0x378D2D4 VA: 0x37912D4
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x37912DC Offset: 0x378D2DC VA: 0x37912DC
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37912E4 Offset: 0x378D2E4 VA: 0x37912E4
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x37912EC Offset: 0x378D2EC VA: 0x37912EC
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x37912F4 Offset: 0x378D2F4 VA: 0x37912F4
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37912FC Offset: 0x378D2FC VA: 0x37912FC
	public short get_ExMp() { }

	// RVA: 0x3791304 Offset: 0x378D304 VA: 0x3791304 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379130C Offset: 0x378D30C VA: 0x379130C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x379170C Offset: 0x378D70C VA: 0x379170C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
