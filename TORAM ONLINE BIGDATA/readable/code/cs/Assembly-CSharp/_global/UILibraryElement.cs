// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILibraryElement : MonoBehaviour // TypeDefIndex: 8348
{
	// Fields
	[SerializeField]
	private UISprite buttonBackground; // 0x20
	[SerializeField]
	private UILabel buttonLabel; // 0x28
	[SerializeField]
	private UISprite skillIcon; // 0x30
	[SerializeField]
	private UILabel skillNameLabel; // 0x38
	[SerializeField]
	private UILabel skillLvLabel; // 0x40
	[SerializeField]
	private BoxCollider buttonCollider; // 0x48
	private int accountLv; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private int skillTreeType; // 0x60
	private int skillNowLevel; // 0x64
	private Action<int, int, int, int> onClickEvent; // 0x68

	// Properties
	public int SkillTreeTypeId { get; }

	// Methods

	// RVA: 0x1D2B178 Offset: 0x1D27178 VA: 0x1D2B178
	public int get_SkillTreeTypeId() { }

	// RVA: 0x1D2B180 Offset: 0x1D27180 VA: 0x1D2B180
	private void Awake() { }

	// RVA: 0x1D2B294 Offset: 0x1D27294 VA: 0x1D2B294
	public void Initialize(int skillTreeType, int nowSkillLv, int requireLv, Action<int, int, int, int> onClick) { }

	// RVA: 0x1D2B774 Offset: 0x1D27774 VA: 0x1D2B774
	private void onClick() { }

	// RVA: 0x1D2B820 Offset: 0x1D27820 VA: 0x1D2B820
	public void .ctor() { }
}
