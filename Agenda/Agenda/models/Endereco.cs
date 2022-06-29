namespace Agenda.models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public int UF_Id { get; set; }

        #region Navigation Properties
        public virtual UF UF { get; set; }
        #endregion
    }
}
