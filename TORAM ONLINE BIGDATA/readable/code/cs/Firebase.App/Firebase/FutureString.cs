// Assembly: Firebase.App.dll
// Namespace: Firebase
internal class FutureString : FutureBase // TypeDefIndex: 17216
{
	// Fields
	private HandleRef swigCPtr; // 0x28
	private static Dictionary<int, FutureString.Action> Callbacks; // 0x0
	private static int CallbackIndex; // 0x8
	private static object CallbackLock; // 0x10
	private IntPtr callbackData; // 0x38
	private FutureString.SWIG_CompletionDelegate SWIG_CompletionCB; // 0x40

	// Methods

	// RVA: 0x2658164 Offset: 0x2654164 VA: 0x2658164
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x26582A0 Offset: 0x26542A0 VA: 0x26582A0 Slot: 5
	public override void Dispose(bool disposing) { }

	// RVA: 0x2658660 Offset: 0x2654660 VA: 0x2658660
	public static Task<string> GetTask(FutureString fu) { }

	// RVA: 0x2658B98 Offset: 0x2654B98 VA: 0x2658B98
	private void ThrowIfDisposed() { }

	// RVA: 0x2658920 Offset: 0x2654920 VA: 0x2658920
	public void SetOnCompletionCallback(FutureString.Action userCompletionCallback) { }

	// RVA: 0x2658478 Offset: 0x2654478 VA: 0x2658478
	private void SetCompletionData(IntPtr data) { }

	[MonoPInvokeCallback(typeof(FutureString.SWIG_CompletionDelegate))]
	// RVA: 0x2657F7C Offset: 0x2653F7C VA: 0x2657F7C
	private static void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x2658CA0 Offset: 0x2654CA0 VA: 0x2658CA0
	internal IntPtr SWIG_OnCompletion(FutureString.SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x2658D80 Offset: 0x2654D80 VA: 0x2658D80
	public static void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x2658F4C Offset: 0x2654F4C VA: 0x2658F4C
	public string GetResult() { }

	// RVA: 0x26590A8 Offset: 0x26550A8 VA: 0x26590A8
	private static void .cctor() { }
}
