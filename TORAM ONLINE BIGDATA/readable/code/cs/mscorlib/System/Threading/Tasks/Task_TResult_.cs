// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<TResult>))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
public class Task<TResult> : Task // TypeDefIndex: 9959
{
	// Fields
	internal TResult m_result; // 0x0
	private static TaskFactory<TResult> s_defaultFactory; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD614 Offset: 0x2CA9614 VA: 0x2CAD614
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE21C Offset: 0x2CAA21C VA: 0x2CAE21C
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAEEA0 Offset: 0x2CAAEA0 VA: 0x2CAEEA0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFB98 Offset: 0x2CABB98 VA: 0x2CAFB98
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB0840 Offset: 0x2CAC840 VA: 0x2CB0840
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB1460 Offset: 0x2CAD460 VA: 0x2CB1460
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB2068 Offset: 0x2CAE068 VA: 0x2CB2068
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2C70 Offset: 0x2CAEC70 VA: 0x2CB2C70
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB38C4 Offset: 0x2CAF8C4 VA: 0x2CB38C4
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB4548 Offset: 0x2CB0548 VA: 0x2CB4548
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB5154 Offset: 0x2CB1154 VA: 0x2CB5154
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD66C Offset: 0x2CA966C VA: 0x2CAD66C
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE274 Offset: 0x2CAA274 VA: 0x2CAE274
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAEEF8 Offset: 0x2CAAEF8 VA: 0x2CAEEF8
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFBF0 Offset: 0x2CABBF0 VA: 0x2CAFBF0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB0898 Offset: 0x2CAC898 VA: 0x2CB0898
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB14B8 Offset: 0x2CAD4B8 VA: 0x2CB14B8
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB20C0 Offset: 0x2CAE0C0 VA: 0x2CB20C0
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2CC8 Offset: 0x2CAECC8 VA: 0x2CB2CC8
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB391C Offset: 0x2CAF91C VA: 0x2CB391C
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB45A0 Offset: 0x2CB05A0 VA: 0x2CB45A0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB51AC Offset: 0x2CB11AC VA: 0x2CB51AC
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD6E0 Offset: 0x2CA96E0 VA: 0x2CAD6E0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE2E8 Offset: 0x2CAA2E8 VA: 0x2CAE2E8
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAEF6C Offset: 0x2CAAF6C VA: 0x2CAEF6C
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFC64 Offset: 0x2CABC64 VA: 0x2CAFC64
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB090C Offset: 0x2CAC90C VA: 0x2CB090C
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB152C Offset: 0x2CAD52C VA: 0x2CB152C
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB2134 Offset: 0x2CAE134 VA: 0x2CB2134
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2D3C Offset: 0x2CAED3C VA: 0x2CB2D3C
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB3990 Offset: 0x2CAF990 VA: 0x2CB3990
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB4614 Offset: 0x2CB0614 VA: 0x2CB4614
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB5220 Offset: 0x2CB1220 VA: 0x2CB5220
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD758 Offset: 0x2CA9758 VA: 0x2CAD758
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE370 Offset: 0x2CAA370 VA: 0x2CAE370
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAEFF8 Offset: 0x2CAAFF8 VA: 0x2CAEFF8
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFCE8 Offset: 0x2CABCE8 VA: 0x2CAFCE8
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB0988 Offset: 0x2CAC988 VA: 0x2CB0988
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB15A4 Offset: 0x2CAD5A4 VA: 0x2CB15A4
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB21AC Offset: 0x2CAE1AC VA: 0x2CB21AC
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2DBC Offset: 0x2CAEDBC VA: 0x2CB2DBC
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB3A18 Offset: 0x2CAFA18 VA: 0x2CB3A18
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB468C Offset: 0x2CB068C VA: 0x2CB468C
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB5340 Offset: 0x2CB1340 VA: 0x2CB5340
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD7E8 Offset: 0x2CA97E8 VA: 0x2CAD7E8
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE430 Offset: 0x2CAA430 VA: 0x2CAE430
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAF0B0 Offset: 0x2CAB0B0 VA: 0x2CAF0B0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFD98 Offset: 0x2CABD98 VA: 0x2CAFD98
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB0A1C Offset: 0x2CACA1C VA: 0x2CB0A1C
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB1634 Offset: 0x2CAD634 VA: 0x2CB1634
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB223C Offset: 0x2CAE23C VA: 0x2CB223C
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2E68 Offset: 0x2CAEE68 VA: 0x2CB2E68
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB3AD8 Offset: 0x2CAFAD8 VA: 0x2CB3AD8
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB471C Offset: 0x2CB071C VA: 0x2CB471C
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB5478 Offset: 0x2CB1478 VA: 0x2CB5478
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD890 Offset: 0x2CA9890 VA: 0x2CAD890
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE4D8 Offset: 0x2CAA4D8 VA: 0x2CAE4D8
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAF158 Offset: 0x2CAB158 VA: 0x2CAF158
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFE40 Offset: 0x2CABE40 VA: 0x2CAFE40
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB0AC4 Offset: 0x2CACAC4 VA: 0x2CB0AC4
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB16DC Offset: 0x2CAD6DC VA: 0x2CB16DC
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB22E4 Offset: 0x2CAE2E4 VA: 0x2CB22E4
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2F10 Offset: 0x2CAEF10 VA: 0x2CB2F10
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB3B80 Offset: 0x2CAFB80 VA: 0x2CB3B80
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB47C4 Offset: 0x2CB07C4 VA: 0x2CB47C4
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB5540 Offset: 0x2CB1540 VA: 0x2CB5540
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD940 Offset: 0x2CA9940 VA: 0x2CAD940
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2CAE588 Offset: 0x2CAA588 VA: 0x2CAE588
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CAF208 Offset: 0x2CAB208 VA: 0x2CAF208
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CAFEF0 Offset: 0x2CABEF0 VA: 0x2CAFEF0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CB0B74 Offset: 0x2CACB74 VA: 0x2CB0B74
	|-Task<bool>..ctor
	|
	|-RVA: 0x2CB178C Offset: 0x2CAD78C VA: 0x2CB178C
	|-Task<int>..ctor
	|
	|-RVA: 0x2CB2394 Offset: 0x2CAE394 VA: 0x2CB2394
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0x2CB2FC0 Offset: 0x2CAEFC0 VA: 0x2CB2FC0
	|-Task<object>..ctor
	|
	|-RVA: 0x2CB3C30 Offset: 0x2CAFC30 VA: 0x2CB3C30
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CB4874 Offset: 0x2CB0874 VA: 0x2CB4874
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CB55F0 Offset: 0x2CB15F0 VA: 0x2CB55F0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9F0 Offset: 0x2CA99F0 VA: 0x2CAD9F0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x2CAE638 Offset: 0x2CAA638 VA: 0x2CAE638
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x2CAF2B8 Offset: 0x2CAB2B8 VA: 0x2CAF2B8
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x2CAFFA0 Offset: 0x2CABFA0 VA: 0x2CAFFA0
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x2CB0C24 Offset: 0x2CACC24 VA: 0x2CB0C24
	|-Task<bool>.StartNew
	|
	|-RVA: 0x2CB183C Offset: 0x2CAD83C VA: 0x2CB183C
	|-Task<int>.StartNew
	|
	|-RVA: 0x2CB2444 Offset: 0x2CAE444 VA: 0x2CB2444
	|-Task<Int32Enum>.StartNew
	|
	|-RVA: 0x2CB3070 Offset: 0x2CAF070 VA: 0x2CB3070
	|-Task<object>.StartNew
	|
	|-RVA: 0x2CB3CE0 Offset: 0x2CAFCE0 VA: 0x2CB3CE0
	|-Task<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0x2CB4924 Offset: 0x2CB0924 VA: 0x2CB4924
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x2CB56A0 Offset: 0x2CB16A0 VA: 0x2CB56A0
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB18 Offset: 0x2CA9B18 VA: 0x2CADB18
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x2CAE760 Offset: 0x2CAA760 VA: 0x2CAE760
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x2CAF3E0 Offset: 0x2CAB3E0 VA: 0x2CAF3E0
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x2CB00C8 Offset: 0x2CAC0C8 VA: 0x2CB00C8
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x2CB0D4C Offset: 0x2CACD4C VA: 0x2CB0D4C
	|-Task<bool>.StartNew
	|
	|-RVA: 0x2CB1964 Offset: 0x2CAD964 VA: 0x2CB1964
	|-Task<int>.StartNew
	|
	|-RVA: 0x2CB256C Offset: 0x2CAE56C VA: 0x2CB256C
	|-Task<Int32Enum>.StartNew
	|
	|-RVA: 0x2CB3198 Offset: 0x2CAF198 VA: 0x2CB3198
	|-Task<object>.StartNew
	|
	|-RVA: 0x2CB3E08 Offset: 0x2CAFE08 VA: 0x2CB3E08
	|-Task<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0x2CB4A4C Offset: 0x2CB0A4C VA: 0x2CB4A4C
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x2CB5808 Offset: 0x2CB1808 VA: 0x2CB5808
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADC50 Offset: 0x2CA9C50 VA: 0x2CADC50
	|-Task<Nullable<int>>.TrySetResult
	|
	|-RVA: 0x2CAE898 Offset: 0x2CAA898 VA: 0x2CAE898
	|-Task<ValueTuple<bool, object>>.TrySetResult
	|
	|-RVA: 0x2CAF518 Offset: 0x2CAB518 VA: 0x2CAF518
	|-Task<ValueTuple<object, object, int>>.TrySetResult
	|
	|-RVA: 0x2CB0200 Offset: 0x2CAC200 VA: 0x2CB0200
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetResult
	|
	|-RVA: 0x2CB0E84 Offset: 0x2CACE84 VA: 0x2CB0E84
	|-Task<bool>.TrySetResult
	|
	|-RVA: 0x2CB1A9C Offset: 0x2CADA9C VA: 0x2CB1A9C
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x2CB26A4 Offset: 0x2CAE6A4 VA: 0x2CB26A4
	|-Task<Int32Enum>.TrySetResult
	|
	|-RVA: 0x2CB32D0 Offset: 0x2CAF2D0 VA: 0x2CB32D0
	|-Task<object>.TrySetResult
	|
	|-RVA: 0x2CB3F40 Offset: 0x2CAFF40 VA: 0x2CB3F40
	|-Task<SerializableProjectConfiguration>.TrySetResult
	|
	|-RVA: 0x2CB4B84 Offset: 0x2CB0B84 VA: 0x2CB4B84
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x2CB598C Offset: 0x2CB198C VA: 0x2CB598C
	|-Task<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADCEC Offset: 0x2CA9CEC VA: 0x2CADCEC
	|-Task<Nullable<int>>.DangerousSetResult
	|
	|-RVA: 0x2CAE948 Offset: 0x2CAA948 VA: 0x2CAE948
	|-Task<ValueTuple<bool, object>>.DangerousSetResult
	|
	|-RVA: 0x2CAF5CC Offset: 0x2CAB5CC VA: 0x2CAF5CC
	|-Task<ValueTuple<object, object, int>>.DangerousSetResult
	|
	|-RVA: 0x2CB02AC Offset: 0x2CAC2AC VA: 0x2CB02AC
	|-Task<ValueTuple<object, bool, bool, object, object>>.DangerousSetResult
	|
	|-RVA: 0x2CB0F24 Offset: 0x2CACF24 VA: 0x2CB0F24
	|-Task<bool>.DangerousSetResult
	|
	|-RVA: 0x2CB1B38 Offset: 0x2CADB38 VA: 0x2CB1B38
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x2CB2740 Offset: 0x2CAE740 VA: 0x2CB2740
	|-Task<Int32Enum>.DangerousSetResult
	|
	|-RVA: 0x2CB3378 Offset: 0x2CAF378 VA: 0x2CB3378
	|-Task<object>.DangerousSetResult
	|
	|-RVA: 0x2CB3FF0 Offset: 0x2CAFFF0 VA: 0x2CB3FF0
	|-Task<SerializableProjectConfiguration>.DangerousSetResult
	|
	|-RVA: 0x2CB4C20 Offset: 0x2CB0C20 VA: 0x2CB4C20
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x2CB5AD0 Offset: 0x2CB1AD0 VA: 0x2CB5AD0
	|-Task<__Il2CppFullySharedGenericType>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADD34 Offset: 0x2CA9D34 VA: 0x2CADD34
	|-Task<Nullable<int>>.get_Result
	|
	|-RVA: 0x2CAE9A0 Offset: 0x2CAA9A0 VA: 0x2CAE9A0
	|-Task<ValueTuple<bool, object>>.get_Result
	|
	|-RVA: 0x2CAF644 Offset: 0x2CAB644 VA: 0x2CAF644
	|-Task<ValueTuple<object, object, int>>.get_Result
	|
	|-RVA: 0x2CB0314 Offset: 0x2CAC314 VA: 0x2CB0314
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Result
	|
	|-RVA: 0x2CB0F74 Offset: 0x2CACF74 VA: 0x2CB0F74
	|-Task<bool>.get_Result
	|
	|-RVA: 0x2CB1B80 Offset: 0x2CADB80 VA: 0x2CB1B80
	|-Task<int>.get_Result
	|
	|-RVA: 0x2CB2788 Offset: 0x2CAE788 VA: 0x2CB2788
	|-Task<Int32Enum>.get_Result
	|
	|-RVA: 0x2CB33C8 Offset: 0x2CAF3C8 VA: 0x2CB33C8
	|-Task<object>.get_Result
	|
	|-RVA: 0x2CB4048 Offset: 0x2CB0048 VA: 0x2CB4048
	|-Task<SerializableProjectConfiguration>.get_Result
	|
	|-RVA: 0x2CB4C6C Offset: 0x2CB0C6C VA: 0x2CB4C6C
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x2CB5BD8 Offset: 0x2CB1BD8 VA: 0x2CB5BD8
	|-Task<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADD88 Offset: 0x2CA9D88 VA: 0x2CADD88
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|
	|-RVA: 0x2CAE9F0 Offset: 0x2CAA9F0 VA: 0x2CAE9F0
	|-Task<ValueTuple<bool, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x2CAF6B8 Offset: 0x2CAB6B8 VA: 0x2CAF6B8
	|-Task<ValueTuple<object, object, int>>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB037C Offset: 0x2CAC37C VA: 0x2CB037C
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB0FC8 Offset: 0x2CACFC8 VA: 0x2CB0FC8
	|-Task<bool>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB1BD4 Offset: 0x2CADBD4 VA: 0x2CB1BD4
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB27DC Offset: 0x2CAE7DC VA: 0x2CB27DC
	|-Task<Int32Enum>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB341C Offset: 0x2CAF41C VA: 0x2CB341C
	|-Task<object>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB4098 Offset: 0x2CB0098 VA: 0x2CB4098
	|-Task<SerializableProjectConfiguration>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB4CC0 Offset: 0x2CB0CC0 VA: 0x2CB4CC0
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x2CB5CEC Offset: 0x2CB1CEC VA: 0x2CB5CEC
	|-Task<__Il2CppFullySharedGenericType>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADD90 Offset: 0x2CA9D90 VA: 0x2CADD90
	|-Task<Nullable<int>>.GetResultCore
	|
	|-RVA: 0x2CAE9FC Offset: 0x2CAA9FC VA: 0x2CAE9FC
	|-Task<ValueTuple<bool, object>>.GetResultCore
	|
	|-RVA: 0x2CAF6CC Offset: 0x2CAB6CC VA: 0x2CAF6CC
	|-Task<ValueTuple<object, object, int>>.GetResultCore
	|
	|-RVA: 0x2CB0388 Offset: 0x2CAC388 VA: 0x2CB0388
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetResultCore
	|
	|-RVA: 0x2CB0FD0 Offset: 0x2CACFD0 VA: 0x2CB0FD0
	|-Task<bool>.GetResultCore
	|
	|-RVA: 0x2CB1BDC Offset: 0x2CADBDC VA: 0x2CB1BDC
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x2CB27E4 Offset: 0x2CAE7E4 VA: 0x2CB27E4
	|-Task<Int32Enum>.GetResultCore
	|
	|-RVA: 0x2CB3424 Offset: 0x2CAF424 VA: 0x2CB3424
	|-Task<object>.GetResultCore
	|
	|-RVA: 0x2CB40A4 Offset: 0x2CB00A4 VA: 0x2CB40A4
	|-Task<SerializableProjectConfiguration>.GetResultCore
	|
	|-RVA: 0x2CB4CC8 Offset: 0x2CB0CC8 VA: 0x2CB4CC8
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x2CB5D84 Offset: 0x2CB1D84 VA: 0x2CB5D84
	|-Task<__Il2CppFullySharedGenericType>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADE08 Offset: 0x2CA9E08 VA: 0x2CADE08
	|-Task<Nullable<int>>.get_Factory
	|
	|-RVA: 0x2CAEA74 Offset: 0x2CAAA74 VA: 0x2CAEA74
	|-Task<ValueTuple<bool, object>>.get_Factory
	|
	|-RVA: 0x2CAF754 Offset: 0x2CAB754 VA: 0x2CAF754
	|-Task<ValueTuple<object, object, int>>.get_Factory
	|
	|-RVA: 0x2CB0408 Offset: 0x2CAC408 VA: 0x2CB0408
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Factory
	|
	|-RVA: 0x2CB1048 Offset: 0x2CAD048 VA: 0x2CB1048
	|-Task<bool>.get_Factory
	|
	|-RVA: 0x2CB1C54 Offset: 0x2CADC54 VA: 0x2CB1C54
	|-Task<int>.get_Factory
	|
	|-RVA: 0x2CB285C Offset: 0x2CAE85C VA: 0x2CB285C
	|-Task<Int32Enum>.get_Factory
	|
	|-RVA: 0x2CB349C Offset: 0x2CAF49C VA: 0x2CB349C
	|-Task<object>.get_Factory
	|
	|-RVA: 0x2CB411C Offset: 0x2CB011C VA: 0x2CB411C
	|-Task<SerializableProjectConfiguration>.get_Factory
	|
	|-RVA: 0x2CB4D40 Offset: 0x2CB0D40 VA: 0x2CB4D40
	|-Task<VoidTaskResult>.get_Factory
	|
	|-RVA: 0x2CB5EA0 Offset: 0x2CB1EA0 VA: 0x2CB5EA0
	|-Task<__Il2CppFullySharedGenericType>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADF08 Offset: 0x2CA9F08 VA: 0x2CADF08
	|-Task<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x2CAEB74 Offset: 0x2CAAB74 VA: 0x2CAEB74
	|-Task<ValueTuple<bool, object>>.InnerInvoke
	|
	|-RVA: 0x2CAF854 Offset: 0x2CAB854 VA: 0x2CAF854
	|-Task<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x2CB0508 Offset: 0x2CAC508 VA: 0x2CB0508
	|-Task<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x2CB1148 Offset: 0x2CAD148 VA: 0x2CB1148
	|-Task<bool>.InnerInvoke
	|
	|-RVA: 0x2CB1D54 Offset: 0x2CADD54 VA: 0x2CB1D54
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x2CB295C Offset: 0x2CAE95C VA: 0x2CB295C
	|-Task<Int32Enum>.InnerInvoke
	|
	|-RVA: 0x2CB359C Offset: 0x2CAF59C VA: 0x2CB359C
	|-Task<object>.InnerInvoke
	|
	|-RVA: 0x2CB421C Offset: 0x2CB021C VA: 0x2CB421C
	|-Task<SerializableProjectConfiguration>.InnerInvoke
	|
	|-RVA: 0x2CB4E40 Offset: 0x2CB0E40 VA: 0x2CB4E40
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x2CB5FCC Offset: 0x2CB1FCC VA: 0x2CB5FCC
	|-Task<__Il2CppFullySharedGenericType>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADFB8 Offset: 0x2CA9FB8 VA: 0x2CADFB8
	|-Task<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x2CAEC3C Offset: 0x2CAAC3C VA: 0x2CAEC3C
	|-Task<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x2CAF934 Offset: 0x2CAB934 VA: 0x2CAF934
	|-Task<ValueTuple<object, object, int>>.GetAwaiter
	|
	|-RVA: 0x2CB05DC Offset: 0x2CAC5DC VA: 0x2CB05DC
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|
	|-RVA: 0x2CB11FC Offset: 0x2CAD1FC VA: 0x2CB11FC
	|-Task<bool>.GetAwaiter
	|
	|-RVA: 0x2CB1E04 Offset: 0x2CADE04 VA: 0x2CB1E04
	|-Task<int>.GetAwaiter
	|
	|-RVA: 0x2CB2A0C Offset: 0x2CAEA0C VA: 0x2CB2A0C
	|-Task<Int32Enum>.GetAwaiter
	|
	|-RVA: 0x2CB3660 Offset: 0x2CAF660 VA: 0x2CB3660
	|-Task<object>.GetAwaiter
	|
	|-RVA: 0x2CB42E4 Offset: 0x2CB02E4 VA: 0x2CB42E4
	|-Task<SerializableProjectConfiguration>.GetAwaiter
	|
	|-RVA: 0x2CB4EF0 Offset: 0x2CB0EF0 VA: 0x2CB4EF0
	|-Task<VoidTaskResult>.GetAwaiter
	|
	|-RVA: 0x2CB6108 Offset: 0x2CB2108 VA: 0x2CB6108
	|-Task<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADFD8 Offset: 0x2CA9FD8 VA: 0x2CADFD8
	|-Task<Nullable<int>>.ConfigureAwait
	|
	|-RVA: 0x2CAEC5C Offset: 0x2CAAC5C VA: 0x2CAEC5C
	|-Task<ValueTuple<bool, object>>.ConfigureAwait
	|
	|-RVA: 0x2CAF954 Offset: 0x2CAB954 VA: 0x2CAF954
	|-Task<ValueTuple<object, object, int>>.ConfigureAwait
	|
	|-RVA: 0x2CB05FC Offset: 0x2CAC5FC VA: 0x2CB05FC
	|-Task<ValueTuple<object, bool, bool, object, object>>.ConfigureAwait
	|
	|-RVA: 0x2CB121C Offset: 0x2CAD21C VA: 0x2CB121C
	|-Task<bool>.ConfigureAwait
	|
	|-RVA: 0x2CB1E24 Offset: 0x2CADE24 VA: 0x2CB1E24
	|-Task<int>.ConfigureAwait
	|
	|-RVA: 0x2CB2A2C Offset: 0x2CAEA2C VA: 0x2CB2A2C
	|-Task<Int32Enum>.ConfigureAwait
	|
	|-RVA: 0x2CB3680 Offset: 0x2CAF680 VA: 0x2CB3680
	|-Task<object>.ConfigureAwait
	|
	|-RVA: 0x2CB4304 Offset: 0x2CB0304 VA: 0x2CB4304
	|-Task<SerializableProjectConfiguration>.ConfigureAwait
	|
	|-RVA: 0x2CB4F10 Offset: 0x2CB0F10 VA: 0x2CB4F10
	|-Task<VoidTaskResult>.ConfigureAwait
	|
	|-RVA: 0x2CB6128 Offset: 0x2CB2128 VA: 0x2CB6128
	|-Task<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE014 Offset: 0x2CAA014 VA: 0x2CAE014
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x2CAEC98 Offset: 0x2CAAC98 VA: 0x2CAEC98
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x2CAF990 Offset: 0x2CAB990 VA: 0x2CAF990
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x2CB0638 Offset: 0x2CAC638 VA: 0x2CB0638
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x2CB1258 Offset: 0x2CAD258 VA: 0x2CB1258
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x2CB1E60 Offset: 0x2CADE60 VA: 0x2CB1E60
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x2CB2A68 Offset: 0x2CAEA68 VA: 0x2CB2A68
	|-Task<Int32Enum>.ContinueWith
	|
	|-RVA: 0x2CB36BC Offset: 0x2CAF6BC VA: 0x2CB36BC
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x2CB4340 Offset: 0x2CB0340 VA: 0x2CB4340
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x2CB4F4C Offset: 0x2CB0F4C VA: 0x2CB4F4C
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x2CB6164 Offset: 0x2CB2164 VA: 0x2CB6164
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE09C Offset: 0x2CAA09C VA: 0x2CAE09C
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x2CAED20 Offset: 0x2CAAD20 VA: 0x2CAED20
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x2CAFA18 Offset: 0x2CABA18 VA: 0x2CAFA18
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x2CB06C0 Offset: 0x2CAC6C0 VA: 0x2CB06C0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x2CB12E0 Offset: 0x2CAD2E0 VA: 0x2CB12E0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x2CB1EE8 Offset: 0x2CADEE8 VA: 0x2CB1EE8
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x2CB2AF0 Offset: 0x2CAEAF0 VA: 0x2CB2AF0
	|-Task<Int32Enum>.ContinueWith
	|
	|-RVA: 0x2CB3744 Offset: 0x2CAF744 VA: 0x2CB3744
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x2CB43C8 Offset: 0x2CB03C8 VA: 0x2CB43C8
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x2CB4FD4 Offset: 0x2CB0FD4 VA: 0x2CB4FD4
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x2CB61F0 Offset: 0x2CB21F0 VA: 0x2CB61F0
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAE0B4 Offset: 0x2CAA0B4 VA: 0x2CAE0B4
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x2CAED38 Offset: 0x2CAAD38 VA: 0x2CAED38
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x2CAFA30 Offset: 0x2CABA30 VA: 0x2CAFA30
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x2CB06D8 Offset: 0x2CAC6D8 VA: 0x2CB06D8
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x2CB12F8 Offset: 0x2CAD2F8 VA: 0x2CB12F8
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x2CB1F00 Offset: 0x2CADF00 VA: 0x2CB1F00
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x2CB2B08 Offset: 0x2CAEB08 VA: 0x2CB2B08
	|-Task<Int32Enum>.ContinueWith
	|
	|-RVA: 0x2CB375C Offset: 0x2CAF75C VA: 0x2CB375C
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x2CB43E0 Offset: 0x2CB03E0 VA: 0x2CB43E0
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x2CB4FEC Offset: 0x2CB0FEC VA: 0x2CB4FEC
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x2CB620C Offset: 0x2CB220C VA: 0x2CB620C
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267E804 Offset: 0x267A804 VA: 0x267E804
	|-Task<Int32Enum>.ContinueWith<object>
	|
	|-RVA: 0x267EBD8 Offset: 0x267ABD8 VA: 0x267EBD8
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267E614 Offset: 0x267A614 VA: 0x267E614
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x267E9E8 Offset: 0x267A9E8 VA: 0x267E9E8
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x267EC5C Offset: 0x267AC5C VA: 0x267EC5C
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267E6A0 Offset: 0x267A6A0 VA: 0x267E6A0
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x267E884 Offset: 0x267A884 VA: 0x267E884
	|-Task<Int32Enum>.ContinueWith<object>
	|
	|-RVA: 0x267EA74 Offset: 0x267AA74 VA: 0x267EA74
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x267ECEC Offset: 0x267ACEC VA: 0x267ECEC
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/
}
