// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AreaBonusResult : PacketBase // TypeDefIndex: 11945
{
	// Fields
	[CompilerGenerated]
	private short <BonusMaxGauge>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <BonusGauge>k__BackingField; // 0x22
	[CompilerGenerated]
	private Dictionary<int, int> <SubdueMobs>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <ResultThrough>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 146)]
	public short BonusMaxGauge { get; set; }
	[PacketParameter(Code = 206)]
	public short BonusGauge { get; set; }
	[PacketParameter(Code = 89, IsOptional = True)]
	public Dictionary<int, int> SubdueMobs { get; set; }
	public bool ResultThrough { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376BB18 Offset: 0x3767B18 VA: 0x376BB18
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376BB20 Offset: 0x3767B20 VA: 0x376BB20
	public short get_BonusMaxGauge() { }

	[CompilerGenerated]
	// RVA: 0x376BB28 Offset: 0x3767B28 VA: 0x376BB28
	public void set_BonusMaxGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x376BB30 Offset: 0x3767B30 VA: 0x376BB30
	public short get_BonusGauge() { }

	[CompilerGenerated]
	// RVA: 0x376BB38 Offset: 0x3767B38 VA: 0x376BB38
	public void set_BonusGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x376BB40 Offset: 0x3767B40 VA: 0x376BB40
	public Dictionary<int, int> get_SubdueMobs() { }

	[CompilerGenerated]
	// RVA: 0x376BB48 Offset: 0x3767B48 VA: 0x376BB48
	public void set_SubdueMobs(Dictionary<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x376BB50 Offset: 0x3767B50 VA: 0x376BB50
	public bool get_ResultThrough() { }

	[CompilerGenerated]
	// RVA: 0x376BB58 Offset: 0x3767B58 VA: 0x376BB58
	public void set_ResultThrough(bool value) { }

	// RVA: 0x376BB64 Offset: 0x3767B64 VA: 0x376BB64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376BB6C Offset: 0x3767B6C VA: 0x376BB6C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376BDE8 Offset: 0x3767DE8 VA: 0x376BDE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
