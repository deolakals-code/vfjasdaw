// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceTreasureHuntRecoveryReconnectionData : IReconnectionSubData // TypeDefIndex: 4962
{
	// Fields
	private int orbNum; // 0x10
	private int type; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EDB08 Offset: 0x25E9B08 VA: 0x25EDB08 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDB10 Offset: 0x25E9B10 VA: 0x25EDB10 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDB18 Offset: 0x25E9B18 VA: 0x25EDB18
	public void .ctor(int orbNum, int type) { }

	// RVA: 0x25EDB44 Offset: 0x25E9B44 VA: 0x25EDB44 Slot: 6
	public void Reconnection(Game engine) { }
}
