// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", 0)]
public class Physics // TypeDefIndex: 17643
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Physics.ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Properties
	public static bool invokeCollisionCallbacks { get; }
	[NativeProperty("DefaultPhysicsSceneHandle", True, 0, True)]
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool reuseCollisionCallbacks { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x38189E0 Offset: 0x38149E0 VA: 0x38189E0
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x3818AC4 Offset: 0x3814AC4 VA: 0x3818AC4
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x3818AEC Offset: 0x3814AEC VA: 0x3818AEC
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x3818BA4 Offset: 0x3814BA4 VA: 0x3818BA4
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x3818E4C Offset: 0x3814E4C VA: 0x3818E4C
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x3818F10 Offset: 0x3814F10 VA: 0x3818F10
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x3818FD8 Offset: 0x3814FD8 VA: 0x3818FD8
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x3819090 Offset: 0x3815090 VA: 0x3819090
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x3819354 Offset: 0x3815354 VA: 0x3819354
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x3819430 Offset: 0x3815430 VA: 0x3819430
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x38194F8 Offset: 0x38154F8 VA: 0x38194F8
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x38195C0 Offset: 0x38155C0 VA: 0x38195C0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x3819658 Offset: 0x3815658 VA: 0x3819658
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x38196F4 Offset: 0x38156F4 VA: 0x38196F4
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x381977C Offset: 0x381577C VA: 0x381977C
	public static bool Raycast(Ray ray) { }

	// RVA: 0x3819804 Offset: 0x3815804 VA: 0x3819804
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x38198B4 Offset: 0x38158B4 VA: 0x38198B4
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x381996C Offset: 0x381596C VA: 0x381996C
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x3819A0C Offset: 0x3815A0C VA: 0x3819A0C
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x3819A9C Offset: 0x3815A9C VA: 0x3819A9C
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x3819B78 Offset: 0x3815B78 VA: 0x3819B78
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("RaycastAll")]
	// RVA: 0x3819C40 Offset: 0x3815C40 VA: 0x3819C40
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3819D54 Offset: 0x3815D54 VA: 0x3819D54
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x3819F78 Offset: 0x3815F78 VA: 0x3819F78
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x381A028 Offset: 0x3816028 VA: 0x381A028
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x381A0D4 Offset: 0x38160D4 VA: 0x381A0D4
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x381A178 Offset: 0x3816178 VA: 0x381A178
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x381A22C Offset: 0x381622C VA: 0x381A22C
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x381A2DC Offset: 0x38162DC VA: 0x381A2DC
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x381A380 Offset: 0x3816380 VA: 0x381A380
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x381A41C Offset: 0x381641C VA: 0x381A41C
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x381A71C Offset: 0x381671C VA: 0x381A71C
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x381A7B4 Offset: 0x38167B4 VA: 0x381A7B4
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x381A850 Offset: 0x3816850 VA: 0x381A850
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x381A8DC Offset: 0x38168DC VA: 0x381A8DC
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x381A9B0 Offset: 0x38169B0 VA: 0x381A9B0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x381AA88 Offset: 0x3816A88 VA: 0x381AA88
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x381AB4C Offset: 0x3816B4C VA: 0x381AB4C
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeName("SphereCastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x381AC10 Offset: 0x3816C10 VA: 0x381AC10
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381AD5C Offset: 0x3816D5C VA: 0x381AD5C
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x381AEC4 Offset: 0x3816EC4 VA: 0x381AEC4
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x381AF7C Offset: 0x3816F7C VA: 0x381AF7C
	public static bool get_reuseCollisionCallbacks() { }

	[NativeName("SphereTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x381AFA4 Offset: 0x3816FA4 VA: 0x381AFA4
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381B0C8 Offset: 0x38170C8 VA: 0x381B0C8
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x381B164 Offset: 0x3817164 VA: 0x381B164
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x381B1EC Offset: 0x38171EC VA: 0x381B1EC
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x381B228 Offset: 0x3817228 VA: 0x381B228
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x381B264 Offset: 0x3817264 VA: 0x381B264
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x381B2A8 Offset: 0x38172A8 VA: 0x381B2A8
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x381B2EC Offset: 0x38172EC VA: 0x381B2EC
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[RequiredByNativeCode]
	// RVA: 0x381B330 Offset: 0x3817330 VA: 0x381B330
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x381B588 Offset: 0x3817588 VA: 0x381B588
	private static void ReportContacts(NativeArray.ReadOnly<ContactPairHeader> array) { }

	// RVA: 0x381B988 Offset: 0x3817988 VA: 0x381B988
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x381BAD0 Offset: 0x3817AD0 VA: 0x381BAD0
	private static void .cctor() { }

	// RVA: 0x3818B68 Offset: 0x3814B68 VA: 0x3818B68
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x3819CE8 Offset: 0x3815CE8 VA: 0x3819CE8
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381ACD8 Offset: 0x3816CD8 VA: 0x381ACD8
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x381B05C Offset: 0x381705C VA: 0x381B05C
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }
}
