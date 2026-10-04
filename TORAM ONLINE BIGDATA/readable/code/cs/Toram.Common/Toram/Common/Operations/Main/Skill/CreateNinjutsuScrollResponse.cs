// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class CreateNinjutsuScrollResponse : OperationResponseBase // TypeDefIndex: 12106
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <UseItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2 <CreateItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <RandomSkillList>k__BackingField; // 0x30

	// Properties
	public ItemDatav2[] UseItemList { get; set; }
	public ItemDatav2 CreateItem { get; set; }
	public short[] RandomSkillList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378836C Offset: 0x378436C VA: 0x378836C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3788374 Offset: 0x3784374 VA: 0x3788374
	public ItemDatav2[] get_UseItemList() { }

	[CompilerGenerated]
	// RVA: 0x378837C Offset: 0x378437C VA: 0x378837C
	public void set_UseItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3788384 Offset: 0x3784384 VA: 0x3788384
	public ItemDatav2 get_CreateItem() { }

	[CompilerGenerated]
	// RVA: 0x378838C Offset: 0x378438C VA: 0x378838C
	public void set_CreateItem(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3788394 Offset: 0x3784394 VA: 0x3788394
	public short[] get_RandomSkillList() { }

	[CompilerGenerated]
	// RVA: 0x378839C Offset: 0x378439C VA: 0x378839C
	public void set_RandomSkillList(short[] value) { }

	// RVA: 0x37883A4 Offset: 0x37843A4 VA: 0x37883A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37883AC Offset: 0x37843AC VA: 0x37883AC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37883B4 Offset: 0x37843B4 VA: 0x37883B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378860C Offset: 0x378460C VA: 0x378860C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
