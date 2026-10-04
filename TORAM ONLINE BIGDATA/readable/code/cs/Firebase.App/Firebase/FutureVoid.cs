// Assembly: Firebase.App.dll
// Namespace: Firebase
internal class FutureVoid : FutureBase // TypeDefIndex: 17220
{
	// Fields
	private HandleRef swigCPtr; // 0x28
	private static Dictionary<int, FutureVoid.Action> Callbacks; // 0x0
	private static int CallbackIndex; // 0x8
	private static object CallbackLock; // 0x10
	private IntPtr callbackData; // 0x38
	private FutureVoid.SWIG_CompletionDelegate SWIG_CompletionCB; // 0x40

	// Methods

	// RVA: 0x2659554 Offset: 0x2655554 VA: 0x2659554
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2659690 Offset: 0x2655690 VA: 0x2659690 Slot: 5
	public override void Dispose(bool disposing) { }

	// RVA: 0x2659A50 Offset: 0x2655A50 VA: 0x2659A50
	public static Task GetTask(FutureVoid fu) { }

	// RVA: 0x2659F88 Offset: 0x2655F88 VA: 0x2659F88
	private void ThrowIfDisposed() { }

	// RVA: 0x2659D10 Offset: 0x2655D10 VA: 0x2659D10
	public void SetOnCompletionCallback(FutureVoid.Action userCompletionCallback) { }

	// RVA: 0x2659868 Offset: 0x2655868 VA: 0x2659868
	private void SetCompletionData(IntPtr data) { }

	[MonoPInvokeCallback(typeof(FutureVoid.SWIG_CompletionDelegate))]
	// RVA: 0x265936C Offset: 0x265536C VA: 0x265936C
	private static void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x265A090 Offset: 0x2656090 VA: 0x265A090
	internal IntPtr SWIG_OnCompletion(FutureVoid.SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x265A170 Offset: 0x2656170 VA: 0x265A170
	public static void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x265A33C Offset: 0x265633C VA: 0x265A33C
	private static void .cctor() { }
}
