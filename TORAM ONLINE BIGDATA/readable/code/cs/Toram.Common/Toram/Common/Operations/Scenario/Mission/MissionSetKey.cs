// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionSetKey : OperationBase // TypeDefIndex: 11420
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MissionKeyCommon <MissionKey>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketClass(Code = 156, IsOptional = True)]
	public MissionKeyCommon MissionKey { get; set; }

	// Methods

	// RVA: 0x37053A8 Offset: 0x37013A8 VA: 0x37053A8
	public void .ctor() { }

	// RVA: 0x37053B0 Offset: 0x37013B0 VA: 0x37053B0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37053B8 Offset: 0x37013B8 VA: 0x37053B8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37053C0 Offset: 0x37013C0 VA: 0x37053C0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37053C8 Offset: 0x37013C8 VA: 0x37053C8
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37053D0 Offset: 0x37013D0 VA: 0x37053D0
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37053D8 Offset: 0x37013D8 VA: 0x37053D8
	public MissionKeyCommon get_MissionKey() { }

	[CompilerGenerated]
	// RVA: 0x37053E0 Offset: 0x37013E0 VA: 0x37053E0
	public void set_MissionKey(MissionKeyCommon value) { }

	// RVA: 0x37053E8 Offset: 0x37013E8 VA: 0x37053E8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705504 Offset: 0x3701504 VA: 0x3705504
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3705580 Offset: 0x3701580 VA: 0x3705580 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705710 Offset: 0x3701710 VA: 0x3705710 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
