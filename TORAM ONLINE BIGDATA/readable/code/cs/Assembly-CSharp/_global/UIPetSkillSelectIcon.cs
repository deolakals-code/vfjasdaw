// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSkillSelectIcon : MonoBehaviour // TypeDefIndex: 7835
{
	// Fields
	[SerializeField]
	private UILabel skillCanGetLabel; // 0x20
	[SerializeField]
	private UILabel skillNumLabel; // 0x28
	private UIIcon icon; // 0x30
	[SerializeField]
	private UISprite imageButton; // 0x38
	[CompilerGenerated]
	private SkillId <SkillId>k__BackingField; // 0x40
	private int skillParentLevel; // 0x44
	private string buttonSpriteName; // 0x48
	private bool selected; // 0x50

	// Properties
	public SkillId SkillId { get; set; }
	public bool Selected { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C34118 Offset: 0x1C30118 VA: 0x1C34118
	private void set_SkillId(SkillId value) { }

	[CompilerGenerated]
	// RVA: 0x1C34120 Offset: 0x1C30120 VA: 0x1C34120
	public SkillId get_SkillId() { }

	// RVA: 0x1C34128 Offset: 0x1C30128 VA: 0x1C34128
	public void set_Selected(bool value) { }

	// RVA: 0x1C3419C Offset: 0x1C3019C VA: 0x1C3419C
	public void Initialize(SkillId id, int skillNo, bool first, bool have, bool select, bool inherit) { }

	// RVA: 0x1C34500 Offset: 0x1C30500 VA: 0x1C34500
	public void .ctor() { }
}
