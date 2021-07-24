using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Request
    {
        public Guid id { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhone { get; set; }
        public string ChildName { get; set; }
        public int ChildAge { get; set; }
        public string ChildKnowledge { get; set; }
        public string ChildHobby { get; set; }
        public string FavouriteCharacter { get; set; }
        public string ThingsNotLike { get; set; }

    }
}
