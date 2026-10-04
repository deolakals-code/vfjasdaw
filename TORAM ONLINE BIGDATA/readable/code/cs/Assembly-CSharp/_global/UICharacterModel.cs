// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICharacterModel : MonoBehaviour // TypeDefIndex: 8874
{
	// Fields
	private Texture skinTex; // 0x20
	private Texture hairTex; // 0x28
	private Texture eyeTex; // 0x30
	private Color skinColor; // 0x38
	private Color hairColor; // 0x48
	private Color eyeColor; // 0x58
	private Color hairStreakColor; // 0x68
	private Color oddEyeColor; // 0x78
	private Color baseColorR; // 0x88
	private Color baseColorG; // 0x98
	private Color baseColorB; // 0xA8
	private SkinnedMeshRenderer skinMeshRenderer; // 0xB8

	// Properties
	public Color BaseColorR { get; }
	public Color BaseColorG { get; }
	public Color BaseColorB { get; }

	// Methods

	// RVA: 0x1E3C490 Offset: 0x1E38490 VA: 0x1E3C490
	public Color get_BaseColorR() { }

	// RVA: 0x1E3C49C Offset: 0x1E3849C VA: 0x1E3C49C
	public Color get_BaseColorG() { }

	// RVA: 0x1E3C4A8 Offset: 0x1E384A8 VA: 0x1E3C4A8
	public Color get_BaseColorB() { }

	// RVA: 0x1E3C4B4 Offset: 0x1E384B4 VA: 0x1E3C4B4
	public SkinnedMeshRenderer Initialize(Texture skinTex, Texture hairTex, Texture eyeTex, Color skinColor, Color hairColor, Color eyeColor, Color oddEyeColor, Color hairStreakColor) { }

	// RVA: 0x1E3CCF4 Offset: 0x1E38CF4 VA: 0x1E3CCF4
	public void SetActive(bool acitve) { }

	// RVA: 0x1E3CD14 Offset: 0x1E38D14 VA: 0x1E3CD14
	public void ColorSetting(byte colorRId, byte colorGId, byte colorBId) { }

	// RVA: 0x1E3CE70 Offset: 0x1E38E70 VA: 0x1E3CE70
	public void ColorSetting(Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x1E3D0EC Offset: 0x1E390EC VA: 0x1E3D0EC
	public void PlayerColorSetting(Color skinColor, Color hairColor, Color eyeColor, Color oddEyeColro, Color hairStreakColor) { }

	// RVA: 0x1E3D12C Offset: 0x1E3912C VA: 0x1E3D12C
	public void PlayerTextureSetting(Texture skinTex, Texture hairTex, Texture eyeTex) { }

	// RVA: 0x1E3C9C8 Offset: 0x1E389C8 VA: 0x1E3C9C8
	public void PlayerBaseSetting(Color skinColor, Color hairColor, Color eyeColor, Color oddEyeColor, Color hairStreakColor, Texture skinTex, Texture hairTex, Texture eyeTex) { }

	// RVA: 0x1E3D18C Offset: 0x1E3918C VA: 0x1E3D18C
	public void .ctor() { }
}
