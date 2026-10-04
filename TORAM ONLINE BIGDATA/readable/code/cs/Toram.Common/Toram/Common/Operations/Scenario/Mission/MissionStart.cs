// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionStart : OperationBase // TypeDefIndex: 11422
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }

	// Methods

	// RVA: 0x3705C20 Offset: 0x3701C20 VA: 0x3705C20
	public void .ctor() { }

	// RVA: 0x3705C28 Offset: 0x3701C28 VA: 0x3705C28 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3705C30 Offset: 0x3701C30 VA: 0x3705C30
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3705C38 Offset: 0x3701C38 VA: 0x3705C38
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3705C40 Offset: 0x3701C40 VA: 0x3705C40
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3705C48 Offset: 0x3701C48 VA: 0x3705C48
	public void set_MissionId(int value) { }

	// RVA: 0x3705C50 Offset: 0x3701C50 VA: 0x3705C50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705DD0 Offset: 0x3701DD0 VA: 0x3705DD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
