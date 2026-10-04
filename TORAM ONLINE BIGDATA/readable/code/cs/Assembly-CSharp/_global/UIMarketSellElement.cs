// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketSellElement : MonoBehaviour // TypeDefIndex: 8453
{
	// Fields
	[SerializeField]
	private GameObject filledParent; // 0x20
	[SerializeField]
	private UIIcon elementIcon; // 0x28
	[SerializeField]
	private ItemIcon elementItemLabel; // 0x30
	[SerializeField]
	private UILabel salesLabel; // 0x38
	[SerializeField]
	private UILabel dateLabel; // 0x40
	[SerializeField]
	private UILabel stateLabel; // 0x48
	[SerializeField]
	private GameObject soldoutIcon; // 0x50
	[SerializeField]
	private UISprite[] cristaIcon; // 0x58
	[SerializeField]
	private UILabel[] cristaLabel; // 0x60
	[SerializeField]
	private UILabel costLabel; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private ItemTextManager itemTextManager; // 0x78
	private EnemyTextManager enemyTextManager; // 0x80
	private SkillTextManager skillTextManager; // 0x88
	private Action<int, long> cancelCallback; // 0x90
	private Action<int, long, int> collectCallback; // 0x98
	private Action<int> registerCallback; // 0xA0
	private Action<int, long> finishCallback; // 0xA8
	private ItemData itemData; // 0xB0
	private string date; // 0xB8
	private byte saleAreaType; // 0xC0
	private byte state; // 0xC1
	private int salesPrice; // 0xC4
	private int revenuePrice; // 0xC8
	private int fee; // 0xCC
	private int slotId; // 0xD0
	private long uniqueId; // 0xD8
	private StarGemData starGemData; // 0xE0

	// Methods

	// RVA: 0x1D6A118 Offset: 0x1D66118 VA: 0x1D6A118
	private void Awake() { }

	// RVA: 0x1D68B50 Offset: 0x1D64B50 VA: 0x1D68B50
	public void Initialize(UIMarketProductData product, int slot, byte marketType, Action<int, long> cancelCallback, Action<int, long, int> collectCallback, Action<int> registerCallback, Action<int, long> finishedCallback) { }

	// RVA: 0x1D68238 Offset: 0x1D64238 VA: 0x1D68238
	public void InitializeStarGem(UIMarketProductData product, int slot, byte marketType, Action<int, long> cancelCallback, Action<int, long, int> collectCallback, Action<int> registerCallback, Action<int, long> finishedCallback) { }

	// RVA: 0x1D6A410 Offset: 0x1D66410 VA: 0x1D6A410
	private void onClick() { }

	// RVA: 0x1D6A598 Offset: 0x1D66598 VA: 0x1D6A598
	public void .ctor() { }
}
