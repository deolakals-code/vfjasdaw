// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Orbs
public class OrbEquipItemData : BinaryBase // TypeDefIndex: 11145
{
	// Fields
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <CapId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <CapVal>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Model>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <Color>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x48
	[CompilerGenerated]
	private DateTime <EquipDate>k__BackingField; // 0x50

	// Properties
	[BinaryParameter]
	public int Uuid { get; set; }
	[BinaryParameter]
	public int Id { get; set; }
	[BinaryParameter]
	public short[] CapId { get; set; }
	[BinaryParameter]
	public byte[] CapVal { get; set; }
	[BinaryParameter]
	public int Model { get; set; }
	[BinaryParameter]
	public byte[] Color { get; set; }
	[BinaryParameter]
	public byte Flag { get; set; }
	[BinaryParameter]
	public DateTime EquipDate { get; set; }

	// Methods

	// RVA: 0x35C987C Offset: 0x35C587C VA: 0x35C987C
	public void .ctor() { }

	// RVA: 0x35C994C Offset: 0x35C594C VA: 0x35C994C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35C9954 Offset: 0x35C5954 VA: 0x35C9954
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x35C995C Offset: 0x35C595C VA: 0x35C995C
	protected void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C9964 Offset: 0x35C5964 VA: 0x35C9964
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35C996C Offset: 0x35C596C VA: 0x35C996C
	protected void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C9974 Offset: 0x35C5974 VA: 0x35C9974
	public short[] get_CapId() { }

	[CompilerGenerated]
	// RVA: 0x35C997C Offset: 0x35C597C VA: 0x35C997C
	protected void set_CapId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C9984 Offset: 0x35C5984 VA: 0x35C9984
	public byte[] get_CapVal() { }

	[CompilerGenerated]
	// RVA: 0x35C998C Offset: 0x35C598C VA: 0x35C998C
	protected void set_CapVal(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C9994 Offset: 0x35C5994 VA: 0x35C9994
	public int get_Model() { }

	[CompilerGenerated]
	// RVA: 0x35C999C Offset: 0x35C599C VA: 0x35C999C
	protected void set_Model(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C99A4 Offset: 0x35C59A4 VA: 0x35C99A4
	public byte[] get_Color() { }

	[CompilerGenerated]
	// RVA: 0x35C99AC Offset: 0x35C59AC VA: 0x35C99AC
	protected void set_Color(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C99B4 Offset: 0x35C59B4 VA: 0x35C99B4
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35C99BC Offset: 0x35C59BC VA: 0x35C99BC
	protected void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C99C4 Offset: 0x35C59C4 VA: 0x35C99C4
	public DateTime get_EquipDate() { }

	[CompilerGenerated]
	// RVA: 0x35C99CC Offset: 0x35C59CC VA: 0x35C99CC
	protected void set_EquipDate(DateTime value) { }

	// RVA: 0x35C9898 Offset: 0x35C5898 VA: 0x35C9898
	protected void Init() { }

	// RVA: 0x35C99D4 Offset: 0x35C59D4 VA: 0x35C99D4
	protected byte GetCapNum() { }

	// RVA: 0x35C9A28 Offset: 0x35C5A28 VA: 0x35C9A28 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C9B00 Offset: 0x35C5B00 VA: 0x35C9B00 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C9D60 Offset: 0x35C5D60 VA: 0x35C9D60 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
