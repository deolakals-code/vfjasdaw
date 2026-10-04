// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetSkillPopUpWindow : PopBaseWindow // TypeDefIndex: 8774
{
	// Fields
	private int selectSkillId; // 0x20
	private int skillLevel; // 0x24
	private bool firstSkillFlag; // 0x28
	private bool canFlag; // 0x29
	private bool isInherit; // 0x2A
	private int messageAction; // 0x2C
	private GameObject skillIcon; // 0x30
	private UILabel titleLabel; // 0x38

	// Methods

	// RVA: 0x1E07DA0 Offset: 0x1E03DA0 VA: 0x1E07DA0
	public void .ctor(int skillid, int level, bool first, bool can, bool isInherit, GameObject icon) { }

	// RVA: 0x1E07E1C Offset: 0x1E03E1C VA: 0x1E07E1C Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E08A9C Offset: 0x1E04A9C VA: 0x1E08A9C
	private void SkillText(SkillMasterData skillMasterData, int mpCost, GameObject obj) { }

	// RVA: 0x1E08E5C Offset: 0x1E04E5C VA: 0x1E08E5C Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E08E70 Offset: 0x1E04E70 VA: 0x1E08E70 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E08E78 Offset: 0x1E04E78 VA: 0x1E08E78 Slot: 5
	public override void Update() { }
}
