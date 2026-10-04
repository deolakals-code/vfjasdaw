// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WorldTreasureManager // TypeDefIndex: 1542
{
	// Fields
	public static readonly int maxKeyNum; // 0x0
	public static readonly int createSeconds; // 0x4
	public static readonly int unlockMissionNo; // 0x8
	[CompilerGenerated]
	private int <KeyNum>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <LapseSecond>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <RecoveryKeyNum>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsConnect>k__BackingField; // 0x1C
	private List<TreasureSettingData> treasureDataList; // 0x20

	// Properties
	public int KeyNum { get; set; }
	public float LapseSecond { get; set; }
	public int RecoveryKeyNum { get; set; }
	public bool IsConnect { get; set; }
	public TreasureSettingData[] TreasureData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2088720 Offset: 0x2084720 VA: 0x2088720
	public int get_KeyNum() { }

	[CompilerGenerated]
	// RVA: 0x2088728 Offset: 0x2084728 VA: 0x2088728
	private void set_KeyNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x2088730 Offset: 0x2084730 VA: 0x2088730
	public float get_LapseSecond() { }

	[CompilerGenerated]
	// RVA: 0x2088738 Offset: 0x2084738 VA: 0x2088738
	private void set_LapseSecond(float value) { }

	[CompilerGenerated]
	// RVA: 0x2088740 Offset: 0x2084740 VA: 0x2088740
	public int get_RecoveryKeyNum() { }

	[CompilerGenerated]
	// RVA: 0x2088748 Offset: 0x2084748 VA: 0x2088748
	private void set_RecoveryKeyNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x2088750 Offset: 0x2084750 VA: 0x2088750
	public bool get_IsConnect() { }

	[CompilerGenerated]
	// RVA: 0x2088758 Offset: 0x2084758 VA: 0x2088758
	private void set_IsConnect(bool value) { }

	// RVA: 0x2088764 Offset: 0x2084764 VA: 0x2088764
	public TreasureSettingData[] get_TreasureData() { }

	// RVA: 0x20887B4 Offset: 0x20847B4 VA: 0x20887B4
	public void .ctor() { }

	// RVA: 0x208884C Offset: 0x208484C VA: 0x208884C
	public void Update() { }

	// RVA: 0x20889FC Offset: 0x20849FC VA: 0x20889FC
	public void KeyInfoUpdate(int keyNum, int lapseSecond = -1) { }

	// RVA: 0x2088A14 Offset: 0x2084A14 VA: 0x2088A14
	public void KeyRecovery(int keyNum) { }

	// RVA: 0x2088A2C Offset: 0x2084A2C VA: 0x2088A2C
	public void KeyRecoveryConnect() { }

	// RVA: 0x2088A38 Offset: 0x2084A38 VA: 0x2088A38
	public bool IsKeyInfoUnacquired() { }

	// RVA: 0x208891C Offset: 0x208491C VA: 0x208891C
	public bool IsUseLock() { }

	// RVA: 0x2088A74 Offset: 0x2084A74 VA: 0x2088A74
	public void TreasureDataListUpdate(TreasureSettingData[] data) { }

	[IteratorStateMachine(typeof(WorldTreasureManager.<UpdateKeyInfo>d__31))]
	// RVA: 0x2088B9C Offset: 0x2084B9C VA: 0x2088B9C
	public static IEnumerator UpdateKeyInfo() { }

	// RVA: 0x2088C1C Offset: 0x2084C1C VA: 0x2088C1C
	private static void .cctor() { }
}
