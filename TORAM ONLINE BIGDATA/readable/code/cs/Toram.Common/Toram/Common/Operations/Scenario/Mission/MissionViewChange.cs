// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionViewChange : OperationBase // TypeDefIndex: 11426
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <ScenarioInfoNo>k__BackingField; // 0x34

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 125, IsOptional = True)]
	public short KeySetting { get; set; }
	[PacketParameter(Code = 126, IsOptional = True)]
	public short ItemSetting { get; set; }
	[PacketParameter(Code = 127, IsOptional = True)]
	public short MobSetting { get; set; }
	[PacketParameter(Code = 128, IsOptional = True)]
	public byte ScenarioInfoNo { get; set; }

	// Methods

	// RVA: 0x37069D0 Offset: 0x37029D0 VA: 0x37069D0
	public void .ctor() { }

	// RVA: 0x37069D8 Offset: 0x37029D8 VA: 0x37069D8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37069E0 Offset: 0x37029E0 VA: 0x37069E0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37069E8 Offset: 0x37029E8 VA: 0x37069E8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37069F0 Offset: 0x37029F0 VA: 0x37069F0
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37069F8 Offset: 0x37029F8 VA: 0x37069F8
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3706A00 Offset: 0x3702A00 VA: 0x3706A00
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3706A08 Offset: 0x3702A08 VA: 0x3706A08
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3706A10 Offset: 0x3702A10 VA: 0x3706A10
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x3706A18 Offset: 0x3702A18 VA: 0x3706A18
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3706A20 Offset: 0x3702A20 VA: 0x3706A20
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x3706A28 Offset: 0x3702A28 VA: 0x3706A28
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3706A30 Offset: 0x3702A30 VA: 0x3706A30
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x3706A38 Offset: 0x3702A38 VA: 0x3706A38
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3706A40 Offset: 0x3702A40 VA: 0x3706A40
	public byte get_ScenarioInfoNo() { }

	[CompilerGenerated]
	// RVA: 0x3706A48 Offset: 0x3702A48 VA: 0x3706A48
	public void set_ScenarioInfoNo(byte value) { }

	// RVA: 0x3706A50 Offset: 0x3702A50 VA: 0x3706A50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3706DD0 Offset: 0x3702DD0 VA: 0x3706DD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
