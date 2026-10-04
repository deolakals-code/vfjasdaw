// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetShopBuyElement : MonoBehaviour // TypeDefIndex: 7720
{
	// Fields
	private readonly Color notMatchedIconColor; // 0x20
	private readonly Color matchedIconColor; // 0x30
	[SerializeField]
	private UISprite icon; // 0x40
	[SerializeField]
	private UILabel lvLabel; // 0x48
	[SerializeField]
	private UILabel nameLabel; // 0x50
	[SerializeField]
	private UILabel spinaLabel; // 0x58
	[SerializeField]
	private UILabel targetLabel; // 0x60
	[SerializeField]
	private GameObject MostUpFrames; // 0x68
	[SerializeField]
	private GameObject MostBottomFrames; // 0x70
	[SerializeField]
	private GameObject MiddleFrames; // 0x78
	[SerializeField]
	private GameObject SingleFrames; // 0x80
	[CompilerGenerated]
	private HousePetSaleItemData <SaleItemData>k__BackingField; // 0x88
	private Action<int> buyCallback; // 0x90
	private Action<int> detailCallback; // 0x98
	private ItemTextManager itemTextManager; // 0xA0
	private int no; // 0xA8
	private EnemyTextManager enemyTextManager; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8

	// Properties
	public HousePetSaleItemData SaleItemData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BF0734 Offset: 0x1BEC734 VA: 0x1BF0734
	public HousePetSaleItemData get_SaleItemData() { }

	[CompilerGenerated]
	// RVA: 0x1BF073C Offset: 0x1BEC73C VA: 0x1BF073C
	private void set_SaleItemData(HousePetSaleItemData value) { }

	// RVA: 0x1BF0744 Offset: 0x1BEC744 VA: 0x1BF0744
	private void Awake() { }

	// RVA: 0x1BF096C Offset: 0x1BEC96C VA: 0x1BF096C
	public void Initialize(HousePetSaleItemData data, int no, Action<int> buycallback) { }

	// RVA: 0x1BF0DF8 Offset: 0x1BECDF8 VA: 0x1BF0DF8
	public void OnClickBuy() { }

	// RVA: 0x1BF0E18 Offset: 0x1BECE18 VA: 0x1BF0E18
	private void onClickIcon() { }

	// RVA: 0x1BF0D18 Offset: 0x1BECD18 VA: 0x1BF0D18
	private string GetExhabitText(byte type) { }

	// RVA: 0x1BF0E1C Offset: 0x1BECE1C VA: 0x1BF0E1C
	public void SetMostTopFrame() { }

	// RVA: 0x1BF0F58 Offset: 0x1BECF58 VA: 0x1BF0F58
	public void SetMostBottomFrame() { }

	// RVA: 0x1BF1094 Offset: 0x1BED094 VA: 0x1BF1094
	public void SetMiddleFrame() { }

	// RVA: 0x1BF11D0 Offset: 0x1BED1D0 VA: 0x1BF11D0
	public void SetSingleFrame() { }

	// RVA: 0x1BF130C Offset: 0x1BED30C VA: 0x1BF130C
	public void .ctor() { }
}
