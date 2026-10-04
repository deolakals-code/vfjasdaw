// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildChangeOnlineNoticeReconnectionData : IReconnectionSubData // TypeDefIndex: 4889
{
	// Fields
	private byte type; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC4FC Offset: 0x25E84FC VA: 0x25EC4FC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC504 Offset: 0x25E8504 VA: 0x25EC504 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC50C Offset: 0x25E850C VA: 0x25EC50C
	public void .ctor(byte type) { }

	// RVA: 0x25EC534 Offset: 0x25E8534 VA: 0x25EC534 Slot: 6
	public void Reconnection(Game engine) { }
}
