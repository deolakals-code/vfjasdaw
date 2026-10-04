// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemEquipReconnectionData : IReconnectionSubData // TypeDefIndex: 4974
{
	// Fields
	private Dictionary<byte, long> updateEquips; // 0x10
	private int cost; // 0x18

	// Properties
	public byte SubCode { get; }
	public byte Code { get; }

	// Methods

	// RVA: 0x25EDE50 Offset: 0x25E9E50 VA: 0x25EDE50 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDE58 Offset: 0x25E9E58 VA: 0x25EDE58 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDE60 Offset: 0x25E9E60 VA: 0x25EDE60
	public void .ctor(Dictionary<byte, long> updateEquips, int cost) { }

	// RVA: 0x25EDE9C Offset: 0x25E9E9C VA: 0x25EDE9C Slot: 6
	public void Reconnection(Game engine) { }
}
