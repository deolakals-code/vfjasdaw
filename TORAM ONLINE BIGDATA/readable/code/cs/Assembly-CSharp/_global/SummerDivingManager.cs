// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummerDivingManager // TypeDefIndex: 4550
{
	// Fields
	[SerializeField]
	private readonly float prohibitedDistance; // 0x10
	private readonly int[] popMobIds; // 0x18
	private SummerDivingManager.LocalIdManager mobIdManager; // 0x20
	private SummerDivingManager.LocalIdManager bulletIdManager; // 0x28
	private Dictionary<int, SummerDivingManager.FishData> fishList; // 0x30
	private Dictionary<int, SummerDivingManager.AvatarData> avatarList; // 0x38
	private List<DivingAttack> bulletList; // 0x40
	private SummerDivingManager.AvatarData myAvatar; // 0x48

	// Methods

	// RVA: 0x251DB8C Offset: 0x2519B8C VA: 0x251DB8C
	public void .ctor() { }

	// RVA: 0x251DFD8 Offset: 0x2519FD8 VA: 0x251DFD8
	public void Update() { }

	// RVA: 0x251E024 Offset: 0x251A024 VA: 0x251E024
	public void Clear() { }

	// RVA: 0x251E604 Offset: 0x251A604 VA: 0x251E604
	public void AddAvatar(int id, TakeController takeController, bool isMine) { }

	// RVA: 0x251E738 Offset: 0x251A738 VA: 0x251E738
	public void PlayerAttackStart(byte weaponId, DivingAttack bullet, Vector3 pos, short rot) { }

	// RVA: 0x251E850 Offset: 0x251A850 VA: 0x251E850
	public int GetBulletNo() { }

	// RVA: 0x251E984 Offset: 0x251A984 VA: 0x251E984
	public bool RemoveBullet(DivingAttack bullet) { }

	// RVA: 0x251EB54 Offset: 0x251AB54 VA: 0x251EB54
	public void PlayerToFishDamage(byte weaponId, int harpoonNo, DivingMob fish) { }

	// RVA: 0x251ECB0 Offset: 0x251ACB0 VA: 0x251ECB0
	public int CheckHitBulletToFish(DivingAttack bullet, int removeId) { }

	// RVA: 0x251F15C Offset: 0x251B15C VA: 0x251F15C
	public bool CheckHitFish(GameObject target, out DivingMob fish) { }

	// RVA: 0x251F3D0 Offset: 0x251B3D0 VA: 0x251F3D0
	public GameObject MostNearObject(Vector3 pos, Vector3 forward, float scopeaDist) { }

	// RVA: 0x251F924 Offset: 0x251B924 VA: 0x251F924
	public void OnPlayerDamaged(int id, float speed, Vector3 dir, Action endFunc) { }

	// RVA: 0x251FAC4 Offset: 0x251BAC4 VA: 0x251FAC4
	public void PopClientMob() { }

	// RVA: 0x251FC6C Offset: 0x251BC6C VA: 0x251FC6C
	public void CreateClientMob(int mobId) { }

	// RVA: 0x251FFA8 Offset: 0x251BFA8 VA: 0x251FFA8
	public void CreateMob(int mobId, byte localId, int uniqueId, int hp, Vector3 pos, float rot) { }

	// RVA: 0x252051C Offset: 0x251C51C VA: 0x252051C
	private PolygonRay AddMob4903PolygonRay(GameObject mob) { }

	// RVA: 0x252081C Offset: 0x251C81C VA: 0x252081C
	private PolygonRay AddMob5201PolygonRay(GameObject mob) { }

	// RVA: 0x2520C58 Offset: 0x251CC58 VA: 0x2520C58
	public void RemoveMob(int mobId, byte localId, int uniqueId) { }

	// RVA: 0x2520E70 Offset: 0x251CE70 VA: 0x2520E70
	public void UpdateServerMob(int mobId, byte localId, int uniqueId, int hp, Vector3 moved, float rot, byte actionState, byte commandId, byte value) { }

	// RVA: 0x25210B4 Offset: 0x251D0B4 VA: 0x25210B4
	public List<DivingMob> GetServerFishs() { }

	// RVA: 0x2521298 Offset: 0x251D298 VA: 0x2521298
	public void AllDeadMob() { }

	// RVA: 0x25215E8 Offset: 0x251D5E8 VA: 0x25215E8
	public void DeadMob(int mobId, int uniqueId) { }

	// RVA: 0x251FE3C Offset: 0x251BE3C VA: 0x251FE3C
	private Vector3 GetClientMobPopPosition(float depthMin, float depthMax) { }

	// RVA: 0x25201C4 Offset: 0x251C1C4 VA: 0x25201C4
	public GameObject GetSeaMobObject(int mobId) { }
}
