// Assembly: Toram.Common.dll
// Namespace: Toram.Common.MiniGame
public class MiniGameTeamData : UnityHashBase // TypeDefIndex: 11167
{
	// Fields
	[CompilerGenerated]
	private byte <TeamNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <MaxHp>k__BackingField; // 0x20
	[CompilerGenerated]
	private MiniGameMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <ItemDatas>k__BackingField; // 0x30

	// Properties
	public byte TeamNo { get; set; }
	public int Hp { get; set; }
	public int MaxHp { get; set; }
	public MiniGameMemberData[] Members { get; set; }
	public int[] ItemDatas { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35CEADC Offset: 0x35CAADC VA: 0x35CEADC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35CEAE4 Offset: 0x35CAAE4 VA: 0x35CEAE4
	public byte get_TeamNo() { }

	[CompilerGenerated]
	// RVA: 0x35CEAEC Offset: 0x35CAAEC VA: 0x35CEAEC
	public void set_TeamNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CEAF4 Offset: 0x35CAAF4 VA: 0x35CEAF4
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x35CEAFC Offset: 0x35CAAFC VA: 0x35CEAFC
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CEB04 Offset: 0x35CAB04 VA: 0x35CEB04
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x35CEB0C Offset: 0x35CAB0C VA: 0x35CEB0C
	public void set_MaxHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CEB14 Offset: 0x35CAB14 VA: 0x35CEB14
	public MiniGameMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x35CEB1C Offset: 0x35CAB1C VA: 0x35CEB1C
	public void set_Members(MiniGameMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CEB24 Offset: 0x35CAB24 VA: 0x35CEB24
	public int[] get_ItemDatas() { }

	[CompilerGenerated]
	// RVA: 0x35CEB2C Offset: 0x35CAB2C VA: 0x35CEB2C
	public void set_ItemDatas(int[] value) { }

	// RVA: 0x35CEB34 Offset: 0x35CAB34 VA: 0x35CEB34
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CEC70 Offset: 0x35CAC70 VA: 0x35CEC70
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CED30 Offset: 0x35CAD30 VA: 0x35CED30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35CED38 Offset: 0x35CAD38 VA: 0x35CED38 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35CF050 Offset: 0x35CB050 VA: 0x35CF050 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
