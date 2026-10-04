// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSAutoJoinRequestResponse : OperationResponseBase // TypeDefIndex: 12458
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

	// RVA: 0x360ACB8 Offset: 0x3606CB8 VA: 0x360ACB8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360ACC0 Offset: 0x3606CC0 VA: 0x360ACC0 Slot: 8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360ACC8 Offset: 0x3606CC8 VA: 0x360ACC8 Slot: 9
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360ACD0 Offset: 0x3606CD0 VA: 0x360ACD0 Slot: 10
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x360ACD8 Offset: 0x3606CD8 VA: 0x360ACD8 Slot: 11
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x360ACE0 Offset: 0x3606CE0 VA: 0x360ACE0 Slot: 12
	public GuildUserData get_User() { }

	[CompilerGenerated]
	// RVA: 0x360ACE8 Offset: 0x3606CE8 VA: 0x360ACE8 Slot: 13
	public void set_User(GuildUserData value) { }

	[CompilerGenerated]
	// RVA: 0x360ACF0 Offset: 0x3606CF0 VA: 0x360ACF0 Slot: 14
	public DateTime get_GuildLatestMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x360ACF8 Offset: 0x3606CF8 VA: 0x360ACF8 Slot: 15
	public void set_GuildLatestMsgTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x360AD00 Offset: 0x3606D00 VA: 0x360AD00
	public byte get_BoosterType() { }

	[CompilerGenerated]
	// RVA: 0x360AD08 Offset: 0x3606D08 VA: 0x360AD08
	public void set_BoosterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360AD10 Offset: 0x3606D10 VA: 0x360AD10
	public int get_BoostRate() { }

	[CompilerGenerated]
	// RVA: 0x360AD18 Offset: 0x3606D18 VA: 0x360AD18
	public void set_BoostRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x360AD20 Offset: 0x3606D20 VA: 0x360AD20
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x360AD28 Offset: 0x3606D28 VA: 0x360AD28
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x360AD30 Offset: 0x3606D30 VA: 0x360AD30 Slot: 16
	public string get_GuildLoginMessage() { }

	[CompilerGenerated]
	// RVA: 0x360AD38 Offset: 0x3606D38 VA: 0x360AD38 Slot: 17
	public void set_GuildLoginMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x360AD40 Offset: 0x3606D40 VA: 0x360AD40 Slot: 18
	public byte get_MemberVersion() { }

	[CompilerGenerated]
	// RVA: 0x360AD48 Offset: 0x3606D48 VA: 0x360AD48 Slot: 19
	public void set_MemberVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360AD50 Offset: 0x3606D50 VA: 0x360AD50 Slot: 20
	public int[] get_MemberIdList() { }

	[CompilerGenerated]
	// RVA: 0x360AD58 Offset: 0x3606D58 VA: 0x360AD58 Slot: 21
	public void set_MemberIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x360AD60 Offset: 0x3606D60 VA: 0x360AD60
	public int get_GuildRaidStamina() { }

	[CompilerGenerated]
	// RVA: 0x360AD68 Offset: 0x3606D68 VA: 0x360AD68
	public void set_GuildRaidStamina(int value) { }

	[CompilerGenerated]
	// RVA: 0x360AD70 Offset: 0x3606D70 VA: 0x360AD70
	public GuildFacilityData[] get_FacilityList() { }

	[CompilerGenerated]
	// RVA: 0x360AD78 Offset: 0x3606D78 VA: 0x360AD78
	public void set_FacilityList(GuildFacilityData[] value) { }

	[CompilerGenerated]
	// RVA: 0x360AD80 Offset: 0x3606D80 VA: 0x360AD80
	public GuildVariableData[] get_VariableList() { }

	[CompilerGenerated]
	// RVA: 0x360AD88 Offset: 0x3606D88 VA: 0x360AD88
	public void set_VariableList(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x360AD90 Offset: 0x3606D90 VA: 0x360AD90
	public GuildAllianceData get_AllianceData() { }

	[CompilerGenerated]
	// RVA: 0x360AD98 Offset: 0x3606D98 VA: 0x360AD98
	public void set_AllianceData(GuildAllianceData value) { }

	// RVA: 0x360ADA0 Offset: 0x3606DA0 VA: 0x360ADA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360ADA8 Offset: 0x3606DA8 VA: 0x360ADA8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360ADB0 Offset: 0x3606DB0 VA: 0x360ADB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360B0BC Offset: 0x36070BC VA: 0x360B0BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
