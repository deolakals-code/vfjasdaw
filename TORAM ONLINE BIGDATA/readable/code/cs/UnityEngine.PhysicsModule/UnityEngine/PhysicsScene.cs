// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 17656
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x381CA7C Offset: 0x3818A7C VA: 0x381CA7C Slot: 3
	public override string ToString() { }

	// RVA: 0x381CB6C Offset: 0x3818B6C VA: 0x381CB6C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x381CB74 Offset: 0x3818B74 VA: 0x381CB74 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x381CBEC Offset: 0x3818BEC VA: 0x381CBEC Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x3818C7C Offset: 0x3814C7C VA: 0x3818C7C
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x381CBFC Offset: 0x3818BFC VA: 0x381CBFC
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3819168 Offset: 0x3815168 VA: 0x3819168
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("Raycast")]
	// RVA: 0x381CCE4 Offset: 0x3818CE4 VA: 0x381CCE4
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381A4C8 Offset: 0x38164C8 VA: 0x381A4C8
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x381CDDC Offset: 0x3818DDC VA: 0x381CDDC
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("SphereCast")]
	// RVA: 0x381CED0 Offset: 0x3818ED0 VA: 0x381CED0
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381CFF8 Offset: 0x3818FF8 VA: 0x381CFF8
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3819B70 Offset: 0x3815B70 VA: 0x3819B70
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x381CC78 Offset: 0x3818C78 VA: 0x381CC78
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381CD60 Offset: 0x3818D60 VA: 0x381CD60
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381CE54 Offset: 0x3818E54 VA: 0x381CE54
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381CF6C Offset: 0x3818F6C VA: 0x381CF6C
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }
}
