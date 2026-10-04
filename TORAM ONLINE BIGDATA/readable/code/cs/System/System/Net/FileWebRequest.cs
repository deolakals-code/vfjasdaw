// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 14451
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private bool m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private bool m_syncHint; // 0x90
	private int m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private bool m_writePending; // 0xA0
	private bool m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private int m_Aborted; // 0xB8

	// Properties
	internal bool Aborted { get; }
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; }

	// Methods

	// RVA: 0x350162C Offset: 0x34FD62C VA: 0x350162C
	internal void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x35017B4 Offset: 0x34FD7B4 VA: 0x35017B4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3501BE4 Offset: 0x34FDBE4 VA: 0x3501BE4 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3501BF0 Offset: 0x34FDBF0 VA: 0x3501BF0 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3501E98 Offset: 0x34FDE98 VA: 0x3501E98
	internal bool get_Aborted() { }

	// RVA: 0x3501EA8 Offset: 0x34FDEA8 VA: 0x3501EA8 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x3501EB0 Offset: 0x34FDEB0 VA: 0x3501EB0 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x3501EB8 Offset: 0x34FDEB8 VA: 0x3501EB8 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x3501EC0 Offset: 0x34FDEC0 VA: 0x3501EC0 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x3501EC8 Offset: 0x34FDEC8 VA: 0x3501EC8 Slot: 9
	public override string get_Method() { }

	// RVA: 0x3501ED0 Offset: 0x34FDED0 VA: 0x3501ED0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x3501FAC Offset: 0x34FDFAC VA: 0x3501FAC Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x3501FB4 Offset: 0x34FDFB4 VA: 0x3501FB4 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x3501FBC Offset: 0x34FDFBC VA: 0x3501FBC Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x3501FC4 Offset: 0x34FDFC4 VA: 0x3501FC4 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x3501FCC Offset: 0x34FDFCC VA: 0x3501FCC Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x35022A4 Offset: 0x34FE2A4 VA: 0x35022A4 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x3502590 Offset: 0x34FE590 VA: 0x3502590 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x35028E4 Offset: 0x34FE8E4 VA: 0x35028E4
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x3502BA8 Offset: 0x34FEBA8 VA: 0x3502BA8
	private static void GetResponseCallback(object state) { }

	// RVA: 0x35031D4 Offset: 0x34FF1D4 VA: 0x35031D4
	internal void UnblockReader() { }

	// RVA: 0x35032AC Offset: 0x34FF2AC VA: 0x35032AC Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x35032D4 Offset: 0x34FF2D4 VA: 0x35032D4 Slot: 24
	public override void Abort() { }

	// RVA: 0x3503648 Offset: 0x34FF648 VA: 0x3503648
	private static void .cctor() { }
}
