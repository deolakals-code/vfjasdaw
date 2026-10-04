// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Quests
public class QuestKeyCommon : BinaryBase, IScenarioKey // TypeDefIndex: 11092
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Current>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <Maximum>k__BackingField; // 0x1B

	// Properties
	[BinaryParameter]
	public byte No { get; set; }
	[BinaryParameter]
	public byte Current { get; set; }
	[BinaryParameter]
	public byte Maximum { get; set; }

	// Methods

	// RVA: 0x35B7A44 Offset: 0x35B3A44 VA: 0x35B7A44
	public void .ctor() { }

	// RVA: 0x35B7A4C Offset: 0x35B3A4C VA: 0x35B7A4C
	public void .ctor(byte[] binary) { }

	// RVA: 0x35B6734 Offset: 0x35B2734 VA: 0x35B6734
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B7A54 Offset: 0x35B3A54 VA: 0x35B7A54 Slot: 8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35B7A5C Offset: 0x35B3A5C VA: 0x35B7A5C Slot: 9
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B7A64 Offset: 0x35B3A64 VA: 0x35B7A64 Slot: 10
	public byte get_Current() { }

	[CompilerGenerated]
	// RVA: 0x35B7A6C Offset: 0x35B3A6C VA: 0x35B7A6C Slot: 11
	public void set_Current(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B7A74 Offset: 0x35B3A74 VA: 0x35B7A74 Slot: 12
	public byte get_Maximum() { }

	[CompilerGenerated]
	// RVA: 0x35B7A7C Offset: 0x35B3A7C VA: 0x35B7A7C Slot: 13
	public void set_Maximum(byte value) { }

	// RVA: 0x35B7A84 Offset: 0x35B3A84 VA: 0x35B7A84 Slot: 3
	public override string ToString() { }

	// RVA: 0x35B7B48 Offset: 0x35B3B48 VA: 0x35B7B48 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B7C68 Offset: 0x35B3C68 VA: 0x35B7C68 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
