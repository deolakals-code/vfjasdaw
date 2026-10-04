// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionAbandonment : OperationBase // TypeDefIndex: 11411
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }

	// Methods

	// RVA: 0x3703044 Offset: 0x36FF044 VA: 0x3703044
	public void .ctor() { }

	// RVA: 0x370304C Offset: 0x36FF04C VA: 0x370304C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3703054 Offset: 0x36FF054 VA: 0x3703054
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370305C Offset: 0x36FF05C VA: 0x370305C
	public void set_AvatarUuid(int value) { }

	// RVA: 0x3703064 Offset: 0x36FF064 VA: 0x3703064 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3703198 Offset: 0x36FF198 VA: 0x3703198 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
