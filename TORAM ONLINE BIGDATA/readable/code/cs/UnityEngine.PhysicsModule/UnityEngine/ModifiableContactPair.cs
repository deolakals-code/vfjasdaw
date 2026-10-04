// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public struct ModifiableContactPair // TypeDefIndex: 17644
{
	// Fields
	private IntPtr actor; // 0x0
	private IntPtr otherActor; // 0x8
	private IntPtr shape; // 0x10
	private IntPtr otherShape; // 0x18
	public Quaternion rotation; // 0x20
	public Vector3 position; // 0x30
	public Quaternion otherRotation; // 0x3C
	public Vector3 otherPosition; // 0x4C
	private int numContacts; // 0x58
	private IntPtr contacts; // 0x60
}
