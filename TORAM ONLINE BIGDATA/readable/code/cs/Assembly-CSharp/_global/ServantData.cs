// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ServantData : MonoBehaviour // TypeDefIndex: 2522
{
	// Fields
	[SerializeField]
	private Color[] presetColorR; // 0x20
	[SerializeField]
	private Color[] presetColorG; // 0x28
	[SerializeField]
	private byte defaultBColor; // 0x30
	[SerializeField]
	private Vector3 viewOffest; // 0x34

	// Properties
	public Vector3 ViewOffest { get; }
	public byte DefaultBColor { get; }

	// Methods

	// RVA: 0x21E2D5C Offset: 0x21DED5C VA: 0x21E2D5C
	public Vector3 get_ViewOffest() { }

	// RVA: 0x21E2D68 Offset: 0x21DED68 VA: 0x21E2D68
	public byte get_DefaultBColor() { }

	// RVA: 0x21E2D70 Offset: 0x21DED70 VA: 0x21E2D70
	public int GetPresetNum() { }

	// RVA: 0x21E2D88 Offset: 0x21DED88 VA: 0x21E2D88
	private Color GetPresetColor(Color[] list, byte index) { }

	// RVA: 0x21E2DD8 Offset: 0x21DEDD8 VA: 0x21E2DD8
	public Color GetPresetColorR(byte index) { }

	// RVA: 0x21E2DE8 Offset: 0x21DEDE8 VA: 0x21E2DE8
	public Color GetPresetColorG(byte index) { }

	// RVA: 0x21E2DF8 Offset: 0x21DEDF8 VA: 0x21E2DF8
	public void .ctor() { }
}
