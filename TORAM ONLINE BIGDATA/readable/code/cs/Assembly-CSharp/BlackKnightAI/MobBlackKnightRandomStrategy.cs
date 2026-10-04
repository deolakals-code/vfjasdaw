// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public class MobBlackKnightRandomStrategy : IBlackKnightMobStrategy // TypeDefIndex: 9124
{
	// Fields
	private MobActionPattern[] mobSkills; // 0x10
	private int useSkillNum; // 0x18
	private MobActionPattern selectSkill; // 0x20

	// Properties
	public int SkillNum { get; }
	public bool IsAction { get; }
	public MobActionPattern SelectSkill { get; }

	// Methods

	// RVA: 0x1EAF778 Offset: 0x1EAB778 VA: 0x1EAF778 Slot: 4
	public int get_SkillNum() { }

	// RVA: 0x1EAF790 Offset: 0x1EAB790 VA: 0x1EAF790 Slot: 5
	public bool get_IsAction() { }

	// RVA: 0x1EAF798 Offset: 0x1EAB798 VA: 0x1EAF798 Slot: 6
	public MobActionPattern get_SelectSkill() { }

	// RVA: 0x1EAC60C Offset: 0x1EA860C VA: 0x1EAC60C
	public void .ctor(MobActionPattern[] canUseSkills) { }

	// RVA: 0x1EAF7A0 Offset: 0x1EAB7A0 VA: 0x1EAF7A0 Slot: 7
	public void ThinkStrategy() { }
}
