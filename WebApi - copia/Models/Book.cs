using WebApi.Models.Base;

namespace WebApi.Models;

public class Book: Model
{
    public string? Name {get; set; }

    public int? AuthorId {get; set;}

    public int? EditorialId {get; set;}

    public DateTime ReleaseDate {get; set;}

    public virtual Author? Author { get; set;} = default!;

    public virtual Editorial? Editorial { get; set;} = default!;
    
}


// {
//   "name": "Argel",
//   "AuthorId": 1,
//   "EditorialId": 1,
//   "ReleaseDate": "2022-10-20T01:51:56.370Z",
//   "createdOn": "2022-10-20T01:51:56.370Z",
//   "updatedOn": "2022-10-20T01:51:56.370Z",
// }