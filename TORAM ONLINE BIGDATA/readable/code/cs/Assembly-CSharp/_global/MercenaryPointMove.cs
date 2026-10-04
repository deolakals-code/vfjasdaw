// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryPointMove : MercenaryAIStateBase // TypeDefIndex: 632
{
	// Fields
	private Vector3 target; // 0x30
	private float range; // 0x3C
	private float timer; // 0x40
	private float sizeOffset; // 0x44
	[CompilerGenerated]
	private Action<IAICentral> TurnEndCallback; // 0x48

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E1AAC Offset: 0x19DDAAC VA: 0x19E1AAC
	public void add_TurnEndCallback(Action<IAICentral> value) { }

	[CompilerGenerated]
	// RVA: 0x19E3560 Offset: 0x19DF560 VA: 0x19E3560
	public void remove_TurnEndCallback(Action<IAICentral> value) { }

	// RVA: 0x19E1A40 Offset: 0x19DDA40 VA: 0x19E1A40
	public void Initialize(Vector3 target, float range, float timer, float sizeOffset) { }

	// RVA: 0x19E3610 Offset: 0x19DF610 VA: 0x19E3610 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E3614 Offset: 0x19DF614 VA: 0x19E3614 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E3618 Offset: 0x19DF618 VA: 0x19E3618 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E361C Offset: 0x19DF61C VA: 0x19E361C Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryPointMove.<GetState>d__12))]
	// RVA: 0x19E3638 Offset: 0x19DF638 VA: 0x19E3638 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E36CC Offset: 0x19DF6CC VA: 0x19E36CC
	public void .ctor() { }
}
