// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestBoradButton : MonoBehaviour // TypeDefIndex: 7881
{
	// Fields
	private UIQuestBoradManager manager; // 0x20
	[SerializeField]
	private UILabel typeQLabel; // 0x28
	[SerializeField]
	private GameObject stateQLabel; // 0x30
	[SerializeField]
	private UILabel nameQLabel; // 0x38
	[SerializeField]
	private UILabel mesQLabel; // 0x40
	[SerializeField]
	private GameObject readQButton; // 0x48
	[SerializeField]
	private GameObject skipButton; // 0x50
	private bool scenarioType; // 0x58
	private int id; // 0x5C
	private PlayerDataManager pData; // 0x60

	// Properties
	private PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: 0x1C4E988 Offset: 0x1C4A988 VA: 0x1C4E988
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1C4EA0C Offset: 0x1C4AA0C VA: 0x1C4EA0C
	public void NonData(string type, string mes) { }

	// RVA: 0x1C4EC30 Offset: 0x1C4AC30 VA: 0x1C4EC30
	public void CreateQuestList(bool scenarioType, string title, string name, string type, bool clear, int id, UIQuestBoradManager manager) { }

	// RVA: 0x1C4EEC0 Offset: 0x1C4AEC0 VA: 0x1C4EEC0
	private void BoradSelect() { }

	// RVA: 0x1C523FC Offset: 0x1C4E3FC VA: 0x1C523FC
	public void OnSkip() { }

	// RVA: 0x1C522E0 Offset: 0x1C4E2E0 VA: 0x1C522E0
	public void UpdateSkipButton() { }

	// RVA: 0x1C52C50 Offset: 0x1C4EC50 VA: 0x1C52C50
	public void .ctor() { }
}
