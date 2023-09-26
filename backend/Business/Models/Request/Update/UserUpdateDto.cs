<<<<<<< HEAD
﻿using Infrastructure.Data.Postgres.Entities;
using System;
=======
﻿using System;
>>>>>>> f56b32d180c53771a9bde59e09330d49110d3711
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UserUpdateDto
    {
        public string Email { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string FullName { get; set; } = default!;
<<<<<<< HEAD
        public UserType UserType { get; set; } = UserType.Mentor;
=======
>>>>>>> f56b32d180c53771a9bde59e09330d49110d3711
    }
}
