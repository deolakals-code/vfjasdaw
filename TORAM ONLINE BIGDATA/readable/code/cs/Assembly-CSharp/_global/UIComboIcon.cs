// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIComboIcon : MonoBehaviour // TypeDefIndex: 6862
{
	// Fields
	[SerializeField]
	private GameObject skillIconObject; // 0x20
	private UIIcon skillIcon; // 0x28
	[SerializeField]
	private GameObject comboIconObject; // 0x30
	private UIIcon comboIcon; // 0x38
	[SerializeField]
	private TweenScale scaleAnimation; // 0x40
	[SerializeField]
	private TweenAlpha alphaAnimation; // 0x48
	private byte comboId; // 0x50
	private SkillComboType bufferId; // 0x54
	private short skillId; // 0x58
	private UIComboWindow window; // 0x60

	// Properties
	public byte ComboIndex { get; }

	// Methods

	// RVA: 0x1A1F618 Offset: 0x1A1B618 VA: 0x1A1F618
	public byte get_ComboIndex() { }

	// RVA: 0x1A1F620 Offset: 0x1A1B620 VA: 0x1A1F620
	public void SetComboIcon(short skillId, SkillComboType bufferId, byte comboId, UIComboWindow window) { }

	// RVA: 0x1A1F7CC Offset: 0x1A1B7CC VA: 0x1A1F7CC
	public void SelectButton(bool select) { }

	// RVA: 0x1A1F830 Offset: 0x1A1B830 VA: 0x1A1F830
	private void OnClick() { }

	// RVA: 0x1A1F854 Offset: 0x1A1B854 VA: 0x1A1F854
	public void .ctor() { }
}
