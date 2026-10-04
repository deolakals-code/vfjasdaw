// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIMS_ValueChangeAction : AIMasteryActionStateBase // TypeDefIndex: 1610
{
	// Fields
	private ActionMaterialPropatyData propaty_data; // 0x18
	private int access_propaty_bit; // 0x20
	private float timing; // 0x24
	private float elapsed_time; // 0x28
	private int grant_value; // 0x2C
	private float base_time; // 0x30
	private bool access_format_bitflg; // 0x34

	// Methods

	// RVA: 0x209345C Offset: 0x208F45C VA: 0x209345C
	public void .ctor(MasteryScriptAI _mastery_script_ai, ActionMaterialPropatyData _propaty_data, int _access_propaty_bit, float _timing, int _grant_value, bool _access_format) { }

	// RVA: 0x20934C4 Offset: 0x208F4C4 VA: 0x20934C4 Slot: 8
	public override bool Action() { }
}
