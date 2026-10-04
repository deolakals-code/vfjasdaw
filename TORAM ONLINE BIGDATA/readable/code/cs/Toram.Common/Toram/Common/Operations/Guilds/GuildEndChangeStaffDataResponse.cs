// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildEndChangeStaffDataResponse : OperationResponseBase // TypeDefIndex: 12364
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UpdateMemberId>k__BackingField; // 0x24
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x30
	[CompilerGenerated]
	private NewStyleData <NewStyleData>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildStaffEquipData[] <EquipData>k__BackingField; // 0x40

	// Properties
	public byte Type { get; set; }
	public int UpdateMemberId { get; set; }
	public DateTime UpdateDate { get; set; }
	public string Name { get; set; }
	public NewStyleData NewStyleData { get; set; }
	public GuildStaffEquipData[] EquipData { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FB378 Offset: 0x35F7378 VA: 0x35FB378
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FB380 Offset: 0x35F7380 VA: 0x35FB380
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35FB388 Offset: 0x35F7388 VA: 0x35FB388
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FB390 Offset: 0x35F7390 VA: 0x35FB390
	public int get_UpdateMemberId() { }

	[CompilerGenerated]
	// RVA: 0x35FB398 Offset: 0x35F7398 VA: 0x35FB398
	public void set_UpdateMemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FB3A0 Offset: 0x35F73A0 VA: 0x35FB3A0
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x35FB3A8 Offset: 0x35F73A8 VA: 0x35FB3A8
	public void set_UpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35FB3B0 Offset: 0x35F73B0 VA: 0x35FB3B0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x35FB3B8 Offset: 0x35F73B8 VA: 0x35FB3B8
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FB3C0 Offset: 0x35F73C0 VA: 0x35FB3C0
	public NewStyleData get_NewStyleData() { }

	[CompilerGenerated]
	// RVA: 0x35FB3C8 Offset: 0x35F73C8 VA: 0x35FB3C8
	public void set_NewStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x35FB3D0 Offset: 0x35F73D0 VA: 0x35FB3D0
	public GuildStaffEquipData[] get_EquipData() { }

	[CompilerGenerated]
	// RVA: 0x35FB3D8 Offset: 0x35F73D8 VA: 0x35FB3D8
	public void set_EquipData(GuildStaffEquipData[] value) { }

	// RVA: 0x35FB3E0 Offset: 0x35F73E0 VA: 0x35FB3E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FB3E8 Offset: 0x35F73E8 VA: 0x35FB3E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FB3F0 Offset: 0x35F73F0 VA: 0x35FB3F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FB5CC Offset: 0x35F75CC VA: 0x35FB5CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
