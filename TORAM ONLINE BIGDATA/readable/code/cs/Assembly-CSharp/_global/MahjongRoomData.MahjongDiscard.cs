// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongDiscard : MahjongDiscardExplain, IReconnectionReceiveResponse, IReconnectionSubData // TypeDefIndex: 2369
{
	// Fields
	private MahjongRoomData roomData; // 0x30
	private bool isWhiteMagic; // 0x38
	private bool isDestinyDraw; // 0x39
	private bool isKakukan; // 0x3A
	private bool isStickyFingers; // 0x3B
	private bool isGraffiti; // 0x3C

	// Methods

	// RVA: 0x219CB28 Offset: 0x2198B28 VA: 0x219CB28
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, MahjongRoomData roomData) { }

	// RVA: 0x219C928 Offset: 0x2198928 VA: 0x219C928
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, bool isWhiteMagic, MahjongRoomData roomData) { }

	// RVA: 0x219C990 Offset: 0x2198990 VA: 0x219C990
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, int destinyDrawId, MahjongRoomData roomData) { }

	// RVA: 0x219C9F4 Offset: 0x21989F4 VA: 0x219C9F4
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, bool isKakukan, MahjongRoomData roomData, bool hoge) { }

	// RVA: 0x219CA5C Offset: 0x2198A5C VA: 0x219CA5C
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, int sfPickUpUid, int sfDiscardUid, MahjongRoomData roomData) { }

	// RVA: 0x219CAC4 Offset: 0x2198AC4 VA: 0x219CAC4
	public void .ctor(int uid, bool isRiichi, bool isKyushukyuhai, int graffitiId, MahjongRoomData roomData, bool hoge) { }

	// RVA: 0x219E808 Offset: 0x219A808 VA: 0x219E808 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219E848 Offset: 0x219A848 VA: 0x219E848 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219E878 Offset: 0x219A878 VA: 0x219E878 Slot: 15
	protected override void OnNotMatch() { }

	// RVA: 0x219E8A8 Offset: 0x219A8A8 VA: 0x219E8A8 Slot: 14
	protected override void OnNotMyTurn() { }

	// RVA: 0x219E8D8 Offset: 0x219A8D8 VA: 0x219E8D8 Slot: 13
	protected override void OnNotStart() { }

	// RVA: 0x219E908 Offset: 0x219A908 VA: 0x219E908 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219E9E4 Offset: 0x219A9E4 VA: 0x219E9E4 Slot: 11
	protected override void OnSystemLock() { }
}
