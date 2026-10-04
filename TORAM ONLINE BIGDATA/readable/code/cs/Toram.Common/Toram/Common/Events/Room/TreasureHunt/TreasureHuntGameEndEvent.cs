// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntGameEndEvent : EventSubBase // TypeDefIndex: 12792
{
	// Fields
	[CompilerGenerated]
	private byte <GameEndCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ScriptRetval>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte[] <acquiredTreasureNums>k__BackingField; // 0x28
	[CompilerGenerated]
	private TreasureHuntResultBonusData[] <ResultBonusDatas>k__BackingField; // 0x30
	[CompilerGenerated]
	private TreasureHuntTreasureRewardData[] <RewardList>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsRegistletOpenSystem>k__BackingField; // 0x40

	// Properties
	[PacketClass(Code = 141)]
	public byte GameEndCode { get; set; }
	[PacketClass(Code = 195)]
	public short ScriptRetval { get; set; }
	[PacketClass(Code = 253, IsOptional = True)]
	public byte[] acquiredTreasureNums { get; set; }
	[PacketClass(Code = 206, IsOptional = True)]
	public TreasureHuntResultBonusData[] ResultBonusDatas { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public TreasureHuntTreasureRewardData[] RewardList { get; set; }
	[PacketClass(Code = 43, IsOptional = True)]
	public bool IsRegistletOpenSystem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365A2A8 Offset: 0x36562A8 VA: 0x365A2A8
	public void .ctor() { }

	// RVA: 0x365A2B0 Offset: 0x36562B0 VA: 0x365A2B0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365A2B8 Offset: 0x36562B8 VA: 0x365A2B8
	public byte get_GameEndCode() { }

	[CompilerGenerated]
	// RVA: 0x365A2C0 Offset: 0x36562C0 VA: 0x365A2C0
	public void set_GameEndCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365A2C8 Offset: 0x36562C8 VA: 0x365A2C8
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x365A2D0 Offset: 0x36562D0 VA: 0x365A2D0
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x365A2D8 Offset: 0x36562D8 VA: 0x365A2D8
	public byte[] get_acquiredTreasureNums() { }

	[CompilerGenerated]
	// RVA: 0x365A2E0 Offset: 0x36562E0 VA: 0x365A2E0
	public void set_acquiredTreasureNums(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x365A2E8 Offset: 0x36562E8 VA: 0x365A2E8
	public TreasureHuntResultBonusData[] get_ResultBonusDatas() { }

	[CompilerGenerated]
	// RVA: 0x365A2F0 Offset: 0x36562F0 VA: 0x365A2F0
	public void set_ResultBonusDatas(TreasureHuntResultBonusData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365A2F8 Offset: 0x36562F8 VA: 0x365A2F8
	public TreasureHuntTreasureRewardData[] get_RewardList() { }

	[CompilerGenerated]
	// RVA: 0x365A300 Offset: 0x3656300 VA: 0x365A300
	public void set_RewardList(TreasureHuntTreasureRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365A308 Offset: 0x3656308 VA: 0x365A308
	public bool get_IsRegistletOpenSystem() { }

	[CompilerGenerated]
	// RVA: 0x365A310 Offset: 0x3656310 VA: 0x365A310
	public void set_IsRegistletOpenSystem(bool value) { }

	// RVA: 0x365A31C Offset: 0x365631C VA: 0x365A31C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365A324 Offset: 0x3656324 VA: 0x365A324 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365A32C Offset: 0x365632C VA: 0x365A32C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365A6F0 Offset: 0x36566F0 VA: 0x365A6F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
