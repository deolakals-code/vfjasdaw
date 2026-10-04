// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Pets
public class PetModelData : BinaryBase // TypeDefIndex: 12957
{
	// Fields
	public const int ColorMax = 3;
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Scale>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <Color>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x30

	// Properties
	public int ModelId { get; set; }
	public byte Scale { get; set; }
	public int[] Color { get; set; }
	public int MonsterUuid { get; set; }

	// Methods

	// RVA: 0x3681B34 Offset: 0x367DB34 VA: 0x3681B34
	public void .ctor() { }

	// RVA: 0x368022C Offset: 0x367C22C VA: 0x368022C
	public void .ctor(byte[] binary) { }

	// RVA: 0x36810F0 Offset: 0x367D0F0 VA: 0x36810F0
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x3681B98 Offset: 0x367DB98 VA: 0x3681B98
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x3681BA0 Offset: 0x367DBA0 VA: 0x3681BA0
	protected void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3681BA8 Offset: 0x367DBA8 VA: 0x3681BA8
	public byte get_Scale() { }

	[CompilerGenerated]
	// RVA: 0x3681BB0 Offset: 0x367DBB0 VA: 0x3681BB0
	protected void set_Scale(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3681BB8 Offset: 0x367DBB8 VA: 0x3681BB8
	public int[] get_Color() { }

	[CompilerGenerated]
	// RVA: 0x3681BC0 Offset: 0x367DBC0 VA: 0x3681BC0
	protected void set_Color(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3681BC8 Offset: 0x367DBC8 VA: 0x3681BC8
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x3681BD0 Offset: 0x367DBD0 VA: 0x3681BD0
	protected void set_MonsterUuid(int value) { }

	// RVA: 0x3681BD8 Offset: 0x367DBD8 VA: 0x3681BD8
	public bool IsMatch(int monsterUuid, int modelId) { }

	// RVA: 0x3681BFC Offset: 0x367DBFC VA: 0x3681BFC
	public bool IsMatch(PetModelData model) { }

	// RVA: 0x3681C38 Offset: 0x367DC38 VA: 0x3681C38 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3681E38 Offset: 0x367DE38 VA: 0x3681E38 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
