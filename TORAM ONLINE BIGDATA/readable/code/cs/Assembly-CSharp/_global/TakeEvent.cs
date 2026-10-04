// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class TakeEvent // TypeDefIndex: 4623
{
	// Fields
	[SearchableEnum]
	public TakeEventType Type; // 0x10
	public int Parameter; // 0x14
	public float Timer; // 0x18

	// Methods

	// RVA: 0x2583274 Offset: 0x257F274 VA: 0x2583274
	public void .ctor(TakeEventType type, int parameter) { }

	// RVA: 0x25832A0 Offset: 0x257F2A0 VA: 0x25832A0
	public void .ctor(TakeEventType type, int parameter, float timer) { }
}
