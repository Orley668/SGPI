using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Pago
    {
        public Pago()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdPago { get; set; }
        public int ValorPago { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }


        create proc categoria_existe
        @valor varchar(100),
@existe bit output
as
       if exists(select nombre from categoria where categoria = ltrim(rtrim(@valor)))
             begin
              set @existe=1
             end
       else
             begin
              set @existe=0
             end
    }
}
