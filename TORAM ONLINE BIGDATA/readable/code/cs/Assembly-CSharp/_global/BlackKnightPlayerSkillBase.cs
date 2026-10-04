// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightPlayerSkillBase : BlackKnightSkillActionBase // TypeDefIndex: 4223
{
	// Fields
	private GameObject skillPosition; // 0x50
	[CompilerGenerated]
	private bool <IsFailure>k__BackingField; // 0x58
	[CompilerGenerated]
	private SkillLinkedTake <CurrentTake>k__BackingField; // 0x60
	[CompilerGenerated]
	private Dictionary<TakeParameterType, int> <HitTakeAppendParam>k__BackingField; // 0x68
	protected float size; // 0x70
	protected int shotTakeId; // 0x74
	private bool isEndFirstHitCheck; // 0x78
	protected Dictionary<int, List<BlackKnightSkillActionBase.TargetData>> hitTargetData; // 0x80
	protected List<BlackKnightSkillActionBase.TargetData> hitData; // 0x88

	// Properties
	public abstract bool IsUseMp { get; }
	public GameObject SkillPosition { get; set; }
	public virtual bool IsFailure { get; set; }
	public SkillLinkedTake CurrentTake { get; set; }
	public SkillLinkedTake CurrentEventTake { get; }
	public Dictionary<TakeParameterType, int> HitTakeAppendParam { get; set; }
	public float Size { get; }
	public int ShotTakeId { get; }
	public virtual bool IsPermitInputMove { get; }
	public virtual bool IsPermitJump { get; }
	public virtual bool IsPermitDash { get; }
	public Dictionary<int, List<BlackKnightSkillActionBase.TargetData>> HitTargetData { get; }
	public List<BlackKnightSkillActionBase.TargetData> HitData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool get_IsUseMp();

	// RVA: 0x24ADF64 Offset: 0x24A9F64 VA: 0x24ADF64
	public GameObject get_SkillPosition() { }

	// RVA: 0x24ADF6C Offset: 0x24A9F6C VA: 0x24ADF6C
	protected void set_SkillPosition(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x24AE044 Offset: 0x24AA044 VA: 0x24AE044 Slot: 24
	public virtual bool get_IsFailure() { }

	[CompilerGenerated]
	// RVA: 0x24AE04C Offset: 0x24AA04C VA: 0x24AE04C Slot: 25
	protected virtual void set_IsFailure(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24AE058 Offset: 0x24AA058 VA: 0x24AE058
	public SkillLinkedTake get_CurrentTake() { }

	[CompilerGenerated]
	// RVA: 0x24AE060 Offset: 0x24AA060 VA: 0x24AE060
	public void set_CurrentTake(SkillLinkedTake value) { }

	// RVA: 0x24AE068 Offset: 0x24AA068 VA: 0x24AE068
	public SkillLinkedTake get_CurrentEventTake() { }

	[CompilerGenerated]
	// RVA: 0x24AE080 Offset: 0x24AA080 VA: 0x24AE080
	public Dictionary<TakeParameterType, int> get_HitTakeAppendParam() { }

	[CompilerGenerated]
	// RVA: 0x24AE088 Offset: 0x24AA088 VA: 0x24AE088
	private void set_HitTakeAppendParam(Dictionary<TakeParameterType, int> value) { }

	// RVA: 0x24AE090 Offset: 0x24AA090 VA: 0x24AE090
	public float get_Size() { }

	// RVA: 0x24AE098 Offset: 0x24AA098 VA: 0x24AE098
	public int get_ShotTakeId() { }

	// RVA: 0x24AE0A0 Offset: 0x24AA0A0 VA: 0x24AE0A0 Slot: 26
	public virtual bool get_IsPermitInputMove() { }

	// RVA: 0x24AE0A8 Offset: 0x24AA0A8 VA: 0x24AE0A8 Slot: 27
	public virtual bool get_IsPermitJump() { }

	// RVA: 0x24AE0B0 Offset: 0x24AA0B0 VA: 0x24AE0B0 Slot: 28
	public virtual bool get_IsPermitDash() { }

	// RVA: 0x24AE0B8 Offset: 0x24AA0B8 VA: 0x24AE0B8
	public Dictionary<int, List<BlackKnightSkillActionBase.TargetData>> get_HitTargetData() { }

	// RVA: 0x24AE0C0 Offset: 0x24AA0C0 VA: 0x24AE0C0
	public List<BlackKnightSkillActionBase.TargetData> get_HitData() { }

	// RVA: 0x24AE0C8 Offset: 0x24AA0C8 VA: 0x24AE0C8
	public void AddHitTakeAppendParam(TakeParameterType type, int param) { }

	// RVA: 0x24AE184 Offset: 0x24AA184 VA: 0x24AE184
	protected void .ctor() { }

	// RVA: 0x24AE270 Offset: 0x24AA270 VA: 0x24AE270 Slot: 17
	protected override void OnEnd() { }

	// RVA: 0x24AE33C Offset: 0x24AA33C VA: 0x24AE33C Slot: 29
	public virtual GameObject GetTarget(BlackKnightMobObjectManager mobObjManager) { }

	// RVA: 0x24AE344 Offset: 0x24AA344 VA: 0x24AE344
	public void UpdateHitArea() { }

	// RVA: 0x24AE648 Offset: 0x24AA648 VA: 0x24AE648
	public bool NextTake() { }

	// RVA: 0x24AE684 Offset: 0x24AA684 VA: 0x24AE684 Slot: 30
	public virtual int CalcCostMp() { }

	// RVA: 0x24AE68C Offset: 0x24AA68C VA: 0x24AE68C Slot: 21
	protected override BlackKnightSkillActionBase.DamageData templateToDamageData(BlackKnightSkillActionBase.DamageData damageData, BlackKnightCharacterManagerBase charaMng, int damage, bool isCritical) { }

	// RVA: 0x24AE7E8 Offset: 0x24AA7E8 VA: 0x24AE7E8
	public void EndHitCheck() { }

	// RVA: 0x24AE80C Offset: 0x24AA80C VA: 0x24AE80C Slot: 31
	protected virtual void OnEndFirstHitCheck() { }

	// RVA: 0x24AE810 Offset: 0x24AA810 VA: 0x24AE810 Slot: 22
	public override void NextRangeHit() { }

	// RVA: 0x24AE8F8 Offset: 0x24AA8F8 VA: 0x24AE8F8
	public void AddHitTarget(BlackKnightCharacterManagerBase target, int localId) { }

	// RVA: 0x24AEB54 Offset: 0x24AAB54 VA: 0x24AEB54
	public bool ContainsHitTarget(BlackKnightCharacterManagerBase target, int localId) { }
}
