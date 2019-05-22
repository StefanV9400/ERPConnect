using System;

namespace ERPConnect.API.Dtos
{
    public class UserForListDto
    {
         public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
    }
}