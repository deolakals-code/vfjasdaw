// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MergeMaterial // TypeDefIndex: 5320
{
	// Fields
	public byte TextureId; // 0x10
	public byte ShaderId; // 0x11
	public byte Type; // 0x12
	public short UVSeppd; // 0x14
	public short Layer; // 0x16
	public Color ColorR; // 0x18
	public Color ColorG; // 0x28
	public Color ColorB; // 0x38

	// Methods

	// RVA: 0x262E838 Offset: 0x262A838 VA: 0x262E838
	public static MergeMaterial CreateMergeMaterial(byte type, Dictionary<MaterialProperty, object> matProperty, List<Texture2D> textures, Texture2D texture, byte r, byte g, byte b) { }

	// RVA: 0x262EB4C Offset: 0x262AB4C VA: 0x262EB4C
	public static MergeMaterial CreateMergeMaterial(byte type, Dictionary<MaterialProperty, object> matProperty, List<Texture2D> textures, Texture2D texture, Color r, Color g, Color b) { }

	// RVA: 0x262EDF4 Offset: 0x262ADF4 VA: 0x262EDF4
	public void .ctor() { }
}
