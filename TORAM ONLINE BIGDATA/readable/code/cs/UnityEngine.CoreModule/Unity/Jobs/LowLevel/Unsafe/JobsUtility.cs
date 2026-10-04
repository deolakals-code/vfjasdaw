// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs.LowLevel.Unsafe
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[NativeHeader("Runtime/Jobs/JobSystem.h")]
public static class JobsUtility // TypeDefIndex: 16136
{
	// Fields
	internal static JobsUtility.PanicFunction_ PanicFunction; // 0x0

	// Methods

	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x37CB93C Offset: 0x37C793C VA: 0x37CB93C
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x37CB9A8 Offset: 0x37C79A8 VA: 0x37CB9A8
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[RequiredByNativeCode]
	// RVA: 0x37CBA08 Offset: 0x37C7A08 VA: 0x37CBA08
	private static void InvokePanicFunction() { }
}
