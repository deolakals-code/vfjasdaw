// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameJoinResponse : OperationResponseBase // TypeDefIndex: 12271
{
	// Fields
	[CompilerGenerated]
	private CardGameSettingData <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private CardGameMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TableOwnerId>k__BackingField; // 0x30

	// Properties
	public CardGameSettingData Setting { get; set; }
	public CardGameMemberData[] Members { get; set; }
	public int TableOwnerId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E9EAC Offset: 0x35E5EAC VA: 0x35E9EAC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E9EB4 Offset: 0x35E5EB4 VA: 0x35E9EB4
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35E9EBC Offset: 0x35E5EBC VA: 0x35E9EBC
	public void set_Setting(CardGameSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x35E9EC4 Offset: 0x35E5EC4 VA: 0x35E9EC4
	public CardGameMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x35E9ECC Offset: 0x35E5ECC VA: 0x35E9ECC
	public void set_Members(CardGameMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35E9ED4 Offset: 0x35E5ED4 VA: 0x35E9ED4
	public int get_TableOwnerId() { }

	[CompilerGenerated]
	// RVA: 0x35E9EDC Offset: 0x35E5EDC VA: 0x35E9EDC
	public void set_TableOwnerId(int value) { }

	// RVA: 0x35E9EE4 Offset: 0x35E5EE4 VA: 0x35E9EE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E9EEC Offset: 0x35E5EEC VA: 0x35E9EEC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E9EF4 Offset: 0x35E5EF4 VA: 0x35E9EF4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EA1B0 Offset: 0x35E61B0 VA: 0x35EA1B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
