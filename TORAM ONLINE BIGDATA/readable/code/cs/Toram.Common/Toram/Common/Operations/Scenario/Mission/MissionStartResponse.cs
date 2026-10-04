// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionStartResponse : OperationBase // TypeDefIndex: 11423
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MissionCommon <MissionData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketClass(Code = 155, IsOptional = True)]
	public MissionCommon MissionData { get; set; }

	// Methods

	// RVA: 0x3705E98 Offset: 0x3701E98 VA: 0x3705E98
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705EA0 Offset: 0x3701EA0 VA: 0x3705EA0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3705EA8 Offset: 0x3701EA8 VA: 0x3705EA8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3705EB0 Offset: 0x3701EB0 VA: 0x3705EB0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3705EB8 Offset: 0x3701EB8 VA: 0x3705EB8
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3705EC0 Offset: 0x3701EC0 VA: 0x3705EC0
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3705EC8 Offset: 0x3701EC8 VA: 0x3705EC8
	public MissionCommon get_MissionData() { }

	[CompilerGenerated]
	// RVA: 0x3705ED0 Offset: 0x3701ED0 VA: 0x3705ED0
	public void set_MissionData(MissionCommon value) { }

	// RVA: 0x3705ED8 Offset: 0x3701ED8 VA: 0x3705ED8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705FF4 Offset: 0x3701FF4 VA: 0x3705FF4
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3706070 Offset: 0x3702070 VA: 0x3706070 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3706200 Offset: 0x3702200 VA: 0x3706200 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
