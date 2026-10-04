// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Pets
public class PetEntityData : BinaryBase // TypeDefIndex: 12952
{
	// Fields
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private PetModelData <Model>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <OwnerId>k__BackingField; // 0x48

	// Properties
	public long Uuid { get; set; }
	public string Name { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public PetModelData Model { get; set; }
	public int OwnerId { get; set; }

	// Methods

	// RVA: 0x3680DCC Offset: 0x367CDCC VA: 0x3680DCC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3680E30 Offset: 0x367CE30 VA: 0x3680E30
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x3680E38 Offset: 0x367CE38 VA: 0x3680E38
	protected void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3680E40 Offset: 0x367CE40 VA: 0x3680E40
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3680E48 Offset: 0x367CE48 VA: 0x3680E48
	protected void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3680E50 Offset: 0x367CE50 VA: 0x3680E50
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3680E58 Offset: 0x367CE58 VA: 0x3680E58
	protected void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3680E60 Offset: 0x367CE60 VA: 0x3680E60
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3680E68 Offset: 0x367CE68 VA: 0x3680E68
	protected void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3680E70 Offset: 0x367CE70 VA: 0x3680E70
	public PetModelData get_Model() { }

	[CompilerGenerated]
	// RVA: 0x3680E78 Offset: 0x367CE78 VA: 0x3680E78
	protected void set_Model(PetModelData value) { }

	[CompilerGenerated]
	// RVA: 0x3680E80 Offset: 0x367CE80 VA: 0x3680E80
	public int get_OwnerId() { }

	[CompilerGenerated]
	// RVA: 0x3680E88 Offset: 0x367CE88 VA: 0x3680E88
	protected void set_OwnerId(int value) { }

	// RVA: 0x3680E90 Offset: 0x367CE90 VA: 0x3680E90 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36810F8 Offset: 0x367D0F8 VA: 0x36810F8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
