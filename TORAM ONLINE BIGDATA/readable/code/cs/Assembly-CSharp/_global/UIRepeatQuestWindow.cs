// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRepeatQuestWindow : MonoBehaviour // TypeDefIndex: 6410
{
	// Fields
	[SerializeField]
	private UIToggle[] toggleButtons; // 0x20
	[SerializeField]
	private UILabel[] toggleButtonLabels; // 0x28
	[SerializeField]
	private GameObject[] selectButton; // 0x30
	private int selectNum; // 0x38
	private int selectMax; // 0x3C
	private string localizeText; // 0x40
	private int playScriptId; // 0x48
	[CompilerGenerated]
	private bool <IsClosed>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <IsDefaultFlag>k__BackingField; // 0x4D
	[CompilerGenerated]
	private byte <Count>k__BackingField; // 0x4E
	[CompilerGenerated]
	private bool <IsExpOver>k__BackingField; // 0x4F

	// Properties
	public bool IsClosed { get; set; }
	public bool IsDefaultFlag { get; set; }
	public byte Count { get; set; }
	public bool IsExpOver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x192967C Offset: 0x192567C VA: 0x192967C
	public bool get_IsClosed() { }

	[CompilerGenerated]
	// RVA: 0x1929684 Offset: 0x1925684 VA: 0x1929684
	private void set_IsClosed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1929690 Offset: 0x1925690 VA: 0x1929690
	public bool get_IsDefaultFlag() { }

	[CompilerGenerated]
	// RVA: 0x1929698 Offset: 0x1925698 VA: 0x1929698
	private void set_IsDefaultFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x19296A4 Offset: 0x19256A4 VA: 0x19296A4
	public byte get_Count() { }

	[CompilerGenerated]
	// RVA: 0x19296AC Offset: 0x19256AC VA: 0x19296AC
	private void set_Count(byte value) { }

	[CompilerGenerated]
	// RVA: 0x19296B4 Offset: 0x19256B4 VA: 0x19296B4
	public bool get_IsExpOver() { }

	[CompilerGenerated]
	// RVA: 0x19296BC Offset: 0x19256BC VA: 0x19296BC
	private void set_IsExpOver(bool value) { }

	// RVA: 0x19296C8 Offset: 0x19256C8 VA: 0x19296C8
	public void Initialize(int max, int playScriptId) { }

	// RVA: 0x1929E08 Offset: 0x1925E08 VA: 0x1929E08
	private void Update() { }

	// RVA: 0x192981C Offset: 0x192581C VA: 0x192981C
	public void OnClickUpdate() { }

	// RVA: 0x1929EC0 Offset: 0x1925EC0 VA: 0x1929EC0
	public void OnAddSelectNumData(int add) { }

	// RVA: 0x192A1BC Offset: 0x19261BC VA: 0x192A1BC
	public void OnClickEnter() { }

	// RVA: 0x192A278 Offset: 0x1926278 VA: 0x192A278
	public void .ctor() { }
}
