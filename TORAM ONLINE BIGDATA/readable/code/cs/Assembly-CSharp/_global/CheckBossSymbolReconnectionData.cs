// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CheckBossSymbolReconnectionData : IReconnectionData // TypeDefIndex: 5003
{
	// Fields
	private int fieldId; // 0x10
	private byte roomId; // 0x14
	private bool forcibly; // 0x15

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE60C Offset: 0x25EA60C VA: 0x25EE60C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE614 Offset: 0x25EA614 VA: 0x25EE614
	public void .ctor(int fieldId, byte roomId, bool forcibly) { }

	// RVA: 0x25EE65C Offset: 0x25EA65C VA: 0x25EE65C Slot: 5
	public void Reconnection(Game engine) { }
}
