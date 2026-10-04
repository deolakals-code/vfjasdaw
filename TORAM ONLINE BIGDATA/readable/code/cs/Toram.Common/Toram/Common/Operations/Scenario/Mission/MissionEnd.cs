// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionEnd : OperationBase // TypeDefIndex: 11415
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

	// RVA: 0x3703E1C Offset: 0x36FFE1C VA: 0x3703E1C
	public void .ctor() { }

	// RVA: 0x3703E24 Offset: 0x36FFE24 VA: 0x3703E24 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3703E2C Offset: 0x36FFE2C VA: 0x3703E2C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3703E34 Offset: 0x36FFE34 VA: 0x3703E34
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3703E3C Offset: 0x36FFE3C VA: 0x3703E3C
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3703E44 Offset: 0x36FFE44 VA: 0x3703E44
	public void set_MissionId(int value) { }

	// RVA: 0x3703E4C Offset: 0x36FFE4C VA: 0x3703E4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3703FCC Offset: 0x36FFFCC VA: 0x3703FCC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
