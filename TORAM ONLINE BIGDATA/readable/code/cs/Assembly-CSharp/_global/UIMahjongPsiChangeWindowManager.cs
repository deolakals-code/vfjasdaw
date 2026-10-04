// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongPsiChangeWindowManager : MonoBehaviour // TypeDefIndex: 5921
{
	// Fields
	[SerializeField]
	private UIButtonCallAction buttonTemplate; // 0x20
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x28
	[SerializeField]
	private BoxCollider dragCameraBoxCollider; // 0x30
	[SerializeField]
	private GameObject psiDiscriptionWindow; // 0x38
	[SerializeField]
	private UILabel psiNameLabel; // 0x40
	[SerializeField]
	private UILabel psiDiscriptionLabel; // 0x48
	private MahjongRoomData roomData; // 0x50
	private Vector2 buttonSpacing; // 0x58
	private Dictionary<MahjongPsiType, GameObject> psiButtonBases; // 0x60
	private Dictionary<MahjongPsiType, UILabel> psiButtonLabels; // 0x68
	private MahjongPsiType selectedPsiType; // 0x70
	private Coroutine discriptionWindowCor; // 0x78

	// Methods

	// RVA: 0x18438B4 Offset: 0x183F8B4 VA: 0x18438B4
	public void Initialize(MahjongRoomData roomData, MahjongPsiType psiType) { }

	// RVA: 0x18441F8 Offset: 0x18401F8 VA: 0x18441F8
	public void OnClickSelectPsi(int id) { }

	// RVA: 0x18448EC Offset: 0x18408EC VA: 0x18448EC
	public void OnClickChangePsi() { }

	[IteratorStateMachine(typeof(UIMahjongPsiChangeWindowManager.<ChangeDiscriptionWindowScale>d__15))]
	// RVA: 0x1844880 Offset: 0x1840880 VA: 0x1844880
	private IEnumerator ChangeDiscriptionWindowScale() { }

	// RVA: 0x1844A40 Offset: 0x1840A40 VA: 0x1844A40
	public void .ctor() { }
}
