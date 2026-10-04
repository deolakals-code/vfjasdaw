// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISkillSelectIcon : MonoBehaviour // TypeDefIndex: 6877
{
	// Fields
	[SerializeField]
	private UILabel skillLevelLabel; // 0x20
	private UIIcon icon; // 0x28
	[SerializeField]
	private UISprite imageButton; // 0x30
	[CompilerGenerated]
	private SkillId <SkillId>k__BackingField; // 0x38
	private int skillParentLevel; // 0x3C
	private string buttonSpriteName; // 0x40
	private bool selected; // 0x48

	// Properties
	public SkillId SkillId { get; set; }
	public bool Selected { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A30870 Offset: 0x1A2C870 VA: 0x1A30870
	private void set_SkillId(SkillId value) { }

	[CompilerGenerated]
	// RVA: 0x1A30878 Offset: 0x1A2C878 VA: 0x1A30878
	public SkillId get_SkillId() { }

	// RVA: 0x1A30880 Offset: 0x1A2C880 VA: 0x1A30880
	public void set_Selected(bool value) { }

	// RVA: 0x1A308F4 Offset: 0x1A2C8F4 VA: 0x1A308F4
	public void Initialize(SkillId id, int level, int parentLevel) { }

	// RVA: 0x1A30B6C Offset: 0x1A2CB6C VA: 0x1A30B6C
	public void .ctor() { }
}
