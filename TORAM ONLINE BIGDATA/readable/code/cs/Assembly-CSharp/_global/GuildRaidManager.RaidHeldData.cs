// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRaidManager.RaidHeldData // TypeDefIndex: 1926
{
	// Fields
	public readonly byte Element; // 0x10
	[CompilerGenerated]
	private byte <HeldCount>k__BackingField; // 0x11
	private TimeSpan summonSeverTimer; // 0x18
	private TimeSpan coolSeverTimer; // 0x20
	private DateTime updateTime; // 0x28
	private byte maxHpCount; // 0x30

	// Properties
	public byte HeldCount { get; set; }
	public int SummonLevel { get; }
	public int HeldMedal { get; }
	public TimeSpan SummonTimer { get; }
	public TimeSpan CoolTimer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2109128 Offset: 0x2105128 VA: 0x2109128
	public byte get_HeldCount() { }

	[CompilerGenerated]
	// RVA: 0x2109130 Offset: 0x2105130 VA: 0x2109130
	private void set_HeldCount(byte value) { }

	// RVA: 0x2109138 Offset: 0x2105138 VA: 0x2109138
	public int get_SummonLevel() { }

	// RVA: 0x2109144 Offset: 0x2105144 VA: 0x2109144
	public int get_HeldMedal() { }

	// RVA: 0x2108C94 Offset: 0x2104C94 VA: 0x2108C94
	public TimeSpan get_SummonTimer() { }

	// RVA: 0x2108D7C Offset: 0x2104D7C VA: 0x2108D7C
	public TimeSpan get_CoolTimer() { }

	// RVA: 0x2108F00 Offset: 0x2104F00 VA: 0x2108F00
	public void .ctor(byte element) { }

	// RVA: 0x2108F88 Offset: 0x2104F88 VA: 0x2108F88
	public bool UpdateData(GuildRaidHeldData data) { }
}
