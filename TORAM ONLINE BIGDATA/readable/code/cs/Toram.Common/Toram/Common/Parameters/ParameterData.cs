// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class ParameterData : UnityHashBase // TypeDefIndex: 11122
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x1A
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ScenarioProgress>k__BackingField; // 0x2C

	// Properties
	[UnityHash(Code = 108, IsOptional = True)]
	public byte ParamId { get; set; }
	[UnityHash(Code = 29, IsOptional = True)]
	public short Level { get; set; }
	[UnityHash(Code = 109, IsOptional = True)]
	public string ParamName { get; set; }
	[UnityHash(Code = 43, IsOptional = True)]
	public byte Flag { get; set; }
	[UnityHash(Code = 158, IsOptional = True)]
	public int ScenarioProgress { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35BFE24 Offset: 0x35BBE24 VA: 0x35BFE24
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35BFE44 Offset: 0x35BBE44 VA: 0x35BFE44
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x35BFE4C Offset: 0x35BBE4C VA: 0x35BFE4C
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BFE54 Offset: 0x35BBE54 VA: 0x35BFE54
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x35BFE5C Offset: 0x35BBE5C VA: 0x35BFE5C
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x35BFE64 Offset: 0x35BBE64 VA: 0x35BFE64
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x35BFE6C Offset: 0x35BBE6C VA: 0x35BFE6C
	public void set_ParamName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35BFE74 Offset: 0x35BBE74 VA: 0x35BFE74
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35BFE7C Offset: 0x35BBE7C VA: 0x35BFE7C
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BFE84 Offset: 0x35BBE84 VA: 0x35BFE84
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x35BFE8C Offset: 0x35BBE8C VA: 0x35BFE8C
	public void set_ScenarioProgress(int value) { }

	// RVA: 0x35BFE94 Offset: 0x35BBE94 VA: 0x35BFE94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35BFE9C Offset: 0x35BBE9C VA: 0x35BFE9C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C02B0 Offset: 0x35BC2B0 VA: 0x35C02B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
