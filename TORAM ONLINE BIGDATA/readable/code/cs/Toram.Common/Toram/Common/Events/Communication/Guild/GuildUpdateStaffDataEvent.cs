// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildUpdateStaffDataEvent : PacketBase // TypeDefIndex: 12909
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UpdateMemberId>k__BackingField; // 0x24
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <UpdateStyleMemberId>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <UpdateStyleDate>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <UpdateEquipMemberId>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTime <UpdateEquipDate>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x50
	[CompilerGenerated]
	private NewStyleData <NewStyleData>k__BackingField; // 0x58
	[CompilerGenerated]
	private GuildStaffEquipData[] <EquipData>k__BackingField; // 0x60

	// Properties
	public int GuildId { get; set; }
	public int UpdateMemberId { get; set; }
	public DateTime UpdateDate { get; set; }
	public int UpdateStyleMemberId { get; set; }
	public DateTime UpdateStyleDate { get; set; }
	public int UpdateEquipMemberId { get; set; }
	public DateTime UpdateEquipDate { get; set; }
	public string Name { get; set; }
	public NewStyleData NewStyleData { get; set; }
	public GuildStaffEquipData[] EquipData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3674DE4 Offset: 0x3670DE4 VA: 0x3674DE4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3674DEC Offset: 0x3670DEC VA: 0x3674DEC
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3674DF4 Offset: 0x3670DF4 VA: 0x3674DF4
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3674DFC Offset: 0x3670DFC VA: 0x3674DFC
	public int get_UpdateMemberId() { }

	[CompilerGenerated]
	// RVA: 0x3674E04 Offset: 0x3670E04 VA: 0x3674E04
	public void set_UpdateMemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3674E0C Offset: 0x3670E0C VA: 0x3674E0C
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x3674E14 Offset: 0x3670E14 VA: 0x3674E14
	public void set_UpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3674E1C Offset: 0x3670E1C VA: 0x3674E1C
	public int get_UpdateStyleMemberId() { }

	[CompilerGenerated]
	// RVA: 0x3674E24 Offset: 0x3670E24 VA: 0x3674E24
	public void set_UpdateStyleMemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3674E2C Offset: 0x3670E2C VA: 0x3674E2C
	public DateTime get_UpdateStyleDate() { }

	[CompilerGenerated]
	// RVA: 0x3674E34 Offset: 0x3670E34 VA: 0x3674E34
	public void set_UpdateStyleDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3674E3C Offset: 0x3670E3C VA: 0x3674E3C
	public int get_UpdateEquipMemberId() { }

	[CompilerGenerated]
	// RVA: 0x3674E44 Offset: 0x3670E44 VA: 0x3674E44
	public void set_UpdateEquipMemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3674E4C Offset: 0x3670E4C VA: 0x3674E4C
	public DateTime get_UpdateEquipDate() { }

	[CompilerGenerated]
	// RVA: 0x3674E54 Offset: 0x3670E54 VA: 0x3674E54
	public void set_UpdateEquipDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3674E5C Offset: 0x3670E5C VA: 0x3674E5C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3674E64 Offset: 0x3670E64 VA: 0x3674E64
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3674E6C Offset: 0x3670E6C VA: 0x3674E6C
	public NewStyleData get_NewStyleData() { }

	[CompilerGenerated]
	// RVA: 0x3674E74 Offset: 0x3670E74 VA: 0x3674E74
	public void set_NewStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x3674E7C Offset: 0x3670E7C VA: 0x3674E7C
	public GuildStaffEquipData[] get_EquipData() { }

	[CompilerGenerated]
	// RVA: 0x3674E84 Offset: 0x3670E84 VA: 0x3674E84
	public void set_EquipData(GuildStaffEquipData[] value) { }

	// RVA: 0x3674E8C Offset: 0x3670E8C VA: 0x3674E8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3674E94 Offset: 0x3670E94 VA: 0x3674E94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3675440 Offset: 0x3671440 VA: 0x3675440 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
