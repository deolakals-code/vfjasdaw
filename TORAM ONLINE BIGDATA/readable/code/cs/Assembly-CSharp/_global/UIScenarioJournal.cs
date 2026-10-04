// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScenarioJournal : MonoBehaviour // TypeDefIndex: 6561
{
	// Fields
	[SerializeField]
	private GameObject scenarioJournalObject; // 0x20
	private IUILabel scenarioJournalLabel; // 0x28
	private TweenPosition scenarioJournalTPos; // 0x30
	private TweenAlpha scenarioJournalTAlpha; // 0x38
	private bool scenarioJournalPop; // 0x40
	private QuestManager questManager; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private ItemTextManager itemTextManager; // 0x58
	private SystemTextManager systemTextManager; // 0x60

	// Methods

	// RVA: 0x19820DC Offset: 0x197E0DC VA: 0x19820DC
	private void Start() { }

	// RVA: 0x1982328 Offset: 0x197E328 VA: 0x1982328
	private void Update() { }

	// RVA: 0x19825F4 Offset: 0x197E5F4 VA: 0x19825F4
	private bool ScenarioMobClearCheck() { }

	// RVA: 0x1982AC8 Offset: 0x197EAC8 VA: 0x1982AC8
	private bool ScenarioItemClearCheck() { }

	// RVA: 0x1982E38 Offset: 0x197EE38 VA: 0x1982E38
	private bool ScenarioClearPop(bool misstion, int id, string targetName, int current, int subdueNum) { }

	// RVA: 0x1982568 Offset: 0x197E568 VA: 0x1982568
	private void ScenarioClearPopEffect() { }

	// RVA: 0x198345C Offset: 0x197F45C VA: 0x198345C
	public void .ctor() { }
}
