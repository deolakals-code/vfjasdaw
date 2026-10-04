// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
public class AsyncOperation : YieldInstruction // TypeDefIndex: 16329
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }

	// Methods

	[StaticAccessor("AsyncOperationBindings", 2)]
	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x37E9AFC Offset: 0x37E5AFC VA: 0x37E9AFC
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethod("IsDone")]
	// RVA: 0x37E9B38 Offset: 0x37E5B38 VA: 0x37E9B38
	public bool get_isDone() { }

	// RVA: 0x37E9B74 Offset: 0x37E5B74 VA: 0x37E9B74 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCode]
	// RVA: 0x37E9C30 Offset: 0x37E5C30 VA: 0x37E9C30
	internal void InvokeCompletionEvent() { }

	// RVA: 0x37E9C80 Offset: 0x37E5C80 VA: 0x37E9C80
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x37E9D7C Offset: 0x37E5D7C VA: 0x37E9D7C
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x37E9600 Offset: 0x37E5600 VA: 0x37E9600
	public void .ctor() { }
}
