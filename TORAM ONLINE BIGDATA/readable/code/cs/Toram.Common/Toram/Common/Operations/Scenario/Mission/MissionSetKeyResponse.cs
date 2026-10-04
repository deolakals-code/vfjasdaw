// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionSetKeyResponse : OperationBase // TypeDefIndex: 11421
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MissionKeyCommon <MissionKey>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketClass(Code = 156, IsOptional = True)]
	public MissionKeyCommon MissionKey { get; set; }

	// Methods

	// RVA: 0x37057E4 Offset: 0x37017E4 VA: 0x37057E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x37057EC Offset: 0x37017EC VA: 0x37057EC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37057F4 Offset: 0x37017F4 VA: 0x37057F4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37057FC Offset: 0x37017FC VA: 0x37057FC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3705804 Offset: 0x3701804 VA: 0x3705804
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x370580C Offset: 0x370180C VA: 0x370580C
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3705814 Offset: 0x3701814 VA: 0x3705814
	public MissionKeyCommon get_MissionKey() { }

	[CompilerGenerated]
	// RVA: 0x370581C Offset: 0x370181C VA: 0x370581C
	public void set_MissionKey(MissionKeyCommon value) { }

	// RVA: 0x3705824 Offset: 0x3701824 VA: 0x3705824
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705940 Offset: 0x3701940 VA: 0x3705940
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37059BC Offset: 0x37019BC VA: 0x37059BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3705B4C Offset: 0x3701B4C VA: 0x3705B4C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
