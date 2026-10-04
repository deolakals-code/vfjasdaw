// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HealQigongBuf : CountBufferBase // TypeDefIndex: 3190
{
	// Fields
	[CompilerGenerated]
	private bool <IsCutDamage>k__BackingField; // 0x28
	private readonly PlayerStatusBase status; // 0x30
	private int percent; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override int BufEffectTakeId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public bool IsCutDamage { get; set; }

	// Methods

	// RVA: 0x23328C8 Offset: 0x232E8C8 VA: 0x23328C8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23328D0 Offset: 0x232E8D0 VA: 0x23328D0 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x23328DC Offset: 0x232E8DC VA: 0x23328DC Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23328E4 Offset: 0x232E8E4 VA: 0x23328E4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x23328FC Offset: 0x232E8FC VA: 0x23328FC
	public bool get_IsCutDamage() { }

	[CompilerGenerated]
	// RVA: 0x2332904 Offset: 0x232E904 VA: 0x2332904
	private void set_IsCutDamage(bool value) { }

	// RVA: 0x2332910 Offset: 0x232E910 VA: 0x2332910
	public void .ctor(byte lv, int useNum, PlayerStatusBase status) { }

	// RVA: 0x2332A04 Offset: 0x232EA04 VA: 0x2332A04 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2332AB4 Offset: 0x232EAB4 VA: 0x2332AB4 Slot: 11
	public override void Updata() { }

	// RVA: 0x2332B08 Offset: 0x232EB08 VA: 0x2332B08
	public bool CheckCutDamageByQigong() { }

	// RVA: 0x2332BE8 Offset: 0x232EBE8 VA: 0x2332BE8
	public void ApplyDamageCut() { }

	// RVA: 0x2332BF4 Offset: 0x232EBF4 VA: 0x2332BF4 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x2332D08 Offset: 0x232ED08 VA: 0x2332D08
	public void DamageFunction(GameObject target, PlayerActionManagerBase actorActionManager, SkillDamageData damageData) { }

	// RVA: 0x2332EF0 Offset: 0x232EEF0 VA: 0x2332EF0
	private bool CheckCollisionOfFightingSpirit(GameObject target, PlayerActionManagerBase actorActionManager) { }
}
