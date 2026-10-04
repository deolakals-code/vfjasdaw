// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FishingGameManager : Singleton<FishingGameManager> // TypeDefIndex: 4343
{
	// Fields
	public const int Fishing_Start = 3001;
	public const int Fishing_Hit = 3002;
	public const int Fishing_Battle = 3003;
	public const int Fishing_Fight = 3004;
	public const int Fishing_Finish = 3005;
	public const int Fishing_Result_0 = 3006;
	public const int Fishing_Result_1 = 3007;
	public const int Fishing_Result_2 = 3008;
	private SystemTextManager systemTextManager; // 0x20
	private Dictionary<int, FishingMasterFishData> masterDatas; // 0x28
	private Dictionary<short, FishingFishClientData> fishBag; // 0x30
	private Dictionary<byte, FishingRodClientData> rodBag; // 0x38
	private PlayerDataManager playerDataManager; // 0x40
	private bool isFishing; // 0x48
	private bool isHit; // 0x49
	private int fieldBGMId; // 0x4C
	private int fieldGameBGMId; // 0x50
	private Action<bool> hitTimingAction; // 0x58
	[CompilerGenerated]
	private short <BagCapacity>k__BackingField; // 0x60
	[CompilerGenerated]
	private byte <EquipRodIndex>k__BackingField; // 0x62
	[CompilerGenerated]
	private int <ChummingFieldId>k__BackingField; // 0x64
	[CompilerGenerated]
	private byte <ChummingCount>k__BackingField; // 0x68

	// Properties
	private PlayerDataManager pdata { get; }
	public bool IsNonRod { get; }
	public short BagCapacity { get; set; }
	public byte EquipRodIndex { get; set; }
	public int ChummingFieldId { get; set; }
	public byte ChummingCount { get; set; }
	public PlayerDataManager PData { get; }
	public bool IsFishing { get; }
	public bool IsHit { get; }
	public short RodNum { get; }
	public short FishListCount { get; }
	public FishingFishClientData[] FishList { get; }

	// Methods

	// RVA: 0x24D2AE8 Offset: 0x24CEAE8 VA: 0x24D2AE8
	private PlayerDataManager get_pdata() { }

	// RVA: 0x24D2B6C Offset: 0x24CEB6C VA: 0x24D2B6C
	public bool get_IsNonRod() { }

	[CompilerGenerated]
	// RVA: 0x24D2BF0 Offset: 0x24CEBF0 VA: 0x24D2BF0
	public short get_BagCapacity() { }

	[CompilerGenerated]
	// RVA: 0x24D2BF8 Offset: 0x24CEBF8 VA: 0x24D2BF8
	private void set_BagCapacity(short value) { }

	[CompilerGenerated]
	// RVA: 0x24D2C00 Offset: 0x24CEC00 VA: 0x24D2C00
	public byte get_EquipRodIndex() { }

	[CompilerGenerated]
	// RVA: 0x24D2C08 Offset: 0x24CEC08 VA: 0x24D2C08
	private void set_EquipRodIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x24D2C10 Offset: 0x24CEC10 VA: 0x24D2C10
	public int get_ChummingFieldId() { }

	[CompilerGenerated]
	// RVA: 0x24D2C18 Offset: 0x24CEC18 VA: 0x24D2C18
	private void set_ChummingFieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D2C20 Offset: 0x24CEC20 VA: 0x24D2C20
	public byte get_ChummingCount() { }

	[CompilerGenerated]
	// RVA: 0x24D2C28 Offset: 0x24CEC28 VA: 0x24D2C28
	private void set_ChummingCount(byte value) { }

	// RVA: 0x24D2C30 Offset: 0x24CEC30 VA: 0x24D2C30
	public PlayerDataManager get_PData() { }

	// RVA: 0x24D2C34 Offset: 0x24CEC34 VA: 0x24D2C34
	public bool get_IsFishing() { }

	// RVA: 0x24D2C3C Offset: 0x24CEC3C VA: 0x24D2C3C
	public bool get_IsHit() { }

	// RVA: 0x24D2B9C Offset: 0x24CEB9C VA: 0x24D2B9C
	public short get_RodNum() { }

	// RVA: 0x24D2C44 Offset: 0x24CEC44 VA: 0x24D2C44
	public short get_FishListCount() { }

	// RVA: 0x24D2C98 Offset: 0x24CEC98 VA: 0x24D2C98
	public FishingFishClientData[] get_FishList() { }

	// RVA: 0x24D2D04 Offset: 0x24CED04 VA: 0x24D2D04
	public bool LoadFishingMasterData() { }

	// RVA: 0x24D322C Offset: 0x24CF22C VA: 0x24D322C
	public void LoadSE(List<int> loadFieldId, List<int> loadBGM, int loadBGMId) { }

	// RVA: 0x24D358C Offset: 0x24CF58C VA: 0x24D358C
	public void SetFishingData(FishingData fishingData) { }

	// RVA: 0x24D37DC Offset: 0x24CF7DC VA: 0x24D37DC
	public void DiscardRodData(byte rodIndex) { }

	// RVA: 0x24D386C Offset: 0x24CF86C VA: 0x24D386C
	public void ChangeFishingFlag(bool isPlay) { }

	// RVA: 0x24D39A8 Offset: 0x24CF9A8 VA: 0x24D39A8
	public void ChangeFishingHitFlag(bool isFlag) { }

	// RVA: 0x24D39B4 Offset: 0x24CF9B4 VA: 0x24D39B4
	public void ChangeEquipRodIndex(byte equipRodIndex) { }

	// RVA: 0x24D39BC Offset: 0x24CF9BC VA: 0x24D39BC
	public void ChangeBagCapacity(short bagCapacity) { }

	// RVA: 0x24D39C4 Offset: 0x24CF9C4 VA: 0x24D39C4
	public void CheckFishingArea() { }

	// RVA: 0x24D459C Offset: 0x24D059C VA: 0x24D459C
	public void SetHitTimingAction(Action<bool> action) { }

	// RVA: 0x24D45A4 Offset: 0x24D05A4 VA: 0x24D45A4
	public void FishingHit() { }

	// RVA: 0x24D4758 Offset: 0x24D0758 VA: 0x24D4758
	public void FishingHitEnd() { }

	// RVA: 0x24D47F4 Offset: 0x24D07F4 VA: 0x24D47F4
	public void PlayerRotate(bool isLookTowards) { }

	// RVA: 0x24D48EC Offset: 0x24D08EC VA: 0x24D48EC
	public bool TryGetEquipRodData(out FishingRodClientData rodData) { }

	// RVA: 0x24D4948 Offset: 0x24D0948 VA: 0x24D4948
	public bool TryGetRodData(byte indexId, out FishingRodClientData rodData) { }

	// RVA: 0x24D49B0 Offset: 0x24D09B0 VA: 0x24D49B0
	public bool TryGetFishData(short indexId, out FishingFishClientData fishData) { }

	// RVA: 0x24D4A18 Offset: 0x24D0A18 VA: 0x24D4A18
	public bool TryGetFishMasterData(int fishId, out FishingMasterFishData fishMasterData) { }

	[IteratorStateMachine(typeof(FishingGameManager.<LoadModel>d__68))]
	// RVA: 0x24D4A9C Offset: 0x24D0A9C VA: 0x24D4A9C
	public IEnumerator LoadModel(int fishId, int size, Action<GameObject, float> callback) { }

	[IteratorStateMachine(typeof(FishingGameManager.<LoadFishResource>d__69))]
	// RVA: 0x24D4B64 Offset: 0x24D0B64 VA: 0x24D4B64
	private IEnumerator LoadFishResource(int modelId, Action<bool> result) { }

	// RVA: 0x24D4C1C Offset: 0x24D0C1C VA: 0x24D4C1C
	public void OnEventFishingHit(FishingHitEvent hit) { }

	// RVA: 0x24D4CB8 Offset: 0x24D0CB8 VA: 0x24D4CB8
	public void ReceiveProcessFishingFish(ProcessFishingFishResponse response) { }

	// RVA: 0x24D4D7C Offset: 0x24D0D7C VA: 0x24D4D7C
	public void ReceiveChumming(int fieldId, byte chummingCount) { }

	// RVA: 0x24D4D88 Offset: 0x24D0D88 VA: 0x24D4D88
	public void ReceiveRodsData(FishingRodData[] rodDatas) { }

	// RVA: 0x24D4EA0 Offset: 0x24D0EA0 VA: 0x24D4EA0
	public void ReceiveFishDatas(FishingFishData[] fishDatas) { }

	// RVA: 0x24D4FB8 Offset: 0x24D0FB8 VA: 0x24D4FB8
	public static int CalcDisplayCummingCount(int count) { }

	// RVA: 0x24D44C4 Offset: 0x24D04C4 VA: 0x24D44C4
	private void StartFishingGame() { }

	// RVA: 0x24D48D0 Offset: 0x24D08D0 VA: 0x24D48D0
	private Vector3 GetOppositePoint(Vector3 a, Vector3 b) { }

	// RVA: 0x24D4FC8 Offset: 0x24D0FC8 VA: 0x24D4FC8
	public void .ctor() { }
}
