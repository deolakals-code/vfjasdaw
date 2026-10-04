// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionAbandonmentResponse : OperationBase // TypeDefIndex: 11412
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <AccountProgress>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ScenarioProgress>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 157)]
	public int AccountProgress { get; set; }
	[PacketParameter(Code = 158)]
	public int ScenarioProgress { get; set; }

	// Methods

	// RVA: 0x3703238 Offset: 0x36FF238 VA: 0x3703238
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3703240 Offset: 0x36FF240 VA: 0x3703240 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3703248 Offset: 0x36FF248 VA: 0x3703248
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3703250 Offset: 0x36FF250 VA: 0x3703250
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3703258 Offset: 0x36FF258 VA: 0x3703258
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3703260 Offset: 0x36FF260 VA: 0x3703260
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3703268 Offset: 0x36FF268 VA: 0x3703268
	public int get_AccountProgress() { }

	[CompilerGenerated]
	// RVA: 0x3703270 Offset: 0x36FF270 VA: 0x3703270
	public void set_AccountProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x3703278 Offset: 0x36FF278 VA: 0x3703278
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x3703280 Offset: 0x36FF280 VA: 0x3703280
	public void set_ScenarioProgress(int value) { }

	// RVA: 0x3703288 Offset: 0x36FF288 VA: 0x3703288 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3703490 Offset: 0x36FF490 VA: 0x3703490 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
