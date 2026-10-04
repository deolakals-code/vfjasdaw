// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildEndChangeStaffData : OperationRequestBase // TypeDefIndex: 12363
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private NewStyleData <NewStyleData>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, int> <ChangeEquipData>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildStaffEquipData[] <EquipData>k__BackingField; // 0x40

	// Properties
	public byte Type { get; set; }
	public string Name { get; set; }
	public NewStyleData NewStyleData { get; set; }
	public Dictionary<byte, int> ChangeEquipData { get; set; }
	public GuildStaffEquipData[] EquipData { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FAE44 Offset: 0x35F6E44 VA: 0x35FAE44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FAE4C Offset: 0x35F6E4C VA: 0x35FAE4C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35FAE54 Offset: 0x35F6E54 VA: 0x35FAE54
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FAE5C Offset: 0x35F6E5C VA: 0x35FAE5C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x35FAE64 Offset: 0x35F6E64 VA: 0x35FAE64
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FAE6C Offset: 0x35F6E6C VA: 0x35FAE6C
	public NewStyleData get_NewStyleData() { }

	[CompilerGenerated]
	// RVA: 0x35FAE74 Offset: 0x35F6E74 VA: 0x35FAE74
	public void set_NewStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x35FAE7C Offset: 0x35F6E7C VA: 0x35FAE7C
	public Dictionary<byte, int> get_ChangeEquipData() { }

	[CompilerGenerated]
	// RVA: 0x35FAE84 Offset: 0x35F6E84 VA: 0x35FAE84
	public void set_ChangeEquipData(Dictionary<byte, int> value) { }

	[CompilerGenerated]
	// RVA: 0x35FAE8C Offset: 0x35F6E8C VA: 0x35FAE8C
	public GuildStaffEquipData[] get_EquipData() { }

	[CompilerGenerated]
	// RVA: 0x35FAE94 Offset: 0x35F6E94 VA: 0x35FAE94
	public void set_EquipData(GuildStaffEquipData[] value) { }

	// RVA: 0x35FAE9C Offset: 0x35F6E9C VA: 0x35FAE9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FAEA4 Offset: 0x35F6EA4 VA: 0x35FAEA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FAEAC Offset: 0x35F6EAC VA: 0x35FAEAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FAFDC Offset: 0x35F6FDC VA: 0x35FAFDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
