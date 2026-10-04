// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AddChallengePointRoomReconnectionData : IReconnectionSubData // TypeDefIndex: 5071
{
	// Fields
	private byte index; // 0x10
	private Dictionary<int, byte> clientItems; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFCB4 Offset: 0x25EBCB4 VA: 0x25EFCB4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFCBC Offset: 0x25EBCBC VA: 0x25EFCBC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFCC4 Offset: 0x25EBCC4 VA: 0x25EFCC4
	public void .ctor(byte index, Dictionary<int, byte> clientItems) { }

	// RVA: 0x25EFCFC Offset: 0x25EBCFC VA: 0x25EFCFC Slot: 6
	public void Reconnection(Game engine) { }
}
