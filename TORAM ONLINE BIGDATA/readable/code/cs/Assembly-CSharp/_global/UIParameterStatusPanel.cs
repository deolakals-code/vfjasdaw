// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIParameterStatusPanel : MonoBehaviour // TypeDefIndex: 6861
{
	// Fields
	[SerializeField]
	private UISlider strSlider; // 0x20
	[SerializeField]
	private UILabel strPointLabel; // 0x28
	[SerializeField]
	private UISlider intSlider; // 0x30
	[SerializeField]
	private UILabel intPointLabel; // 0x38
	[SerializeField]
	private UISlider vitSlider; // 0x40
	[SerializeField]
	private UILabel vitPointLabel; // 0x48
	[SerializeField]
	private UISlider agiSlider; // 0x50
	[SerializeField]
	private UILabel agiPointLabel; // 0x58
	[SerializeField]
	private UISlider dexSlider; // 0x60
	[SerializeField]
	private UILabel dexPointLabel; // 0x68
	[SerializeField]
	private GameObject primaryObject; // 0x70
	[SerializeField]
	private UISlider primarySlider; // 0x78
	[SerializeField]
	private UILabel primaryLabel; // 0x80
	[SerializeField]
	private UILabel primaryPointLabel; // 0x88
	[SerializeField]
	private Transform skillIconParent; // 0x90
	private List<GameObject> skillIconLsit; // 0x98
	[SerializeField]
	private UILabel skillLevel; // 0xA0
	[SerializeField]
	private UIIcon skillIcon; // 0xA8
	private SystemTextManager systemManager; // 0xB0
	private PlayerDataManager playerManager; // 0xB8

	// Properties
	private SystemTextManager systemTextManager { get; }
	private PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: 0x1A1F420 Offset: 0x1A1B420 VA: 0x1A1F420
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1A1F50C Offset: 0x1A1B50C VA: 0x1A1F50C
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1A1C47C Offset: 0x1A1847C VA: 0x1A1C47C
	public void StatusSetting(ParameterStatus status) { }

	// RVA: 0x1A1F590 Offset: 0x1A1B590 VA: 0x1A1F590
	public void .ctor() { }
}
