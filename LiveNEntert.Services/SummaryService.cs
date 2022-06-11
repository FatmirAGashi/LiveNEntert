using LiveNEntert.Domain;
using LiveNEntert.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveNEntert.Services
{
    public class SummaryService : ISummaryService
    {
        private readonly IRepository _repository;

        public SummaryService(IRepository repository)
        {
            _repository = repository;
        }

        public Summary GetSummary(int a, int b, Summary summary)
        {
            return _repository.GenerateString(a, b, summary);
        }
    }
}
