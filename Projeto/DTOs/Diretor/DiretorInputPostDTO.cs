using FluentValidation;
public class DiretorInputPostDTO{

    public string Nome {get; set;}

    public  DiretorInputPostDTO(string nome){
        Nome = nome;
    }
}

public class DiretorInputPostDTOValidator : AbstractValidator<DiretorInputPostDTO>{

    public DiretorInputPostDTOValidator(){
        RuleFor(diretor => diretor.Nome).NotNull().NotEmpty();
        RuleFor(diretor => diretor.Nome).Length(2, 258).WithMessage("Tamanho {TotalLength} é invalido");
    }
}