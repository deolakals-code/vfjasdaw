// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Orbs
public class OrbEnchantData : BinaryBase // TypeDefIndex: 11141
{
	// Fields
	public const int EnchantCapMax = 9;
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <EquipType>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short[] <CapId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <CapVal>k__BackingField; // 0x28

	// Properties
	public byte Index { get; set; }
	public byte EquipType { get; set; }
	public short[] CapId { get; set; }
	public byte[] CapVal { get; set; }

	// Methods

	// RVA: 0x35C8370 Offset: 0x35C4370 VA: 0x35C8370
	public void .ctor() { }

	// RVA: 0x35C841C Offset: 0x35C441C VA: 0x35C841C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35C8424 Offset: 0x35C4424 VA: 0x35C8424
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35C842C Offset: 0x35C442C VA: 0x35C842C
	protected void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C8434 Offset: 0x35C4434 VA: 0x35C8434
	public byte get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x35C843C Offset: 0x35C443C VA: 0x35C843C
	protected void set_EquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C8444 Offset: 0x35C4444 VA: 0x35C8444
	public short[] get_CapId() { }

	[CompilerGenerated]
	// RVA: 0x35C844C Offset: 0x35C444C VA: 0x35C844C
	protected void set_CapId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C8454 Offset: 0x35C4454 VA: 0x35C8454
	public byte[] get_CapVal() { }

	[CompilerGenerated]
	// RVA: 0x35C845C Offset: 0x35C445C VA: 0x35C845C
	protected void set_CapVal(byte[] value) { }

	// RVA: 0x35C838C Offset: 0x35C438C VA: 0x35C838C
	protected void Init() { }

	// RVA: 0x35C8464 Offset: 0x35C4464 VA: 0x35C8464
	protected byte GetCapNum() { }

	// RVA: 0x35C84B8 Offset: 0x35C44B8 VA: 0x35C84B8 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C86A8 Offset: 0x35C46A8 VA: 0x35C86A8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C8780 Offset: 0x35C4780 VA: 0x35C8780 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
