// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackEventData : UnityHashBase // TypeDefIndex: 13112
{
	// Fields
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaMobResponseData[] <MobaMobList>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 20)]
	public MobResponseData[] MobList { get; set; }
	[UnityHash(Code = 98, IsOptional = True)]
	public MobaMobResponseData[] MobaMobList { get; set; }
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 85, IsOptional = True)]
	public int SkillIndividualFlag { get; set; }
	[UnityHash(Code = 46, IsOptional = True)]
	public byte Element { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A4F8C Offset: 0x36A0F8C VA: 0x36A4F8C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A4F94 Offset: 0x36A0F94 VA: 0x36A4F94
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36A4F9C Offset: 0x36A0F9C VA: 0x36A4F9C
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A4FA4 Offset: 0x36A0FA4 VA: 0x36A4FA4
	public MobaMobResponseData[] get_MobaMobList() { }

	[CompilerGenerated]
	// RVA: 0x36A4FAC Offset: 0x36A0FAC VA: 0x36A4FAC
	public void set_MobaMobList(MobaMobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A4FB4 Offset: 0x36A0FB4 VA: 0x36A4FB4
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A4FBC Offset: 0x36A0FBC VA: 0x36A4FBC
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A4FC4 Offset: 0x36A0FC4 VA: 0x36A4FC4
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A4FCC Offset: 0x36A0FCC VA: 0x36A4FCC
	public void set_SkillIndividualFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A4FD4 Offset: 0x36A0FD4 VA: 0x36A4FD4
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x36A4FDC Offset: 0x36A0FDC VA: 0x36A4FDC
	public void set_Element(byte value) { }

	// RVA: 0x36A4FE4 Offset: 0x36A0FE4 VA: 0x36A4FE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A4FEC Offset: 0x36A0FEC VA: 0x36A4FEC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A5470 Offset: 0x36A1470 VA: 0x36A5470 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
