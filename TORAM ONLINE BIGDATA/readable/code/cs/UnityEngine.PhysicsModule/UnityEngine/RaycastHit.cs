// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
public struct RaycastHit // TypeDefIndex: 17645
{
	// Fields
	[NativeName("point")]
	internal Vector3 m_Point; // 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; // 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; // 0x18
	[NativeName("distance")]
	internal float m_Distance; // 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; // 0x20
	[NativeName("collider")]
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; }
	public float distance { get; }
	public Vector2 textureCoord { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x381BBF8 Offset: 0x3817BF8 VA: 0x381BBF8
	public Collider get_collider() { }

	// RVA: 0x381BCA4 Offset: 0x3817CA4 VA: 0x381BCA4
	public Vector3 get_point() { }

	// RVA: 0x381BCB0 Offset: 0x3817CB0 VA: 0x381BCB0
	public void set_point(Vector3 value) { }

	// RVA: 0x381BCBC Offset: 0x3817CBC VA: 0x381BCBC
	public Vector3 get_normal() { }

	// RVA: 0x381BCC8 Offset: 0x3817CC8 VA: 0x381BCC8
	public float get_distance() { }

	[NativeMethod("CalculateRaycastTexCoord", True, True)]
	// RVA: 0x381BCD0 Offset: 0x3817CD0 VA: 0x381BCD0
	private static Vector2 CalculateRaycastTexCoord(int colliderInstanceID, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	// RVA: 0x381BDC4 Offset: 0x3817DC4 VA: 0x381BDC4
	public Vector2 get_textureCoord() { }

	// RVA: 0x381BDE4 Offset: 0x3817DE4 VA: 0x381BDE4
	public Transform get_transform() { }

	// RVA: 0x381BEC0 Offset: 0x3817EC0 VA: 0x381BEC0
	public Rigidbody get_rigidbody() { }

	// RVA: 0x381BD50 Offset: 0x3817D50 VA: 0x381BD50
	private static void CalculateRaycastTexCoord_Injected(int colliderInstanceID, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }
}
