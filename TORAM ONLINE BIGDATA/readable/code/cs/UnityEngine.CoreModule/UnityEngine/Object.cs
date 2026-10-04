// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class Object // TypeDefIndex: 16377
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x37EF51C Offset: 0x37EB51C VA: 0x37EF51C
	public int GetInstanceID() { }

	// RVA: 0x37EF65C Offset: 0x37EB65C VA: 0x37EF65C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37EF664 Offset: 0x37EB664 VA: 0x37EF664 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37EF808 Offset: 0x37EB808 VA: 0x37EF808
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x37EF760 Offset: 0x37EB760 VA: 0x37EF760
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x37EF86C Offset: 0x37EB86C VA: 0x37EF86C
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x37EF88C Offset: 0x37EB88C VA: 0x37EF88C
	private IntPtr GetCachedPtr() { }

	// RVA: 0x37EF894 Offset: 0x37EB894 VA: 0x37EF894
	public string get_name() { }

	// RVA: 0x37EF944 Offset: 0x37EB944 VA: 0x37EF944
	public void set_name(string value) { }

	[TypeInferenceRule(3)]
	// RVA: 0x37EFA0C Offset: 0x37EBA0C VA: 0x37EFA0C
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(3)]
	// RVA: 0x37EFCA0 Offset: 0x37EBCA0 VA: 0x37EFCA0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x37EFEEC Offset: 0x37EBEEC VA: 0x37EFEEC
	public static Object Instantiate(Object original) { }

	[TypeInferenceRule(3)]
	// RVA: 0x37F0018 Offset: 0x37EC018 VA: 0x37F0018
	public static Object Instantiate(Object original, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x37F0080 Offset: 0x37EC080 VA: 0x37F0080
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD168 Offset: 0x26D9168 VA: 0x26DD168
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD3C4 Offset: 0x26D93C4 VA: 0x26DD3C4
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD294 Offset: 0x26D9294 VA: 0x26DD294
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD304 Offset: 0x26D9304 VA: 0x26DD304
	|-Object.Instantiate<object>
	*/

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x37F021C Offset: 0x37EC21C VA: 0x37F021C
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocs]
	// RVA: 0x37F0268 Offset: 0x37EC268 VA: 0x37F0268
	public static void Destroy(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x37F02E0 Offset: 0x37EC2E0 VA: 0x37F02E0
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocs]
	// RVA: 0x37F0324 Offset: 0x37EC324 VA: 0x37F0324
	public static void DestroyImmediate(Object obj) { }

	// RVA: 0x37F039C Offset: 0x37EC39C VA: 0x37F039C
	public static Object[] FindObjectsOfType(Type type) { }

	[TypeInferenceRule(2)]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	// RVA: 0x37F0414 Offset: 0x37EC414 VA: 0x37F0414
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	// RVA: 0x37F0458 Offset: 0x37EC458 VA: 0x37F0458
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x37F0494 Offset: 0x37EC494 VA: 0x37F0494
	public HideFlags get_hideFlags() { }

	// RVA: 0x37F04D0 Offset: 0x37EC4D0 VA: 0x37F04D0
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD080 Offset: 0x26D9080 VA: 0x26DD080
	|-Object.FindObjectOfType<object>
	*/

	// RVA: 0x37EFBBC Offset: 0x37EBBBC VA: 0x37EFBBC
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRule(0)]
	// RVA: 0x37F0514 Offset: 0x37EC514 VA: 0x37F0514
	public static Object FindObjectOfType(Type type) { }

	[TypeInferenceRule(0)]
	// RVA: 0x37F05AC Offset: 0x37EC5AC VA: 0x37F05AC
	public static Object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x37F0650 Offset: 0x37EC650 VA: 0x37F0650 Slot: 3
	public override string ToString() { }

	// RVA: 0x37ECCB0 Offset: 0x37E8CB0 VA: 0x37ECCB0
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x37F0700 Offset: 0x37EC700 VA: 0x37F0700
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x37EF634 Offset: 0x37EB634 VA: 0x37EF634
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x37EFFDC Offset: 0x37EBFDC VA: 0x37EFFDC
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunction("CloneObject")]
	// RVA: 0x37F01C8 Offset: 0x37EC1C8 VA: 0x37F01C8
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x37EFC08 Offset: 0x37EBC08 VA: 0x37EFC08
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x37EFE44 Offset: 0x37EBE44 VA: 0x37EFE44
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	// RVA: 0x37F06C4 Offset: 0x37EC6C4 VA: 0x37F06C4
	private static string ToString(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	// RVA: 0x37EF908 Offset: 0x37EB908 VA: 0x37EF908
	private static string GetName(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	// RVA: 0x37EF9C8 Offset: 0x37EB9C8 VA: 0x37EF9C8
	private static void SetName(Object obj, string name) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	// RVA: 0x37F0820 Offset: 0x37EC820 VA: 0x37F0820
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x37EB8A0 Offset: 0x37E78A0 VA: 0x37EB8A0
	public void .ctor() { }

	// RVA: 0x37F085C Offset: 0x37EC85C VA: 0x37F085C
	private static void .cctor() { }

	// RVA: 0x37F0770 Offset: 0x37EC770 VA: 0x37F0770
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x37F07C4 Offset: 0x37EC7C4 VA: 0x37F07C4
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }
}
