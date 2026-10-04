// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AvatarComebackReconnectionData : IReconnectionData // TypeDefIndex: 5055
{
	// Fields
	private Action<AvatarVariableUpdateResponse> callback; // 0x10

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EF790 Offset: 0x25EB790 VA: 0x25EF790 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF798 Offset: 0x25EB798 VA: 0x25EF798
	public void .ctor(Action<AvatarVariableUpdateResponse> callback) { }

	// RVA: 0x25EF7C8 Offset: 0x25EB7C8 VA: 0x25EF7C8 Slot: 5
	public void Reconnection(Game engine) { }

	// RVA: 0x25EF7DC Offset: 0x25EB7DC VA: 0x25EF7DC
	public void Receive(AvatarVariableUpdateResponse reconnection) { }
}
