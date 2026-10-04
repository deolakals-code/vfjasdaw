// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDefenceBattleManager : MonoBehaviour // TypeDefIndex: 5730
{
	// Fields
	private UIPopBaseWindow popWindow; // 0x20
	[SerializeField]
	private GameObject popWinButton; // 0x28
	[SerializeField]
	private GameObject battleObj; // 0x30
	[SerializeField]
	private UILabel crystalHpLabel; // 0x38
	[SerializeField]
	private GameObject crystalPanel; // 0x40
	private float hpScale; // 0x48
	private bool hpScaleChangeFlag; // 0x4C
	[SerializeField]
	private GameObject timePanel; // 0x50
	[SerializeField]
	private UILabel timeLabel; // 0x58
	private float clock; // 0x60
	private string minutesText; // 0x68
	private string secondText; // 0x70
	[SerializeField]
	private UILabel bossLabel; // 0x78
	private bool bossLabelAplhaFlag; // 0x80
	private bool bossLabelVisibleChangeFlag; // 0x81
	private float bossLabelVisibleTime; // 0x84
	[SerializeField]
	private GameObject reportPanel; // 0x88
	[SerializeField]
	private UILabel reportTitleLabel; // 0x90
	private string reportTitleText; // 0x98
	[SerializeField]
	private UILabel reportContentLabel; // 0xA0
	private string reportContentText; // 0xA8
	private string reportColorText; // 0xB0
	private bool reportActiveFlag; // 0xB8
	private bool reportVisibleChangeFlag; // 0xB9
	private float reportVisibleTime; // 0xBC
	private float reportTitleScale; // 0xC0
	private float reportContentScale; // 0xC4
	private UIIruna2Anchor crystalHpAnchor; // 0xC8
	private int popWindowFlag; // 0xD0
	private SystemTextManager systemTextManager; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private DefenceRoomData defenceRoomData; // 0xE8
	private bool battleVisibleFlag; // 0xF0
	private bool reConnectFlag; // 0xF1

	// Methods

	// RVA: 0x17D2654 Offset: 0x17CE654 VA: 0x17D2654
	public void SetBossAppear() { }

	// RVA: 0x17D2680 Offset: 0x17CE680 VA: 0x17D2680
	public void SetReportProp(string reportText, bool colorFlg) { }

	// RVA: 0x17D27CC Offset: 0x17CE7CC VA: 0x17D27CC
	private void Start() { }

	// RVA: 0x17D2978 Offset: 0x17CE978 VA: 0x17D2978
	public void Initialize() { }

	// RVA: 0x17D2AA0 Offset: 0x17CEAA0 VA: 0x17D2AA0
	private void BattleUiInit() { }

	// RVA: 0x17D2E6C Offset: 0x17CEE6C VA: 0x17D2E6C
	private void Update() { }

	// RVA: 0x17D3728 Offset: 0x17CF728 VA: 0x17D3728
	private void CreatePopWindow() { }

	// RVA: 0x17D3874 Offset: 0x17CF874 VA: 0x17D3874
	private void onPopClose() { }

	// RVA: 0x17D2D44 Offset: 0x17CED44 VA: 0x17D2D44
	private void UpdateCrystalHpAnchor() { }

	// RVA: 0x17D39A0 Offset: 0x17CF9A0 VA: 0x17D39A0
	public void .ctor() { }
}
