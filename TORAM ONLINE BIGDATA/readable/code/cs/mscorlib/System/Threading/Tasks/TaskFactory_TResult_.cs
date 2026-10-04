// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 9965
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6AD8 Offset: 0x2CA2AD8 VA: 0x2CA6AD8
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x2CA72A0 Offset: 0x2CA32A0 VA: 0x2CA72A0
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CA7A70 Offset: 0x2CA3A70 VA: 0x2CA7A70
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CA825C Offset: 0x2CA425C VA: 0x2CA825C
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CA8A48 Offset: 0x2CA4A48 VA: 0x2CA8A48
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x2CA9218 Offset: 0x2CA5218 VA: 0x2CA9218
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x2CA99E4 Offset: 0x2CA59E4 VA: 0x2CA99E4
	|-TaskFactory<Int32Enum>..ctor
	|
	|-RVA: 0x2CAA1B0 Offset: 0x2CA61B0 VA: 0x2CAA1B0
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x2CAA978 Offset: 0x2CA6978 VA: 0x2CAA978
	|-TaskFactory<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CAB148 Offset: 0x2CA7148 VA: 0x2CAB148
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CAB914 Offset: 0x2CA7914 VA: 0x2CAB914
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6AEC Offset: 0x2CA2AEC VA: 0x2CA6AEC
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x2CA72B4 Offset: 0x2CA32B4 VA: 0x2CA72B4
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CA7A84 Offset: 0x2CA3A84 VA: 0x2CA7A84
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CA8270 Offset: 0x2CA4270 VA: 0x2CA8270
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CA8A5C Offset: 0x2CA4A5C VA: 0x2CA8A5C
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x2CA922C Offset: 0x2CA522C VA: 0x2CA922C
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x2CA99F8 Offset: 0x2CA59F8 VA: 0x2CA99F8
	|-TaskFactory<Int32Enum>..ctor
	|
	|-RVA: 0x2CAA1C4 Offset: 0x2CA61C4 VA: 0x2CAA1C4
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x2CAA98C Offset: 0x2CA698C VA: 0x2CAA98C
	|-TaskFactory<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CAB15C Offset: 0x2CA715C VA: 0x2CAB15C
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CAB938 Offset: 0x2CA7938 VA: 0x2CAB938
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6B60 Offset: 0x2CA2B60 VA: 0x2CA6B60
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CA7328 Offset: 0x2CA3328 VA: 0x2CA7328
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CA7AF8 Offset: 0x2CA3AF8 VA: 0x2CA7AF8
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CA82E4 Offset: 0x2CA42E4 VA: 0x2CA82E4
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CA8AD0 Offset: 0x2CA4AD0 VA: 0x2CA8AD0
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CA92A0 Offset: 0x2CA52A0 VA: 0x2CA92A0
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CA9A6C Offset: 0x2CA5A6C VA: 0x2CA9A6C
	|-TaskFactory<Int32Enum>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CAA238 Offset: 0x2CA6238 VA: 0x2CAA238
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CAAA00 Offset: 0x2CA6A00 VA: 0x2CAAA00
	|-TaskFactory<SerializableProjectConfiguration>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CAB1D0 Offset: 0x2CA71D0 VA: 0x2CAB1D0
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x2CAB9AC Offset: 0x2CA79AC VA: 0x2CAB9AC
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6D44 Offset: 0x2CA2D44 VA: 0x2CA6D44
	|-TaskFactory<Nullable<int>>.FromAsync
	|
	|-RVA: 0x2CA7510 Offset: 0x2CA3510 VA: 0x2CA7510
	|-TaskFactory<ValueTuple<bool, object>>.FromAsync
	|
	|-RVA: 0x2CA7CF0 Offset: 0x2CA3CF0 VA: 0x2CA7CF0
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsync
	|
	|-RVA: 0x2CA84DC Offset: 0x2CA44DC VA: 0x2CA84DC
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsync
	|
	|-RVA: 0x2CA8CBC Offset: 0x2CA4CBC VA: 0x2CA8CBC
	|-TaskFactory<bool>.FromAsync
	|
	|-RVA: 0x2CA9488 Offset: 0x2CA5488 VA: 0x2CA9488
	|-TaskFactory<int>.FromAsync
	|
	|-RVA: 0x2CA9C54 Offset: 0x2CA5C54 VA: 0x2CA9C54
	|-TaskFactory<Int32Enum>.FromAsync
	|
	|-RVA: 0x2CAA41C Offset: 0x2CA641C VA: 0x2CAA41C
	|-TaskFactory<object>.FromAsync
	|
	|-RVA: 0x2CAABE8 Offset: 0x2CA6BE8 VA: 0x2CAABE8
	|-TaskFactory<SerializableProjectConfiguration>.FromAsync
	|
	|-RVA: 0x2CAB3B8 Offset: 0x2CA73B8 VA: 0x2CAB3B8
	|-TaskFactory<VoidTaskResult>.FromAsync
	|
	|-RVA: 0x2CABC8C Offset: 0x2CA7C8C VA: 0x2CABC8C
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6D64 Offset: 0x2CA2D64 VA: 0x2CA6D64
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x2CA7530 Offset: 0x2CA3530 VA: 0x2CA7530
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncImpl
	|
	|-RVA: 0x2CA7D10 Offset: 0x2CA3D10 VA: 0x2CA7D10
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncImpl
	|
	|-RVA: 0x2CA84FC Offset: 0x2CA44FC VA: 0x2CA84FC
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncImpl
	|
	|-RVA: 0x2CA8CDC Offset: 0x2CA4CDC VA: 0x2CA8CDC
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x2CA94A8 Offset: 0x2CA54A8 VA: 0x2CA94A8
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x2CA9C74 Offset: 0x2CA5C74 VA: 0x2CA9C74
	|-TaskFactory<Int32Enum>.FromAsyncImpl
	|
	|-RVA: 0x2CAA43C Offset: 0x2CA643C VA: 0x2CAA43C
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x2CAAC08 Offset: 0x2CA6C08 VA: 0x2CAAC08
	|-TaskFactory<SerializableProjectConfiguration>.FromAsyncImpl
	|
	|-RVA: 0x2CAB3D8 Offset: 0x2CA73D8 VA: 0x2CAB3D8
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	|
	|-RVA: 0x2CABCB0 Offset: 0x2CA7CB0 VA: 0x2CABCB0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C278 Offset: 0x2678278 VA: 0x267C278
	|-TaskFactory<object>.FromAsync<object>
	|
	|-RVA: 0x267D3C4 Offset: 0x26793C4 VA: 0x267D3C4
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C2E4 Offset: 0x26782E4 VA: 0x267C2E4
	|-TaskFactory<object>.FromAsyncImpl<object>
	|
	|-RVA: 0x267C7F8 Offset: 0x26787F8 VA: 0x267C7F8
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object>
	|
	|-RVA: 0x267D4C4 Offset: 0x26794C4 VA: 0x267D4C4
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CD0C Offset: 0x2678D0C VA: 0x267CD0C
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x267DC2C Offset: 0x2679C2C VA: 0x267DC2C
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C0EC Offset: 0x26780EC VA: 0x267C0EC
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x267D238 Offset: 0x2679238 VA: 0x267D238
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x267E3F0 Offset: 0x267A3F0 VA: 0x267E3F0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncTrim<object, __Il2CppFullySharedGenericType>
	*/
}
