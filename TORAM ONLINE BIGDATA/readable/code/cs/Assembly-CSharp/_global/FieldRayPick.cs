// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldRayPick // TypeDefIndex: 3930
{
	// Fields
	private const float WallHitOffset = 0.015;
	private float height; // 0x10
	private float fallHeight; // 0x14
	private float rad; // 0x18
	private Vector3 groundPosition; // 0x1C
	private Vector3 groundNormal; // 0x28
	private float brightness; // 0x34
	private Vector2 floorUv; // 0x38
	private bool isGround; // 0x40
	private bool groundOnFlag; // 0x41
	private int lowMoveCount; // 0x44
	private Vector3 lastMoveXZDir; // 0x48
	private float slideDot; // 0x54
	private float incidenceAngle; // 0x58
	[CompilerGenerated]
	private bool <EnableWallHitCheck>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <EnableFloorHitCheck>k__BackingField; // 0x5D
	[CompilerGenerated]
	private bool <EnableAllFloorMove>k__BackingField; // 0x5E
	[CompilerGenerated]
	private bool <EnableIncidenceAngle>k__BackingField; // 0x5F
	[CompilerGenerated]
	private bool <EnableOnGroundMove>k__BackingField; // 0x60
	private Vector3 baseMoveDir; // 0x64
	private Vector3 movePos; // 0x70
	private Vector3 moveXZ; // 0x7C
	private RaycastHit ray; // 0x88
	private Vector3 moveXZDir; // 0xB4
	private Vector3 normalFirst; // 0xC0
	private Vector3 normalSecond; // 0xCC
	private Vector3 checkPos; // 0xD8
	private Vector3 posToHit; // 0xE4
	private Vector3 wallCross; // 0xF0
	private Vector3 wallMove; // 0xFC
	private Vector3 wallVertical; // 0x108
	private Vector3 sphereMovePos; // 0x114
	private Vector3 overMove; // 0x120
	private Vector3 overMoveVec; // 0x12C

	// Properties
	public float Height { get; set; }
	public float Radius { get; set; }
	public float FallHeight { get; set; }
	public bool EnableWallHitCheck { get; set; }
	public bool EnableFloorHitCheck { get; set; }
	public bool EnableAllFloorMove { get; set; }
	public bool IsGround { get; }
	public Vector3 GroundPosition { get; }
	public Vector3 GroundNormal { get; }
	public float Brightness { get; }
	public float SlideDot { get; set; }
	public bool EnableIncidenceAngle { get; set; }
	public float IncidenceAngle { get; set; }
	public bool EnableOnGroundMove { get; set; }

	// Methods

	// RVA: 0x24144F0 Offset: 0x24104F0 VA: 0x24144F0
	public float get_Height() { }

	// RVA: 0x24144F8 Offset: 0x24104F8 VA: 0x24144F8
	public void set_Height(float value) { }

	// RVA: 0x2414500 Offset: 0x2410500 VA: 0x2414500
	public float get_Radius() { }

	// RVA: 0x2414508 Offset: 0x2410508 VA: 0x2414508
	public void set_Radius(float value) { }

	// RVA: 0x2414510 Offset: 0x2410510 VA: 0x2414510
	public float get_FallHeight() { }

	// RVA: 0x2414518 Offset: 0x2410518 VA: 0x2414518
	public void set_FallHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x2414520 Offset: 0x2410520 VA: 0x2414520
	public bool get_EnableWallHitCheck() { }

	[CompilerGenerated]
	// RVA: 0x2414528 Offset: 0x2410528 VA: 0x2414528
	public void set_EnableWallHitCheck(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2414534 Offset: 0x2410534 VA: 0x2414534
	public bool get_EnableFloorHitCheck() { }

	[CompilerGenerated]
	// RVA: 0x241453C Offset: 0x241053C VA: 0x241453C
	public void set_EnableFloorHitCheck(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2414548 Offset: 0x2410548 VA: 0x2414548
	public bool get_EnableAllFloorMove() { }

	[CompilerGenerated]
	// RVA: 0x2414550 Offset: 0x2410550 VA: 0x2414550
	public void set_EnableAllFloorMove(bool value) { }

	// RVA: 0x241455C Offset: 0x241055C VA: 0x241455C
	public bool get_IsGround() { }

	// RVA: 0x2414564 Offset: 0x2410564 VA: 0x2414564
	public Vector3 get_GroundPosition() { }

	// RVA: 0x2414570 Offset: 0x2410570 VA: 0x2414570
	public Vector3 get_GroundNormal() { }

	// RVA: 0x241457C Offset: 0x241057C VA: 0x241457C
	public float get_Brightness() { }

	// RVA: 0x2414584 Offset: 0x2410584 VA: 0x2414584
	public float get_SlideDot() { }

	// RVA: 0x241458C Offset: 0x241058C VA: 0x241458C
	public void set_SlideDot(float value) { }

	[CompilerGenerated]
	// RVA: 0x2414594 Offset: 0x2410594 VA: 0x2414594
	public bool get_EnableIncidenceAngle() { }

	[CompilerGenerated]
	// RVA: 0x241459C Offset: 0x241059C VA: 0x241459C
	public void set_EnableIncidenceAngle(bool value) { }

	// RVA: 0x24145A8 Offset: 0x24105A8 VA: 0x24145A8
	public float get_IncidenceAngle() { }

	// RVA: 0x24145B0 Offset: 0x24105B0 VA: 0x24145B0
	public void set_IncidenceAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x24145B8 Offset: 0x24105B8 VA: 0x24145B8
	public bool get_EnableOnGroundMove() { }

	[CompilerGenerated]
	// RVA: 0x24145C0 Offset: 0x24105C0 VA: 0x24145C0
	public void set_EnableOnGroundMove(bool value) { }

	// RVA: 0x24145CC Offset: 0x24105CC VA: 0x24145CC
	public void .ctor() { }

	// RVA: 0x2414714 Offset: 0x2410714 VA: 0x2414714
	public Vector3 GetMoveDelta(Vector3 pos, Vector3 move) { }

	// RVA: 0x2416734 Offset: 0x2412734 VA: 0x2416734
	public Vector3 GetMoveDelta_old(Vector3 pos, Vector3 move) { }

	// RVA: 0x24176B0 Offset: 0x24136B0 VA: 0x24176B0
	public bool GetFallDelta(Vector3 pos, float moveY, out Vector3 move) { }

	// RVA: 0x2417A78 Offset: 0x2413A78 VA: 0x2417A78
	public Vector3 GetFallDelta(Vector3 pos) { }

	// RVA: 0x2417E40 Offset: 0x2413E40 VA: 0x2417E40
	public static bool GetFallPosition(Vector3 pos, float dist, out Vector3 hitPos) { }

	// RVA: 0x2417FC4 Offset: 0x2413FC4 VA: 0x2417FC4
	public static bool IsFall(Transform transform, CharacterMove charaMove) { }
}
