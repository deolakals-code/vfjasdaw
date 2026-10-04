// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemUseActionReconnectionData : IActionReconnectionData // TypeDefIndex: 4825
{
	// Fields
	private int itemUuid; // 0x10
	private bool isAutoUse; // 0x14

	// Properties
	public ActionCode Type { get; }

	// Methods

	// RVA: 0x25E3498 Offset: 0x25DF498 VA: 0x25E3498 Slot: 4
	public ActionCode get_Type() { }

	// RVA: 0x25E34A0 Offset: 0x25DF4A0 VA: 0x25E34A0
	public void .ctor(int itemUuid, bool isAutoUse) { }

	// RVA: 0x25E34D0 Offset: 0x25DF4D0 VA: 0x25E34D0 Slot: 5
	public void Invoke(Game engine) { }

	// RVA: 0x25E34E8 Offset: 0x25DF4E8 VA: 0x25E34E8 Slot: 6
	public void Cancel() { }
}
