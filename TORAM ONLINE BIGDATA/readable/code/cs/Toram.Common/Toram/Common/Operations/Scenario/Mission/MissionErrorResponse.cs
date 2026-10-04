// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionErrorResponse : OperationBase // TypeDefIndex: 11417
{
	// Fields
	private byte operationCode; // 0x21
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MissionKeyCommon <MissionKey>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x3A
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte <ScenarioInfoNo>k__BackingField; // 0x3E

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketClass(Code = 156, IsOptional = True)]
	public MissionKeyCommon MissionKey { get; set; }
	[PacketParameter(Code = 125, IsOptional = True)]
	public short KeySetting { get; set; }
	[PacketParameter(Code = 126, IsOptional = True)]
	public short ItemSetting { get; set; }
	[PacketParameter(Code = 127, IsOptional = True)]
	public short MobSetting { get; set; }
	[PacketParameter(Code = 128, IsOptional = True)]
	public byte ScenarioInfoNo { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37045FC Offset: 0x37005FC VA: 0x37045FC
	public void .ctor(byte operationCode, Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3704628 Offset: 0x3700628 VA: 0x3704628
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3704630 Offset: 0x3700630 VA: 0x3704630
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3704638 Offset: 0x3700638 VA: 0x3704638
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3704640 Offset: 0x3700640 VA: 0x3704640
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3704648 Offset: 0x3700648 VA: 0x3704648
	public MissionKeyCommon get_MissionKey() { }

	[CompilerGenerated]
	// RVA: 0x3704650 Offset: 0x3700650 VA: 0x3704650
	public void set_MissionKey(MissionKeyCommon value) { }

	[CompilerGenerated]
	// RVA: 0x3704658 Offset: 0x3700658 VA: 0x3704658
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x3704660 Offset: 0x3700660 VA: 0x3704660
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3704668 Offset: 0x3700668 VA: 0x3704668
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x3704670 Offset: 0x3700670 VA: 0x3704670
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3704678 Offset: 0x3700678 VA: 0x3704678
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x3704680 Offset: 0x3700680 VA: 0x3704680
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3704688 Offset: 0x3700688 VA: 0x3704688
	public byte get_ScenarioInfoNo() { }

	[CompilerGenerated]
	// RVA: 0x3704690 Offset: 0x3700690 VA: 0x3704690
	public void set_ScenarioInfoNo(byte value) { }

	// RVA: 0x3704698 Offset: 0x3700698 VA: 0x3704698
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37047B4 Offset: 0x37007B4 VA: 0x37047B4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3704830 Offset: 0x3700830 VA: 0x3704830 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3704838 Offset: 0x3700838 VA: 0x3704838 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3704B84 Offset: 0x3700B84 VA: 0x3704B84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
