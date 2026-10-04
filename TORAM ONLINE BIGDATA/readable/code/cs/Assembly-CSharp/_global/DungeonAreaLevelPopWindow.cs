// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonAreaLevelPopWindow : PopBaseWindow // TypeDefIndex: 8766
{
	// Fields
	private UILabel titleLabel; // 0x20
	private GameObject titleIcon; // 0x28
	private UILabel guildAreaLevelLabel; // 0x30
	private int selectGuildAreaLevel; // 0x38
	private int guildAreaLevel; // 0x3C
	private int userLastAreaLevel; // 0x40
	private Action<int> retAction; // 0x48
	private GameObject arrowButton; // 0x50
	private int messageAction; // 0x58

	// Methods

	// RVA: 0x1E04710 Offset: 0x1E00710 VA: 0x1E04710
	public void .ctor(int guildAreaLevel, int userLastAreaLevel, GameObject arrow, Action<int> retAction) { }

	// RVA: 0x1E0476C Offset: 0x1E0076C VA: 0x1E0476C Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E05054 Offset: 0x1E01054 VA: 0x1E05054 Slot: 5
	public override void Update() { }

	// RVA: 0x1E050A8 Offset: 0x1E010A8 VA: 0x1E050A8 Slot: 6
	public override void MessageAction(int action) { }

	// RVA: 0x1E05370 Offset: 0x1E01370 VA: 0x1E05370 Slot: 7
	public override int MessageCheck() { }
}
