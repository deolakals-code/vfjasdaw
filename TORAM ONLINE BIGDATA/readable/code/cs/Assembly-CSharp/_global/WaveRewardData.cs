// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveRewardData // TypeDefIndex: 1859
{
	// Fields
	[CompilerGenerated]
	private Dictionary<int, Dictionary<ushort, byte>> <SaveDataList>k__BackingField; // 0x10

	// Properties
	public Dictionary<int, Dictionary<ushort, byte>> SaveDataList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20F2BF8 Offset: 0x20EEBF8 VA: 0x20F2BF8
	public Dictionary<int, Dictionary<ushort, byte>> get_SaveDataList() { }

	[CompilerGenerated]
	// RVA: 0x20F2C00 Offset: 0x20EEC00 VA: 0x20F2C00
	private void set_SaveDataList(Dictionary<int, Dictionary<ushort, byte>> value) { }

	// RVA: 0x20EE3A8 Offset: 0x20EA3A8 VA: 0x20EE3A8
	public void Clear() { }

	// RVA: 0x20F2C08 Offset: 0x20EEC08 VA: 0x20F2C08
	public void SetDataList(int fieldId, Dictionary<ushort, byte> dataList) { }

	// RVA: 0x20F2CD4 Offset: 0x20EECD4 VA: 0x20F2CD4
	public void UpdateData(int fieldId, byte waveNo, byte index, byte state) { }

	// RVA: 0x20F2E2C Offset: 0x20EEE2C VA: 0x20F2E2C
	public static ushort GetClearDataKey(byte waveNo, byte index) { }

	// RVA: 0x20F2E38 Offset: 0x20EEE38 VA: 0x20F2E38
	public static ValueTuple<byte, byte> GetClearDataKeyToData(ushort key) { }

	// RVA: 0x20EE934 Offset: 0x20EA934 VA: 0x20EE934
	public void .ctor() { }
}
