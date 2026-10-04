// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public abstract class MobSkillDataBase : ISkillParameter, ISkillController // TypeDefIndex: 9117
{
	// Fields
	private MobSkillId skillId; // 0x10
	private MobSkillType skillType; // 0x14
	private int effectiveValue; // 0x18

	// Properties
	public virtual MobSkillId SkillId { get; }
	public virtual MobSkillType SkillType { get; }
	public virtual int EffectiveValue { get; }
	public virtual ISkillParameter Parameter { get; }

	// Methods

	// RVA: 0x1EAE3A8 Offset: 0x1EAA3A8 VA: 0x1EAE3A8 Slot: 9
	public virtual MobSkillId get_SkillId() { }

	// RVA: 0x1EAE3B0 Offset: 0x1EAA3B0 VA: 0x1EAE3B0 Slot: 10
	public virtual MobSkillType get_SkillType() { }

	// RVA: 0x1EAE3B8 Offset: 0x1EAA3B8 VA: 0x1EAE3B8 Slot: 11
	public virtual int get_EffectiveValue() { }

	// RVA: 0x1EAE3C0 Offset: 0x1EAA3C0 VA: 0x1EAE3C0 Slot: 12
	public virtual ISkillParameter get_Parameter() { }

	// RVA: 0x1EAE3C4 Offset: 0x1EAA3C4 VA: 0x1EAE3C4
	public void .ctor(SkillParameter param) { }

	// RVA: 0x1EAE400 Offset: 0x1EAA400 VA: 0x1EAE400 Slot: 8
	public void AddPrevActions() { }

	// RVA: 0x1EAE404 Offset: 0x1EAA404 VA: 0x1EAE404
	public void AddAfterActions() { }
}
