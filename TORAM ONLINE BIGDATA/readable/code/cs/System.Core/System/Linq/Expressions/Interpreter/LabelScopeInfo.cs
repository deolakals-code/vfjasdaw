// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelScopeInfo // TypeDefIndex: 15517
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x315B42C Offset: 0x315742C VA: 0x315B42C
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x315B308 Offset: 0x3157308 VA: 0x315B308
	internal bool get_CanJumpInto() { }

	// RVA: 0x315ADA4 Offset: 0x3156DA4 VA: 0x315ADA4
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x315B468 Offset: 0x3157468 VA: 0x315B468
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x315AF40 Offset: 0x3156F40 VA: 0x315AF40
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}
