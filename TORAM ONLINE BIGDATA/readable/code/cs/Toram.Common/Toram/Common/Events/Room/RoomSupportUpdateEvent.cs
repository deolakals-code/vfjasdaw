// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomSupportUpdateEvent : PacketBase // TypeDefIndex: 12753
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomSupportUseData[] <SupportList>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <TargetUniqueIds>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <EntreeStagingFlag>k__BackingField; // 0x40

	// Properties
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public RoomSupportUseData[] SupportList { get; set; }
	public int[] TargetUniqueIds { get; set; }
	public bool EntreeStagingFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3650EE4 Offset: 0x364CEE4 VA: 0x3650EE4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3650EEC Offset: 0x364CEEC VA: 0x3650EEC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3650EF4 Offset: 0x364CEF4 VA: 0x3650EF4
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3650EFC Offset: 0x364CEFC VA: 0x3650EFC
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3650F04 Offset: 0x364CF04 VA: 0x3650F04
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3650F0C Offset: 0x364CF0C VA: 0x3650F0C
	public RoomSupportUseData[] get_SupportList() { }

	[CompilerGenerated]
	// RVA: 0x3650F14 Offset: 0x364CF14 VA: 0x3650F14
	public void set_SupportList(RoomSupportUseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3650F1C Offset: 0x364CF1C VA: 0x3650F1C
	public int[] get_TargetUniqueIds() { }

	[CompilerGenerated]
	// RVA: 0x3650F24 Offset: 0x364CF24 VA: 0x3650F24
	public void set_TargetUniqueIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3650F2C Offset: 0x364CF2C VA: 0x3650F2C
	public bool get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x3650F34 Offset: 0x364CF34 VA: 0x3650F34
	public void set_EntreeStagingFlag(bool value) { }

	// RVA: 0x3650F40 Offset: 0x364CF40 VA: 0x3650F40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3650F48 Offset: 0x364CF48 VA: 0x3650F48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3651254 Offset: 0x364D254 VA: 0x3651254 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
