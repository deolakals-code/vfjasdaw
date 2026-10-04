// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraBlackKnightGameController : CameraControlerBase // TypeDefIndex: 363
{
	// Fields
	private float cameraDist; // 0x20
	private float lerpStartDist; // 0x24
	private float lerpEndDist; // 0x28
	private float cameraRot; // 0x2C
	private float lerpStartRot; // 0x30
	private float lerpEndRot; // 0x34
	private Vector3 lerpStartLook; // 0x38
	private Vector3 lerpEndLook; // 0x44
	private float cameraLookHeight; // 0x50
	private Vector3 movePos; // 0x54
	private Vector3 lookPos; // 0x60
	private GuideRail guideRail; // 0x70
	private BlackKnightPlayerManager playerManager; // 0x78
	private BlackKnightBossManager bossManager; // 0x80
	private bool isInit; // 0x88
	private readonly float lerpEndTime; // 0x8C
	private float lerpTimer; // 0x90
	[CompilerGenerated]
	private bool <IsBossBattle>k__BackingField; // 0x94

	// Properties
	public override CameraControlerType Type { get; }
	public override Vector3 Position { get; }
	public override Vector3 TargetDist { get; }
	public bool IsBossBattle { get; set; }

	// Methods

	// RVA: 0x248C6E4 Offset: 0x24886E4 VA: 0x248C6E4 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x248C6EC Offset: 0x24886EC VA: 0x248C6EC Slot: 5
	public override Vector3 get_Position() { }

	// RVA: 0x248C734 Offset: 0x2488734 VA: 0x248C734 Slot: 4
	public override Vector3 get_TargetDist() { }

	[CompilerGenerated]
	// RVA: 0x248C774 Offset: 0x2488774 VA: 0x248C774
	public bool get_IsBossBattle() { }

	[CompilerGenerated]
	// RVA: 0x248C77C Offset: 0x248877C VA: 0x248C77C
	private void set_IsBossBattle(bool value) { }

	// RVA: 0x248C788 Offset: 0x2488788 VA: 0x248C788
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x248C804 Offset: 0x2488804 VA: 0x248C804 Slot: 7
	public override void OnActive() { }

	// RVA: 0x248C808 Offset: 0x2488808 VA: 0x248C808
	public void Init(GuideRail guide, BlackKnightPlayerManager player, GameObject playerObj) { }

	// RVA: 0x248C9F4 Offset: 0x24889F4 VA: 0x248C9F4 Slot: 8
	public override void Update() { }

	// RVA: 0x248CEE0 Offset: 0x2488EE0 VA: 0x248CEE0
	private void NormalCameraUpdate(Vector3 cross, Vector3 railDir) { }

	// RVA: 0x248CB78 Offset: 0x2488B78 VA: 0x248CB78
	private void BossCameraUpdate(Vector3 cross, Vector3 railDir) { }

	// RVA: 0x248D0D4 Offset: 0x24890D4 VA: 0x248D0D4 Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x248D178 Offset: 0x2489178 VA: 0x248D178
	private void RotateUpdate() { }

	// RVA: 0x248D1DC Offset: 0x24891DC VA: 0x248D1DC
	public void StartBossBattle(BlackKnightBossManager boss) { }

	// RVA: 0x248D1E0 Offset: 0x24891E0 VA: 0x248D1E0
	private void ChangeBossBattle(BlackKnightBossManager boss) { }
}
