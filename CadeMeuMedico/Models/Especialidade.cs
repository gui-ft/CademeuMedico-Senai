﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models {
    public class Especialidade {
        public int EspecialidadeID { get; set; }
        [Required]
        public string Nome { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}