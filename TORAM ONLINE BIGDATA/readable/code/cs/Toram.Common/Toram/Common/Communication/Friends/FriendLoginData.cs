// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Friends
public class FriendLoginData : PacketBase // TypeDefIndex: 13014
{
	// Fields
	[CompilerGenerated]
	private int[] <FriendIdList>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <BinaryState>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <ApplyingIdList>k__BackingField; // 0x30
	[CompilerGenerated]
	private FriendReserveData[] <ReserveList>k__BackingField; // 0x38

	// Properties
	public int[] FriendIdList { get; set; }
	public byte BinaryState { get; set; }
	public int[] ApplyingIdList { get; set; }
	public FriendReserveData[] ReserveList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3686D5C Offset: 0x3682D5C VA: 0x3686D5C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x368DF8C Offset: 0x3689F8C VA: 0x368DF8C
	public int[] get_FriendIdList() { }

	[CompilerGenerated]
	// RVA: 0x368DF94 Offset: 0x3689F94 VA: 0x368DF94
	public void set_FriendIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x368DF9C Offset: 0x3689F9C VA: 0x368DF9C
	public byte get_BinaryState() { }

	[CompilerGenerated]
	// RVA: 0x368DFA4 Offset: 0x3689FA4 VA: 0x368DFA4
	public void set_BinaryState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368DFAC Offset: 0x3689FAC VA: 0x368DFAC
	public int[] get_ApplyingIdList() { }

	[CompilerGenerated]
	// RVA: 0x368DFB4 Offset: 0x3689FB4 VA: 0x368DFB4
	public void set_ApplyingIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x368DFBC Offset: 0x3689FBC VA: 0x368DFBC
	public FriendReserveData[] get_ReserveList() { }

	[CompilerGenerated]
	// RVA: 0x368DFC4 Offset: 0x3689FC4 VA: 0x368DFC4
	public void set_ReserveList(FriendReserveData[] value) { }

	// RVA: 0x368DFCC Offset: 0x3689FCC VA: 0x368DFCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x368DFD4 Offset: 0x3689FD4 VA: 0x368DFD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x368E358 Offset: 0x368A358 VA: 0x368E358 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
