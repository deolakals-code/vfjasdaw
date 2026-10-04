// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BattleLogBase // TypeDefIndex: 315
{
	// Methods

	// RVA: 0x2389F08 Offset: 0x2385F08 VA: 0x2389F08 Slot: 4
	public virtual string AddAttackLog(string damage) { }

	// RVA: 0x2389F54 Offset: 0x2385F54 VA: 0x2389F54 Slot: 5
	public virtual string AddPetAttackLog(string name, string damage) { }

	// RVA: 0x2389FB0 Offset: 0x2385FB0 VA: 0x2389FB0 Slot: 6
	public virtual string AddComboReflectionAttackLog(string damage) { }

	// RVA: 0x2389FFC Offset: 0x2385FFC VA: 0x2389FFC Slot: 7
	public virtual string AddSkillAttackLog(string name, string damage) { }

	// RVA: 0x238A058 Offset: 0x2386058 VA: 0x238A058 Slot: 8
	public virtual string AddPetSkillAttackLog(string name, string skillName, string damage) { }

	// RVA: 0x238A0BC Offset: 0x23860BC VA: 0x238A0BC Slot: 9
	public virtual string AddMissAttackLog() { }

	// RVA: 0x238A0FC Offset: 0x23860FC VA: 0x238A0FC Slot: 10
	public virtual string AddRateDamageLog(string damage) { }

	// RVA: 0x238A148 Offset: 0x2386148 VA: 0x238A148 Slot: 11
	public virtual string AddFatalDamageLog(string damage) { }

	// RVA: 0x238A194 Offset: 0x2386194 VA: 0x238A194 Slot: 12
	public virtual string AddMagicDamageLog(string damage) { }

	// RVA: 0x238A1E0 Offset: 0x23861E0 VA: 0x238A1E0 Slot: 13
	public virtual string AddPhysicsDamageLog(string damage) { }

	// RVA: 0x238A22C Offset: 0x238622C VA: 0x238A22C Slot: 14
	public virtual string AddBarrierDamageLog(string damage) { }

	// RVA: 0x238A278 Offset: 0x2386278 VA: 0x238A278 Slot: 15
	public virtual string AddReflectionDamageLog(string damage) { }

	// RVA: 0x238A2C4 Offset: 0x23862C4 VA: 0x238A2C4 Slot: 16
	public virtual string AddPhysicalPursuitAttackLog(string damage) { }

	// RVA: 0x238A310 Offset: 0x2386310 VA: 0x238A310 Slot: 17
	public virtual string AddMagicPursuitAttackLog(string damage) { }

	// RVA: 0x238A35C Offset: 0x238635C VA: 0x238A35C Slot: 18
	public virtual string AddDeadlyPoisonAttackLog(string damage) { }

	// RVA: 0x238A3A8 Offset: 0x23863A8 VA: 0x238A3A8 Slot: 19
	public virtual string AddCircleBufLog(string name, string skill) { }

	// RVA: 0x238A404 Offset: 0x2386404 VA: 0x238A404 Slot: 20
	public virtual string RemoveCircleBufLog(string name, string skill) { }

	// RVA: 0x238A460 Offset: 0x2386460 VA: 0x238A460 Slot: 21
	public virtual string AddMagicalExplosionDamage(string damage) { }

	// RVA: 0x238A4AC Offset: 0x23864AC VA: 0x238A4AC Slot: 22
	public virtual string AddChronosShiftDamage(string damage) { }

	// RVA: 0x238A4F8 Offset: 0x23864F8 VA: 0x238A4F8 Slot: 23
	public virtual string FamiliaEscape() { }

	// RVA: 0x238A5A0 Offset: 0x23865A0 VA: 0x238A5A0 Slot: 24
	public virtual string SummonDemonicKillPlayer() { }

	// RVA: 0x238A648 Offset: 0x2386648 VA: 0x238A648 Slot: 25
	public virtual string AddSkillDamageLog(string skillName, string damage) { }

	// RVA: 0x238A6A4 Offset: 0x23866A4 VA: 0x238A6A4
	public void .ctor() { }
}
