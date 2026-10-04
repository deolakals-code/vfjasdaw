// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetRaceGameManager : UIBasePanelConnection, ICamaraInputManager, PetRaceRoomData.IPetRaceMemberData // TypeDefIndex: 5977
{
	// Fields
	protected const float MoveSpeed = 9;
	[SerializeField]
	private UIIruna2Anchor bottomAnchor; // 0x30
	[SerializeField]
	private UIIruna2Anchor leftAnchor; // 0x38
	[SerializeField]
	private UIIruna2AnchorSimple rightAnchor; // 0x40
	[SerializeField]
	private UIRightStick rightStick; // 0x48
	[SerializeField]
	private UILeftStick leftStick; // 0x50
	[SerializeField]
	protected UIIruna2DragPinch screenDragPinch; // 0x58
	[SerializeField]
	private GameObject popTelop; // 0x60
	[SerializeField]
	private TweenScale popTelopAnimation; // 0x68
	[SerializeField]
	private UILabel popTelopLabel; // 0x70
	[SerializeField]
	private UILabel raceTimeLabel; // 0x78
	[SerializeField]
	private UISprite[] staminaBar; // 0x80
	[SerializeField]
	private GameObject[] rankingPanels; // 0x88
	[SerializeField]
	private UILabel[] rankingLabels; // 0x90
	[SerializeField]
	private UISprite[] speedmeter; // 0x98
	[SerializeField]
	private UILabel speedmeterLabel; // 0xA0
	[SerializeField]
	private UISprite autoBackSwitch; // 0xA8
	[SerializeField]
	private UILabel lapLabel; // 0xB0
	[SerializeField]
	private GameObject giveupWindow; // 0xB8
	[SerializeField]
	private UILabel giveupWindowTitleLabel; // 0xC0
	[SerializeField]
	private UILabel giveupWindowMessageLabel; // 0xC8
	[SerializeField]
	private GameObject[] giveupWindowButton; // 0xD0
	protected bool isAutoBack; // 0xD8
	private CameraManager cameraManager; // 0xE0
	private PetMemberRaceActionManager actionManaer; // 0xE8
	private bool isUIViewFlag; // 0xF0
	private PetRaceRoomData roomData; // 0xF8
	private bool isStartFlag; // 0x100
	private float speedPower; // 0x104
	private float speedPowerMove; // 0x108
	private Dictionary<int, string> userNames; // 0x110
	private string lapTextLocalize; // 0x118
	private float autoCameraMove; // 0x120
	private Vector3 moveDir; // 0x124
	private GameObject petCameraTarget; // 0x130
	private short countDownView; // 0x138
	private const float cameraPower = 360;
	private const float cameraMoveMax = 45;
	private const float cameraAsobi = 0.9;

	// Properties
	public virtual bool ScreenTapInputKey { get; }
	public virtual bool ScreenPinchInputKey { get; }
	public virtual float ScreenPinchInputValue { get; }
	public virtual bool IsScreenPress { get; }
	public virtual bool RightInputKey { get; }
	public virtual Vector2 RightInputFirstDeltaValue { get; }

	// Methods

	// RVA: 0x1859250 Offset: 0x1855250 VA: 0x1859250 Slot: 15
	public virtual bool get_ScreenTapInputKey() { }

	// RVA: 0x185926C Offset: 0x185526C VA: 0x185926C Slot: 16
	public virtual bool get_ScreenPinchInputKey() { }

	// RVA: 0x1859294 Offset: 0x1855294 VA: 0x1859294 Slot: 17
	public virtual float get_ScreenPinchInputValue() { }

	// RVA: 0x18592D0 Offset: 0x18552D0 VA: 0x18592D0 Slot: 18
	public virtual bool get_IsScreenPress() { }

	// RVA: 0x18592EC Offset: 0x18552EC VA: 0x18592EC Slot: 19
	public virtual bool get_RightInputKey() { }

	// RVA: 0x1859320 Offset: 0x1855320 VA: 0x1859320 Slot: 20
	public virtual Vector2 get_RightInputFirstDeltaValue() { }

	// RVA: 0x18593D4 Offset: 0x18553D4 VA: 0x18593D4 Slot: 21
	protected virtual void Awake() { }

	[IteratorStateMachine(typeof(UIPetRaceGameManager.<Start>d__52))]
	// RVA: 0x1859810 Offset: 0x1855810 VA: 0x1859810 Slot: 22
	protected virtual IEnumerator Start() { }

	// RVA: 0x1859884 Offset: 0x1855884 VA: 0x1859884 Slot: 23
	protected virtual void OnDestroy() { }

	// RVA: 0x1859988 Offset: 0x1855988 VA: 0x1859988 Slot: 24
	protected virtual void Update() { }

	// RVA: 0x185A4A8 Offset: 0x18564A8 VA: 0x185A4A8 Slot: 25
	protected virtual Vector2 GetMoveStick() { }

	// RVA: 0x185A4C4 Offset: 0x18564C4 VA: 0x185A4C4 Slot: 14
	public void ReceiveRoomData(PetRaceMemberData[] members) { }

	// RVA: 0x185A59C Offset: 0x185659C VA: 0x185A59C
	public void ReceiveRaceRoomData(Dictionary<byte, int> ranks) { }

	// RVA: 0x185A880 Offset: 0x1856880 VA: 0x185A880 Slot: 26
	protected virtual bool CheckActionInput() { }

	// RVA: 0x185A8C4 Offset: 0x18568C4 VA: 0x185A8C4
	protected bool CheckGiveUp() { }

	// RVA: 0x185A908 Offset: 0x1856908 VA: 0x185A908 Slot: 27
	public virtual void OnClick_ChangeCamera() { }

	// RVA: 0x185AA90 Offset: 0x1856A90 VA: 0x185AA90
	public void OnClick_DashAction() { }

	// RVA: 0x185AB6C Offset: 0x1856B6C VA: 0x185AB6C
	public void OnClick_JumpAction() { }

	// RVA: 0x185ABA4 Offset: 0x1856BA4 VA: 0x185ABA4
	public void OnClick_StepAction(int move) { }

	// RVA: 0x185ADD0 Offset: 0x1856DD0 VA: 0x185ADD0
	public void OnClick_GiveUp() { }

	// RVA: 0x185B038 Offset: 0x1857038 VA: 0x185B038
	public void OnClick_GiveUpEnter() { }

	// RVA: 0x185B0E0 Offset: 0x18570E0 VA: 0x185B0E0
	public void OnClick_RetryEnter() { }

	// RVA: 0x185B16C Offset: 0x185716C VA: 0x185B16C
	public void OnClick_RetryFieldEnter() { }

	// RVA: 0x185B310 Offset: 0x1857310 VA: 0x185B310 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x185B320 Offset: 0x1857320 VA: 0x185B320 Slot: 28
	protected virtual void TopReturnButton() { }

	// RVA: 0x185B460 Offset: 0x1857460 VA: 0x185B460 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x185B464 Offset: 0x1857464 VA: 0x185B464
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x185B560 Offset: 0x1857560 VA: 0x185B560
	private bool <Start>b__52_0(AutoMember member) { }

	[CompilerGenerated]
	// RVA: 0x185B634 Offset: 0x1857634 VA: 0x185B634
	private void <OnClick_RetryFieldEnter>b__67_1() { }
}
