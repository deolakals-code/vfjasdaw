// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
internal sealed class NoAllocHelpers // TypeDefIndex: 16361
{
	// Methods

	// RVA: 0x37ED89C Offset: 0x37E989C VA: 0x37ED89C
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DCF90 Offset: 0x26D8F90 VA: 0x26DCF90
	|-NoAllocHelpers.SafeLength<Color>
	|
	|-RVA: 0x26DCFC4 Offset: 0x26D8FC4 VA: 0x26DCFC4
	|-NoAllocHelpers.SafeLength<Vector2>
	|
	|-RVA: 0x26DCFF8 Offset: 0x26D8FF8 VA: 0x26DCFF8
	|-NoAllocHelpers.SafeLength<Vector3>
	|
	|-RVA: 0x26DD02C Offset: 0x26D902C VA: 0x26DD02C
	|-NoAllocHelpers.SafeLength<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
	// RVA: 0x37ED8AC Offset: 0x37E98AC VA: 0x37ED8AC
	public static Array ExtractArrayFromList(object list) { }
}
