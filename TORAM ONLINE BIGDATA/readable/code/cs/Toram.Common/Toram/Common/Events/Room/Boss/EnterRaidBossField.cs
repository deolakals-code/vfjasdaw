// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Boss
public class EnterRaidBossField : PacketBase // TypeDefIndex: 12778
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <DifficultyLevel>k__BackingField; // 0x30
	[CompilerGenerated]
	private BossFieldSettingData <BossFieldSettingData>k__BackingField; // 0x38
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int[] <NpcPopIds>k__BackingField; // 0x48

	// Properties
	public int TeamId { get; set; }
	public RaidRoomSetting Setting { get; set; }
	public short DifficultyLevel { get; set; }
	public BossFieldSettingData BossFieldSettingData { get; set; }
	public MobResponseData[] MobList { get; set; }
	public int[] NpcPopIds { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3656C44 Offset: 0x3652C44 VA: 0x3656C44
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3656C4C Offset: 0x3652C4C VA: 0x3656C4C
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x3656C54 Offset: 0x3652C54 VA: 0x3656C54
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3656C5C Offset: 0x3652C5C VA: 0x3656C5C
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3656C64 Offset: 0x3652C64 VA: 0x3656C64
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3656C6C Offset: 0x3652C6C VA: 0x3656C6C
	public short get_DifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x3656C74 Offset: 0x3652C74 VA: 0x3656C74
	public void set_DifficultyLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x3656C7C Offset: 0x3652C7C VA: 0x3656C7C
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x3656C84 Offset: 0x3652C84 VA: 0x3656C84
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3656C8C Offset: 0x3652C8C VA: 0x3656C8C
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3656C94 Offset: 0x3652C94 VA: 0x3656C94
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3656C9C Offset: 0x3652C9C VA: 0x3656C9C
	public int[] get_NpcPopIds() { }

	[CompilerGenerated]
	// RVA: 0x3656CA4 Offset: 0x3652CA4 VA: 0x3656CA4
	public void set_NpcPopIds(int[] value) { }

	// RVA: 0x3656CAC Offset: 0x3652CAC VA: 0x3656CAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3656CB4 Offset: 0x3652CB4 VA: 0x3656CB4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36570D4 Offset: 0x36530D4 VA: 0x36570D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
