// Assembly: mscorlib.dll
// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Stream.<>c // TypeDefIndex: 10727
{
	// Fields
	public static readonly Stream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__4_0; // 0x8
	public static Func<object, int> <>9__40_0; // 0x10
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__45_0; // 0x18
	public static Func<Stream, IAsyncResult, int> <>9__45_1; // 0x20
	public static Func<object, int> <>9__48_0; // 0x28
	public static Action<Task, object> <>9__49_0; // 0x30
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__58_0; // 0x38
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__58_1; // 0x40

	// Methods

	// RVA: 0x2F4F414 Offset: 0x2F4B414 VA: 0x2F4F414
	private static void .cctor() { }

	// RVA: 0x2F4F47C Offset: 0x2F4B47C VA: 0x2F4F47C
	public void .ctor() { }

	// RVA: 0x2F4F484 Offset: 0x2F4B484 VA: 0x2F4F484
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x2F4F4E0 Offset: 0x2F4B4E0 VA: 0x2F4F4E0
	internal int <BeginReadInternal>b__40_0(object <p0>) { }

	// RVA: 0x2F4F6A4 Offset: 0x2F4B6A4 VA: 0x2F4F6A4
	internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x2F4F6D8 Offset: 0x2F4B6D8 VA: 0x2F4F6D8
	internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x2F4F704 Offset: 0x2F4B704 VA: 0x2F4F704
	internal int <BeginWriteInternal>b__48_0(object <p0>) { }

	// RVA: 0x2F4F8B8 Offset: 0x2F4B8B8 VA: 0x2F4F8B8
	internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state) { }

	// RVA: 0x2F4F924 Offset: 0x2F4B924 VA: 0x2F4F924
	internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x2F4F958 Offset: 0x2F4B958 VA: 0x2F4F958
	internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult) { }
}
