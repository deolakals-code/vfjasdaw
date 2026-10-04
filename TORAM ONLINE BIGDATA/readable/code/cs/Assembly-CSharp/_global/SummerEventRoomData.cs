// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummerEventRoomData : RoomDataBase // TypeDefIndex: 2475
{
	// Fields
	protected GameObject[] motion; // 0x68
	private GameObject playerObject; // 0x70
	private CharacterMove playerMove; // 0x78
	private TakeController playerTakeController; // 0x80
	private float playerWaterDepth; // 0x88
	protected CameraManager cameraManager; // 0x90
	private FadeAnimationManager playerFadeManager; // 0x98
	private PlayerAnimation playerAnimation; // 0xA0
	private int harpoonNum; // 0xA8
	[CompilerGenerated]
	private byte <WeaponType>k__BackingField; // 0xAC
	[CompilerGenerated]
	private bool <IsAutoLock>k__BackingField; // 0xAD
	[CompilerGenerated]
	private bool <IsDeepLock>k__BackingField; // 0xAE
	private bool isSuperMory; // 0xAF
	private bool isMermaidFin; // 0xB0
	private bool isSeaManDrink; // 0xB1
	[CompilerGenerated]
	private int <UsedHarpoonNum>k__BackingField; // 0xB4
	protected SummerDivingManager divingManager; // 0xB8
	private GameObject traceObject; // 0xC0
	private GameObject traceRootObject; // 0xC8
	private static SummerEventRoomData.FieldSize movableSize; // 0x0
	private int restHp; // 0xD0
	private int maxHp; // 0xD4
	private SummerResultData resultData; // 0xD8
	private Dictionary<TakeParameterType, int> hitParam; // 0xE0
	private float invisibleTimer; // 0xE8
	private float soundLoopTimer; // 0xEC
	private int selectBGM; // 0xF0
	protected int playBGM; // 0xF4
	private float speed; // 0xF8
	private bool isMove; // 0xFC
	private bool isRepeatGun; // 0xFD
	private float playerRot; // 0x100
	private GameObject lightEffect; // 0x108
	private SkinnedMeshRenderer lightRender; // 0x110
	private GameObject bubblesEffect; // 0x118
	private AnimationBase bubblesEffectAnimation; // 0x120
	private Renderer bubblesEffectRender; // 0x128
	private float effectFade; // 0x130
	private float escapeActionTimer; // 0x134
	private Vector3 escapeActionMove; // 0x138
	private Vector3 escapeRoll; // 0x144
	[CompilerGenerated]
	private bool <IsWallArae>k__BackingField; // 0x150

	// Properties
	public byte WeaponType { get; set; }
	public bool IsAutoLock { get; set; }
	public bool IsDeepLock { get; set; }
	public int UsedHarpoonNum { get; set; }
	public float PlayerWaterDepth { get; }
	public override string[] LoadAssetsPath { get; }
	public override byte RoomType { get; }
	public static SummerEventRoomData.FieldSize MovableSize { get; }
	public GameObject TraceObject { get; }
	public float RestHpPercent { get; }
	public int UsedItemFlag { get; }
	public int HarpoonNum { get; }
	public SummerResultData ResultData { get; }
	private bool isAttack { get; }
	protected virtual UIActiveState fieldMainUIState { get; }
	public bool IsWallArae { get; set; }
	public virtual bool IsDead { get; }
	public override bool IsFocusPropertyUpdate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21CACFC Offset: 0x21C6CFC VA: 0x21CACFC
	public byte get_WeaponType() { }

	[CompilerGenerated]
	// RVA: 0x21CAD04 Offset: 0x21C6D04 VA: 0x21CAD04
	private void set_WeaponType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21CAD0C Offset: 0x21C6D0C VA: 0x21CAD0C
	public bool get_IsAutoLock() { }

	[CompilerGenerated]
	// RVA: 0x21CAD14 Offset: 0x21C6D14 VA: 0x21CAD14
	protected void set_IsAutoLock(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21CAD20 Offset: 0x21C6D20 VA: 0x21CAD20
	public bool get_IsDeepLock() { }

	[CompilerGenerated]
	// RVA: 0x21CAD28 Offset: 0x21C6D28 VA: 0x21CAD28
	protected void set_IsDeepLock(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21CAD34 Offset: 0x21C6D34 VA: 0x21CAD34
	public int get_UsedHarpoonNum() { }

	[CompilerGenerated]
	// RVA: 0x21CAD3C Offset: 0x21C6D3C VA: 0x21CAD3C
	private void set_UsedHarpoonNum(int value) { }

	// RVA: 0x21CAD44 Offset: 0x21C6D44 VA: 0x21CAD44
	public float get_PlayerWaterDepth() { }

	// RVA: 0x21CAD4C Offset: 0x21C6D4C VA: 0x21CAD4C Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21CAE3C Offset: 0x21C6E3C VA: 0x21CAE3C Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21CAE44 Offset: 0x21C6E44 VA: 0x21CAE44
	public static SummerEventRoomData.FieldSize get_MovableSize() { }

	// RVA: 0x21CAE9C Offset: 0x21C6E9C VA: 0x21CAE9C
	public GameObject get_TraceObject() { }

	// RVA: 0x21CAF14 Offset: 0x21C6F14 VA: 0x21CAF14
	public float get_RestHpPercent() { }

	// RVA: 0x21CAF48 Offset: 0x21C6F48 VA: 0x21CAF48
	public int get_UsedItemFlag() { }

	// RVA: 0x21CAF84 Offset: 0x21C6F84 VA: 0x21CAF84
	public int get_HarpoonNum() { }

	// RVA: 0x21CAF98 Offset: 0x21C6F98 VA: 0x21CAF98
	public SummerResultData get_ResultData() { }

	// RVA: 0x21CAFA0 Offset: 0x21C6FA0 VA: 0x21CAFA0
	private bool get_isAttack() { }

	// RVA: 0x21CAFD8 Offset: 0x21C6FD8 VA: 0x21CAFD8 Slot: 40
	protected virtual UIActiveState get_fieldMainUIState() { }

	[CompilerGenerated]
	// RVA: 0x21CAFE0 Offset: 0x21C6FE0 VA: 0x21CAFE0
	public bool get_IsWallArae() { }

	[CompilerGenerated]
	// RVA: 0x21CAFE8 Offset: 0x21C6FE8 VA: 0x21CAFE8
	protected void set_IsWallArae(bool value) { }

	// RVA: 0x21CAFF4 Offset: 0x21C6FF4 VA: 0x21CAFF4 Slot: 41
	public virtual bool get_IsDead() { }

	// RVA: 0x21CAFFC Offset: 0x21C6FFC VA: 0x21CAFFC Slot: 9
	public override bool get_IsFocusPropertyUpdate() { }

	// RVA: 0x21CB004 Offset: 0x21C7004 VA: 0x21CB004 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21CB1A8 Offset: 0x21C71A8 VA: 0x21CB1A8 Slot: 15
	public override void Update() { }

	// RVA: 0x21CBF70 Offset: 0x21C7F70 VA: 0x21CBF70 Slot: 42
	protected virtual Vector3 MoveAreaCheck(Vector3 pos) { }

	// RVA: 0x21CC0C4 Offset: 0x21C80C4 VA: 0x21CC0C4
	public float GetMoveSpeed(float defaultSpeed) { }

	// RVA: 0x21CC0FC Offset: 0x21C80FC VA: 0x21CC0FC
	public void OnAutoLock() { }

	// RVA: 0x21CC10C Offset: 0x21C810C VA: 0x21CC10C
	public void OnDeepLock() { }

	// RVA: 0x21CC11C Offset: 0x21C811C VA: 0x21CC11C
	public bool OnEscapeAction(float speed, float timer) { }

	// RVA: 0x21CC5AC Offset: 0x21C85AC VA: 0x21CC5AC
	public void OnAttackStart() { }

	// RVA: 0x21CC848 Offset: 0x21C8848 VA: 0x21CC848
	public void RegisterBullets(DivingAttack bullet) { }

	// RVA: 0x21CC930 Offset: 0x21C8930 VA: 0x21CC930
	public bool RemoveBullet(DivingAttack bullet) { }

	// RVA: 0x21CC94C Offset: 0x21C894C VA: 0x21CC94C
	private Quaternion AutoLockRotation() { }

	// RVA: 0x21CC708 Offset: 0x21C8708 VA: 0x21CC708
	private void AttackSpear() { }

	// RVA: 0x21CC5FC Offset: 0x21C85FC VA: 0x21CC5FC
	private void AttackGun() { }

	// RVA: 0x21CCAB0 Offset: 0x21C8AB0 VA: 0x21CCAB0
	public bool OnChangeWeapon() { }

	// RVA: 0x21CCB84 Offset: 0x21C8B84 VA: 0x21CCB84 Slot: 43
	public virtual int CheckHitBulletToFish(DivingAttack bullet, int removeId) { }

	// RVA: 0x21CCD3C Offset: 0x21C8D3C VA: 0x21CCD3C Slot: 44
	public virtual void OnPlayerDamaged(DivingMob mob) { }

	// RVA: 0x21CD36C Offset: 0x21C936C VA: 0x21CD36C Slot: 12
	public override void Clear() { }

	// RVA: 0x21CD370 Offset: 0x21C9370 VA: 0x21CD370 Slot: 45
	protected virtual void EnterPlayerSettings() { }

	// RVA: 0x21CD5B0 Offset: 0x21C95B0 VA: 0x21CD5B0 Slot: 13
	public override void Enter() { }

	// RVA: 0x21CDCCC Offset: 0x21C9CCC VA: 0x21CDCCC Slot: 14
	public override void Leave() { }

	// RVA: 0x21CDF74 Offset: 0x21C9F74 VA: 0x21CDF74 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21CDF78 Offset: 0x21C9F78 VA: 0x21CDF78 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21CDF7C Offset: 0x21C9F7C VA: 0x21CDF7C Slot: 22
	public override void OnGameRoomRejoin(IEnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x21CDFFC Offset: 0x21C9FFC VA: 0x21CDFFC Slot: 23
	public override NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21CE020 Offset: 0x21CA020 VA: 0x21CE020 Slot: 24
	public override void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x21CE3D8 Offset: 0x21CA3D8 VA: 0x21CE3D8 Slot: 26
	public override bool OnActionOtherMove(OtherPlayerActionManager otherPlayerActionManager, IMoveData eventData) { }

	// RVA: 0x21CE5B0 Offset: 0x21CA5B0 VA: 0x21CE5B0 Slot: 27
	public override void ReceiveUpdate(OperationResponse response) { }

	// RVA: 0x21CE688 Offset: 0x21CA688 VA: 0x21CE688
	protected void UpdateHp(int hp) { }

	// RVA: 0x21CE6C8 Offset: 0x21CA6C8 VA: 0x21CE6C8 Slot: 28
	public override bool CheckTapPlayerRoom() { }

	// RVA: 0x21CE6D0 Offset: 0x21CA6D0 VA: 0x21CE6D0 Slot: 21
	public override void OnGameEventLogin(GameEventLoginResponse login, short returnCode) { }

	// RVA: 0x21CE6D4 Offset: 0x21CA6D4 VA: 0x21CE6D4 Slot: 32
	public override bool InitCameraUpdate(CameraManager manager) { }

	// RVA: 0x21CE704 Offset: 0x21CA704 VA: 0x21CE704 Slot: 46
	protected virtual void HitCheckPlayerMove(Vector3 pos, Vector3 move) { }

	// RVA: 0x21CE768 Offset: 0x21CA768 VA: 0x21CE768 Slot: 35
	public override bool PlayerInputMoveCheck() { }

	// RVA: 0x21CEC98 Offset: 0x21CAC98 VA: 0x21CEC98
	public void OnActionSummerThrow(SummerThrowData response) { }

	// RVA: 0x21CED10 Offset: 0x21CAD10 VA: 0x21CED10
	public void OnActionSummerAttack(GameReturnCode returnCode, SummerAttackData response) { }

	// RVA: 0x21CED44 Offset: 0x21CAD44 VA: 0x21CED44
	public void OnActionSummerFishCreate(GameReturnCode returnCode, MobResponseData response) { }

	// RVA: 0x21CEE54 Offset: 0x21CAE54 VA: 0x21CEE54
	public void OnEventSummerFishCreate(SummerFishCreateEvent createEvent) { }

	// RVA: 0x21CEF40 Offset: 0x21CAF40 VA: 0x21CEF40
	public void OnEventSummerFishAction(SummerFishActionEvent actionEvent) { }

	// RVA: 0x21CF614 Offset: 0x21CB614 VA: 0x21CF614
	public void OnActionSummerFishMove(MobMoveEventData response) { }

	// RVA: 0x21CF6B8 Offset: 0x21CB6B8 VA: 0x21CF6B8
	public void OnActionEventSummerFishResult(MobData[] mobs) { }

	// RVA: 0x21CF734 Offset: 0x21CB734 VA: 0x21CF734
	public void OnGameEventResult(SummerResultData resultData) { }

	// RVA: 0x21CF73C Offset: 0x21CB73C VA: 0x21CF73C
	public void OnEventSummerBossPop(SummerBossPopEvent popEvent) { }

	// RVA: 0x21CF818 Offset: 0x21CB818 VA: 0x21CF818
	public static Vector3 GetRandomMoveblePos() { }

	// RVA: 0x21CFA28 Offset: 0x21CBA28 VA: 0x21CFA28
	public void .ctor() { }

	// RVA: 0x21CFB54 Offset: 0x21CBB54 VA: 0x21CFB54
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x21CFC3C Offset: 0x21CBC3C VA: 0x21CFC3C
	private void <Update>b__86_0() { }

	[CompilerGenerated]
	// RVA: 0x21CFCCC Offset: 0x21CBCCC VA: 0x21CFCCC
	private void <AttackSpear>b__96_0(int uid, TakeEventType type, int param) { }

	[CompilerGenerated]
	// RVA: 0x21CFF44 Offset: 0x21CBF44 VA: 0x21CFF44
	private void <AttackGun>b__97_0(int uid, TakeEventType type, int param) { }

	[CompilerGenerated]
	// RVA: 0x21D01BC Offset: 0x21CC1BC VA: 0x21D01BC
	private void <Enter>b__103_0(bool s, GameObject o) { }

	[CompilerGenerated]
	// RVA: 0x21D0428 Offset: 0x21CC428 VA: 0x21D0428
	private void <Enter>b__103_1(bool s, GameObject o) { }
}
