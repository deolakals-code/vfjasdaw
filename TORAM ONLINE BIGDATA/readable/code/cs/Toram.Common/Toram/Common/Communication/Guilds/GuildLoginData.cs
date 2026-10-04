// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds
public class GuildLoginData : PacketBase // TypeDefIndex: 13017
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <GuildLevel>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <BoosterType>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <MemberVersion>k__BackingField; // 0x33
	[CompilerGenerated]
	private int[] <MemberIdList>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <GuildLatestMsgTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <GuildLoginMessage>k__BackingField; // 0x48
	[CompilerGenerated]
	private GuildUserData <User>k__BackingField; // 0x50
	[CompilerGenerated]
	private GuildVariableData[] <VariableData>k__BackingField; // 0x58
	[CompilerGenerated]
	private GuildStaffData <StaffData>k__BackingField; // 0x60
	[CompilerGenerated]
	private GuildRenovationData <RenovationData>k__BackingField; // 0x68
	[CompilerGenerated]
	private GuildItemData[] <ItemList>k__BackingField; // 0x70
	[CompilerGenerated]
	private GuildRaidData <Raid>k__BackingField; // 0x78
	[CompilerGenerated]
	private GuildFacilityData[] <FacilityList>k__BackingField; // 0x80
	[CompilerGenerated]
	private GuildFacilityUseElementData <UseElementData>k__BackingField; // 0x88
	[CompilerGenerated]
	private GuildAllianceData <AllianceData>k__BackingField; // 0x90

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public short GuildLevel { get; set; }
	public byte BoosterType { get; set; }
	public byte MemberVersion { get; set; }
	public int[] MemberIdList { get; set; }
	public DateTime GuildLatestMsgTime { get; set; }
	public string GuildLoginMessage { get; set; }
	public GuildUserData User { get; set; }
	public GuildVariableData[] VariableData { get; set; }
	public GuildStaffData StaffData { get; set; }
	public GuildRenovationData RenovationData { get; set; }
	public GuildItemData[] ItemList { get; set; }
	public GuildRaidData Raid { get; set; }
	public GuildFacilityData[] FacilityList { get; set; }
	public GuildFacilityUseElementData UseElementData { get; set; }
	public GuildAllianceData AllianceData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3686D64 Offset: 0x3682D64 VA: 0x3686D64
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x368E9EC Offset: 0x368A9EC VA: 0x368E9EC Slot: 7
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x368E9F4 Offset: 0x368A9F4 VA: 0x368E9F4 Slot: 8
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368E9FC Offset: 0x368A9FC VA: 0x368E9FC Slot: 9
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x368EA04 Offset: 0x368AA04 VA: 0x368EA04 Slot: 10
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368EA0C Offset: 0x368AA0C VA: 0x368EA0C
	public short get_GuildLevel() { }

	[CompilerGenerated]
	// RVA: 0x368EA14 Offset: 0x368AA14 VA: 0x368EA14
	public void set_GuildLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x368EA1C Offset: 0x368AA1C VA: 0x368EA1C
	public byte get_BoosterType() { }

	[CompilerGenerated]
	// RVA: 0x368EA24 Offset: 0x368AA24 VA: 0x368EA24
	public void set_BoosterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368EA2C Offset: 0x368AA2C VA: 0x368EA2C Slot: 11
	public byte get_MemberVersion() { }

	[CompilerGenerated]
	// RVA: 0x368EA34 Offset: 0x368AA34 VA: 0x368EA34 Slot: 12
	public void set_MemberVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368EA3C Offset: 0x368AA3C VA: 0x368EA3C Slot: 13
	public int[] get_MemberIdList() { }

	[CompilerGenerated]
	// RVA: 0x368EA44 Offset: 0x368AA44 VA: 0x368EA44 Slot: 14
	public void set_MemberIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x368EA4C Offset: 0x368AA4C VA: 0x368EA4C Slot: 15
	public DateTime get_GuildLatestMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x368EA54 Offset: 0x368AA54 VA: 0x368EA54 Slot: 16
	public void set_GuildLatestMsgTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x368EA5C Offset: 0x368AA5C VA: 0x368EA5C Slot: 17
	public string get_GuildLoginMessage() { }

	[CompilerGenerated]
	// RVA: 0x368EA64 Offset: 0x368AA64 VA: 0x368EA64 Slot: 18
	public void set_GuildLoginMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x368EA6C Offset: 0x368AA6C VA: 0x368EA6C Slot: 19
	public GuildUserData get_User() { }

	[CompilerGenerated]
	// RVA: 0x368EA74 Offset: 0x368AA74 VA: 0x368EA74 Slot: 20
	public void set_User(GuildUserData value) { }

	[CompilerGenerated]
	// RVA: 0x368EA7C Offset: 0x368AA7C VA: 0x368EA7C
	public GuildVariableData[] get_VariableData() { }

	[CompilerGenerated]
	// RVA: 0x368EA84 Offset: 0x368AA84 VA: 0x368EA84
	public void set_VariableData(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x368EA8C Offset: 0x368AA8C VA: 0x368EA8C
	public GuildStaffData get_StaffData() { }

	[CompilerGenerated]
	// RVA: 0x368EA94 Offset: 0x368AA94 VA: 0x368EA94
	public void set_StaffData(GuildStaffData value) { }

	[CompilerGenerated]
	// RVA: 0x368EA9C Offset: 0x368AA9C VA: 0x368EA9C
	public GuildRenovationData get_RenovationData() { }

	[CompilerGenerated]
	// RVA: 0x368EAA4 Offset: 0x368AAA4 VA: 0x368EAA4
	public void set_RenovationData(GuildRenovationData value) { }

	[CompilerGenerated]
	// RVA: 0x368EAAC Offset: 0x368AAAC VA: 0x368EAAC
	public GuildItemData[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x368EAB4 Offset: 0x368AAB4 VA: 0x368EAB4
	public void set_ItemList(GuildItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x368EABC Offset: 0x368AABC VA: 0x368EABC
	public GuildRaidData get_Raid() { }

	[CompilerGenerated]
	// RVA: 0x368EAC4 Offset: 0x368AAC4 VA: 0x368EAC4
	public void set_Raid(GuildRaidData value) { }

	[CompilerGenerated]
	// RVA: 0x368EACC Offset: 0x368AACC VA: 0x368EACC
	public GuildFacilityData[] get_FacilityList() { }

	[CompilerGenerated]
	// RVA: 0x368EAD4 Offset: 0x368AAD4 VA: 0x368EAD4
	public void set_FacilityList(GuildFacilityData[] value) { }

	[CompilerGenerated]
	// RVA: 0x368EADC Offset: 0x368AADC VA: 0x368EADC
	public GuildFacilityUseElementData get_UseElementData() { }

	[CompilerGenerated]
	// RVA: 0x368EAE4 Offset: 0x368AAE4 VA: 0x368EAE4
	public void set_UseElementData(GuildFacilityUseElementData value) { }

	[CompilerGenerated]
	// RVA: 0x368EAEC Offset: 0x368AAEC VA: 0x368EAEC
	public GuildAllianceData get_AllianceData() { }

	[CompilerGenerated]
	// RVA: 0x368EAF4 Offset: 0x368AAF4 VA: 0x368EAF4
	public void set_AllianceData(GuildAllianceData value) { }

	// RVA: 0x368EAFC Offset: 0x368AAFC VA: 0x368EAFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x368EB04 Offset: 0x368AB04 VA: 0x368EB04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x368F558 Offset: 0x368B558 VA: 0x368F558 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
