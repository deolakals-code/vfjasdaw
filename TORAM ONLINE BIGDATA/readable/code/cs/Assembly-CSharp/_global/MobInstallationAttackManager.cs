// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobInstallationAttackManager : MonoBehaviour // TypeDefIndex: 943
{
	// Fields
	private MobRangeAttackCollection range; // 0x20
	private EnemyMobActionManagerBase actionManager; // 0x28
	private Dictionary<MobPatternBase, MobAttackBase> installationList; // 0x30
	private Dictionary<MobPatternBase, MobAttackBase> delayAddInstallationList; // 0x38
	private TakeController takeController; // 0x40
	private bool rangeCheck; // 0x48
	private Dictionary<string, GameObject> loadEffectList; // 0x50
	private int blackHoleId; // 0x58

	// Methods

	// RVA: 0x1F0A6FC Offset: 0x1F066FC VA: 0x1F0A6FC
	public void Inistialize(EnemyMobActionManagerBase actionManger, TakeController takeController, MobRangeAttackCollection range) { }

	// RVA: 0x1F0A970 Offset: 0x1F06970 VA: 0x1F0A970
	public void Clear() { }

	// RVA: 0x1F0ACD4 Offset: 0x1F06CD4 VA: 0x1F0ACD4
	public void Update() { }

	// RVA: 0x1F0B9BC Offset: 0x1F079BC VA: 0x1F0B9BC
	private void LateUpdate() { }

	// RVA: 0x1F0BB9C Offset: 0x1F07B9C VA: 0x1F0BB9C
	public void AttackInvalid() { }

	// RVA: 0x1F0BD64 Offset: 0x1F07D64 VA: 0x1F0BD64
	public bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1F0BF14 Offset: 0x1F07F14 VA: 0x1F0BF14
	public MobAttackBase[] GetInstallationAttack() { }

	// RVA: 0x1F0BFBC Offset: 0x1F07FBC VA: 0x1F0BFBC
	public void Add(int commandId, GameObject target, Vector3 startPos, Vector3 endPos, MobPatternBase parentPattern, ElementType mobElement, bool delayAdd) { }

	// RVA: 0x1F0D31C Offset: 0x1F0931C VA: 0x1F0D31C
	public void AddInstallationCopy(MobPatternBase basePattern, Vector3 targetPos) { }

	// RVA: 0x1F0D65C Offset: 0x1F0965C VA: 0x1F0D65C
	public void AddExtraBullet(int commandId, GameObject target, Vector3 bulletPos, MobActionPattern parentPattern, ElementType mobElement) { }

	// RVA: 0x1F0CBD8 Offset: 0x1F08BD8 VA: 0x1F0CBD8
	private GameObject GetBullet(ElementType elementType, int bulletType) { }

	// RVA: 0x1F0CC88 Offset: 0x1F08C88 VA: 0x1F0CC88
	private GameObject GetExplosion(ElementType elementType, int explosionType) { }

	// RVA: 0x1F0CAAC Offset: 0x1F08AAC VA: 0x1F0CAAC
	private GameObject GetVertical(ElementType element) { }

	// RVA: 0x1F0CE04 Offset: 0x1F08E04 VA: 0x1F0CE04
	private GameObject GetWall(ElementType element, int effectType) { }

	// RVA: 0x1F0CD38 Offset: 0x1F08D38 VA: 0x1F0CD38
	private GameObject GetTranslation(ElementType element) { }

	// RVA: 0x1F0CEF0 Offset: 0x1F08EF0 VA: 0x1F0CEF0
	private GameObject GetBlackHoleEffect(ElementType element, int effectType) { }

	// RVA: 0x1F0CFE4 Offset: 0x1F08FE4 VA: 0x1F0CFE4
	private GameObject GetMeteor(MobActionPattern pattern, ElementType element) { }

	// RVA: 0x1F0D0C4 Offset: 0x1F090C4 VA: 0x1F0D0C4
	private GameObject GetMultiLineEffect(ElementType element, int effectType) { }

	// RVA: 0x1F0D1AC Offset: 0x1F091AC VA: 0x1F0D1AC
	private GameObject GetBounceParabolaEffect(ElementType element) { }

	// RVA: 0x1F0D250 Offset: 0x1F09250 VA: 0x1F0D250
	private GameObject GetBarrierScreenEffect(ElementType element) { }

	// RVA: 0x1F0A7AC Offset: 0x1F067AC VA: 0x1F0A7AC
	private void InitializeLoad() { }

	// RVA: 0x1F0DC54 Offset: 0x1F09C54 VA: 0x1F0DC54
	private void GetMobIdList(int mobId, ref List<int> checkMobIdList) { }

	// RVA: 0x1F0DE98 Offset: 0x1F09E98 VA: 0x1F0DE98
	private void LoadMonsterBullet(int mobId) { }

	// RVA: 0x1F0DF7C Offset: 0x1F09F7C VA: 0x1F0DF7C
	private void InitializePatternLoad(MobStatusMaster master) { }

	// RVA: 0x1F0E8D4 Offset: 0x1F0A8D4 VA: 0x1F0E8D4
	private void LoadBullet(MobStatusMaster master, ElementType elementType, int bulletType) { }

	// RVA: 0x1F0E978 Offset: 0x1F0A978 VA: 0x1F0E978
	private void LoadExplosion(MobStatusMaster master, ElementType elementType, int explosionType) { }

	// RVA: 0x1F0EA1C Offset: 0x1F0AA1C VA: 0x1F0EA1C
	private void LoadTranslation() { }

	// RVA: 0x1F0EA88 Offset: 0x1F0AA88 VA: 0x1F0EA88
	private void LoadWall(int effectType) { }

	// RVA: 0x1F0E808 Offset: 0x1F0A808 VA: 0x1F0E808
	private void LoadVertical() { }

	// RVA: 0x1F0EB0C Offset: 0x1F0AB0C VA: 0x1F0EB0C
	private void LoadBlackHole(int effectType) { }

	// RVA: 0x1F0EBA4 Offset: 0x1F0ABA4 VA: 0x1F0EBA4
	private void LoadMeteor(MobStatusMaster master, MobActionPattern pattern) { }

	// RVA: 0x1F0EC24 Offset: 0x1F0AC24 VA: 0x1F0EC24
	private void LoadMultiLineEffect() { }

	// RVA: 0x1F0EDA0 Offset: 0x1F0ADA0 VA: 0x1F0EDA0
	private void LoadBounceParabolaBoundEffect(MobStatusMaster master, int effectId, ElementType elementType) { }

	// RVA: 0x1F0EC90 Offset: 0x1F0AC90 VA: 0x1F0EC90
	private void LoadBounceParabolaEffect(MobStatusMaster master, ElementType elementType) { }

	// RVA: 0x1F0ED34 Offset: 0x1F0AD34 VA: 0x1F0ED34
	private void LoadBarrierScreenEffect() { }

	// RVA: 0x1F0D82C Offset: 0x1F0982C VA: 0x1F0D82C
	private GameObject ChangeEffectModelColor(GameObject effect, int modelId, int motionId, ElementType element) { }

	// RVA: 0x1F0EE44 Offset: 0x1F0AE44 VA: 0x1F0EE44
	private static Color CreateColor(float red, float green, float blue) { }

	// RVA: 0x1F0EE60 Offset: 0x1F0AE60 VA: 0x1F0EE60
	public void .ctor() { }
}
