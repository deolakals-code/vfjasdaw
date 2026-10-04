// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIEAct_CheckOneMaterialValue : AIEventActionStateBase // TypeDefIndex: 1595
{
	// Fields
	protected int access_material_bit; // 0x24
	protected int check_value; // 0x28

	// Methods

	// RVA: 0x20904D4 Offset: 0x208C4D4 VA: 0x20904D4
	public void .ctor(IScriptAICentral _central, int _access_bit, int _check_value, IAIAction _action) { }

	// RVA: 0x2090A64 Offset: 0x208CA64 VA: 0x2090A64 Slot: 11
	public override AIEventActionStateBase Clone() { }

	// RVA: 0x2090AD4 Offset: 0x208CAD4 VA: 0x2090AD4 Slot: 12
	protected override bool cheak_term() { }

	// RVA: 0x2090B10 Offset: 0x208CB10 VA: 0x2090B10
	private bool check_realation_value() { }

	// RVA: 0x2090C6C Offset: 0x208CC6C VA: 0x2090C6C Slot: 13
	protected virtual bool check_range_value() { }
}
