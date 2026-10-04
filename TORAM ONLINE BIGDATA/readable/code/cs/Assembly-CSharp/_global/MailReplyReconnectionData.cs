// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MailReplyReconnectionData : IReconnectionData // TypeDefIndex: 5046
{
	// Fields
	private int toAvatarUuid; // 0x10
	private byte mailType; // 0x14
	private string title; // 0x18
	private string message; // 0x20
	private long replyMailId; // 0x28
	private string toAvatarName; // 0x30

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF34C Offset: 0x25EB34C VA: 0x25EF34C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF354 Offset: 0x25EB354 VA: 0x25EF354
	public void .ctor(int toAvatarUuid, byte mailType, string title, string message, long replyMailId, string toAvatarName) { }

	// RVA: 0x25EF3D4 Offset: 0x25EB3D4 VA: 0x25EF3D4 Slot: 5
	public void Reconnection(Game engine) { }
}
