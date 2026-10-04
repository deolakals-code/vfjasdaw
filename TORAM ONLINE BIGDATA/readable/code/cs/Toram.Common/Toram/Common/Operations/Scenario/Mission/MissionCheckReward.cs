// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionCheckReward : OperationBase // TypeDefIndex: 11413
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RewardId>k__BackingField; // 0x2C

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 122)]
	public byte RewardId { get; set; }

	// Methods

	// RVA: 0x37035B0 Offset: 0x36FF5B0 VA: 0x37035B0
	public void .ctor() { }

	// RVA: 0x37035B8 Offset: 0x36FF5B8 VA: 0x37035B8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37035C0 Offset: 0x36FF5C0 VA: 0x37035C0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37035C8 Offset: 0x36FF5C8 VA: 0x37035C8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37035D0 Offset: 0x36FF5D0 VA: 0x37035D0
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37035D8 Offset: 0x36FF5D8 VA: 0x37035D8
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37035E0 Offset: 0x36FF5E0 VA: 0x37035E0
	public byte get_RewardId() { }

	[CompilerGenerated]
	// RVA: 0x37035E8 Offset: 0x36FF5E8 VA: 0x37035E8
	public void set_RewardId(byte value) { }

	// RVA: 0x37035F0 Offset: 0x36FF5F0 VA: 0x37035F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37037C8 Offset: 0x36FF7C8 VA: 0x37037C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
