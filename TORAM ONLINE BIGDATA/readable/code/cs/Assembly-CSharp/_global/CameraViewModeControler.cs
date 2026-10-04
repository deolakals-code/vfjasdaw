// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraViewModeControler : CameraFieldControler // TypeDefIndex: 381
{
	// Fields
	private UIViewModeManager uiViewModeManager; // 0x108
	private Transform targetTrans; // 0x110
	private float targetHeight; // 0x118

	// Properties
	public override CameraControlerType Type { get; }
	protected override Transform autoLookTargetObject { get; }
	protected override ICamaraInputManager inputManager { get; }
	protected override Transform playerTrans { get; }

	// Methods

	// RVA: 0x25573E0 Offset: 0x25533E0 VA: 0x25573E0 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x25573E8 Offset: 0x25533E8 VA: 0x25573E8 Slot: 11
	protected override Transform get_autoLookTargetObject() { }

	// RVA: 0x25573F0 Offset: 0x25533F0 VA: 0x25573F0 Slot: 12
	protected override ICamaraInputManager get_inputManager() { }

	// RVA: 0x25573F8 Offset: 0x25533F8 VA: 0x25573F8 Slot: 10
	protected override Transform get_playerTrans() { }

	// RVA: 0x2557400 Offset: 0x2553400 VA: 0x2557400
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x2557410 Offset: 0x2553410 VA: 0x2557410 Slot: 13
	protected override void setTargetPos() { }

	// RVA: 0x25574C8 Offset: 0x25534C8 VA: 0x25574C8 Slot: 9
	public override void LateUpdate() { }
}
