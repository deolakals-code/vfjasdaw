// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobEventCircleManager // TypeDefIndex: 927
{
	// Fields
	private readonly EnemyMobActionManagerBase actorAction; // 0x10
	private PlayerDataManager player; // 0x18
	private bool valid; // 0x20
	private ScriptFlag flag; // 0x24
	private float range; // 0x28
	private int color; // 0x2C

	// Methods

	// RVA: 0x1F06B38 Offset: 0x1F02B38 VA: 0x1F06B38
	public void .ctor(EnemyMobActionManagerBase actorAction) { }

	// RVA: 0x1F06B68 Offset: 0x1F02B68 VA: 0x1F06B68
	public void Update() { }

	// RVA: 0x1F06D88 Offset: 0x1F02D88 VA: 0x1F06D88
	public void Valid() { }

	// RVA: 0x1EFA904 Offset: 0x1EF6904 VA: 0x1EFA904
	public void Invalid() { }

	// RVA: 0x1F06D94 Offset: 0x1F02D94 VA: 0x1F06D94
	public void UpdateEventCircleStatus(int flag, float range, int color) { }

	// RVA: 0x1F06DA4 Offset: 0x1F02DA4 VA: 0x1F06DA4
	public void DrawCircle() { }

	// RVA: 0x1EFA8D8 Offset: 0x1EF68D8 VA: 0x1EFA8D8
	public void RemoveCircle() { }

	// RVA: 0x1F06D54 Offset: 0x1F02D54 VA: 0x1F06D54
	private bool CheckRange(Vector3 actorPos, Vector3 targetPos, float targetSize) { }
}
