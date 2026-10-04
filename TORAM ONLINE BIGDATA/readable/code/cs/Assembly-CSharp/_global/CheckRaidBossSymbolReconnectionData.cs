// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CheckRaidBossSymbolReconnectionData : IReconnectionSubData // TypeDefIndex: 5005
{
	// Fields
	private int fieldId; // 0x10
	private byte roomId; // 0x14
	private bool isMatching; // 0x15

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EE6BC Offset: 0x25EA6BC VA: 0x25EE6BC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE6C4 Offset: 0x25EA6C4 VA: 0x25EE6C4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EE6CC Offset: 0x25EA6CC VA: 0x25EE6CC
	public void .ctor(int fieldId, byte roomId, bool isMatching) { }

	// RVA: 0x25EE71C Offset: 0x25EA71C VA: 0x25EE71C Slot: 6
	public void Reconnection(Game engine) { }
}
