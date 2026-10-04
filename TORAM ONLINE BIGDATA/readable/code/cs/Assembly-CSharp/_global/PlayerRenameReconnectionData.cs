// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerRenameReconnectionData : IReconnectionData // TypeDefIndex: 5037
{
	// Fields
	private string name; // 0x10
	private int orbNum; // 0x18
	private int useOrbNum; // 0x1C

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF098 Offset: 0x25EB098 VA: 0x25EF098 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF0A0 Offset: 0x25EB0A0 VA: 0x25EF0A0
	public void .ctor(string name, int orbNum, int useOrbNum) { }

	// RVA: 0x25EF0E8 Offset: 0x25EB0E8 VA: 0x25EF0E8 Slot: 5
	public void Reconnection(Game engine) { }
}
