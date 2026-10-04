// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
public class TaskFactory // TypeDefIndex: 9995
{
	// Fields
	private readonly CancellationToken m_defaultCancellationToken; // 0x10
	private readonly TaskScheduler m_defaultScheduler; // 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; // 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x3061920 Offset: 0x305D920 VA: 0x3061920
	public void .ctor() { }

	// RVA: 0x3063B6C Offset: 0x305FB6C VA: 0x3063B6C
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x3063CD4 Offset: 0x305FCD4 VA: 0x3063CD4
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x3063D30 Offset: 0x305FD30 VA: 0x3063D30
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F6288 Offset: 0x26F2288 VA: 0x26F6288
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x26F631C Offset: 0x26F231C VA: 0x26F631C
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F63B4 Offset: 0x26F23B4 VA: 0x26F63B4
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0x26F6458 Offset: 0x26F2458 VA: 0x26F6458
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x26F64FC Offset: 0x26F24FC VA: 0x26F64FC
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F5C1C Offset: 0x26F1C1C VA: 0x26F5C1C
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0x26F5C84 Offset: 0x26F1C84 VA: 0x26F5C84
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F5D84 Offset: 0x26F1D84 VA: 0x26F5D84
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0x26F5DF0 Offset: 0x26F1DF0 VA: 0x26F5DF0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F5EEC Offset: 0x26F1EEC VA: 0x26F5EEC
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0x26F5F5C Offset: 0x26F1F5C VA: 0x26F5F5C
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F60B8 Offset: 0x26F20B8 VA: 0x26F60B8
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0x26F612C Offset: 0x26F212C VA: 0x26F612C
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3063DC0 Offset: 0x305FDC0 VA: 0x3063DC0
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x3060C8C Offset: 0x305CC8C VA: 0x3060C8C
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x3063BD8 Offset: 0x305FBD8 VA: 0x3063BD8
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}
