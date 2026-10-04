// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SkillMasteryBase // TypeDefIndex: 3503
{
	// Fields
	protected readonly SkillData skillData; // 0x10

	// Properties
	public SkillData SkillData { get; }

	// Methods

	// RVA: 0x235F614 Offset: 0x235B614 VA: 0x235F614
	public SkillData get_SkillData() { }

	// RVA: 0x2356850 Offset: 0x2352850 VA: 0x2356850
	protected void .ctor(SkillData data) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetMasteryParam(MasteryId id);
}
