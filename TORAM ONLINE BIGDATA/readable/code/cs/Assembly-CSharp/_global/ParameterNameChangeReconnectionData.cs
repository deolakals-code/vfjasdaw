// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParameterNameChangeReconnectionData : IReconnectionData // TypeDefIndex: 5082
{
	// Fields
	private byte parameterId; // 0x10
	private string parameterName; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EFFD8 Offset: 0x25EBFD8 VA: 0x25EFFD8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFFE0 Offset: 0x25EBFE0 VA: 0x25EFFE0
	public void .ctor(byte id, string name) { }

	// RVA: 0x25F0060 Offset: 0x25EC060 VA: 0x25F0060 Slot: 5
	public void Reconnection(Game engine) { }
}
