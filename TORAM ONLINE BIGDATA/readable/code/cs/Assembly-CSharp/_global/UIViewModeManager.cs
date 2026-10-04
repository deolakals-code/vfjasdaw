// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIViewModeManager : UIBasePanel, ICamaraInputManager // TypeDefIndex: 6584
{
	// Fields
	[SerializeField]
	private UIRightStick rightStick; // 0x30
	[SerializeField]
	private UILeftStick leftStick; // 0x38
	[SerializeField]
	protected UIIruna2DragPinch screenDragPinch; // 0x40
	[SerializeField]
	private Transform wallPopErrTrans; // 0x48
	[SerializeField]
	private UIToggle uiViweToggle; // 0x50
	[SerializeField]
	private GameObject screenShotButton; // 0x58
	private GameObject targetTrans; // 0x60
	protected CharacterMove targetTransMove; // 0x68
	private GameObject shortcutManager; // 0x70
	private bool openShortcut; // 0x78
	private CameraManager cameraManager; // 0x80
	private bool isUIViewFlag; // 0x88
	protected const float MoveSpeed = 9;
	private Vector3 savePosition; // 0x8C
	private float wallPopTimer; // 0x98
	private bool isFadeUpdate; // 0x9C
	private bool isScreenshotShortcut; // 0x9D
	private Action destroyCallback; // 0xA0

	// Properties
	public virtual bool ScreenTapInputKey { get; }
	public virtual bool ScreenPinchInputKey { get; }
	public virtual float ScreenPinchInputValue { get; }
	public virtual bool IsScreenPress { get; }
	public virtual bool RightInputKey { get; }
	public virtual Vector2 RightInputFirstDeltaValue { get; }
	public Transform TargetTrans { get; }
	public bool IsFadeView { get; }

	// Methods

	// RVA: 0x1990ED0 Offset: 0x198CED0 VA: 0x1990ED0 Slot: 13
	public virtual bool get_ScreenTapInputKey() { }

	// RVA: 0x1990EEC Offset: 0x198CEEC VA: 0x1990EEC Slot: 14
	public virtual bool get_ScreenPinchInputKey() { }

	// RVA: 0x1990F14 Offset: 0x198CF14 VA: 0x1990F14 Slot: 15
	public virtual float get_ScreenPinchInputValue() { }

	// RVA: 0x1990F50 Offset: 0x198CF50 VA: 0x1990F50 Slot: 16
	public virtual bool get_IsScreenPress() { }

	// RVA: 0x1990F6C Offset: 0x198CF6C VA: 0x1990F6C Slot: 17
	public virtual bool get_RightInputKey() { }

	// RVA: 0x1990F88 Offset: 0x198CF88 VA: 0x1990F88 Slot: 18
	public virtual Vector2 get_RightInputFirstDeltaValue() { }

	// RVA: 0x1991030 Offset: 0x198D030 VA: 0x1991030
	public Transform get_TargetTrans() { }

	// RVA: 0x199104C Offset: 0x198D04C VA: 0x199104C
	public bool get_IsFadeView() { }

	// RVA: 0x199106C Offset: 0x198D06C VA: 0x199106C Slot: 19
	protected virtual void Awake() { }

	// RVA: 0x1991500 Offset: 0x198D500 VA: 0x1991500
	private void OnDestroy() { }

	// RVA: 0x19916D4 Offset: 0x198D6D4 VA: 0x19916D4 Slot: 20
	protected virtual void Update() { }

	// RVA: 0x1991B8C Offset: 0x198DB8C VA: 0x1991B8C Slot: 21
	protected virtual Vector2 GetMoveStick() { }

	// RVA: 0x1991BA8 Offset: 0x198DBA8 VA: 0x1991BA8
	public void SetDestroyCallback(Action callback) { }

	// RVA: 0x1991BB0 Offset: 0x198DBB0 VA: 0x1991BB0
	public void OnClick_ScreenShot() { }

	// RVA: 0x1991C30 Offset: 0x198DC30 VA: 0x1991C30 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1991D30 Offset: 0x198DD30 VA: 0x1991D30
	private void TopReturnButton() { }

	// RVA: 0x1991DF8 Offset: 0x198DDF8 VA: 0x1991DF8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1991CA8 Offset: 0x198DCA8 VA: 0x1991CA8
	private void TopChatButton() { }

	// RVA: 0x1991E70 Offset: 0x198DE70 VA: 0x1991E70 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1992008 Offset: 0x198E008 VA: 0x1992008
	public void .ctor() { }
}
