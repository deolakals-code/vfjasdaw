// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 9981
{
	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDDE60 Offset: 0x2CD9E60 VA: 0x2CDDE60
	|-UnwrapPromise<Int32Enum>..ctor
	|
	|-RVA: 0x2CDE84C Offset: 0x2CDA84C VA: 0x2CDE84C
	|-UnwrapPromise<object>..ctor
	|
	|-RVA: 0x2CDF238 Offset: 0x2CDB238 VA: 0x2CDF238
	|-UnwrapPromise<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CDFC24 Offset: 0x2CDBC24 VA: 0x2CDFC24
	|-UnwrapPromise<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE008 Offset: 0x2CDA008 VA: 0x2CDE008
	|-UnwrapPromise<Int32Enum>.Invoke
	|
	|-RVA: 0x2CDE9F4 Offset: 0x2CDA9F4 VA: 0x2CDE9F4
	|-UnwrapPromise<object>.Invoke
	|
	|-RVA: 0x2CDF3E0 Offset: 0x2CDB3E0 VA: 0x2CDF3E0
	|-UnwrapPromise<VoidTaskResult>.Invoke
	|
	|-RVA: 0x2CDFE04 Offset: 0x2CDBE04 VA: 0x2CDFE04
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE13C Offset: 0x2CDA13C VA: 0x2CDE13C
	|-UnwrapPromise<Int32Enum>.InvokeCore
	|
	|-RVA: 0x2CDEB28 Offset: 0x2CDAB28 VA: 0x2CDEB28
	|-UnwrapPromise<object>.InvokeCore
	|
	|-RVA: 0x2CDF514 Offset: 0x2CDB514 VA: 0x2CDF514
	|-UnwrapPromise<VoidTaskResult>.InvokeCore
	|
	|-RVA: 0x2CDFF40 Offset: 0x2CDBF40 VA: 0x2CDFF40
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE194 Offset: 0x2CDA194 VA: 0x2CDE194
	|-UnwrapPromise<Int32Enum>.InvokeCoreAsync
	|
	|-RVA: 0x2CDEB80 Offset: 0x2CDAB80 VA: 0x2CDEB80
	|-UnwrapPromise<object>.InvokeCoreAsync
	|
	|-RVA: 0x2CDF56C Offset: 0x2CDB56C VA: 0x2CDF56C
	|-UnwrapPromise<VoidTaskResult>.InvokeCoreAsync
	|
	|-RVA: 0x2CDFFEC Offset: 0x2CDBFEC VA: 0x2CDFFEC
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE300 Offset: 0x2CDA300 VA: 0x2CDE300
	|-UnwrapPromise<Int32Enum>.ProcessCompletedOuterTask
	|
	|-RVA: 0x2CDECEC Offset: 0x2CDACEC VA: 0x2CDECEC
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	|
	|-RVA: 0x2CDF6D8 Offset: 0x2CDB6D8 VA: 0x2CDF6D8
	|-UnwrapPromise<VoidTaskResult>.ProcessCompletedOuterTask
	|
	|-RVA: 0x2CE0174 Offset: 0x2CDC174 VA: 0x2CE0174
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE468 Offset: 0x2CDA468 VA: 0x2CDE468
	|-UnwrapPromise<Int32Enum>.TrySetFromTask
	|
	|-RVA: 0x2CDEE54 Offset: 0x2CDAE54 VA: 0x2CDEE54
	|-UnwrapPromise<object>.TrySetFromTask
	|
	|-RVA: 0x2CDF840 Offset: 0x2CDB840 VA: 0x2CDF840
	|-UnwrapPromise<VoidTaskResult>.TrySetFromTask
	|
	|-RVA: 0x2CE032C Offset: 0x2CDC32C VA: 0x2CE032C
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE7B8 Offset: 0x2CDA7B8 VA: 0x2CDE7B8
	|-UnwrapPromise<Int32Enum>.ProcessInnerTask
	|
	|-RVA: 0x2CDF1A4 Offset: 0x2CDB1A4 VA: 0x2CDF1A4
	|-UnwrapPromise<object>.ProcessInnerTask
	|
	|-RVA: 0x2CDFB90 Offset: 0x2CDBB90 VA: 0x2CDFB90
	|-UnwrapPromise<VoidTaskResult>.ProcessInnerTask
	|
	|-RVA: 0x2CE076C Offset: 0x2CDC76C VA: 0x2CE076C
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessInnerTask
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDE844 Offset: 0x2CDA844 VA: 0x2CDE844
	|-UnwrapPromise<Int32Enum>.get_InvokeMayRunArbitraryCode
	|
	|-RVA: 0x2CDF230 Offset: 0x2CDB230 VA: 0x2CDF230
	|-UnwrapPromise<object>.get_InvokeMayRunArbitraryCode
	|
	|-RVA: 0x2CDFC1C Offset: 0x2CDBC1C VA: 0x2CDFC1C
	|-UnwrapPromise<VoidTaskResult>.get_InvokeMayRunArbitraryCode
	|
	|-RVA: 0x2CE080C Offset: 0x2CDC80C VA: 0x2CE080C
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.get_InvokeMayRunArbitraryCode
	*/
}
