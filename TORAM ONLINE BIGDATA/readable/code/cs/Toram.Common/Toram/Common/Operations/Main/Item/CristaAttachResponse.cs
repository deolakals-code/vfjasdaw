// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class CristaAttachResponse : PacketBase // TypeDefIndex: 12152
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

	// RVA: 0x3791C7C Offset: 0x378DC7C VA: 0x3791C7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3791C84 Offset: 0x378DC84 VA: 0x3791C84
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3791C8C Offset: 0x378DC8C VA: 0x3791C8C
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3791C94 Offset: 0x378DC94 VA: 0x3791C94
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3791C9C Offset: 0x378DC9C VA: 0x3791C9C
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3791CA4 Offset: 0x378DCA4 VA: 0x3791CA4
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3791CAC Offset: 0x378DCAC VA: 0x3791CAC
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3791CB4 Offset: 0x378DCB4 VA: 0x3791CB4
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3791CBC Offset: 0x378DCBC VA: 0x3791CBC
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x3791CC4 Offset: 0x378DCC4 VA: 0x3791CC4
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3791CCC Offset: 0x378DCCC VA: 0x3791CCC
	public short get_ExMp() { }

	// RVA: 0x3791CD4 Offset: 0x378DCD4 VA: 0x3791CD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3791CDC Offset: 0x378DCDC VA: 0x3791CDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3791FA4 Offset: 0x378DFA4 VA: 0x3791FA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
