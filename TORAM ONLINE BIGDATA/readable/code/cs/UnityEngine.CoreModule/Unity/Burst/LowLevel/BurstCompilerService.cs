// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Burst.LowLevel
[NativeHeader("Runtime/Burst/Burst.h")]
[StaticAccessor("BurstCompilerService::Get()", 1)]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
internal static class BurstCompilerService // TypeDefIndex: 16189
{
	// Methods

	[ThreadSafe]
	// RVA: 0x37CC200 Offset: 0x37C8200 VA: 0x37CC200
	public static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }
}
