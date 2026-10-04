// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetSynthesisData // TypeDefIndex: 7748
{
	// Fields
	[CompilerGenerated]
	private long[] <targetPets>k__BackingField; // 0x10
	[CompilerGenerated]
	private long[] <choices>k__BackingField; // 0x18
	[CompilerGenerated]
	private int[] <skills>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <useOrb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <haveOrb>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool[] <isColorUseOrb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <skillsLv>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <typePetParam>k__BackingField; // 0x40
	[CompilerGenerated]
	private PetSynthesisType <selectedPetType>k__BackingField; // 0x44

	// Properties
	public long[] targetPets { get; set; }
	public long[] choices { get; set; }
	public int[] skills { get; set; }
	public int useOrb { get; set; }
	public int haveOrb { get; set; }
	public bool[] isColorUseOrb { get; set; }
	public long[] Colors { get; }
	public int[] skillsLv { get; set; }
	public int typePetParam { get; set; }
	public PetSynthesisType selectedPetType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C00338 Offset: 0x1BFC338 VA: 0x1C00338
	public long[] get_targetPets() { }

	[CompilerGenerated]
	// RVA: 0x1C00340 Offset: 0x1BFC340 VA: 0x1C00340
	private void set_targetPets(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x1C00348 Offset: 0x1BFC348 VA: 0x1C00348
	public long[] get_choices() { }

	[CompilerGenerated]
	// RVA: 0x1C00350 Offset: 0x1BFC350 VA: 0x1C00350
	private void set_choices(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x1C00358 Offset: 0x1BFC358 VA: 0x1C00358
	public int[] get_skills() { }

	[CompilerGenerated]
	// RVA: 0x1C00360 Offset: 0x1BFC360 VA: 0x1C00360
	private void set_skills(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x1C00368 Offset: 0x1BFC368 VA: 0x1C00368
	public int get_useOrb() { }

	[CompilerGenerated]
	// RVA: 0x1C00370 Offset: 0x1BFC370 VA: 0x1C00370
	private void set_useOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C00378 Offset: 0x1BFC378 VA: 0x1C00378
	public int get_haveOrb() { }

	[CompilerGenerated]
	// RVA: 0x1C00380 Offset: 0x1BFC380 VA: 0x1C00380
	private void set_haveOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C00388 Offset: 0x1BFC388 VA: 0x1C00388
	public bool[] get_isColorUseOrb() { }

	[CompilerGenerated]
	// RVA: 0x1C00390 Offset: 0x1BFC390 VA: 0x1C00390
	private void set_isColorUseOrb(bool[] value) { }

	// RVA: 0x1C00398 Offset: 0x1BFC398 VA: 0x1C00398
	public long[] get_Colors() { }

	[CompilerGenerated]
	// RVA: 0x1C0044C Offset: 0x1BFC44C VA: 0x1C0044C
	public int[] get_skillsLv() { }

	[CompilerGenerated]
	// RVA: 0x1C00454 Offset: 0x1BFC454 VA: 0x1C00454
	private void set_skillsLv(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x1C0045C Offset: 0x1BFC45C VA: 0x1C0045C
	public int get_typePetParam() { }

	[CompilerGenerated]
	// RVA: 0x1C00464 Offset: 0x1BFC464 VA: 0x1C00464
	private void set_typePetParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C0046C Offset: 0x1BFC46C VA: 0x1C0046C
	public PetSynthesisType get_selectedPetType() { }

	[CompilerGenerated]
	// RVA: 0x1C00474 Offset: 0x1BFC474 VA: 0x1C00474
	private void set_selectedPetType(PetSynthesisType value) { }

	// RVA: 0x1C0047C Offset: 0x1BFC47C VA: 0x1C0047C
	public void .ctor() { }

	// RVA: 0x1C00590 Offset: 0x1BFC590 VA: 0x1C00590
	public void SetTargetPet(long pet1, long pet2) { }

	// RVA: 0x1C0061C Offset: 0x1BFC61C VA: 0x1C0061C
	public void SetChoices(PetSynthesisType type, long petUuid) { }

	// RVA: 0x1C0064C Offset: 0x1BFC64C VA: 0x1C0064C
	public void SetSkill(int targetPet, int skillId, int skillLv) { }

	// RVA: 0x1C0069C Offset: 0x1BFC69C VA: 0x1C0069C
	public void SetType(PetSynthesisType type, long petUuid, int param) { }

	// RVA: 0x1C0074C Offset: 0x1BFC74C VA: 0x1C0074C
	public void SetColorUseOrb(bool[] useOrb) { }

	// RVA: 0x1C007B4 Offset: 0x1BFC7B4 VA: 0x1C007B4
	public void SetUseOrbNum(int num) { }

	// RVA: 0x1C007BC Offset: 0x1BFC7BC VA: 0x1C007BC
	public void SetHaveOrbNum(int num) { }
}
