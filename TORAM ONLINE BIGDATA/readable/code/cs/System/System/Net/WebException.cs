// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 14406
{
	// Fields
	private WebExceptionStatus m_Status; // 0x8C
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x34EF964 Offset: 0x34EB964 VA: 0x34EF964
	public void .ctor() { }

	// RVA: 0x34DFDE0 Offset: 0x34DBDE0 VA: 0x34DFDE0
	public void .ctor(string message) { }

	// RVA: 0x34EB798 Offset: 0x34E7798 VA: 0x34EB798
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x34E12DC Offset: 0x34DD2DC VA: 0x34E12DC
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x34EF974 Offset: 0x34EB974 VA: 0x34EF974
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x34DF39C Offset: 0x34DB39C VA: 0x34DF39C
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x34EF9A8 Offset: 0x34EB9A8 VA: 0x34EF9A8
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x34EF990 Offset: 0x34EB990 VA: 0x34EF990
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x34EFA90 Offset: 0x34EBA90 VA: 0x34EFA90
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x34EFB8C Offset: 0x34EBB8C VA: 0x34EFB8C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34EFB9C Offset: 0x34EBB9C VA: 0x34EFB9C Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34EFBA8 Offset: 0x34EBBA8 VA: 0x34EFBA8 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34EFBB0 Offset: 0x34EBBB0 VA: 0x34EFBB0
	public WebExceptionStatus get_Status() { }

	// RVA: 0x34EFBB8 Offset: 0x34EBBB8 VA: 0x34EFBB8
	public WebResponse get_Response() { }
}
