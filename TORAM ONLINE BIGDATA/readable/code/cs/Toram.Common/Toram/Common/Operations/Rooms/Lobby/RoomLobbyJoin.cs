// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbyJoin : OperationRequestBase // TypeDefIndex: 11774
{
	// Fields
	[CompilerGenerated]
	private byte[] <BonusList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <SupportItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <SupportOrbItemList>k__BackingField; // 0x30

	// Properties
	public byte[] BonusList { get; set; }
	public int[] SupportItemList { get; set; }
	public int[] SupportOrbItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3747F94 Offset: 0x3743F94 VA: 0x3747F94
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3747F9C Offset: 0x3743F9C VA: 0x3747F9C
	public byte[] get_BonusList() { }

	[CompilerGenerated]
	// RVA: 0x3747FA4 Offset: 0x3743FA4 VA: 0x3747FA4
	public void set_BonusList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747FAC Offset: 0x3743FAC VA: 0x3747FAC
	public int[] get_SupportItemList() { }

	[CompilerGenerated]
	// RVA: 0x3747FB4 Offset: 0x3743FB4 VA: 0x3747FB4
	public void set_SupportItemList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747FBC Offset: 0x3743FBC VA: 0x3747FBC
	public int[] get_SupportOrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3747FC4 Offset: 0x3743FC4 VA: 0x3747FC4
	public void set_SupportOrbItemList(int[] value) { }

	// RVA: 0x3747FCC Offset: 0x3743FCC VA: 0x3747FCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3747FD4 Offset: 0x3743FD4 VA: 0x3747FD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3747FDC Offset: 0x3743FDC VA: 0x3747FDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3748238 Offset: 0x3744238 VA: 0x3748238 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
