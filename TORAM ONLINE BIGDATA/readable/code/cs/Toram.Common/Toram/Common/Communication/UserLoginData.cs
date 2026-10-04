// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class UserLoginData : PacketBase // TypeDefIndex: 12980
{
	// Fields
	[CompilerGenerated]
	private FriendLoginData <FriendLogin>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildLoginData <GuildLogin>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildReserveData[] <GuildReserve>k__BackingField; // 0x30

	// Properties
	public FriendLoginData FriendLogin { get; set; }
	public GuildLoginData GuildLogin { get; set; }
	public GuildReserveData[] GuildReserve { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3686A10 Offset: 0x3682A10 VA: 0x3686A10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3686A18 Offset: 0x3682A18 VA: 0x3686A18
	public FriendLoginData get_FriendLogin() { }

	[CompilerGenerated]
	// RVA: 0x3686A20 Offset: 0x3682A20 VA: 0x3686A20
	public void set_FriendLogin(FriendLoginData value) { }

	[CompilerGenerated]
	// RVA: 0x3686A28 Offset: 0x3682A28 VA: 0x3686A28
	public GuildLoginData get_GuildLogin() { }

	[CompilerGenerated]
	// RVA: 0x3686A30 Offset: 0x3682A30 VA: 0x3686A30
	public void set_GuildLogin(GuildLoginData value) { }

	[CompilerGenerated]
	// RVA: 0x3686A38 Offset: 0x3682A38 VA: 0x3686A38
	public GuildReserveData[] get_GuildReserve() { }

	[CompilerGenerated]
	// RVA: 0x3686A40 Offset: 0x3682A40 VA: 0x3686A40
	public void set_GuildReserve(GuildReserveData[] value) { }

	// RVA: 0x3686A48 Offset: 0x3682A48 VA: 0x3686A48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3686A50 Offset: 0x3682A50 VA: 0x3686A50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3686D6C Offset: 0x3682D6C VA: 0x3686D6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
