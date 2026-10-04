// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightCharacterManagerBase : IDisposable // TypeDefIndex: 4148
{
	// Fields
	protected GameObject charaObj; // 0x10
	protected GuideRail guideRail; // 0x18
	protected float railPosDist; // 0x20
	protected Cylinder damageCollider; // 0x28
	protected SkinnedMeshRenderer rootSkin; // 0x30
	protected FadeAnimationManager fadeAnimation; // 0x38
	[SerializeField]
	private float height; // 0x40
	[SerializeField]
	private float size; // 0x44
	protected FieldRayPick rayPick; // 0x48
	private float gravity; // 0x50
	private readonly float defaultGravity; // 0x54
	protected bool isHalfGravity; // 0x58
	protected bool isOnGround; // 0x59
	private float moveHeight; // 0x5C
	private Vector3 prevRootPos; // 0x60
	private Vector3 baseRootPos; // 0x6C
	protected AbnormalType[] actionLockAbnormalType; // 0x78
	protected Dictionary<AbnormalType, float> abnormalTime; // 0x80
	protected Dictionary<AbnormalType, float> abnormalResistTime; // 0x88
	protected BlackKnightAbnormalManager abnormalManager; // 0x90
	protected GameObject renderObject; // 0x98
	[CompilerGenerated]
	private float <MoveDist>k__BackingField; // 0xA0
	[CompilerGenerated]
	private float <RealMoveDist>k__BackingField; // 0xA4
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <IsGround>k__BackingField; // 0xA9
	[CompilerGenerated]
	private bool <IsGravity>k__BackingField; // 0xAA
	[CompilerGenerated]
	private bool <IsMove>k__BackingField; // 0xAB
	[CompilerGenerated]
	private bool <AutoLookMoveDirection>k__BackingField; // 0xAC
	[CompilerGenerated]
	private bool <AutoLookMoveInverseDirection>k__BackingField; // 0xAD

	// Properties
	public abstract BlackKnightCharacterManagerBase.CharacterType CharaType { get; }
	public GameObject CharaObj { get; }
	public float MoveDist { get; set; }
	public float RealMoveDist { get; set; }
	public float MoveHeight { get; set; }
	public bool IsDead { get; set; }
	public Cylinder DamageCollider { get; }
	public float Size { get; set; }
	public virtual float ContactSize { get; }
	public float RailPosDist { get; }
	public float Height { get; set; }
	public bool IsGround { get; set; }
	public bool IsGravity { get; set; }
	public virtual Vector3 RootPos { get; }
	public bool IsMove { get; set; }
	public Vector3 PrevRootPos { get; }
	public Vector3 BaseRootPos { get; }
	public bool AutoLookMoveDirection { get; set; }
	public bool AutoLookMoveInverseDirection { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract BlackKnightCharacterManagerBase.CharacterType get_CharaType();

	// RVA: 0x24919C4 Offset: 0x248D9C4 VA: 0x24919C4
	public GameObject get_CharaObj() { }

	[CompilerGenerated]
	// RVA: 0x24919CC Offset: 0x248D9CC VA: 0x24919CC
	public float get_MoveDist() { }

	[CompilerGenerated]
	// RVA: 0x24919D4 Offset: 0x248D9D4 VA: 0x24919D4
	private void set_MoveDist(float value) { }

	[CompilerGenerated]
	// RVA: 0x24919DC Offset: 0x248D9DC VA: 0x24919DC
	public float get_RealMoveDist() { }

	[CompilerGenerated]
	// RVA: 0x24919E4 Offset: 0x248D9E4 VA: 0x24919E4
	private void set_RealMoveDist(float value) { }

	// RVA: 0x24919EC Offset: 0x248D9EC VA: 0x24919EC
	public float get_MoveHeight() { }

	// RVA: 0x24919F4 Offset: 0x248D9F4 VA: 0x24919F4
	public void set_MoveHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x2491A0C Offset: 0x248DA0C VA: 0x2491A0C
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x2491A14 Offset: 0x248DA14 VA: 0x2491A14
	private void set_IsDead(bool value) { }

	// RVA: 0x2491A20 Offset: 0x248DA20 VA: 0x2491A20
	public Cylinder get_DamageCollider() { }

	// RVA: 0x2491A28 Offset: 0x248DA28 VA: 0x2491A28
	public float get_Size() { }

	// RVA: 0x2491A30 Offset: 0x248DA30 VA: 0x2491A30
	public void set_Size(float value) { }

	// RVA: 0x2491A38 Offset: 0x248DA38 VA: 0x2491A38 Slot: 6
	public virtual float get_ContactSize() { }

	// RVA: 0x2491A40 Offset: 0x248DA40 VA: 0x2491A40
	public float get_RailPosDist() { }

	// RVA: 0x2491A48 Offset: 0x248DA48 VA: 0x2491A48
	public float get_Height() { }

	// RVA: 0x2491A50 Offset: 0x248DA50 VA: 0x2491A50
	public void set_Height(float value) { }

	[CompilerGenerated]
	// RVA: 0x2491A58 Offset: 0x248DA58 VA: 0x2491A58
	public bool get_IsGround() { }

	[CompilerGenerated]
	// RVA: 0x2491A60 Offset: 0x248DA60 VA: 0x2491A60
	public void set_IsGround(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2491A6C Offset: 0x248DA6C VA: 0x2491A6C
	public bool get_IsGravity() { }

	[CompilerGenerated]
	// RVA: 0x2491A74 Offset: 0x248DA74 VA: 0x2491A74
	public void set_IsGravity(bool value) { }

	// RVA: 0x2491A80 Offset: 0x248DA80 VA: 0x2491A80 Slot: 7
	public virtual Vector3 get_RootPos() { }

	[CompilerGenerated]
	// RVA: 0x2491B84 Offset: 0x248DB84 VA: 0x2491B84
	public bool get_IsMove() { }

	[CompilerGenerated]
	// RVA: 0x2491B8C Offset: 0x248DB8C VA: 0x2491B8C
	private void set_IsMove(bool value) { }

	// RVA: 0x2491B98 Offset: 0x248DB98 VA: 0x2491B98
	public Vector3 get_PrevRootPos() { }

	// RVA: 0x2491BA4 Offset: 0x248DBA4 VA: 0x2491BA4
	public Vector3 get_BaseRootPos() { }

	[CompilerGenerated]
	// RVA: 0x2491BB0 Offset: 0x248DBB0 VA: 0x2491BB0
	public bool get_AutoLookMoveDirection() { }

	[CompilerGenerated]
	// RVA: 0x2491BB8 Offset: 0x248DBB8 VA: 0x2491BB8
	public void set_AutoLookMoveDirection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2491BC4 Offset: 0x248DBC4 VA: 0x2491BC4
	public bool get_AutoLookMoveInverseDirection() { }

	[CompilerGenerated]
	// RVA: 0x2491BCC Offset: 0x248DBCC VA: 0x2491BCC
	public void set_AutoLookMoveInverseDirection(bool value) { }

	// RVA: 0x2491BD8 Offset: 0x248DBD8 VA: 0x2491BD8 Slot: 8
	public virtual void Initialize(GameObject obj, GuideRail guide, float posData, bool isRight, float height) { }

	// RVA: 0x24921E8 Offset: 0x248E1E8 VA: 0x24921E8 Slot: 9
	public virtual void Update() { }

	// RVA: 0x2492250 Offset: 0x248E250 VA: 0x2492250 Slot: 10
	public virtual void MoveUpdate() { }

	// RVA: 0x2492A80 Offset: 0x248EA80 VA: 0x2492A80 Slot: 11
	public virtual Vector3 GetFallNextPosition() { }

	// RVA: 0x2492E40 Offset: 0x248EE40 VA: 0x2492E40
	public void PlayAnimation(int id, WrapMode mode, float speed) { }

	// RVA: 0x2492E9C Offset: 0x248EE9C VA: 0x2492E9C
	public void PlayAnimNatural() { }

	// RVA: 0x2492ED0 Offset: 0x248EED0 VA: 0x2492ED0
	public void PlayAnimRun() { }

	// RVA: 0x2492F04 Offset: 0x248EF04 VA: 0x2492F04
	public void PlayAnimBattleWait() { }

	// RVA: 0x2492F38 Offset: 0x248EF38 VA: 0x2492F38
	public void PlayAnimBattleRun() { }

	// RVA: 0x2492F6C Offset: 0x248EF6C VA: 0x2492F6C
	public void PlayAnimDead() { }

	// RVA: 0x2492FA0 Offset: 0x248EFA0 VA: 0x2492FA0
	public void PlayAnimNonCrossFade(int id, WrapMode mode, float speed) { }

	// RVA: 0x2493000 Offset: 0x248F000 VA: 0x2493000 Slot: 12
	protected virtual void OnPlayAnimation(int id, WrapMode mode, float speed) { }

	// RVA: 0x2493004 Offset: 0x248F004 VA: 0x2493004 Slot: 13
	protected virtual void OnPlayAnimNatural() { }

	// RVA: 0x2493008 Offset: 0x248F008 VA: 0x2493008 Slot: 14
	protected virtual void OnPlayAnimRun() { }

	// RVA: 0x249300C Offset: 0x248F00C VA: 0x249300C Slot: 15
	protected virtual void OnPlayAnimBattleWait() { }

	// RVA: 0x2493010 Offset: 0x248F010 VA: 0x2493010 Slot: 16
	protected virtual void OnPlayAnimBattleRun() { }

	// RVA: 0x2493014 Offset: 0x248F014 VA: 0x2493014 Slot: 17
	protected virtual void OnPlayAnimDead() { }

	// RVA: 0x2493018 Offset: 0x248F018 VA: 0x2493018 Slot: 18
	protected virtual void OnPlayAnimNonCrossFade(int id, WrapMode mode, float speed) { }

	// RVA: 0x249301C Offset: 0x248F01C VA: 0x249301C
	protected void SetMoveDist(float move) { }

	// RVA: 0x24931C0 Offset: 0x248F1C0 VA: 0x24931C0
	public void SetMoveDistByContact(float move) { }

	// RVA: 0x24931C8 Offset: 0x248F1C8 VA: 0x24931C8
	public void SetRailPosByRootPos() { }

	// RVA: 0x249332C Offset: 0x248F32C VA: 0x249332C
	public void ActionCancel() { }

	// RVA: 0x2493350 Offset: 0x248F350 VA: 0x2493350 Slot: 19
	protected virtual void OnActionCancel() { }

	// RVA: 0x2493354 Offset: 0x248F354 VA: 0x2493354 Slot: 20
	public virtual void OnDamaged(SkillDamageData damage) { }

	// RVA: 0x2493358 Offset: 0x248F358 VA: 0x2493358
	public void Dead() { }

	// RVA: 0x2493384 Offset: 0x248F384 VA: 0x2493384 Slot: 21
	public virtual void OnDead() { }

	// RVA: 0x2493388 Offset: 0x248F388 VA: 0x2493388 Slot: 22
	protected virtual void UpdateAbnormal() { }

	// RVA: 0x24933A0 Offset: 0x248F3A0 VA: 0x24933A0 Slot: 23
	protected virtual void OnEndAbnormal(AbnormalType type) { }

	// RVA: 0x24933A4 Offset: 0x248F3A4 VA: 0x24933A4
	protected bool CheckIsActionLockAbnormal() { }

	// RVA: 0x249346C Offset: 0x248F46C VA: 0x249346C Slot: 24
	protected virtual bool AddAbnormal(AbnormalType type, float effectTime, float resistTime) { }

	// RVA: 0x2493474 Offset: 0x248F474 VA: 0x2493474 Slot: 25
	public virtual void OnActionHit(BlackKnightSkillActionBase action) { }

	// RVA: 0x2492A08 Offset: 0x248EA08 VA: 0x2492A08
	public bool GetIsLookRailVec() { }

	// RVA: 0x2493478 Offset: 0x248F478 VA: 0x2493478 Slot: 4
	public void Dispose() { }

	// RVA: 0x24934E8 Offset: 0x248F4E8 VA: 0x24934E8
	public Vector3 CalcEarthPoint(Vector3 nowPos) { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract void OnDicpose();

	// RVA: 0x24935AC Offset: 0x248F5AC VA: 0x24935AC
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2493704 Offset: 0x248F704 VA: 0x2493704
	private bool <CheckIsActionLockAbnormal>b__107_0(AbnormalType x) { }
}
