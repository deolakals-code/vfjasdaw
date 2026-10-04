// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class AreaBonusRewardEvent : PacketBase // TypeDefIndex: 12713
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x28

	// Properties
	public int SenderId { get; set; }
	public RewardResponseDatav2 RewardData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3647D5C Offset: 0x3643D5C VA: 0x3647D5C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3647D64 Offset: 0x3643D64 VA: 0x3647D64
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3647D6C Offset: 0x3643D6C VA: 0x3647D6C
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3647D74 Offset: 0x3643D74 VA: 0x3647D74
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x3647D7C Offset: 0x3643D7C VA: 0x3647D7C
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x3647D84 Offset: 0x3643D84 VA: 0x3647D84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3647D8C Offset: 0x3643D8C VA: 0x3647D8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3647F80 Offset: 0x3643F80 VA: 0x3647F80 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
