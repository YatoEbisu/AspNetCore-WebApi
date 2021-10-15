using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infra.Data
{
    public static class Settings
    {
        public static Guid Secret { get; set; } = new Guid("781ba00c-5b8d-4218-8ce0-dfea3a523bb0");
    }
}
