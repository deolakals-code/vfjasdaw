// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CameraRezeroControler : CameraFieldControler // TypeDefIndex: 373
{
	// Fields
	private IObjectCollder mobCollder; // 0x108
	private GameObject mob; // 0x110

	// Properties
	public override CameraControlerType Type { get; }

	// Methods

	// RVA: 0x25531CC Offset: 0x254F1CC VA: 0x25531CC Slot: 6
	public override CameraControlerType get_Type() { }

	// RVA: 0x25531D4 Offset: 0x254F1D4 VA: 0x25531D4
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x25531DC Offset: 0x254F1DC VA: 0x25531DC Slot: 8
	public override void Update() { }

	// RVA: 0x2553350 Offset: 0x254F350 VA: 0x2553350 Slot: 9
	public override void LateUpdate() { }

	// RVA: 0x25534C4 Offset: 0x254F4C4 VA: 0x25534C4 Slot: 14
	protected override float screenHeightRotateCameraMove(float heightStart, float move, float power) { }

	// RVA: 0x25534F0 Offset: 0x254F4F0 VA: 0x25534F0 Slot: 15
	protected override float heightMoveCameraMove(float move, float power) { }
}
