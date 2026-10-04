// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RenderVartexColorChanger : MonoBehaviour // TypeDefIndex: 289
{
	// Fields
	private bool initFlag; // 0x20
	private bool changeFlag; // 0x21
	private SkinnedMeshRenderer[] baseSkin; // 0x28
	private SkinBreakParts skinBreakParts; // 0x30
	private Color defaultColorR; // 0x38
	private Color defaultColorG; // 0x48
	private Color defaultColorB; // 0x58
	private Color changeColorR; // 0x68
	private Color changeColorG; // 0x78
	private Color changeColorB; // 0x88

	// Methods

	// RVA: 0x22B5DBC Offset: 0x22B1DBC VA: 0x22B5DBC
	public void Initialize() { }

	// RVA: 0x22B6078 Offset: 0x22B2078 VA: 0x22B6078
	public void Initialize(SkinnedMeshRenderer[] skin) { }

	// RVA: 0x22B6254 Offset: 0x22B2254 VA: 0x22B6254
	public void ChangeColor(byte bit, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x22B63F0 Offset: 0x22B23F0 VA: 0x22B63F0
	private void ChangeColor() { }

	// RVA: 0x22B6588 Offset: 0x22B2588 VA: 0x22B6588
	private void Update() { }

	// RVA: 0x22B65A0 Offset: 0x22B25A0 VA: 0x22B65A0
	public void .ctor() { }
}
