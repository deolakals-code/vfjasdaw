// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureHuntManager // TypeDefIndex: 1539
{
	// Fields
	public const int BoxRankMax = 5;
	private readonly int[] treasureUpdateTime; // 0x10
	private UITreasureHuntPanel treasureHuntPanel; // 0x18
	private SystemTextManager systemTextManager; // 0x20
	private ItemTextManager itemTextManager; // 0x28
	private int lastSetTime; // 0x30
	private int[] acqiureBoxNum; // 0x38
	private UIActiveState currentState; // 0x40
	private UIActiveState prevState; // 0x44
	[CompilerGenerated]
	private bool <IsStarted>k__BackingField; // 0x48
	[CompilerGenerated]
	private TreasureHuntGameEndEvent <ResultData>k__BackingField; // 0x50
	[CompilerGenerated]
	private TreasureHuntTestGameEndEvent <TestResultData>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <IsTestVersionResult>k__BackingField; // 0x60

	// Properties
	public bool IsStarted { get; set; }
	public TreasureHuntGameEndEvent ResultData { get; set; }
	public TreasureHuntTestGameEndEvent TestResultData { get; set; }
	public bool IsTestVersionResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20877EC Offset: 0x20837EC VA: 0x20877EC
	public bool get_IsStarted() { }

	[CompilerGenerated]
	// RVA: 0x20877F4 Offset: 0x20837F4 VA: 0x20877F4
	private void set_IsStarted(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2087800 Offset: 0x2083800 VA: 0x2087800
	public TreasureHuntGameEndEvent get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x2087808 Offset: 0x2083808 VA: 0x2087808
	private void set_ResultData(TreasureHuntGameEndEvent value) { }

	[CompilerGenerated]
	// RVA: 0x2087810 Offset: 0x2083810 VA: 0x2087810
	public TreasureHuntTestGameEndEvent get_TestResultData() { }

	[CompilerGenerated]
	// RVA: 0x2087818 Offset: 0x2083818 VA: 0x2087818
	private void set_TestResultData(TreasureHuntTestGameEndEvent value) { }

	[CompilerGenerated]
	// RVA: 0x2087820 Offset: 0x2083820 VA: 0x2087820
	public bool get_IsTestVersionResult() { }

	[CompilerGenerated]
	// RVA: 0x2087828 Offset: 0x2083828 VA: 0x2087828
	private void set_IsTestVersionResult(bool value) { }

	// RVA: 0x2087834 Offset: 0x2083834 VA: 0x2087834
	public void Initialize(int time) { }

	// RVA: 0x2087C20 Offset: 0x2083C20 VA: 0x2087C20
	public void SetTreasureHuntTimeLeft(int time) { }

	// RVA: 0x2087D88 Offset: 0x2083D88 VA: 0x2087D88
	public void SetTreasureHuntAcqiureBoxNum() { }

	// RVA: 0x2087F40 Offset: 0x2083F40 VA: 0x2087F40
	public void AcqiureBox(int index) { }

	// RVA: 0x2087F78 Offset: 0x2083F78 VA: 0x2087F78
	public void PanelRemove() { }

	// RVA: 0x2088038 Offset: 0x2084038 VA: 0x2088038
	public void Leave() { }

	// RVA: 0x208803C Offset: 0x208403C VA: 0x208803C
	public bool ActiveStateChange() { }

	// RVA: 0x20880A8 Offset: 0x20840A8 VA: 0x20880A8
	public bool IsOpenDescriptionState() { }

	// RVA: 0x20880D8 Offset: 0x20840D8 VA: 0x20880D8
	public void TreasureHuntStart() { }

	// RVA: 0x2088104 Offset: 0x2084104 VA: 0x2088104
	public void OpenBoxFailure(Vector3 pos) { }

	// RVA: 0x2088120 Offset: 0x2084120 VA: 0x2088120
	public void AddLog(byte type, int updateTime) { }

	// RVA: 0x208837C Offset: 0x208437C VA: 0x208837C
	public void ChangeResultPanel() { }

	// RVA: 0x20884D8 Offset: 0x20844D8 VA: 0x20884D8
	public void SetResultData(TreasureHuntGameEndEvent data) { }

	// RVA: 0x20884E4 Offset: 0x20844E4 VA: 0x20884E4
	public void SetResultData(TreasureHuntTestGameEndEvent data) { }

	// RVA: 0x20884F4 Offset: 0x20844F4 VA: 0x20884F4
	public string GetBoxTypeName(int rank) { }

	// RVA: 0x2087A00 Offset: 0x2083A00 VA: 0x2087A00
	private void CreateTreasureHuntPanel() { }

	// RVA: 0x2087DD4 Offset: 0x2083DD4 VA: 0x2087DD4
	private void SetTreasureHuntBoxNumLabel(int index) { }

	// RVA: 0x20882E0 Offset: 0x20842E0 VA: 0x20882E0
	private string GetBoxName(int time) { }

	// RVA: 0x208857C Offset: 0x208457C VA: 0x208857C
	public void .ctor() { }
}
