// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithProcessingCompleteDialog : MonoBehaviour // TypeDefIndex: 8534
{
	// Fields
	[SerializeField]
	private UILabel MessageLabel; // 0x20
	[SerializeField]
	private UILabel GetPointLabel; // 0x28
	[SerializeField]
	private ItemIcon ItemNameLabel; // 0x30
	[SerializeField]
	private LocalizeText ItemCountLabel; // 0x38
	[SerializeField]
	private GameObject lostItemOrigin; // 0x40
	[SerializeField]
	private GameObject scrollBar; // 0x48
	[SerializeField]
	private GameObject scrollFrame; // 0x50
	[CompilerGenerated]
	private Action CloseCallFunc; // 0x58
	private SystemTextManager systemTextManager; // 0x60
	private UIBasePanelControl topButtonControl; // 0x68
	private UIScrollWindow scroll; // 0x70

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D9E2C8 Offset: 0x1D9A2C8 VA: 0x1D9E2C8
	public void add_CloseCallFunc(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1D9E364 Offset: 0x1D9A364 VA: 0x1D9E364
	public void remove_CloseCallFunc(Action value) { }

	// RVA: 0x1D9E400 Offset: 0x1D9A400 VA: 0x1D9E400
	private void Awake() { }

	// RVA: 0x1D9E52C Offset: 0x1D9A52C VA: 0x1D9E52C
	private void Start() { }

	// RVA: 0x1D9E530 Offset: 0x1D9A530 VA: 0x1D9E530
	private void Update() { }

	// RVA: 0x1D9E534 Offset: 0x1D9A534 VA: 0x1D9E534
	public void InitData(int typeLv, string getType, int point, int count, ItemData[] items, UIBasePanelControl topControl) { }

	// RVA: 0x1D9ED3C Offset: 0x1D9AD3C VA: 0x1D9ED3C
	public void Close() { }

	// RVA: 0x1D9EF30 Offset: 0x1D9AF30 VA: 0x1D9EF30
	public void .ctor() { }
}
