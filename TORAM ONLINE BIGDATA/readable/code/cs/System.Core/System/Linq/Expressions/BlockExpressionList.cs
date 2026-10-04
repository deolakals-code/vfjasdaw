// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DefaultMember("Item")]
internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable // TypeDefIndex: 15269
{
	// Fields
	private readonly BlockExpression _block; // 0x10
	private readonly Expression _arg0; // 0x18

	// Properties
	public Expression Item { get; set; }
	public int Count { get; }
	[ExcludeFromCodeCoverage]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3131844 Offset: 0x312D844 VA: 0x3131844
	internal void .ctor(BlockExpression provider, Expression arg0) { }

	// RVA: 0x3132894 Offset: 0x312E894 VA: 0x3132894 Slot: 6
	public int IndexOf(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313291C Offset: 0x312E91C VA: 0x313291C Slot: 7
	public void Insert(int index, Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x3132944 Offset: 0x312E944 VA: 0x3132944 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x313296C Offset: 0x312E96C VA: 0x313296C Slot: 4
	public Expression get_Item(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313299C Offset: 0x312E99C VA: 0x313299C Slot: 5
	public void set_Item(int index, Expression value) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x31329C4 Offset: 0x312E9C4 VA: 0x31329C4 Slot: 11
	public void Add(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x31329EC Offset: 0x312E9EC VA: 0x31329EC Slot: 12
	public void Clear() { }

	// RVA: 0x3132A14 Offset: 0x312EA14 VA: 0x3132A14 Slot: 13
	public bool Contains(Expression item) { }

	// RVA: 0x3132A2C Offset: 0x312EA2C VA: 0x3132A2C Slot: 14
	public void CopyTo(Expression[] array, int index) { }

	// RVA: 0x3132BC8 Offset: 0x312EBC8 VA: 0x3132BC8 Slot: 9
	public int get_Count() { }

	// RVA: 0x3132BE8 Offset: 0x312EBE8 VA: 0x3132BE8 Slot: 10
	public bool get_IsReadOnly() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x3132C10 Offset: 0x312EC10 VA: 0x3132C10 Slot: 15
	public bool Remove(Expression item) { }

	[IteratorStateMachine(typeof(BlockExpressionList.<GetEnumerator>d__18))]
	// RVA: 0x3132C38 Offset: 0x312EC38 VA: 0x3132C38 Slot: 16
	public IEnumerator<Expression> GetEnumerator() { }

	// RVA: 0x3132CCC Offset: 0x312ECCC VA: 0x3132CCC Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}
