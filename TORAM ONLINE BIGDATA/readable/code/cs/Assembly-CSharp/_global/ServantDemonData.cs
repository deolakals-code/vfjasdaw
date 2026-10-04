// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ServantDemonData : MonoBehaviour // TypeDefIndex: 2523
{
	// Fields
	[SerializeField]
	private Color[] presetColorR; // 0x20
	[SerializeField]
	private Color[] presetColorG; // 0x28
	[SerializeField]
	private Color[] presetColorB; // 0x30
	[SerializeField]
	private Vector3 viewOffest; // 0x38
	[SerializeField]
	private Vector3 viewScalet; // 0x44

	// Properties
	public Vector3 ViewOffest { get; }
	public Vector3 ViewScale { get; }

	// Methods

	// RVA: 0x21E2F00 Offset: 0x21DEF00 VA: 0x21E2F00
	public Vector3 get_ViewOffest() { }

	// RVA: 0x21E2F0C Offset: 0x21DEF0C VA: 0x21E2F0C
	public Vector3 get_ViewScale() { }

	// RVA: 0x21E2F18 Offset: 0x21DEF18 VA: 0x21E2F18
	public int GetPresetNum() { }

	// RVA: 0x21E2F30 Offset: 0x21DEF30 VA: 0x21E2F30
	private Color GetPresetColor(Color[] list, byte index) { }

	// RVA: 0x21E2F80 Offset: 0x21DEF80 VA: 0x21E2F80
	public Color GetPresetColorR(byte index) { }

	// RVA: 0x21E2F90 Offset: 0x21DEF90 VA: 0x21E2F90
	public Color GetPresetColorG(byte index) { }

	// RVA: 0x21E2FA0 Offset: 0x21DEFA0 VA: 0x21E2FA0
	public Color GetPresetColorB(byte index) { }

	// RVA: 0x21E2FB0 Offset: 0x21DEFB0 VA: 0x21E2FB0
	public void .ctor() { }
}
