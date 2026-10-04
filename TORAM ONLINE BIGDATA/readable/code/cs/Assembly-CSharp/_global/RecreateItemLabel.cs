// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecreateItemLabel : MonoBehaviour // TypeDefIndex: 8630
{
	// Fields
	[SerializeField]
	private UILabel spinaLabel; // 0x20
	[SerializeField]
	private GameObject originalIcon; // 0x28
	[CompilerGenerated]
	private int <Spina>k__BackingField; // 0x30
	private Dictionary<RecreateType, RecipeDBData> addedRecipes; // 0x38
	private Dictionary<int, GameObject> addedIconObjects; // 0x40
	private Dictionary<int, List<Pair<int, int>>> addedItemList; // 0x48
	private PlayerDataManager playerDataManager; // 0x50

	// Properties
	public int Spina { get; set; }
	public int Space { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DC38A4 Offset: 0x1DBF8A4 VA: 0x1DC38A4
	public int get_Spina() { }

	[CompilerGenerated]
	// RVA: 0x1DC38AC Offset: 0x1DBF8AC VA: 0x1DC38AC
	private void set_Spina(int value) { }

	// RVA: 0x1DC38B4 Offset: 0x1DBF8B4 VA: 0x1DC38B4
	public int get_Space() { }

	// RVA: 0x1DC38BC Offset: 0x1DBF8BC VA: 0x1DC38BC
	private void Start() { }

	// RVA: 0x1DC38E0 Offset: 0x1DBF8E0 VA: 0x1DC38E0
	public void RemoveRequire(RecreateType type) { }

	// RVA: 0x1DC3E5C Offset: 0x1DBFE5C VA: 0x1DC3E5C
	public void SetRequire(RecreateType type, RecipeDBData recipe) { }

	// RVA: 0x1DC3950 Offset: 0x1DBF950 VA: 0x1DC3950
	private void updateObjects() { }

	// RVA: 0x1DC45F8 Offset: 0x1DC05F8 VA: 0x1DC45F8
	private void checkCreateIcon() { }

	// RVA: 0x1DC3EDC Offset: 0x1DBFEDC VA: 0x1DC3EDC
	private void checkDestroyIcon() { }

	// RVA: 0x1DC4D44 Offset: 0x1DC0D44 VA: 0x1DC4D44
	private void alignmentIcons() { }

	// RVA: 0x1DC3970 Offset: 0x1DBF970 VA: 0x1DC3970
	private void updateRequires() { }

	// RVA: 0x1DC3AE0 Offset: 0x1DBFAE0 VA: 0x1DC3AE0
	private void updateLabels() { }

	// RVA: 0x1DC4F8C Offset: 0x1DC0F8C VA: 0x1DC4F8C
	public bool IsOverSpina() { }

	// RVA: 0x1DC4FD4 Offset: 0x1DC0FD4 VA: 0x1DC4FD4
	public bool IsOverModelId(int modelId) { }

	// RVA: 0x1DC5408 Offset: 0x1DC1408 VA: 0x1DC5408
	public void .ctor() { }
}
