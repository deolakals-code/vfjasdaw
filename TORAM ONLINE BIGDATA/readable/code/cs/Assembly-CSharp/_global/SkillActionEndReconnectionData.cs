// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillActionEndReconnectionData : IActionReconnectionData // TypeDefIndex: 4827
{
	// Fields
	private short skillId; // 0x10
	private byte localId; // 0x12

	// Properties
	public ActionCode Type { get; }

	// Methods

	// RVA: 0x25E3540 Offset: 0x25DF540 VA: 0x25E3540 Slot: 4
	public ActionCode get_Type() { }

	// RVA: 0x25E3548 Offset: 0x25DF548 VA: 0x25E3548
	public void .ctor(short skillId, byte localId) { }

	// RVA: 0x25E3578 Offset: 0x25DF578 VA: 0x25E3578 Slot: 6
	public void Cancel() { }

	// RVA: 0x25E357C Offset: 0x25DF57C VA: 0x25E357C Slot: 5
	public void Invoke(Game engine) { }
}
