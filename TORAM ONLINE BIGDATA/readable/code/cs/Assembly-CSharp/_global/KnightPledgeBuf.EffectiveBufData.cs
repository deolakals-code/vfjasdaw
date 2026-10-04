// Assembly: Assembly-CSharp.dll
// Namespace: 
private class KnightPledgeBuf.EffectiveBufData // TypeDefIndex: 3221
{
	// Fields
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <IsSelf>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <SkillLocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsEffective>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <LeftTime>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x28
	private int totalReduceValue; // 0x2C
	private int effectiveNum; // 0x30
	private int lastDamageRate; // 0x34
	private int knockbackDistReduceRate; // 0x38

	// Properties
	public byte Level { get; set; }
	public int ArchetypeId { get; set; }
	public bool IsSelf { get; set; }
	public int SkillLocalId { get; set; }
	public bool IsEffective { get; set; }
	public float LeftTime { get; set; }
	public bool IsEnd { get; set; }
	public int TotalReduceValue { get; }
	public int EffectiveNum { get; }
	public int LastDamageRate { get; }
	public int KnockbackDistReduceRate { get; }

	// Methods

	// RVA: 0x233886C Offset: 0x233486C VA: 0x233886C
	public void .ctor(byte lv, int archetypeId, bool isSelf, int skillLocalId) { }

	[CompilerGenerated]
	// RVA: 0x2338A98 Offset: 0x2334A98 VA: 0x2338A98
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x2338AA0 Offset: 0x2334AA0 VA: 0x2338AA0
	private void set_Level(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2338AA8 Offset: 0x2334AA8 VA: 0x2338AA8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x2338AB0 Offset: 0x2334AB0 VA: 0x2338AB0
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2338AB8 Offset: 0x2334AB8 VA: 0x2338AB8
	public bool get_IsSelf() { }

	[CompilerGenerated]
	// RVA: 0x2338AC0 Offset: 0x2334AC0 VA: 0x2338AC0
	private void set_IsSelf(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2338ACC Offset: 0x2334ACC VA: 0x2338ACC
	public int get_SkillLocalId() { }

	[CompilerGenerated]
	// RVA: 0x2338AD4 Offset: 0x2334AD4 VA: 0x2338AD4
	private void set_SkillLocalId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2338ADC Offset: 0x2334ADC VA: 0x2338ADC
	public bool get_IsEffective() { }

	[CompilerGenerated]
	// RVA: 0x2338AE4 Offset: 0x2334AE4 VA: 0x2338AE4
	private void set_IsEffective(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2338AF0 Offset: 0x2334AF0 VA: 0x2338AF0
	public float get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x2338AF8 Offset: 0x2334AF8 VA: 0x2338AF8
	private void set_LeftTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x2338B00 Offset: 0x2334B00 VA: 0x2338B00
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x2338B08 Offset: 0x2334B08 VA: 0x2338B08
	private void set_IsEnd(bool value) { }

	// RVA: 0x2338B14 Offset: 0x2334B14 VA: 0x2338B14
	public int get_TotalReduceValue() { }

	// RVA: 0x2338B1C Offset: 0x2334B1C VA: 0x2338B1C
	public int get_EffectiveNum() { }

	// RVA: 0x2338B24 Offset: 0x2334B24 VA: 0x2338B24
	public int get_LastDamageRate() { }

	// RVA: 0x2338B2C Offset: 0x2334B2C VA: 0x2338B2C
	public int get_KnockbackDistReduceRate() { }

	// RVA: 0x2338630 Offset: 0x2334630 VA: 0x2338630
	public void Update() { }

	// RVA: 0x23388D4 Offset: 0x23348D4 VA: 0x23388D4
	public void UpdateOtherParameter(int totalReduceValue, int lastDamageRate, int knockbackDistReduceRate, int num) { }

	// RVA: 0x23389E0 Offset: 0x23349E0 VA: 0x23389E0
	public void UpdateSelfParameter(int num, int lastDamageRate, int knockbackDistReduceRate, bool inArea) { }

	// RVA: 0x2338760 Offset: 0x2334760 VA: 0x2338760
	public void ReceiveTotalReduceValue(int totalReduceValue) { }
}
