// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemElement : MonoBehaviour // TypeDefIndex: 8012
{
	// Fields
	[SerializeField]
	private GameObject starGemDataLabelsObj; // 0x20
	[SerializeField]
	private GameObject unsetLabelObj; // 0x28
	[SerializeField]
	private UILabel levelLabel; // 0x30
	[SerializeField]
	private UILabel nameLabel; // 0x38
	[SerializeField]
	private UILabel costLabel; // 0x40
	[SerializeField]
	private UIIcon skillIcon; // 0x48
	[SerializeField]
	private UISprite backSprite; // 0x50
	private int cost; // 0x58
	private bool isSetSkill; // 0x5C
	private StarGemData gemData; // 0x60

	// Properties
	public int Cost { get; }
	public bool IsSetSkill { get; }
	public StarGemData GemData { get; }
	public string GetSkillName { get; }

	// Methods

	// RVA: 0x1C9C7D8 Offset: 0x1C987D8 VA: 0x1C9C7D8
	public int get_Cost() { }

	// RVA: 0x1C9C7E0 Offset: 0x1C987E0 VA: 0x1C9C7E0
	public bool get_IsSetSkill() { }

	// RVA: 0x1C9C7E8 Offset: 0x1C987E8 VA: 0x1C9C7E8
	public StarGemData get_GemData() { }

	// RVA: 0x1C9C7F0 Offset: 0x1C987F0 VA: 0x1C9C7F0
	public string get_GetSkillName() { }

	// RVA: 0x1C9A094 Offset: 0x1C96094 VA: 0x1C9A094
	public void SetButton(StarGemData gem, string name, int cost) { }

	// RVA: 0x1C99F4C Offset: 0x1C95F4C VA: 0x1C99F4C
	public void SetButton() { }

	// RVA: 0x1C9C80C Offset: 0x1C9880C VA: 0x1C9C80C
	public void SetColorTextElement(StarGemData gem, string name, int cost) { }

	// RVA: 0x1C9A4E4 Offset: 0x1C964E4 VA: 0x1C9A4E4
	public void BaseBrightnessChange(bool isBright) { }

	// RVA: 0x1C9CA48 Offset: 0x1C98A48 VA: 0x1C9CA48
	public void .ctor() { }
}
