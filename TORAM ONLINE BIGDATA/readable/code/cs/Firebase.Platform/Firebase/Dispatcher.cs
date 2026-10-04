// Assembly: Firebase.Platform.dll
// Namespace: Firebase
internal class Dispatcher // TypeDefIndex: 17727
{
	// Fields
	private int ownerThreadId; // 0x10
	private Queue<Action> queue; // 0x18

	// Methods

	// RVA: 0x26688D4 Offset: 0x26648D4 VA: 0x26688D4
	public void .ctor() { }

	// RVA: -1 Offset: -1
	public TResult Run<TResult>(Func<TResult> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E9704 Offset: 0x27E5704 VA: 0x27E9704
	|-Dispatcher.Run<bool>
	|
	|-RVA: 0x27E997C Offset: 0x27E597C VA: 0x27E997C
	|-Dispatcher.Run<object>
	|
	|-RVA: 0x27E9BE8 Offset: 0x27E5BE8 VA: 0x27E9BE8
	|-Dispatcher.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> RunAsync<TResult>(Func<TResult> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E9F6C Offset: 0x27E5F6C VA: 0x27E9F6C
	|-Dispatcher.RunAsync<bool>
	|
	|-RVA: 0x27EA160 Offset: 0x27E6160 VA: 0x27EA160
	|-Dispatcher.RunAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> RunAsyncNow<TResult>(Func<TResult> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EA364 Offset: 0x27E6364 VA: 0x27EA364
	|-Dispatcher.RunAsyncNow<bool>
	|
	|-RVA: 0x27EA4AC Offset: 0x27E64AC VA: 0x27EA4AC
	|-Dispatcher.RunAsyncNow<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x266897C Offset: 0x266497C VA: 0x266897C
	internal bool ManagesThisThread() { }

	// RVA: 0x26689B0 Offset: 0x26649B0 VA: 0x26689B0
	public void PollJobs() { }
}
