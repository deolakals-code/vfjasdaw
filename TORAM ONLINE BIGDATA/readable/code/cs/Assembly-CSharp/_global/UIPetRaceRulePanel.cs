// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetRaceRulePanel : MonoBehaviour // TypeDefIndex: 6003
{
	// Fields
	[SerializeField]
	private UILabel topSelectLabel; // 0x20
	[SerializeField]
	private GameObject[] topSelectIcon; // 0x28
	[SerializeField]
	private GameObject[] panels; // 0x30
	[SerializeField]
	private GameObject[] elements; // 0x38
	[SerializeField]
	private UILabel[] elementValLabel; // 0x40
	[SerializeField]
	private GameObject recordIcon; // 0x48
	[SerializeField]
	private GameObject[] selectButtons; // 0x50
	private PetRaceRoomData roomData; // 0x58
	private int[] selectVal; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private ScriptTextManagerData scriptTextManagerData; // 0x70
	private float connectionTimer; // 0x78
	private int cacheFlag; // 0x7C
	private int cacheFieldId; // 0x80
	private bool isActive; // 0x84
	private Dictionary<int, PetRaceRecordData> courseRecord; // 0x88

	// Methods

	// RVA: 0x1862F7C Offset: 0x185EF7C VA: 0x1862F7C
	private void Awake() { }

	// RVA: 0x1863244 Offset: 0x185F244 VA: 0x1863244
	private void LateUpdate() { }

	// RVA: 0x185D9E4 Offset: 0x18599E4 VA: 0x185D9E4
	public void Active(bool selectUser) { }

	// RVA: 0x18635CC Offset: 0x185F5CC VA: 0x18635CC
	private void UpdateSettingView() { }

	// RVA: 0x185DAB0 Offset: 0x1859AB0 VA: 0x185DAB0
	public void Close(bool cancel) { }

	// RVA: 0x186345C Offset: 0x185F45C VA: 0x186345C
	private bool CheckSettingConnection() { }

	// RVA: 0x1863F68 Offset: 0x185FF68 VA: 0x1863F68
	private void ReceiveRecord(PetRaceRecordData[] records) { }

	// RVA: 0x1863AC4 Offset: 0x185FAC4 VA: 0x1863AC4
	private void UpdateCourseRecordLabel() { }

	// RVA: 0x18639BC Offset: 0x185F9BC VA: 0x18639BC
	private int ActiveElements(int flag) { }

	// RVA: 0x186417C Offset: 0x186017C VA: 0x186417C
	public void OnClick_FieldSelected(int add) { }

	// RVA: 0x1864240 Offset: 0x1860240 VA: 0x1864240
	public void OnClick_RoomSelected(int add) { }

	// RVA: 0x1864368 Offset: 0x1860368 VA: 0x1864368
	public void OnClick_RuleSelected(int add) { }

	// RVA: 0x1864488 Offset: 0x1860488 VA: 0x1864488
	public void .ctor() { }
}
