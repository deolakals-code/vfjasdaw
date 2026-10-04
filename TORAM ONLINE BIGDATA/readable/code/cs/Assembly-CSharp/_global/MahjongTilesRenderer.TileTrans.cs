// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongTilesRenderer.TileTrans // TypeDefIndex: 4442
{
	// Fields
	private byte type; // 0x10
	public int Uid; // 0x14
	private int index; // 0x18
	public Vector3 Position; // 0x1C
	public Vector3 Scale; // 0x28
	public Quaternion Rotation; // 0x34
	public bool IsPickup; // 0x44
	public bool IsPickup2; // 0x45
	public bool IsPickup3; // 0x46
	private bool isRed; // 0x47
	private static byte[] TypeY; // 0x0
	private byte animationId; // 0x48
	private float animationTimer; // 0x4C
	private Matrix4x4 userTrans; // 0x50

	// Properties
	public byte Type { get; }
	public int Index { get; set; }

	// Methods

	// RVA: 0x24F6154 Offset: 0x24F2154 VA: 0x24F6154
	public byte get_Type() { }

	// RVA: 0x24F615C Offset: 0x24F215C VA: 0x24F615C
	public int get_Index() { }

	// RVA: 0x24F6164 Offset: 0x24F2164 VA: 0x24F6164
	public void set_Index(int value) { }

	// RVA: 0x24F54AC Offset: 0x24F14AC VA: 0x24F54AC
	public void .ctor(byte type, bool isRed) { }

	// RVA: 0x24F521C Offset: 0x24F121C VA: 0x24F521C
	public void .ctor(byte type, bool isRed, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x24F5DF8 Offset: 0x24F1DF8 VA: 0x24F5DF8
	public Matrix4x4 GetMatrix(float area, float modelScale = 0.176) { }

	// RVA: 0x24F51F8 Offset: 0x24F11F8 VA: 0x24F51F8
	public void DiscardAnimation(Matrix4x4 trans) { }

	// RVA: 0x24F38DC Offset: 0x24EF8DC VA: 0x24F38DC
	public void OpenTileAnimation(Matrix4x4 trans) { }

	// RVA: 0x24EEBD8 Offset: 0x24EABD8 VA: 0x24EEBD8
	public void DrawAnimation(Matrix4x4 trans) { }

	// RVA: 0x24F51D4 Offset: 0x24F11D4 VA: 0x24F51D4
	public void RiichiAnimation(Matrix4x4 trans) { }

	// RVA: 0x24F616C Offset: 0x24F216C VA: 0x24F616C
	private static void .cctor() { }
}
