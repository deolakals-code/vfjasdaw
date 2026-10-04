// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegistletEnhanceGemCartReconnectionData : IReconnectionSubData // TypeDefIndex: 5061
{
	// Fields
	private long enhanceUuid; // 0x10
	private long[] materialUuid; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EF9B8 Offset: 0x25EB9B8 VA: 0x25EF9B8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF9C0 Offset: 0x25EB9C0 VA: 0x25EF9C0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EF9C8 Offset: 0x25EB9C8 VA: 0x25EF9C8
	public void .ctor(long enhanceUuid, long[] materialUuid) { }

	// RVA: 0x25EFA00 Offset: 0x25EBA00 VA: 0x25EFA00 Slot: 6
	public void Reconnection(Game engine) { }
}
