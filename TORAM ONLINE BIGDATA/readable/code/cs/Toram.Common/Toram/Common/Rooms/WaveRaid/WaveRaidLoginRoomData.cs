// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.WaveRaid
public class WaveRaidLoginRoomData : LoginRoomDataBase // TypeDefIndex: 11313
{
	// Fields
	[CompilerGenerated]
	private WaveGameSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <WaveData>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <NowWaveID>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 187, IsOptional = True)]
	public WaveGameSetting Setting { get; set; }
	[UnityHash(Code = 73, IsOptional = True)]
	public byte[] WaveData { get; set; }
	[UnityHash(Code = 19)]
	public int NowWaveID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36DD66C Offset: 0x36D966C VA: 0x36DD66C
	public WaveGameSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36DD674 Offset: 0x36D9674 VA: 0x36DD674
	public void set_Setting(WaveGameSetting value) { }

	[CompilerGenerated]
	// RVA: 0x36DD67C Offset: 0x36D967C VA: 0x36DD67C
	public byte[] get_WaveData() { }

	[CompilerGenerated]
	// RVA: 0x36DD684 Offset: 0x36D9684 VA: 0x36DD684
	public void set_WaveData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DD68C Offset: 0x36D968C VA: 0x36DD68C
	public int get_NowWaveID() { }

	[CompilerGenerated]
	// RVA: 0x36DD694 Offset: 0x36D9694 VA: 0x36DD694
	public void set_NowWaveID(int value) { }

	// RVA: 0x36DD69C Offset: 0x36D969C VA: 0x36DD69C
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36DD6A4 Offset: 0x36D96A4 VA: 0x36DD6A4
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DD970 Offset: 0x36D9970 VA: 0x36DD970
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DDAE0 Offset: 0x36D9AE0 VA: 0x36DDAE0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DDB8C Offset: 0x36D9B8C VA: 0x36DDB8C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
