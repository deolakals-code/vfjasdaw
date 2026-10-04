// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeActionEvent : PacketBase // TypeDefIndex: 12613
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private ActionData <ActionData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketClass(Code = 75, IsOptional = True)]
	public ActionData ActionData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3630720 Offset: 0x362C720 VA: 0x3630720
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3630728 Offset: 0x362C728 VA: 0x3630728
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3630730 Offset: 0x362C730 VA: 0x3630730
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3630738 Offset: 0x362C738 VA: 0x3630738
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3630740 Offset: 0x362C740 VA: 0x3630740
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3630748 Offset: 0x362C748 VA: 0x3630748
	public ActionData get_ActionData() { }

	[CompilerGenerated]
	// RVA: 0x3630750 Offset: 0x362C750 VA: 0x3630750
	public void set_ActionData(ActionData value) { }

	// RVA: 0x3630758 Offset: 0x362C758 VA: 0x3630758
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3630878 Offset: 0x362C878 VA: 0x3630878
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36308F4 Offset: 0x362C8F4 VA: 0x36308F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36308FC Offset: 0x362C8FC VA: 0x36308FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3630AD0 Offset: 0x362CAD0 VA: 0x3630AD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
