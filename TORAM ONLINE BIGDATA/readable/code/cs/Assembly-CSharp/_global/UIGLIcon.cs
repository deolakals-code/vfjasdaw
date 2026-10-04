// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLIcon : UIIconBase // TypeDefIndex: 8916
{
	// Fields
	[SerializeField]
	private UIGLSprite baseIcon; // 0x28
	[SerializeField]
	private float scale; // 0x30

	// Properties
	public float alpha { get; set; }
	public float Size { get; set; }

	// Methods

	// RVA: 0x1E54984 Offset: 0x1E50984 VA: 0x1E54984
	public float get_alpha() { }

	// RVA: 0x1E549A4 Offset: 0x1E509A4 VA: 0x1E549A4
	public void set_alpha(float value) { }

	// RVA: 0x1E549C8 Offset: 0x1E509C8 VA: 0x1E549C8
	public float get_Size() { }

	// RVA: 0x1E549D0 Offset: 0x1E509D0 VA: 0x1E549D0
	public void set_Size(float value) { }

	// RVA: 0x1E54AD0 Offset: 0x1E50AD0 VA: 0x1E54AD0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x1E54B68 Offset: 0x1E50B68 VA: 0x1E54B68 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x1E54BF0 Offset: 0x1E50BF0 VA: 0x1E54BF0 Slot: 6
	protected override bool CheckSprite(string name) { }

	// RVA: 0x1E54C8C Offset: 0x1E50C8C VA: 0x1E54C8C Slot: 9
	public override void NonIcon() { }

	// RVA: 0x1E54D18 Offset: 0x1E50D18 VA: 0x1E54D18 Slot: 7
	public override void SetIcon(string spriteName, Color color) { }

	// RVA: 0x1E54E4C Offset: 0x1E50E4C VA: 0x1E54E4C Slot: 8
	public override void SetSystemIcon(string spriteName, Color color) { }

	// RVA: 0x1E54E58 Offset: 0x1E50E58 VA: 0x1E54E58
	public void .ctor() { }
}
