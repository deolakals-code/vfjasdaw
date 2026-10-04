// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Wave
public class WaveData : BinaryBase // TypeDefIndex: 11302
{
	// Fields
	[CompilerGenerated]
	private int <WaveId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private WaveMobPopData[] <MobPopDatas>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <EndStartScript>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <LimitTimeMini>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <ClearAddTime>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <NextWaveDelay>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <NextWaveTargetHeal>k__BackingField; // 0x32
	private byte version; // 0x34

	// Properties
	public int WaveId { get; set; }
	public WaveMobPopData[] MobPopDatas { get; set; }
	public int EndStartScript { get; set; }
	public short LimitTimeMini { get; set; }
	public short ClearAddTime { get; set; }
	public short NextWaveDelay { get; set; }
	public short NextWaveTargetHeal { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36DADE8 Offset: 0x36D6DE8 VA: 0x36DADE8
	public int get_WaveId() { }

	[CompilerGenerated]
	// RVA: 0x36DADF0 Offset: 0x36D6DF0 VA: 0x36DADF0
	private void set_WaveId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DADF8 Offset: 0x36D6DF8 VA: 0x36DADF8
	public WaveMobPopData[] get_MobPopDatas() { }

	[CompilerGenerated]
	// RVA: 0x36DAE00 Offset: 0x36D6E00 VA: 0x36DAE00
	private void set_MobPopDatas(WaveMobPopData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DAE08 Offset: 0x36D6E08 VA: 0x36DAE08
	public int get_EndStartScript() { }

	[CompilerGenerated]
	// RVA: 0x36DAE10 Offset: 0x36D6E10 VA: 0x36DAE10
	private void set_EndStartScript(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DAE18 Offset: 0x36D6E18 VA: 0x36DAE18
	public short get_LimitTimeMini() { }

	[CompilerGenerated]
	// RVA: 0x36DAE20 Offset: 0x36D6E20 VA: 0x36DAE20
	private void set_LimitTimeMini(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DAE28 Offset: 0x36D6E28 VA: 0x36DAE28
	public short get_ClearAddTime() { }

	[CompilerGenerated]
	// RVA: 0x36DAE30 Offset: 0x36D6E30 VA: 0x36DAE30
	private void set_ClearAddTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DAE38 Offset: 0x36D6E38 VA: 0x36DAE38
	public short get_NextWaveDelay() { }

	[CompilerGenerated]
	// RVA: 0x36DAE40 Offset: 0x36D6E40 VA: 0x36DAE40
	private void set_NextWaveDelay(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DAE48 Offset: 0x36D6E48 VA: 0x36DAE48
	public short get_NextWaveTargetHeal() { }

	[CompilerGenerated]
	// RVA: 0x36DAE50 Offset: 0x36D6E50 VA: 0x36DAE50
	private void set_NextWaveTargetHeal(short value) { }

	// RVA: 0x36DAE58 Offset: 0x36D6E58 VA: 0x36DAE58
	public void .ctor(int waveId, int endStarScript, short limitTimeMini, short clearAddTime, short nextWaveDelay, short nextWaveTargetHeal, WaveMobPopData[] mobdatas) { }

	// RVA: 0x36DAED0 Offset: 0x36D6ED0 VA: 0x36DAED0
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36DAED8 Offset: 0x36D6ED8 VA: 0x36DAED8
	public void .ctor(MemoryStream ms, byte version) { }

	// RVA: 0x36DAF18 Offset: 0x36D6F18 VA: 0x36DAF18 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DB51C Offset: 0x36D751C VA: 0x36DB51C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
