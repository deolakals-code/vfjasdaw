// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticSelectColor : MonoBehaviour, IUIPetSynthetic // TypeDefIndex: 7762
{
	// Fields
	[SerializeField]
	private UISprite[] colorButton; // 0x20
	private bool[] colorButtonEnable; // 0x28
	[SerializeField]
	private UISprite[] colorPalette; // 0x30
	[SerializeField]
	private UILabel[] colorLabel; // 0x38
	[SerializeField]
	private GameObject[] costObj; // 0x40
	private UISprite[] costIcon; // 0x48
	private bool[] isUseOrb; // 0x50
	private Action<bool[], bool[]> getAction; // 0x58
	private Action<int> setGoldAction; // 0x60
	private Action<int> setOrbAction; // 0x68
	private Action<bool[]> setColorAction; // 0x70
	private Color[] baseColor; // 0x78
	private int[] materialColor; // 0x80
	private long[] color; // 0x88
	private UIImageButton mainButton; // 0x90
	private bool mainButtonEnable; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private Coroutine endCoroutine; // 0xB0
	private UIPetSyntheticPanel mainPanel; // 0xB8

	// Properties
	private int goldCost { get; }

	// Methods

	// RVA: 0x1C077A8 Offset: 0x1C037A8 VA: 0x1C077A8
	private int get_goldCost() { }

	// RVA: 0x1C07838 Offset: 0x1C03838 VA: 0x1C07838
	public void Initialize(UIPetSyntheticPanel mainPanel, Color[] baseColor, int[] materialColor, bool[] isUseOrb, long[] colors, Action<bool[]> setColorAction, Action<int> setGoldAction, Action<int> setOrbAction, Action<bool[], bool[]> getAction) { }

	// RVA: 0x1C0823C Offset: 0x1C0423C VA: 0x1C0823C Slot: 4
	public void InitMainButton(UIImageButton mainButton) { }

	// RVA: 0x1C083C4 Offset: 0x1C043C4 VA: 0x1C083C4 Slot: 5
	public void ClosePanel() { }

	[IteratorStateMachine(typeof(UIPetSyntheticSelectColor.<CloseAndDisnablePanel>d__25))]
	// RVA: 0x1C083F4 Offset: 0x1C043F4 VA: 0x1C083F4
	private IEnumerator CloseAndDisnablePanel() { }

	// RVA: 0x1C08488 Offset: 0x1C04488 VA: 0x1C08488 Slot: 6
	public void ResetElementPos() { }

	// RVA: 0x1C084C4 Offset: 0x1C044C4 VA: 0x1C084C4
	private void onSelectColor(int param) { }

	// RVA: 0x1C089B4 Offset: 0x1C049B4 VA: 0x1C089B4
	private void onSelectCost(int param) { }

	// RVA: 0x1C08BEC Offset: 0x1C04BEC VA: 0x1C08BEC
	private void onNext() { }

	// RVA: 0x1C07DE0 Offset: 0x1C03DE0 VA: 0x1C07DE0
	private void InitSelectColorObj(int param) { }

	// RVA: 0x1C08544 Offset: 0x1C04544 VA: 0x1C08544
	private void UpdateSelectColorObj(int param) { }

	// RVA: 0x1C0811C Offset: 0x1C0411C VA: 0x1C0811C
	private void UpdateCostButton(int param) { }

	// RVA: 0x1C08A34 Offset: 0x1C04A34 VA: 0x1C08A34
	private void UpdateCostObj(int param) { }

	// RVA: 0x1C08C18 Offset: 0x1C04C18 VA: 0x1C08C18
	private void SetCost(int param) { }

	// RVA: 0x1C08ED4 Offset: 0x1C04ED4 VA: 0x1C08ED4
	private void ResetMainButtonEnable() { }

	// RVA: 0x1C08EF8 Offset: 0x1C04EF8 VA: 0x1C08EF8
	public void .ctor() { }
}
