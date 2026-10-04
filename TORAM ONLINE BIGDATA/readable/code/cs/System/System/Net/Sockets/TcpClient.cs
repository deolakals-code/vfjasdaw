// Assembly: System.dll
// Namespace: System.Net.Sockets
public class TcpClient : IDisposable // TypeDefIndex: 14587
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0x345DDA0 Offset: 0x3459DA0 VA: 0x345DDA0
	public void .ctor() { }

	// RVA: 0x345DDC0 Offset: 0x3459DC0 VA: 0x345DDC0
	public void .ctor(AddressFamily family) { }

	// RVA: 0x345DF40 Offset: 0x3459F40 VA: 0x345DF40
	public Socket get_Client() { }

	// RVA: 0x345DF48 Offset: 0x3459F48 VA: 0x345DF48
	public void set_Client(Socket value) { }

	// RVA: 0x345DF50 Offset: 0x3459F50 VA: 0x345DF50
	public void Connect(string hostname, int port) { }

	// RVA: 0x345E5E0 Offset: 0x345A5E0 VA: 0x345E5E0
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x345E6DC Offset: 0x345A6DC VA: 0x345E6DC
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x345E744 Offset: 0x345A744 VA: 0x345E744
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x345E788 Offset: 0x345A788 VA: 0x345E788
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x345E8F4 Offset: 0x345A8F4 VA: 0x345E8F4
	public NetworkStream GetStream() { }

	// RVA: 0x345EA38 Offset: 0x345AA38 VA: 0x345EA38 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x345EBFC Offset: 0x345ABFC VA: 0x345EBFC Slot: 4
	public void Dispose() { }

	// RVA: 0x345EC0C Offset: 0x345AC0C VA: 0x345EC0C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x345DECC Offset: 0x3459ECC VA: 0x345DECC
	private void initialize() { }
}
