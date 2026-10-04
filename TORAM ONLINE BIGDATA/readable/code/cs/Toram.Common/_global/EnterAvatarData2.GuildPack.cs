// Assembly: Toram.Common.dll
// Namespace: 
public class EnterAvatarData2.GuildPack : PacketBase, IGuildGameData, IGuildBufferData // TypeDefIndex: 11366
{
	// Fields
	[CompilerGenerated]
	private byte <BoostType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <BoostRate>k__BackingField; // 0x24
	[CompilerGenerated]
	private GuildStaffHireData <StaffHireData>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildFacilityData[] <FacilityBuffList>k__BackingField; // 0x30

	// Properties
	public byte BoostType { get; set; }
	public int BoostRate { get; set; }
	public GuildStaffHireData StaffHireData { get; set; }
	public GuildFacilityData[] FacilityBuffList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36F4438 Offset: 0x36F0438 VA: 0x36F4438
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F594C Offset: 0x36F194C VA: 0x36F594C Slot: 8
	public byte get_BoostType() { }

	[CompilerGenerated]
	// RVA: 0x36F5954 Offset: 0x36F1954 VA: 0x36F5954
	public void set_BoostType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F595C Offset: 0x36F195C VA: 0x36F595C Slot: 9
	public int get_BoostRate() { }

	[CompilerGenerated]
	// RVA: 0x36F5964 Offset: 0x36F1964 VA: 0x36F5964
	public void set_BoostRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F596C Offset: 0x36F196C VA: 0x36F596C Slot: 7
	public GuildStaffHireData get_StaffHireData() { }

	[CompilerGenerated]
	// RVA: 0x36F5974 Offset: 0x36F1974 VA: 0x36F5974
	public void set_StaffHireData(GuildStaffHireData value) { }

	[CompilerGenerated]
	// RVA: 0x36F597C Offset: 0x36F197C VA: 0x36F597C Slot: 10
	public GuildFacilityData[] get_FacilityBuffList() { }

	[CompilerGenerated]
	// RVA: 0x36F5984 Offset: 0x36F1984 VA: 0x36F5984
	public void set_FacilityBuffList(GuildFacilityData[] value) { }

	// RVA: 0x36F598C Offset: 0x36F198C VA: 0x36F598C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36F5994 Offset: 0x36F1994 VA: 0x36F5994 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36F5B04 Offset: 0x36F1B04 VA: 0x36F5B04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
