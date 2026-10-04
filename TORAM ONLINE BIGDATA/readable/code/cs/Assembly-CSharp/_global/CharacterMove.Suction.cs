// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CharacterMove.Suction // TypeDefIndex: 547
{
	// Fields
	private readonly CharacterMove charaMove; // 0x10
	private readonly byte localId; // 0x18
	private const float StopRange = 0.5;
	private Vector3 suctionPos; // 0x1C
	private Vector3 suctionDir; // 0x28
	private float suctionRange; // 0x34
	private float suctionPower1; // 0x38
	private float suctionPower2; // 0x3C
	private float suctionDistance; // 0x40
	private float suctionProgressDistance; // 0x44
	private float suctionMoveTime; // 0x48
	private float suctionProgressTime; // 0x4C
	private CharacterMove.TimeFlag suctionMoveTimeFlag; // 0x50
	private Action suctionEndAction; // 0x58
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x60

	// Properties
	public bool IsEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18F19EC Offset: 0x18ED9EC VA: 0x18F19EC
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x18F19F4 Offset: 0x18ED9F4 VA: 0x18F19F4
	private void set_IsEnd(bool value) { }

	// RVA: 0x18F1A00 Offset: 0x18EDA00 VA: 0x18F1A00
	public void .ctor(CharacterMove charaMove, byte localId, Vector3 pos, float time, float distance, float range, bool slowStart, bool slowEnd, Action endCallback) { }

	// RVA: 0x18F1B0C Offset: 0x18EDB0C VA: 0x18F1B0C
	public Vector3 CalcMove(Vector3 targetPos) { }

	// RVA: 0x18F1DD0 Offset: 0x18EDDD0 VA: 0x18F1DD0
	public void Stop() { }

	// RVA: 0x18F1DF0 Offset: 0x18EDDF0 VA: 0x18F1DF0
	public bool CheckSuction(Vector3 targetPos) { }

	// RVA: 0x18F1CBC Offset: 0x18EDCBC VA: 0x18F1CBC
	private void EndSuction() { }

	// RVA: 0x18F1D68 Offset: 0x18EDD68 VA: 0x18F1D68
	private float CalcSuctionTimeMove() { }
}
