// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class DivingMob : MonoBehaviour // TypeDefIndex: 4524
{
	// Fields
	private GameObject client; // 0x20
	private bool isInitialize; // 0x28
	private MobStatusMaster master; // 0x30
	private DivingMobAIBase ai; // 0x38
	private Cylinder cylinder; // 0x40
	private IObjectCollder objectCollder; // 0x48
	private CircularArray<int> damageList; // 0x50
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x58
	private FadeAnimationManager fadeAnimation; // 0x60
	private SkinBreakParts skinBreakParts; // 0x68
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <IsClient>k__BackingField; // 0x7C
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x7D
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0x84
	[CompilerGenerated]
	private Transform <Target>k__BackingField; // 0x88
	[CompilerGenerated]
	private SummerEventRoomData <RoomData>k__BackingField; // 0x90

	// Properties
	public int MobId { get; set; }
	public byte LocalId { get; set; }
	public int UniqueId { get; set; }
	public bool IsClient { get; set; }
	public bool IsServer { get; set; }
	public int Hp { get; set; }
	public bool IsDead { get; set; }
	public Transform Target { get; set; }
	protected SummerEventRoomData RoomData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2514CB0 Offset: 0x2510CB0 VA: 0x2514CB0
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x2514CB8 Offset: 0x2510CB8 VA: 0x2514CB8
	protected void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2514CC0 Offset: 0x2510CC0 VA: 0x2514CC0
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x2514CC8 Offset: 0x2510CC8 VA: 0x2514CC8
	protected void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2514CD0 Offset: 0x2510CD0 VA: 0x2514CD0
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x2514CD8 Offset: 0x2510CD8 VA: 0x2514CD8
	protected void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2514CE0 Offset: 0x2510CE0 VA: 0x2514CE0
	public bool get_IsClient() { }

	[CompilerGenerated]
	// RVA: 0x2514CE8 Offset: 0x2510CE8 VA: 0x2514CE8
	private void set_IsClient(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2514CF4 Offset: 0x2510CF4 VA: 0x2514CF4
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x2514CFC Offset: 0x2510CFC VA: 0x2514CFC
	private void set_IsServer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2514D08 Offset: 0x2510D08 VA: 0x2514D08
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x2514D10 Offset: 0x2510D10 VA: 0x2514D10
	private void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x2514D18 Offset: 0x2510D18 VA: 0x2514D18
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x2514D20 Offset: 0x2510D20 VA: 0x2514D20
	private void set_IsDead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2514D2C Offset: 0x2510D2C VA: 0x2514D2C
	public Transform get_Target() { }

	[CompilerGenerated]
	// RVA: 0x2514D34 Offset: 0x2510D34 VA: 0x2514D34
	private void set_Target(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x2514D3C Offset: 0x2510D3C VA: 0x2514D3C
	protected SummerEventRoomData get_RoomData() { }

	[CompilerGenerated]
	// RVA: 0x2514D44 Offset: 0x2510D44 VA: 0x2514D44
	private void set_RoomData(SummerEventRoomData value) { }

	// RVA: 0x2514D4C Offset: 0x2510D4C VA: 0x2514D4C
	public void .ctor() { }

	// RVA: 0x2514DF4 Offset: 0x2510DF4 VA: 0x2514DF4
	public void Update() { }

	// RVA: 0x2514F6C Offset: 0x2510F6C VA: 0x2514F6C
	public void ReciveUpdate(Vector3 moved, float rot, byte actionState, byte commandId, byte value) { }

	// RVA: 0x25150AC Offset: 0x25110AC VA: 0x25150AC
	public void UpdateHp(int hp) { }

	// RVA: 0x2515174 Offset: 0x2511174 VA: 0x2515174
	public void Destroy() { }

	// RVA: 0x2515274 Offset: 0x2511274 VA: 0x2515274
	public void SetId(int mobId, byte localId, int uniqueId) { }

	// RVA: 0x2515284 Offset: 0x2511284 VA: 0x2515284
	public void Initialize() { }

	// RVA: 0x2515D40 Offset: 0x2511D40 VA: 0x2515D40
	public void AddIObjectCollder(IObjectCollder collder) { }

	// RVA: 0x2515D48 Offset: 0x2511D48 VA: 0x2515D48
	public bool IsMatch(int mobId, byte localId, int uniqueId) { }

	// RVA: 0x2515D78 Offset: 0x2511D78 VA: 0x2515D78
	public bool CheckHit(int removeId, GameObject target, bool bullet, Vector3 pos, float rad, Vector3 vec) { }

	// RVA: 0x2515F20 Offset: 0x2511F20 VA: 0x2515F20
	public bool OnDamaged(GameObject target, int bulletNo) { }

	// RVA: 0x2515FD8 Offset: 0x2511FD8 VA: 0x2515FD8
	public void OnAttack(GameObject target) { }

	// RVA: 0x2515FF0 Offset: 0x2511FF0 VA: 0x2515FF0
	public MobSendData GetMobSendData() { }

	// RVA: 0x25160EC Offset: 0x25120EC VA: 0x25160EC
	public void Dead() { }

	// RVA: 0x251611C Offset: 0x251211C VA: 0x251611C
	public void Remove() { }

	[CompilerGenerated]
	// RVA: 0x251622C Offset: 0x251222C VA: 0x251622C
	private void <Destroy>b__50_0() { }

	[CompilerGenerated]
	// RVA: 0x2516284 Offset: 0x2512284 VA: 0x2516284
	private void <Remove>b__60_0() { }
}
