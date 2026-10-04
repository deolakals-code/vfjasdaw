// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections
[CLSCompliant(False)]
public abstract class OperationRelatedExplainBase // TypeDefIndex: 14902
{
	// Properties
	public abstract byte Code { get; }
	public abstract byte SubCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Code();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte get_SubCode();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract OperationRequestBase GetOperationParameter();

	// RVA: 0x355F54C Offset: 0x355B54C VA: 0x355F54C Slot: 7
	public virtual void SendOperation(Game engine) { }

	// RVA: 0x355F58C Offset: 0x355B58C VA: 0x355F58C Slot: 8
	public virtual void Reconnection(Game engine) { }

	// RVA: 0x355F084 Offset: 0x355B084 VA: 0x355F084
	protected internal void Send(Game engine, OperationRequestBase operation, bool sendReliable = True, bool encrypt = False) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse);

	// RVA: 0x355F598 Offset: 0x355B598 VA: 0x355F598 Slot: 3
	public override string ToString() { }

	// RVA: 0x355F678 Offset: 0x355B678 VA: 0x355F678
	public static bool IsExplainCode(byte code, byte subCode = 0) { }

	// RVA: 0x355F734 Offset: 0x355B734 VA: 0x355F734
	public static bool IsChangeFieldExplainCode(byte code, byte subCode = 0) { }

	// RVA: 0x355EFD4 Offset: 0x355AFD4 VA: 0x355EFD4
	protected void .ctor() { }
}
