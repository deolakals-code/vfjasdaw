// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 15882
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingCollection { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingCollection();
}
