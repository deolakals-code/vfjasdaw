// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCultivationManager : UIBasePanel // TypeDefIndex: 7235
{
	// Fields
	[SerializeField]
	private GameObject allWaterButton; // 0x30
	[SerializeField]
	private GameObject cultivationButton; // 0x38
	[SerializeField]
	private GameObject popHarvestPanel; // 0x40
	[SerializeField]
	private UILabel popHarvestGetPointLabel; // 0x48
	[SerializeField]
	private UILabel popHarvestAllPointlabel; // 0x50
	[SerializeField]
	private GameObject popHarvestItemPanel; // 0x58
	[SerializeField]
	private UILabel popHarvestGetNumLabel; // 0x60
	[SerializeField]
	private UILabel popHarvestItemNamelabel; // 0x68
	private UIScrollWindow scrollListWindow; // 0x70
	private UIImageButton allWaterImageButton; // 0x78
	private Dictionary<short, UIHouseCultivationButton> buttonList; // 0x80
	private UIPopBaseWindow popWindow; // 0x88
	private bool cancelCheck; // 0x90
	private bool isInitList; // 0x91
	private PlayerDataManager playerDataManager; // 0x98

	// Methods

	[IteratorStateMachine(typeof(UIHouseCultivationManager.<Start>d__15))]
	// RVA: 0x1AE4F08 Offset: 0x1AE0F08 VA: 0x1AE4F08
	private IEnumerator Start() { }

	// RVA: 0x1AE4F9C Offset: 0x1AE0F9C VA: 0x1AE4F9C
	private void UpdatePanel() { }

	// RVA: 0x1AE535C Offset: 0x1AE135C VA: 0x1AE535C
	public void OnClickAllWaterButton() { }

	[IteratorStateMachine(typeof(UIHouseCultivationManager.<AllWaterButtonThread>d__18))]
	// RVA: 0x1AE54DC Offset: 0x1AE14DC VA: 0x1AE54DC
	private IEnumerator AllWaterButtonThread() { }

	// RVA: 0x1AE0A64 Offset: 0x1ADCA64 VA: 0x1AE0A64
	public void OnClickTargetWaterButton(int index, int produceId) { }

	[IteratorStateMachine(typeof(UIHouseCultivationManager.<TargetWaterButtonThread>d__20))]
	// RVA: 0x1AE5570 Offset: 0x1AE1570 VA: 0x1AE5570
	private IEnumerator TargetWaterButtonThread(short index, int produceId) { }

	// RVA: 0x1AE0CE0 Offset: 0x1ADCCE0 VA: 0x1AE0CE0
	public void OnClickTargetProduceHarvest(int index, byte type, int produceId) { }

	[IteratorStateMachine(typeof(UIHouseCultivationManager.<TargetProduceHarvestThread>d__22))]
	// RVA: 0x1AE561C Offset: 0x1AE161C VA: 0x1AE561C
	private IEnumerator TargetProduceHarvestThread(short index, byte type, int produceId) { }

	[IteratorStateMachine(typeof(UIHouseCultivationManager.<PopUpWindow>d__23))]
	// RVA: 0x1AE56D8 Offset: 0x1AE16D8 VA: 0x1AE56D8
	private IEnumerator PopUpWindow(Action<int> callback) { }

	[IteratorStateMachine(typeof(UIHouseCultivationManager.<LoadingWait>d__24))]
	// RVA: 0x1AE5788 Offset: 0x1AE1788 VA: 0x1AE5788
	private IEnumerator LoadingWait(Func<bool> waitAction) { }

	// RVA: 0x1AE5838 Offset: 0x1AE1838 VA: 0x1AE5838 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AE58E0 Offset: 0x1AE18E0 VA: 0x1AE58E0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AE596C Offset: 0x1AE196C VA: 0x1AE596C
	public void .ctor() { }
}
