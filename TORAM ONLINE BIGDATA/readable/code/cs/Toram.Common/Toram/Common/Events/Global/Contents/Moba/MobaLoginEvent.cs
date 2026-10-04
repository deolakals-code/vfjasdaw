// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaLoginEvent : EventSubBase // TypeDefIndex: 12676
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x22
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobaAvatarData <AvatarData>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <MemberProperties>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <RuleType>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <MobPopBit>k__BackingField; // 0x4A
	[CompilerGenerated]
	private byte[] <EnableSkills>k__BackingField; // 0x50

	// Properties
	public short ReturnCode { get; set; }
	public byte Type { get; set; }
	public int Id { get; set; }
	public byte ParamId { get; set; }
	public string ParamName { get; set; }
	public MobaAvatarData AvatarData { get; set; }
	public byte[] MemberProperties { get; set; }
	public byte RuleType { get; set; }
	public short MobPopBit { get; set; }
	public byte[] EnableSkills { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363F008 Offset: 0x363B008 VA: 0x363F008
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363F010 Offset: 0x363B010 VA: 0x363F010
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x363F018 Offset: 0x363B018 VA: 0x363F018
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x363F020 Offset: 0x363B020 VA: 0x363F020
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x363F028 Offset: 0x363B028 VA: 0x363F028
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363F030 Offset: 0x363B030 VA: 0x363F030
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x363F038 Offset: 0x363B038 VA: 0x363F038
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x363F040 Offset: 0x363B040 VA: 0x363F040
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x363F048 Offset: 0x363B048 VA: 0x363F048
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363F050 Offset: 0x363B050 VA: 0x363F050
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x363F058 Offset: 0x363B058 VA: 0x363F058
	public void set_ParamName(string value) { }

	[CompilerGenerated]
	// RVA: 0x363F060 Offset: 0x363B060 VA: 0x363F060
	public MobaAvatarData get_AvatarData() { }

	[CompilerGenerated]
	// RVA: 0x363F068 Offset: 0x363B068 VA: 0x363F068
	public void set_AvatarData(MobaAvatarData value) { }

	[CompilerGenerated]
	// RVA: 0x363F070 Offset: 0x363B070 VA: 0x363F070
	public byte[] get_MemberProperties() { }

	[CompilerGenerated]
	// RVA: 0x363F078 Offset: 0x363B078 VA: 0x363F078
	public void set_MemberProperties(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x363F080 Offset: 0x363B080 VA: 0x363F080
	public byte get_RuleType() { }

	[CompilerGenerated]
	// RVA: 0x363F088 Offset: 0x363B088 VA: 0x363F088
	public void set_RuleType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363F090 Offset: 0x363B090 VA: 0x363F090
	public short get_MobPopBit() { }

	[CompilerGenerated]
	// RVA: 0x363F098 Offset: 0x363B098 VA: 0x363F098
	public void set_MobPopBit(short value) { }

	[CompilerGenerated]
	// RVA: 0x363F0A0 Offset: 0x363B0A0 VA: 0x363F0A0
	public byte[] get_EnableSkills() { }

	[CompilerGenerated]
	// RVA: 0x363F0A8 Offset: 0x363B0A8 VA: 0x363F0A8
	public void set_EnableSkills(byte[] value) { }

	// RVA: 0x363F0B0 Offset: 0x363B0B0 VA: 0x363F0B0
	public MobaSkillData[] GetSkills() { }

	// RVA: 0x363F0F8 Offset: 0x363B0F8 VA: 0x363F0F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363F100 Offset: 0x363B100 VA: 0x363F100 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363F108 Offset: 0x363B108 VA: 0x363F108 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363F31C Offset: 0x363B31C VA: 0x363F31C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
