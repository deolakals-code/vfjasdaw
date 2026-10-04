// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionViewChangeResponse : OperationBase // TypeDefIndex: 11427
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <ScenarioInfoNo>k__BackingField; // 0x32

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 125, IsOptional = True)]
	public short KeySetting { get; set; }
	[PacketParameter(Code = 126, IsOptional = True)]
	public short ItemSetting { get; set; }
	[PacketParameter(Code = 127, IsOptional = True)]
	public short MobSetting { get; set; }
	[PacketParameter(Code = 128, IsOptional = True)]
	public byte ScenarioInfoNo { get; set; }

	// Methods

	// RVA: 0x3706FA8 Offset: 0x3702FA8 VA: 0x3706FA8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3706FB0 Offset: 0x3702FB0 VA: 0x3706FB0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3706FB8 Offset: 0x3702FB8 VA: 0x3706FB8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3706FC0 Offset: 0x3702FC0 VA: 0x3706FC0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3706FC8 Offset: 0x3702FC8 VA: 0x3706FC8
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3706FD0 Offset: 0x3702FD0 VA: 0x3706FD0
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3706FD8 Offset: 0x3702FD8 VA: 0x3706FD8
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x3706FE0 Offset: 0x3702FE0 VA: 0x3706FE0
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3706FE8 Offset: 0x3702FE8 VA: 0x3706FE8
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x3706FF0 Offset: 0x3702FF0 VA: 0x3706FF0
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3706FF8 Offset: 0x3702FF8 VA: 0x3706FF8
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x3707000 Offset: 0x3703000 VA: 0x3707000
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3707008 Offset: 0x3703008 VA: 0x3707008
	public byte get_ScenarioInfoNo() { }

	[CompilerGenerated]
	// RVA: 0x3707010 Offset: 0x3703010 VA: 0x3707010
	public void set_ScenarioInfoNo(byte value) { }

	// RVA: 0x3707018 Offset: 0x3703018 VA: 0x3707018 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3707354 Offset: 0x3703354 VA: 0x3707354 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
