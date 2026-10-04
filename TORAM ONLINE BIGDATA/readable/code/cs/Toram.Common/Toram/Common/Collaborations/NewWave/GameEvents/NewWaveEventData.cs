// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.GameEvents
public class NewWaveEventData : GameEventDataBase // TypeDefIndex: 13047
{
	// Fields
	public static readonly int PointBoostRecvCoolHourTime; // 0x0
	private GameEventScenarioData scenarioData; // 0x20
	[CompilerGenerated]
	private byte <InnerVersion>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <PointBoost>k__BackingField; // 0x29
	[CompilerGenerated]
	private DateTime <PointBoostRecvStartTime>k__BackingField; // 0x30

	// Properties
	public override int Version { get; }
	public override byte Code { get; }
	public byte InnerVersion { get; set; }
	public byte PointBoost { get; set; }
	public DateTime PointBoostRecvStartTime { get; set; }

	// Methods

	// RVA: 0x3696E88 Offset: 0x3692E88 VA: 0x3696E88
	public void .ctor() { }

	// RVA: 0x3696E90 Offset: 0x3692E90 VA: 0x3696E90 Slot: 7
	public override int get_Version() { }

	// RVA: 0x3696E98 Offset: 0x3692E98 VA: 0x3696E98 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3696EA0 Offset: 0x3692EA0 VA: 0x3696EA0
	public byte get_InnerVersion() { }

	[CompilerGenerated]
	// RVA: 0x3696EA8 Offset: 0x3692EA8 VA: 0x3696EA8
	private void set_InnerVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3696EB0 Offset: 0x3692EB0 VA: 0x3696EB0
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x3696EB8 Offset: 0x3692EB8 VA: 0x3696EB8
	public void set_PointBoost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3696EC0 Offset: 0x3692EC0 VA: 0x3696EC0
	public DateTime get_PointBoostRecvStartTime() { }

	[CompilerGenerated]
	// RVA: 0x3696EC8 Offset: 0x3692EC8 VA: 0x3696EC8
	public void set_PointBoostRecvStartTime(DateTime value) { }

	// RVA: 0x3696ED0 Offset: 0x3692ED0 VA: 0x3696ED0 Slot: 8
	protected override bool VersionInitialize() { }

	// RVA: 0x3696F84 Offset: 0x3692F84 VA: 0x3696F84 Slot: 9
	protected override void Serialize(MemoryStream ms) { }

	// RVA: 0x3697050 Offset: 0x3693050 VA: 0x3697050 Slot: 10
	protected override bool Deserialize(MemoryStream ms, bool isInitialize) { }

	// RVA: 0x3697270 Offset: 0x3693270 VA: 0x3697270
	private static void .cctor() { }
}
