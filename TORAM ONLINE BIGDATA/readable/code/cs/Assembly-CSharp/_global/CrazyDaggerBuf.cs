// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CrazyDaggerBuf : CountBufferBase // TypeDefIndex: 3115
{
	// Fields
	private static float actionRange; // 0x0
	private CrazyDaggerBuf.EffectManager effectManager; // 0x28
	private PlayerActionManagerBase playerAction; // 0x30
	private bool isOther; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23236B4 Offset: 0x231F6B4 VA: 0x23236B4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23236BC Offset: 0x231F6BC VA: 0x23236BC Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23236C4 Offset: 0x231F6C4 VA: 0x23236C4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23236CC Offset: 0x231F6CC VA: 0x23236CC
	public void .ctor(byte lv, PlayerActionManagerBase playerAction, bool other = False) { }

	// RVA: 0x2323994 Offset: 0x231F994 VA: 0x2323994 Slot: 11
	public override void Updata() { }

	// RVA: 0x23239D0 Offset: 0x231F9D0 VA: 0x23239D0 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23239F0 Offset: 0x231F9F0 VA: 0x23239F0 Slot: 23
	public override void Next() { }

	// RVA: 0x2323A14 Offset: 0x231FA14 VA: 0x2323A14
	public void SetCount(int count) { }

	// RVA: 0x2323B18 Offset: 0x231FB18 VA: 0x2323B18
	public void AttackStart(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x232404C Offset: 0x232004C VA: 0x232404C
	public void OtherAttackStart(MobActionManagerBase mobAction) { }

	// RVA: 0x2324238 Offset: 0x2320238 VA: 0x2324238
	public void SkillStart(int motionSpeed) { }

	// RVA: 0x23243FC Offset: 0x23203FC VA: 0x23243FC
	public void SkillAttack(List<MobActionManagerBase> targetList) { }

	// RVA: 0x2324618 Offset: 0x2320618 VA: 0x2324618
	public void SkillAttackOther(MobActionManagerBase target) { }

	// RVA: 0x232478C Offset: 0x232078C VA: 0x232478C
	public void SkillEnd() { }

	// RVA: 0x23248F0 Offset: 0x23208F0 VA: 0x23248F0
	public void SkillGuard(GameObject target) { }

	// RVA: 0x2324CD8 Offset: 0x2320CD8 VA: 0x2324CD8
	public void VanishingObject(GameObject actor) { }

	// RVA: 0x2324E10 Offset: 0x2320E10 VA: 0x2324E10 Slot: 17
	public override void OnLeave() { }

	// RVA: 0x2324E2C Offset: 0x2320E2C VA: 0x2324E2C
	public void ClearEffect() { }

	// RVA: 0x2324E78 Offset: 0x2320E78 VA: 0x2324E78
	public static void Damaged(PlayerActionManagerBase playerAction, AbnormalType type) { }

	// RVA: 0x2324F74 Offset: 0x2320F74 VA: 0x2324F74
	private static void .cctor() { }
}
