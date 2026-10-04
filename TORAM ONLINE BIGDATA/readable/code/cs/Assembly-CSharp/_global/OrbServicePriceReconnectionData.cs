// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServicePriceReconnectionData : IReconnectionSubData // TypeDefIndex: 4949
{
	// Fields
	private OrbServiceType type; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED6D0 Offset: 0x25E96D0 VA: 0x25ED6D0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED6D8 Offset: 0x25E96D8 VA: 0x25ED6D8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED6E0 Offset: 0x25E96E0 VA: 0x25ED6E0
	public void .ctor(OrbServiceType type) { }

	// RVA: 0x25ED708 Offset: 0x25E9708 VA: 0x25ED708 Slot: 6
	public void Reconnection(Game engine) { }
}
