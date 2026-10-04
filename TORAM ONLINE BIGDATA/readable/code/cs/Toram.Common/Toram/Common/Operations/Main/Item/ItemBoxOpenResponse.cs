// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ItemBoxOpenResponse : OperationResponseBase // TypeDefIndex: 12131
{
	// Fields
	[CompilerGenerated]
	private short <OpenNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2 <OpenItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x30

	// Properties
	public short OpenNum { get; set; }
	public ItemDatav2 OpenItem { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378DD9C Offset: 0x3789D9C VA: 0x378DD9C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378DDA4 Offset: 0x3789DA4 VA: 0x378DDA4
	public short get_OpenNum() { }

	[CompilerGenerated]
	// RVA: 0x378DDAC Offset: 0x3789DAC VA: 0x378DDAC
	public void set_OpenNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x378DDB4 Offset: 0x3789DB4 VA: 0x378DDB4
	public ItemDatav2 get_OpenItem() { }

	[CompilerGenerated]
	// RVA: 0x378DDBC Offset: 0x3789DBC VA: 0x378DDBC
	public void set_OpenItem(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x378DDC4 Offset: 0x3789DC4 VA: 0x378DDC4
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x378DDCC Offset: 0x3789DCC VA: 0x378DDCC
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x378DDD4 Offset: 0x3789DD4 VA: 0x378DDD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378DDDC Offset: 0x3789DDC VA: 0x378DDDC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378DDE4 Offset: 0x3789DE4 VA: 0x378DDE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378DEDC Offset: 0x3789EDC VA: 0x378DEDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
