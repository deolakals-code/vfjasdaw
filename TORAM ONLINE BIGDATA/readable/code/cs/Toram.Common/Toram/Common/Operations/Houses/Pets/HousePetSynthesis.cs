// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetSynthesis : OperationRequestBase // TypeDefIndex: 12329
{
	// Fields
	[CompilerGenerated]
	private long[] <TargetPets>k__BackingField; // 0x20
	[CompilerGenerated]
	private long[] <Choices>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <Skills>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x3C

	// Properties
	public long[] TargetPets { get; set; }
	public long[] Choices { get; set; }
	public int[] Skills { get; set; }
	public int UseOrb { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F4970 Offset: 0x35F0970 VA: 0x35F4970
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F4978 Offset: 0x35F0978 VA: 0x35F4978
	public long[] get_TargetPets() { }

	[CompilerGenerated]
	// RVA: 0x35F4980 Offset: 0x35F0980 VA: 0x35F4980
	public void set_TargetPets(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F4988 Offset: 0x35F0988 VA: 0x35F4988
	public long[] get_Choices() { }

	[CompilerGenerated]
	// RVA: 0x35F4990 Offset: 0x35F0990 VA: 0x35F4990
	public void set_Choices(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F4998 Offset: 0x35F0998 VA: 0x35F4998
	public int[] get_Skills() { }

	[CompilerGenerated]
	// RVA: 0x35F49A0 Offset: 0x35F09A0 VA: 0x35F49A0
	public void set_Skills(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F49A8 Offset: 0x35F09A8 VA: 0x35F49A8
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F49B0 Offset: 0x35F09B0 VA: 0x35F49B0
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F49B8 Offset: 0x35F09B8 VA: 0x35F49B8
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F49C0 Offset: 0x35F09C0 VA: 0x35F49C0
	public void set_Orb(int value) { }

	// RVA: 0x35F49C8 Offset: 0x35F09C8 VA: 0x35F49C8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F49CC Offset: 0x35F09CC VA: 0x35F49CC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F49D0 Offset: 0x35F09D0 VA: 0x35F49D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F49D8 Offset: 0x35F09D8 VA: 0x35F49D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F49E0 Offset: 0x35F09E0 VA: 0x35F49E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4C6C Offset: 0x35F0C6C VA: 0x35F4C6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
