// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobImitationAI : MobAIBase // TypeDefIndex: 709
{
	// Fields
	private Vector3 center; // 0x40
	private float moveTime; // 0x4C
	private float nextActionTime; // 0x50
	private Vector3 lastPos; // 0x54
	private FadeAnimationManager fade; // 0x60
	private bool isForcingCenter; // 0x68
	private bool isBattleWait; // 0x69
	private int forcingCount; // 0x6C
	private float naturalMotionTime; // 0x70

	// Methods

	// RVA: 0x1B8C18C Offset: 0x1B8818C VA: 0x1B8C18C
	public void Initialize(Vector3 pos, bool isBattleWait) { }

	// RVA: 0x1B8C27C Offset: 0x1B8827C VA: 0x1B8C27C Slot: 6
	public override void AIUpdate() { }

	// RVA: 0x1B8C5A4 Offset: 0x1B885A4 VA: 0x1B8C5A4
	private int ForcingCenter(int count) { }

	// RVA: 0x1B8C708 Offset: 0x1B88708 VA: 0x1B8C708
	private bool IsDistanceApart(Vector3 p1, Vector3 p2, float distance) { }

	// RVA: 0x1B8C730 Offset: 0x1B88730 VA: 0x1B8C730
	public void .ctor() { }
}
