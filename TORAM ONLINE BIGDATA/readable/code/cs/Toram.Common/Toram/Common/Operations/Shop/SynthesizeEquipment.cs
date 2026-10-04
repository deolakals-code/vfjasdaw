// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class SynthesizeEquipment : OperationRequestBase // TypeDefIndex: 11720
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <ItemUuid>k__BackingField; // 0x38
	[CompilerGenerated]
	private int[] <UseItemUuid>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <SupportItemId>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x4C
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x50

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public short SkillId { get; set; }
	public int[] ItemUuid { get; set; }
	public int[] UseItemUuid { get; set; }
	public int SupportItemId { get; set; }
	public int UseOrb { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373A964 Offset: 0x3736964 VA: 0x373A964
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373A96C Offset: 0x373696C VA: 0x373A96C
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373A974 Offset: 0x3736974 VA: 0x373A974
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373A97C Offset: 0x373697C VA: 0x373A97C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373A984 Offset: 0x3736984 VA: 0x373A984
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x373A98C Offset: 0x373698C VA: 0x373A98C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x373A994 Offset: 0x3736994 VA: 0x373A994
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x373A99C Offset: 0x373699C VA: 0x373A99C
	public int[] get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x373A9A4 Offset: 0x37369A4 VA: 0x373A9A4
	public void set_ItemUuid(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x373A9AC Offset: 0x37369AC VA: 0x373A9AC
	public int[] get_UseItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x373A9B4 Offset: 0x37369B4 VA: 0x373A9B4
	public void set_UseItemUuid(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x373A9BC Offset: 0x37369BC VA: 0x373A9BC
	public int get_SupportItemId() { }

	[CompilerGenerated]
	// RVA: 0x373A9C4 Offset: 0x37369C4 VA: 0x373A9C4
	public void set_SupportItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373A9CC Offset: 0x37369CC VA: 0x373A9CC
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x373A9D4 Offset: 0x37369D4 VA: 0x373A9D4
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x373A9DC Offset: 0x37369DC VA: 0x373A9DC
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x373A9E4 Offset: 0x37369E4 VA: 0x373A9E4
	public void set_Orb(int value) { }

	// RVA: 0x373A9EC Offset: 0x37369EC VA: 0x373A9EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373A9F4 Offset: 0x37369F4 VA: 0x373A9F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373A9FC Offset: 0x37369FC VA: 0x373A9FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373ABA4 Offset: 0x3736BA4 VA: 0x373ABA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
