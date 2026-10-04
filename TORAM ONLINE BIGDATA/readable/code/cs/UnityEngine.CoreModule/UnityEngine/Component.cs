// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
public class Component : Object // TypeDefIndex: 16349
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public string tag { get; }

	// Methods

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37EB440 Offset: 0x37E7440 VA: 0x37EB440
	public Transform get_transform() { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	// RVA: 0x37EB47C Offset: 0x37E747C VA: 0x37EB47C
	public GameObject get_gameObject() { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37EB4B8 Offset: 0x37E74B8 VA: 0x37EB4B8
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1654 Offset: 0x27DD654 VA: 0x27E1654
	|-Component.GetComponent<object>
	|
	|-RVA: 0x27E16E8 Offset: 0x27DD6E8 VA: 0x27E16E8
	|-Component.GetComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1EC4 Offset: 0x27DDEC4 VA: 0x27E1EC4
	|-Component.TryGetComponent<object>
	|
	|-RVA: 0x27E1F14 Offset: 0x27DDF14 VA: 0x27E1F14
	|-Component.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x37EB50C Offset: 0x37E750C VA: 0x37EB50C
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1AD8 Offset: 0x27DDAD8 VA: 0x27E1AD8
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0x27E1BA8 Offset: 0x27DDBA8 VA: 0x27E1BA8
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E18B8 Offset: 0x27DD8B8 VA: 0x27E18B8
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0x27E197C Offset: 0x27DD97C VA: 0x27E197C
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1E20 Offset: 0x27DDE20 VA: 0x27E1E20
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x27E1E70 Offset: 0x27DDE70 VA: 0x27E1E70
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1DA4 Offset: 0x27DDDA4 VA: 0x27E1DA4
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x27E1DE0 Offset: 0x27DDDE0 VA: 0x27E1DE0
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37EB5E8 Offset: 0x37E75E8 VA: 0x37EB5E8
	public string get_tag() { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1D10 Offset: 0x27DDD10 VA: 0x27E1D10
	|-Component.GetComponents<object>
	|
	|-RVA: 0x27E1D58 Offset: 0x27DDD58 VA: 0x27E1D58
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37EB694 Offset: 0x37E7694 VA: 0x37EB694
	public void SendMessage(string methodName, object value) { }

	// RVA: 0x37EB748 Offset: 0x37E7748 VA: 0x37EB748
	public void SendMessage(string methodName) { }

	[FreeFunction("SendMessage", HasExplicitThis = True)]
	// RVA: 0x37EB6EC Offset: 0x37E76EC VA: 0x37EB6EC
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x37EB794 Offset: 0x37E7794 VA: 0x37EB794
	public void SendMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	// RVA: 0x37EB7EC Offset: 0x37E77EC VA: 0x37EB7EC
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x37EB848 Offset: 0x37E7848 VA: 0x37EB848
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x37EA9D0 Offset: 0x37E69D0 VA: 0x37EA9D0
	public void .ctor() { }
}
