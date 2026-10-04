// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Collider.h")]
[RequiredByNativeCode]
[RequireComponent(typeof(Transform))]
public class Collider : Component // TypeDefIndex: 17647
{
	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { set; }
	public Bounds bounds { get; }

	// Methods

	// RVA: 0x381C404 Offset: 0x3818404 VA: 0x381C404
	public bool get_enabled() { }

	// RVA: 0x381C440 Offset: 0x3818440 VA: 0x381C440
	public void set_enabled(bool value) { }

	[NativeMethod("GetRigidbody")]
	// RVA: 0x381BF7C Offset: 0x3817F7C VA: 0x381BF7C
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x381C484 Offset: 0x3818484 VA: 0x381C484
	public void set_isTrigger(bool value) { }

	// RVA: 0x381C4C8 Offset: 0x38184C8 VA: 0x381C4C8
	public Bounds get_bounds() { }

	// RVA: 0x381C574 Offset: 0x3818574 VA: 0x381C574
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x381C674 Offset: 0x3818674 VA: 0x381C674
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x381C720 Offset: 0x3818720 VA: 0x381C720
	public void .ctor() { }

	// RVA: 0x381C530 Offset: 0x3818530 VA: 0x381C530
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x381C608 Offset: 0x3818608 VA: 0x381C608
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }
}
