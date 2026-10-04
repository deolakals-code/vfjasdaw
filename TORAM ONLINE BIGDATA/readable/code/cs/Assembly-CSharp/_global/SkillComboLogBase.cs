// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillComboLogBase // TypeDefIndex: 323
{
	// Fields
	protected int comboNum; // 0x10
	protected bool CompleteStart; // 0x14
	protected Dictionary<SkillId, SkillComboLogBase.LogData> log; // 0x18
	protected SkillComboState currentCombo; // 0x20

	// Methods

	// RVA: 0x247C8DC Offset: 0x24788DC VA: 0x247C8DC
	public bool DrawChatLog(SkillId skillId) { }

	// RVA: 0x247CB48 Offset: 0x2478B48 VA: 0x247CB48
	public void Start(int Num, SkillComboState state) { }

	// RVA: 0x247CBF8 Offset: 0x2478BF8 VA: 0x247CBF8 Slot: 4
	public virtual void NoneComboLog() { }

	// RVA: 0x247CBFC Offset: 0x2478BFC VA: 0x247CBFC Slot: 5
	public virtual void StartComboLog() { }

	// RVA: 0x247CC00 Offset: 0x2478C00 VA: 0x247CC00 Slot: 6
	public virtual void RengekiComboLog(int mp, int power) { }

	// RVA: 0x247CC04 Offset: 0x2478C04 VA: 0x247CC04 Slot: 7
	public virtual void ThirdEyeComboLog(bool result) { }

	// RVA: 0x247CC08 Offset: 0x2478C08 VA: 0x247CC08 Slot: 8
	public virtual void FillingComboLog(int mp, int rate) { }

	// RVA: 0x247CC0C Offset: 0x2478C0C VA: 0x247CC0C Slot: 9
	public virtual void FillingEffectComboLog(int rate, int cost) { }

	// RVA: 0x247CC10 Offset: 0x2478C10 VA: 0x247CC10 Slot: 10
	public virtual void QuickComboLog() { }

	// RVA: 0x247CC14 Offset: 0x2478C14 VA: 0x247CC14 Slot: 11
	public virtual void HardHitComboLog(bool last) { }

	// RVA: 0x247CC18 Offset: 0x2478C18 VA: 0x247CC18 Slot: 12
	public virtual void HardHitEffectComboLog() { }

	// RVA: 0x247CC1C Offset: 0x2478C1C VA: 0x247CC1C Slot: 13
	public virtual void HardHitComboFailure() { }

	// RVA: 0x247CC20 Offset: 0x2478C20 VA: 0x247CC20 Slot: 14
	public virtual void TenacityComboLog(int hp) { }

	// RVA: 0x247CC24 Offset: 0x2478C24 VA: 0x247CC24 Slot: 15
	public virtual void TenacityEnoughComboLog() { }

	// RVA: 0x247CC28 Offset: 0x2478C28 VA: 0x247CC28 Slot: 16
	public virtual void InvincibleComboLog(int rate, bool result) { }

	// RVA: 0x247CC2C Offset: 0x2478C2C VA: 0x247CC2C Slot: 17
	public virtual void NotHpCost() { }

	// RVA: 0x247CC30 Offset: 0x2478C30 VA: 0x247CC30 Slot: 18
	public virtual void NotMpCost() { }

	// RVA: 0x247CC34 Offset: 0x2478C34 VA: 0x247CC34 Slot: 19
	public virtual void ReflectionComboLog() { }

	// RVA: 0x247CC38 Offset: 0x2478C38 VA: 0x247CC38 Slot: 20
	public virtual void BloodSuckingHeal(int skillId, int comboIndex, int heal) { }

	// RVA: 0x247CC3C Offset: 0x2478C3C VA: 0x247CC3C Slot: 21
	public virtual void BloodyAttack(int payHp, int rate) { }

	// RVA: 0x247CC40 Offset: 0x2478C40 VA: 0x247CC40 Slot: 22
	public virtual void BloodyLastAttack(int rate) { }

	// RVA: 0x247CC44 Offset: 0x2478C44 VA: 0x247CC44 Slot: 23
	public virtual void ToughComboLog() { }

	// RVA: 0x247CC48 Offset: 0x2478C48 VA: 0x247CC48 Slot: 24
	public virtual void ToughEffectComboLog() { }

	// RVA: 0x247CC4C Offset: 0x2478C4C VA: 0x247CC4C Slot: 25
	public virtual void DuplicationError() { }

	// RVA: 0x247CC50 Offset: 0x2478C50 VA: 0x247CC50
	public void UseSkill(int index) { }

	// RVA: 0x247CB88 Offset: 0x2478B88 VA: 0x247CB88
	public void End() { }

	// RVA: 0x247CC5C Offset: 0x2478C5C VA: 0x247CC5C
	protected void AddMessage(SkillComboLogBase.ComboLogType key, string data) { }

	// RVA: 0x247CCA0 Offset: 0x2478CA0 VA: 0x247CCA0
	protected void AddMessage(SkillId skillId, SkillComboLogBase.ComboLogType key, string data) { }

	// RVA: 0x247CE48 Offset: 0x2478E48 VA: 0x247CE48
	public void .ctor() { }
}
