// Assembly: System.dll
// Namespace: System.Net
public class FtpWebResponse : WebResponse, IDisposable // TypeDefIndex: 14382
{
	// Fields
	internal Stream _responseStream; // 0x20
	private long _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public FtpStatusCode StatusCode { get; }

	// Methods

	// RVA: 0x34ECE28 Offset: 0x34E8E28 VA: 0x34ECE28
	internal void .ctor(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x34EB7A8 Offset: 0x34E77A8 VA: 0x34EB7A8
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x34ED620 Offset: 0x34E9620 VA: 0x34ED620 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x34ECD80 Offset: 0x34E8D80 VA: 0x34ECD80
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x34ED728 Offset: 0x34E9728 VA: 0x34ED728 Slot: 9
	public override void Close() { }

	// RVA: 0x34ED81C Offset: 0x34E981C VA: 0x34ED81C Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x34ED930 Offset: 0x34E9930 VA: 0x34ED930 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x34ED938 Offset: 0x34E9938 VA: 0x34ED938
	public FtpStatusCode get_StatusCode() { }
}
