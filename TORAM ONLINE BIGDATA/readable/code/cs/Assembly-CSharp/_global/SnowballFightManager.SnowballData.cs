// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SnowballFightManager.SnowballData // TypeDefIndex: 4504
{
	// Fields
	private int archetypeId; // 0x10
	private int ballNo; // 0x14
	private Snowball ball; // 0x18
	private GameObject model; // 0x20
	private bool isDestroy; // 0x28
	public readonly byte Flag; // 0x29

	// Properties
	public int ArchetypeId { get; }
	public int BallNo { get; }
	public bool IsMoveEnd { get; }
	public bool IsFloor { get; }
	public bool IsWall { get; }
	public bool IsMeteor { get; }
	public bool IsDestroy { get; }
	public bool IsHit { get; }
	public GameObject HitOther { get; }
	public Vector3 Position { get; }

	// Methods

	// RVA: 0x250F8BC Offset: 0x250B8BC VA: 0x250F8BC
	public int get_ArchetypeId() { }

	// RVA: 0x250F8C4 Offset: 0x250B8C4 VA: 0x250F8C4
	public int get_BallNo() { }

	// RVA: 0x250EC40 Offset: 0x250AC40 VA: 0x250EC40
	public bool get_IsMoveEnd() { }

	// RVA: 0x250ECC8 Offset: 0x250ACC8 VA: 0x250ECC8
	public bool get_IsFloor() { }

	// RVA: 0x250ED50 Offset: 0x250AD50 VA: 0x250ED50
	public bool get_IsWall() { }

	// RVA: 0x250EDD8 Offset: 0x250ADD8 VA: 0x250EDD8
	public bool get_IsMeteor() { }

	// RVA: 0x250F8CC Offset: 0x250B8CC VA: 0x250F8CC
	public bool get_IsDestroy() { }

	// RVA: 0x250E63C Offset: 0x250A63C VA: 0x250E63C
	public bool get_IsHit() { }

	// RVA: 0x250E6A8 Offset: 0x250A6A8 VA: 0x250E6A8
	public GameObject get_HitOther() { }

	// RVA: 0x250E6C4 Offset: 0x250A6C4 VA: 0x250E6C4
	public Vector3 get_Position() { }

	// RVA: 0x250F8D4 Offset: 0x250B8D4 VA: 0x250F8D4
	public void .ctor(int archetypeId, int ballNo, Snowball ball, GameObject model, byte flag) { }

	// RVA: 0x250AA94 Offset: 0x2506A94 VA: 0x250AA94
	public void Destroy() { }
}
