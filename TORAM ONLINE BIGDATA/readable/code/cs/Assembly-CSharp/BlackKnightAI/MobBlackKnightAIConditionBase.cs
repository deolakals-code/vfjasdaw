// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public abstract class MobBlackKnightAIConditionBase : MobBlackKnightActionBase // TypeDefIndex: 9100
{
	// Fields
	private MobBlackKnightActionBase action; // 0x20
	private bool inverseFlg; // 0x28
	private bool isConditionSuccess; // 0x29

	// Properties
	public bool IsConditionSuccess { get; }

	// Methods

	// RVA: 0x1EAD460 Offset: 0x1EA9460 VA: 0x1EAD460
	public bool get_IsConditionSuccess() { }

	// RVA: 0x1EAD14C Offset: 0x1EA914C VA: 0x1EAD14C
	public void .ctor(MobBlackKnightActionBase actionBase, IBlackBoardMemory memory, bool inverse) { }

	// RVA: 0x1EAD468 Offset: 0x1EA9468 VA: 0x1EAD468 Slot: 7
	protected override void MainAction() { }

	// RVA: 0x1EAD4E0 Offset: 0x1EA94E0 VA: 0x1EAD4E0
	private bool CheckInverse() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool CheckConditon();
}
