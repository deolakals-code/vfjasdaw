// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[ExtensionOfNativeClass]
[NativeClass(null)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class ScriptableObject : Object // TypeDefIndex: 16364
{
	// Methods

	// RVA: 0x37ED920 Offset: 0x37E9920 VA: 0x37ED920
	public void .ctor() { }

	// RVA: 0x37ED9DC Offset: 0x37E99DC VA: 0x37ED9DC
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EE724 Offset: 0x26EA724 VA: 0x26EE724
	|-ScriptableObject.CreateInstance<object>
	*/

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x37ED9A0 Offset: 0x37E99A0 VA: 0x37ED9A0
	private static void CreateScriptableObject(ScriptableObject self) { }

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x37EDA1C Offset: 0x37E9A1C VA: 0x37EDA1C
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }
}
