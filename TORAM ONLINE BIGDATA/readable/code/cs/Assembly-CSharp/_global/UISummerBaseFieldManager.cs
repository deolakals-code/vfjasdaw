// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISummerBaseFieldManager : UIBasePanel // TypeDefIndex: 6282
{
	// Fields
	public float speed; // 0x2C
	public float timer; // 0x30
	[SerializeField]
	protected UIIruna2AnchorSimple rightAnchor; // 0x38
	[SerializeField]
	private UILabel playerWaterDepthLabel; // 0x40
	[SerializeField]
	private UISprite bar; // 0x48
	[SerializeField]
	private TweenColor barTweenColor; // 0x50
	[SerializeField]
	protected GameObject autoLockButtonPanel; // 0x58
	[SerializeField]
	private UISprite autoLockIcon; // 0x60
	[SerializeField]
	private UIImageButton autoLockButton; // 0x68
	[SerializeField]
	private UILabel autoLockLabel; // 0x70
	[SerializeField]
	private Transform targetSite; // 0x78
	[SerializeField]
	private UILabel uiPopTextLabel; // 0x80
	[SerializeField]
	private UISprite deepLockIcon; // 0x88
	[SerializeField]
	private UIImageButton escapeImageIcon; // 0x90
	[SerializeField]
	protected UIIruna2AnchorSimple rightBottomAnchor; // 0x98
	[SerializeField]
	protected UISlider cameraSlider; // 0xA0
	[SerializeField]
	protected UISprite cameraButtonIcon; // 0xA8
	[SerializeField]
	protected UIImageButton cameraButton; // 0xB0
	protected float prevSliderValue; // 0xB8
	protected int prevCameraFlag; // 0xBC
	protected Transform playerTrans; // 0xC0
	protected SummerEventRoomData roomData; // 0xC8
	private GameObject shortcutManager; // 0xD0
	protected bool openShortcut; // 0xD8
	private int waterDepth; // 0xDC
	private string waterDepthText; // 0xE0
	private bool isWallCheck; // 0xE8
	protected bool isOptionReverse; // 0xE9
	protected bool isActionPress; // 0xEA
	private float escapeDelayTimer; // 0xEC
	protected const int DefaultSensitivity = 50;

	// Methods

	// RVA: 0x18DAFBC Offset: 0x18D6FBC VA: 0x18DAFBC
	private void Start() { }

	// RVA: 0x18DAFC8 Offset: 0x18D6FC8 VA: 0x18DAFC8
	private void OnDestroy() { }

	// RVA: 0x18DB058 Offset: 0x18D7058 VA: 0x18DB058 Slot: 7
	protected virtual void Initialize() { }

	// RVA: 0x18DB628 Offset: 0x18D7628 VA: 0x18DB628
	private void Update() { }

	// RVA: 0x18DB634 Offset: 0x18D7634 VA: 0x18DB634 Slot: 8
	protected virtual void UpdateData() { }

	// RVA: 0x18DBA68 Offset: 0x18D7A68 VA: 0x18DBA68
	protected void SetPlayerWaterDepthLabel(int waterDepth) { }

	// RVA: 0x18DBAF4 Offset: 0x18D7AF4 VA: 0x18DBAF4
	public void OnAttackPress() { }

	// RVA: 0x18DBB28 Offset: 0x18D7B28 VA: 0x18DBB28
	public void OnAttackRelease() { }

	// RVA: 0x18DBB30 Offset: 0x18D7B30 VA: 0x18DBB30
	public void OnDeepLock() { }

	// RVA: 0x18DB5AC Offset: 0x18D75AC VA: 0x18DB5AC
	private void UpdateUIDeepLock() { }

	// RVA: 0x18DBBA4 Offset: 0x18D7BA4 VA: 0x18DBBA4
	public void OnEscapeAction() { }

	// RVA: 0x18DBBE4 Offset: 0x18D7BE4 VA: 0x18DBBE4
	public void OnAutoLock() { }

	// RVA: 0x18DB450 Offset: 0x18D7450 VA: 0x18DB450
	private void UpdateUIAutoLock() { }

	// RVA: 0x18DBC0C Offset: 0x18D7C0C VA: 0x18DBC0C Slot: 9
	protected virtual void CloseShortcutPanel() { }

	// RVA: 0x18DBD64 Offset: 0x18D7D64 VA: 0x18DBD64 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18DBE20 Offset: 0x18D7E20 VA: 0x18DBE20 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18DBF08 Offset: 0x18D7F08 VA: 0x18DBF08 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18DBFAC Offset: 0x18D7FAC VA: 0x18DBFAC Slot: 10
	public virtual bool IsOpenPopPanel() { }

	// RVA: 0x18DBFB4 Offset: 0x18D7FB4 VA: 0x18DBFB4
	public void OnCameraButton() { }

	// RVA: 0x18DC02C Offset: 0x18D802C VA: 0x18DC02C
	private void UpdateCameraButton() { }

	// RVA: 0x18DC120 Offset: 0x18D8120 VA: 0x18DC120
	public void .ctor() { }
}
