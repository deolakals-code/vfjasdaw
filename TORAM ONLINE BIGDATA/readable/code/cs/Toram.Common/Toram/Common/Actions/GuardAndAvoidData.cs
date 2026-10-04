// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class GuardAndAvoidData : UnityHashBase // TypeDefIndex: 13179
{
	// Fields
	[CompilerGenerated]
	private byte <ActionType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Param>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int[] <ClientParam>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 18, IsOptional = False)]
	public byte ActionType { get; set; }
	[UnityHash(Code = 55, IsOptional = False)]
	public int Param { get; set; }
	public int[] ClientParam { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }

	// Methods

	// RVA: 0x36C00CC Offset: 0x36BC0CC VA: 0x36C00CC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C00D4 Offset: 0x36BC0D4 VA: 0x36C00D4
	public byte get_ActionType() { }

	[CompilerGenerated]
	// RVA: 0x36C00DC Offset: 0x36BC0DC VA: 0x36C00DC
	public void set_ActionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C00E4 Offset: 0x36BC0E4 VA: 0x36C00E4
	public int get_Param() { }

	[CompilerGenerated]
	// RVA: 0x36C00EC Offset: 0x36BC0EC VA: 0x36C00EC
	public void set_Param(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C00F4 Offset: 0x36BC0F4 VA: 0x36C00F4
	public int[] get_ClientParam() { }

	[CompilerGenerated]
	// RVA: 0x36C00FC Offset: 0x36BC0FC VA: 0x36C00FC
	public void set_ClientParam(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C0104 Offset: 0x36BC104 VA: 0x36C0104
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36C010C Offset: 0x36BC10C VA: 0x36C010C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C0114 Offset: 0x36BC114 VA: 0x36C0114
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36C011C Offset: 0x36BC11C VA: 0x36C011C
	public void set_Rotation(short value) { }

	// RVA: 0x36C0124 Offset: 0x36BC124 VA: 0x36C0124
	public void .ctor() { }

	// RVA: 0x36C012C Offset: 0x36BC12C VA: 0x36C012C
	public void .ctor(Dictionary<object, object> parameter) { }

	// RVA: 0x36C0134 Offset: 0x36BC134 VA: 0x36C0134 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C0330 Offset: 0x36BC330 VA: 0x36C0330 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
