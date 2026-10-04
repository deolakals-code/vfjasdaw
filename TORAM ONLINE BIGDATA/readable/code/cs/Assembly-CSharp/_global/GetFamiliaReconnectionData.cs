// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GetFamiliaReconnectionData : IReconnectionSubData // TypeDefIndex: 5057
{
	// Fields
	private Action<GetFamiliaResponse> callback; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EF81C Offset: 0x25EB81C VA: 0x25EF81C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF824 Offset: 0x25EB824 VA: 0x25EF824 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EF82C Offset: 0x25EB82C VA: 0x25EF82C
	public void .ctor(Action<GetFamiliaResponse> callback) { }

	// RVA: 0x25EF85C Offset: 0x25EB85C VA: 0x25EF85C Slot: 6
	public void Reconnection(Game engine) { }

	// RVA: 0x25EF868 Offset: 0x25EB868 VA: 0x25EF868
	public void Callback(GetFamiliaResponse data) { }
}
