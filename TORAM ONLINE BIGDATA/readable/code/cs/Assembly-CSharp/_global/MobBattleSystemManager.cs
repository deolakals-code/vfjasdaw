// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobBattleSystemManager : MonoBehaviour // TypeDefIndex: 733
{
	// Fields
	private Transform charaTransform; // 0x20
	private EnemyMobActionManagerBase actionManager; // 0x28
	private MobBattleAI battleAi; // 0x30
	private MobBattleManager battleManager; // 0x38
	private MobBattlePlayer battlePlayer; // 0x40
	private bool isWaitActionEnd; // 0x48

	// Properties
	public bool IsWaitActionEnd { get; }
	public bool IsDelay { get; }
	public MobActionPattern CurrenctPatternPlayer { get; }
	public MobActionPattern CurrenctPatternManager { get; }
	public MobSkillActionManager MobSkillActionManager { get; }
	public MobSkillActionPlayer MobSkillActionPlayer { get; }

	// Methods

	// RVA: 0x1B9805C Offset: 0x1B9405C VA: 0x1B9805C
	public bool get_IsWaitActionEnd() { }

	// RVA: 0x1B8DCB8 Offset: 0x1B89CB8 VA: 0x1B8DCB8
	public bool get_IsDelay() { }

	// RVA: 0x1B8EB8C Offset: 0x1B8AB8C VA: 0x1B8EB8C
	public MobActionPattern get_CurrenctPatternPlayer() { }

	// RVA: 0x1B98080 Offset: 0x1B94080 VA: 0x1B98080
	public MobActionPattern get_CurrenctPatternManager() { }

	// RVA: 0x1B9813C Offset: 0x1B9413C VA: 0x1B9813C
	public MobSkillActionManager get_MobSkillActionManager() { }

	// RVA: 0x1B98064 Offset: 0x1B94064 VA: 0x1B98064
	public MobSkillActionPlayer get_MobSkillActionPlayer() { }

	// RVA: 0x1B98158 Offset: 0x1B94158 VA: 0x1B98158
	private void Awake() { }

	// RVA: 0x1B9826C Offset: 0x1B9426C VA: 0x1B9826C
	public void SetMobBattleAi(MobBattleAI ai) { }

	// RVA: 0x1B982E8 Offset: 0x1B942E8 VA: 0x1B982E8
	public void BattleActive() { }

	// RVA: 0x1B98304 Offset: 0x1B94304 VA: 0x1B98304
	public void BattleStop() { }

	// RVA: 0x1B983BC Offset: 0x1B943BC VA: 0x1B983BC
	public void BattleEnd() { }

	// RVA: 0x1B90688 Offset: 0x1B8C688 VA: 0x1B90688
	public void ActionCancel() { }

	// RVA: 0x1B983E8 Offset: 0x1B943E8 VA: 0x1B983E8
	public void ActionCancel(short patternId) { }

	// RVA: 0x1B9854C Offset: 0x1B9454C VA: 0x1B9854C
	public void UnmanagedActionDamage() { }

	// RVA: 0x1B985C4 Offset: 0x1B945C4 VA: 0x1B985C4
	public void ChangeManaged() { }

	// RVA: 0x1B988A4 Offset: 0x1B948A4 VA: 0x1B988A4
	public void ChangeTarget() { }

	// RVA: 0x1B9310C Offset: 0x1B8F10C VA: 0x1B9310C
	public void OnActionEnd() { }

	// RVA: 0x1B9325C Offset: 0x1B8F25C VA: 0x1B9325C
	public void OnActionCancel() { }

	// RVA: 0x1B98910 Offset: 0x1B94910 VA: 0x1B98910
	public void Avoid(GameObject actor) { }

	// RVA: 0x1B98984 Offset: 0x1B94984 VA: 0x1B98984
	public void Guard(GameObject actor) { }

	// RVA: 0x1B989F8 Offset: 0x1B949F8 VA: 0x1B989F8
	public void ApparentDeath() { }

	// RVA: 0x1B98A3C Offset: 0x1B94A3C VA: 0x1B98A3C
	public void ReviveFromApparentDeath() { }

	// RVA: 0x1B98AE0 Offset: 0x1B94AE0 VA: 0x1B98AE0
	public void Dead() { }

	// RVA: 0x1B98B0C Offset: 0x1B94B0C VA: 0x1B98B0C
	public MobAttackBase GetCurrentAttack() { }

	// RVA: 0x1B8DFF8 Offset: 0x1B89FF8 VA: 0x1B8DFF8
	public MobAttackBase CreateMobAction(MobActionPattern pattern) { }

	// RVA: 0x1B98BC8 Offset: 0x1B94BC8 VA: 0x1B98BC8
	public void AbnormalActionCancel() { }

	// RVA: 0x1B98BFC Offset: 0x1B94BFC VA: 0x1B98BFC
	public void .ctor() { }
}
