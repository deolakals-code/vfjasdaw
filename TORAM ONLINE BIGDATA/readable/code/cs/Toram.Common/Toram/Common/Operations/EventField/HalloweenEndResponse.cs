// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.EventField
public class HalloweenEndResponse : OperationResponseBase // TypeDefIndex: 11670
{
	// Fields
	[CompilerGenerated]
	private EventFieldRewardData[] <RewardList>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, byte> <MyBag>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ClearTime>k__BackingField; // 0x30

	// Properties
	public EventFieldRewardData[] RewardList { get; set; }
	[PacketParameter(Code = 15)]
	public Dictionary<byte, byte> MyBag { get; set; }
	[PacketParameter(Code = 42)]
	public int ClearTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372F190 Offset: 0x372B190 VA: 0x372F190
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372F198 Offset: 0x372B198 VA: 0x372F198
	public EventFieldRewardData[] get_RewardList() { }

	[CompilerGenerated]
	// RVA: 0x372F1A0 Offset: 0x372B1A0 VA: 0x372F1A0
	public void set_RewardList(EventFieldRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x372F1A8 Offset: 0x372B1A8 VA: 0x372F1A8
	public Dictionary<byte, byte> get_MyBag() { }

	[CompilerGenerated]
	// RVA: 0x372F1B0 Offset: 0x372B1B0 VA: 0x372F1B0
	public void set_MyBag(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x372F1B8 Offset: 0x372B1B8 VA: 0x372F1B8
	public int get_ClearTime() { }

	[CompilerGenerated]
	// RVA: 0x372F1C0 Offset: 0x372B1C0 VA: 0x372F1C0
	public void set_ClearTime(int value) { }

	// RVA: 0x372F1C8 Offset: 0x372B1C8 VA: 0x372F1C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372F1D0 Offset: 0x372B1D0 VA: 0x372F1D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372F1D8 Offset: 0x372B1D8 VA: 0x372F1D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372F444 Offset: 0x372B444 VA: 0x372F444 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
