// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public abstract class MobBlackKnightActionBase : IMobBlackKnightAction // TypeDefIndex: 9105
{
	// Fields
	private Action callback; // 0x10
	protected IBlackBoardMemory memory; // 0x18

	// Methods

	// RVA: 0x1EAB3FC Offset: 0x1EA73FC VA: 0x1EAB3FC
	public void .ctor(IBlackBoardMemory memory) { }

	// RVA: 0x1EAD508 Offset: 0x1EA9508 VA: 0x1EAD508 Slot: 5
	public void Action() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void MainAction();

	// RVA: 0x1EAD88C Offset: 0x1EA988C VA: 0x1EAD88C Slot: 4
	public void SetCallBackActionDone(Action callBack) { }

	// RVA: 0x1EAD894 Offset: 0x1EA9894 VA: 0x1EAD894 Slot: 8
	public virtual void ActionCancel() { }
}
