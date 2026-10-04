// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITrophyButton : MonoBehaviour // TypeDefIndex: 6891
{
	// Fields
	[SerializeField]
	private UILabel titleText; // 0x20
	[SerializeField]
	private UILabel messageText; // 0x28
	[SerializeField]
	private UILabel compleText; // 0x30
	[SerializeField]
	private UISprite torphyCompleIcon; // 0x38
	[SerializeField]
	private Transform compleButton; // 0x40
	[SerializeField]
	private UILabel progressLabel; // 0x48
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x50
	private UITrophyManager manager; // 0x58
	private TrophyProgressData progressData; // 0x60
	private TrophyManager.ProgressType progressType; // 0x68
	private GameRecordManager gameRecordManager; // 0x70
	private bool isTimer; // 0x78

	// Properties
	public int TrophyId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A3B2AC Offset: 0x1A372AC VA: 0x1A3B2AC
	private void set_TrophyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1A3B2B4 Offset: 0x1A372B4 VA: 0x1A3B2B4
	public int get_TrophyId() { }

	// RVA: 0x1A3B2BC Offset: 0x1A372BC VA: 0x1A3B2BC
	public void Initialize(int trophyId, TrophyFlagType flag, UITrophyManager manager) { }

	// RVA: 0x1A3BD48 Offset: 0x1A37D48 VA: 0x1A3BD48
	public void OnTrophyCheckReward() { }

	// RVA: 0x1A3BEFC Offset: 0x1A37EFC VA: 0x1A3BEFC
	private void Update() { }

	// RVA: 0x1A3B8E8 Offset: 0x1A378E8 VA: 0x1A3B8E8
	private void UpdateProgressText() { }

	// RVA: 0x1A3BFA0 Offset: 0x1A37FA0 VA: 0x1A3BFA0
	public void .ctor() { }
}
