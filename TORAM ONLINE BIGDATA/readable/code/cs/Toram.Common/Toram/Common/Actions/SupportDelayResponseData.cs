// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportDelayResponseData : UnityHashBase // TypeDefIndex: 13203
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x1C
	[CompilerGenerated]
	private SupportResultData <SupportResultData>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 40, IsOptional = True)]
	public byte SkillLv { get; set; }
	[UnityHash(Code = 41, IsOptional = True)]
	public SupportResultData SupportResultData { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36C85D0 Offset: 0x36C45D0 VA: 0x36C85D0
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C85D8 Offset: 0x36C45D8 VA: 0x36C85D8
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C85E0 Offset: 0x36C45E0 VA: 0x36C85E0
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x36C85E8 Offset: 0x36C45E8 VA: 0x36C85E8
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C85F0 Offset: 0x36C45F0 VA: 0x36C85F0
	public SupportResultData get_SupportResultData() { }

	[CompilerGenerated]
	// RVA: 0x36C85F8 Offset: 0x36C45F8 VA: 0x36C85F8
	public void set_SupportResultData(SupportResultData value) { }

	// RVA: 0x36C8600 Offset: 0x36C4600 VA: 0x36C8600 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C8608 Offset: 0x36C4608 VA: 0x36C8608
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36C8610 Offset: 0x36C4610 VA: 0x36C8610 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C87AC Offset: 0x36C47AC VA: 0x36C87AC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
