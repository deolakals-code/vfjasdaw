// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureBoxManager : Singleton<TreasureBoxManager>, ISceneChangeManager // TypeDefIndex: 3844
{
	// Fields
	private TreasureBoxBase treasureBox; // 0x20
	private int loadFolderId; // 0x28
	private TreasureBoxManager.TreasureType treasureBoxType; // 0x2C
	[CompilerGenerated]
	private bool <IsPopResultWindow>k__BackingField; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private Dictionary<int, TreasuerBoxBinaryData[]> treasuerBoxBinaryData; // 0x40
	private int lastSettingFieldId; // 0x48
	private static readonly float FadeOutTime; // 0x0
	private int[] treasureHuntBoxTotalCount; // 0x50
	private List<GameObject> searchPotumObjList; // 0x58

	// Properties
	public TreasureBoxBase TreasureBox { get; }
	public int LoadFolderId { get; }
	public TreasureBoxManager.TreasureType TreasureBoxType { get; }
	private bool isClosedFlag { get; }
	public bool IsPopResultWindow { get; set; }
	public int[] TreasureHuntBoxTotalCount { get; }

	// Methods

	// RVA: 0x23F34AC Offset: 0x23EF4AC VA: 0x23F34AC
	public TreasureBoxBase get_TreasureBox() { }

	// RVA: 0x23F34B4 Offset: 0x23EF4B4 VA: 0x23F34B4
	public int get_LoadFolderId() { }

	// RVA: 0x23F34BC Offset: 0x23EF4BC VA: 0x23F34BC
	public TreasureBoxManager.TreasureType get_TreasureBoxType() { }

	// RVA: 0x23F34C4 Offset: 0x23EF4C4 VA: 0x23F34C4
	private bool get_isClosedFlag() { }

	[CompilerGenerated]
	// RVA: 0x23F354C Offset: 0x23EF54C VA: 0x23F354C
	public bool get_IsPopResultWindow() { }

	[CompilerGenerated]
	// RVA: 0x23F3554 Offset: 0x23EF554 VA: 0x23F3554
	private void set_IsPopResultWindow(bool value) { }

	// RVA: 0x23F3560 Offset: 0x23EF560 VA: 0x23F3560
	private void Start() { }

	// RVA: 0x23F35D8 Offset: 0x23EF5D8 VA: 0x23F35D8
	public void Clear() { }

	// RVA: 0x23F3624 Offset: 0x23EF624 VA: 0x23F3624
	public void TreasureBoxDataChange() { }

	// RVA: 0x23F36E0 Offset: 0x23EF6E0 VA: 0x23F36E0
	public void AddTreasureBox(int id, Vector3 position, float rot, byte type) { }

	// RVA: 0x23F3924 Offset: 0x23EF924 VA: 0x23F3924
	public void OpenTreasureBox(int id) { }

	// RVA: 0x23EA4F4 Offset: 0x23E64F4 VA: 0x23EA4F4
	public void GetTreasureBoxModel(int modelId, int motionId, Action<GameObject> act) { }

	// RVA: 0x23F3934 Offset: 0x23EF934 VA: 0x23F3934
	private void TreasureOpenEffect(int id) { }

	// RVA: 0x23F37AC Offset: 0x23EF7AC VA: 0x23F37AC
	private void CreateTreasureBox(int id, Vector3 position, float rot, byte type) { }

	// RVA: 0x23F3E54 Offset: 0x23EFE54 VA: 0x23F3E54
	public void OpenTreasureBox(int id, int[] itemList, bool party) { }

	// RVA: 0x23F4058 Offset: 0x23F0058 VA: 0x23F4058
	public bool LoadBoxBinary(int foldId, byte[] binary) { }

	// RVA: 0x23F4654 Offset: 0x23F0654 VA: 0x23F4654
	public void WorldTreasureSetting(TreasureSettingData[] data) { }

	// RVA: 0x23F485C Offset: 0x23F085C VA: 0x23F485C
	public void OpenTreasureBox(RewardData[] reward, int id) { }

	[IteratorStateMachine(typeof(TreasureBoxManager.<TreasureBoxRewardWindow>d__31))]
	// RVA: 0x23F48A8 Offset: 0x23F08A8 VA: 0x23F48A8
	private IEnumerator TreasureBoxRewardWindow(RewardData[] reward, TreasureBoxData box) { }

	// RVA: 0x23F496C Offset: 0x23F096C VA: 0x23F496C
	public bool IsOpenedBox(int id) { }

	// RVA: 0x23F4984 Offset: 0x23F0984 VA: 0x23F4984
	public int[] get_TreasureHuntBoxTotalCount() { }

	// RVA: 0x23F498C Offset: 0x23F098C VA: 0x23F498C
	public void CreateTreasureHuntBox(TreasureHuntTreasureData[] data) { }

	// RVA: 0x23F4F80 Offset: 0x23F0F80 VA: 0x23F4F80
	public void AcquireTreasureHuntBox(byte localId) { }

	// RVA: 0x23F501C Offset: 0x23F101C VA: 0x23F501C
	public void TreasureHuntBoxCountClear() { }

	[IteratorStateMachine(typeof(TreasureBoxManager.<AcquireTreasureHunt>d__40))]
	// RVA: 0x23F4FA0 Offset: 0x23F0FA0 VA: 0x23F4FA0
	private IEnumerator AcquireTreasureHunt(byte localId) { }

	// RVA: 0x23F5068 Offset: 0x23F1068 VA: 0x23F5068
	public void CreateSearchPotumObject(HideSeekData[] hideSeekList) { }

	[IteratorStateMachine(typeof(TreasureBoxManager.<LoadSearchPotumObject>d__43))]
	// RVA: 0x23F517C Offset: 0x23F117C VA: 0x23F517C
	private IEnumerator LoadSearchPotumObject(HideSeekData hideSeekData) { }

	// RVA: 0x23F522C Offset: 0x23F122C VA: 0x23F522C
	private void ClearSearchPotum() { }

	// RVA: 0x23F53D4 Offset: 0x23F13D4 VA: 0x23F53D4 Slot: 4
	public void OnEnter() { }

	// RVA: 0x23F53D8 Offset: 0x23F13D8 VA: 0x23F53D8 Slot: 5
	public void OnLeave() { }

	// RVA: 0x23F53F0 Offset: 0x23F13F0 VA: 0x23F53F0
	public void .ctor() { }

	// RVA: 0x23F5520 Offset: 0x23F1520 VA: 0x23F5520
	private static void .cctor() { }
}
