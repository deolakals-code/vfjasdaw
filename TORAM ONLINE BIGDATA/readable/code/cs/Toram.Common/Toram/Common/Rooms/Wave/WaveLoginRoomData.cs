// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Wave
public class WaveLoginRoomData : LoginRoomDataBase // TypeDefIndex: 11307
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
	// RVA: 0x36DBE80 Offset: 0x36D7E80 VA: 0x36DBE80
	public WaveGameSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36DBE88 Offset: 0x36D7E88 VA: 0x36DBE88
	public void set_Setting(WaveGameSetting value) { }

	[CompilerGenerated]
	// RVA: 0x36DBE90 Offset: 0x36D7E90 VA: 0x36DBE90
	public byte[] get_WaveData() { }

	[CompilerGenerated]
	// RVA: 0x36DBE98 Offset: 0x36D7E98 VA: 0x36DBE98
	public void set_WaveData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DBEA0 Offset: 0x36D7EA0 VA: 0x36DBEA0
	public int get_NowWaveID() { }

	[CompilerGenerated]
	// RVA: 0x36DBEA8 Offset: 0x36D7EA8 VA: 0x36DBEA8
	public void set_NowWaveID(int value) { }

	// RVA: 0x36DBEB0 Offset: 0x36D7EB0 VA: 0x36DBEB0
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36DBEB8 Offset: 0x36D7EB8 VA: 0x36DBEB8
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DC184 Offset: 0x36D8184 VA: 0x36DC184
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DC2F4 Offset: 0x36D82F4 VA: 0x36DC2F4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DC3A0 Offset: 0x36D83A0 VA: 0x36DC3A0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
