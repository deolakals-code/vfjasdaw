// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITips : MonoBehaviour // TypeDefIndex: 5187
{
	// Fields
	[SerializeField]
	private UILabel tipsTitleLabel; // 0x20
	[SerializeField]
	private UILabel tipsMessageLabel; // 0x28
	[SerializeField]
	private GameObject backWindow; // 0x30
	private PlayerDataManager playerData; // 0x38
	private readonly int tipsMaxCount; // 0x40
	private readonly int beginnerPlayerLevel; // 0x44
	private SystemTextManager systemTextManager; // 0x48
	private bool isShow; // 0x50
	private int lastShowTipsNo; // 0x54
	private int[] beginnerTipsNo; // 0x58
	private int[] missionBossTipsNo; // 0x60
	private const int missionProgress = 18;
	private readonly int[] missionFieldIds; // 0x68
	private PlayerDataManager playerDataManager; // 0x70
	private float changeTimer; // 0x78
	private const float changeTime = 5;

	// Properties
	private bool initialized { get; }

	// Methods

	// RVA: 0x260512C Offset: 0x260112C VA: 0x260512C
	private bool get_initialized() { }

	// RVA: 0x260513C Offset: 0x260113C VA: 0x260513C
	private void Awake() { }

	// RVA: 0x2605140 Offset: 0x2601140 VA: 0x2605140
	public void Initialize() { }

	// RVA: 0x2605250 Offset: 0x2601250 VA: 0x2605250
	private void Update() { }

	// RVA: 0x2605304 Offset: 0x2601304 VA: 0x2605304
	public void Show() { }

	// RVA: 0x2605568 Offset: 0x2601568 VA: 0x2605568
	public void Show(float switchTime) { }

	// RVA: 0x26052D0 Offset: 0x26012D0 VA: 0x26052D0
	public void Show(int tipsNo) { }

	// RVA: 0x2605500 Offset: 0x2601500 VA: 0x2605500
	private void showTips(int tipsNo) { }

	// RVA: 0x2605810 Offset: 0x2601810 VA: 0x2605810
	public void Hide() { }

	// RVA: 0x2605594 Offset: 0x2601594 VA: 0x2605594
	private void setWindow(bool isShow) { }

	// RVA: 0x26055B4 Offset: 0x26015B4 VA: 0x26055B4
	private void setTitle(int tipsNo) { }

	// RVA: 0x260575C Offset: 0x260175C VA: 0x260575C
	private void setMessage(int tipsNo) { }

	// RVA: 0x260583C Offset: 0x260183C VA: 0x260583C
	public void OnClickTips() { }

	// RVA: 0x26052D4 Offset: 0x26012D4 VA: 0x26052D4
	public void OnChangeTips(int param) { }

	// RVA: 0x260586C Offset: 0x260186C VA: 0x260586C
	public void .ctor() { }
}
