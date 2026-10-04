// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightSaveDataButton : MonoBehaviour // TypeDefIndex: 5857
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x20
	[SerializeField]
	private GameObject saveDataObj; // 0x28
	[SerializeField]
	private UILabel playTimeLabel; // 0x30
	[SerializeField]
	private UILabel spinaLabel; // 0x38
	[SerializeField]
	private UILabel bestScoreLabel; // 0x40
	[SerializeField]
	private GameObject[] cristaObjs; // 0x48
	[SerializeField]
	private GameObject allClearIcon; // 0x50
	[SerializeField]
	private GameObject newGameLabel; // 0x58
	[SerializeField]
	private UILabel versionLabel; // 0x60
	private BlackKnightSaveData selectedData; // 0x68
	private SystemTextManager systemTextMangager; // 0x70

	// Methods

	// RVA: 0x180BBBC Offset: 0x1807BBC VA: 0x180BBBC
	public void InitializeData(BlackKnightSaveData data) { }

	// RVA: 0x180C36C Offset: 0x180836C VA: 0x180C36C
	public void InitializeNoData(int id) { }

	// RVA: 0x180C510 Offset: 0x1808510 VA: 0x180C510
	private int GetCristaPercent(BlackKnightCristaType type) { }

	// RVA: 0x180C968 Offset: 0x1808968 VA: 0x180C968
	public void .ctor() { }
}
