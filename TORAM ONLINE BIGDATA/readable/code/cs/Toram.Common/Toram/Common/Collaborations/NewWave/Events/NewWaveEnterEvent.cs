// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveEnterEvent : EventSubBase // TypeDefIndex: 13048
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <DifficultyLevel>k__BackingField; // 0x30
	[CompilerGenerated]
	private BossFieldSettingData <FieldSettingData>k__BackingField; // 0x38
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int[] <NpcPopIds>k__BackingField; // 0x48

	// Properties
	public int TeamId { get; set; }
	public RaidRoomSetting Setting { get; set; }
	public short DifficultyLevel { get; set; }
	public BossFieldSettingData FieldSettingData { get; set; }
	public MobResponseData[] MobList { get; set; }
	public int[] NpcPopIds { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36972BC Offset: 0x36932BC VA: 0x36972BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36972C4 Offset: 0x36932C4 VA: 0x36972C4
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x36972CC Offset: 0x36932CC VA: 0x36972CC
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36972D4 Offset: 0x36932D4 VA: 0x36972D4
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36972DC Offset: 0x36932DC VA: 0x36972DC
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x36972E4 Offset: 0x36932E4 VA: 0x36972E4
	public short get_DifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x36972EC Offset: 0x36932EC VA: 0x36972EC
	public void set_DifficultyLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36972F4 Offset: 0x36932F4 VA: 0x36972F4
	public BossFieldSettingData get_FieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x36972FC Offset: 0x36932FC VA: 0x36972FC
	public void set_FieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3697304 Offset: 0x3693304 VA: 0x3697304
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x369730C Offset: 0x369330C VA: 0x369730C
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3697314 Offset: 0x3693314 VA: 0x3697314
	public int[] get_NpcPopIds() { }

	[CompilerGenerated]
	// RVA: 0x369731C Offset: 0x369331C VA: 0x369731C
	public void set_NpcPopIds(int[] value) { }

	// RVA: 0x3697324 Offset: 0x3693324 VA: 0x3697324 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369732C Offset: 0x369332C VA: 0x369732C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3697334 Offset: 0x3693334 VA: 0x3697334 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3697754 Offset: 0x3693754 VA: 0x3697754 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
