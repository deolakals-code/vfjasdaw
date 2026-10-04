// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LibraryReconnectionData : IReconnectionData // TypeDefIndex: 4982
{
	// Fields
	private int shopId; // 0x10
	private byte skillTreeType; // 0x14
	private byte skillTreeLv; // 0x15
	private int cost; // 0x18
	private short[] pos; // 0x20

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE0D0 Offset: 0x25EA0D0 VA: 0x25EE0D0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE0D8 Offset: 0x25EA0D8 VA: 0x25EE0D8
	public void .ctor(int shopid, byte treeType, byte treeLv, int cost, short[] pos) { }

	// RVA: 0x25EE138 Offset: 0x25EA138 VA: 0x25EE138 Slot: 5
	public void Reconnection(Game engine) { }
}
