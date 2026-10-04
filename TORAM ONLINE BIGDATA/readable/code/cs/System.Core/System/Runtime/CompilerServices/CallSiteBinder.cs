// Assembly: System.Core.dll
// Namespace: System.Runtime.CompilerServices
public abstract class CallSiteBinder // TypeDefIndex: 15747
{
	// Fields
	internal Dictionary<Type, object> Cache; // 0x10
	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; // 0x0

	// Properties
	public static LabelTarget UpdateLabel { get; }

	// Methods

	// RVA: 0x3181838 Offset: 0x317D838 VA: 0x3181838
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3181840 Offset: 0x317D840 VA: 0x3181840
	public static LabelTarget get_UpdateLabel() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T BindDelegate<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DDF68 Offset: 0x27D9F68 VA: 0x27DDF68
	|-CallSiteBinder.BindDelegate<object>
	*/

	// RVA: -1 Offset: -1
	internal T BindCore<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DDE40 Offset: 0x27D9E40 VA: 0x27DDE40
	|-CallSiteBinder.BindCore<object>
	*/

	// RVA: -1 Offset: -1
	protected void CacheTarget<T>(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DDF70 Offset: 0x27D9F70 VA: 0x27DDF70
	|-CallSiteBinder.CacheTarget<object>
	*/

	// RVA: -1 Offset: -1
	private static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE244 Offset: 0x27DA244 VA: 0x27DE244
	|-CallSiteBinder.Stitch<object>
	*/

	// RVA: -1 Offset: -1
	internal RuleCache<T> GetRuleCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DDFC4 Offset: 0x27D9FC4 VA: 0x27DDFC4
	|-CallSiteBinder.GetRuleCache<object>
	*/

	// RVA: 0x3181898 Offset: 0x317D898 VA: 0x3181898
	private static void .cctor() { }
}
