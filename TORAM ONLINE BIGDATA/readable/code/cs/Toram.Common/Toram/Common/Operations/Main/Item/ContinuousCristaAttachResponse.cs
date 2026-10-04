// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ContinuousCristaAttachResponse : PacketBase // TypeDefIndex: 12127
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

	// RVA: 0x378CB74 Offset: 0x3788B74 VA: 0x378CB74
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378CB7C Offset: 0x3788B7C VA: 0x378CB7C
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x378CB84 Offset: 0x3788B84 VA: 0x378CB84
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x378CB8C Offset: 0x3788B8C VA: 0x378CB8C
	public OrbItemData[] get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x378CB94 Offset: 0x3788B94 VA: 0x378CB94
	public void set_OrbItemList(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x378CB9C Offset: 0x3788B9C VA: 0x378CB9C
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x378CBA4 Offset: 0x3788BA4 VA: 0x378CBA4
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x378CBAC Offset: 0x3788BAC VA: 0x378CBAC
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x378CBB4 Offset: 0x3788BB4 VA: 0x378CBB4
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x378CBBC Offset: 0x3788BBC VA: 0x378CBBC
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x378CBC4 Offset: 0x3788BC4 VA: 0x378CBC4
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x378CBCC Offset: 0x3788BCC VA: 0x378CBCC
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x378CBD4 Offset: 0x3788BD4 VA: 0x378CBD4
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x378CBDC Offset: 0x3788BDC VA: 0x378CBDC
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x378CBE4 Offset: 0x3788BE4 VA: 0x378CBE4
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x378CBEC Offset: 0x3788BEC VA: 0x378CBEC
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x378CBF4 Offset: 0x3788BF4 VA: 0x378CBF4
	public short get_ExMp() { }

	// RVA: 0x378CBFC Offset: 0x3788BFC VA: 0x378CBFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378CC04 Offset: 0x3788C04 VA: 0x378CC04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378D004 Offset: 0x3789004 VA: 0x378D004 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
