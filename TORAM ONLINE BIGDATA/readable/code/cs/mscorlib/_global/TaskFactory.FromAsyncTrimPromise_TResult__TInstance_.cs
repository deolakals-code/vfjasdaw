// Assembly: mscorlib.dll
// Namespace: 
private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 9961
{
	// Fields
	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FFDF0 Offset: 0x29FBDF0 VA: 0x29FFDF0
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|
	|-RVA: 0x2A002B0 Offset: 0x29FC2B0 VA: 0x2A002B0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	|
	|-RVA: 0x2A00770 Offset: 0x29FC770 VA: 0x2A00770
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FFE3C Offset: 0x29FBE3C VA: 0x29FFE3C
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x2A002FC Offset: 0x29FC2FC VA: 0x2A002FC
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x2A007EC Offset: 0x29FC7EC VA: 0x2A007EC
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>.CompleteFromAsyncResult
	*/

	// RVA: -1 Offset: -1
	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A00070 Offset: 0x29FC070 VA: 0x2A00070
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x2A00530 Offset: 0x29FC530 VA: 0x2A00530
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	|
	|-RVA: 0x2A00B00 Offset: 0x29FCB00 VA: 0x2A00B00
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>.Complete
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A001DC Offset: 0x29FC1DC VA: 0x2A001DC
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x2A0069C Offset: 0x29FC69C VA: 0x2A0069C
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	|
	|-RVA: 0x2A00D68 Offset: 0x29FCD68 VA: 0x2A00D68
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>..cctor
	*/
}
