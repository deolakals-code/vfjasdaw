// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.HighRaid
public class EnterHighRaidField : PacketBase // TypeDefIndex: 12799
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

	// RVA: 0x365BA88 Offset: 0x3657A88 VA: 0x365BA88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365BA90 Offset: 0x3657A90 VA: 0x365BA90
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x365BA98 Offset: 0x3657A98 VA: 0x365BA98
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x365BAA0 Offset: 0x3657AA0 VA: 0x365BAA0
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365BAA8 Offset: 0x3657AA8 VA: 0x365BAA8
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x365BAB0 Offset: 0x3657AB0 VA: 0x365BAB0
	public short get_DifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x365BAB8 Offset: 0x3657AB8 VA: 0x365BAB8
	public void set_DifficultyLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x365BAC0 Offset: 0x3657AC0 VA: 0x365BAC0
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x365BAC8 Offset: 0x3657AC8 VA: 0x365BAC8
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x365BAD0 Offset: 0x3657AD0 VA: 0x365BAD0
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365BAD8 Offset: 0x3657AD8 VA: 0x365BAD8
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365BAE0 Offset: 0x3657AE0 VA: 0x365BAE0
	public int[] get_NpcPopIds() { }

	[CompilerGenerated]
	// RVA: 0x365BAE8 Offset: 0x3657AE8 VA: 0x365BAE8
	public void set_NpcPopIds(int[] value) { }

	// RVA: 0x365BAF0 Offset: 0x3657AF0 VA: 0x365BAF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365BAF8 Offset: 0x3657AF8 VA: 0x365BAF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365BF18 Offset: 0x3657F18 VA: 0x365BF18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
