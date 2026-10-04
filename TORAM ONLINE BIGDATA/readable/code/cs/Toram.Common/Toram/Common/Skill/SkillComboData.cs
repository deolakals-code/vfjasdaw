// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Skill
public class SkillComboData : UnityHashBase // TypeDefIndex: 11261
{
	// Fields
	[CompilerGenerated]
	private byte <Id>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <Enable>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short[] <SkillIds>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <Types>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ComboFinish>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 200)]
	public byte Id { get; set; }
	[UnityHash(Code = 43)]
	public bool Enable { get; set; }
	[UnityHash(Code = 90, IsOptional = True)]
	public short[] SkillIds { get; set; }
	[UnityHash(Code = 195, IsOptional = True)]
	public byte[] Types { get; set; }
	[UnityHash(Code = 245, IsOptional = True)]
	public byte ComboFinish { get; set; }

	// Methods

	// RVA: 0x36D2324 Offset: 0x36CE324 VA: 0x36D2324
	public void .ctor() { }

	// RVA: 0x36D232C Offset: 0x36CE32C VA: 0x36D232C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36D2334 Offset: 0x36CE334 VA: 0x36D2334
	public byte get_Id() { }

	[CompilerGenerated]
	// RVA: 0x36D233C Offset: 0x36CE33C VA: 0x36D233C
	public void set_Id(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D2344 Offset: 0x36CE344 VA: 0x36D2344
	public bool get_Enable() { }

	[CompilerGenerated]
	// RVA: 0x36D234C Offset: 0x36CE34C VA: 0x36D234C
	public void set_Enable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36D2358 Offset: 0x36CE358 VA: 0x36D2358
	public short[] get_SkillIds() { }

	[CompilerGenerated]
	// RVA: 0x36D2360 Offset: 0x36CE360 VA: 0x36D2360
	public void set_SkillIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36D2368 Offset: 0x36CE368 VA: 0x36D2368
	public byte[] get_Types() { }

	[CompilerGenerated]
	// RVA: 0x36D2370 Offset: 0x36CE370 VA: 0x36D2370
	public void set_Types(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36D2378 Offset: 0x36CE378 VA: 0x36D2378
	public byte get_ComboFinish() { }

	[CompilerGenerated]
	// RVA: 0x36D2380 Offset: 0x36CE380 VA: 0x36D2380
	public void set_ComboFinish(byte value) { }

	// RVA: 0x36D2388 Offset: 0x36CE388 VA: 0x36D2388 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36D276C Offset: 0x36CE76C VA: 0x36D276C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
