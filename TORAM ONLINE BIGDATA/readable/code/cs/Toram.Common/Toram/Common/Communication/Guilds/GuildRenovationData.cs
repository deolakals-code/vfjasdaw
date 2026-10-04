// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds
public class GuildRenovationData : BinaryBase // TypeDefIndex: 13019
{
	// Fields
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0x19
	[CompilerGenerated]
	private long <OpenFlag>k__BackingField; // 0x20

	// Properties
	public byte RenovationId { get; set; }
	public long OpenFlag { get; set; }

	// Methods

	// RVA: 0x368F538 Offset: 0x368B538 VA: 0x368F538
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x368FAF4 Offset: 0x368BAF4 VA: 0x368FAF4
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x368FAFC Offset: 0x368BAFC VA: 0x368FAFC
	protected void set_RenovationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368FB04 Offset: 0x368BB04 VA: 0x368FB04
	public long get_OpenFlag() { }

	[CompilerGenerated]
	// RVA: 0x368FB0C Offset: 0x368BB0C VA: 0x368FB0C
	protected void set_OpenFlag(long value) { }

	// RVA: 0x368FB14 Offset: 0x368BB14 VA: 0x368FB14 Slot: 3
	public override string ToString() { }

	// RVA: 0x368FBD0 Offset: 0x368BBD0 VA: 0x368FBD0 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368FC0C Offset: 0x368BC0C VA: 0x368FC0C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
