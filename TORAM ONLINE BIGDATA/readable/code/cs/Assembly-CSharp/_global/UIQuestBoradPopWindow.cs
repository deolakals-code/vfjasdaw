// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestBoradPopWindow : MonoBehaviour // TypeDefIndex: 7892
{
	// Fields
	private UIScrollWindow scrollWindow; // 0x20
	[SerializeField]
	private GameObject questBoradButtonObject; // 0x28
	private UIQuestBoradButton questBoradButton; // 0x30
	[SerializeField]
	private GameObject listLabelObject; // 0x38
	private List<UIQuestBoradPopLabel> labelList; // 0x40
	[CompilerGenerated]
	private bool <IsEffectPlay>k__BackingField; // 0x48
	private float y; // 0x4C
	private int countId; // 0x50
	private float endWait; // 0x54

	// Properties
	public bool IsEffectPlay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C57328 Offset: 0x1C53328 VA: 0x1C57328
	private void set_IsEffectPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C57334 Offset: 0x1C53334 VA: 0x1C57334
	public bool get_IsEffectPlay() { }

	// RVA: 0x1C5733C Offset: 0x1C5333C VA: 0x1C5733C
	public void Initialize(bool scenarioType, int selectId, short changeKey, short changeItem, short changeMob) { }

	// RVA: 0x1C59994 Offset: 0x1C55994 VA: 0x1C59994
	private void AddList(string message, string param, bool effect) { }

	// RVA: 0x1C59750 Offset: 0x1C55750 VA: 0x1C59750
	private void AddList(string message, string param, bool effect, bool enterCheck) { }

	// RVA: 0x1C599A0 Offset: 0x1C559A0 VA: 0x1C599A0
	private void Update() { }

	// RVA: 0x1C59A80 Offset: 0x1C55A80 VA: 0x1C59A80
	private void OnDsetroy() { }

	// RVA: 0x1C59A88 Offset: 0x1C55A88 VA: 0x1C59A88
	public void .ctor() { }
}
