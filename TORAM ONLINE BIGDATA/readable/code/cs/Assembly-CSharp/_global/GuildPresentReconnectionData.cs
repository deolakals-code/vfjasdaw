// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildPresentReconnectionData : IReconnectionSubData // TypeDefIndex: 4884
{
	// Fields
	private GuildPresentType type; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC3A0 Offset: 0x25E83A0 VA: 0x25EC3A0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC3A8 Offset: 0x25E83A8 VA: 0x25EC3A8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC3B0 Offset: 0x25E83B0 VA: 0x25EC3B0
	public void .ctor(GuildPresentType type) { }

	// RVA: 0x25EC3D8 Offset: 0x25E83D8 VA: 0x25EC3D8 Slot: 6
	public void Reconnection(Game engine) { }
}
