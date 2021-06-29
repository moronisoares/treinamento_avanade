namespace Avanade.SubTCSE.Projeto.Domain.Aggregates
{
    public abstract record BaseEntity<Tid>
    {
        public string Id { get; set; }
    }
}
