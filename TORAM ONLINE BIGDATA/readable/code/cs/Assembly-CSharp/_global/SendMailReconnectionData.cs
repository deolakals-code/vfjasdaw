// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SendMailReconnectionData : IReconnectionData // TypeDefIndex: 5041
{
	// Fields
	private int toAvatarUuid; // 0x10
	private byte mailType; // 0x14
	private string title; // 0x18
	private string message; // 0x20
	private byte sendType; // 0x28
	private ItemSelectData data; // 0x30

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF1AC Offset: 0x25EB1AC VA: 0x25EF1AC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF1B4 Offset: 0x25EB1B4 VA: 0x25EF1B4
	public void .ctor(int toAvatarUuid, byte mailType, string title, string message, ItemSelectData data, byte sendType) { }

	// RVA: 0x25EF234 Offset: 0x25EB234 VA: 0x25EF234 Slot: 5
	public void Reconnection(Game engine) { }
}
