// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BattleManagerBase.TargetData // TypeDefIndex: 326
{
	// Fields
	[CompilerGenerated]
	private BattleManagerBase.NextTargetType <TargetType>k__BackingField; // 0x10
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x18
	[CompilerGenerated]
	private CharacterActionManagerBase <ActionManager>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <TargetSize>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IgnoreDelay>k__BackingField; // 0x2C

	// Properties
	public BattleManagerBase.NextTargetType TargetType { get; set; }
	public GameObject Target { get; set; }
	public CharacterActionManagerBase ActionManager { get; set; }
	public float TargetSize { get; set; }
	public bool HasTarget { get; }
	public bool IgnoreDelay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2482220 Offset: 0x247E220 VA: 0x2482220
	public BattleManagerBase.NextTargetType get_TargetType() { }

	[CompilerGenerated]
	// RVA: 0x2482228 Offset: 0x247E228 VA: 0x2482228
	private void set_TargetType(BattleManagerBase.NextTargetType value) { }

	[CompilerGenerated]
	// RVA: 0x2482230 Offset: 0x247E230 VA: 0x2482230
	public GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x2482238 Offset: 0x247E238 VA: 0x2482238
	private void set_Target(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2482240 Offset: 0x247E240 VA: 0x2482240
	public CharacterActionManagerBase get_ActionManager() { }

	[CompilerGenerated]
	// RVA: 0x2482248 Offset: 0x247E248 VA: 0x2482248
	private void set_ActionManager(CharacterActionManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x2482250 Offset: 0x247E250 VA: 0x2482250
	public float get_TargetSize() { }

	[CompilerGenerated]
	// RVA: 0x2482258 Offset: 0x247E258 VA: 0x2482258
	private void set_TargetSize(float value) { }

	// RVA: 0x2480E9C Offset: 0x247CE9C VA: 0x2480E9C
	public bool get_HasTarget() { }

	[CompilerGenerated]
	// RVA: 0x2482260 Offset: 0x247E260 VA: 0x2482260
	public bool get_IgnoreDelay() { }

	[CompilerGenerated]
	// RVA: 0x2482268 Offset: 0x247E268 VA: 0x2482268
	private void set_IgnoreDelay(bool value) { }

	// RVA: 0x24819B4 Offset: 0x247D9B4 VA: 0x24819B4
	public void SetTarget(GameObject target, CharacterActionManagerBase actionManager, float size, BattleManagerBase.NextTargetType type, bool ignoreDelay) { }

	// RVA: 0x2480FBC Offset: 0x247CFBC VA: 0x2480FBC
	public void Clear() { }

	// RVA: 0x2482218 Offset: 0x247E218 VA: 0x2482218
	public void .ctor() { }
}
