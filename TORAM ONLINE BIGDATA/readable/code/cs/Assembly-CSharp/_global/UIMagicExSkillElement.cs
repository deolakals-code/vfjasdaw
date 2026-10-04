// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMagicExSkillElement : MonoBehaviour // TypeDefIndex: 6734
{
	// Fields
	[SerializeField]
	private ItemIcon nameLabel; // 0x20
	[SerializeField]
	private UISprite[] buttonIcons; // 0x28
	[SerializeField]
	private UILabel[] buttonLabels; // 0x30
	[SerializeField]
	private UIImageButton[] buttons; // 0x38
	[CompilerGenerated]
	private int <SkillId>k__BackingField; // 0x40
	[CompilerGenerated]
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> <Config>k__BackingField; // 0x44
	private string[] iconNames; // 0x48
	[TupleElementNames(new[] { "a", "b" })]
	private Action<int, ValueTuple<bool, bool>> setAction; // 0x50
	private Func<int, bool> pointCheck; // 0x58
	private SystemTextManager sys; // 0x60

	// Properties
	public int SkillId { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> Config { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19D056C Offset: 0x19CC56C VA: 0x19D056C
	public int get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x19D0574 Offset: 0x19CC574 VA: 0x19D0574
	private void set_SkillId(int value) { }

	[CompilerGenerated]
	// RVA: 0x19D057C Offset: 0x19CC57C VA: 0x19D057C
	public ValueTuple<bool, bool> get_Config() { }

	[CompilerGenerated]
	// RVA: 0x19D0584 Offset: 0x19CC584 VA: 0x19D0584
	private void set_Config(ValueTuple<bool, bool> value) { }

	// RVA: 0x19D058C Offset: 0x19CC58C VA: 0x19D058C
	public void Initialize(int skillId, string[] iconNames, ValueTuple<bool, bool> config, Action<int, ValueTuple<bool, bool>> setAction, Func<int, bool> pointCheck) { }

	// RVA: 0x19D0BD0 Offset: 0x19CCBD0 VA: 0x19D0BD0
	public void OnEx1() { }

	// RVA: 0x19D0D34 Offset: 0x19CCD34 VA: 0x19D0D34
	public void OnEx2() { }

	// RVA: 0x19D0838 Offset: 0x19CC838 VA: 0x19D0838
	private void UpdateLabel() { }

	// RVA: 0x19D0B34 Offset: 0x19CCB34 VA: 0x19D0B34
	private void UpdateButtonLooks(UIImageButton button, bool flag) { }

	// RVA: 0x19D09A8 Offset: 0x19CC9A8 VA: 0x19D09A8
	private void UpdateIcon() { }

	// RVA: 0x19D0D10 Offset: 0x19CCD10 VA: 0x19D0D10
	private int GetPoint(bool a, bool b, bool isNeed = False) { }

	// RVA: 0x19D0E78 Offset: 0x19CCE78 VA: 0x19D0E78
	public void .ctor() { }
}
