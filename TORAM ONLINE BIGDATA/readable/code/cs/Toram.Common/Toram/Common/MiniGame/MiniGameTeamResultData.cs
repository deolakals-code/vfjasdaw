// Assembly: Toram.Common.dll
// Namespace: Toram.Common.MiniGame
public class MiniGameTeamResultData : UnityHashBase // TypeDefIndex: 11165
{
	// Fields
	[CompilerGenerated]
	private byte <TeamNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <MaxHp>k__BackingField; // 0x20
	[CompilerGenerated]
	private MiniGameMemberResultData[] <Members>k__BackingField; // 0x28

	// Properties
	public byte TeamNo { get; set; }
	public int Hp { get; set; }
	public int MaxHp { get; set; }
	public MiniGameMemberResultData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35CE020 Offset: 0x35CA020 VA: 0x35CE020
	public void .ctor() { }

	// RVA: 0x35CD490 Offset: 0x35C9490 VA: 0x35CD490
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35CE028 Offset: 0x35CA028 VA: 0x35CE028
	public byte get_TeamNo() { }

	[CompilerGenerated]
	// RVA: 0x35CE030 Offset: 0x35CA030 VA: 0x35CE030
	public void set_TeamNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CE038 Offset: 0x35CA038 VA: 0x35CE038
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x35CE040 Offset: 0x35CA040 VA: 0x35CE040
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CE048 Offset: 0x35CA048 VA: 0x35CE048
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x35CE050 Offset: 0x35CA050 VA: 0x35CE050
	public void set_MaxHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CE058 Offset: 0x35CA058 VA: 0x35CE058
	public MiniGameMemberResultData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x35CE060 Offset: 0x35CA060 VA: 0x35CE060
	public void set_Members(MiniGameMemberResultData[] value) { }

	// RVA: 0x35CE068 Offset: 0x35CA068 VA: 0x35CE068
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CE1A4 Offset: 0x35CA1A4 VA: 0x35CE1A4
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CE264 Offset: 0x35CA264 VA: 0x35CE264 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35CE26C Offset: 0x35CA26C VA: 0x35CE26C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35CE4D0 Offset: 0x35CA4D0 VA: 0x35CE4D0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
