// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballFightManager : Singleton<SnowballFightManager> // TypeDefIndex: 4516
{
	// Fields
	private const int DEFAULT_SNOWBALL_NUM = 3;
	private CameraManager cameraManager; // 0x20
	private static Dictionary<SnowballFightManager.FieldType, List<Vector3>> ItemPopPoint; // 0x0
	[SerializeField]
	private int snowballNum; // 0x28
	private int avatarUuid; // 0x2C
	private byte damageFlag; // 0x30
	private float frostbiteTime; // 0x34
	private float invincibleTime; // 0x38
	private List<SnowballFightManager.SnowballData> snowballs; // 0x40
	private Dictionary<int, SnowballFightAvatarData> members; // 0x48
	private Dictionary<int, Queue<int>> stackBallNos; // 0x50
	private UISnowballFightManager panel; // 0x58
	private SnowballSearching searching; // 0x60
	private bool isWaitDead; // 0x68
	private Coroutine deadCoroutine; // 0x70
	private bool isWaitResurrection; // 0x78
	private Coroutine waitResCoroutine; // 0x80
	private Dictionary<int, SnowballFightManager.ItemData> items; // 0x88
	private List<SnowballFightMeteor> meteors; // 0x90
	private MiniGameRoomData _roomData; // 0x98
	private CameraSnowballControler.CameraType cameraType; // 0xA0
	private CameraSnowballControler.CameraType prevCameraType; // 0xA4
	private CameraSnowballControler cameraControler; // 0xA8

	// Properties
	public SnowballSearching Searching { get; }
	private UISnowballFightManager snowballFightPanel { get; }
	public int DamageState { get; }
	public bool IsInvincible { get; }
	public CameraSnowballControler.CameraType NowCameraType { get; }
	private MiniGameRoomData RoomData { get; }
	public int SnowballNum { get; }
	public CameraSnowballControler CameraCpmtroloer { get; }

	// Methods

	// RVA: 0x2507358 Offset: 0x2503358 VA: 0x2507358
	public static void SetUserColliderSize(bool isReload, BoxCollider snowballCol, int height) { }

	// RVA: 0x2507458 Offset: 0x2503458 VA: 0x2507458
	public SnowballSearching get_Searching() { }

	// RVA: 0x2507510 Offset: 0x2503510 VA: 0x2507510
	private UISnowballFightManager get_snowballFightPanel() { }

	// RVA: 0x25075D0 Offset: 0x25035D0 VA: 0x25075D0
	public int get_DamageState() { }

	// RVA: 0x25075D8 Offset: 0x25035D8 VA: 0x25075D8
	public bool get_IsInvincible() { }

	// RVA: 0x25075E8 Offset: 0x25035E8 VA: 0x25075E8
	public CameraSnowballControler.CameraType get_NowCameraType() { }

	// RVA: 0x25075F0 Offset: 0x25035F0 VA: 0x25075F0
	private MiniGameRoomData get_RoomData() { }

	// RVA: 0x2507728 Offset: 0x2503728 VA: 0x2507728
	public int get_SnowballNum() { }

	// RVA: 0x2507730 Offset: 0x2503730 VA: 0x2507730
	public CameraSnowballControler get_CameraCpmtroloer() { }

	// RVA: 0x2507850 Offset: 0x2503850 VA: 0x2507850
	private void Awake() { }

	// RVA: 0x2507F88 Offset: 0x2503F88 VA: 0x2507F88
	private void Update() { }

	// RVA: 0x2509F4C Offset: 0x2505F4C VA: 0x2509F4C
	public void GameEnd() { }

	// RVA: 0x250A3D8 Offset: 0x25063D8 VA: 0x250A3D8
	public void Destroy() { }

	// RVA: 0x250AB9C Offset: 0x2506B9C VA: 0x250AB9C
	public void Reset() { }

	// RVA: 0x250AE74 Offset: 0x2506E74 VA: 0x250AE74
	public void Moving() { }

	// RVA: 0x250AED4 Offset: 0x2506ED4 VA: 0x250AED4
	public void AddMember(int uuid, TakeController controller, bool isMine, string name) { }

	// RVA: 0x250B0A4 Offset: 0x25070A4 VA: 0x250B0A4
	public void SetSnowBallNo(int archetypeId, int ballNo) { }

	// RVA: 0x250B168 Offset: 0x2507168 VA: 0x250B168
	public void Throw(int uuid, float power, float angle, float height, int speed, Action endFunc) { }

	// RVA: 0x250B484 Offset: 0x2507484 VA: 0x250B484
	public void Reload(int uuid, float reloadTime, Action endFunc) { }

	// RVA: 0x250B708 Offset: 0x2507708 VA: 0x250B708
	public void ReloadCancel(int uuid, bool takeSkip) { }

	// RVA: 0x250B9C4 Offset: 0x25079C4 VA: 0x250B9C4
	public void Dodge(int uuid, float angle, Action endFunc) { }

	// RVA: 0x250BC18 Offset: 0x2507C18 VA: 0x250BC18
	public void OnDamage(int uuid, byte flag, Action endFunc) { }

	// RVA: 0x250BEAC Offset: 0x2507EAC VA: 0x250BEAC
	public void ReceiveDamage(GameReturnCode returnCode, SnowballFightDamageData response) { }

	// RVA: 0x250C3A4 Offset: 0x25083A4 VA: 0x250C3A4
	public void Dead(int uuid, int otherArchetypeId, Action endFunc) { }

	// RVA: 0x250C69C Offset: 0x250869C VA: 0x250C69C
	public void ReceiveDead(GameReturnCode returnCode, SnowballFightDeadData response) { }

	// RVA: 0x250C970 Offset: 0x2508970 VA: 0x250C970
	public void Resurrection(int uuid, Action endFunc) { }

	// RVA: 0x250CB90 Offset: 0x2508B90 VA: 0x250CB90
	public void ReceiveResurrection(GameReturnCode returnCode, SnowballFightResurrectionData response) { }

	// RVA: 0x250BFEC Offset: 0x2507FEC VA: 0x250BFEC
	public void Transfer(int actorArchetypeId, int ownerArchetypeId, byte itemUid, byte itemType) { }

	// RVA: 0x250C210 Offset: 0x2508210 VA: 0x250C210
	public void RemoveItem(int archetypeId) { }

	// RVA: 0x250C2E4 Offset: 0x25082E4 VA: 0x250C2E4
	public void RemoveChest(int itemUid) { }

	// RVA: 0x250D200 Offset: 0x2509200 VA: 0x250D200
	public void OnPopItem(int itemUid, byte itemType, byte popPoint) { }

	// RVA: 0x250D614 Offset: 0x2509614 VA: 0x250D614
	public void OnGetItem(int archetypeId, int itemUid, byte itemType, bool success) { }

	// RVA: 0x250D7B0 Offset: 0x25097B0 VA: 0x250D7B0
	public void OnUseItem(int archetypeId, int itemUid, float elapsedTime) { }

	// RVA: 0x250D968 Offset: 0x2509968 VA: 0x250D968
	public void UpdateServerItemData(int archetypeId, int itemData, bool initialize) { }

	// RVA: 0x250DCA0 Offset: 0x2509CA0 VA: 0x250DCA0
	public int GetSnowball() { }

	// RVA: 0x250DCA8 Offset: 0x2509CA8 VA: 0x250DCA8
	public float GetReloadTime() { }

	// RVA: 0x250DCE4 Offset: 0x2509CE4 VA: 0x250DCE4
	public void OtherBeforeAction(int uuid) { }

	// RVA: 0x250DD80 Offset: 0x2509D80 VA: 0x250DD80
	public bool IsAction(int uuid) { }

	// RVA: 0x250DE20 Offset: 0x2509E20 VA: 0x250DE20
	public bool IsThrow(int uuid) { }

	// RVA: 0x250DEBC Offset: 0x2509EBC VA: 0x250DEBC
	public bool IsReloadStart(int uuid) { }

	// RVA: 0x250DF58 Offset: 0x2509F58 VA: 0x250DF58
	public bool IsReload(int uuid) { }

	// RVA: 0x250DFF4 Offset: 0x2509FF4 VA: 0x250DFF4
	public bool IsReloadUp(int uuid) { }

	// RVA: 0x250E090 Offset: 0x250A090 VA: 0x250E090
	public bool IsDodge(int uuid) { }

	// RVA: 0x250E12C Offset: 0x250A12C VA: 0x250E12C
	public bool IsDamage(int uuid) { }

	// RVA: 0x250E1C8 Offset: 0x250A1C8 VA: 0x250E1C8
	public bool IsDead(int uuid) { }

	// RVA: 0x250E264 Offset: 0x250A264 VA: 0x250E264
	public bool IsResurrection(int uuid) { }

	// RVA: 0x250E300 Offset: 0x250A300 VA: 0x250E300
	public bool IsDamageInvalidation(int uuid) { }

	// RVA: 0x250E3A0 Offset: 0x250A3A0 VA: 0x250E3A0
	public bool InvalidExceptReload(int uuid) { }

	// RVA: 0x250E410 Offset: 0x250A410 VA: 0x250E410
	public void ChangeSnowballCamera(CameraManager cameraManager) { }

	// RVA: 0x250E4B0 Offset: 0x250A4B0 VA: 0x250E4B0
	public bool ChangeCameraType(CameraSnowballControler.CameraType cameraType) { }

	// RVA: 0x250E638 Offset: 0x250A638 VA: 0x250E638
	public void ChangePCCameraLock(bool isLock) { }

	// RVA: 0x2508364 Offset: 0x2504364 VA: 0x2508364
	private void UpdateSnowballs() { }

	// RVA: 0x2509034 Offset: 0x2505034 VA: 0x2509034
	private void UpdateMembers() { }

	// RVA: 0x2509500 Offset: 0x2505500 VA: 0x2509500
	private void UpdateMeteor() { }

	// RVA: 0x250B474 Offset: 0x2507474 VA: 0x250B474
	private bool IsMine(int uuid) { }

	// RVA: 0x250E960 Offset: 0x250A960 VA: 0x250E960
	private bool FrostbiteDamage(out bool barrier) { }

	// RVA: 0x2509EC8 Offset: 0x2505EC8 VA: 0x2509EC8
	private void Recovery() { }

	// RVA: 0x250E78C Offset: 0x250A78C VA: 0x250E78C
	private void PlayHitEffect(int uuid, Vector3 pos) { }

	[IteratorStateMachine(typeof(SnowballFightManager.<WaitDeadResponse>d__94))]
	// RVA: 0x250C608 Offset: 0x2508608 VA: 0x250C608
	private IEnumerator WaitDeadResponse(float time, int otherArchetypeId) { }

	[IteratorStateMachine(typeof(SnowballFightManager.<waitResurrection>d__95))]
	// RVA: 0x250C8EC Offset: 0x25088EC VA: 0x250C8EC
	private IEnumerator waitResurrection(float timer) { }

	// RVA: 0x250B90C Offset: 0x250790C VA: 0x250B90C
	private void UnloadReload(int uuid) { }

	// RVA: 0x250AD50 Offset: 0x2506D50 VA: 0x250AD50
	private void ChangeReloadCamera(bool isReload, bool isSkip) { }

	// RVA: 0x250E59C Offset: 0x250A59C VA: 0x250E59C
	private void ChangeCamera(CameraSnowballControler.CameraType cameraType) { }

	// RVA: 0x250EE60 Offset: 0x250AE60 VA: 0x250EE60
	private bool CheckDamageFlag(SnowballFightDamageFlag damageFlag) { }

	// RVA: 0x250CF08 Offset: 0x2508F08 VA: 0x250CF08
	private bool IsGameEnd() { }

	// RVA: 0x250CED4 Offset: 0x2508ED4 VA: 0x250CED4
	private bool IsItemPermission() { }

	// RVA: 0x250CF3C Offset: 0x2508F3C VA: 0x250CF3C
	private void AddItem(int archetypeId, byte itemUid, byte itemType, float effectTime) { }

	// RVA: 0x250EE78 Offset: 0x250AE78 VA: 0x250EE78
	public void .ctor() { }

	// RVA: 0x250F05C Offset: 0x250B05C VA: 0x250F05C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x250F7AC Offset: 0x250B7AC VA: 0x250F7AC
	private void <UpdateSnowballs>b__87_1() { }

	[CompilerGenerated]
	// RVA: 0x250F834 Offset: 0x250B834 VA: 0x250F834
	private void <UpdateMeteor>b__89_1() { }
}
