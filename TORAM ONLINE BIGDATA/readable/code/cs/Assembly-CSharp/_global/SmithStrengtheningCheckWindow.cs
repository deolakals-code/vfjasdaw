// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithStrengtheningCheckWindow : MonoBehaviour // TypeDefIndex: 8560
{
	// Fields
	[SerializeField]
	private UILabel DengerLabel; // 0x20
	[SerializeField]
	private UILabel SuccessNameLabel; // 0x28
	[SerializeField]
	private UILabel FailureNameLabel; // 0x30
	[SerializeField]
	private GameObject[] DengerIcons; // 0x38
	[SerializeField]
	private UILabel successRankLabel; // 0x40
	[SerializeField]
	private UISprite[] successRankBars; // 0x48
	private const int MaxBarGuage = 400;
	private const int MaxSuccessRank = 100;
	private int ItemId; // 0x50
	private int DengerRank; // 0x54
	private bool isBreaker; // 0x58
	private bool isDownGuard100; // 0x59
	private int skipRefine; // 0x5C
	private SystemTextManager systemTextManager; // 0x60
	private ItemTextManager itemTextManager; // 0x68
	private PlayerDataManager playerDataManager; // 0x70

	// Methods

	// RVA: 0x1DAA774 Offset: 0x1DA6774 VA: 0x1DAA774
	private void Start() { }

	// RVA: 0x1DAA92C Offset: 0x1DA692C VA: 0x1DAA92C
	private void Update() { }

	// RVA: 0x1DAA930 Offset: 0x1DA6930 VA: 0x1DAA930
	public void SetItem(int uuid) { }

	// RVA: 0x1DAAC8C Offset: 0x1DA6C8C VA: 0x1DAAC8C
	public void SetBreaker(bool isBreaker) { }

	// RVA: 0x1DAAC98 Offset: 0x1DA6C98 VA: 0x1DAAC98
	public void SetDownGuard100(bool is100) { }

	// RVA: 0x1DAACA4 Offset: 0x1DA6CA4 VA: 0x1DAACA4
	public void SetSkipRefine(int refine) { }

	// RVA: 0x1DAACAC Offset: 0x1DA6CAC VA: 0x1DAACAC
	public void SetDenger(int rank) { }

	// RVA: 0x1DAAE2C Offset: 0x1DA6E2C VA: 0x1DAAE2C
	public void SetSuccess(int rank, int oreBonus) { }

	// RVA: 0x1DAB088 Offset: 0x1DA7088 VA: 0x1DAB088
	public void .ctor() { }
}
