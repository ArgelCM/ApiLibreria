using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{
    public string? Name {get; set; }

    public int? BookId {get; set;}

    public int? UsuarioId {get; set;}

    public DateTime ReleaseDate {get; set;}

    public virtual Book? Books { get; set;} = default!;

    public virtual Usuario? Usuario { get; set;} = default!;

   



}


// {
//   "name": "Argel",
//   "AuthorId": 1,
//   "EditorialId": 1,
//   "ReleaseDate": "2022-10-20T01:51:56.370Z",
//   "createdOn": "2022-10-20T01:51:56.370Z",
//   "updatedOn": "2022-10-20T01:51:56.370Z",
// }