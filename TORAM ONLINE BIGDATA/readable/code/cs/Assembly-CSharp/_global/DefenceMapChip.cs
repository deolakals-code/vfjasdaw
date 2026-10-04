// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceMapChip // TypeDefIndex: 3865
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public DefenceMapKind mapKind; // 0x18
	public byte gate; // 0x1C
	public int roomId; // 0x20
	public byte roomFlag; // 0x24
	public Dictionary<DefencePoint2, byte> guide; // 0x28
	public Dictionary<DefencePoint2, byte> distance; // 0x30

	// Properties
	public bool IsRoom { get; }
	public bool IsRoad { get; }

	// Methods

	// RVA: 0x2401228 Offset: 0x23FD228 VA: 0x2401228
	public bool get_IsRoom() { }

	// RVA: 0x240123C Offset: 0x23FD23C VA: 0x240123C
	public bool get_IsRoad() { }

	// RVA: 0x2401250 Offset: 0x23FD250 VA: 0x2401250
	public void .ctor() { }
}
