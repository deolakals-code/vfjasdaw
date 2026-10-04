// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class DivingMobAIBase // TypeDefIndex: 4528
{
	// Fields
	protected GameObject controller; // 0x10
	protected MobStatusMaster master; // 0x18
	protected GameObject client; // 0x20
	protected MobAnimation animation; // 0x28
	protected float mSpeed; // 0x30
	protected DivingMobAIBase.ActionState state; // 0x34
	protected float damageTime; // 0x38
	protected List<MobActionPattern> attackPatternList; // 0x40
	protected DivingMobAIBase.MoveType moveType; // 0x48
	[CompilerGenerated]
	private float <DepthMin>k__BackingField; // 0x4C
	[CompilerGenerated]
	private float <DepthMax>k__BackingField; // 0x50
	[CompilerGenerated]
	private SummerEventRoomData <RoomData>k__BackingField; // 0x58

	// Properties
	protected Vector3 Position { get; }
	protected float DepthMin { get; set; }
	protected float DepthMax { get; set; }
	protected SummerEventRoomData RoomData { get; set; }

	// Methods

	// RVA: 0x25135C8 Offset: 0x250F5C8 VA: 0x25135C8
	protected Vector3 get_Position() { }

	[CompilerGenerated]
	// RVA: 0x25162F0 Offset: 0x25122F0 VA: 0x25162F0
	protected float get_DepthMin() { }

	[CompilerGenerated]
	// RVA: 0x25162F8 Offset: 0x25122F8 VA: 0x25162F8
	private void set_DepthMin(float value) { }

	[CompilerGenerated]
	// RVA: 0x2516300 Offset: 0x2512300 VA: 0x2516300
	protected float get_DepthMax() { }

	[CompilerGenerated]
	// RVA: 0x2516308 Offset: 0x2512308 VA: 0x2516308
	private void set_DepthMax(float value) { }

	[CompilerGenerated]
	// RVA: 0x2516310 Offset: 0x2512310 VA: 0x2516310
	protected SummerEventRoomData get_RoomData() { }

	[CompilerGenerated]
	// RVA: 0x2516318 Offset: 0x2512318 VA: 0x2516318
	private void set_RoomData(SummerEventRoomData value) { }

	// RVA: 0x2515BF8 Offset: 0x2511BF8 VA: 0x2515BF8
	public void Initialize(GameObject controller, MobStatusMaster master, GameObject client, SummerEventRoomData roomData) { }

	// RVA: 0x2516320 Offset: 0x2512320 VA: 0x2516320 Slot: 4
	protected virtual void OnInitialize() { }

	// RVA: 0x2516324 Offset: 0x2512324 VA: 0x2516324 Slot: 5
	public virtual void Update() { }

	// RVA: 0x2516378 Offset: 0x2512378 VA: 0x2516378 Slot: 6
	public virtual void OnDamaged(GameObject target) { }

	// RVA: 0x2516430 Offset: 0x2512430 VA: 0x2516430 Slot: 7
	public virtual void OnAttack(GameObject target) { }

	// RVA: 0x2516434 Offset: 0x2512434 VA: 0x2516434 Slot: 8
	public virtual void Dead() { }

	// RVA: 0x2516464 Offset: 0x2512464 VA: 0x2516464 Slot: 9
	public virtual void Remove() { }

	// RVA: 0x2516468 Offset: 0x2512468 VA: 0x2516468 Slot: 10
	public virtual bool CheckHit(GameObject target, float rad) { }

	// RVA: 0x25158A0 Offset: 0x25118A0 VA: 0x25158A0
	public static DivingMobAIBase Create(int persona) { }

	// RVA: 0x2516564 Offset: 0x2512564 VA: 0x2516564
	protected static Vector3 Celing(Vector3 pos, Vector3 move) { }

	// RVA: 0x25167F8 Offset: 0x25127F8 VA: 0x25167F8
	protected static bool CheckMovedPos(Vector3 pos) { }

	// RVA: 0x2513D44 Offset: 0x250FD44 VA: 0x2513D44
	protected void ValidState(DivingMobAIBase.ActionState state) { }

	// RVA: 0x2513DCC Offset: 0x250FDCC VA: 0x2513DCC
	protected void InvalidState(DivingMobAIBase.ActionState state) { }

	// RVA: 0x2512D2C Offset: 0x250ED2C VA: 0x2512D2C
	protected bool CheckState(DivingMobAIBase.ActionState state) { }

	// RVA: 0x2516A5C Offset: 0x2512A5C VA: 0x2516A5C
	protected bool CheckHabitableArea(float posY) { }

	// RVA: 0x2516A80 Offset: 0x2512A80 VA: 0x2516A80
	protected Vector3 GetHabitableAreaDirection(float posY) { }

	// RVA: 0x2516AB4 Offset: 0x2512AB4 VA: 0x2516AB4
	protected Vector3 GetRandomHabitableArea() { }

	// RVA: 0x2516C50 Offset: 0x2512C50 VA: 0x2516C50
	protected DivingMobAIBase.Ink CreateBullet(Vector3 attackStartPos, Vector3 targetPos, float speed, float acceleration, float scale, bool targetAttack) { }

	// RVA: 0x25143F0 Offset: 0x25103F0 VA: 0x25143F0
	protected void .ctor() { }
}
