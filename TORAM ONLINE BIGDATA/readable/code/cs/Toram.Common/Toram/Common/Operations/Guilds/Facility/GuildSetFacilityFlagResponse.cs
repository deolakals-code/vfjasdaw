// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Facility
public class GuildSetFacilityFlagResponse : OperationResponseBase // TypeDefIndex: 12439
{
	// Fields
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 20)]
	public bool IsActive { get; set; }
	[PacketClass(Code = 2)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3608540 Offset: 0x3604540 VA: 0x3608540
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3608548 Offset: 0x3604548 VA: 0x3608548
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x3608550 Offset: 0x3604550 VA: 0x3608550
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x360855C Offset: 0x360455C VA: 0x360855C
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3608564 Offset: 0x3604564 VA: 0x3608564
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x360856C Offset: 0x360456C VA: 0x360856C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3608574 Offset: 0x3604574 VA: 0x3608574 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360857C Offset: 0x360457C VA: 0x360857C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3608744 Offset: 0x3604744 VA: 0x3608744 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
