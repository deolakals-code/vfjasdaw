// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 10527
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46914 Offset: 0x2B42914 VA: 0x2B46914
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|
	|-RVA: 0x2B47060 Offset: 0x2B43060 VA: 0x2B47060
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|
	|-RVA: 0x2B48188 Offset: 0x2B44188 VA: 0x2B48188
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Create
	|
	|-RVA: 0x2B49404 Offset: 0x2B45404 VA: 0x2B49404
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Create
	|
	|-RVA: 0x2B4A5C0 Offset: 0x2B465C0 VA: 0x2B4A5C0
	|-AsyncTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x2B4B6D0 Offset: 0x2B476D0 VA: 0x2B4B6D0
	|-AsyncTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x2B4C7D4 Offset: 0x2B487D4 VA: 0x2B4C7D4
	|-AsyncTaskMethodBuilder<object>.Create
	|
	|-RVA: 0x2B4CF20 Offset: 0x2B48F20 VA: 0x2B4CF20
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Create
	|
	|-RVA: 0x2B4E048 Offset: 0x2B4A048 VA: 0x2B4E048
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	|
	|-RVA: 0x2B4F14C Offset: 0x2B4B14C VA: 0x2B4F14C
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x266CACC Offset: 0x2668ACC VA: 0x266CACC
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x266CDE8 Offset: 0x2668DE8 VA: 0x266CDE8
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Start<WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0x266D0FC Offset: 0x26690FC VA: 0x266D0FC
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x266D624 Offset: 0x2669624 VA: 0x266D624
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Start<HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x266E188 Offset: 0x266A188 VA: 0x266E188
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x266E288 Offset: 0x266A288 VA: 0x266E288
	|-AsyncTaskMethodBuilder<bool>.Start<ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0x266E388 Offset: 0x266A388 VA: 0x266E388
	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x26701A0 Offset: 0x266C1A0 VA: 0x26701A0
	|-AsyncTaskMethodBuilder<int>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0x26702A0 Offset: 0x266C2A0 VA: 0x26702A0
	|-AsyncTaskMethodBuilder<int>.Start<BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0x26703A0 Offset: 0x266C3A0 VA: 0x26703A0
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0x26704A0 Offset: 0x266C4A0 VA: 0x26704A0
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x26705A0 Offset: 0x266C5A0 VA: 0x26705A0
	|-AsyncTaskMethodBuilder<int>.Start<FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0x26706A0 Offset: 0x266C6A0 VA: 0x26706A0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x26707A0 Offset: 0x266C7A0 VA: 0x26707A0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0x26708A0 Offset: 0x266C8A0 VA: 0x26708A0
	|-AsyncTaskMethodBuilder<int>.Start<MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0x26709A0 Offset: 0x266C9A0 VA: 0x26709A0
	|-AsyncTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x2670AA0 Offset: 0x266CAA0 VA: 0x2670AA0
	|-AsyncTaskMethodBuilder<int>.Start<WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x2670BA0 Offset: 0x266CBA0 VA: 0x2670BA0
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x2672DF0 Offset: 0x266EDF0 VA: 0x2672DF0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0x2672EF0 Offset: 0x266EEF0 VA: 0x2672EF0
	|-AsyncTaskMethodBuilder<object>.Start<WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0x2672FF0 Offset: 0x266EFF0 VA: 0x2672FF0
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x26730F0 Offset: 0x266F0F0 VA: 0x26730F0
	|-AsyncTaskMethodBuilder<object>.Start<CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53>
	|
	|-RVA: 0x26731F0 Offset: 0x266F1F0 VA: 0x26731F0
	|-AsyncTaskMethodBuilder<object>.Start<CoreRegistryInitializer.<InitializeRegistryAsync>d__3>
	|
	|-RVA: 0x26732F0 Offset: 0x266F2F0 VA: 0x26732F0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0x26733F0 Offset: 0x266F3F0 VA: 0x26733F0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x26734F0 Offset: 0x266F4F0 VA: 0x26734F0
	|-AsyncTaskMethodBuilder<object>.Start<MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0x26735F0 Offset: 0x266F5F0 VA: 0x26735F0
	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x26736F0 Offset: 0x266F6F0 VA: 0x26736F0
	|-AsyncTaskMethodBuilder<object>.Start<WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0x26737F0 Offset: 0x266F7F0 VA: 0x26737F0
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x26738F0 Offset: 0x266F8F0 VA: 0x26738F0
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x2673E18 Offset: 0x266FE18 VA: 0x2673E18
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Start<CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54>
	|
	|-RVA: 0x2673F18 Offset: 0x266FF18 VA: 0x2673F18
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Start<StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>
	|
	|-RVA: 0x2678E48 Offset: 0x2674E48 VA: 0x2678E48
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46920 Offset: 0x2B42920 VA: 0x2B46920
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|
	|-RVA: 0x2B4706C Offset: 0x2B4306C VA: 0x2B4706C
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x2B48194 Offset: 0x2B44194 VA: 0x2B48194
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetStateMachine
	|
	|-RVA: 0x2B49410 Offset: 0x2B45410 VA: 0x2B49410
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetStateMachine
	|
	|-RVA: 0x2B4A5CC Offset: 0x2B465CC VA: 0x2B4A5CC
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x2B4B6DC Offset: 0x2B476DC VA: 0x2B4B6DC
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x2B4C7E0 Offset: 0x2B487E0 VA: 0x2B4C7E0
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|
	|-RVA: 0x2B4CF2C Offset: 0x2B48F2C VA: 0x2B4CF2C
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetStateMachine
	|
	|-RVA: 0x2B4E054 Offset: 0x2B4A054 VA: 0x2B4E054
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	|
	|-RVA: 0x2B4F158 Offset: 0x2B4B158 VA: 0x2B4F158
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x266C8B8 Offset: 0x26688B8 VA: 0x266C8B8
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x266CBCC Offset: 0x2668BCC VA: 0x266CBCC
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0x266CEE8 Offset: 0x2668EE8 VA: 0x266CEE8
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x266D1FC Offset: 0x26691FC VA: 0x266D1FC
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x266D410 Offset: 0x2669410 VA: 0x266D410
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x266D724 Offset: 0x2669724 VA: 0x266D724
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x266D938 Offset: 0x2669938 VA: 0x266D938
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x266DB4C Offset: 0x2669B4C VA: 0x266DB4C
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0x266DD60 Offset: 0x2669D60 VA: 0x266DD60
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x266DF74 Offset: 0x2669F74 VA: 0x266DF74
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x266E488 Offset: 0x266A488 VA: 0x266E488
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0x266E69C Offset: 0x266A69C VA: 0x266E69C
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0x266E8B0 Offset: 0x266A8B0 VA: 0x266E8B0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0x266EAC4 Offset: 0x266AAC4 VA: 0x266EAC4
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x266ECD8 Offset: 0x266ACD8 VA: 0x266ECD8
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0x266EEEC Offset: 0x266AEEC VA: 0x266EEEC
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x266F100 Offset: 0x266B100 VA: 0x266F100
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x266F314 Offset: 0x266B314 VA: 0x266F314
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x266F528 Offset: 0x266B528 VA: 0x266F528
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0x266F73C Offset: 0x266B73C VA: 0x266F73C
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x266F950 Offset: 0x266B950 VA: 0x266F950
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x266FB64 Offset: 0x266BB64 VA: 0x266FB64
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0x266FD78 Offset: 0x266BD78 VA: 0x266FD78
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x266FF8C Offset: 0x266BF8C VA: 0x266FF8C
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x2670CA0 Offset: 0x266CCA0 VA: 0x2670CA0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x2670EB4 Offset: 0x266CEB4 VA: 0x2670EB4
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0x26710C8 Offset: 0x266D0C8 VA: 0x26710C8
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x26712DC Offset: 0x266D2DC VA: 0x26712DC
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0x26714F0 Offset: 0x266D4F0 VA: 0x26714F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0x267170C Offset: 0x266D70C VA: 0x267170C
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x2671920 Offset: 0x266D920 VA: 0x2671920
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x2671B34 Offset: 0x266DB34 VA: 0x2671B34
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x2671D48 Offset: 0x266DD48 VA: 0x2671D48
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x2671F5C Offset: 0x266DF5C VA: 0x2671F5C
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<SerializableProjectConfiguration>, CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53>
	|
	|-RVA: 0x2672178 Offset: 0x266E178 VA: 0x2672178
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<InitializeRegistryAsync>d__3>
	|
	|-RVA: 0x267238C Offset: 0x266E38C VA: 0x267238C
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x26725A0 Offset: 0x266E5A0 VA: 0x26725A0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0x26727B4 Offset: 0x266E7B4 VA: 0x26727B4
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x26729C8 Offset: 0x266E9C8 VA: 0x26729C8
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0x2672BDC Offset: 0x266EBDC VA: 0x2672BDC
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x26739F0 Offset: 0x266F9F0 VA: 0x26739F0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>
	|
	|-RVA: 0x2673C04 Offset: 0x266FC04 VA: 0x2673C04
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.AwaitUnsafeOnCompleted<TaskAwaiter<SerializableProjectConfiguration>, CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54>
	|
	|-RVA: 0x2674018 Offset: 0x2670018 VA: 0x2674018
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x267422C Offset: 0x267022C VA: 0x267422C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x2674440 Offset: 0x2670440 VA: 0x2674440
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x2674654 Offset: 0x2670654 VA: 0x2674654
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x2674868 Offset: 0x2670868 VA: 0x2674868
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x2674A7C Offset: 0x2670A7C VA: 0x2674A7C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x2674C90 Offset: 0x2670C90 VA: 0x2674C90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x2674EA4 Offset: 0x2670EA4 VA: 0x2674EA4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x26750B8 Offset: 0x26710B8 VA: 0x26750B8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0x26752D4 Offset: 0x26712D4 VA: 0x26752D4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	|
	|-RVA: 0x26754E8 Offset: 0x26714E8 VA: 0x26754E8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x26756FC Offset: 0x26716FC VA: 0x26756FC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<InitializeComponents>d__47>
	|
	|-RVA: 0x2675910 Offset: 0x2671910 VA: 0x2675910
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x2675B24 Offset: 0x2671B24 VA: 0x2675B24
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Ua2CoreInitializeCallback.<Initialize>d__1>
	|
	|-RVA: 0x2675D38 Offset: 0x2671D38 VA: 0x2675D38
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<EnableInitializationAsync>d__36>
	|
	|-RVA: 0x2675F4C Offset: 0x2671F4C VA: 0x2675F4C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeServicesAsync>d__33>
	|
	|-RVA: 0x2676168 Offset: 0x2672168 VA: 0x2676168
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x267637C Offset: 0x267237C VA: 0x267637C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x2676590 Offset: 0x2672590 VA: 0x2676590
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x26767A4 Offset: 0x26727A4 VA: 0x26767A4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|
	|-RVA: 0x26769C0 Offset: 0x26729C0 VA: 0x26769C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0x2676BDC Offset: 0x2672BDC VA: 0x2676BDC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x2676E1C Offset: 0x2672E1C VA: 0x2676E1C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2677030 Offset: 0x2673030 VA: 0x2677030
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x2677244 Offset: 0x2673244 VA: 0x2677244
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x2677458 Offset: 0x2673458 VA: 0x2677458
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x267766C Offset: 0x267366C VA: 0x267766C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x2677880 Offset: 0x2673880 VA: 0x2677880
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x2677A94 Offset: 0x2673A94 VA: 0x2677A94
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x2677CA8 Offset: 0x2673CA8 VA: 0x2677CA8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x2677EBC Offset: 0x2673EBC VA: 0x2677EBC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x26780D0 Offset: 0x26740D0 VA: 0x26780D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x26782E4 Offset: 0x26742E4 VA: 0x26782E4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x26784F8 Offset: 0x26744F8 VA: 0x26784F8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x267870C Offset: 0x267470C VA: 0x267870C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x2678920 Offset: 0x2674920 VA: 0x2678920
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x2678B34 Offset: 0x2674B34 VA: 0x2678B34
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46928 Offset: 0x2B42928 VA: 0x2B46928
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0x2B47074 Offset: 0x2B43074 VA: 0x2B47074
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x2B4819C Offset: 0x2B4419C VA: 0x2B4819C
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.get_Task
	|
	|-RVA: 0x2B49418 Offset: 0x2B45418 VA: 0x2B49418
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.get_Task
	|
	|-RVA: 0x2B4A5D4 Offset: 0x2B465D4 VA: 0x2B4A5D4
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x2B4B6E4 Offset: 0x2B476E4 VA: 0x2B4B6E4
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x2B4C7E8 Offset: 0x2B487E8 VA: 0x2B4C7E8
	|-AsyncTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0x2B4CF34 Offset: 0x2B48F34 VA: 0x2B4CF34
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.get_Task
	|
	|-RVA: 0x2B4E05C Offset: 0x2B4A05C VA: 0x2B4E05C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	|
	|-RVA: 0x2B4F160 Offset: 0x2B4B160 VA: 0x2B4F160
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B469B4 Offset: 0x2B429B4 VA: 0x2B469B4
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x2B47100 Offset: 0x2B43100 VA: 0x2B47100
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x2B48228 Offset: 0x2B44228 VA: 0x2B48228
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x2B494A4 Offset: 0x2B454A4 VA: 0x2B494A4
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x2B4A660 Offset: 0x2B46660 VA: 0x2B4A660
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x2B4B770 Offset: 0x2B47770 VA: 0x2B4B770
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x2B4C874 Offset: 0x2B48874 VA: 0x2B4C874
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x2B4CFC0 Offset: 0x2B48FC0 VA: 0x2B4CFC0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetResult
	|
	|-RVA: 0x2B4E0E8 Offset: 0x2B4A0E8 VA: 0x2B4E0E8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0x2B4F21C Offset: 0x2B4B21C VA: 0x2B4F21C
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46B60 Offset: 0x2B42B60 VA: 0x2B46B60
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x2B472B8 Offset: 0x2B432B8 VA: 0x2B472B8
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x2B48420 Offset: 0x2B44420 VA: 0x2B48420
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x2B49674 Offset: 0x2B45674 VA: 0x2B49674
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x2B4A80C Offset: 0x2B4680C VA: 0x2B4A80C
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x2B4B91C Offset: 0x2B4791C VA: 0x2B4B91C
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x2B4CA20 Offset: 0x2B48A20 VA: 0x2B4CA20
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x2B4D178 Offset: 0x2B49178 VA: 0x2B4D178
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetResult
	|
	|-RVA: 0x2B4E294 Offset: 0x2B4A294 VA: 0x2B4E294
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0x2B4F5BC Offset: 0x2B4B5BC VA: 0x2B4F5BC
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46BE4 Offset: 0x2B42BE4 VA: 0x2B46BE4
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x2B47340 Offset: 0x2B43340 VA: 0x2B47340
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|
	|-RVA: 0x2B484DC Offset: 0x2B444DC VA: 0x2B484DC
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetException
	|
	|-RVA: 0x2B49720 Offset: 0x2B45720 VA: 0x2B49720
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetException
	|
	|-RVA: 0x2B4A890 Offset: 0x2B46890 VA: 0x2B4A890
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x2B4B9A0 Offset: 0x2B479A0 VA: 0x2B4B9A0
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x2B4CAA4 Offset: 0x2B48AA4 VA: 0x2B4CAA4
	|-AsyncTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0x2B4D200 Offset: 0x2B49200 VA: 0x2B4D200
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetException
	|
	|-RVA: 0x2B4E318 Offset: 0x2B4A318 VA: 0x2B4E318
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	|
	|-RVA: 0x2B4F784 Offset: 0x2B4B784 VA: 0x2B4F784
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46D68 Offset: 0x2B42D68 VA: 0x2B46D68
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x2B474C4 Offset: 0x2B434C4 VA: 0x2B474C4
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.GetTaskForResult
	|
	|-RVA: 0x2B48660 Offset: 0x2B44660 VA: 0x2B48660
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.GetTaskForResult
	|
	|-RVA: 0x2B498A4 Offset: 0x2B458A4 VA: 0x2B498A4
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.GetTaskForResult
	|
	|-RVA: 0x2B4AA14 Offset: 0x2B46A14 VA: 0x2B4AA14
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x2B4BB24 Offset: 0x2B47B24 VA: 0x2B4BB24
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x2B4CC28 Offset: 0x2B48C28 VA: 0x2B4CC28
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x2B4D384 Offset: 0x2B49384 VA: 0x2B4D384
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.GetTaskForResult
	|
	|-RVA: 0x2B4E49C Offset: 0x2B4A49C VA: 0x2B4E49C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	|
	|-RVA: 0x2B4F940 Offset: 0x2B4B940 VA: 0x2B4F940
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46F8C Offset: 0x2B42F8C VA: 0x2B46F8C
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x2B480B0 Offset: 0x2B440B0 VA: 0x2B480B0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0x2B492FC Offset: 0x2B452FC VA: 0x2B492FC
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0x2B4A4C8 Offset: 0x2B464C8 VA: 0x2B4A4C8
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0x2B4B5FC Offset: 0x2B475FC VA: 0x2B4B5FC
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x2B4C700 Offset: 0x2B48700 VA: 0x2B4C700
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x2B4CE4C Offset: 0x2B48E4C VA: 0x2B4CE4C
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x2B4DF70 Offset: 0x2B49F70 VA: 0x2B4DF70
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>..cctor
	|
	|-RVA: 0x2B4F078 Offset: 0x2B4B078 VA: 0x2B4F078
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	|
	|-RVA: 0x2B50A60 Offset: 0x2B4CA60 VA: 0x2B50A60
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>..cctor
	*/
}
