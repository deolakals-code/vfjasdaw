// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMyroomSwitchElement : MonoBehaviour // TypeDefIndex: 7288
{
	// Fields
	[SerializeField]
	private GameObject houseIconObj; // 0x20
	[SerializeField]
	private GameObject batsuIconObj; // 0x28
	[SerializeField]
	private UILabel useLabel; // 0x30
	[SerializeField]
	private UIImageButton switchButton; // 0x38
	[SerializeField]
	private GameObject switchButtonIcon; // 0x40
	[SerializeField]
	private UIInput memoInput; // 0x48
	[SerializeField]
	private GameObject memoIcon; // 0x50
	[SerializeField]
	private GameObject setObjectNumObj; // 0x58
	[SerializeField]
	private UILabel setObjectNumLabel; // 0x60
	[SerializeField]
	private GameObject attentionObj; // 0x68
	private byte selectSlotNo; // 0x70
	private SystemTextManager systemTextManager; // 0x78
	private string memoText; // 0x80
	private UIHouseMyroomSwitchManager manager; // 0x88

	// Methods

	// RVA: 0x1B001A8 Offset: 0x1AFC1A8 VA: 0x1B001A8
	public void Initialize(UIHouseMyroomSwitchManager manager, HouseSlotData data) { }

	// RVA: 0x1B00684 Offset: 0x1AFC684 VA: 0x1B00684
	public void InitializeNoData(UIHouseMyroomSwitchManager manager, byte slotNo) { }

	// RVA: 0x1B006FC Offset: 0x1AFC6FC VA: 0x1B006FC
	public void OnSubmit() { }

	// RVA: 0x1B008A4 Offset: 0x1AFC8A4 VA: 0x1B008A4
	public void OnSwitch() { }

	// RVA: 0x1B001EC Offset: 0x1AFC1EC VA: 0x1B001EC
	private void SetData(byte slotNo, string memo, short objNum) { }

	[IteratorStateMachine(typeof(UIHouseMyroomSwitchElement.<ChangeSaveSlot>d__19))]
	// RVA: 0x1B008C4 Offset: 0x1AFC8C4 VA: 0x1B008C4
	private IEnumerator ChangeSaveSlot() { }

	[IteratorStateMachine(typeof(UIHouseMyroomSwitchElement.<UpdateSaveSlotData>d__20))]
	// RVA: 0x1B00838 Offset: 0x1AFC838 VA: 0x1B00838
	private IEnumerator UpdateSaveSlotData() { }

	// RVA: 0x1B00980 Offset: 0x1AFC980 VA: 0x1B00980
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B009E0 Offset: 0x1AFC9E0 VA: 0x1B009E0
	private void <UpdateSaveSlotData>b__20_0() { }
}
