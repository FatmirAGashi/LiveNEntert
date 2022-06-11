using AutoMapper;
using LiveNEntert.Api.OutputModels;
using LiveNEntert.Domain;
using LiveNEntert.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveNEntert.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SummaryController : Controller
    {
        private readonly ISummaryService _summaryService;
        private readonly ILogger<SummaryController> _logger;
        private readonly IMapper _mapper;

        public SummaryController(ISummaryService summaryService, 
                                    ILogger<SummaryController> logger,
                                    IMapper mapper)
        {
            _summaryService = summaryService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public LiveNationOutput GetSummary([FromQuery] int a, int b)
        {
            var sum = new Summary();
            var payload = _summaryService.GetSummary(a, b, sum);
            return _mapper.Map<LiveNationOutput>(payload);
        }
    }
}
