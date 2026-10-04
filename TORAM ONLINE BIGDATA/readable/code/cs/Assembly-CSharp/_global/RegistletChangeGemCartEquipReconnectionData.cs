// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegistletChangeGemCartEquipReconnectionData : IReconnectionSubData // TypeDefIndex: 5063
{
	// Fields
	private Dictionary<byte, long> updateEquips; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFA38 Offset: 0x25EBA38 VA: 0x25EFA38 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFA40 Offset: 0x25EBA40 VA: 0x25EFA40 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFA48 Offset: 0x25EBA48 VA: 0x25EFA48
	public void .ctor(Dictionary<byte, long> updateEquips) { }

	// RVA: 0x25EFA78 Offset: 0x25EBA78 VA: 0x25EFA78 Slot: 6
	public void Reconnection(Game engine) { }
}
