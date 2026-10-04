// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightAbnormalManager // TypeDefIndex: 4146
{
	// Fields
	private Dictionary<AbnormalType, BlackKnightAbnormalManager.AbnormalData> abnormalList; // 0x10
	private List<BlackKnightAbnormalManager.AbnormalData> _abnormalList; // 0x18

	// Properties
	public bool IsActionLock { get; }

	// Methods

	// RVA: 0x2491110 Offset: 0x248D110 VA: 0x2491110
	public bool get_IsActionLock() { }

	// RVA: 0x24911F4 Offset: 0x248D1F4 VA: 0x24911F4
	public void .ctor() { }

	// RVA: 0x2491328 Offset: 0x248D328 VA: 0x2491328
	public void Update() { }

	// RVA: 0x2491600 Offset: 0x248D600 VA: 0x2491600
	public bool AddAbnormal(AbnormalType type, float effectTime, float resistTime) { }

	// RVA: 0x2491608 Offset: 0x248D608 VA: 0x2491608
	public bool AddAbnormal(AbnormalType type, float effectTime, float resistTime, Action callBack) { }

	// RVA: 0x24917FC Offset: 0x248D7FC VA: 0x24917FC
	public bool RemoveAbnormal(AbnormalType type) { }

	// RVA: 0x2491758 Offset: 0x248D758 VA: 0x2491758
	public bool ContainsAbnormalType(AbnormalType type) { }

	// RVA: 0x2491170 Offset: 0x248D170 VA: 0x2491170
	public bool CheckActiveAbnormalType(AbnormalType type) { }

	// RVA: 0x24918D8 Offset: 0x248D8D8 VA: 0x24918D8
	public void EndAbnormalEffect(AbnormalType type) { }
}
