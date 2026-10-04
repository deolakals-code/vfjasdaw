// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobSymbolAI : MobAIBase // TypeDefIndex: 715
{
	// Fields
	private float moveTime; // 0x40
	private float nextActionTime; // 0x44
	private Vector3 lastPos; // 0x48
	private bool isBattleWait; // 0x54
	private Vector3 checkHeightVec; // 0x58
	private float checkHeight; // 0x64
	private float naturalMotionTime; // 0x68

	// Methods

	// RVA: 0x1B8CCAC Offset: 0x1B88CAC VA: 0x1B8CCAC Slot: 5
	protected override void OnInitialize() { }

	// RVA: 0x1B8CDA4 Offset: 0x1B88DA4 VA: 0x1B8CDA4 Slot: 6
	public override void AIUpdate() { }

	// RVA: 0x1B8D338 Offset: 0x1B89338 VA: 0x1B8D338
	public void BattleWait(bool isBattleWait) { }

	// RVA: 0x1B8D174 Offset: 0x1B89174 VA: 0x1B8D174
	private void NextMove() { }

	// RVA: 0x1B8D070 Offset: 0x1B89070 VA: 0x1B8D070
	private static bool CheckFloor(Vector3 pos, float distance) { }

	// RVA: 0x1B8D370 Offset: 0x1B89370 VA: 0x1B8D370
	private static Vector3 GetNextPosition(Vector3 center) { }

	// RVA: 0x1B8D3BC Offset: 0x1B893BC VA: 0x1B8D3BC
	public void .ctor() { }
}
