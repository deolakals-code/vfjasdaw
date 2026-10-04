// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMagicLancer : BlackKnightPlayerSkillBase // TypeDefIndex: 4239
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x90
	private BlackKnightMobManagerBase targetManager; // 0x98
	private int hitNum; // 0xA0
	private List<int> lancerTakeUidList; // 0xA8
	private bool isAbnormalEffect; // 0xB0
	private readonly float targetRange; // 0xB4
	private float length; // 0xB8
	private readonly float highLancerOffset; // 0xBC

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public float Length { get; }

	// Methods

	// RVA: 0x24B2288 Offset: 0x24AE288 VA: 0x24B2288 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B2290 Offset: 0x24AE290 VA: 0x24B2290 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B2298 Offset: 0x24AE298 VA: 0x24B2298 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B22A0 Offset: 0x24AE2A0 VA: 0x24B22A0 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B22A8 Offset: 0x24AE2A8 VA: 0x24B22A8 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B22B0 Offset: 0x24AE2B0 VA: 0x24B22B0
	public float get_Length() { }

	// RVA: 0x24B22B8 Offset: 0x24AE2B8 VA: 0x24B22B8 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B2390 Offset: 0x24AE390 VA: 0x24B2390 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B279C Offset: 0x24AE79C VA: 0x24B279C Slot: 29
	public override GameObject GetTarget(BlackKnightMobObjectManager mobObjManager) { }

	// RVA: 0x24B2924 Offset: 0x24AE924 VA: 0x24B2924 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B294C Offset: 0x24AE94C VA: 0x24B294C Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24B2AF0 Offset: 0x24AEAF0 VA: 0x24B2AF0
	public void SetHitLancerTakeUid(int uid) { }

	// RVA: 0x24B2B94 Offset: 0x24AEB94 VA: 0x24B2B94
	public int GetHitLancerTakeId() { }

	// RVA: 0x24AF5A8 Offset: 0x24AB5A8 VA: 0x24AF5A8
	public void .ctor() { }
}
