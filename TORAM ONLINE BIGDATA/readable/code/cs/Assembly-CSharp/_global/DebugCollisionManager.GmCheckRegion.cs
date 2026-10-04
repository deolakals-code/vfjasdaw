// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DebugCollisionManager.GmCheckRegion : IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1767
{
	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x20DE1F8 Offset: 0x20DA1F8 VA: 0x20DE1F8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x20DE200 Offset: 0x20DA200 VA: 0x20DE200 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x20DE208 Offset: 0x20DA208 VA: 0x20DE208
	private GameReturnCode ErrReturnCode(string word) { }

	// RVA: 0x20DE2A4 Offset: 0x20DA2A4 VA: 0x20DE2A4 Slot: 8
	public GameReturnCode ReceiveResponse(Game game, OperationResponse operationResponse) { }

	// RVA: 0x20DE5E0 Offset: 0x20DA5E0 VA: 0x20DE5E0 Slot: 6
	public void Reconnection(Game engine) { }

	// RVA: 0x20DE5E4 Offset: 0x20DA5E4 VA: 0x20DE5E4 Slot: 7
	public void SendOperation(Game engine) { }

	// RVA: 0x20DE5E8 Offset: 0x20DA5E8 VA: 0x20DE5E8
	public void .ctor() { }
}
