// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildMemberData // TypeDefIndex: 1924
{
	// Fields
	public int Id; // 0x10
	public string UserName; // 0x18
	public int Level; // 0x20
	public string Date; // 0x28
	public byte State; // 0x30
	public byte Authority; // 0x31
	public int Contribution; // 0x34
	public int WorldId; // 0x38
	public DateTime LoginDate; // 0x40
	public int FieldId; // 0x48
	public byte FieldType; // 0x4C

	// Properties
	public bool IsOnline { get; }
	public bool IsPending { get; }
	public bool IsAnotherWorld { get; }
	public bool IsSubMaster { get; }
	public bool IsWriter { get; }
	public bool IsInviter { get; }

	// Methods

	// RVA: 0x20FE75C Offset: 0x20FA75C VA: 0x20FE75C
	public void .ctor(int id) { }

	// RVA: 0x20FCBA4 Offset: 0x20F8BA4 VA: 0x20FCBA4
	public void .ctor(int id, string userName, int level, DateTime date, byte state, byte authority, int contribution, int worldId, DateTime loginDate, int fieldId, byte fieldType) { }

	// RVA: 0x2104D94 Offset: 0x2100D94 VA: 0x2104D94
	public bool get_IsOnline() { }

	// RVA: 0x20FCDF4 Offset: 0x20F8DF4 VA: 0x20FCDF4
	public bool get_IsPending() { }

	// RVA: 0x2108488 Offset: 0x2104488 VA: 0x2108488
	public bool get_IsAnotherWorld() { }

	// RVA: 0x21084EC Offset: 0x21044EC VA: 0x21084EC
	public bool get_IsSubMaster() { }

	// RVA: 0x21084F8 Offset: 0x21044F8 VA: 0x21084F8
	public bool get_IsWriter() { }

	// RVA: 0x2108504 Offset: 0x2104504 VA: 0x2108504
	public bool get_IsInviter() { }
}
