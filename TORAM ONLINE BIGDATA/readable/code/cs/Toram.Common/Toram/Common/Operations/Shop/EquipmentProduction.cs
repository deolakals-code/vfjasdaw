// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class EquipmentProduction : OperationRequestBase // TypeDefIndex: 11708
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <RecipeId>k__BackingField; // 0x34

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public short SkillId { get; set; }
	public int RecipeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373731C Offset: 0x373331C VA: 0x373731C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3737324 Offset: 0x3733324 VA: 0x3737324
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373732C Offset: 0x373332C VA: 0x373732C
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3737334 Offset: 0x3733334 VA: 0x3737334
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373733C Offset: 0x373333C VA: 0x373733C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3737344 Offset: 0x3733344 VA: 0x3737344
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x373734C Offset: 0x373334C VA: 0x373734C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3737354 Offset: 0x3733354 VA: 0x3737354
	public int get_RecipeId() { }

	[CompilerGenerated]
	// RVA: 0x373735C Offset: 0x373335C VA: 0x373735C
	public void set_RecipeId(int value) { }

	// RVA: 0x3737364 Offset: 0x3733364 VA: 0x3737364 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373736C Offset: 0x373336C VA: 0x373736C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3737374 Offset: 0x3733374 VA: 0x3737374 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373749C Offset: 0x373349C VA: 0x373749C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
