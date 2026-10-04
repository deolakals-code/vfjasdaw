// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecreateCompleteDialog : MonoBehaviour // TypeDefIndex: 8629
{
	// Fields
	[SerializeField]
	private ItemIcon ItemNameLabel; // 0x20
	[SerializeField]
	private LocalizeText ItemCountLabel; // 0x28
	[SerializeField]
	private GameObject lostItemOrigin; // 0x30
	[CompilerGenerated]
	private Action CloseCallFunc; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private UIBasePanelControl topButtonControl; // 0x48
	private UIScrollWindow scroll; // 0x50

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DC29B0 Offset: 0x1DBE9B0 VA: 0x1DC29B0
	public void add_CloseCallFunc(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1DC2A4C Offset: 0x1DBEA4C VA: 0x1DC2A4C
	public void remove_CloseCallFunc(Action value) { }

	// RVA: 0x1DC2AE8 Offset: 0x1DBEAE8 VA: 0x1DC2AE8
	private void Awake() { }

	// RVA: 0x1DC2AEC Offset: 0x1DBEAEC VA: 0x1DC2AEC
	private void Start() { }

	// RVA: 0x1DC2AF0 Offset: 0x1DBEAF0 VA: 0x1DC2AF0
	private void Update() { }

	// RVA: 0x1DC2AF4 Offset: 0x1DBEAF4 VA: 0x1DC2AF4
	public void InitData(Dictionary<int, Pair<int, bool>> items, int spina, int orb, UIBasePanelControl topControl) { }

	// RVA: 0x1DC36E0 Offset: 0x1DBF6E0 VA: 0x1DC36E0
	public void Close() { }

	// RVA: 0x1DC389C Offset: 0x1DBF89C VA: 0x1DC389C
	public void .ctor() { }
}
