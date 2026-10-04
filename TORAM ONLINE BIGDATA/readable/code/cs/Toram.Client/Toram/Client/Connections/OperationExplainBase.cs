// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections
[CLSCompliant(False)]
public abstract class OperationExplainBase // TypeDefIndex: 14901
{
	// Properties
	public abstract byte Code { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Code();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract PacketBase GetOperationParameter();

	// RVA: 0x355F374 Offset: 0x355B374 VA: 0x355F374 Slot: 6
	public virtual void SendOperation(Game engine) { }

	// RVA: 0x355F538 Offset: 0x355B538 VA: 0x355F538 Slot: 7
	public virtual void Reconnection(Game engine) { }

	// RVA: 0x355F3B4 Offset: 0x355B3B4 VA: 0x355F3B4
	protected internal void Send(Game engine, PacketBase operation, bool sendReliable = True, bool encrypt = False) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse);

	// RVA: 0x355F544 Offset: 0x355B544 VA: 0x355F544
	protected void .ctor() { }
}
