using System;
using System.Collections.Generic;

#nullable disable

namespace whishListG5.Domains
{
    public partial class Desejo
    {
        public int IdDesejo { get; set; }
        public int? IdUsuario { get; set; }
        public string Desejo1 { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
