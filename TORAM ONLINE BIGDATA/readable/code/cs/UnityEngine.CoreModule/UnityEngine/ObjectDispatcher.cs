// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[RequiredByNativeCode]
[StaticAccessor("GetObjectDispatcher()", 0)]
internal sealed class ObjectDispatcher // TypeDefIndex: 16311
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch; // 0x0
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x37E8390 Offset: 0x37E4390 VA: 0x37E8390
	private static void .cctor() { }
}
