// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIEAct_CheckMultipleMaterialValue : AIEventActionStateBase // TypeDefIndex: 1592
{
	// Fields
	private MasteryScriptAI mastery_ai; // 0x28
	private int access_material_bit; // 0x30
	private int check_value; // 0x34
	private AIEAct_CheckMultipleMaterialValue.MaterialCheckType check_type; // 0x38

	// Methods

	// RVA: 0x20900A0 Offset: 0x208C0A0 VA: 0x20900A0 Slot: 11
	public override AIEventActionStateBase Clone() { }

	// RVA: 0x2090124 Offset: 0x208C124 VA: 0x2090124
	public void .ctor(IScriptAICentral _central, int _access_material_bit, int _check_value, IAIAction _action, AIEAct_CheckMultipleMaterialValue.MaterialCheckType _check_type = 0) { }

	// RVA: 0x2090284 Offset: 0x208C284 VA: 0x2090284 Slot: 12
	protected override bool cheak_term() { }

	// RVA: 0x2090288 Offset: 0x208C288 VA: 0x2090288
	private bool access_material_data_for_check_type() { }

	// RVA: 0x2090390 Offset: 0x208C390 VA: 0x2090390
	private bool calc_check_type(int[] _datas) { }
}
