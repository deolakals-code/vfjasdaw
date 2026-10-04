// Assembly: System.dll
// Namespace: System.Net
internal class ContextAwareResult : LazyAsyncResult // TypeDefIndex: 14349
{
	// Fields
	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private ContextAwareResult.StateFlags _flags; // 0x50

	// Methods

	// RVA: 0x34D94AC Offset: 0x34D54AC VA: 0x34D94AC
	private void SafeCaptureIdentity() { }

	// RVA: 0x34D94B0 Offset: 0x34D54B0 VA: 0x34D94B0
	private void CleanupInternal() { }

	// RVA: 0x34D94B4 Offset: 0x34D54B4 VA: 0x34D94B4
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x34D94BC Offset: 0x34D54BC VA: 0x34D94BC
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x34D950C Offset: 0x34D550C VA: 0x34D950C
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x34D9584 Offset: 0x34D5584 VA: 0x34D9584
	internal object StartPostingAsyncOp() { }

	// RVA: 0x34D958C Offset: 0x34D558C VA: 0x34D958C
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x34D9754 Offset: 0x34D5754 VA: 0x34D9754
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x34D9B98 Offset: 0x34D5B98 VA: 0x34D9B98 Slot: 9
	protected override void Cleanup() { }

	// RVA: 0x34D9794 Offset: 0x34D5794 VA: 0x34D9794
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x34D9E5C Offset: 0x34D5E5C VA: 0x34D9E5C Slot: 8
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x34DA158 Offset: 0x34D6158 VA: 0x34DA158
	private void CompleteCallback() { }
}
