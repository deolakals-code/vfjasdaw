// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildRaidRoomData.RoomEscapeVoteExplainConnection : RoomEscapeVoteExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2339
{
	// Fields
	private GuildRaidRoomData room; // 0x10

	// Methods

	// RVA: 0x218F47C Offset: 0x218B47C VA: 0x218F47C
	public void .ctor(GuildRaidRoomData room) { }

	// RVA: 0x2190680 Offset: 0x218C680 VA: 0x2190680 Slot: 8
	public override void Reconnection(Game engine) { }

	// RVA: 0x2190684 Offset: 0x218C684 VA: 0x2190684 Slot: 11
	protected override void OnFailure() { }

	// RVA: 0x2190688 Offset: 0x218C688 VA: 0x2190688 Slot: 12
	protected override void OnErr_AlreadyExists() { }

	// RVA: 0x219069C Offset: 0x218C69C VA: 0x219069C Slot: 10
	protected override void OnSuccess() { }
}
