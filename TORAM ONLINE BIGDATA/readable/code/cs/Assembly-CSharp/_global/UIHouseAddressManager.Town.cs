// Assembly: Assembly-CSharp.dll
// Namespace: 
private struct UIHouseAddressManager.Town // TypeDefIndex: 7187
{
	// Fields
	internal byte Id; // 0x0
	private short NeedMission; // 0x2
	private GameEventType EventType; // 0x4
	private bool IsGmOnly; // 0x5
	private bool IsEasyRegisterOnly; // 0x6

	// Properties
	internal bool IsRegisterEnable { get; }
	internal bool IsEasyRegisterEnable { get; }
	internal bool IsSearchEnable { get; }

	// Methods

	// RVA: 0x1AD3610 Offset: 0x1ACF610 VA: 0x1AD3610
	internal void .ctor(byte id, short needMission, GameEventType eventType, bool isGmOnly, bool isEasyRegisterOnly) { }

	// RVA: 0x1AD1710 Offset: 0x1ACD710 VA: 0x1AD1710
	internal bool get_IsRegisterEnable() { }

	// RVA: 0x1AD17D0 Offset: 0x1ACD7D0 VA: 0x1AD17D0
	internal bool get_IsEasyRegisterEnable() { }

	// RVA: 0x1AD1888 Offset: 0x1ACD888 VA: 0x1AD1888
	internal bool get_IsSearchEnable() { }
}
