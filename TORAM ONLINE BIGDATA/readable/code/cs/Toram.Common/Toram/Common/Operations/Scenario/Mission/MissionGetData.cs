// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionGetData : PacketBase // TypeDefIndex: 11418
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x24

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }

	// Methods

	// RVA: 0x3704D38 Offset: 0x3700D38 VA: 0x3704D38
	public void .ctor() { }

	// RVA: 0x3704D40 Offset: 0x3700D40 VA: 0x3704D40 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3704D48 Offset: 0x3700D48 VA: 0x3704D48
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3704D50 Offset: 0x3700D50 VA: 0x3704D50
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3704D58 Offset: 0x3700D58 VA: 0x3704D58
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3704D60 Offset: 0x3700D60 VA: 0x3704D60
	public void set_MissionId(int value) { }

	// RVA: 0x3704D68 Offset: 0x3700D68 VA: 0x3704D68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3704ED4 Offset: 0x3700ED4 VA: 0x3704ED4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
