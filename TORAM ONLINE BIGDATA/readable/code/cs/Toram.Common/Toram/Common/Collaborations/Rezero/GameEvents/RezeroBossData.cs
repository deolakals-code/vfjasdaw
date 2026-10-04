// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.Rezero.GameEvents
public class RezeroBossData : MobData // TypeDefIndex: 13058
{
	// Fields
	[CompilerGenerated]
	private short[] <MovePos>k__BackingField; // 0x68
	[CompilerGenerated]
	private byte <NowAction>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <AttackType>k__BackingField; // 0x71
	[CompilerGenerated]
	private byte <AttackPosType>k__BackingField; // 0x72
	[CompilerGenerated]
	private byte <ActionState>k__BackingField; // 0x73
	[CompilerGenerated]
	private byte <PressPosIndex>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <ElapsedTime>k__BackingField; // 0x78

	// Properties
	[UnityHash(Code = 199, IsOptional = True)]
	public short[] MovePos { get; set; }
	[UnityHash(Code = 75)]
	public byte NowAction { get; set; }
	[UnityHash(Code = 130, IsOptional = True)]
	public byte AttackType { get; set; }
	[UnityHash(Code = 245, IsOptional = True)]
	public byte AttackPosType { get; set; }
	[UnityHash(Code = 43, IsOptional = True)]
	public byte ActionState { get; set; }
	[UnityHash(Code = 153)]
	public byte PressPosIndex { get; set; }
	[UnityHash(Code = 172)]
	public int ElapsedTime { get; set; }

	// Methods

	// RVA: 0x36994B4 Offset: 0x36954B4 VA: 0x36994B4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36994BC Offset: 0x36954BC VA: 0x36994BC
	public short[] get_MovePos() { }

	[CompilerGenerated]
	// RVA: 0x36994C4 Offset: 0x36954C4 VA: 0x36994C4
	public void set_MovePos(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36994CC Offset: 0x36954CC VA: 0x36994CC
	public byte get_NowAction() { }

	[CompilerGenerated]
	// RVA: 0x36994D4 Offset: 0x36954D4 VA: 0x36994D4
	public void set_NowAction(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36994DC Offset: 0x36954DC VA: 0x36994DC
	public byte get_AttackType() { }

	[CompilerGenerated]
	// RVA: 0x36994E4 Offset: 0x36954E4 VA: 0x36994E4
	public void set_AttackType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36994EC Offset: 0x36954EC VA: 0x36994EC
	public byte get_AttackPosType() { }

	[CompilerGenerated]
	// RVA: 0x36994F4 Offset: 0x36954F4 VA: 0x36994F4
	public void set_AttackPosType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36994FC Offset: 0x36954FC VA: 0x36994FC
	public byte get_ActionState() { }

	[CompilerGenerated]
	// RVA: 0x3699504 Offset: 0x3695504 VA: 0x3699504
	public void set_ActionState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369950C Offset: 0x369550C VA: 0x369950C
	public byte get_PressPosIndex() { }

	[CompilerGenerated]
	// RVA: 0x3699514 Offset: 0x3695514 VA: 0x3699514
	public void set_PressPosIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369951C Offset: 0x369551C VA: 0x369951C
	public int get_ElapsedTime() { }

	[CompilerGenerated]
	// RVA: 0x3699524 Offset: 0x3695524 VA: 0x3699524
	public void set_ElapsedTime(int value) { }

	// RVA: 0x369952C Offset: 0x369552C VA: 0x369952C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x369978C Offset: 0x369578C VA: 0x369978C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
