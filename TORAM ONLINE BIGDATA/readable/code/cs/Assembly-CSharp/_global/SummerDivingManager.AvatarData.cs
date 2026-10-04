// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SummerDivingManager.AvatarData : MiniGameAvatarBase // TypeDefIndex: 4546
{
	// Fields
	private bool isMove; // 0x20
	private float moveSpeed; // 0x24
	private float moveTime; // 0x28
	private float moveEndTime; // 0x2C
	private Vector3 dir; // 0x30
	private Action moveEndFunc; // 0x40

	// Methods

	// RVA: 0x251E728 Offset: 0x251A728 VA: 0x251E728
	public void .ctor(int id) { }

	// RVA: 0x2521950 Offset: 0x251D950 VA: 0x2521950
	public void Update() { }

	// RVA: 0x2521A58 Offset: 0x251DA58 VA: 0x2521A58
	public void Move(float speed, float time, Vector3 dir, Action endFunc) { }
}
