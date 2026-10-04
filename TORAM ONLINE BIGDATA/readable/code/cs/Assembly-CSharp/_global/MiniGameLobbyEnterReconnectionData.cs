// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MiniGameLobbyEnterReconnectionData : IReconnectionSubData // TypeDefIndex: 4934
{
	// Fields
	private int fieldId; // 0x10
	private EmergencyPositionData emergencyPos; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED2FC Offset: 0x25E92FC VA: 0x25ED2FC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED304 Offset: 0x25E9304 VA: 0x25ED304 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED30C Offset: 0x25E930C VA: 0x25ED30C
	public void .ctor(int fieldId, EmergencyPositionData emergencyPos) { }

	// RVA: 0x25ED344 Offset: 0x25E9344 VA: 0x25ED344 Slot: 6
	public void Reconnection(Game engine) { }
}
