// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLSpriteView // TypeDefIndex: 211
{
	// Fields
	protected Color mColor; // 0x10
	protected UIWidget.Pivot mPivot; // 0x20
	protected Rect uv; // 0x24
	protected float[] atlasVertexX; // 0x38
	protected float[] atlasVertexY; // 0x40
	protected float[] vertexX; // 0x48
	protected float[] vertexY; // 0x50
	protected float[] drawVertexX; // 0x58
	protected float[] drawVertexY; // 0x60
	protected float mAlpha; // 0x68

	// Methods

	// RVA: 0x21C16C0 Offset: 0x21BD6C0 VA: 0x21C16C0
	public void .ctor(UIAtlas atlas, string spriteName, UIWidget.Pivot pivot, Color color) { }

	// RVA: 0x21C1A4C Offset: 0x21BDA4C VA: 0x21C1A4C
	public void SetTrans_SO(Vector3 offset, Vector3 scale) { }

	// RVA: 0x21C1AF8 Offset: 0x21BDAF8 VA: 0x21C1AF8
	public void SetTrans_OS(Vector3 offset, Vector3 scale) { }

	// RVA: 0x21C1BA4 Offset: 0x21BDBA4 VA: 0x21C1BA4
	public void SetOffset(Vector3 pos) { }

	// RVA: 0x21C1C48 Offset: 0x21BDC48 VA: 0x21C1C48 Slot: 4
	public virtual void SetScale(Vector3 scale) { }

	// RVA: 0x21C1CEC Offset: 0x21BDCEC VA: 0x21C1CEC
	public void SetAlpha(float a) { }

	// RVA: 0x21C1CF4 Offset: 0x21BDCF4 VA: 0x21C1CF4 Slot: 5
	public virtual bool OnDraw(Matrix4x4 localToWorldMatrix, Vector3 position) { }
}
