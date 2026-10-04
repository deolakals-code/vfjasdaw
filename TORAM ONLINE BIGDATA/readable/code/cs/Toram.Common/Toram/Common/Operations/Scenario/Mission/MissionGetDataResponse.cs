// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionGetDataResponse : PacketBase // TypeDefIndex: 11419
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private MissionCommon <MissionData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 155, IsOptional = True)]
	public MissionCommon MissionData { get; set; }

	// Methods

	// RVA: 0x3704FD0 Offset: 0x3700FD0 VA: 0x3704FD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3704FD8 Offset: 0x3700FD8 VA: 0x3704FD8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3704FE0 Offset: 0x3700FE0 VA: 0x3704FE0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3704FE8 Offset: 0x3700FE8 VA: 0x3704FE8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3704FF0 Offset: 0x3700FF0 VA: 0x3704FF0
	public MissionCommon get_MissionData() { }

	[CompilerGenerated]
	// RVA: 0x3704FF8 Offset: 0x3700FF8 VA: 0x3704FF8
	public void set_MissionData(MissionCommon value) { }

	// RVA: 0x3705000 Offset: 0x3701000 VA: 0x3705000
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x370511C Offset: 0x370111C VA: 0x370511C
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3705198 Offset: 0x3701198 VA: 0x3705198 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37052C8 Offset: 0x37012C8 VA: 0x37052C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
