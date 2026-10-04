// Assembly: System.Core.dll
// Namespace: System.Runtime.CompilerServices
[DebuggerStepThrough]
[EditorBrowsable(1)]
public class RuleCache<T> // TypeDefIndex: 15752
{
	// Fields
	private T[] _rules; // 0x0
	private readonly object _cacheLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55584 Offset: 0x2C51584 VA: 0x2C55584
	|-RuleCache<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] GetRules() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55658 Offset: 0x2C51658 VA: 0x2C55658
	|-RuleCache<object>.GetRules
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55660 Offset: 0x2C51660 VA: 0x2C55660
	|-RuleCache<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C558D8 Offset: 0x2C518D8 VA: 0x2C558D8
	|-RuleCache<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	private static T[] AddOrInsert(T[] rules, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C559C0 Offset: 0x2C519C0 VA: 0x2C559C0
	|-RuleCache<object>.AddOrInsert
	*/
}
