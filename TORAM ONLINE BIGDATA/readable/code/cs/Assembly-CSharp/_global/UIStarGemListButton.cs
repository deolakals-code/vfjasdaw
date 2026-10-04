// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemListButton : MonoBehaviour // TypeDefIndex: 8018
{
	// Fields
	[SerializeField]
	private UIButtonSendMessage button; // 0x20
	[SerializeField]
	private UIImageButton imageButton; // 0x28
	[SerializeField]
	private BoxCollider buttonCollider; // 0x30
	[SerializeField]
	private UIIcon icon; // 0x38
	[SerializeField]
	private UILabel levelLabel; // 0x40
	[SerializeField]
	private UILabel nameLabel; // 0x48
	[SerializeField]
	private UILabel costLabel; // 0x50
	[SerializeField]
	private UILabel lvLabel; // 0x58
	private StarGemData gemData; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private string levelText; // 0x70
	private string nameText; // 0x78

	// Properties
	public UIIcon Icon { get; }
	public StarGemData GemData { get; }

	// Methods

	// RVA: 0x1C9F864 Offset: 0x1C9B864 VA: 0x1C9F864
	public UIIcon get_Icon() { }

	// RVA: 0x1C9F86C Offset: 0x1C9B86C VA: 0x1C9F86C
	public StarGemData get_GemData() { }

	// RVA: 0x1C9DED8 Offset: 0x1C99ED8 VA: 0x1C9DED8
	public void SetLabelsText(string name, string level, string cost) { }

	// RVA: 0x1C9F874 Offset: 0x1C9B874 VA: 0x1C9F874
	public void SetLabelEquipColor() { }

	// RVA: 0x1C9F958 Offset: 0x1C9B958 VA: 0x1C9F958
	public void SetLabelSelectColor() { }

	// RVA: 0x1C9FA3C Offset: 0x1C9BA3C VA: 0x1C9FA3C
	public void ResetLabelColor() { }

	// RVA: 0x1C9E1AC Offset: 0x1C9A1AC VA: 0x1C9E1AC
	public void SetButtonData(GameObject target, StarGemData data, string funcName, int param) { }

	// RVA: 0x1C9FB20 Offset: 0x1C9BB20 VA: 0x1C9FB20
	public void SwitchButtonFunc(string funcName, int param) { }

	// RVA: 0x1C9FB40 Offset: 0x1C9BB40 VA: 0x1C9FB40
	public void SetButtonEnabled(bool isEnabled) { }

	// RVA: 0x1C9E18C Offset: 0x1C9A18C VA: 0x1C9E18C
	public void ChangeEnabledImageButton(bool isEnabled) { }

	// RVA: 0x1C9FB84 Offset: 0x1C9BB84 VA: 0x1C9FB84
	public void .ctor() { }
}
