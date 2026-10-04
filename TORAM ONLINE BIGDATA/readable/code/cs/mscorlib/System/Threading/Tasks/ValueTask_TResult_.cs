// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[IsReadOnly]
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<TResult>))]
public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 9955
{
	// Fields
	private static Task<TResult> s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05794 Offset: 0x2D01794 VA: 0x2D05794
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x2D063E8 Offset: 0x2D023E8 VA: 0x2D063E8
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D057C0 Offset: 0x2D017C0 VA: 0x2D057C0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x2D06590 Offset: 0x2D02590 VA: 0x2D06590
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05808 Offset: 0x2D01808 VA: 0x2D05808
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x2D066A0 Offset: 0x2D026A0 VA: 0x2D066A0
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05854 Offset: 0x2D01854 VA: 0x2D05854
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0x2D067B4 Offset: 0x2D027B4 VA: 0x2D067B4
	|-ValueTask<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D058A4 Offset: 0x2D018A4 VA: 0x2D058A4
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x2D06A24 Offset: 0x2D02A24 VA: 0x2D06A24
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05988 Offset: 0x2D01988 VA: 0x2D05988
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x2D06B70 Offset: 0x2D02B70 VA: 0x2D06B70
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> AsTask() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05A10 Offset: 0x2D01A10 VA: 0x2D05A10
	|-ValueTask<int>.AsTask
	|
	|-RVA: 0x2D06F2C Offset: 0x2D02F2C VA: 0x2D06F2C
	|-ValueTask<__Il2CppFullySharedGenericType>.AsTask
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05B0C Offset: 0x2D01B0C VA: 0x2D05B0C
	|-ValueTask<int>.GetTaskForValueTaskSource
	|
	|-RVA: 0x2D071C0 Offset: 0x2D031C0 VA: 0x2D071C0
	|-ValueTask<__Il2CppFullySharedGenericType>.GetTaskForValueTaskSource
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D05F78 Offset: 0x2D01F78 VA: 0x2D05F78
	|-ValueTask<int>.get_IsCompleted
	|
	|-RVA: 0x2D07880 Offset: 0x2D03880 VA: 0x2D07880
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D06094 Offset: 0x2D02094 VA: 0x2D06094
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x2D079F8 Offset: 0x2D039F8 VA: 0x2D079F8
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D061B0 Offset: 0x2D021B0 VA: 0x2D061B0
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0x2D07B70 Offset: 0x2D03B70 VA: 0x2D07B70
	|-ValueTask<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D062DC Offset: 0x2D022DC VA: 0x2D062DC
	|-ValueTask<int>.GetAwaiter
	|
	|-RVA: 0x2D07E14 Offset: 0x2D03E14 VA: 0x2D07E14
	|-ValueTask<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D06324 Offset: 0x2D02324 VA: 0x2D06324
	|-ValueTask<int>.ToString
	|
	|-RVA: 0x2D07F78 Offset: 0x2D03F78 VA: 0x2D07F78
	|-ValueTask<__Il2CppFullySharedGenericType>.ToString
	*/
}
