// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailSendResponse : OperationResponseBase // TypeDefIndex: 12028
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ExchangeCount>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public ItemDatav2[] ItemList { get; set; }
	public int ExchangeCount { get; set; }

	// Methods

	// RVA: 0x37799F8 Offset: 0x37759F8 VA: 0x37799F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3779A00 Offset: 0x3775A00 VA: 0x3779A00 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3779A08 Offset: 0x3775A08 VA: 0x3779A08
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3779A10 Offset: 0x3775A10 VA: 0x3779A10
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3779A18 Offset: 0x3775A18 VA: 0x3779A18
	public int get_ExchangeCount() { }

	[CompilerGenerated]
	// RVA: 0x3779A20 Offset: 0x3775A20 VA: 0x3779A20
	public void set_ExchangeCount(int value) { }

	// RVA: 0x3779A28 Offset: 0x3775A28 VA: 0x3779A28
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3779A30 Offset: 0x3775A30 VA: 0x3779A30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3779C38 Offset: 0x3775C38 VA: 0x3779C38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
