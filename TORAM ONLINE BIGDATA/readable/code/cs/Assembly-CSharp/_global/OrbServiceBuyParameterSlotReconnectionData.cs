// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyParameterSlotReconnectionData : IReconnectionSubData // TypeDefIndex: 4957
{
	// Fields
	private int orbNum; // 0x10
	private int useOrb; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED93C Offset: 0x25E993C VA: 0x25ED93C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED944 Offset: 0x25E9944 VA: 0x25ED944 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED94C Offset: 0x25E994C VA: 0x25ED94C
	public void .ctor(int orbNum, int useOrb) { }

	// RVA: 0x25ED978 Offset: 0x25E9978 VA: 0x25ED978 Slot: 6
	public void Reconnection(Game engine) { }
}
