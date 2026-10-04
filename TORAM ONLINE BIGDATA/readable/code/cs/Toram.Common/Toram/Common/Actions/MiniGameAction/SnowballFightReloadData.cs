// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.MiniGameAction
public class SnowballFightReloadData : UnityHashBase // TypeDefIndex: 13231
{
	// Fields
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <ReloadTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BallNum>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 4)]
	public int Uuid { get; set; }
	[UnityHash(Code = 45)]
	public short ReloadTime { get; set; }
	public byte MiniGame { get; }
	[UnityHash(Code = 10, IsOptional = True)]
	public short[] Position { get; set; }
	public byte BallNum { get; set; }

	// Methods

	// RVA: 0x36E7850 Offset: 0x36E3850 VA: 0x36E7850 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36E7858 Offset: 0x36E3858 VA: 0x36E7858
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x36E7860 Offset: 0x36E3860 VA: 0x36E7860
	public void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E7868 Offset: 0x36E3868 VA: 0x36E7868
	public short get_ReloadTime() { }

	[CompilerGenerated]
	// RVA: 0x36E7870 Offset: 0x36E3870 VA: 0x36E7870
	public void set_ReloadTime(short value) { }

	// RVA: 0x36E7878 Offset: 0x36E3878 VA: 0x36E7878 Slot: 7
	public byte get_MiniGame() { }

	[CompilerGenerated]
	// RVA: 0x36E7880 Offset: 0x36E3880 VA: 0x36E7880
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E7888 Offset: 0x36E3888 VA: 0x36E7888
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36E7890 Offset: 0x36E3890 VA: 0x36E7890
	public byte get_BallNum() { }

	[CompilerGenerated]
	// RVA: 0x36E7898 Offset: 0x36E3898 VA: 0x36E7898
	public void set_BallNum(byte value) { }

	// RVA: 0x36E78A0 Offset: 0x36E38A0 VA: 0x36E78A0
	public void .ctor() { }

	// RVA: 0x36E78A8 Offset: 0x36E38A8 VA: 0x36E78A8
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36E78B0 Offset: 0x36E38B0 VA: 0x36E78B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36E7ABC Offset: 0x36E3ABC VA: 0x36E7ABC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
