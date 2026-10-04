// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Profiling
[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
public sealed class Profiler // TypeDefIndex: 16410
{
	// Methods

	[Obsolete("GetTotalUnusedReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalUnusedReservedMemoryLong() instead.")]
	// RVA: 0x37F4570 Offset: 0x37F0570 VA: 0x37F4570
	public static uint GetTotalUnusedReservedMemory() { }

	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalUnusedReservedMemory")]
	[StaticAccessor("GetMemoryManager()", 0)]
	// RVA: 0x37F45A0 Offset: 0x37F05A0 VA: 0x37F45A0
	public static long GetTotalUnusedReservedMemoryLong() { }
}
