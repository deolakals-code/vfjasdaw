// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HousePetOwnershipGetReconnectionData : IReconnectionSubData // TypeDefIndex: 4903
{
	// Fields
	private List<PetSendData> pets; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECA00 Offset: 0x25E8A00 VA: 0x25ECA00 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECA08 Offset: 0x25E8A08 VA: 0x25ECA08 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECA10 Offset: 0x25E8A10 VA: 0x25ECA10
	public void .ctor(List<PetSendData> pets) { }

	// RVA: 0x25ECA40 Offset: 0x25E8A40 VA: 0x25ECA40 Slot: 6
	public void Reconnection(Game engine) { }
}
