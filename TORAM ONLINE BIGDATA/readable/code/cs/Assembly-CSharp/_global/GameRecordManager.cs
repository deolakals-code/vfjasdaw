// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameRecordManager // TypeDefIndex: 1383
{
	// Fields
	private long serverContinuousTime; // 0x10
	private long checkTargetContinuousTime; // 0x18
	private long serverTotalTime; // 0x20
	private long checkTargetTotalTime; // 0x28
	private long serverDailyTime; // 0x30
	private long checkTargetDailyTime; // 0x38
	private float localTimer; // 0x40
	[CompilerGenerated]
	private int <RareDropNum>k__BackingField; // 0x44
	[CompilerGenerated]
	private int <SubdueMobNum>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <QuestCompNum>k__BackingField; // 0x4C
	[CompilerGenerated]
	private int <Distance>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <DeadCount>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <AttackerCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <DefenderCount>k__BackingField; // 0x5C
	[CompilerGenerated]
	private int <SupporterCount>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <BreakerCount>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <AidCount>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsConnect>k__BackingField; // 0x6C

	// Properties
	public string LocalContinuousTime { get; }
	public long LocalContinuousTimeToLong { get; }
	public string LocalTotalTime { get; }
	public int LocalTotalHour { get; }
	public string LocalDailyTime { get; }
	public float LocalTimer { get; }
	public int RareDropNum { get; set; }
	public int SubdueMobNum { get; set; }
	public int QuestCompNum { get; set; }
	public int Distance { get; set; }
	public int DeadCount { get; set; }
	public int AttackerCount { get; set; }
	public int DefenderCount { get; set; }
	public int SupporterCount { get; set; }
	public int BreakerCount { get; set; }
	public int AidCount { get; set; }
	public bool IsConnect { get; set; }

	// Methods

	// RVA: 0x1FE6A24 Offset: 0x1FE2A24 VA: 0x1FE6A24
	public string get_LocalContinuousTime() { }

	// RVA: 0x1FE6C74 Offset: 0x1FE2C74 VA: 0x1FE6C74
	public long get_LocalContinuousTimeToLong() { }

	// RVA: 0x1FE6D8C Offset: 0x1FE2D8C VA: 0x1FE6D8C
	public string get_LocalTotalTime() { }

	// RVA: 0x1FE6FC0 Offset: 0x1FE2FC0 VA: 0x1FE6FC0
	public int get_LocalTotalHour() { }

	// RVA: 0x1FE706C Offset: 0x1FE306C VA: 0x1FE706C
	public string get_LocalDailyTime() { }

	// RVA: 0x1FE72A0 Offset: 0x1FE32A0 VA: 0x1FE72A0
	public float get_LocalTimer() { }

	[CompilerGenerated]
	// RVA: 0x1FE72A8 Offset: 0x1FE32A8 VA: 0x1FE72A8
	private void set_RareDropNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE72B0 Offset: 0x1FE32B0 VA: 0x1FE72B0
	public int get_RareDropNum() { }

	[CompilerGenerated]
	// RVA: 0x1FE72B8 Offset: 0x1FE32B8 VA: 0x1FE72B8
	private void set_SubdueMobNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE72C0 Offset: 0x1FE32C0 VA: 0x1FE72C0
	public int get_SubdueMobNum() { }

	[CompilerGenerated]
	// RVA: 0x1FE72C8 Offset: 0x1FE32C8 VA: 0x1FE72C8
	private void set_QuestCompNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE72D0 Offset: 0x1FE32D0 VA: 0x1FE72D0
	public int get_QuestCompNum() { }

	[CompilerGenerated]
	// RVA: 0x1FE72D8 Offset: 0x1FE32D8 VA: 0x1FE72D8
	private void set_Distance(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE72E0 Offset: 0x1FE32E0 VA: 0x1FE72E0
	public int get_Distance() { }

	[CompilerGenerated]
	// RVA: 0x1FE72E8 Offset: 0x1FE32E8 VA: 0x1FE72E8
	private void set_DeadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE72F0 Offset: 0x1FE32F0 VA: 0x1FE72F0
	public int get_DeadCount() { }

	[CompilerGenerated]
	// RVA: 0x1FE72F8 Offset: 0x1FE32F8 VA: 0x1FE72F8
	private void set_AttackerCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7300 Offset: 0x1FE3300 VA: 0x1FE7300
	public int get_AttackerCount() { }

	[CompilerGenerated]
	// RVA: 0x1FE7308 Offset: 0x1FE3308 VA: 0x1FE7308
	private void set_DefenderCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7310 Offset: 0x1FE3310 VA: 0x1FE7310
	public int get_DefenderCount() { }

	[CompilerGenerated]
	// RVA: 0x1FE7318 Offset: 0x1FE3318 VA: 0x1FE7318
	private void set_SupporterCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7320 Offset: 0x1FE3320 VA: 0x1FE7320
	public int get_SupporterCount() { }

	[CompilerGenerated]
	// RVA: 0x1FE7328 Offset: 0x1FE3328 VA: 0x1FE7328
	private void set_BreakerCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7330 Offset: 0x1FE3330 VA: 0x1FE7330
	public int get_BreakerCount() { }

	[CompilerGenerated]
	// RVA: 0x1FE7338 Offset: 0x1FE3338 VA: 0x1FE7338
	private void set_AidCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7340 Offset: 0x1FE3340 VA: 0x1FE7340
	public int get_AidCount() { }

	[CompilerGenerated]
	// RVA: 0x1FE7348 Offset: 0x1FE3348 VA: 0x1FE7348
	public bool get_IsConnect() { }

	[CompilerGenerated]
	// RVA: 0x1FE7350 Offset: 0x1FE3350 VA: 0x1FE7350
	private void set_IsConnect(bool value) { }

	// RVA: 0x1FE735C Offset: 0x1FE335C VA: 0x1FE735C
	public void .ctor() { }

	// RVA: 0x1FE7378 Offset: 0x1FE3378 VA: 0x1FE7378
	public void Update() { }

	// RVA: 0x1FE7484 Offset: 0x1FE3484 VA: 0x1FE7484
	public void ConnectGameRecord() { }

	// RVA: 0x1FE74F4 Offset: 0x1FE34F4 VA: 0x1FE74F4
	public void SetGameRecord(GameRecordEvent record) { }
}
