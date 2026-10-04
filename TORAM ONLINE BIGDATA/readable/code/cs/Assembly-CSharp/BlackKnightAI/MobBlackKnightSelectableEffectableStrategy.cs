// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public class MobBlackKnightSelectableEffectableStrategy : IBlackKnightMobStrategy // TypeDefIndex: 9125
{
	// Fields
	private int skillNum; // 0x10
	private MobActionPattern selectSkill; // 0x18

	// Properties
	public int SkillNum { get; }
	public bool IsAction { get; }
	public MobActionPattern SelectSkill { get; }

	// Methods

	// RVA: 0x1EAF7EC Offset: 0x1EAB7EC VA: 0x1EAF7EC Slot: 4
	public int get_SkillNum() { }

	// RVA: 0x1EAF7F4 Offset: 0x1EAB7F4 VA: 0x1EAF7F4 Slot: 5
	public bool get_IsAction() { }

	// RVA: 0x1EAF804 Offset: 0x1EAB804 VA: 0x1EAF804 Slot: 6
	public MobActionPattern get_SelectSkill() { }

	// RVA: 0x1EAF80C Offset: 0x1EAB80C VA: 0x1EAF80C
	public void .ctor() { }

	// RVA: 0x1EAF814 Offset: 0x1EAB814 VA: 0x1EAF814 Slot: 7
	public void ThinkStrategy() { }
}
