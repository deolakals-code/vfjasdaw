// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Roguelike
public class EnterRoguelikeField : EventSubBase // TypeDefIndex: 12802
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
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365CCCC Offset: 0x3658CCC VA: 0x365CCCC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365CCD4 Offset: 0x3658CD4 VA: 0x365CCD4
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x365CCDC Offset: 0x3658CDC VA: 0x365CCDC
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x365CCE4 Offset: 0x3658CE4 VA: 0x365CCE4
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365CCEC Offset: 0x3658CEC VA: 0x365CCEC
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x365CCF4 Offset: 0x3658CF4 VA: 0x365CCF4
	public short get_DifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x365CCFC Offset: 0x3658CFC VA: 0x365CCFC
	public void set_DifficultyLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x365CD04 Offset: 0x3658D04 VA: 0x365CD04
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x365CD0C Offset: 0x3658D0C VA: 0x365CD0C
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x365CD14 Offset: 0x3658D14 VA: 0x365CD14
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365CD1C Offset: 0x3658D1C VA: 0x365CD1C
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365CD24 Offset: 0x3658D24 VA: 0x365CD24
	public int[] get_NpcPopIds() { }

	[CompilerGenerated]
	// RVA: 0x365CD2C Offset: 0x3658D2C VA: 0x365CD2C
	public void set_NpcPopIds(int[] value) { }

	// RVA: 0x365CD34 Offset: 0x3658D34 VA: 0x365CD34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365CD3C Offset: 0x3658D3C VA: 0x365CD3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365CD44 Offset: 0x3658D44 VA: 0x365CD44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365D164 Offset: 0x3659164 VA: 0x365D164 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
