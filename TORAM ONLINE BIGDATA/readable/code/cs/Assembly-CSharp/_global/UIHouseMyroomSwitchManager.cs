// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMyroomSwitchManager : UIBasePanelConnection // TypeDefIndex: 7293
{
	// Fields
	[SerializeField]
	private Transform mainPanelTransform; // 0x30
	[SerializeField]
	private UIHouseMyroomSwitchElement itemElement; // 0x38
	private const byte maxItemNum = 3;
	private UIHouseMyroomSwitchElement[] elements; // 0x40
	private HouseSlotData[] editSlotList; // 0x48

	// Properties
	public bool IsPopErrorWindow { get; }

	// Methods

	// RVA: 0x1B00FFC Offset: 0x1AFCFFC VA: 0x1B00FFC
	public bool get_IsPopErrorWindow() { }

	// RVA: 0x1B0104C Offset: 0x1AFD04C VA: 0x1B0104C
	private void Start() { }

	// RVA: 0x1B00C9C Offset: 0x1AFCC9C VA: 0x1B00C9C
	public void PopErrorWindow(string mes, Action callback) { }

	[IteratorStateMachine(typeof(UIHouseMyroomSwitchManager.<Initialize>d__9))]
	// RVA: 0x1B011BC Offset: 0x1AFD1BC VA: 0x1B011BC
	private IEnumerator Initialize() { }

	[IteratorStateMachine(typeof(UIHouseMyroomSwitchManager.<GetSaveSlotData>d__10))]
	// RVA: 0x1B01250 Offset: 0x1AFD250 VA: 0x1B01250
	private IEnumerator GetSaveSlotData() { }

	// RVA: 0x1B012E4 Offset: 0x1AFD2E4 VA: 0x1B012E4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B01358 Offset: 0x1AFD358 VA: 0x1B01358 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B013B4 Offset: 0x1AFD3B4 VA: 0x1B013B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B01450 Offset: 0x1AFD450 VA: 0x1B01450
	private void <GetSaveSlotData>b__10_1() { }
}
