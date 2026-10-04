// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageMainPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7956
{
	// Fields
	[SerializeField]
	private GameObject[] selectButton; // 0x20
	[SerializeField]
	private UILabel[] limitLabel; // 0x28
	[SerializeField]
	private Vector3 startPosition; // 0x30
	[SerializeField]
	private GameObject helpButton; // 0x40
	private UISpecialStorageManager manager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private UIScrollWindow scrollWindow; // 0x58

	// Methods

	// RVA: 0x1C8481C Offset: 0x1C8081C VA: 0x1C8481C Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C84824 Offset: 0x1C80824 VA: 0x1C84824 Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C84950 Offset: 0x1C80950 VA: 0x1C84950 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C84DFC Offset: 0x1C80DFC VA: 0x1C84DFC Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C84CFC Offset: 0x1C80CFC VA: 0x1C84CFC
	private string GetLimitText(string baseText, string countLocalize, BankType type) { }

	// RVA: 0x1C84E54 Offset: 0x1C80E54 VA: 0x1C84E54
	public void OnClickMoney() { }

	// RVA: 0x1C84F64 Offset: 0x1C80F64 VA: 0x1C84F64
	public void OnClickMaterial() { }

	// RVA: 0x1C84F6C Offset: 0x1C80F6C VA: 0x1C84F6C
	public void OnClickExp() { }

	// RVA: 0x1C84F74 Offset: 0x1C80F74 VA: 0x1C84F74
	public void OnClickHelp() { }

	[IteratorStateMachine(typeof(UISpecialStorageMainPanel.<ClickHelpThread>d__16))]
	// RVA: 0x1C84F94 Offset: 0x1C80F94 VA: 0x1C84F94
	public IEnumerator ClickHelpThread() { }

	// RVA: 0x1C84E5C Offset: 0x1C80E5C VA: 0x1C84E5C
	private void ChangePanel(UISpecialStorageManager.PanelType type) { }

	// RVA: 0x1C85028 Offset: 0x1C81028 VA: 0x1C85028 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C85030 Offset: 0x1C81030 VA: 0x1C85030
	public void .ctor() { }
}
