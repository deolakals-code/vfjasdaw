// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InputManager : Singleton<InputManager>, ICamaraInputManager // TypeDefIndex: 5497
{
	// Fields
	private float lastInputTime; // 0x20
	protected float lastInputBattleTime; // 0x24
	private bool isInputLock; // 0x28
	private bool isShowAutoLogout; // 0x29
	private readonly float autoLogoutMessageTime; // 0x2C
	private readonly float autoLogoutTime; // 0x30
	protected readonly float autoMobReleaseTime; // 0x34
	private bool isReserveAutoLogout; // 0x38
	[SerializeField]
	private GameObject leftStickObject; // 0x40
	private UILeftStick leftStick; // 0x48
	[SerializeField]
	private GameObject rightStickObject; // 0x50
	private UIRightStick rightStick; // 0x58
	[SerializeField]
	private GameObject screenTapObject; // 0x60
	private UIIruna2DragPinch screenTap; // 0x68

	// Properties
	public bool IsInputLock { get; set; }
	public bool LeftInputKey { get; }
	public bool LeftInputKeyGuardCrash { get; }
	public Vector2 LeftInputValue { get; }
	public float LeftInputMoveRate { get; }
	public virtual bool RightInputKey { get; }
	public Vector2 RightInputValue { get; }
	public virtual Vector2 RightInputFirstDeltaValue { get; }
	private UIIruna2DragPinch screenDragPinch { get; }
	public bool ScreenTapInputKey { get; }
	public Vector2 ScreenTapInputValue { get; }
	public virtual Vector2 ScreenTapInputFirstDeltaValue { get; }
	public virtual bool ScreenPinchInputKey { get; }
	public virtual float ScreenPinchInputValue { get; }
	public bool IsScreenPress { get; }
	public virtual bool IsTargetMove { get; set; }

	// Methods

	// RVA: 0x177BDE8 Offset: 0x1777DE8 VA: 0x177BDE8
	private void Awake() { }

	// RVA: 0x177BEB8 Offset: 0x1777EB8 VA: 0x177BEB8
	private void Update() { }

	// RVA: 0x177BFE8 Offset: 0x1777FE8 VA: 0x177BFE8
	public void set_IsInputLock(bool value) { }

	// RVA: 0x177BFF4 Offset: 0x1777FF4 VA: 0x177BFF4
	public bool get_IsInputLock() { }

	// RVA: 0x177BFFC Offset: 0x1777FFC VA: 0x177BFFC
	public void LastInputUpdate() { }

	// RVA: 0x177C02C Offset: 0x177802C VA: 0x177C02C Slot: 10
	protected virtual void checkAnyInput() { }

	// RVA: 0x177CA24 Offset: 0x1778A24 VA: 0x177CA24
	private void showAutoLogoutMessage(float time) { }

	// RVA: 0x177BED8 Offset: 0x1777ED8 VA: 0x177BED8
	protected void checkBattleAbandonedTime() { }

	// RVA: 0x177CD18 Offset: 0x1778D18 VA: 0x177CD18 Slot: 11
	protected virtual bool AnyInputKey() { }

	// RVA: 0x177CD20 Offset: 0x1778D20 VA: 0x177CD20
	public bool get_LeftInputKey() { }

	// RVA: 0x177CE54 Offset: 0x1778E54 VA: 0x177CE54
	public bool get_LeftInputKeyGuardCrash() { }

	// RVA: 0x177CF88 Offset: 0x1778F88 VA: 0x177CF88
	public Vector2 get_LeftInputValue() { }

	// RVA: 0x177D0D8 Offset: 0x17790D8 VA: 0x177D0D8
	public float get_LeftInputMoveRate() { }

	// RVA: 0x177D1F8 Offset: 0x17791F8 VA: 0x177D1F8 Slot: 12
	public virtual bool get_RightInputKey() { }

	// RVA: 0x177D2D8 Offset: 0x17792D8 VA: 0x177D2D8
	protected bool RightInputCheck() { }

	// RVA: 0x177D3F4 Offset: 0x17793F4 VA: 0x177D3F4
	public Vector2 get_RightInputValue() { }

	// RVA: 0x177D5D0 Offset: 0x17795D0 VA: 0x177D5D0 Slot: 13
	public virtual Vector2 get_RightInputFirstDeltaValue() { }

	// RVA: 0x177D6FC Offset: 0x17796FC VA: 0x177D6FC
	protected bool RightInputFirstDeltaValueCheck() { }

	// RVA: 0x177D70C Offset: 0x177970C VA: 0x177D70C
	private UIIruna2DragPinch get_screenDragPinch() { }

	// RVA: 0x177D348 Offset: 0x1779348 VA: 0x177D348 Slot: 6
	public bool get_ScreenTapInputKey() { }

	// RVA: 0x177D518 Offset: 0x1779518 VA: 0x177D518
	public Vector2 get_ScreenTapInputValue() { }

	// RVA: 0x177D7BC Offset: 0x17797BC VA: 0x177D7BC Slot: 14
	public virtual Vector2 get_ScreenTapInputFirstDeltaValue() { }

	// RVA: 0x177D83C Offset: 0x177983C VA: 0x177D83C
	protected bool ScreenTapInputFirstDeltaValueCheck() { }

	// RVA: 0x177D8E8 Offset: 0x17798E8 VA: 0x177D8E8 Slot: 15
	public virtual bool get_ScreenPinchInputKey() { }

	// RVA: 0x177D928 Offset: 0x1779928 VA: 0x177D928
	protected bool ScreenPinchInputCheck() { }

	// RVA: 0x177D9B8 Offset: 0x17799B8 VA: 0x177D9B8 Slot: 16
	public virtual float get_ScreenPinchInputValue() { }

	// RVA: 0x177DA0C Offset: 0x1779A0C VA: 0x177DA0C
	public bool ScreenPinchInputValueCheck() { }

	// RVA: 0x177DAB8 Offset: 0x1779AB8 VA: 0x177DAB8 Slot: 7
	public bool get_IsScreenPress() { }

	// RVA: 0x177DAD4 Offset: 0x1779AD4 VA: 0x177DAD4 Slot: 17
	public virtual void set_IsTargetMove(bool value) { }

	// RVA: 0x177DAD8 Offset: 0x1779AD8 VA: 0x177DAD8 Slot: 18
	public virtual bool get_IsTargetMove() { }

	// RVA: 0x177DAE0 Offset: 0x1779AE0 VA: 0x177DAE0
	public void ChangeCursorLockState(bool isLock) { }

	// RVA: 0x177DAE4 Offset: 0x1779AE4 VA: 0x177DAE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x177DB48 Offset: 0x1779B48 VA: 0x177DB48
	private void <showAutoLogoutMessage>b__15_0() { }
}
