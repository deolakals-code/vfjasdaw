// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonRoomData.DungeonTrapEventData // TypeDefIndex: 2336
{
	// Fields
	private DungeonRoomData roomData; // 0x10
	public readonly byte LocalId; // 0x18
	private GameObject eventModel; // 0x20
	[CompilerGenerated]
	private DungeonEventType <Type>k__BackingField; // 0x28
	private int takeUid; // 0x2C
	private Vector3 position; // 0x30

	// Properties
	public GameObject EventModel { get; }
	public DungeonEventType Type { get; set; }

	// Methods

	// RVA: 0x218DF2C Offset: 0x2189F2C VA: 0x218DF2C
	public GameObject get_EventModel() { }

	[CompilerGenerated]
	// RVA: 0x218DF34 Offset: 0x2189F34 VA: 0x218DF34
	public DungeonEventType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x218DF3C Offset: 0x2189F3C VA: 0x218DF3C
	private void set_Type(DungeonEventType value) { }

	// RVA: 0x218D26C Offset: 0x218926C VA: 0x218D26C
	public void .ctor(byte localId, GameObject eventObj, byte trapType, DungeonRoomData roomData) { }

	// RVA: 0x218C028 Offset: 0x2188028 VA: 0x218C028
	public void Clear() { }

	// RVA: 0x218D780 Offset: 0x2189780 VA: 0x218D780
	public void Clear(float timer) { }

	// RVA: 0x218CB98 Offset: 0x2188B98 VA: 0x218CB98
	public void SetTrapTake() { }
}
