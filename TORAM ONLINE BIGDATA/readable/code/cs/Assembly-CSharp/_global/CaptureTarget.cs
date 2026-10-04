// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class CaptureTarget : CaptureTargetBase // TypeDefIndex: 1179
{
	// Fields
	private readonly EnemyMobActionManagerBase target; // 0x20
	private readonly PlayerActionManagerBase player; // 0x28
	protected int orgTimer; // 0x30
	protected int maxGauge; // 0x34
	protected int registIncreaseVal; // 0x38
	private readonly int minRegist; // 0x3C
	private readonly int maxRegist; // 0x40
	protected int nowTimer; // 0x44
	private int nowGauge; // 0x48
	private int nowRegist; // 0x4C
	private Vector3 prevPos; // 0x50
	private bool isDamage; // 0x5C
	private bool isForcedEnd; // 0x5D
	private bool result; // 0x5E
	private bool serverUpdateFlg; // 0x5F
	private float serverUpdateTime; // 0x60
	private bool isEnd; // 0x64

	// Properties
	private bool serverUpdate { get; set; }
	public override bool IsEnd { get; }
	public override int OrgTimer { get; }
	public override int MaxGauge { get; }
	public override int NowTimer { get; }
	public override int NowGauge { get; }
	public override int NowRegist { get; }
	public override bool Result { get; }
	public override EnemyMobActionManagerBase Target { get; }
	public override PlayerActionManagerBase Player { get; }
	private int gaugeVal { get; }

	// Methods

	// RVA: 0x1F7A148 Offset: 0x1F76148 VA: 0x1F7A148
	private bool get_serverUpdate() { }

	// RVA: 0x1F7A1A0 Offset: 0x1F761A0 VA: 0x1F7A1A0
	private void set_serverUpdate(bool value) { }

	// RVA: 0x1F7A1C4 Offset: 0x1F761C4 VA: 0x1F7A1C4 Slot: 8
	public override bool get_IsEnd() { }

	// RVA: 0x1F7A27C Offset: 0x1F7627C VA: 0x1F7A27C Slot: 11
	public override int get_OrgTimer() { }

	// RVA: 0x1F7A284 Offset: 0x1F76284 VA: 0x1F7A284 Slot: 12
	public override int get_MaxGauge() { }

	// RVA: 0x1F7A28C Offset: 0x1F7628C VA: 0x1F7A28C Slot: 13
	public override int get_NowTimer() { }

	// RVA: 0x1F7A294 Offset: 0x1F76294 VA: 0x1F7A294 Slot: 14
	public override int get_NowGauge() { }

	// RVA: 0x1F7A29C Offset: 0x1F7629C VA: 0x1F7A29C Slot: 15
	public override int get_NowRegist() { }

	// RVA: 0x1F7A2A4 Offset: 0x1F762A4 VA: 0x1F7A2A4 Slot: 17
	public override bool get_Result() { }

	// RVA: 0x1F7A2AC Offset: 0x1F762AC VA: 0x1F7A2AC Slot: 9
	public override EnemyMobActionManagerBase get_Target() { }

	// RVA: 0x1F7A2B4 Offset: 0x1F762B4 VA: 0x1F7A2B4 Slot: 10
	public override PlayerActionManagerBase get_Player() { }

	// RVA: 0x1F7A2BC Offset: 0x1F762BC VA: 0x1F7A2BC
	private int get_gaugeVal() { }

	// RVA: 0x1F78F24 Offset: 0x1F74F24 VA: 0x1F78F24
	public void .ctor(EnemyMobActionManagerBase target, PlayerActionManagerBase player) { }

	// RVA: 0x1F7A758 Offset: 0x1F76758 VA: 0x1F7A758
	public void .ctor(EnemyMobActionManagerBase target, PlayerActionManagerBase player, CaptureStartEvent captureEvent) { }

	// RVA: 0x1F7A80C Offset: 0x1F7680C VA: 0x1F7A80C Slot: 16
	public override void SetServerData(int timer, int gauge, int regist) { }

	// RVA: 0x1F7A854 Offset: 0x1F76854 VA: 0x1F7A854 Slot: 18
	public override void AddRegistValue(bool isAttack) { }

	// RVA: 0x1F7A924 Offset: 0x1F76924 VA: 0x1F7A924 Slot: 20
	public override bool Update() { }

	// RVA: 0x1F7AC84 Offset: 0x1F76C84 VA: 0x1F7AC84 Slot: 19
	public override void ForcedEnd() { }

	// RVA: 0x1F7AC70 Offset: 0x1F76C70 VA: 0x1F7AC70
	private void End(bool resultData) { }

	// RVA: 0x1F7AC90 Offset: 0x1F76C90 VA: 0x1F7AC90 Slot: 23
	public override void CaptureSuccess(CaptureSuccessEvent success) { }

	// RVA: 0x1F7AC04 Offset: 0x1F76C04 VA: 0x1F7AC04
	private void SubRegistValue() { }

	// RVA: 0x1F7AABC Offset: 0x1F76ABC VA: 0x1F7AABC
	private bool CheckMovePos() { }

	// RVA: 0x1F7A434 Offset: 0x1F76434 VA: 0x1F7A434
	private bool checkAbnormal() { }

	[IteratorStateMachine(typeof(CaptureTarget.<targetAbnormalType>d__51))]
	// RVA: 0x1F7B024 Offset: 0x1F77024 VA: 0x1F7B024
	private IEnumerable<AbnormalType> targetAbnormalType() { }
}
