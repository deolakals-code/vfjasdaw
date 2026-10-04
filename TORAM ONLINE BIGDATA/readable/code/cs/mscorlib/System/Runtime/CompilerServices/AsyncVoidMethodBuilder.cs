// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
public struct AsyncVoidMethodBuilder // TypeDefIndex: 10525
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	internal Task Task { get; }

	// Methods

	// RVA: 0x2F21014 Offset: 0x2F1D014 VA: 0x2F21014
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DB158 Offset: 0x27D7158 VA: 0x27DB158
	|-AsyncVoidMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27DB368 Offset: 0x27D7368 VA: 0x27DB368
	|-AsyncVoidMethodBuilder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x27DB468 Offset: 0x27D7468 VA: 0x27DB468
	|-AsyncVoidMethodBuilder.Start<UnityServicesInitializer.<EnableServicesInitializationAsync>d__1>
	|
	|-RVA: 0x27DB568 Offset: 0x27D7568 VA: 0x27DB568
	|-AsyncVoidMethodBuilder.Start<WebOperation.<Run>d__58>
	*/

	// RVA: 0x2F21078 Offset: 0x2F1D078 VA: 0x2F21078
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DA4E8 Offset: 0x27D64E8 VA: 0x27DA4E8
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<Run>d__58>
	|
	|-RVA: 0x27DA73C Offset: 0x27D673C VA: 0x27DA73C
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInitializer.<EnableServicesInitializationAsync>d__1>
	|
	|-RVA: 0x27DA98C Offset: 0x27D698C VA: 0x27DA98C
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27DACB0 Offset: 0x27D6CB0 VA: 0x27DACB0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x27DAF04 Offset: 0x27D6F04 VA: 0x27DAF04
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebOperation.<Run>d__58>
	*/

	// RVA: 0x2F2113C Offset: 0x2F1D13C VA: 0x2F2113C
	public void SetResult() { }

	// RVA: 0x2F212AC Offset: 0x2F1D2AC VA: 0x2F212AC
	public void SetException(Exception exception) { }

	// RVA: 0x2F21208 Offset: 0x2F1D208 VA: 0x2F21208
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x2F21198 Offset: 0x2F1D198 VA: 0x2F21198
	internal Task get_Task() { }
}
