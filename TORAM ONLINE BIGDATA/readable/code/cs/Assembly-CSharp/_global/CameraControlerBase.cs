// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class CameraControlerBase // TypeDefIndex: 366
{
	// Fields
	protected CameraManager cameraManager; // 0x10
	protected Transform cameraTransform; // 0x18

	// Properties
	public abstract Vector3 TargetDist { get; }
	public abstract Vector3 Position { get; }
	public abstract CameraControlerType Type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Vector3 get_TargetDist();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector3 get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract CameraControlerType get_Type();

	// RVA: 0x248C7B0 Offset: 0x24887B0 VA: 0x248C7B0
	public void .ctor(CameraManager cameraManager) { }

	// RVA: 0x248D634 Offset: 0x2489634 VA: 0x248D634 Slot: 7
	public virtual void OnActive() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void LateUpdate();

	// RVA: 0x248D638 Offset: 0x2489638 VA: 0x248D638
	protected float RegulateCamera(float value, bool isRotate) { }
}
