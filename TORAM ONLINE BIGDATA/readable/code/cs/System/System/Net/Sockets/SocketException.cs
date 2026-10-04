// Assembly: System.dll
// Namespace: System.Net.Sockets
[Serializable]
public class SocketException : Win32Exception // TypeDefIndex: 14572
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x345DCE8 Offset: 0x3459CE8 VA: 0x345DCE8
	private static int WSAGetLastError_icall() { }

	// RVA: 0x3452008 Offset: 0x344E008 VA: 0x3452008
	public void .ctor() { }

	// RVA: 0x345DCEC Offset: 0x3459CEC VA: 0x345DCEC
	internal void .ctor(int error, string message) { }

	// RVA: 0x344E27C Offset: 0x344A27C VA: 0x344E27C
	public void .ctor(int errorCode) { }

	// RVA: 0x3452D1C Offset: 0x344ED1C VA: 0x3452D1C
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x345DCF4 Offset: 0x3459CF4 VA: 0x345DCF4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x345DCFC Offset: 0x3459CFC VA: 0x345DCFC Slot: 5
	public override string get_Message() { }

	// RVA: 0x345BB54 Offset: 0x3457B54 VA: 0x345BB54
	public SocketError get_SocketErrorCode() { }
}
