// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerMoveSpeedValueData : IValiableData // TypeDefIndex: 1556
{
	// Fields
	private PlayerDataManager playerData; // 0x10
	private float rate; // 0x18
	private bool IsminMaxSetting; // 0x1C
	private float minSpeed; // 0x20
	private float maxSpeed; // 0x24

	// Properties
	private float GetValue { get; }

	// Methods

	// RVA: 0x208ADF0 Offset: 0x2086DF0 VA: 0x208ADF0
	private float get_GetValue() { }

	// RVA: 0x208AEB4 Offset: 0x2086EB4 VA: 0x208AEB4 Slot: 4
	public float GetFValue() { }

	// RVA: 0x208AF4C Offset: 0x2086F4C VA: 0x208AF4C Slot: 5
	public int GetIValue() { }

	// RVA: 0x208AFF8 Offset: 0x2086FF8 VA: 0x208AFF8
	public void .ctor(PlayerDataManager data) { }

	// RVA: 0x208B030 Offset: 0x2087030 VA: 0x208B030
	public void .ctor(PlayerDataManager data, float rate) { }

	// RVA: 0x208B070 Offset: 0x2087070 VA: 0x208B070
	public void .ctor(PlayerDataManager data, float rate, float min, float max) { }
}
