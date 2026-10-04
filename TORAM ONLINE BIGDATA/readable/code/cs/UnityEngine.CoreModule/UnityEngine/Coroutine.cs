// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/Coroutine.h")]
public sealed class Coroutine : YieldInstruction // TypeDefIndex: 16350
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x37EB8A8 Offset: 0x37E78A8 VA: 0x37EB8A8
	private void .ctor() { }

	// RVA: 0x37EB8B0 Offset: 0x37E78B0 VA: 0x37EB8B0 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	// RVA: 0x37EB96C Offset: 0x37E796C VA: 0x37EB96C
	private static void ReleaseCoroutine(IntPtr ptr) { }
}
