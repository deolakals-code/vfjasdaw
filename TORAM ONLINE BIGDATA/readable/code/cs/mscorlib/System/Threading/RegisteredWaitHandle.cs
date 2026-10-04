// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(True)]
public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 9934
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x305464C Offset: 0x305064C VA: 0x305464C
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x30568DC Offset: 0x30528DC VA: 0x30568DC
	internal void Wait(object state) { }

	// RVA: 0x3056E28 Offset: 0x3052E28 VA: 0x3056E28
	private void DoCallBack(object timedOut) { }
}
