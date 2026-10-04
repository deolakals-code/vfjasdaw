// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIReportTypeElement : MonoBehaviour // TypeDefIndex: 7664
{
	// Fields
	[SerializeField]
	private UILabel descriptionLabel; // 0x20
	[SerializeField]
	private UILabel buttonLabel; // 0x28
	[SerializeField]
	private UISprite sprite; // 0x30
	[SerializeField]
	private UISprite systemSprite; // 0x38
	[CompilerGenerated]
	private UIReportPanel.ReportType <ReportType>k__BackingField; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private Action<UIReportPanel.ReportType> callback; // 0x50

	// Properties
	public UIReportPanel.ReportType ReportType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BDCF08 Offset: 0x1BD8F08 VA: 0x1BDCF08
	public UIReportPanel.ReportType get_ReportType() { }

	[CompilerGenerated]
	// RVA: 0x1BDCF10 Offset: 0x1BD8F10 VA: 0x1BDCF10
	private void set_ReportType(UIReportPanel.ReportType value) { }

	// RVA: 0x1BDCF18 Offset: 0x1BD8F18 VA: 0x1BDCF18
	private void Awake() { }

	// RVA: 0x1BDD000 Offset: 0x1BD9000 VA: 0x1BDD000
	public void Initialize(UIReportPanel.ReportType type, string localizeKeyBase, string sprite_name, Action<UIReportPanel.ReportType> onClickAction) { }

	// RVA: 0x1BDD17C Offset: 0x1BD917C VA: 0x1BDD17C
	public void Initialize(UIReportPanel.ReportType type, string text, Action<UIReportPanel.ReportType> onClickAction) { }

	// RVA: 0x1BDD1C0 Offset: 0x1BD91C0 VA: 0x1BDD1C0
	public void OnClick() { }

	// RVA: 0x1BDD1E0 Offset: 0x1BD91E0 VA: 0x1BDD1E0
	public void .ctor() { }
}
