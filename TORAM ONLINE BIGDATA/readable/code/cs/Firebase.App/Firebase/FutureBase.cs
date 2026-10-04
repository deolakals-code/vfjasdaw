// Assembly: Firebase.App.dll
// Namespace: Firebase
internal class FutureBase : IDisposable // TypeDefIndex: 17206
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x26522A4 Offset: 0x264E2A4 VA: 0x26522A4
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2652304 Offset: 0x264E304 VA: 0x2652304 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26523A4 Offset: 0x264E3A4 VA: 0x26523A4 Slot: 4
	public void Dispose() { }

	// RVA: 0x2652410 Offset: 0x264E410 VA: 0x2652410 Slot: 5
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x2652648 Offset: 0x264E648 VA: 0x2652648
	public FutureStatus status() { }

	// RVA: 0x2652998 Offset: 0x264E998 VA: 0x2652998
	public int error() { }

	// RVA: 0x2652ADC Offset: 0x264EADC VA: 0x2652ADC
	public string error_message() { }
}
