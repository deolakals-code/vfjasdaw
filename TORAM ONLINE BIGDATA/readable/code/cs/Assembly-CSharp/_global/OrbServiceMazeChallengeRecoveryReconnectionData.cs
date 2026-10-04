// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceMazeChallengeRecoveryReconnectionData : IReconnectionSubData // TypeDefIndex: 4961
{
	// Fields
	private int orbNum; // 0x10
	private int type; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EDAA0 Offset: 0x25E9AA0 VA: 0x25EDAA0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDAA8 Offset: 0x25E9AA8 VA: 0x25EDAA8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDAB0 Offset: 0x25E9AB0 VA: 0x25EDAB0
	public void .ctor(int orbNum, int type) { }

	// RVA: 0x25EDADC Offset: 0x25E9ADC VA: 0x25EDADC Slot: 6
	public void Reconnection(Game engine) { }
}
