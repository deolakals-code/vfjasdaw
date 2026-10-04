// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class NemesisBuf : CountBufferBase // TypeDefIndex: 3257
{
	// Fields
	private GameObject target; // 0x28
	private PlayerActionManagerBase playerAction; // 0x30
	private EnemyMobActionManagerBase mobAction; // 0x38
	private bool activeStack; // 0x40
	private float range; // 0x44
	private NemesisBuf.NemesisLineEffect lineEffect; // 0x48
	private List<int> playerAttackIdList; // 0x50

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x233EDDC Offset: 0x233ADDC VA: 0x233EDDC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233EDE4 Offset: 0x233ADE4 VA: 0x233EDE4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233EDEC Offset: 0x233ADEC VA: 0x233EDEC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x233EE04 Offset: 0x233AE04 VA: 0x233EE04 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x233EE10 Offset: 0x233AE10 VA: 0x233EE10
	public void .ctor(byte lv, GameObject target, PlayerActionManagerBase player) { }

	// RVA: 0x233EF9C Offset: 0x233AF9C VA: 0x233EF9C Slot: 11
	public override void Updata() { }

	// RVA: 0x233F1A0 Offset: 0x233B1A0 VA: 0x233F1A0 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233F1C8 Offset: 0x233B1C8 VA: 0x233F1C8
	public bool CheckPlayerAttackDamaged(GameObject target, int attackId) { }

	// RVA: 0x233F284 Offset: 0x233B284 VA: 0x233F284
	public bool PlayerAttackDamaged(int attackId) { }

	// RVA: 0x233F33C Offset: 0x233B33C VA: 0x233F33C
	public bool MobAttackDamaged(GameObject mob, SkillDamageData damageData) { }

	// RVA: 0x233F3EC Offset: 0x233B3EC VA: 0x233F3EC
	public void CountReset() { }

	// RVA: 0x233F3F4 Offset: 0x233B3F4 VA: 0x233F3F4 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x233F51C Offset: 0x233B51C VA: 0x233F51C Slot: 15
	public override void OnCall(int takeUid, int param) { }

	// RVA: 0x233F9B8 Offset: 0x233B9B8 VA: 0x233F9B8
	public void ChangeHyperMode(GameObject target) { }

	// RVA: 0x233F058 Offset: 0x233B058 VA: 0x233F058
	private bool CheckBufferLineConnect() { }

	// RVA: 0x233F124 Offset: 0x233B124 VA: 0x233F124
	public void CutBufferLine() { }

	// RVA: 0x233FAFC Offset: 0x233BAFC VA: 0x233FAFC
	public void Sync(int count) { }
}
