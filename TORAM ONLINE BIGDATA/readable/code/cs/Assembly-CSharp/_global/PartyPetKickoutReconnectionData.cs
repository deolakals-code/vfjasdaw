// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyPetKickoutReconnectionData : IReconnectionSubData // TypeDefIndex: 5009
{
	// Fields
	private int kickPetId; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EE85C Offset: 0x25EA85C VA: 0x25EE85C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE864 Offset: 0x25EA864 VA: 0x25EE864 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EE86C Offset: 0x25EA86C VA: 0x25EE86C
	public void .ctor(int kickPetId) { }

	// RVA: 0x25EE894 Offset: 0x25EA894 VA: 0x25EE894 Slot: 6
	public void Reconnection(Game engine) { }
}
