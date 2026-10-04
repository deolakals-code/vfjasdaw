// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseRhythmFinishReconnectionData : IReconnectionSubData // TypeDefIndex: 4911
{
	// Fields
	private short critical; // 0x10
	private short hit; // 0x12
	private short graze; // 0x14
	private short miss; // 0x16

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECC74 Offset: 0x25E8C74 VA: 0x25ECC74 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECC7C Offset: 0x25E8C7C VA: 0x25ECC7C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECC84 Offset: 0x25E8C84 VA: 0x25ECC84
	public void .ctor(short critical, short hit, short graze, short miss) { }

	// RVA: 0x25ECCCC Offset: 0x25E8CCC VA: 0x25ECCCC Slot: 6
	public void Reconnection(Game engine) { }
}
