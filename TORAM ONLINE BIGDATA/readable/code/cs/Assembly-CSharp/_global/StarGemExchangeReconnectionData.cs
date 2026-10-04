// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemExchangeReconnectionData : IReconnectionSubData // TypeDefIndex: 4972
{
	// Fields
	private int useShard; // 0x10
	private short skillId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EDDAC Offset: 0x25E9DAC VA: 0x25EDDAC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDDB4 Offset: 0x25E9DB4 VA: 0x25EDDB4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDDBC Offset: 0x25E9DBC VA: 0x25EDDBC
	public void .ctor(int useShard, short skillId) { }

	// RVA: 0x25EDDEC Offset: 0x25E9DEC VA: 0x25EDDEC Slot: 6
	public void Reconnection(Game engine) { }
}
