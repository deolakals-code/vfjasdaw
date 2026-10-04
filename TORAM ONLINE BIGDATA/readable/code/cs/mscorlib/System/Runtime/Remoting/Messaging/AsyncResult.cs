// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 10287
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x2EED79C Offset: 0x2EE979C VA: 0x2EED79C
	internal void .ctor() { }

	// RVA: 0x2EED7A4 Offset: 0x2EE97A4 VA: 0x2EED7A4 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x2EED7AC Offset: 0x2EE97AC VA: 0x2EED7AC Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x2EED8D0 Offset: 0x2EE98D0 VA: 0x2EED8D0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x2EED8D8 Offset: 0x2EE98D8 VA: 0x2EED8D8 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x2EED8E0 Offset: 0x2EE98E0 VA: 0x2EED8E0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x2EED8E8 Offset: 0x2EE98E8 VA: 0x2EED8E8
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x2EED8F4 Offset: 0x2EE98F4 VA: 0x2EED8F4 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x2EED8FC Offset: 0x2EE98FC VA: 0x2EED8FC Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x2EED904 Offset: 0x2EE9904 VA: 0x2EED904 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2EED93C Offset: 0x2EE993C VA: 0x2EED93C Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x2EED944 Offset: 0x2EE9944 VA: 0x2EED944 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x2EED94C Offset: 0x2EE994C VA: 0x2EED94C
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x2EED958 Offset: 0x2EE9958 VA: 0x2EED958
	internal IMessage EndInvoke() { }

	// RVA: 0x2EEDA68 Offset: 0x2EE9A68 VA: 0x2EEDA68 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EEDC04 Offset: 0x2EE9C04 VA: 0x2EEDC04
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x2EEDC0C Offset: 0x2EE9C0C VA: 0x2EEDC0C
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x2EEDC14 Offset: 0x2EE9C14 VA: 0x2EEDC14 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x2EEDC1C Offset: 0x2EE9C1C VA: 0x2EEDC1C Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x2EEDC18 Offset: 0x2EE9C18 VA: 0x2EEDC18
	internal object Invoke() { }
}
