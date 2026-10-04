// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketSetup : OperationRequestBase // TypeDefIndex: 11925
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AutoLockFlag>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 136, IsOptional = True)]
	public int ShopId { get; set; }
	[PacketParameter(Code = 43, IsOptional = True)]
	public int AutoLockFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3766E88 Offset: 0x3762E88 VA: 0x3766E88
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3766E90 Offset: 0x3762E90 VA: 0x3766E90
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3766E98 Offset: 0x3762E98 VA: 0x3766E98
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3766EA0 Offset: 0x3762EA0 VA: 0x3766EA0
	public int get_AutoLockFlag() { }

	[CompilerGenerated]
	// RVA: 0x3766EA8 Offset: 0x3762EA8 VA: 0x3766EA8
	public void set_AutoLockFlag(int value) { }

	// RVA: 0x3766EB0 Offset: 0x3762EB0 VA: 0x3766EB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3766EB8 Offset: 0x3762EB8 VA: 0x3766EB8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3766EC0 Offset: 0x3762EC0 VA: 0x3766EC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3767080 Offset: 0x3763080 VA: 0x3767080 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
