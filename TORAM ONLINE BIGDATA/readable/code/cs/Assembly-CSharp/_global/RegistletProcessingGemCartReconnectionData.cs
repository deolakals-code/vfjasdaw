// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegistletProcessingGemCartReconnectionData : IReconnectionSubData // TypeDefIndex: 5060
{
	// Fields
	private long[] uuid; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EF964 Offset: 0x25EB964 VA: 0x25EF964 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EF96C Offset: 0x25EB96C VA: 0x25EF96C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EF974 Offset: 0x25EB974 VA: 0x25EF974
	public void .ctor(long[] uuid) { }

	// RVA: 0x25EF9A4 Offset: 0x25EB9A4 VA: 0x25EF9A4 Slot: 6
	public void Reconnection(Game engine) { }
}
