namespace Avanade_SubTCSE_Projeto.Domain.Aggregates
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
