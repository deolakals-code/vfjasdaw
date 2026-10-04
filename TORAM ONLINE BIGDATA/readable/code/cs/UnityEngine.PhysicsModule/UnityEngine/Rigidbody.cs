// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component // TypeDefIndex: 17646
{
	// Properties
	public Vector3 velocity { get; set; }
	public bool useGravity { set; }
	public RigidbodyConstraints constraints { set; }
	public Vector3 inertiaTensor { get; set; }

	// Methods

	// RVA: 0x381BFB8 Offset: 0x3817FB8 VA: 0x381BFB8
	public Vector3 get_velocity() { }

	// RVA: 0x381C058 Offset: 0x3818058 VA: 0x381C058
	public void set_velocity(Vector3 value) { }

	// RVA: 0x381C0F0 Offset: 0x38180F0 VA: 0x381C0F0
	public void set_useGravity(bool value) { }

	// RVA: 0x381C134 Offset: 0x3818134 VA: 0x381C134
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x381C178 Offset: 0x3818178 VA: 0x381C178
	public Vector3 get_inertiaTensor() { }

	// RVA: 0x381C218 Offset: 0x3818218 VA: 0x381C218
	public void set_inertiaTensor(Vector3 value) { }

	// RVA: 0x381C2B0 Offset: 0x38182B0 VA: 0x381C2B0
	public void MovePosition(Vector3 position) { }

	// RVA: 0x381C348 Offset: 0x3818348 VA: 0x381C348
	public void Sleep() { }

	// RVA: 0x381C384 Offset: 0x3818384 VA: 0x381C384
	public bool IsSleeping() { }

	// RVA: 0x381C3C0 Offset: 0x38183C0 VA: 0x381C3C0
	public void ResetInertiaTensor() { }

	// RVA: 0x381C3FC Offset: 0x38183FC VA: 0x381C3FC
	public void .ctor() { }

	// RVA: 0x381C014 Offset: 0x3818014 VA: 0x381C014
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x381C0AC Offset: 0x38180AC VA: 0x381C0AC
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x381C1D4 Offset: 0x38181D4 VA: 0x381C1D4
	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	// RVA: 0x381C26C Offset: 0x381826C VA: 0x381C26C
	private void set_inertiaTensor_Injected(ref Vector3 value) { }

	// RVA: 0x381C304 Offset: 0x3818304 VA: 0x381C304
	private void MovePosition_Injected(ref Vector3 position) { }
}
