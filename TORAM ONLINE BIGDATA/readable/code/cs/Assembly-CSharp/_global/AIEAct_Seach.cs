// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIEAct_Seach : AIEventActionState // TypeDefIndex: 1605
{
	// Fields
	private float serch_distance; // 0x2C
	private float serch_rad; // 0x30
	private bool in_range; // 0x34

	// Methods

	// RVA: 0x20923D8 Offset: 0x208E3D8 VA: 0x20923D8
	public void .ctor(IScriptAICentral _ai_manager, float _serch_distance, float _serch_rad, bool _is_range_cheak) { }

	// RVA: 0x209242C Offset: 0x208E42C VA: 0x209242C Slot: 11
	public override AIEventActionState Clone() { }

	// RVA: 0x2092500 Offset: 0x208E500 VA: 0x2092500 Slot: 9
	public override bool Action() { }

	// RVA: 0x20929C0 Offset: 0x208E9C0 VA: 0x20929C0
	private bool in_serch_area(float _target_distance, Vector3 _target_dir_normalized, Vector3 _mine_pos, float _angle) { }

	// RVA: 0x2092BC0 Offset: 0x208EBC0 VA: 0x2092BC0
	private bool out_serch_area(float _target_distance, Vector3 _target_normalized, Vector3 _mine_pos, float _angle) { }
}
