// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GenericFlagReconnectionData : IReconnectionData // TypeDefIndex: 5026
{
	// Fields
	private GenericFlagId flagId; // 0x10
	private string flagData; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EED70 Offset: 0x25EAD70 VA: 0x25EED70 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EED78 Offset: 0x25EAD78 VA: 0x25EED78
	public void .ctor(GenericFlagId id, string data) { }

	// RVA: 0x25EEDB0 Offset: 0x25EADB0 VA: 0x25EEDB0 Slot: 5
	public void Reconnection(Game engine) { }
}
