// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaReloginEvent : EventSubBase // TypeDefIndex: 12678
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

	// RVA: 0x363FC60 Offset: 0x363BC60 VA: 0x363FC60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363FC68 Offset: 0x363BC68 VA: 0x363FC68
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x363FC70 Offset: 0x363BC70 VA: 0x363FC70
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x363FC78 Offset: 0x363BC78 VA: 0x363FC78
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x363FC80 Offset: 0x363BC80 VA: 0x363FC80
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363FC88 Offset: 0x363BC88 VA: 0x363FC88
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x363FC90 Offset: 0x363BC90 VA: 0x363FC90
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x363FC98 Offset: 0x363BC98 VA: 0x363FC98
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x363FCA0 Offset: 0x363BCA0 VA: 0x363FCA0
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363FCA8 Offset: 0x363BCA8 VA: 0x363FCA8
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x363FCB0 Offset: 0x363BCB0 VA: 0x363FCB0
	public void set_ParamName(string value) { }

	[CompilerGenerated]
	// RVA: 0x363FCB8 Offset: 0x363BCB8 VA: 0x363FCB8
	public MobaAvatarData get_AvatarData() { }

	[CompilerGenerated]
	// RVA: 0x363FCC0 Offset: 0x363BCC0 VA: 0x363FCC0
	public void set_AvatarData(MobaAvatarData value) { }

	[CompilerGenerated]
	// RVA: 0x363FCC8 Offset: 0x363BCC8 VA: 0x363FCC8
	public byte[] get_MemberProperties() { }

	[CompilerGenerated]
	// RVA: 0x363FCD0 Offset: 0x363BCD0 VA: 0x363FCD0
	public void set_MemberProperties(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x363FCD8 Offset: 0x363BCD8 VA: 0x363FCD8
	public byte get_RuleType() { }

	[CompilerGenerated]
	// RVA: 0x363FCE0 Offset: 0x363BCE0 VA: 0x363FCE0
	public void set_RuleType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363FCE8 Offset: 0x363BCE8 VA: 0x363FCE8
	public short get_MobPopBit() { }

	[CompilerGenerated]
	// RVA: 0x363FCF0 Offset: 0x363BCF0 VA: 0x363FCF0
	public void set_MobPopBit(short value) { }

	[CompilerGenerated]
	// RVA: 0x363FCF8 Offset: 0x363BCF8 VA: 0x363FCF8
	public byte[] get_EnableSkills() { }

	[CompilerGenerated]
	// RVA: 0x363FD00 Offset: 0x363BD00 VA: 0x363FD00
	public void set_EnableSkills(byte[] value) { }

	// RVA: 0x363FD08 Offset: 0x363BD08 VA: 0x363FD08
	public MobaSkillData[] GetSkills() { }

	// RVA: 0x363FD50 Offset: 0x363BD50 VA: 0x363FD50 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363FD58 Offset: 0x363BD58 VA: 0x363FD58 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363FD60 Offset: 0x363BD60 VA: 0x363FD60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363FF74 Offset: 0x363BF74 VA: 0x363FF74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
