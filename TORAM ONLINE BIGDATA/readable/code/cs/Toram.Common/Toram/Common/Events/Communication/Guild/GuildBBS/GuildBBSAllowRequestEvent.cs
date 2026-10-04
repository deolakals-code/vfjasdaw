// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.GuildBBS
public class GuildBBSAllowRequestEvent : EventSubBase // TypeDefIndex: 12932
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildUserData <User>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <GuildLatestMsgTime>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <BoosterType>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <BoostRate>k__BackingField; // 0x44
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <GuildLoginMessage>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte <MemberVersion>k__BackingField; // 0x58
	[CompilerGenerated]
	private int[] <MemberIdList>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <GuildRaidStamina>k__BackingField; // 0x68
	[CompilerGenerated]
	private GuildFacilityData[] <FacilityList>k__BackingField; // 0x70
	[CompilerGenerated]
	private GuildVariableData[] <VariableList>k__BackingField; // 0x78
	[CompilerGenerated]
	private GuildAllianceData <AllianceData>k__BackingField; // 0x80

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public GuildUserData User { get; set; }
	public DateTime GuildLatestMsgTime { get; set; }
	public byte BoosterType { get; set; }
	public int BoostRate { get; set; }
	public GameStatusData GameStatus { get; set; }
	public string GuildLoginMessage { get; set; }
	public byte MemberVersion { get; set; }
	public int[] MemberIdList { get; set; }
	public int GuildRaidStamina { get; set; }
	public GuildFacilityData[] FacilityList { get; set; }
	public GuildVariableData[] VariableList { get; set; }
	public GuildAllianceData AllianceData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367AE60 Offset: 0x3676E60 VA: 0x367AE60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367AE68 Offset: 0x3676E68 VA: 0x367AE68 Slot: 8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x367AE70 Offset: 0x3676E70 VA: 0x367AE70 Slot: 9
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367AE78 Offset: 0x3676E78 VA: 0x367AE78 Slot: 10
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x367AE80 Offset: 0x3676E80 VA: 0x367AE80 Slot: 11
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x367AE88 Offset: 0x3676E88 VA: 0x367AE88 Slot: 12
	public GuildUserData get_User() { }

	[CompilerGenerated]
	// RVA: 0x367AE90 Offset: 0x3676E90 VA: 0x367AE90 Slot: 13
	public void set_User(GuildUserData value) { }

	[CompilerGenerated]
	// RVA: 0x367AE98 Offset: 0x3676E98 VA: 0x367AE98 Slot: 14
	public DateTime get_GuildLatestMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x367AEA0 Offset: 0x3676EA0 VA: 0x367AEA0 Slot: 15
	public void set_GuildLatestMsgTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x367AEA8 Offset: 0x3676EA8 VA: 0x367AEA8
	public byte get_BoosterType() { }

	[CompilerGenerated]
	// RVA: 0x367AEB0 Offset: 0x3676EB0 VA: 0x367AEB0
	public void set_BoosterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367AEB8 Offset: 0x3676EB8 VA: 0x367AEB8
	public int get_BoostRate() { }

	[CompilerGenerated]
	// RVA: 0x367AEC0 Offset: 0x3676EC0 VA: 0x367AEC0
	public void set_BoostRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x367AEC8 Offset: 0x3676EC8 VA: 0x367AEC8
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x367AED0 Offset: 0x3676ED0 VA: 0x367AED0
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367AED8 Offset: 0x3676ED8 VA: 0x367AED8 Slot: 16
	public string get_GuildLoginMessage() { }

	[CompilerGenerated]
	// RVA: 0x367AEE0 Offset: 0x3676EE0 VA: 0x367AEE0 Slot: 17
	public void set_GuildLoginMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x367AEE8 Offset: 0x3676EE8 VA: 0x367AEE8 Slot: 18
	public byte get_MemberVersion() { }

	[CompilerGenerated]
	// RVA: 0x367AEF0 Offset: 0x3676EF0 VA: 0x367AEF0 Slot: 19
	public void set_MemberVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367AEF8 Offset: 0x3676EF8 VA: 0x367AEF8 Slot: 20
	public int[] get_MemberIdList() { }

	[CompilerGenerated]
	// RVA: 0x367AF00 Offset: 0x3676F00 VA: 0x367AF00 Slot: 21
	public void set_MemberIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x367AF08 Offset: 0x3676F08 VA: 0x367AF08
	public int get_GuildRaidStamina() { }

	[CompilerGenerated]
	// RVA: 0x367AF10 Offset: 0x3676F10 VA: 0x367AF10
	public void set_GuildRaidStamina(int value) { }

	[CompilerGenerated]
	// RVA: 0x367AF18 Offset: 0x3676F18 VA: 0x367AF18
	public GuildFacilityData[] get_FacilityList() { }

	[CompilerGenerated]
	// RVA: 0x367AF20 Offset: 0x3676F20 VA: 0x367AF20
	public void set_FacilityList(GuildFacilityData[] value) { }

	[CompilerGenerated]
	// RVA: 0x367AF28 Offset: 0x3676F28 VA: 0x367AF28
	public GuildVariableData[] get_VariableList() { }

	[CompilerGenerated]
	// RVA: 0x367AF30 Offset: 0x3676F30 VA: 0x367AF30
	public void set_VariableList(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x367AF38 Offset: 0x3676F38 VA: 0x367AF38
	public GuildAllianceData get_AllianceData() { }

	[CompilerGenerated]
	// RVA: 0x367AF40 Offset: 0x3676F40 VA: 0x367AF40
	public void set_AllianceData(GuildAllianceData value) { }

	// RVA: 0x367AF48 Offset: 0x3676F48 VA: 0x367AF48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367AF50 Offset: 0x3676F50 VA: 0x367AF50 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367AF58 Offset: 0x3676F58 VA: 0x367AF58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x367B710 Offset: 0x3677710 VA: 0x367B710 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
