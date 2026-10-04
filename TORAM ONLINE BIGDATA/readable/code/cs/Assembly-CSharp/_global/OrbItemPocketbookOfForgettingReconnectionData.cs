// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbItemPocketbookOfForgettingReconnectionData : IReconnectionSubData // TypeDefIndex: 4942
{
	// Fields
	private int orbItemId; // 0x10
	private int targetSkillTreeType; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED498 Offset: 0x25E9498 VA: 0x25ED498 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED4A0 Offset: 0x25E94A0 VA: 0x25ED4A0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED4A8 Offset: 0x25E94A8 VA: 0x25ED4A8
	public void .ctor(int orbItemId, int targetSkillTreeType) { }

	// RVA: 0x25ED4D4 Offset: 0x25E94D4 VA: 0x25ED4D4 Slot: 6
	public void Reconnection(Game engine) { }
}
