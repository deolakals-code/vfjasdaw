// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Rhythm
public class RhythmFinish : OperationRequestBase // TypeDefIndex: 12212
{
	// Fields
	[CompilerGenerated]
	private short <Critical>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Hit>k__BackingField; // 0x22
	[CompilerGenerated]
	private short <Graze>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Miss>k__BackingField; // 0x26

	// Properties
	public short Critical { get; set; }
	public short Hit { get; set; }
	public short Graze { get; set; }
	public short Miss { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E1948 Offset: 0x35DD948 VA: 0x35E1948
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E1950 Offset: 0x35DD950 VA: 0x35E1950
	public short get_Critical() { }

	[CompilerGenerated]
	// RVA: 0x35E1958 Offset: 0x35DD958 VA: 0x35E1958
	public void set_Critical(short value) { }

	[CompilerGenerated]
	// RVA: 0x35E1960 Offset: 0x35DD960 VA: 0x35E1960
	public short get_Hit() { }

	[CompilerGenerated]
	// RVA: 0x35E1968 Offset: 0x35DD968 VA: 0x35E1968
	public void set_Hit(short value) { }

	[CompilerGenerated]
	// RVA: 0x35E1970 Offset: 0x35DD970 VA: 0x35E1970
	public short get_Graze() { }

	[CompilerGenerated]
	// RVA: 0x35E1978 Offset: 0x35DD978 VA: 0x35E1978
	public void set_Graze(short value) { }

	[CompilerGenerated]
	// RVA: 0x35E1980 Offset: 0x35DD980 VA: 0x35E1980
	public short get_Miss() { }

	[CompilerGenerated]
	// RVA: 0x35E1988 Offset: 0x35DD988 VA: 0x35E1988
	public void set_Miss(short value) { }

	// RVA: 0x35E1990 Offset: 0x35DD990 VA: 0x35E1990 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E1998 Offset: 0x35DD998 VA: 0x35E1998 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E19A0 Offset: 0x35DD9A0 VA: 0x35E19A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E1B94 Offset: 0x35DDB94 VA: 0x35E1B94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
