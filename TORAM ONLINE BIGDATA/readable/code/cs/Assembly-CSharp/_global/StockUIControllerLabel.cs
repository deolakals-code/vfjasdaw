// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UILabel))]
public class StockUIControllerLabel : MonoBehaviour // TypeDefIndex: 6334
{
	// Fields
	public Color left_base_color; // 0x20
	public int change_color_value; // 0x30
	public Color change_color; // 0x34
	private UILabel label; // 0x48
	private int have_value; // 0x50
	private int max_value; // 0x54
	private bool is_max_break; // 0x58

	// Properties
	public int NowValue { get; set; }
	public int MaxValue { get; }
	public bool IsMaxState { get; }
	public bool IsMinimumValue { get; }

	// Methods

	// RVA: 0x18EAD44 Offset: 0x18E6D44 VA: 0x18EAD44
	public void set_NowValue(int value) { }

	// RVA: 0x18EAEB4 Offset: 0x18E6EB4 VA: 0x18EAEB4
	public int get_NowValue() { }

	// RVA: 0x18EAEBC Offset: 0x18E6EBC VA: 0x18EAEBC
	public int get_MaxValue() { }

	// RVA: 0x18EA2E4 Offset: 0x18E62E4 VA: 0x18EA2E4
	public bool get_IsMaxState() { }

	// RVA: 0x18E5AA0 Offset: 0x18E1AA0 VA: 0x18E5AA0
	public bool get_IsMinimumValue() { }

	// RVA: 0x18EAEC4 Offset: 0x18E6EC4 VA: 0x18EAEC4
	private void Awake() { }

	// RVA: 0x18EAEC8 Offset: 0x18E6EC8 VA: 0x18EAEC8
	private void component_get() { }

	// RVA: 0x18EAF78 Offset: 0x18E6F78 VA: 0x18EAF78
	public void DirectSetText(string _set_text, Color _color) { }

	// RVA: 0x18E1704 Offset: 0x18DD704 VA: 0x18E1704
	public void SetValue(int _have_value, int _max_value, bool _is_max_break) { }

	// RVA: 0x18EB17C Offset: 0x18E717C VA: 0x18EB17C
	private void value_audit(int _have_value, int _max_value) { }

	// RVA: 0x18EAD4C Offset: 0x18E6D4C VA: 0x18EAD4C
	private void label_update() { }

	// RVA: 0x18EB194 Offset: 0x18E7194 VA: 0x18EB194
	private Color cheak_change_color(int _cheak_value) { }

	// RVA: 0x18EB034 Offset: 0x18E7034 VA: 0x18EB034
	private string color_string(Color _color) { }

	// RVA: 0x18EB1D8 Offset: 0x18E71D8 VA: 0x18EB1D8
	private string color_value_chnage_value(float _base_value) { }

	// RVA: 0x18EB300 Offset: 0x18E7300 VA: 0x18EB300
	public void .ctor() { }
}
