// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationHarvestResponse : OperationResponseBase // TypeDefIndex: 12200
{
	// Fields
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <GrowthParam>k__BackingField; // 0x22
	[CompilerGenerated]
	private int <NextGrowthSecond>k__BackingField; // 0x24
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x28

	// Properties
	public short Index { get; set; }
	public byte GrowthParam { get; set; }
	public int NextGrowthSecond { get; set; }
	public RewardResponseDatav2 RewardData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DF8F8 Offset: 0x35DB8F8 VA: 0x35DF8F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DF900 Offset: 0x35DB900 VA: 0x35DF900
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35DF908 Offset: 0x35DB908 VA: 0x35DF908
	public void set_Index(short value) { }

	[CompilerGenerated]
	// RVA: 0x35DF910 Offset: 0x35DB910 VA: 0x35DF910
	public byte get_GrowthParam() { }

	[CompilerGenerated]
	// RVA: 0x35DF918 Offset: 0x35DB918 VA: 0x35DF918
	public void set_GrowthParam(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DF920 Offset: 0x35DB920 VA: 0x35DF920
	public int get_NextGrowthSecond() { }

	[CompilerGenerated]
	// RVA: 0x35DF928 Offset: 0x35DB928 VA: 0x35DF928
	public void set_NextGrowthSecond(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DF930 Offset: 0x35DB930 VA: 0x35DF930
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x35DF938 Offset: 0x35DB938 VA: 0x35DF938
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x35DF940 Offset: 0x35DB940 VA: 0x35DF940 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DF948 Offset: 0x35DB948 VA: 0x35DF948 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DF950 Offset: 0x35DB950 VA: 0x35DF950 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DFBF4 Offset: 0x35DBBF4 VA: 0x35DFBF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
