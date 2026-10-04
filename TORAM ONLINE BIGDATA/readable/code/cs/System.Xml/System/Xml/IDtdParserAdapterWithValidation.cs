// Assembly: System.Xml.dll
// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 13291
{
	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();
}
