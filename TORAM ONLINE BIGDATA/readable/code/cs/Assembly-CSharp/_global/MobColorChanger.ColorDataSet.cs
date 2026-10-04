// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobColorChanger.ColorDataSet // TypeDefIndex: 924
{
	// Fields
	private bool isInitializeComplete; // 0x10
	private Color32 defaultColor; // 0x14
	private string materialPropertyName; // 0x18
	[CompilerGenerated]
	private int <ColorSource>k__BackingField; // 0x20

	// Properties
	public bool Enable { get; }
	public Color32 Color { get; }
	private int ColorSource { get; set; }
	public string PropertyName { get; }

	// Methods

	// RVA: 0x1F06A64 Offset: 0x1F02A64 VA: 0x1F06A64
	public bool get_Enable() { }

	// RVA: 0x1F06A74 Offset: 0x1F02A74 VA: 0x1F06A74
	public Color32 get_Color() { }

	[CompilerGenerated]
	// RVA: 0x1F06A90 Offset: 0x1F02A90 VA: 0x1F06A90
	private int get_ColorSource() { }

	[CompilerGenerated]
	// RVA: 0x1F06A98 Offset: 0x1F02A98 VA: 0x1F06A98
	public void set_ColorSource(int value) { }

	// RVA: 0x1F06AA0 Offset: 0x1F02AA0 VA: 0x1F06AA0
	public string get_PropertyName() { }

	// RVA: 0x1F06A2C Offset: 0x1F02A2C VA: 0x1F06A2C
	public void .ctor(int color, string propertyName) { }

	// RVA: 0x1F067A0 Offset: 0x1F027A0 VA: 0x1F067A0
	public void SetColor(Material material) { }

	// RVA: 0x1F06758 Offset: 0x1F02758 VA: 0x1F06758
	public void SetDefaultColor(Material material) { }
}
