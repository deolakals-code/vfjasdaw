// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParameterRegisterReconnectionData : IReconnectionData // TypeDefIndex: 5077
{
	// Fields
	private NewStyleData Style; // 0x10
	private byte WeaponNo; // 0x18
	private bool isNewMission; // 0x19

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EFE5C Offset: 0x25EBE5C VA: 0x25EFE5C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFE64 Offset: 0x25EBE64 VA: 0x25EFE64
	public void .ctor(NewStyleData style, byte weaponNo) { }

	// RVA: 0x25EFEA8 Offset: 0x25EBEA8 VA: 0x25EFEA8
	public void .ctor(NewStyleData style, byte weaponNo, bool isNewMission) { }

	// RVA: 0x25EFEF4 Offset: 0x25EBEF4 VA: 0x25EFEF4 Slot: 5
	public void Reconnection(Game engine) { }
}
