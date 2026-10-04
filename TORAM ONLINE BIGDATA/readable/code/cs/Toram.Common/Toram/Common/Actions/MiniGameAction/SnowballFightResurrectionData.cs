// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.MiniGameAction
public class SnowballFightResurrectionData : UnityHashBase // TypeDefIndex: 13232
{
	// Fields
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <CameraRot>k__BackingField; // 0x2A

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 4)]
	public int Uuid { get; set; }
	[UnityHash(Code = 10)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11)]
	public short Rotation { get; set; }
	[UnityHash(Code = 55)]
	public short CameraRot { get; set; }
	public byte MiniGame { get; }

	// Methods

	// RVA: 0x36E7DD8 Offset: 0x36E3DD8 VA: 0x36E7DD8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36E7DE0 Offset: 0x36E3DE0 VA: 0x36E7DE0
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x36E7DE8 Offset: 0x36E3DE8 VA: 0x36E7DE8
	public void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E7DF0 Offset: 0x36E3DF0 VA: 0x36E7DF0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E7DF8 Offset: 0x36E3DF8 VA: 0x36E7DF8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36E7E00 Offset: 0x36E3E00 VA: 0x36E7E00
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36E7E08 Offset: 0x36E3E08 VA: 0x36E7E08
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36E7E10 Offset: 0x36E3E10 VA: 0x36E7E10
	public short get_CameraRot() { }

	[CompilerGenerated]
	// RVA: 0x36E7E18 Offset: 0x36E3E18 VA: 0x36E7E18
	public void set_CameraRot(short value) { }

	// RVA: 0x36E7E20 Offset: 0x36E3E20 VA: 0x36E7E20 Slot: 7
	public byte get_MiniGame() { }

	// RVA: 0x36E7E28 Offset: 0x36E3E28 VA: 0x36E7E28
	public void .ctor() { }

	// RVA: 0x36E7E30 Offset: 0x36E3E30 VA: 0x36E7E30
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36E7E38 Offset: 0x36E3E38 VA: 0x36E7E38 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36E803C Offset: 0x36E403C VA: 0x36E803C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
