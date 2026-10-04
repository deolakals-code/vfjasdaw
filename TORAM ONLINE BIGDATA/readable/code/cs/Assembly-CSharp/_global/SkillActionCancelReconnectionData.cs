// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillActionCancelReconnectionData : IActionReconnectionData // TypeDefIndex: 4826
{
	// Fields
	private short skillId; // 0x10
	private byte localId; // 0x12

	// Properties
	public ActionCode Type { get; }

	// Methods

	// RVA: 0x25E34EC Offset: 0x25DF4EC VA: 0x25E34EC Slot: 4
	public ActionCode get_Type() { }

	// RVA: 0x25E34F4 Offset: 0x25DF4F4 VA: 0x25E34F4
	public void .ctor(short skillId, byte localId) { }

	// RVA: 0x25E3524 Offset: 0x25DF524 VA: 0x25E3524 Slot: 6
	public void Cancel() { }

	// RVA: 0x25E3528 Offset: 0x25DF528 VA: 0x25E3528 Slot: 5
	public void Invoke(Game engine) { }
}
