// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
internal static class AsyncTaskCache // TypeDefIndex: 10528
{
	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0x2F21974 Offset: 0x2F1D974 VA: 0x2F21974
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27D6FD8 Offset: 0x27D2FD8 VA: 0x27D6FD8
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|
	|-RVA: 0x27D7040 Offset: 0x27D3040 VA: 0x27D7040
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<bool, object>>
	|
	|-RVA: 0x27D70B0 Offset: 0x27D30B0 VA: 0x27D70B0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, object, int>>
	|
	|-RVA: 0x27D7140 Offset: 0x27D3140 VA: 0x27D7140
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, bool, bool, object, object>>
	|
	|-RVA: 0x27D71C0 Offset: 0x27D31C0 VA: 0x27D71C0
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0x27D7228 Offset: 0x27D3228 VA: 0x27D7228
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0x27D7290 Offset: 0x27D3290 VA: 0x27D7290
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0x27D72F8 Offset: 0x27D32F8 VA: 0x27D72F8
	|-AsyncTaskCache.CreateCacheableTask<SerializableProjectConfiguration>
	|
	|-RVA: 0x27D7368 Offset: 0x27D3368 VA: 0x27D7368
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	|
	|-RVA: 0x27D73D0 Offset: 0x27D33D0 VA: 0x27D73D0
	|-AsyncTaskCache.CreateCacheableTask<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F21A94 Offset: 0x2F1DA94 VA: 0x2F21A94
	private static void .cctor() { }
}
