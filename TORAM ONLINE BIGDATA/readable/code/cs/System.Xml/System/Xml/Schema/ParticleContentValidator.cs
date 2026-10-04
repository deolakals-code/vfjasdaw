// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 13611
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x341E778 Offset: 0x341A778 VA: 0x341E778
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x341E780 Offset: 0x341A780 VA: 0x341E780
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x341E800 Offset: 0x341A800 VA: 0x341E800 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x341E838 Offset: 0x341A838 VA: 0x341E838 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x341E870 Offset: 0x341A870 VA: 0x341E870 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x341E8A8 Offset: 0x341A8A8 VA: 0x341E8A8
	public void Start() { }

	// RVA: 0x341E978 Offset: 0x341A978 VA: 0x341E978
	public void OpenGroup() { }

	// RVA: 0x341E9A0 Offset: 0x341A9A0 VA: 0x341E9A0
	public void CloseGroup() { }

	// RVA: 0x341EB14 Offset: 0x341AB14 VA: 0x341EB14
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x341EB4C Offset: 0x341AB4C VA: 0x341EB4C
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x341ECE4 Offset: 0x341ACE4 VA: 0x341ECE4
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x341EBF4 Offset: 0x341ABF4 VA: 0x341EBF4
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x341ED70 Offset: 0x341AD70 VA: 0x341ED70
	public void AddChoice() { }

	// RVA: 0x341EE5C Offset: 0x341AE5C VA: 0x341EE5C
	public void AddSequence() { }

	// RVA: 0x341EF48 Offset: 0x341AF48 VA: 0x341EF48
	public void AddStar() { }

	// RVA: 0x341F140 Offset: 0x341B140 VA: 0x341F140
	public void AddPlus() { }

	// RVA: 0x341F19C Offset: 0x341B19C VA: 0x341F19C
	public void AddQMark() { }

	// RVA: 0x341F1F8 Offset: 0x341B1F8 VA: 0x341F1F8
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x341EFA4 Offset: 0x341AFA4 VA: 0x341EFA4
	private void Closure(InteriorNode node) { }

	// RVA: 0x341F2EC Offset: 0x341B2EC VA: 0x341F2EC
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x341F878 Offset: 0x341B878 VA: 0x341F878
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x341FCA0 Offset: 0x341BCA0 VA: 0x341FCA0
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x341FB30 Offset: 0x341BB30 VA: 0x341FB30
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x341FE0C Offset: 0x341BE0C VA: 0x341FE0C
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x34204E8 Offset: 0x341C4E8 VA: 0x34204E8
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x341FE94 Offset: 0x341BE94 VA: 0x341FE94
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }
}
