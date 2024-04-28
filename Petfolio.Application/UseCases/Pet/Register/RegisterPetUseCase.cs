using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestRegisterPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 6,
            Name = request.Name,
        };
    }
}
