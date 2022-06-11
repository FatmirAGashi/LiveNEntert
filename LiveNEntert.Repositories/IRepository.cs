using LiveNEntert.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveNEntert.Repositories
{
    public interface IRepository
    {
        Summary GenerateString(int num1, int num2, Summary sum);
    }
}
