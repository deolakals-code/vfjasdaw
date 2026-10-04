// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIAct_Warp : ActionStateBase // TypeDefIndex: 1574
{
	// Fields
	private float warpDistance; // 0x18
	private float ChangeRad; // 0x1C
	private float ErrorHeight; // 0x20

	// Methods

	// RVA: 0x208DB08 Offset: 0x2089B08 VA: 0x208DB08
	public void .ctor(IScriptAICentral _script_central) { }

	// RVA: 0x208DB50 Offset: 0x2089B50 VA: 0x208DB50
	public void .ctor(IScriptAICentral _script_central, float _warp_dist, float _change_rad, float _error_height) { }

	// RVA: 0x208DBA8 Offset: 0x2089BA8 VA: 0x208DBA8 Slot: 9
	public override bool Action() { }

	// RVA: 0x208DC78 Offset: 0x2089C78 VA: 0x208DC78
	private Vector3 CalcWarpPointPos() { }
}
