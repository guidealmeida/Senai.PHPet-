namespace LHPet.models;


public class Foornecedor
{

  
    public int Id {get; set;}

    public string? Nome {get; set;}

    public string? Cnpj {get; set;}

    public string? Email {get; set;}

    


    public Foornecedor (int id, string nome, string cpf, string email, string paciente)
   {
       this.Id = id;
       this.Nome = nome;
       this.Cnpj = cnpj;
       this.Email = email;
       
   }

}