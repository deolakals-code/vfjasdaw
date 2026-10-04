// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class ExecuteSignboardOfCristaExReconnectionData : IReconnectionSubData // TypeDefIndex: 5099
{
	// Fields
	private int targetId; // 0x10
	private int itemId; // 0x14
	private DateTime dateTime; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F04AC Offset: 0x25EC4AC VA: 0x25F04AC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F04B4 Offset: 0x25EC4B4 VA: 0x25F04B4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F04BC Offset: 0x25EC4BC VA: 0x25F04BC
	public void .ctor(int targetId, int itemId, DateTime dateTime) { }

	// RVA: 0x25F04F8 Offset: 0x25EC4F8 VA: 0x25F04F8 Slot: 6
	public void Reconnection(Game engine) { }
}
