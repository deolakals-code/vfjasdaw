// Assembly: mscorlib.dll
// Namespace: System.Threading
public static class LazyInitializer // TypeDefIndex: 9858
{
	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C869C Offset: 0x26C469C VA: 0x26C869C
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8950 Offset: 0x26C4950 VA: 0x26C8950
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C86F0 Offset: 0x26C46F0 VA: 0x26C86F0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8A48 Offset: 0x26C4A48 VA: 0x26C8A48
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C87C8 Offset: 0x26C47C8 VA: 0x26C87C8
	|-LazyInitializer.EnsureInitialized<bool>
	|
	|-RVA: 0x26C884C Offset: 0x26C484C VA: 0x26C884C
	|-LazyInitializer.EnsureInitialized<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8C70 Offset: 0x26C4C70 VA: 0x26C8C70
	|-LazyInitializer.EnsureInitializedCore<bool>
	|
	|-RVA: 0x26C8DC4 Offset: 0x26C4DC4 VA: 0x26C8DC4
	|-LazyInitializer.EnsureInitializedCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8758 Offset: 0x26C4758 VA: 0x26C8758
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8AE4 Offset: 0x26C4AE4 VA: 0x26C8AE4
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: 0x3047290 Offset: 0x3043290 VA: 0x3047290
	private static object EnsureLockInitialized(ref object syncLock) { }
}
