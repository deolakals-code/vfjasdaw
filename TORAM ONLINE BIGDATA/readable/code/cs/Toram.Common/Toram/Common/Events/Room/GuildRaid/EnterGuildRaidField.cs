// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.GuildRaid
public class EnterGuildRaidField : PacketBase // TypeDefIndex: 12800
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private BossFieldSettingData <BossFieldSettingData>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildRaidRandomPropertyData[] <RandomPropertyList>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <StartHpCount>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x49

	// Properties
	public int TeamId { get; set; }
	public RaidRoomSetting Setting { get; set; }
	public BossFieldSettingData BossFieldSettingData { get; set; }
	public MobResponseData[] MobList { get; set; }
	public GuildRaidRandomPropertyData[] RandomPropertyList { get; set; }
	public byte StartHpCount { get; set; }
	public byte CurrentHpCount { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x365C0C8 Offset: 0x36580C8 VA: 0x365C0C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365C0D0 Offset: 0x36580D0 VA: 0x365C0D0
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x365C0D8 Offset: 0x36580D8 VA: 0x365C0D8
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x365C0E0 Offset: 0x36580E0 VA: 0x365C0E0
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365C0E8 Offset: 0x36580E8 VA: 0x365C0E8
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x365C0F0 Offset: 0x36580F0 VA: 0x365C0F0
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x365C0F8 Offset: 0x36580F8 VA: 0x365C0F8
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x365C100 Offset: 0x3658100 VA: 0x365C100
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365C108 Offset: 0x3658108 VA: 0x365C108
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365C110 Offset: 0x3658110 VA: 0x365C110
	public GuildRaidRandomPropertyData[] get_RandomPropertyList() { }

	[CompilerGenerated]
	// RVA: 0x365C118 Offset: 0x3658118 VA: 0x365C118
	public void set_RandomPropertyList(GuildRaidRandomPropertyData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365C120 Offset: 0x3658120 VA: 0x365C120
	public byte get_StartHpCount() { }

	[CompilerGenerated]
	// RVA: 0x365C128 Offset: 0x3658128 VA: 0x365C128
	public void set_StartHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365C130 Offset: 0x3658130 VA: 0x365C130
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x365C138 Offset: 0x3658138 VA: 0x365C138
	public void set_CurrentHpCount(byte value) { }

	// RVA: 0x365C140 Offset: 0x3658140 VA: 0x365C140 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365C148 Offset: 0x3658148 VA: 0x365C148 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365C5D8 Offset: 0x36585D8 VA: 0x365C5D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
