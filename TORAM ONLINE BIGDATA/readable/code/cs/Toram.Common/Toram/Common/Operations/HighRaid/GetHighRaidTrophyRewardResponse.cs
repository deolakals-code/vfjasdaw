// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidTrophyRewardResponse : OperationResponseBase // TypeDefIndex: 11565
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TrophyId>k__BackingField; // 0x21
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, byte> <Trophys>k__BackingField; // 0x30

	// Properties
	public byte HighRaidNo { get; set; }
	public byte TrophyId { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public Dictionary<byte, byte> Trophys { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371B430 Offset: 0x3717430 VA: 0x371B430
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371B438 Offset: 0x3717438 VA: 0x371B438
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371B440 Offset: 0x3717440 VA: 0x371B440
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371B448 Offset: 0x3717448 VA: 0x371B448
	public byte get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x371B450 Offset: 0x3717450 VA: 0x371B450
	public void set_TrophyId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371B458 Offset: 0x3717458 VA: 0x371B458
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x371B460 Offset: 0x3717460 VA: 0x371B460
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x371B468 Offset: 0x3717468 VA: 0x371B468
	public Dictionary<byte, byte> get_Trophys() { }

	[CompilerGenerated]
	// RVA: 0x371B470 Offset: 0x3717470 VA: 0x371B470
	public void set_Trophys(Dictionary<byte, byte> value) { }

	// RVA: 0x371B478 Offset: 0x3717478 VA: 0x371B478
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371B630 Offset: 0x3717630 VA: 0x371B630
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371B6C8 Offset: 0x37176C8 VA: 0x371B6C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371B6D0 Offset: 0x37176D0 VA: 0x371B6D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371B6D8 Offset: 0x37176D8 VA: 0x371B6D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371B854 Offset: 0x3717854 VA: 0x371B854 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
