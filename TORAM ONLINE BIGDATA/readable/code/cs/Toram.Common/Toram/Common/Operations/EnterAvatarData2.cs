// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public class EnterAvatarData2 : PacketBase, IAccountUserData // TypeDefIndex: 11368
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <AccountLevel>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ServerFPS>k__BackingField; // 0x32
	[CompilerGenerated]
	private Dictionary<byte, object> <ArchetypeProperties>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x40
	[CompilerGenerated]
	private EnterAvatarData2.ParamPack <Param>k__BackingField; // 0x48
	[CompilerGenerated]
	private FieldData <FieldData>k__BackingField; // 0x50
	[CompilerGenerated]
	private AreaPopData <AreaPop>k__BackingField; // 0x58
	[CompilerGenerated]
	private PositionData <AvatarPosition>k__BackingField; // 0x60
	[CompilerGenerated]
	private EnterAvatarData2.AvatarPack <Avatar>k__BackingField; // 0x68
	[CompilerGenerated]
	private PetEnterData <PetEnterData>k__BackingField; // 0x70
	[CompilerGenerated]
	private EnterAvatarData2.GuildPack <Guild>k__BackingField; // 0x78
	[CompilerGenerated]
	private EnterAvatarData2.HousePack <House>k__BackingField; // 0x80
	[CompilerGenerated]
	private OffenderData[] <OffenderList>k__BackingField; // 0x88
	[CompilerGenerated]
	private LoginTermFlag <LoginTermFlag>k__BackingField; // 0x90
	[CompilerGenerated]
	private DateTime <BanWordDate>k__BackingField; // 0x98
	[CompilerGenerated]
	private bool <IsAsobiMarket>k__BackingField; // 0xA0
	[CompilerGenerated]
	private AvatarOptionDataBase[] <OptionList>k__BackingField; // 0xA8

	// Properties
	public int AvatarUuid { get; set; }
	public string Name { get; set; }
	public short AccountLevel { get; set; }
	public short ServerFPS { get; set; }
	public Dictionary<byte, object> ArchetypeProperties { get; set; }
	public int PropertiesRevision { get; set; }
	public EnterAvatarData2.ParamPack Param { get; set; }
	public FieldData FieldData { get; set; }
	public AreaPopData AreaPop { get; set; }
	public PositionData AvatarPosition { get; set; }
	public EnterAvatarData2.AvatarPack Avatar { get; set; }
	public PetEnterData PetEnterData { get; set; }
	public EnterAvatarData2.GuildPack Guild { get; set; }
	public EnterAvatarData2.HousePack House { get; set; }
	public OffenderData[] OffenderList { get; set; }
	public LoginTermFlag LoginTermFlag { get; set; }
	public DateTime BanWordDate { get; set; }
	public bool IsAsobiMarket { get; set; }
	public AvatarOptionDataBase[] OptionList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36F336C Offset: 0x36EF36C VA: 0x36F336C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F3374 Offset: 0x36EF374 VA: 0x36F3374 Slot: 7
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36F337C Offset: 0x36EF37C VA: 0x36F337C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F3384 Offset: 0x36EF384 VA: 0x36F3384 Slot: 8
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36F338C Offset: 0x36EF38C VA: 0x36F338C
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x36F3394 Offset: 0x36EF394 VA: 0x36F3394 Slot: 9
	public short get_AccountLevel() { }

	[CompilerGenerated]
	// RVA: 0x36F339C Offset: 0x36EF39C VA: 0x36F339C
	public void set_AccountLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F33A4 Offset: 0x36EF3A4 VA: 0x36F33A4 Slot: 10
	public short get_ServerFPS() { }

	[CompilerGenerated]
	// RVA: 0x36F33AC Offset: 0x36EF3AC VA: 0x36F33AC
	public void set_ServerFPS(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F33B4 Offset: 0x36EF3B4 VA: 0x36F33B4
	public Dictionary<byte, object> get_ArchetypeProperties() { }

	[CompilerGenerated]
	// RVA: 0x36F33BC Offset: 0x36EF3BC VA: 0x36F33BC
	public void set_ArchetypeProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x36F33C4 Offset: 0x36EF3C4 VA: 0x36F33C4
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x36F33CC Offset: 0x36EF3CC VA: 0x36F33CC
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F33D4 Offset: 0x36EF3D4 VA: 0x36F33D4
	public EnterAvatarData2.ParamPack get_Param() { }

	[CompilerGenerated]
	// RVA: 0x36F33DC Offset: 0x36EF3DC VA: 0x36F33DC
	public void set_Param(EnterAvatarData2.ParamPack value) { }

	[CompilerGenerated]
	// RVA: 0x36F33E4 Offset: 0x36EF3E4 VA: 0x36F33E4
	public FieldData get_FieldData() { }

	[CompilerGenerated]
	// RVA: 0x36F33EC Offset: 0x36EF3EC VA: 0x36F33EC
	public void set_FieldData(FieldData value) { }

	[CompilerGenerated]
	// RVA: 0x36F33F4 Offset: 0x36EF3F4 VA: 0x36F33F4
	public AreaPopData get_AreaPop() { }

	[CompilerGenerated]
	// RVA: 0x36F33FC Offset: 0x36EF3FC VA: 0x36F33FC
	public void set_AreaPop(AreaPopData value) { }

	[CompilerGenerated]
	// RVA: 0x36F3404 Offset: 0x36EF404 VA: 0x36F3404
	public PositionData get_AvatarPosition() { }

	[CompilerGenerated]
	// RVA: 0x36F340C Offset: 0x36EF40C VA: 0x36F340C
	public void set_AvatarPosition(PositionData value) { }

	[CompilerGenerated]
	// RVA: 0x36F3414 Offset: 0x36EF414 VA: 0x36F3414
	public EnterAvatarData2.AvatarPack get_Avatar() { }

	[CompilerGenerated]
	// RVA: 0x36F341C Offset: 0x36EF41C VA: 0x36F341C
	public void set_Avatar(EnterAvatarData2.AvatarPack value) { }

	[CompilerGenerated]
	// RVA: 0x36F3424 Offset: 0x36EF424 VA: 0x36F3424
	public PetEnterData get_PetEnterData() { }

	[CompilerGenerated]
	// RVA: 0x36F342C Offset: 0x36EF42C VA: 0x36F342C
	public void set_PetEnterData(PetEnterData value) { }

	[CompilerGenerated]
	// RVA: 0x36F3434 Offset: 0x36EF434 VA: 0x36F3434
	public EnterAvatarData2.GuildPack get_Guild() { }

	[CompilerGenerated]
	// RVA: 0x36F343C Offset: 0x36EF43C VA: 0x36F343C
	public void set_Guild(EnterAvatarData2.GuildPack value) { }

	[CompilerGenerated]
	// RVA: 0x36F3444 Offset: 0x36EF444 VA: 0x36F3444
	public EnterAvatarData2.HousePack get_House() { }

	[CompilerGenerated]
	// RVA: 0x36F344C Offset: 0x36EF44C VA: 0x36F344C
	public void set_House(EnterAvatarData2.HousePack value) { }

	[CompilerGenerated]
	// RVA: 0x36F3454 Offset: 0x36EF454 VA: 0x36F3454 Slot: 13
	public OffenderData[] get_OffenderList() { }

	[CompilerGenerated]
	// RVA: 0x36F345C Offset: 0x36EF45C VA: 0x36F345C
	public void set_OffenderList(OffenderData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F3464 Offset: 0x36EF464 VA: 0x36F3464 Slot: 11
	public LoginTermFlag get_LoginTermFlag() { }

	[CompilerGenerated]
	// RVA: 0x36F346C Offset: 0x36EF46C VA: 0x36F346C
	public void set_LoginTermFlag(LoginTermFlag value) { }

	[CompilerGenerated]
	// RVA: 0x36F3474 Offset: 0x36EF474 VA: 0x36F3474 Slot: 14
	public DateTime get_BanWordDate() { }

	[CompilerGenerated]
	// RVA: 0x36F347C Offset: 0x36EF47C VA: 0x36F347C
	public void set_BanWordDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36F3484 Offset: 0x36EF484 VA: 0x36F3484 Slot: 12
	public bool get_IsAsobiMarket() { }

	[CompilerGenerated]
	// RVA: 0x36F348C Offset: 0x36EF48C VA: 0x36F348C
	public void set_IsAsobiMarket(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36F3498 Offset: 0x36EF498 VA: 0x36F3498
	public AvatarOptionDataBase[] get_OptionList() { }

	[CompilerGenerated]
	// RVA: 0x36F34A0 Offset: 0x36EF4A0 VA: 0x36F34A0
	public void set_OptionList(AvatarOptionDataBase[] value) { }

	// RVA: 0x36F34A8 Offset: 0x36EF4A8 VA: 0x36F34A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36F34B0 Offset: 0x36EF4B0 VA: 0x36F34B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36F38E4 Offset: 0x36EF8E4 VA: 0x36F38E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
