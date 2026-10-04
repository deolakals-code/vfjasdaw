// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventScenarioMenuButton : MonoBehaviour // TypeDefIndex: 6521
{
	// Fields
	private UIEventScenarioMenuButton.ButtonType buttonType; // 0x20
	[SerializeField]
	private GameObject menuObject; // 0x28
	[SerializeField]
	private UILabel mainLabel; // 0x30
	[SerializeField]
	private UILabel subLabel; // 0x38
	private TweenScale subLabelShadowTweenScale; // 0x40
	[SerializeField]
	private UILabel subLabelShadow; // 0x48
	private TweenAlpha subLabelShadowTweenAlpha; // 0x50
	private int sendMessageId; // 0x58

	// Methods

	// RVA: 0x19670BC Offset: 0x19630BC VA: 0x19670BC
	public void AddQuestButton(int questId, int sendId, QuestManager.QuestOrderCondition state) { }

	// RVA: 0x1969140 Offset: 0x1965140 VA: 0x1969140
	private void SetMessage(string mainMes, string subMes, Color setColor, UIEventScenarioMenuButton.ButtonType type) { }

	// RVA: 0x1969388 Offset: 0x1965388 VA: 0x1969388
	public void OnClick() { }

	// RVA: 0x1969494 Offset: 0x1965494 VA: 0x1969494
	public void .ctor() { }
}
