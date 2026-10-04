// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletElement : MonoBehaviour // TypeDefIndex: 7913
{
	// Fields
	[SerializeField]
	private UISprite icon; // 0x20
	[SerializeField]
	private UILabel nameLabel; // 0x28
	[SerializeField]
	private UILabel exLabel; // 0x30
	private GemCartData equipData; // 0x38
	private List<GameObject> multiSelectIconList; // 0x40
	private const float NameLabelPosX = -165;
	private const float IconPosX = -210;

	// Methods

	// RVA: 0x1C62B50 Offset: 0x1C5EB50 VA: 0x1C62B50
	private void Awake() { }

	// RVA: 0x1C5F49C Offset: 0x1C5B49C VA: 0x1C5F49C
	public void SetButton(GemCartData data, string name) { }

	// RVA: 0x1C62D2C Offset: 0x1C5ED2C VA: 0x1C62D2C
	public void SetButton(GemCartData data, string name, string color) { }

	// RVA: 0x1C60DD0 Offset: 0x1C5CDD0 VA: 0x1C60DD0
	public void SetButton(string text) { }

	// RVA: 0x1C60D3C Offset: 0x1C5CD3C VA: 0x1C60D3C
	public void AddSlotButton(string text) { }

	// RVA: 0x1C63060 Offset: 0x1C5F060 VA: 0x1C63060
	public void NonSelectButton(string text) { }

	// RVA: 0x1C5F4FC Offset: 0x1C5B4FC VA: 0x1C5F4FC
	public void GetGemPowderButton(string text) { }

	// RVA: 0x1C632F8 Offset: 0x1C5F2F8 VA: 0x1C632F8
	public void MultiSelectButton(string text, int selectNum) { }

	// RVA: 0x1C63708 Offset: 0x1C5F708 VA: 0x1C63708
	public void .ctor() { }
}
