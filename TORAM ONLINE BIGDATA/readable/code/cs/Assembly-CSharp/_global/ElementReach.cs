// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ElementReach : SkillMasteryBase // TypeDefIndex: 3429
{
	// Methods

	// RVA: 0x23593B4 Offset: 0x23553B4 VA: 0x23593B4
	public void .ctor(SkillData skillData) { }

	// RVA: 0x23593E4 Offset: 0x23553E4 VA: 0x23593E4 Slot: 4
	public override int GetMasteryParam(MasteryId id) { }

	// RVA: 0x23593EC Offset: 0x23553EC VA: 0x23593EC
	public static bool TryGetWeaponElement(PlayerActionManagerBase playerAction, out ElementType element) { }

	// RVA: 0x23594DC Offset: 0x23554DC VA: 0x23594DC
	public static bool CheckActiveElementReach(PlayerAttackBase skill) { }

	// RVA: 0x23595EC Offset: 0x23555EC VA: 0x23595EC
	public static void EnemyDamage(PlayerActionManagerBase playerAction, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x2359840 Offset: 0x2355840 VA: 0x2359840
	public static void ActorDamaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2359B40 Offset: 0x2355B40 VA: 0x2359B40
	public static bool CheckActiveSamuraiArcherySubElement(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2359CA8 Offset: 0x2355CA8 VA: 0x2359CA8
	public static void SetSubElement(PlayerStatusBase status) { }

	// RVA: 0x2359FEC Offset: 0x2355FEC VA: 0x2359FEC
	public static void ResetShootSkill(PlayerStatusBase status) { }
}
