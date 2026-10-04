// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CultivationRemoveReconnectionData : IReconnectionSubData // TypeDefIndex: 4905
{
	// Fields
	private short index; // 0x10
	private int produceId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECACC Offset: 0x25E8ACC VA: 0x25ECACC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECAD4 Offset: 0x25E8AD4 VA: 0x25ECAD4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECADC Offset: 0x25E8ADC VA: 0x25ECADC
	public void .ctor(short index, int produceId) { }

	// RVA: 0x25ECB0C Offset: 0x25E8B0C VA: 0x25ECB0C Slot: 6
	public void Reconnection(Game engine) { }
}
