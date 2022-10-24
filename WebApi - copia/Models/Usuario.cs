using WebApi.Models.Base;

namespace WebApi.Models;

public class Usuario: Model
{
    public string? Name {get; set;}

    public string? LastName {get; set;}

    public virtual IList<Prestamo>? Prestamos { get; set; } = default!;
    
    
}

// {
//   "createdOn": "2022-10-20T02:04:09.470Z",
//   "updatedOn": "2022-10-20T02:04:09.470Z",
//   "name": "Argel ",
//   "lastName": "Cano",
// }

