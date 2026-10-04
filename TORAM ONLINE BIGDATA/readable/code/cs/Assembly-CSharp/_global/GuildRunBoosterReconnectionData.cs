// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRunBoosterReconnectionData : IReconnectionSubData // TypeDefIndex: 4883
{
	// Fields
	private GuildBoosterType type; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC354 Offset: 0x25E8354 VA: 0x25EC354 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC35C Offset: 0x25E835C VA: 0x25EC35C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC364 Offset: 0x25E8364 VA: 0x25EC364
	public void .ctor(GuildBoosterType type) { }

	// RVA: 0x25EC38C Offset: 0x25E838C VA: 0x25EC38C Slot: 6
	public void Reconnection(Game engine) { }
}
