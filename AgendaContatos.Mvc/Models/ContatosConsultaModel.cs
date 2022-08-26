namespace AgendaContatos.Mvc.Models
{
    public class ContatosConsultaModel
    {
        public Guid IdContato { get; set; }
        public string Nome { get; set; }
        public String DataNascimento { get; set; }
        public string Telefone { get; set; }
        public String Email { get; set; }
        public int Idade { get; set; }
    }
}
