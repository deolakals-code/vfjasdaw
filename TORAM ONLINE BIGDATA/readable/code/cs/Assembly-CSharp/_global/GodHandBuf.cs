// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GodHandBuf : CountBufferBase // TypeDefIndex: 3181
{
	// Fields
	private int damageDownRate; // 0x28
	private bool isSkillEnd; // 0x2C
	private bool isCutDamage; // 0x2D
	private bool isDeathExemption; // 0x2E
	private PlayerStatusBase playerStatus; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }
	public bool IsSkillEnd { get; }
	public bool IsGodRigidBodyMastery { get; }

	// Methods

	// RVA: 0x2330918 Offset: 0x232C918 VA: 0x2330918 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2330920 Offset: 0x232C920 VA: 0x2330920 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2330928 Offset: 0x232C928 VA: 0x2330928 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2330940 Offset: 0x232C940 VA: 0x2330940 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x233094C Offset: 0x232C94C VA: 0x233094C
	public bool get_IsSkillEnd() { }

	// RVA: 0x2330954 Offset: 0x232C954 VA: 0x2330954
	public bool get_IsGodRigidBodyMastery() { }

	// RVA: 0x23309CC Offset: 0x232C9CC VA: 0x23309CC
	public void .ctor(byte lv, int stack, float time) { }

	// RVA: 0x2330A70 Offset: 0x232CA70 VA: 0x2330A70 Slot: 23
	public override void Next() { }

	// RVA: 0x2330A90 Offset: 0x232CA90 VA: 0x2330A90 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2330C04 Offset: 0x232CC04 VA: 0x2330C04 Slot: 11
	public override void Updata() { }

	// RVA: 0x2330C58 Offset: 0x232CC58 VA: 0x2330C58
	public void SkillEnd() { }

	// RVA: 0x2330C68 Offset: 0x232CC68 VA: 0x2330C68 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x2330D40 Offset: 0x232CD40 VA: 0x2330D40
	public void Initalize(PlayerStatusBase status) { }

	// RVA: 0x2330DA4 Offset: 0x232CDA4 VA: 0x2330DA4
	public void ApplyDamageCut() { }

	// RVA: 0x2330DB0 Offset: 0x232CDB0 VA: 0x2330DB0
	public void DamageFunction(SkillDamageData damageData) { }

	// RVA: 0x2330DF8 Offset: 0x232CDF8 VA: 0x2330DF8
	public bool DeathExemption() { }
}
