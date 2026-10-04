// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class CreateNinjutsuScroll : OperationRequestBase // TypeDefIndex: 12105
{
	// Fields
	[CompilerGenerated]
	private ItemSelectData[] <SelectItem>k__BackingField; // 0x20

	// Properties
	public ItemSelectData[] SelectItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3788164 Offset: 0x3784164 VA: 0x3788164
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378816C Offset: 0x378416C VA: 0x378816C
	public ItemSelectData[] get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x3788174 Offset: 0x3784174 VA: 0x3788174
	public void set_SelectItem(ItemSelectData[] value) { }

	// RVA: 0x378817C Offset: 0x378417C VA: 0x378817C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3788184 Offset: 0x3784184 VA: 0x3788184 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378818C Offset: 0x378418C VA: 0x378818C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37882D8 Offset: 0x37842D8 VA: 0x37882D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
