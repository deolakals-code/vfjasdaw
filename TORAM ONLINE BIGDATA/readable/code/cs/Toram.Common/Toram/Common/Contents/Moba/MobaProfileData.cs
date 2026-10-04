// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaProfileData : PacketBase // TypeDefIndex: 11226
{
	// Fields
	public const int DuelAbilityMax = 3;
	public const int DefenceMax = 12;
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <Defence>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <DuelAbility>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsEnable>k__BackingField; // 0x40

	// Properties
	public string Name { get; set; }
	public byte Element { get; set; }
	public byte[] Defence { get; set; }
	public int[] DuelAbility { get; set; }
	public bool IsEnable { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36CB050 Offset: 0x36C7050 VA: 0x36CB050
	public void .ctor() { }

	// RVA: 0x36CB058 Offset: 0x36C7058 VA: 0x36CB058
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36CB060 Offset: 0x36C7060 VA: 0x36CB060
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36CB068 Offset: 0x36C7068 VA: 0x36CB068
	protected void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x36CB070 Offset: 0x36C7070 VA: 0x36CB070
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x36CB078 Offset: 0x36C7078 VA: 0x36CB078
	protected void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CB080 Offset: 0x36C7080 VA: 0x36CB080
	public byte[] get_Defence() { }

	[CompilerGenerated]
	// RVA: 0x36CB088 Offset: 0x36C7088 VA: 0x36CB088
	protected void set_Defence(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36CB090 Offset: 0x36C7090 VA: 0x36CB090
	public int[] get_DuelAbility() { }

	[CompilerGenerated]
	// RVA: 0x36CB098 Offset: 0x36C7098 VA: 0x36CB098
	protected void set_DuelAbility(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x36CB0A0 Offset: 0x36C70A0 VA: 0x36CB0A0
	public bool get_IsEnable() { }

	[CompilerGenerated]
	// RVA: 0x36CB0A8 Offset: 0x36C70A8 VA: 0x36CB0A8
	protected void set_IsEnable(bool value) { }

	// RVA: 0x36CB0B4 Offset: 0x36C70B4 VA: 0x36CB0B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36CB0BC Offset: 0x36C70BC VA: 0x36CB0BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36CB208 Offset: 0x36C7208 VA: 0x36CB208 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
