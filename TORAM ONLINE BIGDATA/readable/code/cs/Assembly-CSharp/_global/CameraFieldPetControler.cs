// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraFieldPetControler : CameraFieldControler // TypeDefIndex: 372
{
	// Fields
	private GameObject pet; // 0x108
	private PetRaceMaster master; // 0x110
	private float targetHeight; // 0x118
	private ICamaraInputManager cameraInputManager; // 0x120

	// Properties
	private float targetCameraHeight { get; }
	public override CameraControlerType Type { get; }
	protected override Transform autoLookTargetObject { get; }
	protected override ICamaraInputManager inputManager { get; }
	protected override Transform playerTrans { get; }

	// Methods

	// RVA: 0x2552DC0 Offset: 0x254EDC0 VA: 0x2552DC0
	private float get_targetCameraHeight() { }

	// RVA: 0x2552EC8 Offset: 0x254EEC8 VA: 0x2552EC8 Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x2552ED0 Offset: 0x254EED0 VA: 0x2552ED0 Slot: 11
	protected override Transform get_autoLookTargetObject() { }

	// RVA: 0x2552ED8 Offset: 0x254EED8 VA: 0x2552ED8 Slot: 12
	protected override ICamaraInputManager get_inputManager() { }

	// RVA: 0x2552EE0 Offset: 0x254EEE0 VA: 0x2552EE0 Slot: 10
	protected override Transform get_playerTrans() { }

	// RVA: 0x2552F68 Offset: 0x254EF68 VA: 0x2552F68
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x2552F78 Offset: 0x254EF78 VA: 0x2552F78
	public void SetControllerTarget(GameObject pet, ICamaraInputManager cameraInputManager) { }

	// RVA: 0x2553064 Offset: 0x254F064 VA: 0x2553064 Slot: 13
	protected override void setTargetPos() { }

	// RVA: 0x2553128 Offset: 0x254F128 VA: 0x2553128 Slot: 9
	public override void LateUpdate() { }
}
