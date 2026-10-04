// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ReconnectionManager : Singleton<ReconnectionManager> // TypeDefIndex: 5108
{
	// Fields
	private Game engine; // 0x20
	private Dictionary<byte, IReconnectionData> reconnectionData; // 0x28
	private Dictionary<byte, Dictionary<byte, IReconnectionSubData>> reconnectionSubData; // 0x30
	private Dictionary<byte, short> reconnectionErrData; // 0x38
	private Dictionary<byte, Dictionary<byte, short>> reconnectionSubErrData; // 0x40

	// Methods

	// RVA: 0x25F07D4 Offset: 0x25EC7D4 VA: 0x25F07D4
	public void Initialize(Game engine) { }

	// RVA: 0x25F07DC Offset: 0x25EC7DC VA: 0x25F07DC
	public void Clear() { }

	// RVA: 0x25F0B30 Offset: 0x25ECB30 VA: 0x25F0B30
	public bool Contains(OperationCode type) { }

	// RVA: 0x25F0B88 Offset: 0x25ECB88 VA: 0x25F0B88
	public bool Contains(OperationCode type, byte subCode) { }

	// RVA: 0x25F0C30 Offset: 0x25ECC30 VA: 0x25F0C30
	public void Add(IReconnectionData data) { }

	// RVA: 0x25F0E48 Offset: 0x25ECE48 VA: 0x25F0E48
	public void Add(IReconnectionSubData data) { }

	// RVA: 0x25F12C0 Offset: 0x25ED2C0 VA: 0x25F12C0
	public bool OperationConnection(IReconnectionData sendOperation) { }

	// RVA: 0x25F1534 Offset: 0x25ED534 VA: 0x25F1534
	public bool OperationConnection(IReconnectionSubData sendOperation) { }

	// RVA: 0x25F1A28 Offset: 0x25EDA28 VA: 0x25F1A28
	public void Remove(OperationCode code) { }

	// RVA: 0x25F1A80 Offset: 0x25EDA80 VA: 0x25F1A80
	public void Remove(OperationCode code, byte subCode) { }

	// RVA: 0x25F1B1C Offset: 0x25EDB1C VA: 0x25F1B1C
	public IReconnectionData Pop(OperationCode type) { }

	// RVA: 0x25F1BC0 Offset: 0x25EDBC0 VA: 0x25F1BC0
	public IReconnectionSubData Pop(OperationCode type, byte subCode) { }

	// RVA: 0x25F1CA8 Offset: 0x25EDCA8 VA: 0x25F1CA8
	public bool ReceiveResponse(Game engine, byte type, OperationResponse operationResponse) { }

	// RVA: 0x25F1FC0 Offset: 0x25EDFC0 VA: 0x25F1FC0
	public bool ReceiveResponse(Game engine, byte type, byte subCode, OperationResponse operationResponse) { }

	// RVA: 0x25F2400 Offset: 0x25EE400 VA: 0x25F2400
	public UIBasePanel PopUIBasePanelManager(OperationCode code) { }

	// RVA: 0x25F24B8 Offset: 0x25EE4B8 VA: 0x25F24B8
	public UIBasePanel PopUIBasePanelManager(OperationCode code, byte subCode) { }

	// RVA: 0x25F1EF8 Offset: 0x25EDEF8 VA: 0x25F1EF8
	public bool Err(OperationCode code, short returnCode) { }

	// RVA: 0x25F2254 Offset: 0x25EE254 VA: 0x25F2254
	public bool Err(OperationCode code, byte subCode, short returnCode) { }

	// RVA: 0x25F2580 Offset: 0x25EE580 VA: 0x25F2580
	public bool ErrResponse(OperationCode code, short returnCode) { }

	// RVA: 0x25F270C Offset: 0x25EE70C VA: 0x25F270C
	public bool ErrResponse(OperationCode code, byte subCode, short returnCode) { }

	// RVA: 0x25F297C Offset: 0x25EE97C VA: 0x25F297C
	public UIBasePanel ErrPopUIBasePanelManager(OperationCode code, byte subCode, short returnCode) { }

	// RVA: 0x25F2AD4 Offset: 0x25EEAD4 VA: 0x25F2AD4
	public bool TryGetErr(OperationCode type, out short returnCode) { }

	// RVA: 0x25F2B3C Offset: 0x25EEB3C VA: 0x25F2B3C
	public bool TryGetErr(OperationCode type, byte subCode, out short returnCode) { }

	// RVA: 0x25F0DF0 Offset: 0x25ECDF0 VA: 0x25F0DF0
	public void ErrClear(byte type) { }

	// RVA: 0x25F11D0 Offset: 0x25ED1D0 VA: 0x25F11D0
	public void ErrClear(byte type, byte subCode) { }

	// RVA: 0x25F2BF8 Offset: 0x25EEBF8 VA: 0x25F2BF8
	public void Invoke() { }

	// RVA: 0x25F30F8 Offset: 0x25EF0F8 VA: 0x25F30F8
	public void .ctor() { }
}
