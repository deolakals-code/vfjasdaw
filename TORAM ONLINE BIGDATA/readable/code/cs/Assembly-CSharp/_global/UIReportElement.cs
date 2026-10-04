// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIReportElement : MonoBehaviour // TypeDefIndex: 7650
{
	// Fields
	private readonly Color defaultColor; // 0x20
	private readonly Color emptyColor; // 0x30
	protected Dictionary<UIReportPanel.ReportElementType, string> elementLocalizeKey; // 0x40
	protected Dictionary<UIReportPanel.ReportElementType, string> elementTitleString; // 0x48
	private readonly Dictionary<WorldType, string> worldLocalizeKey; // 0x50
	[SerializeField]
	private UILabel textLabel; // 0x58
	[SerializeField]
	protected UILabel[] inputLabel; // 0x60
	[SerializeField]
	protected UISprite inputBase; // 0x68
	[CompilerGenerated]
	private UIReportPanel.ReportElementType <ElementType>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <IsOptional>k__BackingField; // 0x74
	[CompilerGenerated]
	private float <ElementHeight>k__BackingField; // 0x78
	[CompilerGenerated]
	private float <TrueHeightUpside>k__BackingField; // 0x7C
	private float diff_height; // 0x80
	private SystemTextManager systemTextManager; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private int fromMailUuid; // 0x98
	private string fromMailAvatarName; // 0xA0
	private string inputDefaultKey; // 0xA8

	// Properties
	public UIReportPanel.ReportElementType ElementType { get; set; }
	public bool IsOptional { get; set; }
	public float ElementHeight { get; set; }
	public float TrueHeightUpside { get; set; }
	public float SameFrameDiff { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BD498C Offset: 0x1BD098C VA: 0x1BD498C
	public UIReportPanel.ReportElementType get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x1BD4994 Offset: 0x1BD0994 VA: 0x1BD4994
	private void set_ElementType(UIReportPanel.ReportElementType value) { }

	[CompilerGenerated]
	// RVA: 0x1BD499C Offset: 0x1BD099C VA: 0x1BD499C
	public bool get_IsOptional() { }

	[CompilerGenerated]
	// RVA: 0x1BD49A4 Offset: 0x1BD09A4 VA: 0x1BD49A4
	private void set_IsOptional(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1BD49B0 Offset: 0x1BD09B0 VA: 0x1BD49B0
	public float get_ElementHeight() { }

	[CompilerGenerated]
	// RVA: 0x1BD49B8 Offset: 0x1BD09B8 VA: 0x1BD49B8
	private void set_ElementHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x1BD49C0 Offset: 0x1BD09C0 VA: 0x1BD49C0
	public float get_TrueHeightUpside() { }

	[CompilerGenerated]
	// RVA: 0x1BD49C8 Offset: 0x1BD09C8 VA: 0x1BD49C8
	private void set_TrueHeightUpside(float value) { }

	// RVA: 0x1BD49D0 Offset: 0x1BD09D0 VA: 0x1BD49D0
	public float get_SameFrameDiff() { }

	// RVA: 0x1BD49D8 Offset: 0x1BD09D8 VA: 0x1BD49D8
	public void set_SameFrameDiff(float value) { }

	// RVA: 0x1BD49E0 Offset: 0x1BD09E0 VA: 0x1BD49E0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1BD4AF8 Offset: 0x1BD0AF8 VA: 0x1BD4AF8
	private void Update() { }

	// RVA: 0x1BD4AFC Offset: 0x1BD0AFC VA: 0x1BD4AFC
	public void InitializeText(string _localize_key) { }

	// RVA: 0x1BD4D14 Offset: 0x1BD0D14 VA: 0x1BD4D14
	public void UpdateText(string text) { }

	// RVA: 0x1BD4D30 Offset: 0x1BD0D30 VA: 0x1BD4D30
	public void Initialize(UIReportPanel.ReportElementType type, bool isOptional) { }

	// RVA: 0x1BD50BC Offset: 0x1BD10BC VA: 0x1BD50BC
	public void SetFromMailData(int uuid, string name) { }

	// RVA: 0x1BD50CC Offset: 0x1BD10CC VA: 0x1BD50CC
	public void SetInputDefaultKey(string key) { }

	// RVA: 0x1BD50E8 Offset: 0x1BD10E8 VA: 0x1BD50E8
	private void UpdateDefaultText() { }

	// RVA: 0x1BD4E1C Offset: 0x1BD0E1C VA: 0x1BD4E1C
	private void initializeDefault() { }

	// RVA: 0x1BD51B8 Offset: 0x1BD11B8 VA: 0x1BD51B8 Slot: 5
	protected virtual bool auto_input_value() { }

	// RVA: 0x1BD4B58 Offset: 0x1BD0B58 VA: 0x1BD4B58
	public void initializeHeight() { }

	// RVA: 0x1BD5C3C Offset: 0x1BD1C3C VA: 0x1BD5C3C
	private float update_topside_height(float _base_y, float _center_y, float _widget_height_diff) { }

	// RVA: 0x1BD5C4C Offset: 0x1BD1C4C VA: 0x1BD5C4C
	private float update_bottomside_height(float _base_y, float _center_y, float _widget_height_diff) { }

	// RVA: 0x1BD4F2C Offset: 0x1BD0F2C VA: 0x1BD4F2C
	private void init_inputlimit_setting() { }

	// RVA: 0x1BD5C5C Offset: 0x1BD1C5C VA: 0x1BD5C5C Slot: 6
	protected virtual int get_inputlimit_info_by_element_type() { }

	// RVA: 0x1BD5C80 Offset: 0x1BD1C80 VA: 0x1BD5C80
	public string GetTitle() { }

	// RVA: 0x1BD5CD4 Offset: 0x1BD1CD4 VA: 0x1BD5CD4 Slot: 7
	public virtual string GetText() { }

	// RVA: 0x1BD5F28 Offset: 0x1BD1F28 VA: 0x1BD5F28
	public bool CheckEmpty() { }

	// RVA: 0x1BD6064 Offset: 0x1BD2064 VA: 0x1BD6064
	private void onName() { }

	// RVA: 0x1BD3FF0 Offset: 0x1BCFFF0 VA: 0x1BD3FF0
	public void .ctor() { }
}
