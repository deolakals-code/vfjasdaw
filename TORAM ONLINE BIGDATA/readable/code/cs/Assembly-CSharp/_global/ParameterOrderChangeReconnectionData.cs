// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParameterOrderChangeReconnectionData : IReconnectionSubData // TypeDefIndex: 5083
{
	// Fields
	private byte[] sortList; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25F0078 Offset: 0x25EC078 VA: 0x25F0078 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25F0080 Offset: 0x25EC080 VA: 0x25F0080 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25F0088 Offset: 0x25EC088 VA: 0x25F0088
	public void .ctor(byte[] sortList) { }

	// RVA: 0x25F00B8 Offset: 0x25EC0B8 VA: 0x25F00B8 Slot: 6
	public void Reconnection(Game engine) { }
}
