// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Pets
public class PetBattleStatusData : BinaryBase // TypeDefIndex: 12947
{
	// Fields
	[CompilerGenerated]
	private byte <WeaponType>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <WeaponAtk>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <WeaponRefine>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x1D
	[CompilerGenerated]
	private byte <PetType>k__BackingField; // 0x1E
	[CompilerGenerated]
	private byte <Persona>k__BackingField; // 0x1F

	// Properties
	public byte WeaponType { get; set; }
	public short WeaponAtk { get; set; }
	public byte WeaponRefine { get; set; }
	public byte Element { get; set; }
	public byte PetType { get; set; }
	public byte Persona { get; set; }

	// Methods

	// RVA: 0x367F238 Offset: 0x367B238 VA: 0x367F238
	public void .ctor() { }

	// RVA: 0x367F240 Offset: 0x367B240 VA: 0x367F240
	public void .ctor(byte[] binary) { }

	// RVA: 0x367F248 Offset: 0x367B248 VA: 0x367F248
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x367F250 Offset: 0x367B250 VA: 0x367F250
	public byte get_WeaponType() { }

	[CompilerGenerated]
	// RVA: 0x367F258 Offset: 0x367B258 VA: 0x367F258
	protected void set_WeaponType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367F260 Offset: 0x367B260 VA: 0x367F260
	public short get_WeaponAtk() { }

	[CompilerGenerated]
	// RVA: 0x367F268 Offset: 0x367B268 VA: 0x367F268
	protected void set_WeaponAtk(short value) { }

	[CompilerGenerated]
	// RVA: 0x367F270 Offset: 0x367B270 VA: 0x367F270
	public byte get_WeaponRefine() { }

	[CompilerGenerated]
	// RVA: 0x367F278 Offset: 0x367B278 VA: 0x367F278
	protected void set_WeaponRefine(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367F280 Offset: 0x367B280 VA: 0x367F280
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x367F288 Offset: 0x367B288 VA: 0x367F288
	protected void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367F290 Offset: 0x367B290 VA: 0x367F290
	public byte get_PetType() { }

	[CompilerGenerated]
	// RVA: 0x367F298 Offset: 0x367B298 VA: 0x367F298
	protected void set_PetType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367F2A0 Offset: 0x367B2A0 VA: 0x367F2A0
	public byte get_Persona() { }

	[CompilerGenerated]
	// RVA: 0x367F2A8 Offset: 0x367B2A8 VA: 0x367F2A8
	protected void set_Persona(byte value) { }

	// RVA: 0x367F2B0 Offset: 0x367B2B0 VA: 0x367F2B0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x367F40C Offset: 0x367B40C VA: 0x367F40C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
