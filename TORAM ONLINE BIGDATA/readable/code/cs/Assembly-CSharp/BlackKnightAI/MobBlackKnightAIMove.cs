// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public class MobBlackKnightAIMove : MobBlackKnightActionBase // TypeDefIndex: 9092
{
	// Fields
	private bool playerTarget; // 0x20
	private float[] correspondingValues; // 0x28
	private bool IsBoss; // 0x30
	private bool IsBranchAction; // 0x31

	// Methods

	// RVA: 0x1EAB878 Offset: 0x1EA7878 VA: 0x1EAB878
	public void .ctor(IBlackBoardMemory memory) { }

	// RVA: 0x1EAB8B4 Offset: 0x1EA78B4 VA: 0x1EAB8B4
	public void .ctor(IBlackBoardMemory memory, float goalTarget) { }

	// RVA: 0x1EAB960 Offset: 0x1EA7960 VA: 0x1EAB960
	public void .ctor(IBlackBoardMemory memory, float actionRange, bool isBoss) { }

	// RVA: 0x1EABA14 Offset: 0x1EA7A14 VA: 0x1EABA14
	public void .ctor(IBlackBoardMemory memory, float pointDistance, float motionId, float flg) { }

	// RVA: 0x1EABAEC Offset: 0x1EA7AEC VA: 0x1EABAEC Slot: 7
	protected override void MainAction() { }

	// RVA: 0x1EABD24 Offset: 0x1EA7D24 VA: 0x1EABD24
	private float CalcPlayyerToMoveRangePos(float playerToDistance) { }
}
