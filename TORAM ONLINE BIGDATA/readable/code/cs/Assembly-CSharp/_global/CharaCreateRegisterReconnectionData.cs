// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CharaCreateRegisterReconnectionData : IReconnectionData // TypeDefIndex: 4987
{
	// Fields
	private string Name; // 0x10
	private NewStyleData Style; // 0x18
	private byte WeaponNo; // 0x20

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE238 Offset: 0x25EA238 VA: 0x25EE238 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE240 Offset: 0x25EA240 VA: 0x25EE240
	public void .ctor(string name, NewStyleData style, byte weaponNo) { }

	// RVA: 0x25EE298 Offset: 0x25EA298 VA: 0x25EE298 Slot: 5
	public void Reconnection(Game engine) { }
}
