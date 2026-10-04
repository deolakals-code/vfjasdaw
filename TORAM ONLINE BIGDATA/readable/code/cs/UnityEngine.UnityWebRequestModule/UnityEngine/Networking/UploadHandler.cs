// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable // TypeDefIndex: 17611
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string contentType { set; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3829498 Offset: 0x3825498 VA: 0x3829498
	private void Release() { }

	// RVA: 0x38294D4 Offset: 0x38254D4 VA: 0x38294D4
	internal void .ctor() { }

	// RVA: 0x38294DC Offset: 0x38254DC VA: 0x38294DC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3829578 Offset: 0x3825578 VA: 0x3829578 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x38295D0 Offset: 0x38255D0 VA: 0x38295D0
	public void set_contentType(string value) { }

	// RVA: 0x38295DC Offset: 0x38255DC VA: 0x38295DC Slot: 6
	internal virtual void SetContentType(string newContentType) { }

	[NativeMethod("SetContentType")]
	// RVA: 0x3829620 Offset: 0x3825620 VA: 0x3829620
	private void InternalSetContentType(string newContentType) { }
}
