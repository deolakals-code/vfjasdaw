// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class LoginFieldResponse : PacketBase // TypeDefIndex: 11551
{
	// Fields
	[CompilerGenerated]
	private PositionData <AvatarPosition>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildHomeData <GuildHomeData>k__BackingField; // 0x28
	[CompilerGenerated]
	private HouseReadOnlyData <HouseData>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x38
	[CompilerGenerated]
	private LoginRoomDataBase <LoginRoomData>k__BackingField; // 0x40
	[CompilerGenerated]
	private HideSeekData[] <HideSeekList>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <IsNeedWater>k__BackingField; // 0x54

	// Properties
	public PositionData AvatarPosition { get; set; }
	public GuildHomeData GuildHomeData { get; set; }
	public HouseReadOnlyData HouseData { get; set; }
	public byte RoomType { get; set; }
	public LoginRoomDataBase LoginRoomData { get; set; }
	public HideSeekData[] HideSeekList { get; set; }
	public int WorldId { get; set; }
	public bool IsNeedWater { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37188D8 Offset: 0x37148D8 VA: 0x37188D8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37188E0 Offset: 0x37148E0 VA: 0x37188E0
	public PositionData get_AvatarPosition() { }

	[CompilerGenerated]
	// RVA: 0x37188E8 Offset: 0x37148E8 VA: 0x37188E8
	public void set_AvatarPosition(PositionData value) { }

	[CompilerGenerated]
	// RVA: 0x37188F0 Offset: 0x37148F0 VA: 0x37188F0
	public GuildHomeData get_GuildHomeData() { }

	[CompilerGenerated]
	// RVA: 0x37188F8 Offset: 0x37148F8 VA: 0x37188F8
	public void set_GuildHomeData(GuildHomeData value) { }

	[CompilerGenerated]
	// RVA: 0x3718900 Offset: 0x3714900 VA: 0x3718900
	public HouseReadOnlyData get_HouseData() { }

	[CompilerGenerated]
	// RVA: 0x3718908 Offset: 0x3714908 VA: 0x3718908
	public void set_HouseData(HouseReadOnlyData value) { }

	[CompilerGenerated]
	// RVA: 0x3718910 Offset: 0x3714910 VA: 0x3718910
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x3718918 Offset: 0x3714918 VA: 0x3718918
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3718920 Offset: 0x3714920 VA: 0x3718920
	public LoginRoomDataBase get_LoginRoomData() { }

	[CompilerGenerated]
	// RVA: 0x3718928 Offset: 0x3714928 VA: 0x3718928
	public void set_LoginRoomData(LoginRoomDataBase value) { }

	[CompilerGenerated]
	// RVA: 0x3718930 Offset: 0x3714930 VA: 0x3718930
	public HideSeekData[] get_HideSeekList() { }

	[CompilerGenerated]
	// RVA: 0x3718938 Offset: 0x3714938 VA: 0x3718938
	public void set_HideSeekList(HideSeekData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3718940 Offset: 0x3714940 VA: 0x3718940
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x3718948 Offset: 0x3714948 VA: 0x3718948
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3718950 Offset: 0x3714950 VA: 0x3718950
	public bool get_IsNeedWater() { }

	[CompilerGenerated]
	// RVA: 0x3718958 Offset: 0x3714958 VA: 0x3718958
	public void set_IsNeedWater(bool value) { }

	// RVA: 0x3718964 Offset: 0x3714964 VA: 0x3718964 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371896C Offset: 0x371496C VA: 0x371896C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719044 Offset: 0x3715044 VA: 0x3719044 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
