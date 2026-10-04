// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder // TypeDefIndex: 10526
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x2F216E0 Offset: 0x2F1D6E0 VA: 0x2F216E0
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27D86D8 Offset: 0x27D46D8 VA: 0x27D86D8
	|-AsyncTaskMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27D88E8 Offset: 0x27D48E8 VA: 0x27D88E8
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x27D89E8 Offset: 0x27D49E8 VA: 0x27D89E8
	|-AsyncTaskMethodBuilder.Start<CorePackageInitializer.<InitializeComponents>d__47>
	|
	|-RVA: 0x27D8AE8 Offset: 0x27D4AE8 VA: 0x27D8AE8
	|-AsyncTaskMethodBuilder.Start<CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0x27D8BE8 Offset: 0x27D4BE8 VA: 0x27D8BE8
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x27D8CE8 Offset: 0x27D4CE8 VA: 0x27D8CE8
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x27D8DE8 Offset: 0x27D4DE8 VA: 0x27D8DE8
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x27D8EE8 Offset: 0x27D4EE8 VA: 0x27D8EE8
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x27D8FE8 Offset: 0x27D4FE8 VA: 0x27D8FE8
	|-AsyncTaskMethodBuilder.Start<MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x27D90E8 Offset: 0x27D50E8 VA: 0x27D90E8
	|-AsyncTaskMethodBuilder.Start<ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x27D91E8 Offset: 0x27D51E8 VA: 0x27D91E8
	|-AsyncTaskMethodBuilder.Start<Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x27D92E8 Offset: 0x27D52E8 VA: 0x27D92E8
	|-AsyncTaskMethodBuilder.Start<Ua2CoreInitializeCallback.<Initialize>d__1>
	|
	|-RVA: 0x27D93E8 Offset: 0x27D53E8 VA: 0x27D93E8
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<EnableInitializationAsync>d__36>
	|
	|-RVA: 0x27D94E8 Offset: 0x27D54E8 VA: 0x27D94E8
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<InitializeServicesAsync>d__33>
	|
	|-RVA: 0x27D95E8 Offset: 0x27D55E8 VA: 0x27D95E8
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0x27D96E8 Offset: 0x27D56E8 VA: 0x27D96E8
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x27D97E8 Offset: 0x27D57E8 VA: 0x27D97E8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x27D98E8 Offset: 0x27D58E8 VA: 0x27D98E8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x27D99E8 Offset: 0x27D59E8 VA: 0x27D99E8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x27D9AE8 Offset: 0x27D5AE8 VA: 0x27D9AE8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x27D9BE8 Offset: 0x27D5BE8 VA: 0x27D9BE8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x27D9CE8 Offset: 0x27D5CE8 VA: 0x27D9CE8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x27D9DE8 Offset: 0x27D5DE8 VA: 0x27D9DE8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x27D9EE8 Offset: 0x27D5EE8 VA: 0x27D9EE8
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x27D9FE8 Offset: 0x27D5FE8 VA: 0x27D9FE8
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x27DA0E8 Offset: 0x27D60E8 VA: 0x27DA0E8
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x27DA1E8 Offset: 0x27D61E8 VA: 0x27DA1E8
	|-AsyncTaskMethodBuilder.Start<CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|
	|-RVA: 0x27DA2E8 Offset: 0x27D62E8 VA: 0x27DA2E8
	|-AsyncTaskMethodBuilder.Start<CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0x27DA3E8 Offset: 0x27D63E8 VA: 0x27DA3E8
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	*/

	// RVA: 0x2F216EC Offset: 0x2F1D6EC VA: 0x2F216EC
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27D74E8 Offset: 0x27D34E8 VA: 0x27D74E8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x27D7564 Offset: 0x27D3564 VA: 0x27D7564
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x27D75E0 Offset: 0x27D35E0 VA: 0x27D75E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x27D765C Offset: 0x27D365C VA: 0x27D765C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x27D76D8 Offset: 0x27D36D8 VA: 0x27D76D8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x27D7754 Offset: 0x27D3754 VA: 0x27D7754
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x27D77D0 Offset: 0x27D37D0 VA: 0x27D77D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x27D784C Offset: 0x27D384C VA: 0x27D784C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x27D78C8 Offset: 0x27D38C8 VA: 0x27D78C8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0x27D7944 Offset: 0x27D3944 VA: 0x27D7944
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	|
	|-RVA: 0x27D79C0 Offset: 0x27D39C0 VA: 0x27D79C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x27D7A3C Offset: 0x27D3A3C VA: 0x27D7A3C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<InitializeComponents>d__47>
	|
	|-RVA: 0x27D7AB8 Offset: 0x27D3AB8 VA: 0x27D7AB8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x27D7B34 Offset: 0x27D3B34 VA: 0x27D7B34
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Ua2CoreInitializeCallback.<Initialize>d__1>
	|
	|-RVA: 0x27D7BB0 Offset: 0x27D3BB0 VA: 0x27D7BB0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<EnableInitializationAsync>d__36>
	|
	|-RVA: 0x27D7C2C Offset: 0x27D3C2C VA: 0x27D7C2C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeServicesAsync>d__33>
	|
	|-RVA: 0x27D7CA8 Offset: 0x27D3CA8 VA: 0x27D7CA8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x27D7D24 Offset: 0x27D3D24 VA: 0x27D7D24
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x27D7DA0 Offset: 0x27D3DA0 VA: 0x27D7DA0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x27D7E1C Offset: 0x27D3E1C VA: 0x27D7E1C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|
	|-RVA: 0x27D7E98 Offset: 0x27D3E98 VA: 0x27D7E98
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0x27D7F14 Offset: 0x27D3F14 VA: 0x27D7F14
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x27D7F90 Offset: 0x27D3F90 VA: 0x27D7F90
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27D8010 Offset: 0x27D4010 VA: 0x27D8010
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x27D808C Offset: 0x27D408C VA: 0x27D808C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x27D8108 Offset: 0x27D4108 VA: 0x27D8108
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x27D8184 Offset: 0x27D4184 VA: 0x27D8184
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x27D8200 Offset: 0x27D4200 VA: 0x27D8200
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x27D827C Offset: 0x27D427C VA: 0x27D827C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x27D82F8 Offset: 0x27D42F8 VA: 0x27D82F8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x27D8374 Offset: 0x27D4374 VA: 0x27D8374
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x27D83F0 Offset: 0x27D43F0 VA: 0x27D83F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x27D846C Offset: 0x27D446C VA: 0x27D846C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x27D84E8 Offset: 0x27D44E8 VA: 0x27D84E8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x27D8564 Offset: 0x27D4564 VA: 0x27D8564
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x27D85E0 Offset: 0x27D45E0 VA: 0x27D85E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x27D865C Offset: 0x27D465C VA: 0x27D865C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	*/

	// RVA: 0x2F21768 Offset: 0x2F1D768 VA: 0x2F21768
	public Task get_Task() { }

	// RVA: 0x2F217D4 Offset: 0x2F1D7D4 VA: 0x2F217D4
	public void SetResult() { }

	// RVA: 0x2F21878 Offset: 0x2F1D878 VA: 0x2F21878
	public void SetException(Exception exception) { }

	// RVA: 0x2F218F4 Offset: 0x2F1D8F4 VA: 0x2F218F4
	private static void .cctor() { }
}
