using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson 
        { 
            Id = id, 
            Name = "Biscoito", 
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2021, month: 07, day: 26),
        };
    }
}
