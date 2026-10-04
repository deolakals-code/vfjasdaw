// Assembly: System.dll
// Namespace: System.Net
internal class TlsStream : NetworkStream // TypeDefIndex: 14355
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x34DBF4C Offset: 0x34D7F4C VA: 0x34DBF4C
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x34DC03C Offset: 0x34D803C VA: 0x34DC03C
	public void AuthenticateAsClient() { }

	// RVA: 0x34DC13C Offset: 0x34D813C VA: 0x34DC13C
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x34DC254 Offset: 0x34D8254 VA: 0x34DC254
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x34DC278 Offset: 0x34D8278 VA: 0x34DC278 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x34DC29C Offset: 0x34D829C VA: 0x34DC29C Slot: 26
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x34DC2C0 Offset: 0x34D82C0 VA: 0x34DC2C0 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x34DC2E4 Offset: 0x34D82E4 VA: 0x34DC2E4 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x34DC308 Offset: 0x34D8308 VA: 0x34DC308 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x34DC32C Offset: 0x34D832C VA: 0x34DC32C Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x34DC350 Offset: 0x34D8350 VA: 0x34DC350 Slot: 18
	public override void Close() { }
}
