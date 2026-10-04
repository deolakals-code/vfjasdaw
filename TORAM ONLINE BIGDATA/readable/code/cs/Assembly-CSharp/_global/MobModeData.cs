// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobModeData // TypeDefIndex: 964
{
	// Fields
	private byte modeId; // 0x10
	private short trigger; // 0x12
	private int value; // 0x14
	private int targetMonsterId; // 0x18
	private int auraModel; // 0x1C
	private byte auraMotion; // 0x20
	private int auraColor; // 0x24
	private int ignitionModel; // 0x28
	private byte ignitionMotion; // 0x2C
	private int ignitionColor; // 0x30
	private int flag; // 0x34
	private short combo; // 0x38

	// Properties
	public int ModeId { get; }
	public int Trigger { get; }
	public int Value { get; }
	public int TargetMonsterId { get; }
	public int AuraModel { get; }
	public int AuraMotion { get; }
	public int AuraColor { get; }
	public int IgnitionModel { get; }
	public int IgnitionMotion { get; }
	public int IgnitionColor { get; }
	public int Flag { get; }
	public int Combo { get; }

	// Methods

	// RVA: 0x1F2C118 Offset: 0x1F28118 VA: 0x1F2C118
	public int get_ModeId() { }

	// RVA: 0x1F2C120 Offset: 0x1F28120 VA: 0x1F2C120
	public int get_Trigger() { }

	// RVA: 0x1F2C128 Offset: 0x1F28128 VA: 0x1F2C128
	public int get_Value() { }

	// RVA: 0x1F2C130 Offset: 0x1F28130 VA: 0x1F2C130
	public int get_TargetMonsterId() { }

	// RVA: 0x1F2C138 Offset: 0x1F28138 VA: 0x1F2C138
	public int get_AuraModel() { }

	// RVA: 0x1F2C140 Offset: 0x1F28140 VA: 0x1F2C140
	public int get_AuraMotion() { }

	// RVA: 0x1F2C148 Offset: 0x1F28148 VA: 0x1F2C148
	public int get_AuraColor() { }

	// RVA: 0x1F2C150 Offset: 0x1F28150 VA: 0x1F2C150
	public int get_IgnitionModel() { }

	// RVA: 0x1F2C158 Offset: 0x1F28158 VA: 0x1F2C158
	public int get_IgnitionMotion() { }

	// RVA: 0x1F2C160 Offset: 0x1F28160 VA: 0x1F2C160
	public int get_IgnitionColor() { }

	// RVA: 0x1F2C168 Offset: 0x1F28168 VA: 0x1F2C168
	public int get_Flag() { }

	// RVA: 0x1F2C170 Offset: 0x1F28170 VA: 0x1F2C170
	public int get_Combo() { }

	// RVA: 0x1F2C178 Offset: 0x1F28178 VA: 0x1F2C178
	public static MobModeData CreateModeData(BinaryReader reader) { }

	// RVA: 0x1F2C2F0 Offset: 0x1F282F0 VA: 0x1F2C2F0
	public void .ctor() { }
}
