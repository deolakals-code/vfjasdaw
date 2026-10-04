// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaResultElement : MonoBehaviour // TypeDefIndex: 6111
{
	// Fields
	[SerializeField]
	private GameObject[] frameObjs; // 0x20
	[SerializeField]
	private GameObject panelObj; // 0x28
	[SerializeField]
	private GameObject recordObj; // 0x30
	[SerializeField]
	private GameObject rankObj; // 0x38
	[SerializeField]
	private GameObject memberObj; // 0x40
	[SerializeField]
	private GameObject timeDamageObj; // 0x48
	private bool isParty; // 0x50
	private readonly float[] recordObjPosX; // 0x58
	private const float memberObjSize = 60;
	private const short highRankNum = 3;
	private PlayerDataManager playerDataManager; // 0x60
	private SystemTextManager systemTextManager; // 0x68

	// Properties
	private float memberObjScale { get; }
	private Vector3 rankIconPos { get; }
	private int memberLabelSize { get; }

	// Methods

	// RVA: 0x1889FB8 Offset: 0x1885FB8 VA: 0x1889FB8
	private float get_memberObjScale() { }

	// RVA: 0x1889FD4 Offset: 0x1885FD4 VA: 0x1889FD4
	private Vector3 get_rankIconPos() { }

	// RVA: 0x188A008 Offset: 0x1886008 VA: 0x188A008
	private int get_memberLabelSize() { }

	// RVA: 0x188A020 Offset: 0x1886020 VA: 0x188A020
	public void Initialize(MobaRecordData[] records) { }

	// RVA: 0x188A8DC Offset: 0x18868DC VA: 0x188A8DC
	public void Initialize(MobaRecordData[] records, MobaGroupRecordData groups) { }

	// RVA: 0x188A8E8 Offset: 0x18868E8 VA: 0x188A8E8
	public void Initialize(MobaRecordData[] records, MobaBattleRecordData battleRecord) { }

	// RVA: 0x188A8F8 Offset: 0x18868F8 VA: 0x188A8F8
	public void Initialize(MobaRecordData[] records, MobaGroupRecordData groups, MobaBattleRecordData battleRecord) { }

	// RVA: 0x188A030 Offset: 0x1886030 VA: 0x188A030
	public void Initialize(MobaRecordData[] records, MobaGroupRecordData groups, bool isFullData, MobaBattleRecordData battleRecord) { }

	// RVA: 0x188A97C Offset: 0x188697C VA: 0x188A97C
	public void SetScale(Vector3 scale) { }

	// RVA: 0x188A904 Offset: 0x1886904 VA: 0x188A904
	private UIMobaResultElement.FrameType GetFrameType(bool isParty, bool isHighRank, bool isShort) { }

	// RVA: 0x188A92C Offset: 0x188692C VA: 0x188A92C
	private void SetMemberData(GameObject obj, MobaRecordData data, bool isOnlyLv) { }

	// RVA: 0x188A9CC Offset: 0x18869CC VA: 0x188A9CC
	private void SetWeaponIcon(GameObject obj, byte main, byte sub) { }

	// RVA: 0x188AAFC Offset: 0x1886AFC VA: 0x188AAFC
	private void SetNameStatusLabel(GameObject obj, MobaRecordData data, bool isOnlyLv) { }

	// RVA: 0x188AE48 Offset: 0x1886E48 VA: 0x188AE48
	public void .ctor() { }
}
