// Assembly: Firebase.Platform.dll
// Namespace: Firebase
internal class ExceptionAggregator // TypeDefIndex: 17723
{
	// Fields
	[ThreadStatic]
	private static List<Exception> threadLocalExceptions; // 0x80000000

	// Properties
	private static List<Exception> Exceptions { get; }

	// Methods

	// RVA: 0x2667F94 Offset: 0x2663F94 VA: 0x2667F94
	private static List<Exception> get_Exceptions() { }

	// RVA: 0x2668044 Offset: 0x2664044 VA: 0x2668044
	public static Exception GetAndClearPendingExceptions() { }

	// RVA: 0x2668160 Offset: 0x2664160 VA: 0x2668160
	public static void ThrowAndClearPendingExceptions() { }

	// RVA: 0x2668194 Offset: 0x2664194 VA: 0x2668194
	public static Exception LogException(Exception exception) { }

	// RVA: 0x26687B4 Offset: 0x26647B4 VA: 0x26687B4
	public static void Wrap(Action action) { }

	// RVA: -1 Offset: -1
	public static T Wrap<T>(Func<T> func, T errorValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BF57C Offset: 0x26BB57C VA: 0x26BF57C
	|-ExceptionAggregator.Wrap<bool>
	|
	|-RVA: 0x26BF6B8 Offset: 0x26BB6B8 VA: 0x26BF6B8
	|-ExceptionAggregator.Wrap<__Il2CppFullySharedGenericType>
	*/
}
