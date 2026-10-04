// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BattleNotes : SkillMasteryBase // TypeDefIndex: 3401
{
	// Fields
	private static readonly float AttackCycle; // 0x0
	private long beforeAttackTime; // 0x18
	private float nextAttackDelay; // 0x20

	// Methods

	// RVA: 0x2357B54 Offset: 0x2353B54 VA: 0x2357B54
	public void .ctor(SkillData skillData) { }

	// RVA: 0x2357B84 Offset: 0x2353B84 VA: 0x2357B84 Slot: 4
	public override int GetMasteryParam(MasteryId id) { }

	// RVA: 0x2357BB8 Offset: 0x2353BB8 VA: 0x2357BB8
	public void Attacked(long time, float nextAttackDelay) { }

	// RVA: 0x2357BCC Offset: 0x2353BCC VA: 0x2357BCC
	public static bool CheckAttack(PlayerActionManagerBase actionManager) { }

	// RVA: 0x2357F54 Offset: 0x2353F54 VA: 0x2357F54
	private static void .cctor() { }
}
