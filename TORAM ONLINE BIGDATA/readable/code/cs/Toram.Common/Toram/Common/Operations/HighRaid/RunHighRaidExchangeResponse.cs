// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class RunHighRaidExchangeResponse : OperationResponseBase // TypeDefIndex: 11566
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x24
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <AcquiredFlag>k__BackingField; // 0x30

	// Properties
	public byte HighRaidNo { get; set; }
	public int Point { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public byte AcquiredFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371B928 Offset: 0x3717928 VA: 0x371B928
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371B930 Offset: 0x3717930 VA: 0x371B930
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371B938 Offset: 0x3717938 VA: 0x371B938
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371B940 Offset: 0x3717940 VA: 0x371B940
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x371B948 Offset: 0x3717948 VA: 0x371B948
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x371B950 Offset: 0x3717950 VA: 0x371B950
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x371B958 Offset: 0x3717958 VA: 0x371B958
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x371B960 Offset: 0x3717960 VA: 0x371B960
	public byte get_AcquiredFlag() { }

	[CompilerGenerated]
	// RVA: 0x371B968 Offset: 0x3717968 VA: 0x371B968
	public void set_AcquiredFlag(byte value) { }

	// RVA: 0x371B970 Offset: 0x3717970 VA: 0x371B970 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371B978 Offset: 0x3717978 VA: 0x371B978 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371B980 Offset: 0x3717980 VA: 0x371B980 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371BC18 Offset: 0x3717C18 VA: 0x371BC18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
