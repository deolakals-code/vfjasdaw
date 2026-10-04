// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Cuisine
public class CuisineSendData : UnityHashBase // TypeDefIndex: 12535
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Lv>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <EndTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <RemainingTime>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 245)]
	public byte Type { get; set; }
	[UnityHash(Code = 200)]
	public int Id { get; set; }
	[UnityHash(Code = 29)]
	public byte Lv { get; set; }
	public DateTime EndTime { get; }
	[UnityHash(Code = 189)]
	public int RemainingTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x361A954 Offset: 0x3616954 VA: 0x361A954
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x361A95C Offset: 0x361695C VA: 0x361A95C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x361A964 Offset: 0x3616964 VA: 0x361A964
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361A96C Offset: 0x361696C VA: 0x361A96C
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x361A974 Offset: 0x3616974 VA: 0x361A974
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x361A97C Offset: 0x361697C VA: 0x361A97C
	public byte get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x361A984 Offset: 0x3616984 VA: 0x361A984
	public void set_Lv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361A98C Offset: 0x361698C VA: 0x361A98C
	public DateTime get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x361A994 Offset: 0x3616994 VA: 0x361A994
	public int get_RemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x361A99C Offset: 0x361699C VA: 0x361A99C
	public void set_RemainingTime(int value) { }

	// RVA: 0x361A9A4 Offset: 0x36169A4 VA: 0x361A9A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3616484 Offset: 0x3612484 VA: 0x3616484
	public void CalcRemainingTime() { }

	// RVA: 0x361A9AC Offset: 0x36169AC VA: 0x361A9AC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x361AC18 Offset: 0x3616C18 VA: 0x361AC18 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
