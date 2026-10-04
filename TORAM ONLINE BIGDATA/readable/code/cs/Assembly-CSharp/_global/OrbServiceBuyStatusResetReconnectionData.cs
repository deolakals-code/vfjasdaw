// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyStatusResetReconnectionData : IReconnectionSubData // TypeDefIndex: 4952
{
	// Fields
	private int orbNum; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED7A4 Offset: 0x25E97A4 VA: 0x25ED7A4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED7AC Offset: 0x25E97AC VA: 0x25ED7AC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED7B4 Offset: 0x25E97B4 VA: 0x25ED7B4
	public void .ctor(int orbNum) { }

	// RVA: 0x25ED7DC Offset: 0x25E97DC VA: 0x25ED7DC Slot: 6
	public void Reconnection(Game engine) { }
}
