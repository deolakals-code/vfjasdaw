// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Missions
public class MissionKeyCommon : BinaryBase, IScenarioKey // TypeDefIndex: 11096
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

	// RVA: 0x35B93A0 Offset: 0x35B53A0 VA: 0x35B93A0
	public void .ctor() { }

	// RVA: 0x35B93A8 Offset: 0x35B53A8 VA: 0x35B93A8
	public void .ctor(byte[] binary) { }

	// RVA: 0x35B8564 Offset: 0x35B4564 VA: 0x35B8564
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B93B0 Offset: 0x35B53B0 VA: 0x35B93B0 Slot: 8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35B93B8 Offset: 0x35B53B8 VA: 0x35B93B8 Slot: 9
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B93C0 Offset: 0x35B53C0 VA: 0x35B93C0 Slot: 10
	public byte get_Current() { }

	[CompilerGenerated]
	// RVA: 0x35B93C8 Offset: 0x35B53C8 VA: 0x35B93C8 Slot: 11
	public void set_Current(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B93D0 Offset: 0x35B53D0 VA: 0x35B93D0 Slot: 12
	public byte get_Maximum() { }

	[CompilerGenerated]
	// RVA: 0x35B93D8 Offset: 0x35B53D8 VA: 0x35B93D8 Slot: 13
	public void set_Maximum(byte value) { }

	// RVA: 0x35B93E0 Offset: 0x35B53E0 VA: 0x35B93E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35B94A4 Offset: 0x35B54A4 VA: 0x35B94A4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B95C4 Offset: 0x35B55C4 VA: 0x35B95C4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
