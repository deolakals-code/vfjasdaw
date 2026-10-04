// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightBossManager : BlackKnightMobManagerBase // TypeDefIndex: 4191
{
	// Fields
	private bool isInitialize; // 0x138
	private int hp; // 0x13C
	private float targetMovePoint; // 0x140
	private int targetMoveMotionId; // 0x144
	private int targetMoveFlag; // 0x148
	private float playerMoveDist; // 0x14C
	private float targetMoveStartDist; // 0x150
	private float moveTimer; // 0x154
	private float moveTime; // 0x158

	// Properties
	public override BlackKnightCharacterManagerBase.CharacterType CharaType { get; }
	protected override bool IsBoss { get; }
	public override int Hp { get; }
	public int MaxHp { get; }

	// Methods

	// RVA: 0x24A2FAC Offset: 0x249EFAC VA: 0x24A2FAC Slot: 5
	public override BlackKnightCharacterManagerBase.CharacterType get_CharaType() { }

	// RVA: 0x24A2FB4 Offset: 0x249EFB4 VA: 0x24A2FB4 Slot: 27
	protected override bool get_IsBoss() { }

	// RVA: 0x24A2FBC Offset: 0x249EFBC VA: 0x24A2FBC Slot: 28
	public override int get_Hp() { }

	// RVA: 0x24A2FC4 Offset: 0x249EFC4 VA: 0x24A2FC4
	public int get_MaxHp() { }

	// RVA: 0x24A2FDC Offset: 0x249EFDC VA: 0x24A2FDC
	public void .ctor(BlackKnightPlayerManager player, MobStatusMaster master, int localId) { }

	[IteratorStateMachine(typeof(BlackKnightBossManager.<Remove>d__18))]
	// RVA: 0x24A314C Offset: 0x249F14C VA: 0x24A314C
	public IEnumerator Remove() { }

	// RVA: 0x24A31E0 Offset: 0x249F1E0 VA: 0x24A31E0 Slot: 34
	public override void OnActionEnd(BlackKnightMobSkillBase skillBase) { }

	// RVA: 0x24A3234 Offset: 0x249F234 VA: 0x24A3234 Slot: 9
	public override void Update() { }

	// RVA: 0x24A39B8 Offset: 0x249F9B8 VA: 0x24A39B8 Slot: 8
	public override void Initialize(GameObject modelObj, GuideRail guide, float posData, bool isRight, float height) { }

	// RVA: 0x24A3E08 Offset: 0x249FE08 VA: 0x24A3E08 Slot: 26
	protected override void OnDicpose() { }

	// RVA: 0x24A3FCC Offset: 0x249FFCC VA: 0x24A3FCC Slot: 20
	public override void OnDamaged(SkillDamageData damageData) { }

	// RVA: 0x24A40C4 Offset: 0x24A00C4 VA: 0x24A40C4 Slot: 21
	public override void OnDead() { }

	[IteratorStateMachine(typeof(BlackKnightBossManager.<DeadThread>d__25))]
	// RVA: 0x24A4144 Offset: 0x24A0144 VA: 0x24A4144
	private IEnumerator DeadThread() { }

	// RVA: 0x24A41D8 Offset: 0x24A01D8 VA: 0x24A41D8 Slot: 25
	public override void OnActionHit(BlackKnightSkillActionBase action) { }

	// RVA: 0x24A44BC Offset: 0x24A04BC VA: 0x24A44BC Slot: 32
	public override void EnterBossRoom() { }

	// RVA: 0x24A44D0 Offset: 0x24A04D0 VA: 0x24A44D0 Slot: 33
	public override void StopAction() { }

	// RVA: 0x24A451C Offset: 0x24A051C VA: 0x24A451C Slot: 19
	protected override void OnActionCancel() { }

	// RVA: 0x24A3690 Offset: 0x249F690 VA: 0x24A3690
	private void UpdateTargetMovePoint() { }

	// RVA: 0x24A3884 Offset: 0x249F884 VA: 0x24A3884
	private void UpdatePlayerMove() { }

	// RVA: 0x24A4890 Offset: 0x24A0890 VA: 0x24A4890 Slot: 35
	protected override void OnEventSkill(int commandId) { }

	// RVA: 0x24A4B34 Offset: 0x24A0B34 VA: 0x24A4B34 Slot: 36
	protected override void OnEventTargetMove() { }

	// RVA: 0x24A4BC8 Offset: 0x24A0BC8 VA: 0x24A4BC8 Slot: 37
	protected override void OnEventPointMove(float movePoint, int moveMotionId, int flag) { }

	// RVA: 0x24A4C14 Offset: 0x24A0C14 VA: 0x24A4C14 Slot: 38
	protected override void OnEventRotate(int rotateState) { }

	// RVA: 0x24A4ECC Offset: 0x24A0ECC VA: 0x24A4ECC Slot: 39
	protected override void OnEvent3DPointMove(float point) { }

	// RVA: 0x24A4ED0 Offset: 0x24A0ED0 VA: 0x24A4ED0 Slot: 40
	protected override void OnEventPlayerMove(float dist) { }

	[CompilerGenerated]
	// RVA: 0x24A4ED8 Offset: 0x24A0ED8 VA: 0x24A4ED8
	private void <Remove>b__18_0() { }

	[CompilerGenerated]
	// RVA: 0x24A4F34 Offset: 0x24A0F34 VA: 0x24A4F34
	private void <OnDicpose>b__22_0() { }

	[CompilerGenerated]
	// RVA: 0x24A4F90 Offset: 0x24A0F90 VA: 0x24A4F90
	private void <DeadThread>b__25_0() { }
}
