// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletListButton : MonoBehaviour // TypeDefIndex: 7914
{
	// Fields
	[SerializeField]
	private UILabel label; // 0x20
	[SerializeField]
	private UIIcon icon; // 0x28
	[SerializeField]
	private GameObject lockIcon; // 0x30
	[SerializeField]
	private UIImageButton button; // 0x38
	[SerializeField]
	private GameObject selectIcon; // 0x40
	[CompilerGenerated]
	private GemCartData <Data>k__BackingField; // 0x48
	private string baseText; // 0x50

	// Properties
	public GemCartData Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C63790 Offset: 0x1C5F790 VA: 0x1C63790
	public GemCartData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x1C63798 Offset: 0x1C5F798 VA: 0x1C63798
	private void set_Data(GemCartData value) { }

	// RVA: 0x1C637A0 Offset: 0x1C5F7A0 VA: 0x1C637A0
	public void SetButtonData(GemCartData data, string name, UnityAction<int> action) { }

	// RVA: 0x1C6394C Offset: 0x1C5F94C VA: 0x1C6394C
	public void SetEquipResetButton(string buttonText, UnityAction<int> action) { }

	// RVA: 0x1C63A40 Offset: 0x1C5FA40 VA: 0x1C63A40
	public void SetSearchNameButton(string buttonText, UnityAction<int> action) { }

	// RVA: 0x1C5DAAC Offset: 0x1C59AAC VA: 0x1C5DAAC
	public void EquipLabel() { }

	// RVA: 0x1C5DB38 Offset: 0x1C59B38 VA: 0x1C5DB38
	public void SelectLabel() { }

	// RVA: 0x1C5DB14 Offset: 0x1C59B14 VA: 0x1C5DB14
	public void NoSelectLabel() { }

	// RVA: 0x1C5E0A8 Offset: 0x1C5A0A8 VA: 0x1C5E0A8
	public void UpdateButton() { }

	// RVA: 0x1C63B34 Offset: 0x1C5FB34 VA: 0x1C63B34
	public void SelectButton(bool isSelect) { }

	// RVA: 0x1C63B54 Offset: 0x1C5FB54 VA: 0x1C63B54
	public void .ctor() { }
}
