// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecreateStyleReconnectionData : IReconnectionData // TypeDefIndex: 5024
{
	// Fields
	private NewStyleData style; // 0x10
	private Dictionary<int, int> recipes; // 0x18
	private int useOrb; // 0x20
	private int orb; // 0x24

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EECD8 Offset: 0x25EACD8 VA: 0x25EECD8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EECE0 Offset: 0x25EACE0 VA: 0x25EECE0
	public void .ctor(NewStyleData style, Dictionary<int, int> recipe, int orb, int useOrb) { }

	// RVA: 0x25EED3C Offset: 0x25EAD3C VA: 0x25EED3C Slot: 5
	public void Reconnection(Game engine) { }
}
