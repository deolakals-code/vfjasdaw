// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildAcceptanceResponse : PacketBase // TypeDefIndex: 12378
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

	// Methods

	// RVA: 0x35FD628 Offset: 0x35F9628 VA: 0x35FD628
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FD630 Offset: 0x35F9630 VA: 0x35FD630 Slot: 7
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FD638 Offset: 0x35F9638 VA: 0x35FD638 Slot: 8
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FD640 Offset: 0x35F9640 VA: 0x35FD640 Slot: 9
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x35FD648 Offset: 0x35F9648 VA: 0x35FD648 Slot: 10
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FD650 Offset: 0x35F9650 VA: 0x35FD650 Slot: 11
	public GuildUserData get_User() { }

	[CompilerGenerated]
	// RVA: 0x35FD658 Offset: 0x35F9658 VA: 0x35FD658 Slot: 12
	public void set_User(GuildUserData value) { }

	[CompilerGenerated]
	// RVA: 0x35FD660 Offset: 0x35F9660 VA: 0x35FD660 Slot: 13
	public DateTime get_GuildLatestMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x35FD668 Offset: 0x35F9668 VA: 0x35FD668 Slot: 14
	public void set_GuildLatestMsgTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35FD670 Offset: 0x35F9670 VA: 0x35FD670
	public byte get_BoosterType() { }

	[CompilerGenerated]
	// RVA: 0x35FD678 Offset: 0x35F9678 VA: 0x35FD678
	public void set_BoosterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FD680 Offset: 0x35F9680 VA: 0x35FD680
	public int get_BoostRate() { }

	[CompilerGenerated]
	// RVA: 0x35FD688 Offset: 0x35F9688 VA: 0x35FD688
	public void set_BoostRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FD690 Offset: 0x35F9690 VA: 0x35FD690
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x35FD698 Offset: 0x35F9698 VA: 0x35FD698
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35FD6A0 Offset: 0x35F96A0 VA: 0x35FD6A0 Slot: 15
	public string get_GuildLoginMessage() { }

	[CompilerGenerated]
	// RVA: 0x35FD6A8 Offset: 0x35F96A8 VA: 0x35FD6A8 Slot: 16
	public void set_GuildLoginMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FD6B0 Offset: 0x35F96B0 VA: 0x35FD6B0 Slot: 17
	public byte get_MemberVersion() { }

	[CompilerGenerated]
	// RVA: 0x35FD6B8 Offset: 0x35F96B8 VA: 0x35FD6B8 Slot: 18
	public void set_MemberVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FD6C0 Offset: 0x35F96C0 VA: 0x35FD6C0 Slot: 19
	public int[] get_MemberIdList() { }

	[CompilerGenerated]
	// RVA: 0x35FD6C8 Offset: 0x35F96C8 VA: 0x35FD6C8 Slot: 20
	public void set_MemberIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x35FD6D0 Offset: 0x35F96D0 VA: 0x35FD6D0
	public int get_GuildRaidStamina() { }

	[CompilerGenerated]
	// RVA: 0x35FD6D8 Offset: 0x35F96D8 VA: 0x35FD6D8
	public void set_GuildRaidStamina(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FD6E0 Offset: 0x35F96E0 VA: 0x35FD6E0
	public GuildFacilityData[] get_FacilityList() { }

	[CompilerGenerated]
	// RVA: 0x35FD6E8 Offset: 0x35F96E8 VA: 0x35FD6E8
	public void set_FacilityList(GuildFacilityData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35FD6F0 Offset: 0x35F96F0 VA: 0x35FD6F0
	public GuildVariableData[] get_VariableList() { }

	[CompilerGenerated]
	// RVA: 0x35FD6F8 Offset: 0x35F96F8 VA: 0x35FD6F8
	public void set_VariableList(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35FD700 Offset: 0x35F9700 VA: 0x35FD700
	public GuildAllianceData get_AllianceData() { }

	[CompilerGenerated]
	// RVA: 0x35FD708 Offset: 0x35F9708 VA: 0x35FD708
	public void set_AllianceData(GuildAllianceData value) { }

	// RVA: 0x35FD710 Offset: 0x35F9710 VA: 0x35FD710 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FD718 Offset: 0x35F9718 VA: 0x35FD718 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FDED0 Offset: 0x35F9ED0 VA: 0x35FDED0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
