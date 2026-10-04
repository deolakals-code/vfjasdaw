// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 14490
{
	// Fields
	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private long contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x3512370 Offset: 0x350E370 VA: 0x3512370
	public void .ctor() { }

	// RVA: 0x3512378 Offset: 0x350E378 VA: 0x3512378
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x35119A8 Offset: 0x350D9A8 VA: 0x35119A8
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Obsolete("Serialization is obsoleted for this type", False)]
	// RVA: 0x351268C Offset: 0x350E68C VA: 0x351268C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3512A90 Offset: 0x350EA90 VA: 0x3512A90 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x3512A98 Offset: 0x350EA98 VA: 0x3512A98 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x3512B2C Offset: 0x350EB2C VA: 0x3512B2C Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x3512B34 Offset: 0x350EB34 VA: 0x3512B34 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x3512B4C Offset: 0x350EB4C VA: 0x3512B4C Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x3512BE8 Offset: 0x350EBE8 VA: 0x3512BE8 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3512BF4 Offset: 0x350EBF4 VA: 0x3512BF4 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3512DB4 Offset: 0x350EDB4 VA: 0x3512DB4 Slot: 9
	public override void Close() { }

	// RVA: 0x3512DE4 Offset: 0x350EDE4 VA: 0x3512DE4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3512DF4 Offset: 0x350EDF4 VA: 0x3512DF4 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3512AB0 Offset: 0x350EAB0 VA: 0x3512AB0
	private void CheckDisposed() { }

	// RVA: 0x3512464 Offset: 0x350E464 VA: 0x3512464
	private void FillCookies() { }
}
