// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MailGetBoxReconnectionData : IReconnectionData // TypeDefIndex: 5044
{
	// Fields
	private MailCountType mailType; // 0x10
	private long mailUniqueId; // 0x18
	private int page; // 0x20
	private Dictionary<long, byte> mailUpdateStates; // 0x28

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF290 Offset: 0x25EB290 VA: 0x25EF290 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF298 Offset: 0x25EB298 VA: 0x25EF298
	public void .ctor(MailCountType mailType, long mailUniqueId, int page, Dictionary<long, byte> mailUpdateStates) { }

	// RVA: 0x25EF2E8 Offset: 0x25EB2E8 VA: 0x25EF2E8 Slot: 5
	public void Reconnection(Game engine) { }
}
