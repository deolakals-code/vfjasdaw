// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class DefenceRoom : MonoBehaviour // TypeDefIndex: 3880
{
	// Fields
	private int x; // 0x20
	private int y; // 0x24
	private DefenceMapKind mapKind; // 0x28
	private byte gate; // 0x2C
	private int roomId; // 0x30

	// Properties
	public int X { get; }
	public int Y { get; }
	public DefenceMapKind MapKind { get; }
	public int RoomId { get; }
	public byte Gate { get; }
	public DefencePoint2 CellPos { get; }

	// Methods

	// RVA: 0x24053EC Offset: 0x24013EC VA: 0x24053EC
	public int get_X() { }

	// RVA: 0x24053F4 Offset: 0x24013F4 VA: 0x24053F4
	public int get_Y() { }

	// RVA: 0x24053FC Offset: 0x24013FC VA: 0x24053FC
	public DefenceMapKind get_MapKind() { }

	// RVA: 0x2405404 Offset: 0x2401404 VA: 0x2405404
	public int get_RoomId() { }

	// RVA: 0x240540C Offset: 0x240140C VA: 0x240540C
	public byte get_Gate() { }

	// RVA: 0x2405414 Offset: 0x2401414 VA: 0x2405414
	public DefencePoint2 get_CellPos() { }

	// RVA: 0x240541C Offset: 0x240141C VA: 0x240541C Slot: 4
	public virtual void SetInfo(int x, int y, byte gate, int roomId) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Destroy();

	// RVA: 0x24052F8 Offset: 0x24012F8 VA: 0x24052F8
	protected void .ctor() { }
}
