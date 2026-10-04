// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobManager : BlackKnightMobManagerBase // TypeDefIndex: 4195
{
	// Fields
	private bool isInitialize; // 0x138
	private int hp; // 0x13C
	private float targetMovePoint; // 0x140
	private int targetMoveMotionId; // 0x144
	private int targetMoveFlag; // 0x148
	private bool isShiftCameraDir; // 0x14C
	private float shiftDistance; // 0x150
	private float playerMoveDist; // 0x154

	// Properties
	public override BlackKnightCharacterManagerBase.CharacterType CharaType { get; }
	protected override bool IsBoss { get; }
	public override int Hp { get; }

	// Methods

	// RVA: 0x24A6368 Offset: 0x24A2368 VA: 0x24A6368 Slot: 5
	public override BlackKnightCharacterManagerBase.CharacterType get_CharaType() { }

	// RVA: 0x24A6370 Offset: 0x24A2370 VA: 0x24A6370 Slot: 27
	protected override bool get_IsBoss() { }

	// RVA: 0x24A6378 Offset: 0x24A2378 VA: 0x24A6378 Slot: 28
	public override int get_Hp() { }

	// RVA: 0x24A6380 Offset: 0x24A2380 VA: 0x24A6380
	public void .ctor(BlackKnightPlayerManager player, MobStatusMaster master, int localId, bool outOfRails, bool camerasideShift, float sideDist) { }

	[IteratorStateMachine(typeof(BlackKnightMobManager.<Remove>d__15))]
	// RVA: 0x24A63C8 Offset: 0x24A23C8 VA: 0x24A63C8
	public IEnumerator Remove() { }

	// RVA: 0x24A645C Offset: 0x24A245C VA: 0x24A645C Slot: 34
	public override void OnActionEnd(BlackKnightMobSkillBase skillBase) { }

	// RVA: 0x24A64B0 Offset: 0x24A24B0 VA: 0x24A64B0 Slot: 9
	public override void Update() { }

	// RVA: 0x24A69AC Offset: 0x24A29AC VA: 0x24A69AC Slot: 10
	public override void MoveUpdate() { }

	// RVA: 0x24A6AC0 Offset: 0x24A2AC0 VA: 0x24A6AC0 Slot: 8
	public override void Initialize(GameObject modelObj, GuideRail guide, float posData, bool isRight, float height) { }

	// RVA: 0x24A6DDC Offset: 0x24A2DDC VA: 0x24A6DDC Slot: 26
	protected override void OnDicpose() { }

	// RVA: 0x24A6EE4 Offset: 0x24A2EE4 VA: 0x24A6EE4 Slot: 20
	public override void OnDamaged(SkillDamageData damageData) { }

	// RVA: 0x24A6FE8 Offset: 0x24A2FE8 VA: 0x24A6FE8 Slot: 21
	public override void OnDead() { }

	// RVA: 0x24A7094 Offset: 0x24A3094 VA: 0x24A7094 Slot: 25
	public override void OnActionHit(BlackKnightSkillActionBase action) { }

	// RVA: 0x24A70C8 Offset: 0x24A30C8 VA: 0x24A70C8 Slot: 31
	public override void EnterBossRoomStart() { }

	// RVA: 0x24A70D0 Offset: 0x24A30D0 VA: 0x24A70D0 Slot: 33
	public override void StopAction() { }

	// RVA: 0x24A677C Offset: 0x24A277C VA: 0x24A677C
	private void UpdateTargetMovePoint() { }

	// RVA: 0x24A65B0 Offset: 0x24A25B0 VA: 0x24A65B0
	private void UpdateTargetPointMove3D() { }

	// RVA: 0x24A68A0 Offset: 0x24A28A0 VA: 0x24A68A0
	private void UpdatePlayerMove() { }

	// RVA: 0x24A70E8 Offset: 0x24A30E8 VA: 0x24A70E8 Slot: 35
	protected override void OnEventSkill(int commandId) { }

	// RVA: 0x24A7220 Offset: 0x24A3220 VA: 0x24A7220 Slot: 36
	protected override void OnEventTargetMove() { }

	// RVA: 0x24A72B4 Offset: 0x24A32B4 VA: 0x24A72B4 Slot: 37
	protected override void OnEventPointMove(float movePoint, int moveMotionId, int flag) { }

	// RVA: 0x24A72BC Offset: 0x24A32BC VA: 0x24A72BC Slot: 38
	protected override void OnEventRotate(int rotateState) { }

	// RVA: 0x24A7574 Offset: 0x24A3574 VA: 0x24A7574 Slot: 39
	protected override void OnEvent3DPointMove(float movePoint) { }

	// RVA: 0x24A7740 Offset: 0x24A3740 VA: 0x24A7740 Slot: 40
	protected override void OnEventPlayerMove(float dist) { }

	[CompilerGenerated]
	// RVA: 0x24A7748 Offset: 0x24A3748 VA: 0x24A7748
	private void <Remove>b__15_0() { }

	[CompilerGenerated]
	// RVA: 0x24A77A4 Offset: 0x24A37A4 VA: 0x24A77A4
	private void <OnDicpose>b__20_0() { }

	[CompilerGenerated]
	// RVA: 0x24A7800 Offset: 0x24A3800 VA: 0x24A7800
	private void <OnDead>b__22_0() { }
}
