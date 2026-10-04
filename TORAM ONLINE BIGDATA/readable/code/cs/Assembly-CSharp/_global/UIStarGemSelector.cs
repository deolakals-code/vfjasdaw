// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemSelector : MonoBehaviour // TypeDefIndex: 8212
{
	// Fields
	[SerializeField]
	private UIScrollWindow starGemList; // 0x20
	[SerializeField]
	private UICamera scrollCamera; // 0x28
	[SerializeField]
	private GameObject infoButton; // 0x30
	[SerializeField]
	private UIStarGemListButton stargemListButton; // 0x38
	[SerializeField]
	private UILabel titleLabel; // 0x40
	[CompilerGenerated]
	private StarGemData <SelectedData>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsSkillPopWindow>k__BackingField; // 0x50
	private List<StarGemData> stargemDataList; // 0x58
	private List<UIStarGemListButton> stargemButtonList; // 0x60
	private PlayerDataManager playerDataMangager; // 0x68
	private StarGemManager stargemManager; // 0x70
	private int selectedId; // 0x78
	private UIPopBaseWindow popWindow; // 0x80
	private GameObject skillIconObj; // 0x88
	private SystemTextManager systemTextManager; // 0x90
	private SkillTextManager skillTextManager; // 0x98
	private Action<StarGemData> callback; // 0xA0
	private Action selectedCallBack; // 0xA8
	private string titleLabelFormatKey; // 0xB0
	private string infoButtonLabelKey; // 0xB8
	private const float buttonHeight = 100;

	// Properties
	public StarGemData SelectedData { get; set; }
	public bool IsSkillPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CF671C Offset: 0x1CF271C VA: 0x1CF671C
	public StarGemData get_SelectedData() { }

	[CompilerGenerated]
	// RVA: 0x1CF6724 Offset: 0x1CF2724 VA: 0x1CF6724
	private void set_SelectedData(StarGemData value) { }

	[CompilerGenerated]
	// RVA: 0x1CF672C Offset: 0x1CF272C VA: 0x1CF672C
	public bool get_IsSkillPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x1CF6734 Offset: 0x1CF2734 VA: 0x1CF6734
	private void set_IsSkillPopWindow(bool value) { }

	// RVA: 0x1CF6740 Offset: 0x1CF2740 VA: 0x1CF6740
	public static UIStarGemSelector CreateSelector(Transform parent) { }

	// RVA: 0x1CF68A4 Offset: 0x1CF28A4 VA: 0x1CF68A4
	private void Update() { }

	// RVA: 0x1CF6AAC Offset: 0x1CF2AAC VA: 0x1CF6AAC
	public void Initialize(Action selectedCallBack) { }

	// RVA: 0x1CF6DF8 Offset: 0x1CF2DF8 VA: 0x1CF6DF8
	public void SetScrollEnable(bool isEnable) { }

	// RVA: 0x1CF7388 Offset: 0x1CF3388 VA: 0x1CF7388
	public void CloseSkillPopWindow() { }

	// RVA: 0x1CF7398 Offset: 0x1CF3398 VA: 0x1CF7398
	public void ResetSelectData() { }

	// RVA: 0x1CF75C8 Offset: 0x1CF35C8 VA: 0x1CF75C8
	public void SetStarGemCallBack(Action<StarGemData> callback) { }

	// RVA: 0x1CF75D0 Offset: 0x1CF35D0 VA: 0x1CF75D0
	public void StarGemCallBack() { }

	// RVA: 0x1CF75F0 Offset: 0x1CF35F0 VA: 0x1CF75F0
	public void SetTitleLocalizeKey(string localizeKey) { }

	// RVA: 0x1CF760C Offset: 0x1CF360C VA: 0x1CF760C
	public void SetInfoButtonLocalizeKey(string localizeKey) { }

	// RVA: 0x1CF7614 Offset: 0x1CF3614 VA: 0x1CF7614
	public void UpdateSelectData(short[] noList) { }

	// RVA: 0x1CF7798 Offset: 0x1CF3798 VA: 0x1CF7798
	public void AllNonSelectButton() { }

	// RVA: 0x1CF6EA4 Offset: 0x1CF2EA4 VA: 0x1CF6EA4
	private void CreateButtonList() { }

	// RVA: 0x1CF78E8 Offset: 0x1CF38E8 VA: 0x1CF78E8
	private GameObject AddButton(StarGemData data, Vector3 pos, GameObject target, string funcMes) { }

	// RVA: 0x1CF72DC Offset: 0x1CF32DC VA: 0x1CF72DC
	private void UpdateTitleLabel() { }

	// RVA: 0x1CF68A8 Offset: 0x1CF28A8 VA: 0x1CF68A8
	private void UpdateScrollElementActive() { }

	// RVA: 0x1CF7BCC Offset: 0x1CF3BCC VA: 0x1CF7BCC
	private void OnClickListButton(int param) { }

	// RVA: 0x1CF7EE0 Offset: 0x1CF3EE0 VA: 0x1CF7EE0
	private void OnSkillInfo() { }

	[IteratorStateMachine(typeof(UIStarGemSelector.<skillInfoPopWindow>d__45))]
	// RVA: 0x1CF7F00 Offset: 0x1CF3F00 VA: 0x1CF7F00
	private IEnumerator skillInfoPopWindow() { }

	// RVA: 0x1CF7F94 Offset: 0x1CF3F94 VA: 0x1CF7F94
	public void .ctor() { }
}
