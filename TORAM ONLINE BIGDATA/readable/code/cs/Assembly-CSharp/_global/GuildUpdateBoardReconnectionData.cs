// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildUpdateBoardReconnectionData : IReconnectionData // TypeDefIndex: 4875
{
	// Fields
	private byte type; // 0x10
	private string message; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EC070 Offset: 0x25E8070 VA: 0x25EC070 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC078 Offset: 0x25E8078 VA: 0x25EC078
	public void .ctor(byte type, string message) { }

	// RVA: 0x25EC100 Offset: 0x25E8100 VA: 0x25EC100 Slot: 5
	public void Reconnection(Game engine) { }
}
