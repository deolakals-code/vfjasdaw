// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameSettingElement : MonoBehaviour // TypeDefIndex: 5728
{
	// Fields
	[SerializeField]
	private UILabel name; // 0x20
	[SerializeField]
	private UILabel valueLabel; // 0x28
	[SerializeField]
	private GameObject downButton; // 0x30
	[SerializeField]
	private GameObject upButton; // 0x38
	[SerializeField]
	private UISprite icon; // 0x40
	private int value; // 0x48
	private int minValue; // 0x4C
	private int maxValue; // 0x50
	private int changeValue; // 0x54
	private int defaultValue; // 0x58
	private UICardGameSettingElement.SettingUnitType type; // 0x5C
	private bool mainParam; // 0x60

	// Properties
	public int Value { get; }

	// Methods

	// RVA: 0x17D20C0 Offset: 0x17CE0C0 VA: 0x17D20C0
	public int get_Value() { }

	// RVA: 0x17D20C8 Offset: 0x17CE0C8 VA: 0x17D20C8
	public void Initialized(string name, int value, int min, int max, int change, UICardGameSettingElement.SettingUnitType type, bool main) { }

	// RVA: 0x17D2364 Offset: 0x17CE364 VA: 0x17D2364
	public void InitializedMember(string name, int value, UICardGameSettingElement.SettingUnitType type, bool main) { }

	// RVA: 0x17D23DC Offset: 0x17CE3DC VA: 0x17D23DC
	public void OnClickUp() { }

	// RVA: 0x17D24A0 Offset: 0x17CE4A0 VA: 0x17D24A0
	public void OnClickDown() { }

	// RVA: 0x17D2560 Offset: 0x17CE560 VA: 0x17D2560
	public void UpdateValue(int value) { }

	// RVA: 0x17D2568 Offset: 0x17CE568 VA: 0x17D2568
	public void SetIcon(string iconName) { }

	// RVA: 0x17D25A8 Offset: 0x17CE5A8 VA: 0x17D25A8
	public void ValidChangeValue() { }

	// RVA: 0x17D2608 Offset: 0x17CE608 VA: 0x17D2608
	public void InvalidChangeValue() { }

	// RVA: 0x17D2190 Offset: 0x17CE190 VA: 0x17D2190
	private void SetValueLabel() { }

	// RVA: 0x17D2640 Offset: 0x17CE640 VA: 0x17D2640
	public void .ctor() { }
}
