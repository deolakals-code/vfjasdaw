// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballFightMeteor // TypeDefIndex: 4519
{
	// Fields
	[CompilerGenerated]
	private int <BallNo>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ActorArchetypeId>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <OwnerArchetypeId>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x1C
	public const int MeteorModelId = 3002;
	public const int MeteorMotionId = 0;
	private const float Range = 10;
	private Transform actorTransform; // 0x20
	private GameObject meteorModel; // 0x28
	private Motion meteorMotion; // 0x30
	private SkinnedMeshRenderer skinMeshRendener; // 0x38
	private SnowballFightMeteor.State state; // 0x40
	private SnowballFightMeteor.MotionId motionId; // 0x44

	// Properties
	public int BallNo { get; set; }
	public int ActorArchetypeId { get; set; }
	public int OwnerArchetypeId { get; set; }
	public bool IsEnd { get; set; }
	public bool IsHit { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2511060 Offset: 0x250D060 VA: 0x2511060
	public int get_BallNo() { }

	[CompilerGenerated]
	// RVA: 0x2511068 Offset: 0x250D068 VA: 0x2511068
	private void set_BallNo(int value) { }

	[CompilerGenerated]
	// RVA: 0x2511070 Offset: 0x250D070 VA: 0x2511070
	public int get_ActorArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x2511078 Offset: 0x250D078 VA: 0x2511078
	private void set_ActorArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2511080 Offset: 0x250D080 VA: 0x2511080
	public int get_OwnerArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x2511088 Offset: 0x250D088 VA: 0x2511088
	private void set_OwnerArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2511090 Offset: 0x250D090 VA: 0x2511090
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x2511098 Offset: 0x250D098 VA: 0x2511098
	private void set_IsEnd(bool value) { }

	// RVA: 0x25110A4 Offset: 0x250D0A4 VA: 0x25110A4
	public bool get_IsHit() { }

	// RVA: 0x25110B4 Offset: 0x250D0B4 VA: 0x25110B4
	public void .ctor(int ballNo, int actorArchetypeId, Transform actorTransform, int ownerArchetypeId, Vector3 pos, bool isMyTeam) { }

	// RVA: 0x2511424 Offset: 0x250D424 VA: 0x2511424
	public void Destroy() { }

	// RVA: 0x25114C4 Offset: 0x250D4C4 VA: 0x25114C4
	public void Update() { }

	// RVA: 0x25116EC Offset: 0x250D6EC VA: 0x25116EC
	public bool CheckHit(Transform target) { }

	// RVA: 0x25113C0 Offset: 0x250D3C0 VA: 0x25113C0
	private GameObject GetMeteorModel() { }

	// RVA: 0x2511688 Offset: 0x250D688 VA: 0x2511688
	private void NextMotion() { }

	// RVA: 0x251162C Offset: 0x250D62C VA: 0x251162C
	private void CheckHitState() { }
}
