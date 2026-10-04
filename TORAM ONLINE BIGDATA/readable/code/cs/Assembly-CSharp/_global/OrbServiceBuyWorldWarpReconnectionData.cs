// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyWorldWarpReconnectionData : IReconnectionSubData // TypeDefIndex: 4951
{
	// Fields
	private int orbNum; // 0x10
	private int fieldId; // 0x14
	private byte locationId; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED740 Offset: 0x25E9740 VA: 0x25ED740 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED748 Offset: 0x25E9748 VA: 0x25ED748 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED750 Offset: 0x25E9750 VA: 0x25ED750
	public void .ctor(int orbNum, int fieldId, byte locationId) { }

	// RVA: 0x25ED78C Offset: 0x25E978C VA: 0x25ED78C Slot: 6
	public void Reconnection(Game engine) { }
}
