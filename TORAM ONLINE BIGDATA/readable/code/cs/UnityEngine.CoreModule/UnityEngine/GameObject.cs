// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[ExcludeFromPreset]
public sealed class GameObject : Object // TypeDefIndex: 16356
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public string tag { get; set; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	// RVA: 0x37EBC04 Offset: 0x37E7C04 VA: 0x37EBC04
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2BAC Offset: 0x26BEBAC VA: 0x26C2BAC
	|-GameObject.GetComponent<object>
	|
	|-RVA: 0x26C2C40 Offset: 0x26BEC40 VA: 0x26C2C40
	|-GameObject.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x37EBC40 Offset: 0x37E7C40 VA: 0x37EBC40
	public Component GetComponent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	// RVA: 0x37EBC84 Offset: 0x37E7C84 VA: 0x37EBC84
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x37EB594 Offset: 0x37E7594 VA: 0x37EB594
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x37EBCD8 Offset: 0x37E7CD8 VA: 0x37EBCD8
	public Component GetComponentInChildren(Type type) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2E10 Offset: 0x26BEE10 VA: 0x26C2E10
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x26C2E4C Offset: 0x26BEE4C VA: 0x26C2E4C
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2F54 Offset: 0x26BEF54 VA: 0x26C2F54
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x26C3024 Offset: 0x26BF024 VA: 0x26C3024
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37EBD20 Offset: 0x37E7D20 VA: 0x37EBD20
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x37EBD74 Offset: 0x37E7D74 VA: 0x37EBD74
	public Component GetComponentInParent(Type type) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C318C Offset: 0x26BF18C VA: 0x26C318C
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x26C31C8 Offset: 0x26BF1C8 VA: 0x26C31C8
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C32D0 Offset: 0x26BF2D0 VA: 0x26C32D0
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x26C33A0 Offset: 0x26BF3A0 VA: 0x26C33A0
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37EBDBC Offset: 0x37E7DBC VA: 0x37EBDBC
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C3508 Offset: 0x26BF508 VA: 0x26C3508
	|-GameObject.GetComponents<object>
	|
	|-RVA: 0x26C35DC Offset: 0x26BF5DC VA: 0x26C35DC
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: 0x37EBE40 Offset: 0x37E7E40 VA: 0x37EBE40
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x37EBE48 Offset: 0x37E7E48 VA: 0x37EBE48
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C372C Offset: 0x26BF72C VA: 0x26C372C
	|-GameObject.GetComponentsInChildren<object>
	|
	|-RVA: 0x26C380C Offset: 0x26BF80C VA: 0x26C380C
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C36B0 Offset: 0x26BF6B0 VA: 0x26C36B0
	|-GameObject.GetComponentsInChildren<object>
	|
	|-RVA: 0x26C36EC Offset: 0x26BF6EC VA: 0x26C36EC
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C38EC Offset: 0x26BF8EC VA: 0x26C38EC
	|-GameObject.TryGetComponent<object>
	|
	|-RVA: 0x26C399C Offset: 0x26BF99C VA: 0x26C399C
	|-GameObject.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	[NativeWritableSelf]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37EBEFC Offset: 0x37E7EFC VA: 0x37EBEFC
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x37EBF50 Offset: 0x37E7F50 VA: 0x37EBF50
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x37EC004 Offset: 0x37E8004 VA: 0x37EC004
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	// RVA: 0x37EC0B8 Offset: 0x37E80B8 VA: 0x37EC0B8
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRule(0)]
	// RVA: 0x37EC0FC Offset: 0x37E80FC VA: 0x37EC0FC
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2AC4 Offset: 0x26BEAC4 VA: 0x26C2AC4
	|-GameObject.AddComponent<object>
	*/

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	// RVA: 0x37EC140 Offset: 0x37E8140 VA: 0x37EC140
	public Transform get_transform() { }

	// RVA: 0x37EC17C Offset: 0x37E817C VA: 0x37EC17C
	public int get_layer() { }

	// RVA: 0x37EC1B8 Offset: 0x37E81B8 VA: 0x37EC1B8
	public void set_layer(int value) { }

	[NativeMethod(Name = "SetSelfActive")]
	// RVA: 0x37EC1FC Offset: 0x37E81FC VA: 0x37EC1FC
	public void SetActive(bool value) { }

	[NativeMethod(Name = "IsSelfActive")]
	// RVA: 0x37EC240 Offset: 0x37E8240 VA: 0x37EC240
	public bool get_activeSelf() { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x37EC27C Offset: 0x37E827C VA: 0x37EC27C
	public bool get_activeInHierarchy() { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	// RVA: 0x37EB658 Offset: 0x37E7658 VA: 0x37EB658
	public string get_tag() { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	// RVA: 0x37EC2B8 Offset: 0x37E82B8 VA: 0x37EC2B8
	public void set_tag(string value) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
	// RVA: 0x37EC2FC Offset: 0x37E82FC VA: 0x37EC2FC
	public static GameObject FindGameObjectWithTag(string tag) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x37EBFA8 Offset: 0x37E7FA8 VA: 0x37EBFA8
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	// RVA: 0x37EC338 Offset: 0x37E8338 VA: 0x37EC338
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocs]
	// RVA: 0x37EC390 Offset: 0x37E8390 VA: 0x37EC390
	public void SendMessage(string methodName) { }

	[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x37EC05C Offset: 0x37E805C VA: 0x37EC05C
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x37EC3DC Offset: 0x37E83DC VA: 0x37EC3DC
	public void .ctor(string name) { }

	// RVA: 0x37EC4B0 Offset: 0x37E84B0 VA: 0x37EC4B0
	public void .ctor() { }

	// RVA: 0x37EC534 Offset: 0x37E8534 VA: 0x37EC534
	public void .ctor(string name, Type[] components) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	// RVA: 0x37EC46C Offset: 0x37E846C VA: 0x37EC46C
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	// RVA: 0x37EC644 Offset: 0x37E8644 VA: 0x37EC644
	public static GameObject Find(string name) { }

	// RVA: 0x37EC680 Offset: 0x37E8680 VA: 0x37EC680
	public GameObject get_gameObject() { }
}
