// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable // TypeDefIndex: 17604
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x38270A0 Offset: 0x38230A0 VA: 0x38270A0
	private void Release() { }

	[VisibleToOtherModules]
	// RVA: 0x38270DC Offset: 0x38230DC VA: 0x38270DC
	internal void .ctor() { }

	// RVA: 0x38270E4 Offset: 0x38230E4 VA: 0x38270E4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3827180 Offset: 0x3823180 VA: 0x3827180 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x38271D8 Offset: 0x38231D8 VA: 0x38271D8
	public byte[] get_data() { }

	// RVA: 0x38271E4 Offset: 0x38231E4 VA: 0x38271E4
	public string get_text() { }

	// RVA: 0x38271F0 Offset: 0x38231F0 VA: 0x38271F0 Slot: 6
	protected virtual NativeArray<byte> GetNativeData() { }

	// RVA: 0x38271FC Offset: 0x38231FC VA: 0x38271FC Slot: 7
	protected virtual byte[] GetData() { }

	// RVA: 0x3827284 Offset: 0x3823284 VA: 0x3827284 Slot: 8
	protected virtual string GetText() { }

	// RVA: 0x3827344 Offset: 0x3823344 VA: 0x3827344
	private Encoding GetTextEncoder() { }

	// RVA: 0x38275B4 Offset: 0x38235B4 VA: 0x38275B4
	private string GetContentType() { }

	[RequiredByNativeCode]
	// RVA: 0x38275F0 Offset: 0x38235F0 VA: 0x38275F0 Slot: 9
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x38275F8 Offset: 0x38235F8 VA: 0x38275F8 Slot: 10
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x3827604 Offset: 0x3823604 VA: 0x3827604 Slot: 11
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x3827608 Offset: 0x3823608 VA: 0x3827608 Slot: 12
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x382760C Offset: 0x382360C VA: 0x382760C Slot: 13
	protected virtual float GetProgress() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EA68C Offset: 0x27E668C VA: 0x27EA68C
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrows]
	[VisibleToOtherModules]
	// RVA: 0x3827614 Offset: 0x3823614 VA: 0x3827614
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	// RVA: 0x3827200 Offset: 0x3823200 VA: 0x3827200
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x3827658 Offset: 0x3823658 VA: 0x3827658
	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) { }

	// RVA: 0x3827730 Offset: 0x3823730 VA: 0x3827730
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x3827774 Offset: 0x3823774 VA: 0x3827774
	internal static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) { }
}
