// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionEndResponse : OperationBase // TypeDefIndex: 11416
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
	[CompilerGenerated]
	private MissionCommon <MissionData>k__BackingField; // 0x38

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 157, IsOptional = True)]
	public int AccountProgress { get; set; }
	[PacketParameter(Code = 158)]
	public int ScenarioProgress { get; set; }
	[PacketClass(Code = 155, IsOptional = True)]
	public MissionCommon MissionData { get; set; }

	// Methods

	// RVA: 0x3704094 Offset: 0x3700094 VA: 0x3704094
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370409C Offset: 0x370009C VA: 0x370409C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37040A4 Offset: 0x37000A4 VA: 0x37040A4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37040AC Offset: 0x37000AC VA: 0x37040AC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37040B4 Offset: 0x37000B4 VA: 0x37040B4
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37040BC Offset: 0x37000BC VA: 0x37040BC
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37040C4 Offset: 0x37000C4 VA: 0x37040C4
	public int get_AccountProgress() { }

	[CompilerGenerated]
	// RVA: 0x37040CC Offset: 0x37000CC VA: 0x37040CC
	public void set_AccountProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x37040D4 Offset: 0x37000D4 VA: 0x37040D4
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x37040DC Offset: 0x37000DC VA: 0x37040DC
	public void set_ScenarioProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x37040E4 Offset: 0x37000E4 VA: 0x37040E4
	public MissionCommon get_MissionData() { }

	[CompilerGenerated]
	// RVA: 0x37040EC Offset: 0x37000EC VA: 0x37040EC
	public void set_MissionData(MissionCommon value) { }

	// RVA: 0x37040F4 Offset: 0x37000F4 VA: 0x37040F4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3704210 Offset: 0x3700210 VA: 0x3704210
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x370428C Offset: 0x370028C VA: 0x370428C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37044D0 Offset: 0x37004D0 VA: 0x37044D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
