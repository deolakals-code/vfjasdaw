// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TextureScale // TypeDefIndex: 5590
{
	// Fields
	private static Color[] texColors; // 0x0
	private static Color[] newColors; // 0x8
	private static int w; // 0x10
	private static float ratioX; // 0x14
	private static float ratioY; // 0x18
	private static int w2; // 0x1C
	private static int finishCount; // 0x20
	private static Mutex mutex; // 0x28

	// Methods

	// RVA: 0x17A23BC Offset: 0x179E3BC VA: 0x17A23BC
	public static void Point(Texture2D tex, int newWidth, int newHeight) { }

	// RVA: 0x17A27E4 Offset: 0x179E7E4 VA: 0x17A27E4
	public static void Bilinear(Texture2D tex, int newWidth, int newHeight) { }

	// RVA: 0x17A23C4 Offset: 0x179E3C4 VA: 0x17A23C4
	private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear) { }

	// RVA: 0x17A2818 Offset: 0x179E818 VA: 0x17A2818
	public static void BilinearScale(object obj) { }

	// RVA: 0x17A2A50 Offset: 0x179EA50 VA: 0x17A2A50
	public static void PointScale(object obj) { }

	// RVA: 0x17A2C00 Offset: 0x179EC00 VA: 0x17A2C00
	private static Color ColorLerpUnclamped(Color c1, Color c2, float value) { }

	// RVA: 0x17A2C38 Offset: 0x179EC38 VA: 0x17A2C38
	public void .ctor() { }
}
