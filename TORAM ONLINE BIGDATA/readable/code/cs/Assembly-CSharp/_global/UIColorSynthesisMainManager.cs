// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisMainManager : UIBasePanelConnection // TypeDefIndex: 6728
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x30
	[SerializeField]
	private GameObject popupTitle; // 0x38
	[SerializeField]
	private GameObject errorMessage; // 0x40
	[SerializeField]
	private GameObject popResultMessage; // 0x48
	[CompilerGenerated]
	private ColorSynthesisSelection <Selection>k__BackingField; // 0x50
	[CompilerGenerated]
	private ColorSynthesisResponse <LastResponse>k__BackingField; // 0x58
	private UIColorSynthesisMainManager.PanelState panelState; // 0x60
	private PlayerDataManager playerDataManager; // 0x68
	private ItemTextManager itemTextManager; // 0x70
	private IUIColorSynthesisPanel[] panels; // 0x78
	private UIPopBaseWindow popWindow; // 0x80
	private readonly Dictionary<int, int> brokenGems; // 0x88

	// Properties
	public ColorSynthesisSelection Selection { get; set; }
	public UIColorSynthesisMainManager.PanelState CurrentState { get; }
	public ColorSynthesisResponse LastResponse { get; set; }
	public IReadOnlyDictionary<int, int> BrokenGems { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19CBA3C Offset: 0x19C7A3C VA: 0x19CBA3C
	public ColorSynthesisSelection get_Selection() { }

	[CompilerGenerated]
	// RVA: 0x19CBA44 Offset: 0x19C7A44 VA: 0x19CBA44
	private void set_Selection(ColorSynthesisSelection value) { }

	// RVA: 0x19CBA4C Offset: 0x19C7A4C VA: 0x19CBA4C
	public UIColorSynthesisMainManager.PanelState get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x19CBA54 Offset: 0x19C7A54 VA: 0x19CBA54
	public ColorSynthesisResponse get_LastResponse() { }

	[CompilerGenerated]
	// RVA: 0x19CBA5C Offset: 0x19C7A5C VA: 0x19CBA5C
	private void set_LastResponse(ColorSynthesisResponse value) { }

	// RVA: 0x19CBA64 Offset: 0x19C7A64 VA: 0x19CBA64
	public IReadOnlyDictionary<int, int> get_BrokenGems() { }

	// RVA: 0x19CBA6C Offset: 0x19C7A6C VA: 0x19CBA6C
	private void Start() { }

	// RVA: 0x19CB694 Offset: 0x19C7694 VA: 0x19CB694
	public void ChangePanelState(UIColorSynthesisMainManager.PanelState state) { }

	// RVA: 0x19C6CD4 Offset: 0x19C2CD4 VA: 0x19C6CD4
	public List<byte> GetCandidateColors() { }

	// RVA: 0x19CBEE4 Offset: 0x19C7EE4 VA: 0x19CBEE4
	public int GetSuccessRate() { }

	// RVA: 0x19C6CB4 Offset: 0x19C2CB4 VA: 0x19C6CB4
	public int GetDisplaySuccessRate() { }

	// RVA: 0x19C6C7C Offset: 0x19C2C7C VA: 0x19C6C7C
	public long GetCost() { }

	// RVA: 0x19C97B0 Offset: 0x19C57B0 VA: 0x19C97B0
	public int GetItemCount(int itemId) { }

	// RVA: 0x19C6ACC Offset: 0x19C2ACC VA: 0x19C6ACC
	public string GetResultItemIconName() { }

	// RVA: 0x19CC248 Offset: 0x19C8248 VA: 0x19CC248
	public string GetResultEquipTypeName() { }

	// RVA: 0x19CC378 Offset: 0x19C8378 VA: 0x19CC378
	public string GetResultPartName() { }

	// RVA: 0x19C6BE4 Offset: 0x19C2BE4 VA: 0x19C6BE4
	public string GetResultEquipDisplayName() { }

	// RVA: 0x19C76BC Offset: 0x19C36BC VA: 0x19C76BC
	public void RequestColorSynthesis() { }

	// RVA: 0x19CC4B4 Offset: 0x19C84B4 VA: 0x19CC4B4
	private static ColorSynthesisType ToSynthesisType(ColorSynthesisCostTable.EquipBase baseType) { }

	// RVA: 0x19CC50C Offset: 0x19C850C VA: 0x19CC50C
	private void OnColorSynthesisSuccess(ColorSynthesisResponse response) { }

	// RVA: 0x19CC8DC Offset: 0x19C88DC VA: 0x19CC8DC
	private void OnColorSynthesisError(string key, int errorCode, Action afterClose) { }

	// RVA: 0x19CCAA0 Offset: 0x19C8AA0 VA: 0x19CCAA0
	public void RequestStockColor(Action onComplete) { }

	// RVA: 0x19CC010 Offset: 0x19C8010 VA: 0x19CC010
	private ValueTuple<int, int, int, int> GetColorSkillLevels() { }

	// RVA: 0x19CC8E0 Offset: 0x19C88E0 VA: 0x19CC8E0
	private void OpenErrorWindow(string messageKey, int errorCode, Action afterClose) { }

	// RVA: 0x19CCBF0 Offset: 0x19C8BF0 VA: 0x19CCBF0
	private void ReturnExSkillMenu() { }

	// RVA: 0x19CCCDC Offset: 0x19C8CDC VA: 0x19CCCDC
	public void ShowPhilosophersStoneGetPopup(Action onClose) { }

	[IteratorStateMachine(typeof(UIColorSynthesisMainManager.<PhilosophersStoneGetPopupCoroutine>d__45))]
	// RVA: 0x19CCCFC Offset: 0x19C8CFC VA: 0x19CCCFC
	private IEnumerator PhilosophersStoneGetPopupCoroutine(Action onClose) { }

	// RVA: 0x19CCDAC Offset: 0x19C8DAC VA: 0x19CCDAC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19CCED4 Offset: 0x19C8ED4 VA: 0x19CCED4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19CCF60 Offset: 0x19C8F60 VA: 0x19CCF60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19CD0B8 Offset: 0x19C90B8 VA: 0x19CD0B8
	private void <OpenErrorWindow>b__42_0() { }
}
