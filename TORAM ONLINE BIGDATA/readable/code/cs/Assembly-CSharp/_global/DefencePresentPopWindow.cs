// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefencePresentPopWindow : PopBaseWindow // TypeDefIndex: 8761
{
	// Fields
	private PlayerDataManager playerData; // 0x20
	private UILabel titleLabel; // 0x28
	private GameObject[] okButton; // 0x30
	private GameObject ButtonObj; // 0x38
	private UILabel windowText; // 0x40
	private UILabel rankText; // 0x48
	private UILabel noteText; // 0x50
	private UILabel itemText; // 0x58
	private UILabel[] buttonText; // 0x60
	private Action<int> retAction; // 0x68
	private int CurrentRank; // 0x70
	private int OldRank; // 0x74
	private int LastRank; // 0x78
	private RewardData Reward; // 0x80
	private bool itemGetFlag; // 0x88
	private byte presentType; // 0x89
	private float labelScale; // 0x8C
	private bool labelColorFlag; // 0x90
	private int messageAction; // 0x94

	// Properties
	private PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: 0x1E02D24 Offset: 0x1DFED24 VA: 0x1E02D24
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1E02DA8 Offset: 0x1DFEDA8 VA: 0x1E02DA8
	public void .ctor(int currentrank, int oldrank, int lastRank, bool getFlag, RewardData reward, GameObject[] buttonObj) { }

	// RVA: 0x1E02EA8 Offset: 0x1DFEEA8 VA: 0x1E02EA8 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E03E3C Offset: 0x1DFFE3C VA: 0x1E03E3C Slot: 5
	public override void Update() { }

	// RVA: 0x1E03F64 Offset: 0x1DFFF64 VA: 0x1E03F64 Slot: 6
	public override void MessageAction(int action) { }

	// RVA: 0x1E03F68 Offset: 0x1DFFF68 VA: 0x1E03F68 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E03F70 Offset: 0x1DFFF70 VA: 0x1E03F70 Slot: 8
	public override void Close() { }

	// RVA: 0x1E03A34 Offset: 0x1DFFA34 VA: 0x1E03A34
	private string ChallengerRankText() { }

	// RVA: 0x1E03B78 Offset: 0x1DFFB78 VA: 0x1E03B78
	private string RewardText() { }
}
